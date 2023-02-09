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
            //Hide UserControls
            booklist_uc1.Hide();
            book_Out_uc1.Hide();

            //  Side Panel Bilder
            //ausleih_button.Image = Image.FromFile("../../Images/xxx.png");
            //rueckgabe_button.Image = Image.FromFile("../../Images/xxx.png");
            //books_list.Image = Image.FromFile("../../Images/xxx.png");
            //user_list.Image = Image.FromFile("../../Images/xxx.png");
        }

        private void Dashboard_Form_Shown(object sender, EventArgs e)
        {
            this.Enabled = false;

            // showing Login Form
            Login_Form logf = new Login_Form(this);
            logf.TopMost = true;
            logf.Show();
        }

        private void Dashboard_Form_Click(object sender, EventArgs e)
        {
        }

        private void books_list_Click(object sender, EventArgs e)
        {
            booklist_uc1.Show();
        }

        private void ausleih_button_Click(object sender, EventArgs e)
        {
            book_Out_uc1.Show();
        }
    }
}
