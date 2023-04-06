using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bücherei_Windows_App
{
    public partial class Itemout_UC : UserControl
    {
        // Initialzize of Datatable for Datagrid contents
        DataTable dtItems = new DataTable("out_of_house");

        public Itemout_UC()
        {
            InitializeComponent();
        }
        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        void StyleDatagridview()
        {
            Item_list_datagrid.BorderStyle = BorderStyle.None;
            Item_list_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            Item_list_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Item_list_datagrid.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            Item_list_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            Item_list_datagrid.BackgroundColor = Color.FromArgb(46, 49, 49);
            Item_list_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            Item_list_datagrid.EnableHeadersVisualStyles = false;
            Item_list_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            Item_list_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            Item_list_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 49, 49);
            Item_list_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Item_list_datagrid.AutoResizeColumns();
        }

        void Itemout_UC_Load(object sender, EventArgs e)
        {
            Location = new Point(260, 27);

            StyleDatagridview();

            // fetch data from local database
            using (MySqlConnection con = new MySqlConnection(DBCon.dbConnection))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT item_name, item_type, item_date_out, item_date_in, item_with_who, item_note FROM out_of_house", con))
                {
                    con.Open();

                    var reader = cmd.ExecuteReader();

                    dtItems.Load(reader);

                    // Name Collums in Datagrid
                    dtItems.Columns[0].ColumnName = "Name";
                    dtItems.Columns[1].ColumnName = "Typ";
                    dtItems.Columns[2].ColumnName = "Ausgeliehen am:";
                    dtItems.Columns[3].ColumnName = "Ausgeliehen bis:";
                    dtItems.Columns[4].ColumnName = "Ausgeliehen von";
                    dtItems.Columns[5].ColumnName = "Bemerkung";
                }
            }

            Item_list_datagrid.DataSource = dtItems;
        }

        void OnDispose(object sender, EventArgs e) => Disposed += OnDispose;

        void search_tb_TextChanged(object sender, EventArgs e)
        {
            var dv = dtItems.DefaultView;
            dv.RowFilter = string.Format("Name LIKE '%{0}%'", search_tb.Text);
            Item_list_datagrid.DataSource = dv.ToTable();
        }
    }
}
