using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Item_In_UC : System.Windows.Forms.UserControl
    {
        public Item_In_UC() => InitializeComponent();

        // Methode zum Schließen des UserControls
        // Method to close the UserControl
        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        // Methode zum Ändern der Schriftfarbe beim Hovern
        // Method to change the font color on hover
        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        // Methode zum Zurücksetzen der Schriftfarbe beim Verlassen
        // Method to reset the font color on leave
        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        // Methode, die beim Laden des UserControls ausgeführt wird
        // Method executed when the UserControl is loaded
        void Book_In_UC_Load(object sender, EventArgs e)
        {
            Location = new Point(260, 27);

            // Aktuelles Datum und Uhrzeit abrufen
            // Get the current date and time
            var today = DateTime.Now;

            // Datum in das gewünschte Format umwandeln
            // Format the date to the desired format
            var todayString = today.ToString("dd/MM/yyyy");

            today_date_label.Text = todayString;

            var connstring = DBCon.dbConnection;
            var con = new MySqlConnection(connstring);
            con.Open();

            var cmd = new MySqlCommand("SELECT item_with_who FROM out_of_house", con);
            var reader = cmd.ExecuteReader();

            // Daten aus der Datenbank lesen und in die ComboBox einfügen
            // Read data from the database and insert it into the ComboBox
            while (reader.Read())
            {
                var name = reader.GetString("item_with_who");

                if (!user_name_cb.Items.Contains(name))
                {
                    user_name_cb.Items.Add(name);
                }
            }
        }

        // Methode, die beim Entsorgen des UserControls ausgeführt wird
        // Method executed when the UserControl is disposed
        void OnDispose(object sender, EventArgs e) => Disposed += OnDispose;

        // Methode, die ausgeführt wird, wenn ein Benutzername ausgewählt wird
        // Method executed when a username is selected
        void user_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_name_cb.Items.Clear();

            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selecteduser = user_name_cb.SelectedItem.ToString();

            // MySQL SELECT-Abfrage basierend auf dem ausgewählten Benutzer ausführen
            // Execute a MySQL SELECT query based on the selected user
            var query = "SELECT item_name FROM out_of_house WHERE item_with_who = '" + selecteduser + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Daten aus der ausgewählten Zeile lesen und anzeigen
            // Read and display the data from the selected row
            while (reader.Read())
            {
                var name = reader.GetString("item_name");

                if (!item_name_cb.Items.Contains(name))
                {
                    item_name_cb.Items.Add(name);
                }
            }
        }

        // Methode, die ausgeführt wird, wenn ein Artikelname ausgewählt wird
        // Method executed when an item name is selected
        void item_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selecteditem = item_name_cb.SelectedItem.ToString();

            // MySQL SELECT-Abfrage basierend auf dem ausgewählten Artikel ausführen
            // Execute a MySQL SELECT query based on the selected item
            var query = "SELECT item_note, item_type FROM out_of_house WHERE item_name = '" + selecteditem + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Daten aus der ausgewählten Zeile lesen und anzeigen
            // Read and display the data from the selected row
            while (reader.Read())
            {
                item_note_tb.Text = reader["item_note"].ToString();
                item_type_tb.Text = reader["item_type"].ToString();
            }
        }

        // Methode, die ausgeführt wird, wenn der Rückgabe-Button geklickt wird
        // Method executed when the return button is clicked
        void item_in_finish_btn_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob ein Artikel in der ComboBox ausgewählt ist
            // Checking if an item is selected in the ComboBox
            if (item_name_cb.SelectedIndex != -1)
            {
                // Ausgewählten Artikel aus der ComboBox abrufen
                // Retrieving the selected item from the ComboBox
                var selecteditem2 = item_name_cb.SelectedItem.ToString();

                var delquery = "DELETE FROM out_of_house WHERE item_name= '" + selecteditem2 + "'";

                var connstring = DBCon.dbConnection;
                var con = new MySqlConnection(connstring);

                con.Open();

                // Abfrage ausführen
                // Execute query
                var cmd2 = new MySqlCommand(delquery, con);

                // Überprüfen, ob die Abfrage erfolgreich war
                // Check if the query was successful
                if (cmd2.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Der Artikel wurde erfolgreich zurückgegeben!");
                    // The item has been successfully returned!

                    // Artikelanzahl im Hauptinventar um 1 erhöhen
                    // Update item count in main inventory to +1
                    var selecteditem3 = item_name_cb.SelectedItem.ToString();
                    var updateQuery = "UPDATE main_inventory SET item_count = item_count + 1 WHERE item_name = '" + selecteditem3 + "'";
                    var cmd3 = new MySqlCommand(updateQuery, con);
                    cmd3.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten. Der Artikel konnte nicht zurückgegeben werden.");
                    // An error occurred. The item could not be returned.
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Artikel aus der ComboBox aus.");
                // Please select an item from the ComboBox.
            }
        }
    }
}