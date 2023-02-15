using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Bücherei_Windows_App
{
    public partial class User_Add_UC : UserControl
    {
        public User_Add_UC()
        {
            InitializeComponent();
        }
        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void exit_label_MouseEnter(object sender, EventArgs e)
        {
            exit_label.ForeColor = Color.Red;
        }

        private void exit_label_MouseLeave(object sender, EventArgs e)
        {
            exit_label.ForeColor = Color.Black;
        }

        private void User_Add_UC_Load(object sender, EventArgs e)
        {
            this.Location = new Point(260, 0);
        }
        public class PasswordEncryption
        {
            public static string HashSHA256(string password)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }
                    return builder.ToString();
                }
            }
        }
        private void new_user_create_Click(object sender, EventArgs e)
        {
            if (new_email_tb.Text == new_email_check_tb.Text)
            {
                if (new_email_tb.Text != "")
                {
                    if (new_password_tb.Text == new_password_check_tb.Text)
                    {
                        if (new_password_tb.Text != "")
                        {
                            string hashedPassword = PasswordEncryption.HashSHA256(new_password_tb.Text);

                            String UserType = "admin";

                            string connstringceck = "server=localhost;uid=root;pwd=;database=lms_db";

                            using (MySqlConnection connection = new MySqlConnection(connstringceck))
                            {
                                connection.Open();
                                try
                                {

                                    string query = "INSERT INTO app_users (first_name, last_name, email, password, user_type) VALUES (@firstname, @lastname, @email, @password, @usertype)";

                                    using (MySqlCommand command = new MySqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@firstname", last_name_tb.Text);
                                        command.Parameters.AddWithValue("@lastname", first_name_tb.Text);
                                        command.Parameters.AddWithValue("@email", new_email_tb.Text);
                                        command.Parameters.AddWithValue("@password", hashedPassword);
                                        command.Parameters.AddWithValue("@usertype", UserType);
                             
                                        if (command.ExecuteNonQuery() == 1)
                                        {
                                            MessageBox.Show("Nutzer erfolgreich angelegt", "DATA WAS UPDATETD");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error 404!", "DATA NOT UPDATED");
                                        }
                                    }

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                connection.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password eingabe darf nicht leer sein!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Email eingabe darf nicht leer sein!");
                }
            }
        }
    }
}
