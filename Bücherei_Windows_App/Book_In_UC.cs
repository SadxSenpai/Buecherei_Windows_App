using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Book_In_UC : UserControl
    {
        public Book_In_UC()
        {
            InitializeComponent();
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

        private void Book_In_UC_Load(object sender, EventArgs e)
        {
            this.Location = new Point(260, 0);

            // Get the current date and time
            DateTime today = DateTime.Now;

            // Format the dates to strings in the desired format
            string todayString = today.ToString("dd/MM/yyyy");

            today_date_label.Text = todayString;


            string connstring = "server=localhost;uid=root;pwd=;database=lms_db";
            MySqlConnection con = new MySqlConnection(connstring);
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT book_out_with FROM books WHERE book_out = '1'", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader.GetString("book_out_with");
                user_name_cb.Items.Add(name);
            }
        }

        private void OnDispose(object sender, EventArgs e)
        {
            Disposed += OnDispose;
        }
        private void user_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = "server=localhost;uid=root;pwd=;database=lms_db";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string selecteduser = user_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected user
            string query = "SELECT book_name FROM books WHERE book_out_with = '" + selecteduser + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                string name = reader.GetString("book_name");
                book_name_cb.Items.Add(name);
            }
        }

        private void book_name_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connString = "server=localhost;uid=root;pwd=;database=lms_db";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            string selectedbook = book_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected item
            string query = "SELECT book_note, book_type FROM books WHERE book_name = '" + selectedbook + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                book_info_tb.Text = reader["book_note"].ToString();
                book_type_tb.Text = reader["book_type"].ToString();
            }
        }

        private void book_in_finish_btn_Click(object sender, EventArgs e)
        {

            // Checking if an item is selected in the ComboBox
            if (book_name_cb.SelectedIndex != -1)
            {
                // Retrieving the selected item from the ComboBox
                string selected_book = book_name_cb.SelectedItem.ToString();

                string booktype = "";
                string bookuser = "";
                string dateout = "";
                string dateback = "";
                string bookinfo = "@bookinfo";

                string updateQuery = "UPDATE books SET book_out = '0', book_type =@booktype, book_out_with ='', book_out_since ='', book_back_when ='' WHERE book_name =@selected_book AND book_out != '0'";

                string connstring = "server=localhost;uid=root;pwd=;database=lms_db";
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
