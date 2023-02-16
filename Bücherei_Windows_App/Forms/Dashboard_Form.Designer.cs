namespace Bücherei_Windows_App.Forms
{
    partial class Dashboard_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.book_delete = new System.Windows.Forms.Button();
            this.new_user = new System.Windows.Forms.Button();
            this.book_add_new = new System.Windows.Forms.Button();
            this.books_list = new System.Windows.Forms.Button();
            this.user_list = new System.Windows.Forms.Button();
            this.rueckgabe_button = new System.Windows.Forms.Button();
            this.ausleih_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userlist_uc1 = new Bücherei_Windows_App.Userlist_UC();
            this.user_Add_uc1 = new Bücherei_Windows_App.User_Add_UC();
            this.booklist_uc1 = new Bücherei_Windows_App.Booklist_UC();
            this.book_add_uc1 = new Bücherei_Windows_App.Book_add_UC();
            this.book_Out_uc1 = new Bücherei_Windows_App.Book_Out_UC();
            this.book_In_uc1 = new Bücherei_Windows_App.Book_In_UC();
            this.book_Del_uc1 = new Bücherei_Windows_App.Book_Del_UC();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.mini_dash_label = new System.Windows.Forms.Label();
            this.exit_dash_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.book_delete);
            this.panel1.Controls.Add(this.new_user);
            this.panel1.Controls.Add(this.book_add_new);
            this.panel1.Controls.Add(this.books_list);
            this.panel1.Controls.Add(this.user_list);
            this.panel1.Controls.Add(this.rueckgabe_button);
            this.panel1.Controls.Add(this.ausleih_button);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 715);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel3.Location = new System.Drawing.Point(250, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 682);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel2.Location = new System.Drawing.Point(0, 158);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 10);
            this.panel2.TabIndex = 1;
            // 
            // book_delete
            // 
            this.book_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.book_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_delete.FlatAppearance.BorderSize = 0;
            this.book_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_delete.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_delete.ForeColor = System.Drawing.Color.White;
            this.book_delete.Location = new System.Drawing.Point(3, 339);
            this.book_delete.Name = "book_delete";
            this.book_delete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.book_delete.Size = new System.Drawing.Size(241, 50);
            this.book_delete.TabIndex = 9;
            this.book_delete.Text = "Buch Löschen";
            this.book_delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.book_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_delete.UseVisualStyleBackColor = false;
            this.book_delete.Click += new System.EventHandler(this.book_delete_Click);
            // 
            // new_user
            // 
            this.new_user.BackColor = System.Drawing.Color.LavenderBlush;
            this.new_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.new_user.FlatAppearance.BorderSize = 0;
            this.new_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.new_user.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.new_user.Location = new System.Drawing.Point(3, 507);
            this.new_user.Name = "new_user";
            this.new_user.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.new_user.Size = new System.Drawing.Size(241, 50);
            this.new_user.TabIndex = 8;
            this.new_user.Text = "Neuer Benutzer";
            this.new_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.new_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.new_user.UseVisualStyleBackColor = false;
            this.new_user.Click += new System.EventHandler(this.new_user_Click);
            // 
            // book_add_new
            // 
            this.book_add_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.book_add_new.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_add_new.FlatAppearance.BorderSize = 0;
            this.book_add_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_add_new.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_add_new.ForeColor = System.Drawing.Color.White;
            this.book_add_new.Location = new System.Drawing.Point(3, 285);
            this.book_add_new.Name = "book_add_new";
            this.book_add_new.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.book_add_new.Size = new System.Drawing.Size(241, 50);
            this.book_add_new.TabIndex = 7;
            this.book_add_new.Text = "Neues Buch";
            this.book_add_new.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.book_add_new.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.book_add_new.UseVisualStyleBackColor = false;
            this.book_add_new.Click += new System.EventHandler(this.book_add_new_Click);
            // 
            // books_list
            // 
            this.books_list.BackColor = System.Drawing.Color.LavenderBlush;
            this.books_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.books_list.FlatAppearance.BorderSize = 0;
            this.books_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books_list.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books_list.Location = new System.Drawing.Point(3, 563);
            this.books_list.Name = "books_list";
            this.books_list.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.books_list.Size = new System.Drawing.Size(241, 50);
            this.books_list.TabIndex = 6;
            this.books_list.Text = "Buchliste";
            this.books_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.books_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.books_list.UseVisualStyleBackColor = false;
            this.books_list.Click += new System.EventHandler(this.Books_list_Click);
            // 
            // user_list
            // 
            this.user_list.BackColor = System.Drawing.Color.LavenderBlush;
            this.user_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_list.FlatAppearance.BorderSize = 0;
            this.user_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_list.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_list.Location = new System.Drawing.Point(3, 619);
            this.user_list.Name = "user_list";
            this.user_list.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.user_list.Size = new System.Drawing.Size(241, 50);
            this.user_list.TabIndex = 5;
            this.user_list.Text = "User Management";
            this.user_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.user_list.UseVisualStyleBackColor = false;
            this.user_list.Click += new System.EventHandler(this.User_list_Click);
            // 
            // rueckgabe_button
            // 
            this.rueckgabe_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.rueckgabe_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rueckgabe_button.FlatAppearance.BorderSize = 0;
            this.rueckgabe_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rueckgabe_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rueckgabe_button.ForeColor = System.Drawing.Color.White;
            this.rueckgabe_button.Location = new System.Drawing.Point(3, 229);
            this.rueckgabe_button.Name = "rueckgabe_button";
            this.rueckgabe_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rueckgabe_button.Size = new System.Drawing.Size(241, 50);
            this.rueckgabe_button.TabIndex = 4;
            this.rueckgabe_button.Text = "Rückgabe";
            this.rueckgabe_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rueckgabe_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rueckgabe_button.UseVisualStyleBackColor = false;
            this.rueckgabe_button.Click += new System.EventHandler(this.Rueckgabe_button_Click);
            // 
            // ausleih_button
            // 
            this.ausleih_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ausleih_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ausleih_button.FlatAppearance.BorderSize = 0;
            this.ausleih_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ausleih_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ausleih_button.ForeColor = System.Drawing.Color.White;
            this.ausleih_button.Location = new System.Drawing.Point(3, 173);
            this.ausleih_button.Name = "ausleih_button";
            this.ausleih_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ausleih_button.Size = new System.Drawing.Size(241, 50);
            this.ausleih_button.TabIndex = 3;
            this.ausleih_button.Text = "Ausleihen";
            this.ausleih_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ausleih_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ausleih_button.UseVisualStyleBackColor = false;
            this.ausleih_button.Click += new System.EventHandler(this.Ausleih_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Bücherei_Windows_App.Properties.Resources.BBW_Dash_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // userlist_uc1
            // 
            this.userlist_uc1.BackColor = System.Drawing.Color.White;
            this.userlist_uc1.Location = new System.Drawing.Point(0, 0);
            this.userlist_uc1.Name = "userlist_uc1";
            this.userlist_uc1.Size = new System.Drawing.Size(974, 646);
            this.userlist_uc1.TabIndex = 1;
            // 
            // user_Add_uc1
            // 
            this.user_Add_uc1.BackColor = System.Drawing.Color.White;
            this.user_Add_uc1.Location = new System.Drawing.Point(0, 0);
            this.user_Add_uc1.Name = "user_Add_uc1";
            this.user_Add_uc1.Size = new System.Drawing.Size(404, 681);
            this.user_Add_uc1.TabIndex = 2;
            // 
            // booklist_uc1
            // 
            this.booklist_uc1.BackColor = System.Drawing.Color.White;
            this.booklist_uc1.Location = new System.Drawing.Point(0, 0);
            this.booklist_uc1.Name = "booklist_uc1";
            this.booklist_uc1.Size = new System.Drawing.Size(974, 646);
            this.booklist_uc1.TabIndex = 3;
            // 
            // book_add_uc1
            // 
            this.book_add_uc1.BackColor = System.Drawing.Color.White;
            this.book_add_uc1.Location = new System.Drawing.Point(0, 0);
            this.book_add_uc1.Name = "book_add_uc1";
            this.book_add_uc1.Size = new System.Drawing.Size(404, 681);
            this.book_add_uc1.TabIndex = 4;
            // 
            // book_Out_uc1
            // 
            this.book_Out_uc1.BackColor = System.Drawing.Color.White;
            this.book_Out_uc1.Location = new System.Drawing.Point(0, 0);
            this.book_Out_uc1.Name = "book_Out_uc1";
            this.book_Out_uc1.Size = new System.Drawing.Size(404, 681);
            this.book_Out_uc1.TabIndex = 5;
            // 
            // book_In_uc1
            // 
            this.book_In_uc1.BackColor = System.Drawing.Color.White;
            this.book_In_uc1.Dock = System.Windows.Forms.DockStyle.Left;
            this.book_In_uc1.Location = new System.Drawing.Point(0, 0);
            this.book_In_uc1.Name = "book_In_uc1";
            this.book_In_uc1.Size = new System.Drawing.Size(404, 681);
            this.book_In_uc1.TabIndex = 6;
            // 
            // book_Del_uc1
            // 
            this.book_Del_uc1.BackColor = System.Drawing.Color.White;
            this.book_Del_uc1.Location = new System.Drawing.Point(0, 0);
            this.book_Del_uc1.Name = "book_Del_uc1";
            this.book_Del_uc1.Size = new System.Drawing.Size(404, 681);
            this.book_Del_uc1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::Bücherei_Windows_App.Properties.Resources.Dash_BG;
            this.panel4.Controls.Add(this.book_Del_uc1);
            this.panel4.Controls.Add(this.user_Add_uc1);
            this.panel4.Controls.Add(this.booklist_uc1);
            this.panel4.Controls.Add(this.userlist_uc1);
            this.panel4.Controls.Add(this.book_add_uc1);
            this.panel4.Controls.Add(this.book_Out_uc1);
            this.panel4.Controls.Add(this.book_In_uc1);
            this.panel4.Location = new System.Drawing.Point(260, 27);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1007, 681);
            this.panel4.TabIndex = 8;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.mini_dash_label);
            this.panel5.Controls.Add(this.exit_dash_label);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1267, 27);
            this.panel5.TabIndex = 9;
            // 
            // mini_dash_label
            // 
            this.mini_dash_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mini_dash_label.Location = new System.Drawing.Point(1209, -4);
            this.mini_dash_label.Name = "mini_dash_label";
            this.mini_dash_label.Size = new System.Drawing.Size(27, 27);
            this.mini_dash_label.TabIndex = 1;
            this.mini_dash_label.Text = "━";
            this.mini_dash_label.Click += new System.EventHandler(this.mini_dash_label_Click);
            this.mini_dash_label.MouseEnter += new System.EventHandler(this.mini_dash_label_MouseEnter);
            this.mini_dash_label.MouseLeave += new System.EventHandler(this.mini_dash_label_MouseLeave);
            // 
            // exit_dash_label
            // 
            this.exit_dash_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_dash_label.Location = new System.Drawing.Point(1236, -4);
            this.exit_dash_label.Name = "exit_dash_label";
            this.exit_dash_label.Size = new System.Drawing.Size(27, 27);
            this.exit_dash_label.TabIndex = 0;
            this.exit_dash_label.Text = "X";
            this.exit_dash_label.Click += new System.EventHandler(this.exit_dash_label_Click);
            this.exit_dash_label.MouseEnter += new System.EventHandler(this.exit_dash_label_MouseEnter);
            this.exit_dash_label.MouseLeave += new System.EventHandler(this.exit_dash_label_MouseLeave);
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1264, 715);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            this.Shown += new System.EventHandler(this.Dashboard_Form_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button books_list;
        private Button user_list;
        private Button rueckgabe_button;
        private Button ausleih_button;
        private Button book_add_new;
        private Button new_user;
        private Button book_delete;
        private Panel panel3;
        private Userlist_UC userlist_uc1;
        private User_Add_UC user_Add_uc1;
        private Booklist_UC booklist_uc1;
        private Book_add_UC book_add_uc1;
        private Book_Out_UC book_Out_uc1;
        private Book_In_UC book_In_uc1;
        private Book_Del_UC book_Del_uc1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Panel panel5;
        private Label mini_dash_label;
        private Label exit_dash_label;
    }
}