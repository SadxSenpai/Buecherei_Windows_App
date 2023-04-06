using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data;

namespace Bücherei_Windows_App
{
    public partial class Userlist_UC : UserControl
    {
        public Userlist_UC() => InitializeComponent();

        void exit_label_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
            Dispose();
        }

        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        void StyleDatagridview()
        {
            user_list_datagrid.BorderStyle = BorderStyle.None;
            user_list_datagrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            user_list_datagrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            user_list_datagrid.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            user_list_datagrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            user_list_datagrid.BackgroundColor = Color.FromArgb(46, 49, 49);
            user_list_datagrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            user_list_datagrid.EnableHeadersVisualStyles = false;
            user_list_datagrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            user_list_datagrid.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            user_list_datagrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 49, 49);
            user_list_datagrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            user_list_datagrid.AutoResizeColumns();
        }

        void Userlist_UC_Load(object sender, EventArgs e)
        {
            StyleDatagridview();

            Location = new Point(260, 27);

            user_list_datagrid.DataSource = GetUsersDB();

            user_list_datagrid.Columns[0].HeaderText = "Nr.";
            user_list_datagrid.Columns[1].HeaderText = "Vorname";
            user_list_datagrid.Columns[2].HeaderText = "Nachname";
            user_list_datagrid.Columns[3].HeaderText = "Email";

            user_list_datagrid.AutoResizeColumns();
        }

        void OnDispose(object sender, EventArgs e) => Disposed += OnDispose;

        DataTable GetUsersDB()
        {
            var dtUsers = new DataTable();

            var connString = DBCon.dbConnection;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id, first_name, last_name, email FROM `app_users`", con))
                {
                    con.Open();

                    var reader = cmd.ExecuteReader();

                    dtUsers.Load(reader);
                }
            }

            return dtUsers;
        }
    }
}