-- Widens personel.password so it can hold PBKDF2 hashes (about 83 characters).
-- Run once against the linasoft database before deploying this version of the app.
-- Existing plain-text passwords keep working and are upgraded to a hash
-- automatically the next time each user logs in.

USE linasoft;
GO

ALTER TABLE dbo.personel
    ALTER COLUMN password NVARCHAR(100) NOT NULL;
GO

-- nchar(20) padded values with trailing spaces; strip them.
UPDATE dbo.personel
    SET password = RTRIM(password);
GO
