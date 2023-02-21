using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bücherei_Windows_App
{
    public partial class Book_add_UC : UserControl
    {
        public Book_add_UC()
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

        private void Book_add_UC_Load(object sender, EventArgs e)
        {
            this.Location = new Point(260, 27);
        }

        private void book_type_cb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void book_add_finish_btn_Click(object sender, EventArgs e)
        {
            if (book_name_tb.Text != "")
            {
                if (book_author_tb.Text != "")
                {
                    if (book_type_cb.Text != "")
                    {
                        string connstringceck = "server=localhost;uid=root;pwd=;database=lms_db";

                        using (MySqlConnection connection = new MySqlConnection(connstringceck))
                        {
                            connection.Open();

                            // Create a SELECT query to retrieve the relevant data from the database.
                            string selectQuery = "SELECT COUNT(*) FROM books WHERE book_name = @booknamecheck";

                            using (MySqlCommand cmdcheck = new MySqlCommand(selectQuery, connection))
                            {
                                cmdcheck.Parameters.AddWithValue("@booknamecheck", book_name_tb.Text);

                                int count = Convert.ToInt32(cmdcheck.ExecuteScalar());

                                // If the data does not exist, insert it.
                                if (count == 0)
                                {
                                    string insertQuery = "INSERT INTO books (book_name, book_author, book_type, book_note) VALUES (@bookname, @bookauthor, @booktype, @bookinfo)";

                                    string connstring = "server=localhost;uid=root;pwd=;database=lms_db";
                                    MySqlConnection con = new MySqlConnection(connstring);

                                    con.Open();
                                    try
                                    {
                                        MySqlCommand cmd = new MySqlCommand(insertQuery, con);

                                        cmd.Parameters.AddWithValue("@bookname", book_name_tb.Text);
                                        cmd.Parameters.AddWithValue("@bookauthor", book_author_tb.Text);
                                        cmd.Parameters.AddWithValue("@booktype", book_type_cb.Text);
                                        cmd.Parameters.AddWithValue("@bookinfo", book_info_tb.Text);

                                        if (cmd.ExecuteNonQuery() == 1)
                                        {
                                            MessageBox.Show("Buch erfolgreich hinzugefügt", "DATA WAS UPDATETD");
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
                    MessageBox.Show("Die Author eingabe darf nicht lehr sein");
                }
            }
            else
            {
                MessageBox.Show("Die Namens eingabe darf nicht lehr sein");
            }
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                upload_imgbx.Image = new Bitmap(open.FileName);
            }
        }
    }
}
