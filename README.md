# Linapot: Client Support Tracking System

A Windows desktop application for logging and reporting on client support interactions. Support staff record every engagement with a client, and administrators run filtered reports across clients, staff, request types and date ranges.

## Features

- **Interaction logging:** record the channel (phone call, remote connection, on-site visit) and reason (bug fix, feature request, training request, other) for each client engagement.
- **Reporting:** filter interaction history by client, staff member, request type, reason and date range, displayed in sortable, filterable grids.
- **User accounts:** login, password change, and profile pictures for support staff.
- **Administration:** create staff accounts and client records, with clients linked to locations.
- **Secure credential storage:** passwords are hashed with PBKDF2 (HMAC-SHA256, 100,000 iterations, random per-user salt) and verified in constant time. New accounts receive a random temporary password.

## Tech Stack

| Layer | Technology |
|---|---|
| Language | C# |
| Framework | .NET Framework 4.7.2, Windows Forms |
| Data access | Entity Framework 6.2 (Database First, EDMX), LINQ, ADO.NET typed DataSets |
| Database | Microsoft SQL Server |
| UI components | DG.AdvancedDataGridView |

## Data Model

| Entity | Purpose |
|---|---|
| `personel` | Support staff accounts and credentials |
| `client` | Client companies, linked to a location |
| `location` | Client locations |
| `interaction` | Individual support interactions |
| `data_grid` | Reporting view of interactions |

## Getting Started

### Prerequisites

- Windows with Visual Studio 2019 or later
- .NET Framework 4.7.2
- SQL Server (Express or LocalDB is fine)

### Setup

1. Clone the repository and open `linapot.sln` in Visual Studio.
2. Restore NuGet packages (Visual Studio does this automatically on build).
3. Create a `linasoft` database in SQL Server with the tables described in the data model.
4. Run the scripts in `Database/` against it, in order.
5. Update the connection strings in `App.config` to point at your SQL Server instance.
6. Build and run. The account with `personel_id = 1` is treated as the administrator.

## Security Notes

- Passwords are never stored in plain text. Accounts created before hashing was introduced are upgraded to a hash automatically on their next successful login.
- Connection strings use Windows Integrated Security, so no database credentials are stored in the repository.
