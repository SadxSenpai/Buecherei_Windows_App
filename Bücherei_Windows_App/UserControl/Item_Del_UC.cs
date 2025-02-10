using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Item_Del_UC : UserControl
    {
        public Item_Del_UC() => InitializeComponent();

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
        void Book_In_UC_Load(object sender, EventArgs e)
        {
            // Setzt die Position des UserControls
            // Sets the position of the UserControl
            Location = new Point(260, 27);

            // Holt das aktuelle Datum und die aktuelle Uhrzeit
            // Gets the current date and time
            var today = DateTime.Now;

            // Formatiert das Datum als String im gewünschten Format
            // Formats the date as a string in the desired format
            var todayString = today.ToString("dd/MM/yyyy");

            // Setzt das heutige Datum in das Label
            // Sets the current date in the label
            today_date_label.Text = todayString;

            // Verbindet sich mit der Datenbank
            // Connects to the database
            var connstring = DBCon.dbConnection;
            var con = new MySqlConnection(connstring);
            con.Open();

            // Führt eine SQL-Abfrage aus, um die Namen der Artikel zu holen
            // Executes a SQL query to get the item names
            var cmd = new MySqlCommand("SELECT item_name FROM main_inventory", con);
            var reader = cmd.ExecuteReader();

            // Fügt die Namen der Artikel in die ComboBox ein
            // Adds the item names to the ComboBox
            while (reader.Read())
            {
                var name = reader.GetString("item_name");
                item_name_cb.Items.Add(name);
            }
        }

        // Event-Handler für die Auswahl eines Artikels in der ComboBox
        // Event handler for selecting an item in the ComboBox
        void book_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verbindet sich mit der Datenbank
            // Connects to the database
            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            // Holt den ausgewählten Wert aus der ComboBox
            // Gets the selected value from the ComboBox
            var selectedValue = item_name_cb.SelectedItem.ToString();

            // Führt eine SQL-Abfrage basierend auf dem ausgewählten Artikel aus
            // Executes a SQL query based on the selected item
            var query = "SELECT item_name, item_type, item_origin, item_id, item_note FROM main_inventory WHERE item_name = '" + selectedValue + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Liest und zeigt die Daten der ausgewählten Zeile an
            // Reads and displays the data from the selected row
            while (reader.Read())
            {
                item_del_why_tb.Text = reader["item_note"].ToString();
                item_type_tb.Text = reader["item_type"].ToString();
            }
        }

        // Event-Handler für das Klicken auf den "Fertig"-Button
        // Event handler for clicking the "Finish" button
        void book_in_finish_btn_Click(object sender, EventArgs e)
        {
            // Überprüft, ob ein Artikel in der ComboBox ausgewählt ist
            // Checks if an item is selected in the ComboBox
            if (item_name_cb.SelectedIndex != -1)
            {
                // Holt den ausgewählten Wert aus der ComboBox
                // Gets the selected value from the ComboBox
                var selectedValue = item_name_cb.SelectedItem.ToString();

                // Zeigt eine Bestätigungsnachricht an
                // Shows a confirmation message
                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Verbindet sich mit der Datenbank
                    // Connects to the database
                    var connstring = DBCon.dbConnection;

                    using (MySqlConnection con = new MySqlConnection(connstring))
                    {
                        con.Open();

                        // Führt eine SQL-Abfrage aus, um die Daten des Artikels in die Tabelle "deleted_books" zu kopieren
                        // Executes a SQL query to copy the item data to the "deleted_books" table
                        var insertcmd = "INSERT INTO deleted_books (item_name, item_origin, item_type, item_id) SELECT item_name, item_origin, item_type, item_id FROM main_inventory WHERE item_name = '" + selectedValue + "'";

                        using (MySqlCommand incmd = new MySqlCommand(insertcmd, con))
                        {
                            if (incmd.ExecuteNonQuery() == 1)
                            {
                                // Führt eine SQL-Abfrage aus, um das Löschdatum und den Löschgrund in die Tabelle "deleted_books" einzufügen
                                // Executes a SQL query to insert the deletion date and reason into the "deleted_books" table
                                var insertcmd2 = "INSERT INTO deleted_books del_when =@delwhen, del_why =@delwhy WHERE book_name = '" + selectedValue + "'";

                                using (MySqlCommand incmd2 = new MySqlCommand(insertcmd2, con))
                                {
                                    incmd2.Parameters.AddWithValue("@delwhen", today_date_label.Text);
                                    incmd2.Parameters.AddWithValue("@delwhy", item_del_why_tb.Text);

                                    if (incmd2.ExecuteNonQuery() == 1)
                                    {
                                        // Führt eine SQL-Abfrage aus, um den Artikel aus der Tabelle "books" zu löschen
                                        // Executes a SQL query to delete the item from the "books" table
                                        var deletecmd = "DELETE FROM books WHERE book_name = '" + selectedValue + "'";

                                        using (MySqlCommand delcmd = new MySqlCommand(deletecmd, con))
                                        {
                                            if (delcmd.ExecuteNonQuery() == 1)
                                            {
                                                MessageBox.Show("Data copied & deleted");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Data copied BUT NOT deleted!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Data mid insert Error!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Data NOT copied!");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Löschen abgebrochen");
                }
            }
        }
    }
}