using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bücherei_Windows_App.Forms
{
    public partial class Dashboard_Form : Form
    {
        public Dashboard_Form()
        {
            InitializeComponent();
        }

        private void Dashboard_Form_Load(object sender, EventArgs e)
        {
            //  Side Panel Bilder
            //ausleih_button.Image = Image.FromFile("../../Images/xxx.png");
            //rueckgabe_button.Image = Image.FromFile("../../Images/xxx.png");
            //books_list.Image = Image.FromFile("../../Images/xxx.png");
            //user_list.Image = Image.FromFile("../../Images/xxx.png");
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled= false;

            // showing Login Form
            Login_Form lfg = new Login_Form(this);
            lfg.Show();
        }
    }
}
