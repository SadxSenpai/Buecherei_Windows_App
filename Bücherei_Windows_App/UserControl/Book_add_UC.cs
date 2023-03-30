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

        void book_add_finish_btn_Click(object sender, EventArgs e)
        {
            if (book_name_tb.Text != "")
            {
                if (book_count_tb.Text != "")
                {
                    if (book_author_tb.Text != "")
                    {
                        if (book_type_cb.Text != "")
                        {
                            var image = upload_imgbx.Image;
                            byte[] imageData = null;

                            if (image != null)
                            {
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                    imageData = ms.ToArray();
                                }
                            }

                            var connstringceck = DBCon.dbConnection;

                            using (MySqlConnection connection = new MySqlConnection(connstringceck))
                            {
                                connection.Open();

                                // Create a SELECT query to retrieve the relevant data from the database.
                                var selectQuery = "SELECT COUNT(*) FROM books WHERE book_name = @booknamecheck";

                                using (MySqlCommand cmdcheck = new MySqlCommand(selectQuery, connection))
                                {
                                    cmdcheck.Parameters.AddWithValue("@booknamecheck", book_name_tb.Text);

                                    var count = Convert.ToInt32(cmdcheck.ExecuteScalar());

                                    // If the data does not exist, insert it.
                                    if (count == 0)
                                    {
                                        var insertQuery = "INSERT INTO books (book_name, book_author, book_type, isbn, book_note, book_img) VALUES (@bookname, @bookauthor, @booktype, @isbn, @bookinfo, @book_img)";

                                        var connstring = DBCon.dbConnection;
                                        var con = new MySqlConnection(connstring);

                                        con.Open();

                                        try
                                        {
                                            var cmd = new MySqlCommand(insertQuery, con);

                                            cmd.Parameters.AddWithValue("@bookname", book_name_tb.Text);
                                            cmd.Parameters.AddWithValue("@bookauthor", book_author_tb.Text);
                                            cmd.Parameters.AddWithValue("@booktype", book_type_cb.Text);
                                            cmd.Parameters.AddWithValue("@isbn", book_isbn_tb.Text);
                                            cmd.Parameters.AddWithValue("@book_img", imageData);
                                            cmd.Parameters.AddWithValue("@bookinfo", book_info_tb.Text);

                                            if (cmd.ExecuteNonQuery() == 1)
                                            {
                                                var insertQuery2 = "INSERT INTO books_count (item_name, item_nr, item_count) VALUES (@item_name, @item_nr, @item_count)";

                                                var connstring2 = DBCon.dbConnection;
                                                var con2 = new MySqlConnection(connstring);

                                                con2.Open();

                                                try
                                                {
                                                    var cmd2 = new MySqlCommand(insertQuery2, con);

                                                    cmd2.Parameters.AddWithValue("@item_name", book_name_tb.Text);
                                                    cmd2.Parameters.AddWithValue("@item_nr", book_isbn_tb.Text);
                                                    cmd2.Parameters.AddWithValue("@item_count", book_count_tb.Text);

                                                    if (cmd2.ExecuteNonQuery() == 1)
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

                                                con2.Close();
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
                    MessageBox.Show("Die Mengen eingabe darf nicht lehr sein");
                }
            }
            else
            {
                MessageBox.Show("Die Namens eingabe darf nicht lehr sein");
            }
        }

        void upload_btn_Click(object sender, EventArgs e)
        {
            // open file dialog   
            var open = new OpenFileDialog();
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