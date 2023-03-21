using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Book_In_UC : UserControl
    {
        public Book_In_UC() => InitializeComponent();

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

            var cmd = new MySqlCommand("SELECT book_out_with FROM books WHERE book_out = '1'", con);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var name = reader.GetString("book_out_with");

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
            book_name_cb.Items.Clear();

            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selecteduser = user_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected user
            var query = "SELECT book_name FROM books WHERE book_out_with = '" + selecteduser + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                var name = reader.GetString("book_name");

                if (book_name_cb.Items.Contains(name))
                {
                }
                else
                {
                    book_name_cb.Items.Add(name);
                }
            }
        }

        void book_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            var connString = DBCon.dbConnection;
            var conn = new MySqlConnection(connString);
            conn.Open();

            var selectedbook = book_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected item
            var query = "SELECT book_note, book_type FROM books WHERE book_name = '" + selectedbook + "'";
            var cmd = new MySqlCommand(query, conn);
            var reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                book_info_tb.Text = reader["book_note"].ToString();
                book_type_tb.Text = reader["book_type"].ToString();
            }
        }

        void book_in_finish_btn_Click(object sender, EventArgs e)
        {
            // Checking if an item is selected in the ComboBox
            if (book_name_cb.SelectedIndex != -1)
            {
                // Retrieving the selected item from the ComboBox
                var selected_book = book_name_cb.SelectedItem.ToString();

                var bookuser = "";
                var dateout = "";
                var dateback = "";
                var bookinfo = "@bookinfo";

                var updateQuery = "UPDATE books SET book_out = '0', book_out_with ='', book_out_since ='', book_back_when ='' WHERE book_name =@selected_book AND book_out != '0'";

                var connstring = DBCon.dbConnection;
                var con = new MySqlConnection(connstring);

                con.Open();

                try
                {
                    var cmd = new MySqlCommand(updateQuery, con);

                    cmd.Parameters.AddWithValue("@bookuser", bookuser);
                    cmd.Parameters.AddWithValue("@dateout", dateout);
                    cmd.Parameters.AddWithValue("@dateback", dateback);
                    cmd.Parameters.AddWithValue("@bookinfo", bookinfo);
                    cmd.Parameters.AddWithValue("@selected_book", selected_book);

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Buch erfolgreich abgegeben", "DATA WAS UPDATETD");
                    }
                    else
                    {
                        MessageBox.Show("Das Buch ist bereits abgegeben!", "DATA NOT UPDATED");
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
                MessageBox.Show("Please select an item from the ComboBox.");
            }
        }
    }
}