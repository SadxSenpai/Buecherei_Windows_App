using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Bücherei_Windows_App
{
    public partial class User_Add_UC : System.Windows.Forms.UserControl
    {
        public User_Add_UC() => InitializeComponent();

        // Event handler for exit label click
        // Ereignis-Handler für Klick auf das Exit-Label
        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        // Event handler for mouse entering the exit label
        // Ereignis-Handler für das Betreten des Exit-Labels mit der Maus
        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        // Event handler for mouse leaving the exit label
        // Ereignis-Handler für das Verlassen des Exit-Labels mit der Maus
        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        // Event handler for User Control load
        // Ereignis-Handler für das Laden des User Controls
        void User_Add_UC_Load(object sender, EventArgs e) => Location = new Point(260, 27);

        public class PasswordEncryption
        {
            // Method to hash a password using SHA256
            // Methode zum Hashen eines Passworts mit SHA256
            public static string HashSHA256(string password)
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                    var builder = new StringBuilder();

                    for (int i = 0; i < bytes.Length; i++)
                        builder.Append(bytes[i].ToString("x2"));

                    return builder.ToString();
                }
            }
        }

        // Event handler for creating a new user
        // Ereignis-Handler zum Erstellen eines neuen Benutzers
        void new_user_create_Click(object sender, EventArgs e)
        {
            if (new_email_tb.Text == new_email_check_tb.Text)
            {
                if (new_email_tb.Text != "")
                {
                    if (new_password_tb.Text == new_password_check_tb.Text)
                    {
                        if (new_password_tb.Text != "")
                        {
                            var hashedPassword = PasswordEncryption.HashSHA256(new_password_tb.Text);

                            var UserType = "admin";

                            var connstringceck = DBCon.dbConnection;

                            using (MySqlConnection connection = new MySqlConnection(connstringceck))
                            {
                                connection.Open();

                                try
                                {
                                    var query = "INSERT INTO app_users (first_name, last_name, email, password, user_type) VALUES (@firstname, @lastname, @email, @password, @usertype)";

                                    using (MySqlCommand command = new MySqlCommand(query, connection))
                                    {
                                        command.Parameters.AddWithValue("@firstname", last_name_tb.Text);
                                        command.Parameters.AddWithValue("@lastname", first_name_tb.Text);
                                        command.Parameters.AddWithValue("@email", new_email_tb.Text);
                                        command.Parameters.AddWithValue("@password", hashedPassword);
                                        command.Parameters.AddWithValue("@usertype", UserType);

                                        if (command.ExecuteNonQuery() == 1)
                                        {
                                            MessageBox.Show("Nutzer erfolgreich angelegt", "DATA WAS UPDATED");
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