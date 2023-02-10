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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.books_list = new System.Windows.Forms.Button();
            this.user_list = new System.Windows.Forms.Button();
            this.rueckgabe_button = new System.Windows.Forms.Button();
            this.ausleih_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_books = new System.Windows.Forms.PictureBox();
            this.book_Out_uc1 = new Bücherei_Windows_App.Book_Out_UC();
            this.booklist_uc1 = new Bücherei_Windows_App.Booklist_UC();
            this.userlist_uc1 = new Bücherei_Windows_App.Userlist_UC();
            this.book_In_uc1 = new Bücherei_Windows_App.Book_In_UC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.books_list);
            this.panel1.Controls.Add(this.user_list);
            this.panel1.Controls.Add(this.rueckgabe_button);
            this.panel1.Controls.Add(this.ausleih_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox_books);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 681);
            this.panel1.TabIndex = 0;
            // 
            // books_list
            // 
            this.books_list.BackColor = System.Drawing.Color.LavenderBlush;
            this.books_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.books_list.FlatAppearance.BorderSize = 0;
            this.books_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.books_list.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books_list.Location = new System.Drawing.Point(6, 563);
            this.books_list.Name = "books_list";
            this.books_list.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.books_list.Size = new System.Drawing.Size(251, 50);
            this.books_list.TabIndex = 6;
            this.books_list.Text = "Buchliste";
            this.books_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.books_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.books_list.UseVisualStyleBackColor = false;
            this.books_list.Click += new System.EventHandler(this.books_list_Click);
            // 
            // user_list
            // 
            this.user_list.BackColor = System.Drawing.Color.LavenderBlush;
            this.user_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_list.FlatAppearance.BorderSize = 0;
            this.user_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.user_list.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user_list.Location = new System.Drawing.Point(6, 619);
            this.user_list.Name = "user_list";
            this.user_list.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.user_list.Size = new System.Drawing.Size(251, 50);
            this.user_list.TabIndex = 5;
            this.user_list.Text = "User Management";
            this.user_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user_list.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.user_list.UseVisualStyleBackColor = false;
            this.user_list.Click += new System.EventHandler(this.user_list_Click);
            // 
            // rueckgabe_button
            // 
            this.rueckgabe_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.rueckgabe_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rueckgabe_button.FlatAppearance.BorderSize = 0;
            this.rueckgabe_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rueckgabe_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rueckgabe_button.ForeColor = System.Drawing.Color.White;
            this.rueckgabe_button.Location = new System.Drawing.Point(3, 200);
            this.rueckgabe_button.Name = "rueckgabe_button";
            this.rueckgabe_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rueckgabe_button.Size = new System.Drawing.Size(254, 50);
            this.rueckgabe_button.TabIndex = 4;
            this.rueckgabe_button.Text = "Rückgabe";
            this.rueckgabe_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rueckgabe_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.rueckgabe_button.UseVisualStyleBackColor = false;
            this.rueckgabe_button.Click += new System.EventHandler(this.rueckgabe_button_Click);
            // 
            // ausleih_button
            // 
            this.ausleih_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.ausleih_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ausleih_button.FlatAppearance.BorderSize = 0;
            this.ausleih_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ausleih_button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ausleih_button.ForeColor = System.Drawing.Color.White;
            this.ausleih_button.Location = new System.Drawing.Point(3, 144);
            this.ausleih_button.Name = "ausleih_button";
            this.ausleih_button.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ausleih_button.Size = new System.Drawing.Size(254, 50);
            this.ausleih_button.TabIndex = 3;
            this.ausleih_button.Text = "Ausleihen";
            this.ausleih_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ausleih_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ausleih_button.UseVisualStyleBackColor = false;
            this.ausleih_button.Click += new System.EventHandler(this.ausleih_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 10);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(118, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "LMS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_books
            // 
            this.pictureBox_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox_books.Image = global::Bücherei_Windows_App.Properties.Resources.Book;
            this.pictureBox_books.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_books.Name = "pictureBox_books";
            this.pictureBox_books.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_books.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_books.TabIndex = 1;
            this.pictureBox_books.TabStop = false;
            // 
            // book_Out_uc1
            // 
            this.book_Out_uc1.BackColor = System.Drawing.Color.White;
            this.book_Out_uc1.Location = new System.Drawing.Point(260, 0);
            this.book_Out_uc1.Name = "book_Out_uc1";
            this.book_Out_uc1.Size = new System.Drawing.Size(404, 681);
            this.book_Out_uc1.TabIndex = 1;
            // 
            // booklist_uc1
            // 
            this.booklist_uc1.BackColor = System.Drawing.Color.White;
            this.booklist_uc1.Location = new System.Drawing.Point(260, 0);
            this.booklist_uc1.Name = "booklist_uc1";
            this.booklist_uc1.Size = new System.Drawing.Size(974, 681);
            this.booklist_uc1.TabIndex = 2;
            // 
            // userlist_uc1
            // 
            this.userlist_uc1.BackColor = System.Drawing.Color.White;
            this.userlist_uc1.Location = new System.Drawing.Point(260, 0);
            this.userlist_uc1.Name = "userlist_uc1";
            this.userlist_uc1.Size = new System.Drawing.Size(974, 646);
            this.userlist_uc1.TabIndex = 3;
            // 
            // book_In_uc1
            // 
            this.book_In_uc1.BackColor = System.Drawing.Color.White;
            this.book_In_uc1.Location = new System.Drawing.Point(260, 0);
            this.book_In_uc1.Name = "book_In_uc1";
            this.book_In_uc1.Size = new System.Drawing.Size(404, 681);
            this.book_In_uc1.TabIndex = 4;
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.book_In_uc1);
            this.Controls.Add(this.userlist_uc1);
            this.Controls.Add(this.booklist_uc1);
            this.Controls.Add(this.book_Out_uc1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Form_Load);
            this.Shown += new System.EventHandler(this.Dashboard_Form_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox_books;
        private Panel panel2;
        private Button books_list;
        private Button user_list;
        private Button rueckgabe_button;
        private Button ausleih_button;
        private Booklist_UC booklist_uc1;
        private Userlist_UC userlist_uc1;
        private Book_Out_UC book_Out_uc1;
        private Book_In_UC book_In_uc1;
    }
}