using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App.UserControl
{
    public partial class Item_Extend_UC : System.Windows.Forms.UserControl
    {
        public Item_Extend_UC() => InitializeComponent();

        // Event-Handler für das Klicken auf das Exit-Label
        // Event handler for clicking the exit label
        void exit_label_Click(object sender, EventArgs e)
        {
            // Entfernt dieses UserControl vom Parent-Container
            // Removes this UserControl from the parent container
            Parent.Controls.Remove(this);
            // Gibt die Ressourcen dieses UserControls frei
            // Disposes of the resources of this UserControl
            Dispose();
        }

        // Event-Handler für das MouseEnter-Ereignis des Exit-Labels
        // Event handler for the MouseEnter event of the exit label
        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        // Event-Handler für das MouseLeave-Ereignis des Exit-Labels
        // Event handler for the MouseLeave event of the exit label
        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        // Event-Handler für das Laden des UserControls
        // Event handler for loading the UserControl
        void Item_Extend_UC_Load(object sender, EventArgs e)
        {
            // Setzt die Position des UserControls
            // Sets the position of the UserControl
            Location = new Point(260, 27);

            // Aktuelles Datum und Uhrzeit abrufen
            // Get the current date and time
            var today = DateTime.Now;

            // Datum in das gewünschte Format umwandeln
            // Format the date to the desired format
            var todayString = today.ToString("dd/MM/yyyy");

            item_date_today_tb.Text = todayString;

            // ComboBox mit 7, 14 und 21 Tagen ab dem aktuellen Datum füllen
            // Populate the ComboBox with 7, 14, and 21 days from the current date
            var inDays7 = today.AddDays(7);
            var inDays14 = today.AddDays(14);
            var inDays21 = today.AddDays(21);
            var inDays7String = inDays7.ToString("dd/MM/yyyy");
            var inDays14String = inDays14.ToString("dd/MM/yyyy");
            var inDays21String = inDays21.ToString("dd/MM/yyyy");
            item_date_new_in_cb.Items.Add(inDays7String);
            item_date_new_in_cb.Items.Add(inDays14String);
            item_date_new_in_cb.Items.Add(inDays21String);

            // Verbindet sich mit der Datenbank
            // Connects to the database
            var connstring = DBCon.dbConnection;
            var con = new MySqlConnection(connstring);
            con.Open();

            // Führt eine SQL-Abfrage aus, um die Namen der Artikel zu holen
            // Executes a SQL query to get the item names
            var cmd = new MySqlCommand("SELECT item_name FROM out_of_house", con);
            var reader = cmd.ExecuteReader();

            // Fügt die Namen der Artikel in die ComboBox ein
            // Adds the item names to the ComboBox
            while (reader.Read())
            {
                var name = reader.GetString("item_name");
                item_name_cb.Items.Add(name);
            }
        }
        private void item_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (item_name_cb.SelectedItem != null) // Check for null before dereferencing
            {
                var connString = DBCon.dbConnection;
                var conn = new MySqlConnection(connString);
                conn.Open();

                var selectedValue = item_name_cb.SelectedItem.ToString();

                // MySQL SELECT-Abfrage basierend auf dem ausgewählten Artikel ausführen
                // Execute a MySQL SELECT query based on the selected item
                var query = "SELECT item_type, item_note, item_date_out, item_with_who FROM out_of_house WHERE item_name = '" + selectedValue + "'";
                var cmd = new MySqlCommand(query, conn);
                var reader = cmd.ExecuteReader();

                // Daten aus der ausgewählten Zeile lesen und anzeigen
                // Read and display the data from the selected row
                while (reader.Read())
                {
                    item_type_tb.Text = reader["item_type"]?.ToString() ?? string.Empty; // Null check
                    item_note_tb.Text = reader["item_note"]?.ToString() ?? string.Empty; // Null check
                    item_date_out_tb.Text = reader["item_date_out"]?.ToString() ?? String.Empty; // Null check
                    user_name_tb.Text = reader["item_with_who"]?.ToString() ?? string.Empty; // Null check
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen gültigen Artikel aus der Liste aus.", "Ungültige Auswahl");
            }
        }

        private void book_extend_finish_btn_Click(object sender, EventArgs e)
        {
            if (item_name_cb.SelectedItem == null || item_date_new_in_cb.SelectedItem == null)
            {
                MessageBox.Show("Bitte wählen Sie einen Artikel und ein neues Rückgabedatum aus.", "Fehlende Auswahl");
                return;
            }

            var selectedItem = item_name_cb.SelectedItem.ToString();
            var newDateIn = item_date_new_in_cb.SelectedItem.ToString();

            var connString = DBCon.dbConnection;
            using (var conn = new MySqlConnection(connString))
            {
                conn.Open();
                // Update-Query für das ausgewählte Element
                var query = "UPDATE out_of_house SET item_date_in = @dateIn WHERE item_name = @itemName";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@dateIn", newDateIn);
                    cmd.Parameters.AddWithValue("@itemName", selectedItem);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Das Rückgabedatum wurde erfolgreich verlängert.", "Erfolg");
                    }
                    else
                    {
                        MessageBox.Show("Fehler beim Aktualisieren des Datums.", "Fehler");
                    }
                }
            }
        }
    }
}
