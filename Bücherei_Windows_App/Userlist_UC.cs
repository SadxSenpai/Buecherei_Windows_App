using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bücherei_Windows_App
{
    public partial class Userlist_UC : UserControl
    {
        public Userlist_UC()
        {
            InitializeComponent();
            this.Location = new Point(260, 0);
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
        private void Userlist_UC_Load(object sender, EventArgs e)
        {
            user_list_datagrid.DataSource = GetUsersDB();

            user_list_datagrid.Columns[0].HeaderText = "Nr.";
            user_list_datagrid.Columns[1].HeaderText = "Vorname";
            user_list_datagrid.Columns[2].HeaderText = "Nachname";
            user_list_datagrid.Columns[3].HeaderText = "Email";

            user_list_datagrid.AutoResizeColumns();
        }
        private DataTable GetUsersDB()
        {
            DataTable dtUsers = new DataTable();

            string connString = "server=localhost;uid=root;pwd=;database=lms_db";

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT id, first_name, last_name, email FROM `app_users`", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtUsers.Load(reader);
                }
            }

            return dtUsers;
        }
    }
}
