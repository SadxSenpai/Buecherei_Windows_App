using Google.Protobuf;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Drawing;

namespace Bücherei_Windows_App
{
    public partial class Book_Out_UC : UserControl
    {

        public Book_Out_UC()
        {
            InitializeComponent();
        }
        private void exit_label_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            // Get the current date and time
            DateTime today = DateTime.Now;

            // Get the date in 7 days
            DateTime in7Days = today.AddDays(7);

            // Format the dates to strings in the desired format
            string todayString = today.ToString("dd/MM/yyyy");
            string in7DaysString = in7Days.ToString("dd/MM/yyyy");

            today_date_label.Text = todayString;
            seven_days_label.Text = in7DaysString;


            string connstring = "server=localhost;uid=root;pwd=;database=lms_db";
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

        private void book_out_finish_btn_Click(object sender, EventArgs e)
        {

            // Checking if an item is selected in the ComboBox
            if (book_name_cb.SelectedIndex != -1)
            {
                // Retrieving the selected item from the ComboBox
                string selected_book = book_name_cb.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select an item from the ComboBox.");
            }
            string booktype = book_info_tb.Text;
            string bookuser = book_user_tb.Text;
            string dateout = today_date_label.Text;
            string dateback = seven_days_label.Text;
            string bookinfo = book_info_tb.Text;

            string updateQuery = "UPDATE books SET book_out = '1', book_type = 'booktype', book_out_with = 'bookuser', book_out_since = 'dateout', book_back_when = 'dateback', book_note = 'bookinfo' WHERE book_name = 'selected_book'";

            string connstring = "server=localhost;uid=root;pwd=;database=lms_db";
            MySqlConnection con = new MySqlConnection(connstring);

            con.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(updateQuery, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA UPDATED");
                }
                else
                {
                    MessageBox.Show("Data NOT UPDATED");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
    }
}
