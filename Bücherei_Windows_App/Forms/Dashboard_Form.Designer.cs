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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            userlist_uc1 = new Userlist_UC();
            user_Add_uc1 = new User_Add_UC();
            booklist_uc1 = new Itemlist_UC();
            book_add_uc1 = new Item_add_UC();
            book_Out_uc1 = new Item_Out_UC();
            book_In_uc1 = new Item_In_UC();
            book_Del_uc1 = new Item_Del_UC();
            panel4 = new Panel();
            dashboard_uc1 = new Dashboard_UC();
            dogebox = new PictureBox();
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            Topbar = new Panel();
            mini_dash_label = new Label();
            exit_dash_label = new Label();
            Bottombar = new Panel();
            username_label = new Label();
            pictureBox1 = new PictureBox();
            ausleih_button = new Button();
            rueckgabe_button = new Button();
            user_list = new Button();
            books_list = new Button();
            book_add_new = new Button();
            new_user = new Button();
            book_delete = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            itemout_list = new Button();
            button2 = new Button();
            itemout_uc1 = new Itemout_UC();
            panel1 = new Panel();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dogebox).BeginInit();
            Topbar.SuspendLayout();
            Bottombar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // userlist_uc1
            // 
            userlist_uc1.BackColor = Color.White;
            userlist_uc1.Location = new Point(260, 27);
            userlist_uc1.Name = "userlist_uc1";
            userlist_uc1.Size = new Size(974, 646);
            userlist_uc1.TabIndex = 1;
            // 
            // user_Add_uc1
            // 
            user_Add_uc1.BackColor = Color.White;
            user_Add_uc1.Location = new Point(260, 27);
            user_Add_uc1.Name = "user_Add_uc1";
            user_Add_uc1.Size = new Size(404, 681);
            user_Add_uc1.TabIndex = 2;
            // 
            // booklist_uc1
            // 
            booklist_uc1.BackColor = Color.White;
            booklist_uc1.Location = new Point(260, 27);
            booklist_uc1.Name = "booklist_uc1";
            booklist_uc1.Size = new Size(974, 646);
            booklist_uc1.TabIndex = 3;
            // 
            // book_add_uc1
            // 
            book_add_uc1.BackColor = Color.White;
            book_add_uc1.Location = new Point(260, 27);
            book_add_uc1.Name = "book_add_uc1";
            book_add_uc1.Size = new Size(404, 681);
            book_add_uc1.TabIndex = 4;
            // 
            // book_Out_uc1
            // 
            book_Out_uc1.BackColor = Color.White;
            book_Out_uc1.Location = new Point(260, 27);
            book_Out_uc1.Name = "book_Out_uc1";
            book_Out_uc1.Size = new Size(404, 681);
            book_Out_uc1.TabIndex = 5;
            // 
            // book_In_uc1
            // 
            book_In_uc1.BackColor = Color.White;
            book_In_uc1.Location = new Point(260, 27);
            book_In_uc1.Name = "book_In_uc1";
            book_In_uc1.Size = new Size(404, 681);
            book_In_uc1.TabIndex = 6;
            // 
            // book_Del_uc1
            // 
            book_Del_uc1.BackColor = Color.White;
            book_Del_uc1.Location = new Point(260, 27);
            book_Del_uc1.Name = "book_Del_uc1";
            book_Del_uc1.Size = new Size(404, 681);
            book_Del_uc1.TabIndex = 7;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(dashboard_uc1);
            panel4.Controls.Add(dogebox);
            panel4.Location = new Point(260, 27);
            panel4.Name = "panel4";
            panel4.Size = new Size(1007, 681);
            panel4.TabIndex = 8;
            // 
            // dashboard_uc1
            // 
            dashboard_uc1.BackColor = Color.Transparent;
            dashboard_uc1.Location = new Point(0, -1);
            dashboard_uc1.Name = "dashboard_uc1";
            dashboard_uc1.Size = new Size(1007, 683);
            dashboard_uc1.TabIndex = 13;
            // 
            // dogebox
            // 
            dogebox.BackgroundImage = (Image)resources.GetObject("dogebox.BackgroundImage");
            dogebox.BackgroundImageLayout = ImageLayout.None;
            dogebox.Location = new Point(907, 581);
            dogebox.Name = "dogebox";
            dogebox.Size = new Size(100, 100);
            dogebox.SizeMode = PictureBoxSizeMode.StretchImage;
            dogebox.TabIndex = 0;
            dogebox.TabStop = false;
            dogebox.MouseEnter += dogebox_MouseEnter;
            dogebox.MouseLeave += dogebox_MouseLeave;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // Topbar
            // 
            Topbar.BackColor = Color.FromArgb(0, 57, 141);
            Topbar.Controls.Add(mini_dash_label);
            Topbar.Controls.Add(exit_dash_label);
            Topbar.Location = new Point(0, 0);
            Topbar.Name = "Topbar";
            Topbar.Size = new Size(1267, 27);
            Topbar.TabIndex = 9;
            Topbar.MouseDown += Topbar_MouseDown;
            // 
            // mini_dash_label
            // 
            mini_dash_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            mini_dash_label.ForeColor = Color.White;
            mini_dash_label.Location = new Point(1209, -4);
            mini_dash_label.Name = "mini_dash_label";
            mini_dash_label.Size = new Size(27, 27);
            mini_dash_label.TabIndex = 1;
            mini_dash_label.Text = "━";
            mini_dash_label.Click += mini_dash_label_Click;
            mini_dash_label.MouseEnter += mini_dash_label_MouseEnter;
            mini_dash_label.MouseLeave += mini_dash_label_MouseLeave;
            // 
            // exit_dash_label
            // 
            exit_dash_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            exit_dash_label.ForeColor = Color.White;
            exit_dash_label.Location = new Point(1236, -4);
            exit_dash_label.Name = "exit_dash_label";
            exit_dash_label.Size = new Size(27, 27);
            exit_dash_label.TabIndex = 0;
            exit_dash_label.Text = "X";
            exit_dash_label.Click += exit_dash_label_Click;
            exit_dash_label.MouseEnter += exit_dash_label_MouseEnter;
            exit_dash_label.MouseLeave += exit_dash_label_MouseLeave;
            // 
            // Bottombar
            // 
            Bottombar.BackColor = Color.FromArgb(0, 57, 141);
            Bottombar.Controls.Add(username_label);
            Bottombar.Location = new Point(0, 708);
            Bottombar.Name = "Bottombar";
            Bottombar.Size = new Size(1267, 27);
            Bottombar.TabIndex = 9;
            // 
            // username_label
            // 
            username_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            username_label.ForeColor = Color.White;
            username_label.Location = new Point(0, 0);
            username_label.Name = "username_label";
            username_label.Size = new Size(598, 24);
            username_label.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.BBW_Dash_logo;
            pictureBox1.Location = new Point(-1, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // ausleih_button
            // 
            ausleih_button.BackColor = Color.FromArgb(0, 57, 141);
            ausleih_button.BackgroundImageLayout = ImageLayout.None;
            ausleih_button.Cursor = Cursors.Hand;
            ausleih_button.FlatAppearance.BorderSize = 0;
            ausleih_button.FlatStyle = FlatStyle.Flat;
            ausleih_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ausleih_button.ForeColor = Color.White;
            ausleih_button.Image = Properties.Resources.book_circle_arrow_right;
            ausleih_button.ImageAlign = ContentAlignment.MiddleRight;
            ausleih_button.Location = new Point(3, 173);
            ausleih_button.Name = "ausleih_button";
            ausleih_button.Padding = new Padding(10, 0, 0, 0);
            ausleih_button.Size = new Size(241, 50);
            ausleih_button.TabIndex = 3;
            ausleih_button.Text = "Ausleihen";
            ausleih_button.TextAlign = ContentAlignment.MiddleLeft;
            ausleih_button.UseVisualStyleBackColor = false;
            ausleih_button.Click += Ausleih_button_Click;
            // 
            // rueckgabe_button
            // 
            rueckgabe_button.BackColor = Color.FromArgb(0, 57, 141);
            rueckgabe_button.Cursor = Cursors.Hand;
            rueckgabe_button.FlatAppearance.BorderSize = 0;
            rueckgabe_button.FlatStyle = FlatStyle.Flat;
            rueckgabe_button.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            rueckgabe_button.ForeColor = Color.White;
            rueckgabe_button.Image = Properties.Resources.book_in;
            rueckgabe_button.ImageAlign = ContentAlignment.MiddleRight;
            rueckgabe_button.Location = new Point(3, 229);
            rueckgabe_button.Name = "rueckgabe_button";
            rueckgabe_button.Padding = new Padding(10, 0, 0, 0);
            rueckgabe_button.Size = new Size(241, 50);
            rueckgabe_button.TabIndex = 4;
            rueckgabe_button.Text = "Rückgabe";
            rueckgabe_button.TextAlign = ContentAlignment.MiddleLeft;
            rueckgabe_button.UseVisualStyleBackColor = false;
            rueckgabe_button.Click += Rueckgabe_button_Click;
            // 
            // user_list
            // 
            user_list.BackColor = Color.LavenderBlush;
            user_list.Cursor = Cursors.Hand;
            user_list.FlatAppearance.BorderSize = 0;
            user_list.FlatStyle = FlatStyle.Flat;
            user_list.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            user_list.Image = Properties.Resources.users;
            user_list.ImageAlign = ContentAlignment.MiddleRight;
            user_list.Location = new Point(3, 596);
            user_list.Name = "user_list";
            user_list.Padding = new Padding(10, 0, 0, 0);
            user_list.Size = new Size(241, 50);
            user_list.TabIndex = 5;
            user_list.Text = "User Management";
            user_list.TextAlign = ContentAlignment.MiddleLeft;
            user_list.UseVisualStyleBackColor = false;
            user_list.Click += User_list_Click;
            // 
            // books_list
            // 
            books_list.BackColor = Color.LavenderBlush;
            books_list.Cursor = Cursors.Hand;
            books_list.FlatAppearance.BorderSize = 0;
            books_list.FlatStyle = FlatStyle.Flat;
            books_list.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            books_list.Image = Properties.Resources.books;
            books_list.ImageAlign = ContentAlignment.MiddleRight;
            books_list.Location = new Point(3, 540);
            books_list.Name = "books_list";
            books_list.Padding = new Padding(10, 0, 0, 0);
            books_list.Size = new Size(241, 50);
            books_list.TabIndex = 6;
            books_list.Text = "Inventar";
            books_list.TextAlign = ContentAlignment.MiddleLeft;
            books_list.UseVisualStyleBackColor = false;
            books_list.Click += Books_list_Click;
            // 
            // book_add_new
            // 
            book_add_new.BackColor = Color.FromArgb(0, 57, 141);
            book_add_new.Cursor = Cursors.Hand;
            book_add_new.FlatAppearance.BorderSize = 0;
            book_add_new.FlatStyle = FlatStyle.Flat;
            book_add_new.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            book_add_new.ForeColor = Color.White;
            book_add_new.Image = Properties.Resources.book_add;
            book_add_new.ImageAlign = ContentAlignment.MiddleRight;
            book_add_new.Location = new Point(3, 341);
            book_add_new.Name = "book_add_new";
            book_add_new.Padding = new Padding(10, 0, 0, 0);
            book_add_new.Size = new Size(241, 50);
            book_add_new.TabIndex = 7;
            book_add_new.Text = "Neues Buch";
            book_add_new.TextAlign = ContentAlignment.MiddleLeft;
            book_add_new.UseVisualStyleBackColor = false;
            book_add_new.Click += book_add_new_Click;
            // 
            // new_user
            // 
            new_user.BackColor = Color.LavenderBlush;
            new_user.Cursor = Cursors.Hand;
            new_user.FlatAppearance.BorderSize = 0;
            new_user.FlatStyle = FlatStyle.Flat;
            new_user.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            new_user.Image = Properties.Resources.user_add;
            new_user.ImageAlign = ContentAlignment.MiddleRight;
            new_user.Location = new Point(3, 652);
            new_user.Name = "new_user";
            new_user.Padding = new Padding(10, 0, 0, 0);
            new_user.Size = new Size(241, 50);
            new_user.TabIndex = 8;
            new_user.Text = "Neuer Benutzer";
            new_user.TextAlign = ContentAlignment.MiddleLeft;
            new_user.UseVisualStyleBackColor = false;
            new_user.Click += new_user_Click;
            // 
            // book_delete
            // 
            book_delete.BackColor = Color.FromArgb(0, 57, 141);
            book_delete.Cursor = Cursors.Hand;
            book_delete.FlatAppearance.BorderSize = 0;
            book_delete.FlatStyle = FlatStyle.Flat;
            book_delete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            book_delete.ForeColor = Color.White;
            book_delete.Image = Properties.Resources.book_delete;
            book_delete.ImageAlign = ContentAlignment.MiddleRight;
            book_delete.Location = new Point(3, 397);
            book_delete.Name = "book_delete";
            book_delete.Padding = new Padding(10, 0, 0, 0);
            book_delete.Size = new Size(241, 50);
            book_delete.TabIndex = 9;
            book_delete.Text = "Buch Löschen";
            book_delete.TextAlign = ContentAlignment.MiddleLeft;
            book_delete.UseVisualStyleBackColor = false;
            book_delete.Click += book_delete_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(156, 59, 59);
            panel2.Location = new Point(0, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 10);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(156, 59, 59);
            panel3.Location = new Point(250, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 682);
            panel3.TabIndex = 2;
            // 
            // itemout_list
            // 
            itemout_list.BackColor = Color.LavenderBlush;
            itemout_list.Cursor = Cursors.Hand;
            itemout_list.FlatAppearance.BorderSize = 0;
            itemout_list.FlatStyle = FlatStyle.Flat;
            itemout_list.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            itemout_list.Image = Properties.Resources.books;
            itemout_list.ImageAlign = ContentAlignment.MiddleRight;
            itemout_list.Location = new Point(3, 484);
            itemout_list.Name = "itemout_list";
            itemout_list.Padding = new Padding(10, 0, 0, 0);
            itemout_list.Size = new Size(241, 50);
            itemout_list.TabIndex = 11;
            itemout_list.Text = "Verliehendes";
            itemout_list.TextAlign = ContentAlignment.MiddleLeft;
            itemout_list.UseVisualStyleBackColor = false;
            itemout_list.Click += itemout_list_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 57, 141);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.book_add;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(3, 285);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(241, 50);
            button2.TabIndex = 12;
            button2.Text = "Verlängern";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // itemout_uc1
            // 
            itemout_uc1.BackColor = Color.White;
            itemout_uc1.Location = new Point(260, 27);
            itemout_uc1.Name = "itemout_uc1";
            itemout_uc1.Size = new Size(974, 646);
            itemout_uc1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(itemout_uc1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(itemout_list);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(book_delete);
            panel1.Controls.Add(new_user);
            panel1.Controls.Add(book_add_new);
            panel1.Controls.Add(books_list);
            panel1.Controls.Add(user_list);
            panel1.Controls.Add(rueckgabe_button);
            panel1.Controls.Add(ausleih_button);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 735);
            panel1.TabIndex = 0;
            // 
            // Dashboard_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LimeGreen;
            ClientSize = new Size(1264, 735);
            Controls.Add(book_add_uc1);
            Controls.Add(userlist_uc1);
            Controls.Add(book_Del_uc1);
            Controls.Add(Topbar);
            Controls.Add(Bottombar);
            Controls.Add(booklist_uc1);
            Controls.Add(user_Add_uc1);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(book_In_uc1);
            Controls.Add(book_Out_uc1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Dashboard_Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Form_Load;
            Shown += Dashboard_Form_Shown;
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dogebox).EndInit();
            Topbar.ResumeLayout(false);
            Bottombar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Userlist_UC userlist_uc1;
        private User_Add_UC user_Add_uc1;
        private Itemlist_UC booklist_uc1;
        private Item_add_UC book_add_uc1;
        private Item_Out_UC book_Out_uc1;
        private Item_In_UC book_In_uc1;
        private Item_Del_UC book_Del_uc1;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Panel Topbar;
        private Panel Bottombar;
        private Label mini_dash_label;
        private Label exit_dash_label;
        private PictureBox dogebox;
        private PictureBox pictureBox1;
        private Button ausleih_button;
        private Button rueckgabe_button;
        private Button user_list;
        private Button books_list;
        private Button book_add_new;
        private Button new_user;
        private Button book_delete;
        private Panel panel2;
        private Panel panel3;
        private Button itemout_list;
        private Button button2;
        private Itemout_UC itemout_uc1;
        private Dashboard_UC dashboard_uc1;
        private Panel panel1;
        public Label username_label;
    }
}