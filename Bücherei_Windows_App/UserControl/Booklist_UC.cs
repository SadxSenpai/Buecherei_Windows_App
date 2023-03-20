using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bücherei_Windows_App
{
    public partial class Booklist_UC : UserControl
    {
        //Initialzize of Datatable for Datagrid contents
        DataTable dtBooks = new DataTable("Books");

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
            this.Location = new Point(260, 27);

            book_list_datagrid.AutoResizeColumns();

            //fetch data from local database
            using (MySqlConnection con = new MySqlConnection(DBCon.dbConnection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * From books", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtBooks.Load(reader);
                }
            }
            book_list_datagrid.DataSource = dtBooks;
        }
        private void OnDispose(object sender, EventArgs e)
        {
            Disposed += OnDispose;
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dtBooks.DefaultView;
            dv.RowFilter = string.Format("book_name LIKE '%{0}%' OR isbn LIKE '%{0}%'", search_tb.Text);
            book_list_datagrid.DataSource = dv.ToTable();
        }
    }
}
