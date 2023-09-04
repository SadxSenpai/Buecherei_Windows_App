using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Item_In_UC : UserControl
    {
        public Item_In_UC() => InitializeComponent();

        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        void Book_In_UC_Load(object sender, EventArgs e)
        {
            Location = new Point(260, 27);

            // Get the current date and time
            var today = DateTime.Now;

            // Format the dates to strings in the desired format
            var todayString = today.ToString("dd/MM/yyyy");

            today_date_label.Text = todayString;

            var connstring = DBCon.dbConnection;
            var con = new MySqlConnection(connstring);
            con.Open();

            var cmd = new MySqlCommand("SELECT item_with_who FROM out_of_house", con);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var name = reader.GetString("item_with_who");

                if (user_name_cb.Items.Contains(name))
                {
                }
                else
                {
                    user_name_cb.Items.Add(name);
                }
            }
        }

        void OnDispose(object sender, EventArgs e) => Disposed += OnDispose;

        void user_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_name_cb.Items.Clear();

            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selecteduser = user_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected user
            var query = "SELECT item_name FROM out_of_house WHERE item_with_who = '" + selecteduser + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                var name = reader.GetString("item_name");

                if (item_name_cb.Items.Contains(name))
                {
                }
                else
                {
                    item_name_cb.Items.Add(name);
                }
            }
        }

        void item_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selecteditem = item_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected item
            var query = "SELECT item_note, item_type FROM out_of_house WHERE item_name = '" + selecteditem + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                item_note_tb.Text = reader["item_note"].ToString();
                item_type_tb.Text = reader["item_type"].ToString();
            }
        }

        void item_in_finish_btn_Click(object sender, EventArgs e)
        {
            // Checking if an item is selected in the ComboBox
            if (item_name_cb.SelectedIndex != -1)
            {
                // Retrieving the selected item from the ComboBox
                var selecteditem2 = item_name_cb.SelectedItem.ToString();

                var delquery = "DELETE FROM out_of_house WHERE item_name= '" + selecteditem2 + "'";

                var connstring = DBCon.dbConnection;
                var con = new MySqlConnection(connstring);

                con.Open();

                    //execute delquery
                    var cmd2 = new MySqlCommand(delquery, con);

                    //check if cmd2 query was sucessfull
                    if (cmd2.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("The item has been successfully returned!");

                        //update item_cound inside main_inventory to +1
                        var selecteditem3 = item_name_cb.SelectedItem.ToString();
                        var updateQuery = "UPDATE main_inventory SET item_count = item_count + 1 WHERE item_name = '" + selecteditem3 + "'";
                        var cmd3 = new MySqlCommand(updateQuery, con);
                        cmd3.ExecuteNonQuery();;
                    }
                    else
                    {
                        MessageBox.Show("An error occured. The item could not be returned.");
                    }

                con.Close();
            }
            else
            {
                MessageBox.Show("Please select an item from the ComboBox.");
            }
        }
    }
}