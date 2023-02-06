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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_close = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.password_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.label_close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.password_label);
            this.panel1.Controls.Add(this.password_input);
            this.panel1.Controls.Add(this.email_label);
            this.panel1.Controls.Add(this.email_input);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 450);
            this.panel1.TabIndex = 0;
            // 
            // label_close
            // 
            this.label_close.BackColor = System.Drawing.Color.White;
            this.label_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_close.ForeColor = System.Drawing.Color.Black;
            this.label_close.Location = new System.Drawing.Point(420, 13);
            this.label_close.Name = "label_close";
            this.label_close.Size = new System.Drawing.Size(22, 23);
            this.label_close.TabIndex = 1;
            this.label_close.Text = "X";
            this.label_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_close.Click += new System.EventHandler(this.label_close_Click);
            this.label_close.MouseEnter += new System.EventHandler(this.label_close_MouseEnter);
            this.label_close.MouseLeave += new System.EventHandler(this.label_close_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // login_button
            // 
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_button.Location = new System.Drawing.Point(48, 375);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(350, 50);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // password_label
            // 
            this.password_label.BackColor = System.Drawing.Color.Transparent;
            this.password_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.password_label.ForeColor = System.Drawing.Color.White;
            this.password_label.Location = new System.Drawing.Point(16, 314);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(101, 25);
            this.password_label.TabIndex = 7;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(118, 316);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(319, 23);
            this.password_input.TabIndex = 6;
            // 
            // email_label
            // 
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.email_label.ForeColor = System.Drawing.Color.White;
            this.email_label.Location = new System.Drawing.Point(16, 265);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(101, 25);
            this.email_label.TabIndex = 5;
            this.email_label.Text = "E-Mail";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(118, 265);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(319, 23);
            this.email_input.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Bücherei_Windows_App.Properties.Resources.CDB_137;
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
    }
}