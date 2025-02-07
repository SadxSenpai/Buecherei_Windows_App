using System.Runtime.InteropServices;

namespace Bücherei_Windows_App.Forms
{
    public partial class Dashboard_Form : Form
    {

        public Dashboard_Form()
        {

            InitializeComponent();
        }
        //Dasboard window button bar visuals
        void exit_dash_label_Click(object sender, EventArgs e) => Application.Exit();

        void exit_dash_label_MouseEnter(object sender, EventArgs e)
        {
            exit_dash_label.ForeColor = Color.Red;
        }

        void exit_dash_label_MouseLeave(object sender, EventArgs e) => exit_dash_label.ForeColor = Color.White;

        void mini_dash_label_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void mini_dash_label_MouseEnter(object sender, EventArgs e)
        {
            mini_dash_label.ForeColor = Color.Red;
        }

        void mini_dash_label_MouseLeave(object sender, EventArgs e)
        {
            mini_dash_label.ForeColor = Color.White;
        }

        void Dashboard_Form_Load(object sender, EventArgs e)
        {
            //set dashboard form as shadowform
            guna2ShadowForm1.SetShadowForm(this);

            this.EnableBlur();
            TransparencyKey = Color.LimeGreen;

            // Hide UserControls on Load

            Controls.Remove(itemout_uc1);
            itemout_uc1.Dispose();
            itemout_uc1 = null;

            Controls.Remove(booklist_uc1);
            booklist_uc1.Dispose();
            booklist_uc1 = null;

            Controls.Remove(book_add_uc1);
            book_add_uc1.Dispose();
            book_add_uc1 = null;

            Controls.Remove(book_Out_uc1);
            book_Out_uc1.Dispose();
            book_Out_uc1 = null;

            Controls.Remove(book_In_uc1);
            book_In_uc1.Dispose();
            book_In_uc1 = null;

            Controls.Remove(userlist_uc1);
            userlist_uc1.Dispose();
            userlist_uc1 = null;

            Controls.Remove(user_Add_uc1);
            user_Add_uc1.Dispose();
            user_Add_uc1 = null;

            Controls.Remove(book_Del_uc1);
            book_Del_uc1.Dispose();
            book_Del_uc1 = null;
        }

        void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            Enabled = false;

            // showing Login Form
            var logf = new Login_Form(this);
            logf.BringToFront();
            logf.Show();
        }

        void Books_list_Click(object sender, EventArgs e)
        {
            booklist_uc1 = new Itemlist_UC();
            Controls.Add(booklist_uc1);
            booklist_uc1.BringToFront();

            // Schließe andere UCs
            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        void Ausleih_button_Click(object sender, EventArgs e)
        {
            book_Out_uc1 = new Item_Out_UC();
            Controls.Add(book_Out_uc1);
            book_Out_uc1.BringToFront();

            // Schließe andere UCs
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        void Rueckgabe_button_Click(object sender, EventArgs e)
        {
            book_In_uc1 = new Item_In_UC();
            Controls.Add(book_In_uc1);
            book_In_uc1.BringToFront();

            // Schließe andere UCs
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        void User_list_Click(object sender, EventArgs e)
        {
            userlist_uc1 = new Userlist_UC();
            Controls.Add(userlist_uc1);
            userlist_uc1.BringToFront();

            // Schließe andere UCs
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        void book_add_new_Click(object sender, EventArgs e)
        {
            book_add_uc1 = new Item_add_UC();
            Controls.Add(book_add_uc1);
            book_add_uc1.BringToFront();

            // Schließe andere UCs
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        void new_user_Click(object sender, EventArgs e)
        {
            user_Add_uc1 = new User_Add_UC();
            Controls.Add(user_Add_uc1);
            user_Add_uc1.BringToFront();

            // Schließe andere UCs
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }

        void book_delete_Click(object sender, EventArgs e)
        {
            book_Del_uc1 = new Item_Del_UC();
            Controls.Add(book_Del_uc1);
            book_Del_uc1.BringToFront();

            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

            if (itemout_uc1 != null)
            {
                Controls.Remove(itemout_uc1);
                itemout_uc1.Dispose();
                itemout_uc1 = null;
            }
        }
        private void itemout_list_Click(object sender, EventArgs e)
        {
            itemout_uc1 = new Itemout_UC();
            Controls.Add(itemout_uc1);
            itemout_uc1.BringToFront();

            // close every other Usercontrol
            if (booklist_uc1 != null)
            {
                Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }

            if (book_Del_uc1 != null)
            {
                Controls.Remove(book_Del_uc1);
                book_Del_uc1.Dispose();
                book_Del_uc1 = null;
            }

            if (book_Out_uc1 != null)
            {
                Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }

            if (book_In_uc1 != null)
            {
                Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }

            if (userlist_uc1 != null)
            {
                Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }

            if (book_add_uc1 != null)
            {
                Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }

            if (user_Add_uc1 != null)
            {
                Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }
        }
        //Sekrit Doge huehue
        void dogebox_MouseEnter(object sender, EventArgs e)
        {
            dogebox.Image = Properties.Resources.doge;
        }

        void dogebox_MouseLeave(object sender, EventArgs e)
        {
            dogebox.Image = Properties.Resources.Transparent;
        }

        // Topbar mouse "Drag" funktion um die Anwendeung zu verschieben
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        void Topbar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }

    public static class WindowExtension
    {
        [DllImport("user32.dll")]
        static internal extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

        public static void EnableBlur(this Form @this)
        {
            var accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;
            var accentStructSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);
            var Data = new WindowCompositionAttributeData();
            Data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            Data.SizeOfData = accentStructSize;
            Data.Data = accentPtr;
            SetWindowCompositionAttribute(@this.Handle, ref Data);
            Marshal.FreeHGlobal(accentPtr);
        }
    }

    enum AccentState
    {
        ACCENT_ENABLE_BLURBEHIND = 3
    }

    struct AccentPolicy
    {
        public AccentState AccentState;
        public int AccentFlags;
        public int GradientColor;
        public int AnimationId;
    }

    struct WindowCompositionAttributeData
    {
        public WindowCompositionAttribute Attribute;
        public IntPtr Data;
        public int SizeOfData;
    }

    enum WindowCompositionAttribute
    {
        WCA_ACCENT_POLICY = 19
    }
}