using System;
using System.Security.Cryptography;

namespace linapot
{
    /// <summary>
    /// Hashes and verifies passwords with PBKDF2 (HMAC-SHA256) and a random per-user salt.
    /// Stored format: PBKDF2$iterations$base64(salt)$base64(hash)
    /// </summary>
    public static class PasswordHasher
    {
        private const string Prefix = "PBKDF2";
        private const int SaltSize = 16;       // 128-bit salt
        private const int HashSize = 32;       // 256-bit derived key
        private const int Iterations = 100000;

        public static string Hash(string password)
        {
            if (password == null) throw new ArgumentNullException(nameof(password));

            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash = Derive(password, salt, Iterations);
            return string.Join("$", Prefix, Iterations.ToString(),
                Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public static bool Verify(string password, string stored)
        {
            if (password == null || string.IsNullOrWhiteSpace(stored)) return false;

            stored = stored.Trim();

            // Legacy plain-text value from before hashing was introduced.
            if (!IsHashed(stored))
            {
                return FixedTimeEquals(
                    System.Text.Encoding.UTF8.GetBytes(password),
                    System.Text.Encoding.UTF8.GetBytes(stored));
            }

            string[] parts = stored.Split('$');
            if (parts.Length != 4) return false;

            int iterations;
            if (!int.TryParse(parts[1], out iterations) || iterations <= 0) return false;

            byte[] salt, expected;
            try
            {
                salt = Convert.FromBase64String(parts[2]);
                expected = Convert.FromBase64String(parts[3]);
            }
            catch (FormatException)
            {
                return false;
            }

            byte[] actual = Derive(password, salt, iterations, expected.Length);
            return FixedTimeEquals(actual, expected);
        }

        /// <summary>True when the stored value is a hash rather than legacy plain text.</summary>
        public static bool IsHashed(string stored)
        {
            return stored != null && stored.Trim().StartsWith(Prefix + "$", StringComparison.Ordinal);
        }

        /// <summary>Generates a random temporary password for new accounts.</summary>
        public static string GenerateTemporaryPassword(int length = 12)
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789";
            byte[] data = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(data);
            }

            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[data[i] % chars.Length];
            }
            return new string(result);
        }

        private static byte[] Derive(string password, byte[] salt, int iterations, int size = HashSize)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(size);
            }
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length) return false;
            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }
    }
}
