# TODO: Restrict UserControls Based on user_type from app_users

## 1. Store user_type after login
- [ ] After successful login, retrieve the `user_type` from the `app_users` table for the logged-in user.
- [ ] Store the `user_type` in a static class (e.g., `Session.UserType`).

## 2. Restrict access to UserControls
- [ ] Before opening or creating restricted UserControls (e.g., `Item_add_UC`, `User_Add_UC`, `Userlist_UC`), check if `Session.UserType` is allowed.
- [ ] If not allowed, show a MessageBox with an access denied message and do not open the control.

## 3. (Optional) Hide UI elements for unauthorized users
- [ ] On dashboard/form load, hide or disable buttons/menus for restricted UserControls if `Session.UserType` is not allowed.

## 4. Example Implementation
- [ ] Create a static `Session` class to hold the current user's type.
- [ ] Add user type check in event handlers for opening restricted UserControls.
- [ ] (Optional) Hide or disable UI elements based on user type.

---

# TODO: Mobile Device Support with .NET MAUI

## 1. Create a new MAUI project
- [ ] In Visual Studio, create a new **.NET MAUI App** project (e.g., “Bücherei_MAUI_App”).
- [ ] Select target platforms: Android, iOS, Windows, macOS.

## 2. Outsource shared logic
- [ ] Move business logic (e.g., database access, models, services) into a .NET Standard library (e.g., “Bücherei_Shared”).
- [ ] Reference this library in both the WinForms and MAUI projects.

## 3. Recreate UI for MAUI
- [ ] Rebuild the user interface using XAML and MAUI controls.
- [ ] Reimplement existing UserControls as MAUI Pages/Views.

## 4. Check database connectivity
- [ ] Check if MySQL access works on mobile platforms (if necessary, use REST API or SQLite as an alternative).
- [ ] Adapt connection logic for mobile platforms.

## 5. Consider platform-specific features
- [ ] Implement mobile-specific features (e.g., file access, camera) using MAUI APIs.

## 6. Shared project structure
- [ ] Structure: WinForms project, MAUI project, shared library.

## Notes
- UI code (Forms, UserControls) cannot be reused 1:1.
- MAUI requires .NET 8 or newer.
- For iOS/macOS development, a Mac with Xcode is required.

---

# TODO: Feature Suggestions for the Library App

## 1. Advanced User Management
- [ ] Role and permission management (e.g., "Staff", "Reader", "Admin")
- [ ] Password reset / "Forgot password" functionality
- [ ] User activity log (who did what and when)

## 2. Notifications & Reminders
- [ ] Automatic email notifications for due or overdue loans
- [ ] In-app reminders for returns

## 3. Search and Filter Functions
- [ ] Advanced search by title, author, user, loan status, etc.
- [ ] Filters for available, borrowed, or reserved items

## 4. Statistics & Reports
- [ ] Analytics: most borrowed books, active users, loan history
- [ ] Export as PDF/Excel

## 5. Barcode/QR Code Support
- [ ] Scan items and user cards via camera or external scanner
- [ ] Generate barcodes/QR codes for items and users

## 6. Reservation System
- [ ] Allow users to reserve items in advance
- [ ] Manage waiting lists

## 7. Multilingual Support
- [ ] Support for multiple languages (e.g., English/German)

## 8. Mobile Features (for MAUI)
- [ ] Push notifications
- [ ] Offline mode with synchronization

## 9. Data Backup & Restore
- [ ] Backup and restore functionality for the database

## 10. Accessibility
- [ ] Screen reader support, high contrast, keyboard navigation

---

# TODO: UI Modernization
  
## 1. Rework UI into a more modern style
- [ ] Update forms and UserControls to use a modern, clean, and consistent design.
- [ ] Consider using modern UI frameworks or libraries (e.g., Guna.UI2, Fluent UI, or custom styles).
- [ ] Improve responsiveness and usability for different screen sizes.
- [ ] Enhance visual hierarchy, spacing, and accessibility.
- [ ] Review color scheme, icons, and typography for a contemporary look.

