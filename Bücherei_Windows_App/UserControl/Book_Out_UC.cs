using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Bücherei_Windows_App
{
    public partial class Book_Out_UC : UserControl
    {

        public Book_Out_UC()
        {
            InitializeComponent();
            this.Location = new Point(260, 0);
        }

        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            this.Dispose();
        }

        private void exit_label_MouseEnter(object sender, EventArgs e)
        {
            exit_label.ForeColor = Color.Red;
        }

        private void exit_label_MouseLeave(object sender, EventArgs e)
        {
            exit_label.ForeColor = Color.Black;
        }

        private void Book_Out_UC_Load(object sender, EventArgs e)
        {
            this.Location = new Point(260, 27);

            // Get the current date and time
            DateTime today = DateTime.Now;

            // Get the date in 7 days
            DateTime in7Days = today.AddDays(7);

            // Format the dates to strings in the desired format
            string todayString = today.ToString("dd/MM/yyyy");
            string in7DaysString = in7Days.ToString("dd/MM/yyyy");

            today_date_label.Text = todayString;
            seven_days_label.Text = in7DaysString;


            string connstring = DBCon.dbConnection;
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT book_name FROM books WHERE book_out = '0'", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString("book_name");
                book_name_cb.Items.Add(name);
            }
        }

        private void OnDispose(object sender, EventArgs e)
        {
            Disposed += OnDispose;
        }

        private void book_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = DBCon.dbConnection;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string selectedValue = book_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected item
            string query = "SELECT book_note, book_type FROM books WHERE book_name = '" + selectedValue + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                book_info_tb.Text = reader["book_note"].ToString();
                book_type_tb.Text = reader["book_type"].ToString();
            }
        }

        private void book_out_finish_btn_Click(object sender, EventArgs e)
        {

            // Checking if an item is selected in the ComboBox
            if (book_name_cb.SelectedIndex != -1)
            {
                // Retrieving the selected item from the ComboBox
                string selected_book = book_name_cb.SelectedItem.ToString();

                string booktype = book_type_tb.Text;
                string bookuser = book_user_tb.Text;
                string dateout = today_date_label.Text;
                string dateback = seven_days_label.Text;
                string bookinfo = book_info_tb.Text;

                string updateQuery = "UPDATE books SET book_out = '1', book_type =@booktype, book_out_with =@bookuser, book_out_since =@dateout, book_back_when =@dateback, book_note =@bookinfo WHERE book_name =@selected_book AND book_out != '1'";

                string connstring = DBCon.dbConnection;
                MySqlConnection con = new MySqlConnection(connstring);

                con.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(updateQuery, con);

                    cmd.Parameters.AddWithValue("@booktype", booktype);
                    cmd.Parameters.AddWithValue("@bookuser", bookuser);
                    cmd.Parameters.AddWithValue("@dateout", dateout);
                    cmd.Parameters.AddWithValue("@dateback", dateback);
                    cmd.Parameters.AddWithValue("@bookinfo", bookinfo);
                    cmd.Parameters.AddWithValue("@selected_book", selected_book);


                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Buch erfolgreich verliehen", "DATA WAS UPDATETD");
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
                con.Close();

            }
            else
            {
                MessageBox.Show("Please select an item from the ComboBox.");
            }
        }
        }
    }
