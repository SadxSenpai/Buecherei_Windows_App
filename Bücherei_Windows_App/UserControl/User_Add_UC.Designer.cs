namespace Bücherei_Windows_App
{
    partial class User_Add_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            new_password_check_tb = new TextBox();
            label3 = new Label();
            new_password_tb = new TextBox();
            new_email_check_tb = new TextBox();
            new_email_tb = new TextBox();
            last_name_tb = new TextBox();
            first_name_tb = new TextBox();
            label5 = new Label();
            new_user_create = new Button();
            label2 = new Label();
            label1 = new Label();
            exit_label = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(new_password_check_tb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(new_password_tb);
            panel1.Controls.Add(new_email_check_tb);
            panel1.Controls.Add(new_email_tb);
            panel1.Controls.Add(last_name_tb);
            panel1.Controls.Add(first_name_tb);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(new_user_create);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 643);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 297);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 28;
            label6.Text = "Passwort Bestätigen";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_password_check_tb
            // 
            new_password_check_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_password_check_tb.Location = new Point(176, 295);
            new_password_check_tb.Name = "new_password_check_tb";
            new_password_check_tb.Size = new Size(207, 27);
            new_password_check_tb.TabIndex = 27;
            new_password_check_tb.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 237);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 26;
            label3.Text = "Passwort";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_password_tb
            // 
            new_password_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_password_tb.Location = new Point(176, 235);
            new_password_tb.Name = "new_password_tb";
            new_password_tb.Size = new Size(207, 27);
            new_password_tb.TabIndex = 25;
            new_password_tb.UseSystemPasswordChar = true;
            // 
            // new_email_check_tb
            // 
            new_email_check_tb.CharacterCasing = CharacterCasing.Lower;
            new_email_check_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_email_check_tb.Location = new Point(176, 175);
            new_email_check_tb.Name = "new_email_check_tb";
            new_email_check_tb.Size = new Size(207, 27);
            new_email_check_tb.TabIndex = 24;
            // 
            // new_email_tb
            // 
            new_email_tb.CharacterCasing = CharacterCasing.Lower;
            new_email_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            new_email_tb.Location = new Point(176, 115);
            new_email_tb.Name = "new_email_tb";
            new_email_tb.Size = new Size(207, 27);
            new_email_tb.TabIndex = 23;
            // 
            // last_name_tb
            // 
            last_name_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            last_name_tb.Location = new Point(283, 53);
            last_name_tb.Name = "last_name_tb";
            last_name_tb.PlaceholderText = "Nachname";
            last_name_tb.Size = new Size(100, 27);
            last_name_tb.TabIndex = 22;
            // 
            // first_name_tb
            // 
            first_name_tb.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            first_name_tb.Location = new Point(177, 53);
            first_name_tb.Name = "first_name_tb";
            first_name_tb.PlaceholderText = "Vorname";
            first_name_tb.Size = new Size(100, 27);
            first_name_tb.TabIndex = 21;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 177);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 9;
            label5.Text = "Email Bestätigen";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // new_user_create
            // 
            new_user_create.Location = new Point(67, 582);
            new_user_create.Name = "new_user_create";
            new_user_create.Size = new Size(250, 42);
            new_user_create.TabIndex = 7;
            new_user_create.Text = "Erstellen";
            new_user_create.UseVisualStyleBackColor = true;
            new_user_create.Click += new_user_create_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 117);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 57);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exit_label
            // 
            exit_label.AutoSize = true;
            exit_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            exit_label.Location = new Point(374, 0);
            exit_label.Name = "exit_label";
            exit_label.Size = new Size(30, 32);
            exit_label.TabIndex = 1;
            exit_label.Text = "X";
            exit_label.Click += exit_label_Click;
            exit_label.MouseEnter += exit_label_MouseEnter;
            exit_label.MouseLeave += exit_label_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(193, 32);
            label4.TabIndex = 6;
            label4.Text = "Neuer Benutzer";
            // 
            // User_Add_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(exit_label);
            Controls.Add(panel1);
            Name = "User_Add_UC";
            Size = new Size(404, 681);
            Load += User_Add_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit_label;
        private Label label1;
        private Label label5;
        private Button new_user_create;
        private Label label2;
        private Label label4;
        private TextBox new_password_tb;
        private TextBox new_email_check_tb;
        private TextBox new_email_tb;
        private TextBox last_name_tb;
        private TextBox first_name_tb;
        private TextBox new_password_check_tb;
        private Label label3;
        private Label label6;
    }
}
