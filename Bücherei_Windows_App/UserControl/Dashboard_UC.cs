using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Windows.Forms;

namespace Bücherei_Windows_App
{
    public partial class Dashboard_UC : UserControl
    {
        public Dashboard_UC()
        {
            InitializeComponent();
        }
        public void RefreshList()
        {
            due_soon_dgv.DataSource = null;

            //fill due_soon_dgv datadridview with item_date_in, item_name, item_with_who column from out_of_house table in database
            string query = "SELECT item_date_in, item_name, item_with_who FROM out_of_house";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBCon.dbConnection);
            adapter.Fill(table);
            due_soon_dgv.DataSource = table;
        }

        void StyleDatagridview()
        {
            due_soon_dgv.BorderStyle = BorderStyle.None;
            due_soon_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            due_soon_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            due_soon_dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            due_soon_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            due_soon_dgv.RowsDefaultCellStyle.BackColor = Color.White;
            due_soon_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            due_soon_dgv.BackgroundColor = Color.White;
            due_soon_dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            due_soon_dgv.ColumnHeadersVisible = false;
            due_soon_dgv.ReadOnly = true;

            due_soon_dgv.AutoResizeColumns();
        }

        private void Dashboard_UC_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            RefreshList();
        }
    }
}
