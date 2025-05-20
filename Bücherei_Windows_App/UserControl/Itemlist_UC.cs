using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bücherei_Windows_App
{
    public partial class Itemlist_UC : System.Windows.Forms.UserControl
    {
        // Initialisierung der Datentabelle für den Inhalt des Datenrasters
        // Initialization of Datatable for Datagrid contents
        DataTable dtBooks = new DataTable("Books");

        public Itemlist_UC() => InitializeComponent();

        void exit_label_Click(object sender, EventArgs e)
        {
            // Entfernen des Steuerelements und Freigabe der Ressourcen
            // Remove the control and release resources
            Parent.Controls.Remove(this);
            Dispose();
        }

        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        void StyleDatagridview()
        {
            // Stil des Datenrasters festlegen
            // Set the style of the datagrid
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
            // Position des Steuerelements festlegen
            // Set the position of the control
            Location = new Point(260, 27);

            StyleDatagridview();

            // Daten aus der lokalen Datenbank abrufen
            // Fetch data from local database
            using (MySqlConnection con = new MySqlConnection(DBCon.dbConnection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT item_name, item_type, item_origin, item_id, item_count, item_note FROM main_inventory", con))

                // TODO: Abfrage hinzufügen, um das Rückgabedatum abzurufen und als Eintrag in das Raster hinzuzufügen, um das Element und bis es aus dem Haus ist, leicht anzuzeigen
                // TODO: Add query to pull return date and add as entry to the grid for easy viewing if item and until it is out of house
                {
                    con.Open();

                    var reader = cmd.ExecuteReader();

                    dtBooks.Load(reader);

                    // Spalten im Datenraster benennen
                    // Name columns in datagrid
                    dtBooks.Columns[0].ColumnName = "Name";
                    dtBooks.Columns[1].ColumnName = "Typ";
                    dtBooks.Columns[2].ColumnName = "Hersteller / Author";
                    dtBooks.Columns[3].ColumnName = "Atk. Nr. / ISBN";
                    dtBooks.Columns[4].ColumnName = "Verfügbar";
                    dtBooks.Columns[5].ColumnName = "Bemerkung";
                }
            }

            book_list_datagrid.DataSource = dtBooks;
        }

        void OnDispose(object sender, EventArgs e) => Disposed += OnDispose;

        void search_tb_TextChanged(object sender, EventArgs e)
        {
            // Filter für die Datensicht festlegen
            // Set filter for the data view
            var dv = dtBooks.DefaultView;
            dv.RowFilter = string.Format("book_name LIKE '%{0}%' OR isbn LIKE '%{0}%'", search_tb.Text);
            book_list_datagrid.DataSource = dv.ToTable();
        }
    }
}