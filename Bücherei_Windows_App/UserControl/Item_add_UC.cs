using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Item_add_UC : UserControl
    {
        public Item_add_UC() => InitializeComponent();

        // Event-Handler für das Klicken auf das Exit-Label
        // Event handler for the exit label click event
        void exit_label_Click(object sender, EventArgs e)
        {
            // Entfernt dieses UserControl von seinem Elternteil und entsorgt es
            // Remove this UserControl from its parent and dispose it
            Parent.Controls.Remove(this);
            Dispose();
        }

        // Event-Handler, wenn die Maus das Exit-Label betritt
        // Event handler for when the mouse enters the exit label
        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        // Event-Handler, wenn die Maus das Exit-Label verlässt
        // Event handler for when the mouse leaves the exit label
        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        // Event-Handler, wenn das UserControl geladen wird
        // Event handler for when the UserControl loads
        void Book_add_UC_Load(object sender, EventArgs e) => Location = new Point(260, 27);

        // Event-Handler, um das Tippen in der Buchtyp-Kombobox zu verhindern
        // Event handler to prevent typing in the book type combo box
        void book_type_cb_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        // Event-Handler für das Klicken auf den "Item hinzufügen"-Button
        // Event handler for the item add finish button click event
        void item_add_finish_btn_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob das Textfeld für den Item-Namen nicht leer ist
            // Check if the item name textbox is not empty
            if (item_name_tb.Text != "")
            {
                // Überprüfen, ob das Textfeld für die Item-Anzahl nicht leer ist
                // Check if the item count textbox is not empty
                if (item_count_tb.Text != "")
                {
                    // Überprüfen, ob das Textfeld für die Herkunft des Items nicht leer ist
                    // Check if the item origin textbox is not empty
                    if (item_origin_tb.Text != "")
                    {
                        // Überprüfen, ob das Textfeld für die Item-ID nicht leer ist
                        // Check if the item ID textbox is not empty
                        if (item_id_tb.Text != "")
                        {
                            // Überprüfen, ob das Textfeld für den Item-Typ nicht leer ist
                            // Check if the item type textbox is not empty
                            if (item_type_tb.Text != "")
                            {
                                // Abrufen des Datenbank-Verbindungsstrings
                                // Get the database connection string
                                var connstringceck = DBCon.dbConnection;

                                // Erstellen einer neuen MySQL-Verbindung mit dem Verbindungsstring
                                // Create a new MySQL connection using the connection string
                                using (MySqlConnection connection = new MySqlConnection(connstringceck))
                                {
                                    // Öffnen der Verbindung
                                    // Open the connection
                                    connection.Open();

                                    // Erstellen einer SELECT-Abfrage, um zu überprüfen, ob das Item bereits in der Datenbank existiert
                                    // Create a SELECT query to check if the item already exists in the database
                                    var selectQuery = "SELECT COUNT(*) FROM main_inventory WHERE item_name = @itemnamecheck";

                                    // Erstellen eines neuen MySQL-Befehls mit der SELECT-Abfrage
                                    // Create a new MySQL command using the SELECT query
                                    using (MySqlCommand cmdcheck = new MySqlCommand(selectQuery, connection))
                                    {
                                        // Hinzufügen des Item-Namen-Parameters zum Befehl
                                        // Add the item name parameter to the command
                                        cmdcheck.Parameters.AddWithValue("@itemnamecheck", item_name_tb.Text);

                                        // Ausführen des Befehls und Abrufen der Anzahl der Items mit demselben Namen
                                        // Execute the command and get the count of items with the same name
                                        var count = Convert.ToInt32(cmdcheck.ExecuteScalar());

                                        // Wenn das Item nicht existiert, in die Datenbank einfügen
                                        // If the item does not exist, insert it into the database
                                        if (count == 0)
                                        {
                                            // Erstellen einer INSERT-Abfrage, um das neue Item in die Datenbank einzufügen
                                            // Create an INSERT query to add the new item to the database
                                            var insertQuery = "INSERT INTO main_inventory (item_name, item_type, item_origin, item_id, item_count, item_note) VALUES (@item_name, @item_type, @item_origin, @item_id, @item_count, @item_note)";

                                            // Abrufen des Datenbank-Verbindungsstrings
                                            // Get the database connection string
                                            var connstring = DBCon.dbConnection;
                                            // Erstellen einer neuen MySQL-Verbindung mit dem Verbindungsstring
                                            // Create a new MySQL connection using the connection string
                                            var con = new MySqlConnection(connstring);

                                            // Öffnen der Verbindung
                                            // Open the connection
                                            con.Open();

                                            try
                                            {
                                                // Erstellen eines neuen MySQL-Befehls mit der INSERT-Abfrage
                                                // Create a new MySQL command using the INSERT query
                                                var cmd = new MySqlCommand(insertQuery, con);

                                                // Hinzufügen der Parameter zum Befehl
                                                // Add the parameters to the command
                                                cmd.Parameters.AddWithValue("@item_name", item_name_tb.Text);
                                                cmd.Parameters.AddWithValue("@item_type", item_type_tb.Text);
                                                cmd.Parameters.AddWithValue("@item_origin", item_origin_tb.Text);
                                                cmd.Parameters.AddWithValue("@item_id", item_id_tb.Text);
                                                cmd.Parameters.AddWithValue("@item_count", item_count_tb.Text);
                                                cmd.Parameters.AddWithValue("@item_note", item_note_tb.Text);

                                                // Ausführen des Befehls und Überprüfen, ob eine Zeile betroffen war
                                                // Execute the command and check if one row was affected
                                                if (cmd.ExecuteNonQuery() == 1)
                                                {
                                                    // Anzeigen einer Erfolgsmeldung
                                                    // Show a success message
                                                    MessageBox.Show("Das Buch wurde erfolgreich hinzugefügt!", "DATA UPDATED");
                                                }
                                                else
                                                {
                                                    // Anzeigen einer Fehlermeldung
                                                    // Show an error message
                                                    MessageBox.Show("Error 404!", "DATA NOT UPDATED");
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                // Anzeigen der Ausnahme-Meldung
                                                // Show the exception message
                                                MessageBox.Show(ex.Message);
                                            }

                                            // Schließen der Verbindung
                                            // Close the connection
                                            con.Close();
                                        }
                                        else
                                        {
                                            // Anzeigen einer Meldung, dass das Item bereits existiert
                                            // Show a message indicating that the item already exists
                                            MessageBox.Show("Das Buch ist bereits in der Datenbank! (zb. '_2' am ende hinzufügen)", "DATA NOT UPDATED");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // Anzeigen einer Meldung, dass das Textfeld für den Item-Typ leer ist
                                // Show a message indicating that the item type textbox is empty
                                MessageBox.Show("Die Type eingabe darf nicht lehr sein");
                            }
                        }
                        else
                        {
                            // Anzeigen einer Meldung, dass das Textfeld für die Item-ID leer ist
                            // Show a message indicating that the item ID textbox is empty
                            MessageBox.Show("Die ID eingabe darf nicht lehr sein");
                        }
                    }
                    else
                    {
                        // Anzeigen einer Meldung, dass das Textfeld für die Herkunft des Items leer ist
                        // Show a message indicating that the item origin textbox is empty
                        MessageBox.Show("Die Herkunfts eingabe darf nicht lehr sein");
                    }
                }
                else
                {
                    // Anzeigen einer Meldung, dass das Textfeld für die Item-Anzahl leer ist
                    // Show a message indicating that the item count textbox is empty
                    MessageBox.Show("Die Mengen eingabe darf nicht lehr sein");
                }
            }
            else
            {
                // Anzeigen einer Meldung, dass das Textfeld für den Item-Namen leer ist
                // Show a message indicating that the item name textbox is empty
                MessageBox.Show("Die Namens eingabe darf nicht lehr sein");
            }
        }

        // Event-Handler für das Ändern des Textes im Item-Namen-Textfeld
        // Event handler for the item name textbox text changed event
        private void item_name_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

