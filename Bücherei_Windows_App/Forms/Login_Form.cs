using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using MySql.Data.MySqlClient;

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

            The_Database.DB db = new The_Database.DB();

            string email = email_input.Text;
            string password = password_input.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `app_users` WHERE `email`=@email AND `password`=@pass", db.GetConnection());

            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            // check if user exists
            if (table.Rows.Count > 0)//if exists
            {
                dashF.Enabled = true;
                this.Close();
            }
            else // if not
            {
                // check if email is empty
                if (email.Trim().Equals(""))
                {
                    MessageBox.Show("Keine Email eingabe gefunden!", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // check if (password is empty
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Keine Passwort eingabe gefunden!", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //if this data dosent exist
                else
                {
                    MessageBox.Show("Falsche Email oder Passwort eingabe!", "404", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }
}
