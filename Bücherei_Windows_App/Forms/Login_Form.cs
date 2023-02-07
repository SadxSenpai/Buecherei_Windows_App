using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bücherei_Windows_App.Forms
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
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

        private void login_button_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=;database=lms_db";
            MySqlConnection con = new MySqlConnection();
            con.ConnectionString = connstring;

            string connectionString = "server=localhost;uid=root;pwd=;database=lms_db";
            string select = "SELECT email, password FROM app_users " +
                            "WHERE email = @email";

            using (MySqlConnection Conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(select, Conn))
                {
                    cmd.Parameters.AddWithValue("@email", email_input.Text);

                    Conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string email = reader.GetString(0);
                            string password = reader.GetString(1);
                            if (password == password_input.Text)
                            {
                                dashF.Enabled = true;
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Login Error", "Incorrect username or password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Login Error", "Incorrect username or password.");
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
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string sql = "select * from lms_db.app_users";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show("Name " + reader["email"] + "Password " + reader["password"]);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
