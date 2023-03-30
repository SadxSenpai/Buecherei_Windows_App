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

        void StyleDatagridview()
        {
            book_list_datagrid.BorderStyle = BorderStyle.None;
            book_list_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            book_list_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            book_list_datagrid.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            book_list_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            book_list_datagrid.BackgroundColor = Color.FromArgb(46, 49, 49);
            book_list_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            book_list_datagrid.EnableHeadersVisualStyles = false;
            book_list_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            book_list_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            book_list_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 49, 49);
            book_list_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            book_list_datagrid.AutoResizeColumns();
        }

        void Booklist_UC_Load(object sender, EventArgs e)
        {
            Location = new Point(260, 27);
            
            StyleDatagridview();

            // fetch data from local database
            using (MySqlConnection con = new MySqlConnection(DBCon.dbConnection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT book_name, book_type, book_out_with, book_out_since, book_back_when, book_note FROM books", con))
                {
                    con.Open();

                    var reader = cmd.ExecuteReader();

                    dtBooks.Load(reader);

                    // Name Collums in Datagrid
                    dtBooks.Columns[0].ColumnName = "Name";
                    dtBooks.Columns[1].ColumnName = "Typ";
                    dtBooks.Columns[2].ColumnName = "Ausgeliehen von";
                    dtBooks.Columns[3].ColumnName = "Ausgeliehen am:";
                    dtBooks.Columns[4].ColumnName = "Ausgeliehen bis:";
                    dtBooks.Columns[5].ColumnName = "Bemerkung";
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