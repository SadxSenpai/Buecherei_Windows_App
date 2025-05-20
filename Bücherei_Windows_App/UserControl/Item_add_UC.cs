using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Item_add_UC : System.Windows.Forms.UserControl
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
            // Überprüfen, ob alle erforderlichen Textfelder nicht leer sind
            // Check if all required textboxes are not empty
            if (string.IsNullOrWhiteSpace(item_name_tb.Text) ||
                string.IsNullOrWhiteSpace(item_count_tb.Text) ||
                string.IsNullOrWhiteSpace(item_origin_tb.Text) ||
                string.IsNullOrWhiteSpace(item_id_tb.Text) ||
                string.IsNullOrWhiteSpace(item_type_tb.Text))
            {
                MessageBox.Show("Alle Felder müssen ausgefüllt werden", "Eingabefehler");
                return;
            }

            // Abrufen des Datenbank-Verbindungsstrings
            // Get the database connection string
            var connstring = DBCon.dbConnection;

            // Erstellen einer neuen MySQL-Verbindung mit dem Verbindungsstring
            // Create a new MySQL connection using the connection string
            using (MySqlConnection connection = new MySqlConnection(connstring))
            {
                connection.Open();

                // Erstellen einer SELECT-Abfrage, um zu überprüfen, ob das Item bereits in der Datenbank existiert
                // Create a SELECT query to check if the item already exists in the database
                var selectQuery = "SELECT item_count FROM main_inventory WHERE item_id = @itemidcheck";

                using (MySqlCommand cmdcheck = new MySqlCommand(selectQuery, connection))
                {
                    cmdcheck.Parameters.AddWithValue("@itemidcheck", item_id_tb.Text);
                    var existingCount = cmdcheck.ExecuteScalar();

                    if (existingCount != null)
                    {
                        var result = MessageBox.Show("Das Buch ist bereits in der Datenbank! Möchten Sie die Anzahl erhöhen?", "ITEM EXISTS", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            var updateQuery = "UPDATE main_inventory SET item_count = item_count + @item_count WHERE item_id = @itemidcheck";
                            using (MySqlCommand cmdupdate = new MySqlCommand(updateQuery, connection))
                            {
                                cmdupdate.Parameters.AddWithValue("@item_count", item_count_tb.Text);
                                cmdupdate.Parameters.AddWithValue("@itemidcheck", item_id_tb.Text);
                                if (cmdupdate.ExecuteNonQuery() == 1)
                                {
                                    MessageBox.Show("Die Anzahl des Buches wurde erfolgreich erhöht!", "DATA UPDATED");
                                }
                                else
                                {
                                    MessageBox.Show("Error 404!", "DATA NOT UPDATED");
                                }
                            }
                        }
                        return;
                    }
                }

                // Erstellen einer INSERT-Abfrage, um das neue Item in die Datenbank einzufügen
                // Create an INSERT query to add the new item to the database
                var insertQuery = "INSERT INTO main_inventory (item_name, item_type, item_origin, item_id, item_count, item_note) VALUES (@item_name, @item_type, @item_origin, @item_id, @item_count, @item_note)";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@item_name", item_name_tb.Text);
                    cmd.Parameters.AddWithValue("@item_type", item_type_tb.Text);
                    cmd.Parameters.AddWithValue("@item_origin", item_origin_tb.Text);
                    cmd.Parameters.AddWithValue("@item_id", item_id_tb.Text);
                    cmd.Parameters.AddWithValue("@item_count", item_count_tb.Text);
                    cmd.Parameters.AddWithValue("@item_note", item_note_tb.Text);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Das Buch wurde erfolgreich hinzugefügt!", "DATA UPDATED");
                    }
                    else
                    {
                        MessageBox.Show("Error 404!", "DATA NOT UPDATED");
                    }
                }
            }
        }

        // Event-Handler für das Ändern des Textes im Item-Namen-Textfeld
        // Event handler for the item name textbox text changed event
        private void item_name_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

