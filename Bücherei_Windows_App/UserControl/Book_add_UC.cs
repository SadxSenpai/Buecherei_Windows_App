using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Book_add_UC : UserControl
    {
        public Book_add_UC() => InitializeComponent();

        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        void Book_add_UC_Load(object sender, EventArgs e) => Location = new Point(260, 27);

        void book_type_cb_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        void item_add_finish_btn_Click(object sender, EventArgs e)
        {
            if (item_name_tb.Text != "")
            {
                if (item_count_tb.Text != "")
                {
                    if (item_origin_tb.Text != "")
                    {
                        if (item_id_tb.Text != "")
                        {
                            if (item_type_tb.Text != "")
                            {
                                var connstringceck = DBCon.dbConnection;

                                using (MySqlConnection connection = new MySqlConnection(connstringceck))
                                {
                                    connection.Open();

                                    // Create a SELECT query to retrieve the relevant data from the database.
                                    var selectQuery = "SELECT COUNT(*) FROM main_inventory WHERE item_name = @itemnamecheck";

                                    using (MySqlCommand cmdcheck = new MySqlCommand(selectQuery, connection))
                                    {
                                        cmdcheck.Parameters.AddWithValue("@itemnamecheck", item_name_tb.Text);

                                        var count = Convert.ToInt32(cmdcheck.ExecuteScalar());

                                        // If the data does not exist, insert it.
                                        if (count == 0)
                                        {
                                            var insertQuery = "INSERT INTO main_inventory (item_name, item_type, item_origin, item_id, item_count, item_note) VALUES (@item_name, @item_type, @item_origin, @item_id, @item_count, @item_note)";

                                            var connstring = DBCon.dbConnection;
                                            var con = new MySqlConnection(connstring);

                                            con.Open();

                                            try
                                            {
                                                var cmd = new MySqlCommand(insertQuery, con);

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
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }

                                            con.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Das Buch ist bereits in der Datenbank! (zb. '_2' am ende hinzufügen)", "DATA NOT UPDATED");
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Die Type eingabe darf nicht lehr sein");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Die ID eingabe darf nicht lehr sein");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Die Herkunfts eingabe darf nicht lehr sein");
                    }
                }
                else
                {
                    MessageBox.Show("Die Mengen eingabe darf nicht lehr sein");
                }
            }
            else
            {
                MessageBox.Show("Die Namens eingabe darf nicht lehr sein");
            }
        }

        private void item_name_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

