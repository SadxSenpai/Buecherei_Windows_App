using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
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
            //insert the book_name, book_author, book_type, isbn into the datagridview
            string query = "SELECT book_name, book_author, book_type, isbn FROM books";
            MySqlConnection con = new MySqlConnection(DBCon.dbConnection);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            book_list_datagrid.DataSource = dt;
            //change the header text
            book_list_datagrid.Columns[0].HeaderText = "Buchname";
            book_list_datagrid.Columns[1].HeaderText = "Autor";
            book_list_datagrid.Columns[2].HeaderText = "Buchtyp";
            book_list_datagrid.Columns[3].HeaderText = "ISBN";

            //add and convert blob to image in datagridview
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Bild";
            imageColumn.HeaderText = "Bild";
            book_list_datagrid.Columns.Add(imageColumn);
            for (int i = 0; i < book_list_datagrid.Rows.Count; i++)
            {
                byte[] imageData = (byte[])book_list_datagrid.Rows[i].Cells[4].Value;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    book_list_datagrid.Rows[i].Cells[4].Value = Image.FromStream(ms);
                }
            }
        }

        private void OnDispose(object sender, EventArgs e)
        {
            Disposed += OnDispose;
        }
    }
}
