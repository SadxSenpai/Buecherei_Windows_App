namespace Bücherei_Windows_App
{
    partial class Book_Out_UC
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
            this.book_name_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.book_name_cb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 619);
            this.panel1.TabIndex = 0;
            // 
            // book_name_cb
            // 
            this.book_name_cb.FormattingEnabled = true;
            this.book_name_cb.Location = new System.Drawing.Point(109, 53);
            this.book_name_cb.Name = "book_name_cb";
            this.book_name_cb.Size = new System.Drawing.Size(274, 23);
            this.book_name_cb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
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
            // Book_Out_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.exit_label);
            this.Controls.Add(this.panel1);
            this.Name = "Book_Out_UC";
            this.Size = new System.Drawing.Size(404, 657);
            this.Load += new System.EventHandler(this.Book_Out_UC_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label exit_label;
        private ComboBox book_name_cb;
        private Label label1;
    }
}
