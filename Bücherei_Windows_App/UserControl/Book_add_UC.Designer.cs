namespace Bücherei_Windows_App
{
    partial class Book_add_UC
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
            label3 = new Label();
            book_isbn_tb = new TextBox();
            upload_btn = new Button();
            upload_imgbx = new PictureBox();
            book_author_tb = new TextBox();
            book_name_tb = new TextBox();
            book_info_tb = new TextBox();
            label7 = new Label();
            label5 = new Label();
            book_add_finish_btn = new Button();
            label2 = new Label();
            book_type_cb = new ComboBox();
            label1 = new Label();
            exit_label = new Label();
            label4 = new Label();
            book_count_tb = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)upload_imgbx).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(book_count_tb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(book_isbn_tb);
            panel1.Controls.Add(upload_btn);
            panel1.Controls.Add(upload_imgbx);
            panel1.Controls.Add(book_author_tb);
            panel1.Controls.Add(book_name_tb);
            panel1.Controls.Add(book_info_tb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(book_add_finish_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(book_type_cb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 643);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 142);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 24;
            label3.Text = "ISBN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // book_isbn_tb
            // 
            book_isbn_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            book_isbn_tb.Location = new Point(176, 138);
            book_isbn_tb.Name = "book_isbn_tb";
            book_isbn_tb.Size = new Size(207, 33);
            book_isbn_tb.TabIndex = 23;
            // 
            // upload_btn
            // 
            upload_btn.Location = new Point(29, 305);
            upload_btn.Name = "upload_btn";
            upload_btn.Size = new Size(110, 23);
            upload_btn.TabIndex = 22;
            upload_btn.Text = "Bild hinzufügen";
            upload_btn.UseVisualStyleBackColor = true;
            upload_btn.Click += upload_btn_Click;
            // 
            // upload_imgbx
            // 
            upload_imgbx.BackColor = Color.Transparent;
            upload_imgbx.Location = new Point(184, 220);
            upload_imgbx.Name = "upload_imgbx";
            upload_imgbx.Size = new Size(192, 192);
            upload_imgbx.SizeMode = PictureBoxSizeMode.StretchImage;
            upload_imgbx.TabIndex = 21;
            upload_imgbx.TabStop = false;
            // 
            // book_author_tb
            // 
            book_author_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            book_author_tb.Location = new Point(176, 98);
            book_author_tb.Name = "book_author_tb";
            book_author_tb.Size = new Size(207, 33);
            book_author_tb.TabIndex = 20;
            // 
            // book_name_tb
            // 
            book_name_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            book_name_tb.Location = new Point(176, 18);
            book_name_tb.Name = "book_name_tb";
            book_name_tb.Size = new Size(207, 33);
            book_name_tb.TabIndex = 19;
            // 
            // book_info_tb
            // 
            book_info_tb.Location = new Point(176, 418);
            book_info_tb.Multiline = true;
            book_info_tb.Name = "book_info_tb";
            book_info_tb.Size = new Size(207, 96);
            book_info_tb.TabIndex = 14;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 418);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 13;
            label7.Text = "Bemerkung";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 102);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 9;
            label5.Text = "Author";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // book_add_finish_btn
            // 
            book_add_finish_btn.Location = new Point(67, 582);
            book_add_finish_btn.Name = "book_add_finish_btn";
            book_add_finish_btn.Size = new Size(250, 42);
            book_add_finish_btn.TabIndex = 7;
            book_add_finish_btn.Text = "Hinzufügen";
            book_add_finish_btn.UseVisualStyleBackColor = true;
            book_add_finish_btn.Click += book_add_finish_btn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 182);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Art";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // book_type_cb
            // 
            book_type_cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            book_type_cb.FormattingEnabled = true;
            book_type_cb.Items.AddRange(new object[] { "Buch", "Buch + CD", "Heft", "Heft + CD" });
            book_type_cb.Location = new Point(176, 178);
            book_type_cb.Name = "book_type_cb";
            book_type_cb.Size = new Size(207, 33);
            book_type_cb.TabIndex = 1;
            book_type_cb.KeyPress += book_type_cb_KeyPress;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "Buch";
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
            label4.Size = new Size(148, 32);
            label4.TabIndex = 6;
            label4.Text = "Neues Buch";
            // 
            // book_count_tb
            // 
            book_count_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            book_count_tb.Location = new Point(176, 58);
            book_count_tb.Name = "book_count_tb";
            book_count_tb.Size = new Size(207, 33);
            book_count_tb.TabIndex = 25;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 62);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 26;
            label6.Text = "Menge";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Book_add_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(exit_label);
            Controls.Add(panel1);
            Name = "Book_add_UC";
            Size = new Size(404, 681);
            Load += Book_add_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)upload_imgbx).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit_label;
        private ComboBox book_type_cb;
        private Label label1;
        private Label label5;
        private Button book_add_finish_btn;
        private Label label2;
        private Label label4;
        private TextBox book_info_tb;
        private Label label7;
        private TextBox book_name_tb;
        private TextBox book_author_tb;
        private PictureBox upload_imgbx;
        private Button upload_btn;
        private Label label3;
        private TextBox book_isbn_tb;
        private Label label6;
        private TextBox book_count_tb;
    }
}
