using System.Windows.Forms;

namespace Bücherei_Windows_App.Forms
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            //Load the Usercontrol
            /*
            booklist_uc1 = new Booklist_UC();
            this.Controls.Add(booklist_uc1);

            book_add_uc1 = new Book_add_UC();
            this.Controls.Add(book_add_uc1);

            book_Out_uc1 = new Book_Out_UC();
            this.Controls.Add(book_Out_uc1);

            book_In_uc1 = new Book_In_UC();
            this.Controls.Add(book_In_uc1);

            userlist_uc1 = new Userlist_UC();
            this.Controls.Add(userlist_uc1);

            booklist_uc1 = new Booklist_UC();
            this.Controls.Add(booklist_uc1);
            */


            //Hide UserControls
            this.Controls.Remove(booklist_uc1);
            booklist_uc1.Dispose();
            booklist_uc1 = null;

            this.Controls.Remove(book_add_uc1);
            book_add_uc1.Dispose();
            book_add_uc1 = null;

            this.Controls.Remove(book_Out_uc1);
            book_Out_uc1.Dispose();
            book_Out_uc1 = null;

            this.Controls.Remove(book_In_uc1);
            book_In_uc1.Dispose();
            book_In_uc1 = null;

            this.Controls.Remove(userlist_uc1);
            userlist_uc1.Dispose();
            userlist_uc1 = null;

            this.Controls.Remove(user_Add_uc1);
            user_Add_uc1.Dispose();
            user_Add_uc1 = null;

            this.Controls.Remove(book_Del_uc1);
            book_Del_uc1.Dispose();
            book_Del_uc1 = null;


            //  Side Panel Bilder
            //ausleih_button.Image = Image.FromFile("../../Images/xxx.png");
            //rueckgabe_button.Image = Image.FromFile("../../Images/xxx.png");
            //books_list.Image = Image.FromFile("../../Images/xxx.png");
            //user_list.Image = Image.FromFile("../../Images/xxx.png");
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            // showing Login Form
            Login_Form logf = new Login_Form(this);
            logf.BringToFront();
            logf.Show();
        }

        private void Books_list_Click(object sender, EventArgs e)
        {
            booklist_uc1 = new Booklist_UC();
            this.Controls.Add(booklist_uc1);
            booklist_uc1.BringToFront();


            //Schließe andere UCs
            if (book_Out_uc1 != null)
            {
                this.Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }
            if (userlist_uc1 != null)
            {
                this.Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }
            if (book_In_uc1 != null)
            {
                this.Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }
            if (book_add_uc1 != null)
            {
                this.Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }
            if (user_Add_uc1 != null)
            {
                this.Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }
        }

        private void Ausleih_button_Click(object sender, EventArgs e)
        {
            book_Out_uc1 = new Book_Out_UC();
            this.Controls.Add(book_Out_uc1);
            book_Out_uc1.BringToFront();


            //Schließe andere UCs
            if (booklist_uc1 != null)
            {
                this.Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }
            if (userlist_uc1 != null)
            {
                this.Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }
            if (book_In_uc1 != null)
            {
                this.Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }
            if (book_add_uc1 != null)
            {
                this.Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }
            if (user_Add_uc1 != null)
            {
                this.Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }
        }

        private void Rueckgabe_button_Click(object sender, EventArgs e)
        {
            book_In_uc1 = new Book_In_UC();
            this.Controls.Add(book_In_uc1);
            book_In_uc1.BringToFront();


            //Schließe andere UCs
            if (booklist_uc1 != null)
            {
                this.Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }
            if (userlist_uc1 != null)
            {
                this.Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }
            if (book_Out_uc1 != null)
            {
                this.Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }
            if (book_add_uc1 != null)
            {
                this.Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }
            if (user_Add_uc1 != null)
            {
                this.Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }
        }

        private void User_list_Click(object sender, EventArgs e)
        {
            userlist_uc1 = new Userlist_UC();
            this.Controls.Add(userlist_uc1);
            userlist_uc1.BringToFront();


            //Schließe andere UCs
            if (booklist_uc1 != null)
            {
                this.Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }
            if (book_Out_uc1 != null)
            {
                this.Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }
            if (book_In_uc1 != null)
            {
                this.Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }
            if (book_add_uc1 != null)
            {
                this.Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }
            if (user_Add_uc1 != null)
            {
                this.Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }
        }

        private void book_add_new_Click(object sender, EventArgs e)
        {
            book_add_uc1 = new Book_add_UC();
            this.Controls.Add(book_add_uc1);
            book_add_uc1.BringToFront();


            //Schließe andere UCs
            if (booklist_uc1 != null)
            {
                this.Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }
            if (book_Out_uc1 != null)
            {
                this.Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }
            if (book_In_uc1 != null)
            {
                this.Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }
            if (userlist_uc1 != null)
            {
                this.Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }            
            if (user_Add_uc1 != null)
            {
                this.Controls.Remove(user_Add_uc1);
                user_Add_uc1.Dispose();
                user_Add_uc1 = null;
            }

        }

        private void new_user_Click(object sender, EventArgs e)
        {
            user_Add_uc1 = new User_Add_UC();
            this.Controls.Add(user_Add_uc1);
            user_Add_uc1.BringToFront();


            //Schließe andere UCs
            if (booklist_uc1 != null)
            {
                this.Controls.Remove(booklist_uc1);
                booklist_uc1.Dispose();
                booklist_uc1 = null;
            }
            if (book_Out_uc1 != null)
            {
                this.Controls.Remove(book_Out_uc1);
                book_Out_uc1.Dispose();
                book_Out_uc1 = null;
            }
            if (book_In_uc1 != null)
            {
                this.Controls.Remove(book_In_uc1);
                book_In_uc1.Dispose();
                book_In_uc1 = null;
            }
            if (userlist_uc1 != null)
            {
                this.Controls.Remove(userlist_uc1);
                userlist_uc1.Dispose();
                userlist_uc1 = null;
            }            
            if (book_add_uc1 != null)
            {
                this.Controls.Remove(book_add_uc1);
                book_add_uc1.Dispose();
                book_add_uc1 = null;
            }
        }
    }
}
