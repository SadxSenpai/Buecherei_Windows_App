namespace Bücherei_Windows_App
{
    partial class Booklist_UC
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
            this.exit_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.book_list_datagrid = new System.Windows.Forms.DataGridView();
            this.SQL_Insert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.book_list_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_label
            // 
            this.exit_label.AutoSize = true;
            this.exit_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_label.Location = new System.Drawing.Point(960, 0);
            this.exit_label.Name = "exit_label";
            this.exit_label.Size = new System.Drawing.Size(30, 32);
            this.exit_label.TabIndex = 0;
            this.exit_label.Text = "X";
            this.exit_label.Click += new System.EventHandler(this.exit_label_Click);
            this.exit_label.MouseEnter += new System.EventHandler(this.exit_label_MouseEnter);
            this.exit_label.MouseLeave += new System.EventHandler(this.exit_label_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.book_list_datagrid);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 622);
            this.panel1.TabIndex = 1;
            // 
            // book_list_datagrid
            // 
            this.book_list_datagrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.book_list_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.book_list_datagrid.Location = new System.Drawing.Point(3, 3);
            this.book_list_datagrid.Name = "book_list_datagrid";
            this.book_list_datagrid.RowHeadersWidth = 25;
            this.book_list_datagrid.RowTemplate.Height = 25;
            this.book_list_datagrid.Size = new System.Drawing.Size(978, 616);
            this.book_list_datagrid.TabIndex = 0;
            // 
            // SQL_Insert
            // 
            this.SQL_Insert.Location = new System.Drawing.Point(6, 6);
            this.SQL_Insert.Name = "SQL_Insert";
            this.SQL_Insert.Size = new System.Drawing.Size(75, 23);
            this.SQL_Insert.TabIndex = 1;
            this.SQL_Insert.Text = "Insert Data";
            this.SQL_Insert.UseVisualStyleBackColor = true;
            // 
            // Booklist_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SQL_Insert);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit_label);
            this.Name = "Booklist_UC";
            this.Size = new System.Drawing.Size(990, 660);
            this.Load += new System.EventHandler(this.Booklist_UC_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.book_list_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label exit_label;
        private Panel panel1;
        private DataGridView book_list_datagrid;
        private Button SQL_Insert;
    }
}
