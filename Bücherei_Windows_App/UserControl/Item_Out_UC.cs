using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Bücherei_Windows_App
{
    public partial class Item_Out_UC : System.Windows.Forms.UserControl
    {
        public Item_Out_UC()
        {
            InitializeComponent();
            Location = new Point(260, 0);
        }

        // Methode, die aufgerufen wird, wenn auf das Exit-Label geklickt wird
        // Method called when the exit label is clicked
        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        // Methode, die aufgerufen wird, wenn die Maus über das Exit-Label fährt
        // Method called when the mouse enters the exit label
        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        // Methode, die aufgerufen wird, wenn die Maus das Exit-Label verlässt
        // Method called when the mouse leaves the exit label
        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        // Methode, die aufgerufen wird, wenn das UserControl geladen wird
        // Method called when the UserControl is loaded
        void Book_Out_UC_Load(object sender, EventArgs e)
        {
            Location = new Point(260, 27);

            // Aktuelles Datum und Uhrzeit abrufen
            // Get the current date and time
            var today = DateTime.Now;

            // Datum in das gewünschte Format umwandeln
            // Format the date to the desired format
            var todayString = today.ToString("dd/MM/yyyy");

            item_date_out_tb.Text = todayString;

            // ComboBox mit 7, 14 und 21 Tagen ab dem aktuellen Datum füllen
            // Populate the ComboBox with 7, 14, and 21 days from the current date
            var inDays7 = today.AddDays(7);
            var inDays14 = today.AddDays(14);
            var inDays21 = today.AddDays(21);
            var inDays7String = inDays7.ToString("dd/MM/yyyy");
            var inDays14String = inDays14.ToString("dd/MM/yyyy");
            var inDays21String = inDays21.ToString("dd/MM/yyyy");
            item_date_in_cb.Items.Add(inDays7String);
            item_date_in_cb.Items.Add(inDays14String);
            item_date_in_cb.Items.Add(inDays21String);

            // ComboBox mit den Artikeln aus der Datenbank füllen
            // Populate the ComboBox with the items from the database
            var connstring = DBCon.dbConnection;
            var con = new MySqlConnection(connstring);
            con.Open();

            var cmd = new MySqlCommand("SELECT item_name FROM main_inventory WHERE item_count > '0'", con);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var name = reader.GetString("item_name");
                item_name_cb.Items.Add(name);
            }
        }

        // Methode, die aufgerufen wird, wenn das UserControl entsorgt wird
        // Method called when the UserControl is disposed
        void OnDispose(object sender, EventArgs e) => Disposed += OnDispose;

        // Methode, die aufgerufen wird, wenn ein Artikel in der ComboBox ausgewählt wird
        // Method called when an item is selected in the ComboBox
        void item_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selectedValue = item_name_cb.SelectedItem.ToString();

            // MySQL SELECT-Abfrage basierend auf dem ausgewählten Artikel ausführen
            // Execute a MySQL SELECT query based on the selected item
            var query = "SELECT item_type, item_note FROM main_inventory WHERE item_name = '" + selectedValue + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Daten aus der ausgewählten Zeile lesen und anzeigen
            // Read and display the data from the selected row
            while (reader.Read())
            {
                item_type_tb.Text = reader["item_type"].ToString();
                item_note_tb.Text = reader["item_note"].ToString();
            }
        }

        // Methode, die aufgerufen wird, wenn der "Finish"-Button geklickt wird
        // Method called when the "Finish" button is clicked
        void book_out_finish_btn_Click(object sender, EventArgs e)
        {
            // Überprüfen, ob ein Artikel in der ComboBox ausgewählt ist
            // Checking if an item is selected in the ComboBox
            if (item_name_cb.SelectedIndex != -1 && item_date_in_cb.SelectedIndex != -1 && item_with_who_tb.Text.Length == 0)
            {
                // Ausgewählten Artikel aus der ComboBox abrufen
                // Retrieving the selected item from the ComboBox
                var selected_item = item_name_cb.SelectedItem.ToString();
                var item_date_back = item_date_in_cb.SelectedItem?.ToString();
                var itemuser = item_with_who_tb.Text;

                var itemtype = item_type_tb.Text;
                var dateout = item_date_out_tb.Text;
                var dateback = item_date_back;
                var iteminfo = item_note_tb.Text;

                var updateQuery = "INSERT INTO out_of_house (item_name, item_type, item_date_out, item_date_in, item_with_who, item_note) VALUES (@selected_item, @item_type, @item_date_out, @item_date_in, @item_with_who, @item_note)";

                var connstring = DBCon.dbConnection;
                var con = new MySqlConnection(connstring);

                con.Open();

                // SELECT-Abfrage erstellen, um die relevanten Daten aus der Datenbank abzurufen
                // Create a SELECT query to retrieve the relevant data from the database
                var selectQuery = "SELECT COUNT(*) FROM out_of_house WHERE item_name = '" + selected_item + "'";

                using (MySqlCommand cmdcheck = new MySqlCommand(selectQuery, con))
                {
                    var count = Convert.ToInt32(cmdcheck.ExecuteScalar());

                    // Wenn die Daten nicht existieren, einfügen
                    // If the data does not exist, insert it
                    if (count == 0)
                        try
                        {
                            var cmd = new MySqlCommand(updateQuery, con);

                            cmd.Parameters.AddWithValue("@selected_item", selected_item);
                            cmd.Parameters.AddWithValue("@item_type", itemtype);
                            cmd.Parameters.AddWithValue("@item_date_out", dateout);
                            cmd.Parameters.AddWithValue("@item_date_in", dateback);
                            cmd.Parameters.AddWithValue("@item_with_who", itemuser);
                            cmd.Parameters.AddWithValue("@item_note", iteminfo);

                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Buch erfolgreich verliehen", "DATA WAS UPDATED");

                                var updateQuery2 = "UPDATE main_inventory SET item_count = item_count - 1 WHERE item_name = '" + selected_item + "'";
                                var cmd2 = new MySqlCommand(updateQuery2, con);
                                cmd2.ExecuteNonQuery();
                            }
                            else
                            {
                                MessageBox.Show("Das Buch ist bereits verliehen!", "DATA NOT UPDATED");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                }

                con.Close();
            }
            else
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus.");
            }
        }
    }
}