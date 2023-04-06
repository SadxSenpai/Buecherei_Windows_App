using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Item_Del_UC : UserControl
    {
        public Item_Del_UC() => InitializeComponent();
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

            var cmd = new MySqlCommand("SELECT item_name FROM main_inventory", con);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var name = reader.GetString("item_name");
                item_name_cb.Items.Add(name);
            }
        }

        void book_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selectedValue = item_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected item
            var query = "SELECT item_name, item_type, item_origin, item_id, item_note FROM main_inventory WHERE item_name = '" + selectedValue + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                item_del_why_tb.Text = reader["item_note"].ToString();
                item_type_tb.Text = reader["item_type"].ToString();
            }
        }

        void book_in_finish_btn_Click(object sender, EventArgs e)
        {
            // Checking if an item is selected in the ComboBox
            if (item_name_cb.SelectedIndex != -1)
            {
                var selectedValue = item_name_cb.SelectedItem.ToString();

                var result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var connstring = DBCon.dbConnection;

                    using (MySqlConnection con = new MySqlConnection(connstring))
                    {
                        con.Open();

                        var insertcmd = "INSERT INTO deleted_books (item_name, item_origin, item_type, item_id) SELECT item_name, item_origin, item_type, item_id FROM main_inventory WHERE item_name = '" + selectedValue + "'";

                        using (MySqlCommand incmd = new MySqlCommand(insertcmd, con))
                        {
                            if (incmd.ExecuteNonQuery() == 1)
                            {
                                var insertcmd2 = "INSERT INTO deleted_books del_when =@delwhen, del_why =@delwhy WHERE book_name = '" + selectedValue + "'";

                                using (MySqlCommand incmd2 = new MySqlCommand(insertcmd2, con))
                                {
                                    incmd2.Parameters.AddWithValue("@delwhen", today_date_label.Text);
                                    incmd2.Parameters.AddWithValue("@delwhy", item_del_why_tb.Text);

                                    if (incmd2.ExecuteNonQuery() == 1)
                                    {
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