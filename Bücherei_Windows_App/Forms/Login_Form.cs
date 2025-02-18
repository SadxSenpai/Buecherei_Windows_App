using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace Bücherei_Windows_App.Forms
{
    public partial class Login_Form : Form
    {
        // Referenz auf das Dashboard-Formular
        // Reference to the dashboard form
        Dashboard_Form dashF;

        // Konstruktor für das Login-Formular
        // Constructor for the login form
        public Login_Form(Dashboard_Form SourceForm)
        {
            dashF = SourceForm as Dashboard_Form;
            InitializeComponent();
        }

        // Ereignishandler für das Laden des Login-Formulars
        // Event handler for loading the login form
        public void Login_Form_Load(object sender, EventArgs e)
        {
        }

        // Ereignishandler für das MouseEnter-Ereignis des Schließen-Labels
        // Event handler for the MouseEnter event of the close label
        void label_close_MouseEnter(object sender, EventArgs e) => label_close.ForeColor = Color.Red;

        // Ereignishandler für das MouseLeave-Ereignis des Schließen-Labels
        // Event handler for the MouseLeave event of the close label
        void label_close_MouseLeave(object sender, EventArgs e) => label_close.ForeColor = Color.Black;

        // Ereignishandler für das Klicken auf das Schließen-Label
        // Event handler for clicking the close label
        void label_close_Click(object sender, EventArgs e) => Application.Exit();

        // Ereignishandler für die Validierung der E-Mail-Eingabe
        // Event handler for validating the email input
        void email_input_Validating(object sender, CancelEventArgs e)
        {
            // Regex zur Überprüfung der E-Mail-Adresse
            // Regex to validate the email address
            var rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            // Überprüfen, ob die E-Mail-Eingabe nicht leer ist
            // Check if the email input is not empty
            if (email_input.Text.Length > 0 && email_input.Text.Trim().Length != 0)
            {
                // Überprüfen, ob die E-Mail-Adresse dem Regex-Muster entspricht
                // Check if the email address matches the regex pattern
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

        // Statische Klasse zur Berechnung des SHA256-Hashes
        // Static class for computing the SHA256 hash
        public static class HashSHA256
        {
            // Methode zur Berechnung des SHA256-Hashes
            // Method to compute the SHA256 hash
            public static string ComputeHash(string input)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                    var builder = new StringBuilder();

                    for (int i = 0; i < bytes.Length; i++)
                        builder.Append(bytes[i].ToString("x2"));

                    return builder.ToString();
                }
            }
        }

        // Ereignishandler für das Klicken auf den Login-Button
        // Event handler for clicking the login button
        void login_button_Click(object sender, EventArgs e)
        {
            // Setzen des Benutzernamens im Dashboard-Formular
            // Set the username in the dashboard form
            dashF.username_label.Text = "Angemeldet als: " + email_input.Text;

            // Hashen des eingegebenen Passworts
            // Hash the entered password
            var enteredPassword = password_input.Text;
            var hashedPassword = HashSHA256.ComputeHash(enteredPassword);

            // Verbindung zur Datenbank herstellen
            // Establish a connection to the database
            var connectionString = DBCon.dbConnection;
            var query = "SELECT email, password FROM app_users WHERE email = @email";

            using (MySqlConnection Conn = new MySqlConnection(connectionString))
            {
                using (MySqlCommand cmd = new MySqlCommand(query, Conn))
                {
                    cmd.Parameters.AddWithValue("@email", email_input.Text);

                    Conn.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var email = reader.GetString(0);
                            var password = reader.GetString(1);

                            // Überprüfen, ob die E-Mail-Adresse und das Passwort übereinstimmen
                            // Check if the email address and password match
                            if (email == email_input.Text)
                            {
                                if (password == hashedPassword)
                                {
                                    dashF.Enabled = true;
                                    Close();
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

        // Ereignishandler für das Klicken auf den Test-SQL-Button
        // Event handler for clicking the test SQL button
        public void testSQL_Click(object sender, EventArgs e)
        {
            try
            {
                var connstring = DBCon.dbConnection;
                var querycheck = "SELECT * FROM books";

                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    using (MySqlCommand cmd = new MySqlCommand(querycheck, con))
                    {
                        con.Open();
                        var reader = cmd.ExecuteReader();

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

        // Ereignishandler für das MouseEnter-Ereignis der CattoBox
        // Event handler for the MouseEnter event of the CattoBox
        void cattobox_MouseEnter(object sender, EventArgs e)
        {
            cattobox.Image = Properties.Resources.BongoCat;
        }

        // Ereignishandler für das MouseLeave-Ereignis der CattoBox
        // Event handler for the MouseLeave event of the CattoBox
        void cattobox_MouseLeave(object sender, EventArgs e)
        {
            cattobox.Image = Properties.Resources.Transparent;
        }


    }
}