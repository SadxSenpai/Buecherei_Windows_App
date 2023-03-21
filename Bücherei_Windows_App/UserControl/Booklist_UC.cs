using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bücherei_Windows_App
{
    public partial class Booklist_UC : UserControl
    {
        // Initialzize of Datatable for Datagrid contents
        DataTable dtBooks = new DataTable("Books");

        public Booklist_UC() => InitializeComponent();

        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        void Booklist_UC_Load(object sender, EventArgs e)
        {
            Location = new Point(260, 27);

            book_list_datagrid.AutoResizeColumns();

            // fetch data from local database
            using (MySqlConnection con = new MySqlConnection(DBCon.dbConnection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * From books", con))
                {
                    con.Open();

                    var reader = cmd.ExecuteReader();

                    dtBooks.Load(reader);

                    // Name Collums in Datagrid
                    dtBooks.Columns[0].ColumnName = "Nr.";
                    dtBooks.Columns[1].ColumnName = "Name";
                    dtBooks.Columns[2].ColumnName = "Author";
                    dtBooks.Columns[3].ColumnName = "Typ";
                    dtBooks.Columns[4].ColumnName = "ISBN";
                    dtBooks.Columns[5].ColumnName = "Ausgeliehen von";
                    dtBooks.Columns[6].ColumnName = "Ausgeliehen am:";
                    dtBooks.Columns[7].ColumnName = "Ausgeliehen bis:";
                    dtBooks.Columns[8].ColumnName = "Status";
                }
            }

            book_list_datagrid.DataSource = dtBooks;
        }

        void OnDispose(object sender, EventArgs e) => Disposed += OnDispose;

        void search_tb_TextChanged(object sender, EventArgs e)
        {
            var dv = dtBooks.DefaultView;
            dv.RowFilter = string.Format("book_name LIKE '%{0}%' OR isbn LIKE '%{0}%'", search_tb.Text);
            book_list_datagrid.DataSource = dv.ToTable();
        }
    }
}