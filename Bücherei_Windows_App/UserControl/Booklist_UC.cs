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
            this.Location = new Point(260, 27);

            /*book_list_datagrid.Columns[0].HeaderText = "Nr.";
            book_list_datagrid.Columns[1].HeaderText = "Name";
            book_list_datagrid.Columns[2].HeaderText = "Author";
            book_list_datagrid.Columns[3].HeaderText = "Art";
            book_list_datagrid.Columns[4].HeaderText = "Bild";
            book_list_datagrid.Columns[5].HeaderText = "Bei:";
            book_list_datagrid.Columns[6].HeaderText = "Seit:";
            book_list_datagrid.Columns[7].HeaderText = "Bis:";
            book_list_datagrid.Columns[8].HeaderText = "Status";*/

            book_list_datagrid.AutoResizeColumns();
        }
        private void GetGridData()
        {

            // 1. Create a connection to the database
            using (SqlConnection connection = new SqlConnection(DBCon.dbConnection))
            {
                connection.Open();

                // 2. Create a command to retrieve the data from the database
                SqlCommand command = new SqlCommand("SELECT * FROM Books", connection);

                // 3. Execute the command and retrieve the data using a SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // 4. Loop through the data and add each row to the DataGridView
                while (reader.Read())
                {
                    // Retrieve the values from the reader
                    string column1 = reader.GetString(0);
                    string bookAuthor = reader.GetString(1);
                    string bookType = reader.GetString(2);
                    byte[] bookImage = (byte[])reader["book_img"];
                    string book_out_with = reader.GetString(4);
                    string book_out_since = reader.GetString(5);
                    string book_back_when = reader.GetString(6);
                    bool book_out = reader.GetBoolean(7);
                    string book_note = reader.GetString(8);

                    // Convert the byte array to an image
                    MemoryStream ms = new MemoryStream(bookImage);
                    Image image = Image.FromStream(ms);

                    // Add the row to the DataGridView
                    int rowIndex = book_list_datagrid.Rows.Add();
                    book_list_datagrid.Rows[rowIndex].Cells["book_name"].Value = column1;
                    book_list_datagrid.Rows[rowIndex].Cells["book_author"].Value = bookAuthor;
                    book_list_datagrid.Rows[rowIndex].Cells["book_type"].Value = bookType;
                    book_list_datagrid.Rows[rowIndex].Cells["book_img"].Value = image;
                    book_list_datagrid.Rows[rowIndex].Cells["book_out_with"].Value = book_out_with;
                    book_list_datagrid.Rows[rowIndex].Cells["book_out_since"].Value = book_out_since;
                    book_list_datagrid.Rows[rowIndex].Cells["book_back_when"].Value = book_back_when;
                    book_list_datagrid.Rows[rowIndex].Cells["book_out"].Value = book_out;
                    book_list_datagrid.Rows[rowIndex].Cells["book_note"].Value = book_note;
                }
            }
        }

        private void OnDispose(object sender, EventArgs e)
        {
            Disposed += OnDispose;
        }
    }
}
