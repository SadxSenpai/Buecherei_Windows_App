using MySql.Data.MySqlClient;
using System.Data;
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
            this.Location = new Point(260, 27);

            book_list_datagrid.DataSource = GetBooksDB();

            book_list_datagrid.Columns[0].HeaderText = "Nr.";
            book_list_datagrid.Columns[1].HeaderText = "Name";
            book_list_datagrid.Columns[2].HeaderText = "Author";
            book_list_datagrid.Columns[3].HeaderText = "Art";
            book_list_datagrid.Columns[4].HeaderText = "Bei:";
            book_list_datagrid.Columns[5].HeaderText = "Seit:";
            book_list_datagrid.Columns[6].HeaderText = "Bis:";
            book_list_datagrid.Columns[7].HeaderText = "Status";

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Action";
            btnColumn.Text = "Click Me";
            btnColumn.Name = "btnColumn";
            book_list_datagrid.Columns.Add(btnColumn);

            book_list_datagrid.AutoResizeColumns();
        }

        private void OnDispose(object sender, EventArgs e)
        {
            Disposed += OnDispose;
        }

        private DataTable GetBooksDB()
        {
            DataTable dtBooks = new DataTable();

            string connString = "server=localhost;uid=root;pwd=;database=lms_db";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `books`", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtBooks.Load(reader);
                }
            }

            return dtBooks;
        }
    }
}
