using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Book_Del_UC : UserControl
    {
        public Book_Del_UC()
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

            MySqlCommand cmd = new MySqlCommand("SELECT book_name FROM books WHERE book_out = '0'", con);
            MySqlDataReader reader = cmd.ExecuteReader();

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

            string selectedValue = book_name_cb.SelectedItem.ToString();

            // Execute a MySQL SELECT query based on the selected item
            string query = "SELECT book_note, book_type, book_author FROM books WHERE book_name = '" + selectedValue + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();

            // Read and display the data from the selected row
            while (reader.Read())
            {
                book_del_why_tb.Text = reader["book_note"].ToString();
                book_type_tb.Text = reader["book_type"].ToString();
            }
        }

        private void book_in_finish_btn_Click(object sender, EventArgs e)
        {
            // Checking if an item is selected in the ComboBox
            if (book_name_cb.SelectedIndex != -1)
            {
                string selectedValue = book_name_cb.SelectedItem.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string connstring = "server=localhost;uid=root;pwd=;database=lms_db";

                    using (MySqlConnection con = new MySqlConnection(connstring))
                    {

                        con.Open();

                        string insertcmd = "INSERT INTO deleted_books (book_name, book_author, book_type) SELECT book_name, book_author, book_type FROM books WHERE book_name = '" + selectedValue + "'";
                        using (MySqlCommand incmd = new MySqlCommand(insertcmd, con))
                        {
                            if (incmd.ExecuteNonQuery() == 1)
                            {
                                string insertcmd2 = "INSERT INTO deleted_books del_when =@delwhen, del_why =@delwhy WHERE book_name = '" + selectedValue + "'";
                                using (MySqlCommand incmd2 = new MySqlCommand(insertcmd, con))
                                {
                                    incmd2.Parameters.AddWithValue("@delwhen", today_date_label.Text);
                                    incmd2.Parameters.AddWithValue("@delwhy", book_del_why_tb.Text);

                                    if (incmd2.ExecuteNonQuery() == 1)
                                    {
                                        string deletecmd = "DELETE FROM books WHERE book_name = '" + selectedValue + "'";
                                        using (MySqlCommand delcmd = new MySqlCommand(deletecmd, con))
                                        {

                                            if (delcmd.ExecuteNonQuery() == 1)
                                            {
                                                MessageBox.Show("Data copied & deleted");
                                            }
                                            else
                                            {
                                                MessageBox.Show("Data NOT copied and deleted!");
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
