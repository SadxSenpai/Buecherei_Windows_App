namespace Bücherei_Windows_App.Forms
{
    partial class Login_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cattobox = new PictureBox();
            testSQL = new Button();
            label_close = new Label();
            label1 = new Label();
            login_button = new Button();
            password_label = new Label();
            password_input = new TextBox();
            email_label = new Label();
            email_input = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cattobox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 24, 34);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(cattobox);
            panel1.Controls.Add(testSQL);
            panel1.Controls.Add(label_close);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(login_button);
            panel1.Controls.Add(password_label);
            panel1.Controls.Add(password_input);
            panel1.Controls.Add(email_label);
            panel1.Controls.Add(email_input);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 450);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(5, 250);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(113, 16);
            flowLayoutPanel1.TabIndex = 11;
            // 
            // cattobox
            // 
            cattobox.BackColor = Color.White;
            cattobox.Location = new Point(26, 216);
            cattobox.Name = "cattobox";
            cattobox.Size = new Size(50, 50);
            cattobox.SizeMode = PictureBoxSizeMode.Zoom;
            cattobox.TabIndex = 10;
            cattobox.TabStop = false;
            cattobox.MouseEnter += cattobox_MouseEnter;
            cattobox.MouseLeave += cattobox_MouseLeave;
            // 
            // testSQL
            // 
            testSQL.Location = new Point(3, 3);
            testSQL.Name = "testSQL";
            testSQL.Size = new Size(125, 25);
            testSQL.TabIndex = 9;
            testSQL.Text = "Test SqlConnection";
            testSQL.UseVisualStyleBackColor = true;
            testSQL.Click += testSQL_Click;
            // 
            // label_close
            // 
            label_close.BackColor = Color.White;
            label_close.Cursor = Cursors.Hand;
            label_close.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label_close.ForeColor = Color.Black;
            label_close.Location = new Point(420, 13);
            label_close.Name = "label_close";
            label_close.Size = new Size(22, 23);
            label_close.TabIndex = 1;
            label_close.Text = "X";
            label_close.TextAlign = ContentAlignment.MiddleCenter;
            label_close.Click += label_close_Click;
            label_close.MouseEnter += label_close_MouseEnter;
            label_close.MouseLeave += label_close_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(450, 65);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // login_button
            // 
            login_button.Cursor = Cursors.Hand;
            login_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            login_button.Location = new Point(48, 375);
            login_button.Name = "login_button";
            login_button.Size = new Size(350, 50);
            login_button.TabIndex = 8;
            login_button.Text = "Login";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // password_label
            // 
            password_label.BackColor = Color.Transparent;
            password_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            password_label.ForeColor = Color.White;
            password_label.Location = new Point(16, 314);
            password_label.Name = "password_label";
            password_label.Size = new Size(101, 25);
            password_label.TabIndex = 7;
            password_label.Text = "Password";
            password_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // password_input
            // 
            password_input.Location = new Point(118, 316);
            password_input.Name = "password_input";
            password_input.PasswordChar = '*';
            password_input.Size = new Size(319, 23);
            password_input.TabIndex = 6;
            // 
            // email_label
            // 
            email_label.BackColor = Color.Transparent;
            email_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            email_label.ForeColor = Color.White;
            email_label.Location = new Point(16, 265);
            email_label.Name = "email_label";
            email_label.Size = new Size(101, 25);
            email_label.TabIndex = 5;
            email_label.Text = "E-Mail";
            email_label.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // email_input
            // 
            email_input.CharacterCasing = CharacterCasing.Lower;
            email_input.Location = new Point(118, 265);
            email_input.Name = "email_input";
            email_input.Size = new Size(319, 23);
            email_input.TabIndex = 3;
            email_input.Validating += email_input_Validating;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.placeholder;
            pictureBox1.Location = new Point(0, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(450, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 24, 34);
            ClientSize = new Size(450, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Form";
            Load += Login_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cattobox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_close;
        private Label label1;
        private PictureBox pictureBox1;
        private Label password_label;
        private TextBox password_input;
        private Label email_label;
        private TextBox email_input;
        private Button login_button;
        private Button testSQL;
        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox cattobox;
    }
}