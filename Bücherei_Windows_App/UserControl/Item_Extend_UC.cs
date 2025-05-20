using Bücherei_Windows_App.The_Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bücherei_Windows_App.UserControl
{
    public partial class Item_Extend_UC : System.Windows.Forms.UserControl
    {
        public Item_Extend_UC() => InitializeComponent();

        // Event-Handler für das Klicken auf das Exit-Label
        // Event handler for clicking the exit label
        void exit_label_Click(object sender, EventArgs e)
        {
            // Entfernt dieses UserControl vom Parent-Container
            // Removes this UserControl from the parent container
            Parent.Controls.Remove(this);
            // Gibt die Ressourcen dieses UserControls frei
            // Disposes of the resources of this UserControl
            Dispose();
        }

        // Event-Handler für das MouseEnter-Ereignis des Exit-Labels
        // Event handler for the MouseEnter event of the exit label
        void exit_label_MouseEnter(object sender, EventArgs e) => exit_label.ForeColor = Color.Red;

        // Event-Handler für das MouseLeave-Ereignis des Exit-Labels
        // Event handler for the MouseLeave event of the exit label
        void exit_label_MouseLeave(object sender, EventArgs e) => exit_label.ForeColor = Color.Black;

        // Event-Handler für das Laden des UserControls
        // Event handler for loading the UserControl
        void Book_In_UC_Load(object sender, EventArgs e)
        {
            // Setzt die Position des UserControls
            // Sets the position of the UserControl
            Location = new Point(260, 27);

            // Holt das aktuelle Datum und die aktuelle Uhrzeit
            // Gets the current date and time
            var today = DateTime.Now;

            // Formatiert das Datum als String im gewünschten Format
            // Formats the date as a string in the desired format
            var todayString = today.ToString("dd/MM/yyyy");

            // Setzt das heutige Datum in das Label
            // Sets the current date in the label
            today_date_label.Text = todayString;

            // Verbindet sich mit der Datenbank
            // Connects to the database
            var connstring = DBCon.dbConnection;
            var con = new MySqlConnection(connstring);
            con.Open();

            // Führt eine SQL-Abfrage aus, um die Namen der Artikel zu holen
            // Executes a SQL query to get the item names
            var cmd = new MySqlCommand("SELECT item_name FROM main_inventory", con);
            var reader = cmd.ExecuteReader();

            // Fügt die Namen der Artikel in die ComboBox ein
            // Adds the item names to the ComboBox
            while (reader.Read())
            {
                var name = reader.GetString("item_name");
                item_name_cb.Items.Add(name);
            }
        }
    }
}
