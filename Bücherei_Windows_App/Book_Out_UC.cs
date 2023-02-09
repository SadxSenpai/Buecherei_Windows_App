using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

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
    }
}
