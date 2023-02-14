using MySql.Data.MySqlClient;
using System.ComponentModel;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Reflection.Metadata.BlobBuilder;
using System.Windows.Forms;
using System.Security.Cryptography;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Text;
using System.Diagnostics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Bücherei_Windows_App.Forms
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        public void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label_close_MouseEnter(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Red;
        }

        private void label_close_MouseLeave(object sender, EventArgs e)
        {
            label_close.ForeColor = Color.Black;
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void email_input_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (email_input.Text.Length > 0 && email_input.Text.Trim().Length != 0)
            {
                if (!rEmail.IsMatch(email_input.Text.Trim()))
                {
                    email_input.ForeColor = Color.Red;
                    MessageBox.Show("Das ist keine Email");
                    email_input.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    email_input.ForeColor = Color.Black;
                }
            }
        }
        //Manipulattion des Dashboards via Loginscreen
        private Dashboard_Form dashF = null;
        public Login_Form(Dashboard_Form SourceForm)
        {
            dashF = SourceForm as Dashboard_Form;
            InitializeComponent();
        }

        public static class HashSHA256
        {
            public static string ComputeHash(string input)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string enteredPassword = password_input.Text;
            string hashedPassword = HashSHA256.ComputeHash(enteredPassword);

            string connectionString = "server=localhost;uid=root;pwd=;database=lms_db";
            string query = "SELECT email, password FROM app_users WHERE email = @email";

            using (MySqlConnection Conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("@email", email_input.Text);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    Conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string email = reader.GetString(0);
                            string password = reader.GetString(1);

                            if (email == email_input.Text)
                            {
                                if (password == hashedPassword)
                                {
                                    dashF.Enabled = true;
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect username or password.", "Login Error 3");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password.", "Login Error 2");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password.", "Login Error 1");
                        }
                    }

                    Conn.Close();
                }
            }
        }

        public void testSQL_Click(object sender, EventArgs e)
        {
            try
            {

                string connstring = "server=localhost;uid=root;pwd=;database=lms_db";
                string querycheck = "SELECT * FROM books";

                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(querycheck, con))
                    {

                        con.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            MessageBox.Show("SQL verbindung erfolgreich");
                        }
                        else
                        {
                            MessageBox.Show("SQL verbindung fehlgeschlagen");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cattobox_MouseEnter(object sender, EventArgs e)
        {
            cattobox.Image = Properties.Resources.BongoCat;

        }

        private void cattobox_MouseLeave(object sender, EventArgs e)
        {
            cattobox.Image = Properties.Resources.Transparent;
        }
    }
}
