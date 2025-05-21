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

**Example for Session class:**

	public static class Session { public static string UserType { get; set; } }


**Example for access check in Dashboard_Form:**

	private void new_user_Click(object sender, EventArgs e)
	{

		//Only allow admins to open the add user control

		if (Session.UserType != "admin")
		{

		MessageBox.Show("You do not have permission to add new users.", "Access Denied"); return;

		}

		Close_all_UC();
		user_Add_uc1 = new User_Add_UC();
		Controls.Add(user_Add_uc1);
		user_Add_uc1.BringToFront();
	}

**Example for hiding UI elements:**

	// Call this after login or on form load

	if (Session.UserType != "admin")
	{
	// Hide or disable other restricted controls as needed

		new_user.Visible = false;
		book_add_new.Visible = false;
		user_list.Visible = false;
	}