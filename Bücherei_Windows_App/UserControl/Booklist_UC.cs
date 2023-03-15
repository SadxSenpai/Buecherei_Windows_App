using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bücherei_Windows_App
{
    public partial class Booklist_UC : UserControl
    {
        public Booklist_UC()
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

        private void Booklist_UC_Load(object sender, EventArgs e)
        {
            //fetch and show books from database
            string query = "SELECT * FROM books";
            MySqlConnection con = new MySqlConnection(DBCon.dbConnection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            con.Open();
            MySqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                ListViewItem item = new ListViewItem(reader2["book_name"].ToString(), 0);
                book_list_datagrid.Items.Add(item);
            }
            con.Close();

            //fetch and convert blob to img from database
            string query2 = "SELECT book_blob FROM books_img";
            MySqlConnection con2 = new MySqlConnection(DBCon.dbConnection);
            MySqlCommand cmd2 = new MySqlCommand(query2, con2);
            con2.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                byte[] img = (byte[])(reader["image"]);
                if (img == null)
                {
                    book_list_imglist.Images.Add(Image.FromFile(@"C:\Users\Public\Pictures\Sample Pictures\Desert.jpg"));
                }
                else
                {
                    MemoryStream ms = new MemoryStream(img);
                    book_list_imglist.Images.Add(Image.FromStream(ms));
                }
            }
            con2.Close();

        }

        private void OnDispose(object sender, EventArgs e)
        {
            Disposed += OnDispose;
        }
    }
}
