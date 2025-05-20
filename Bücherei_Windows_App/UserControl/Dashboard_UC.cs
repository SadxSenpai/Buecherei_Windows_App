using Bücherei_Windows_App.The_Database;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Windows.Forms;

namespace Bücherei_Windows_App
{
    public partial class Dashboard_UC : System.Windows.Forms.UserControl
    {
        public Dashboard_UC()
        {
            InitializeComponent();
        }

        // Methode zum Aktualisieren der Liste in der DataGridView
        // Method to refresh the list in the DataGridView
        public void RefreshList()
        {
            // Setzt die Datenquelle der DataGridView auf null, um sie zu leeren
            // Sets the DataSource of the DataGridView to null to clear it
            due_soon_dgv.DataSource = null;

            // SQL-Abfrage, um die Spalten item_date_in, item_name und item_with_who aus der Tabelle out_of_house abzurufen
            // SQL query to retrieve the columns item_date_in, item_name, and item_with_who from the table out_of_house
            string query = "SELECT item_date_in, item_name, item_with_who FROM out_of_house";

            // Erstellt ein neues DataTable-Objekt, um die Daten zu speichern
            // Creates a new DataTable object to store the data
            DataTable table = new DataTable();

            // Erstellt einen MySqlDataAdapter, um die Daten aus der Datenbank abzurufen
            // Creates a MySqlDataAdapter to retrieve the data from the database
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, DBCon.dbConnection);

            // Füllt das DataTable-Objekt mit den abgerufenen Daten
            // Fills the DataTable object with the retrieved data
            adapter.Fill(table);

            // Setzt die Datenquelle der DataGridView auf das gefüllte DataTable-Objekt
            // Sets the DataSource of the DataGridView to the filled DataTable object
            due_soon_dgv.DataSource = table;
        }

        // Methode zum Stylen der DataGridView
        // Method to style the DataGridView
        void StyleDatagridview()
        {
            // Setzt den Rahmenstil der DataGridView auf keinen
            // Sets the border style of the DataGridView to none
            due_soon_dgv.BorderStyle = BorderStyle.None;

            // Setzt den Hintergrundstil der alternierenden Zeilen
            // Sets the background style of alternating rows
            due_soon_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);

            // Setzt den Zellenrahmenstil auf einen horizontalen Einzelrahmen
            // Sets the cell border style to a single horizontal border
            due_soon_dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Setzt den Hintergrund- und Vordergrundstil der ausgewählten Zellen
            // Sets the background and foreground style of selected cells
            due_soon_dgv.DefaultCellStyle.SelectionBackColor = Color.White;
            due_soon_dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Setzt den Hintergrundstil der Zeilen
            // Sets the background style of the rows
            due_soon_dgv.RowsDefaultCellStyle.BackColor = Color.White;
            due_soon_dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            // Setzt den Hintergrundstil der DataGridView
            // Sets the background style of the DataGridView
            due_soon_dgv.BackgroundColor = Color.White;

            // Deaktiviert die Größenänderung der Zeilenkopfbreite
            // Disables resizing of the row header width
            due_soon_dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            // Blendet die Spaltenüberschriften aus
            // Hides the column headers
            due_soon_dgv.ColumnHeadersVisible = false;

            // Setzt die DataGridView auf schreibgeschützt
            // Sets the DataGridView to read-only
            due_soon_dgv.ReadOnly = true;

            // Passt die Spaltenbreite automatisch an den Inhalt an
            // Automatically adjusts the column width to fit the content
            due_soon_dgv.AutoResizeColumns();
        }

        // Ereignishandler für das Laden des UserControls
        // Event handler for loading the UserControl
        private void Dashboard_UC_Load(object sender, EventArgs e)
        {
            // Ruft die Methode zum Stylen der DataGridView auf
            // Calls the method to style the DataGridView
            StyleDatagridview();

            // Ruft die Methode zum Aktualisieren der Liste auf
            // Calls the method to refresh the list
            RefreshList();
        }
    }
}
