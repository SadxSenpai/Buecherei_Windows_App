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
            this.panel1 = new System.Windows.Forms.Panel();
            this.book_info_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.book_add_finish_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.book_type_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.book_name_tb = new System.Windows.Forms.TextBox();
            this.book_author_tb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.book_author_tb);
            this.panel1.Controls.Add(this.book_name_tb);
            this.panel1.Controls.Add(this.book_info_tb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.book_add_finish_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.book_type_cb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 643);
            this.panel1.TabIndex = 0;
            // 
            // book_info_tb
            // 
            this.book_info_tb.Location = new System.Drawing.Point(176, 418);
            this.book_info_tb.Multiline = true;
            this.book_info_tb.Name = "book_info_tb";
            this.book_info_tb.Size = new System.Drawing.Size(207, 96);
            this.book_info_tb.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Bemerkung";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Author";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // book_add_finish_btn
            // 
            this.book_add_finish_btn.Location = new System.Drawing.Point(67, 582);
            this.book_add_finish_btn.Name = "book_add_finish_btn";
            this.book_add_finish_btn.Size = new System.Drawing.Size(250, 42);
            this.book_add_finish_btn.TabIndex = 7;
            this.book_add_finish_btn.Text = "Abgabe";
            this.book_add_finish_btn.UseVisualStyleBackColor = true;
            this.book_add_finish_btn.Click += new System.EventHandler(this.book_add_finish_btn_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Art";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // book_type_cb
            // 
            this.book_type_cb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_type_cb.FormattingEnabled = true;
            this.book_type_cb.Items.AddRange(new object[] {
            "Buch",
            "Buch + CD",
            "Heft",
            "Heft + CD"});
            this.book_type_cb.Location = new System.Drawing.Point(176, 181);
            this.book_type_cb.Name = "book_type_cb";
            this.book_type_cb.Size = new System.Drawing.Size(207, 33);
            this.book_type_cb.TabIndex = 1;
            this.book_type_cb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.book_type_cb_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buch";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_label.Location = new System.Drawing.Point(374, 0);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(30, 32);
            this.exit_label.TabIndex = 1;
            this.exit_label.Text = "X";
            this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
            this.exit_label.MouseEnter += new System.EventHandler(this.exit_label_MouseEnter);
            this.exit_label.MouseLeave += new System.EventHandler(this.exit_label_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Buch Rückgabe";
            // 
            // book_name_tb
            // 
            this.book_name_tb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_name_tb.Location = new System.Drawing.Point(176, 49);
            this.book_name_tb.Name = "book_name_tb";
            this.book_name_tb.Size = new System.Drawing.Size(207, 33);
            this.book_name_tb.TabIndex = 19;
            // 
            // book_author_tb
            // 
            this.book_author_tb.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_author_tb.Location = new System.Drawing.Point(176, 115);
            this.book_author_tb.Name = "book_author_tb";
            this.book_author_tb.Size = new System.Drawing.Size(207, 33);
            this.book_author_tb.TabIndex = 20;
            // 
            // Book_add_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.exit_label);
            this.Controls.Add(this.panel1);
            this.Name = "Book_add_UC";
            this.Size = new System.Drawing.Size(404, 681);
            this.Load += new System.EventHandler(this.Book_add_UC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
