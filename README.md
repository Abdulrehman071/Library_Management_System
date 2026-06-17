# Library_Management_system

A C# WinForms desktop application for managing library books, members, and borrow records.

---

## Project Structure

```
Library_Management_system/
├── LibraryMS.sln                        ← Open this in Visual Studio
├── SetupDatabase.sql                    ← Optional: run in SSMS for sample data
│
├── LibraryMS.Core/                      ← Class library (models, services, interfaces)
│   ├── Models/
│   │   ├── Book.cs
│   │   ├── Member.cs
│   │   └── Borrow.cs                   ← NEW: Borrow record model
│   ├── Contracts/
│   │   ├── IBookService.cs
│   │   ├── IMemberService.cs
│   │   └── IBorrowService.cs           ← NEW: Borrow service interface
│   ├── Services/
│   │   ├── DbBookService.cs
│   │   ├── DbMemberService.cs
│   │   └── DbBorrowService.cs          ← NEW: Full SQL borrow implementation
│   └── Utilities/
│       ├── BookStatusEnum.cs
│       └── BookCategoryEnum.cs
│
└── LibraryMS.App/                       ← WinForms application
    ├── App.config                       ← Edit connection string here
    ├── Program.cs
    ├── Forms/
    │   ├── MainForm.cs / Designer.cs
    │   ├── BookForm.cs / Designer.cs
    │   ├── MemberForm.cs / Designer.cs
    │   ├── IssueBookForm.cs / Designer.cs   ← NEW: Issue book dialog
    │   └── ReturnBookForm.cs / Designer.cs  ← NEW: Return book dialog
    └── Views/
        ├── DashboardView.cs / Designer.cs   ← UPDATED: 2 new stat cards
        ├── BookView.cs / Designer.cs        ← UPDATED: filters moved below toolbar
        ├── MemberView.cs / Designer.cs      ← UPDATED: search moved below toolbar
        └── BorrowView.cs / Designer.cs      ← NEW: Borrow records view
```

---

## Setup Steps

### 1. Database — Auto Created on First Run
The application automatically creates the `LibraryDB` database and all tables
(`Book`, `Member`, `Borrow`) when you run it for the first time using LocalDB.
**No manual SQL script needed.**

### 2. Set the Connection String
Edit `LibraryMS.App/App.config` if needed:

```xml
<add name="LibraryDB"
     connectionString="Server=(localdb)\MSSQLLocalDB;Database=LibraryDB;Integrated Security=True;TrustServerCertificate=True"
     providerName="Microsoft.Data.SqlClient" />
```

Common values for `Server`:
- `(localdb)\MSSQLLocalDB` — LocalDB (default, no SQL Server install needed)
- `.\SQLEXPRESS` — SQL Server Express named instance
- `PCNAME\SQLEXPRESS` — named instance on a specific machine
- `localhost` — full SQL Server with SQL Auth

### 3. Open in Visual Studio
Open `LibraryMS.sln` in Visual Studio 2022 (or newer).
Target framework is **.NET 8.0 (Windows)**.

### 4. Build & Run
Press **F5** or Ctrl+F5. The app validates the DB connection on startup and
creates any missing tables automatically.

---

## Features

### Dashboard
| Card             | Description                              |
|------------------|------------------------------------------|
| Total Books      | Count of all books in the library        |
| Available        | Books with status = Available            |
| Borrowed         | Books currently checked out              |
| Members          | Total registered members                 |
| Active Borrows   | Currently active borrow records          |
| Overdue          | Borrows past their due date (shown red)  |

Also displays a **Recent Books** grid listing all books with title, author, status, and category.

---

### Book Management (CRUD)
| Operation        | Description                              |
|------------------|------------------------------------------|
| Add Book         | Open Add Book form and save to DB        |
| Edit Book        | Edit selected book (also via double-click)|
| Delete Book      | Delete with confirmation dialog          |
| View / Refresh   | Reload all books from database           |
| Search           | Filter by title, author, or ISBN         |
| Filter Category  | Dropdown filter by book category         |
| Filter Status    | Dropdown filter by book status           |

**Book Fields:** Book ID · Title · Author · ISBN · Category · Status · Copies · Year

> Search, Category, and Status filters are placed in a dedicated filter panel
> **below** the CRUD toolbar for a cleaner layout.

---

### Member Management (CRUD)
| Operation        | Description                              |
|------------------|------------------------------------------|
| Add Member       | Open Add Member form and save to DB      |
| Edit Member      | Edit selected member (also via double-click)|
| Delete Member    | Delete with confirmation dialog          |
| View / Refresh   | Reload all members from database         |
| Search           | Filter by name, phone, or email          |

**Member Fields:** Member ID · Name · Phone · Email · Address

> Search is placed in a dedicated filter panel **below** the CRUD toolbar.

---

### Borrow Management ← NEW
| Operation        | Description                                          |
|------------------|------------------------------------------------------|
| Issue Book       | Select book + member, set issue date and due date    |
| Return Book      | Select active record, confirm return date            |
| Search           | Filter by book title or member name                  |
| Filter Status    | All / Active / Returned / Overdue                    |
| Refresh          | Reload all borrow records                            |

**Borrow Fields:** Borrow ID · Book Title · Member · Issue Date · Due Date · Return Date · Status

**How Issue Book works:**
1. Click **+ Issue Book** in the Borrows toolbar
2. Select an available book from the dropdown (only available books shown)
3. Select the member
4. Set Issue Date and Due Date (default: today + 14 days)
5. Click **Issue Book** — the book status automatically changes to `Borrowed`

**How Return Book works:**
1. Select the active borrow row in the grid (or double-click it)
2. Click **Return Book** in the toolbar
3. Confirm the return date
4. Click **Return Book** — the book status automatically resets to `Available`

**Overdue detection:**
- Active borrows past their due date are **highlighted in red** in the grid
- The Dashboard shows a dedicated **Overdue** count card
- The Return Book dialog shows an overdue warning with the number of days late

> Both Issue and Return operations run inside a **SQL transaction** to keep
> the Borrow record and Book status always in sync.

---

## Database Tables

```sql
Book    -- Id, Title, Author, ISBN, Category, Status, Copies, Year
Member  -- Id, Name, Phone, Email, Address
Borrow  -- Id, BookId (FK), MemberId (FK), IssueDate, DueDate, ReturnDate, Status
```

Tables are created automatically on first launch if they do not exist.

---

## UI Layout

- **Sidebar** (left): Dashboard · Books · Members · Borrows navigation buttons
- **ToolStrip** (top of each view): CRUD action buttons only
- **Filter Panel** (below title): Search box + dropdowns — separate from the toolbar
- **DataGridView** (main area): Fills remaining space, resizes with the window

---

## Architecture

```
LibraryMS.Core          (no UI dependency)
  Models/               Plain C# model classes
  Contracts/            Interface definitions (IBookService, IMemberService, IBorrowService)
  Services/             SQL Server implementations (DbBookService, DbMemberService, DbBorrowService)
  Utilities/            Enums (BookStatusEnum, BookCategoryEnum)

LibraryMS.App           (WinForms, references Core)
  Forms/                Modal dialogs (Add/Edit/Issue/Return)
  Views/                UserControls hosted inside MainForm's content panel
  Program.cs            Entry point
  App.config            Connection string
```
"# -Library-Management-System" 
