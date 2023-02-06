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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox_books = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.books_count = new System.Windows.Forms.Label();
            this.books_free = new System.Windows.Forms.Label();
            this.books_taken = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox_books);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 10);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(266, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 657);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.books_count);
            this.panel4.Location = new System.Drawing.Point(17, 21);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 195);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(167)))), ((int)(((byte)(240)))));
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.books_free);
            this.panel5.Location = new System.Drawing.Point(352, 21);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(285, 195);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(126)))), ((int)(((byte)(4)))));
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.books_taken);
            this.panel6.Location = new System.Drawing.Point(687, 21);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(285, 195);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(17, 241);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(143, 399);
            this.panel7.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(196, 386);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(776, 254);
            this.panel8.TabIndex = 2;
            // 
            // books_count
            // 
            this.books_count.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books_count.Location = new System.Drawing.Point(-2, 96);
            this.books_count.Name = "books_count";
            this.books_count.Size = new System.Drawing.Size(285, 42);
            this.books_count.TabIndex = 3;
            this.books_count.Text = "999";
            this.books_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.books_count.Click += new System.EventHandler(this.label2_Click);
            // 
            // books_free
            // 
            this.books_free.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books_free.Location = new System.Drawing.Point(0, 96);
            this.books_free.Name = "books_free";
            this.books_free.Size = new System.Drawing.Size(285, 42);
            this.books_free.TabIndex = 4;
            this.books_free.Text = "999";
            this.books_free.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.books_free.Click += new System.EventHandler(this.books_free_Click);
            // 
            // books_taken
            // 
            this.books_taken.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.books_taken.Location = new System.Drawing.Point(0, 96);
            this.books_taken.Name = "books_taken";
            this.books_taken.Size = new System.Drawing.Size(285, 42);
            this.books_taken.TabIndex = 5;
            this.books_taken.Text = "999";
            this.books_taken.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(84)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 42);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ausgeliehende Bücher";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(240)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 42);
            this.label8.TabIndex = 5;
            this.label8.Text = "Freie Bücher";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(30)))), ((int)(((byte)(24)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(285, 42);
            this.label9.TabIndex = 4;
            this.label9.Text = "Alle Bücher";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(776, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kürzlich Hinzugefügt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Dashboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard_Form";
            this.Text = "Dashboard_Form";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_books)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox_books;
        private Panel panel2;
        private Panel panel3;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Label books_count;
        private Label label5;
        private Label books_taken;
        private Label label8;
        private Label books_free;
        private Label label9;
        private Label label2;
    }
}