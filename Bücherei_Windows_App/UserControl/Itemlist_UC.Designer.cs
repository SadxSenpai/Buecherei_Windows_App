namespace Bücherei_Windows_App
{
    partial class Itemlist_UC
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            exit_label = new Label();
            panel1 = new Panel();
            search_tb = new TextBox();
            book_list_datagrid = new DataGridView();
            dBConBindingSource = new BindingSource(components);
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)book_list_datagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dBConBindingSource).BeginInit();
            SuspendLayout();
            // 
            // exit_label
            // 
            exit_label.AutoSize = true;
            exit_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            exit_label.Location = new Point(944, 0);
            exit_label.Name = "exit_label";
            exit_label.Size = new Size(30, 32);
            exit_label.TabIndex = 0;
            exit_label.Text = "X";
            exit_label.Click += exit_label_Click;
            exit_label.MouseEnter += exit_label_MouseEnter;
            exit_label.MouseLeave += exit_label_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(search_tb);
            panel1.Controls.Add(book_list_datagrid);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 608);
            panel1.TabIndex = 1;
            // 
            // search_tb
            // 
            search_tb.Location = new Point(3, 5);
            search_tb.Name = "search_tb";
            search_tb.PlaceholderText = "Suche";
            search_tb.Size = new Size(201, 23);
            search_tb.TabIndex = 1;
            search_tb.TextChanged += search_tb_TextChanged;
            // 
            // book_list_datagrid
            // 
            book_list_datagrid.AllowUserToAddRows = false;
            book_list_datagrid.AllowUserToDeleteRows = false;
            book_list_datagrid.AllowUserToResizeColumns = false;
            book_list_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            book_list_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            book_list_datagrid.BackgroundColor = Color.FromArgb(46, 49, 49);
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            book_list_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            book_list_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            book_list_datagrid.DefaultCellStyle = dataGridViewCellStyle6;
            book_list_datagrid.GridColor = Color.Black;
            book_list_datagrid.Location = new Point(3, 34);
            book_list_datagrid.Name = "book_list_datagrid";
            book_list_datagrid.ReadOnly = true;
            book_list_datagrid.RowHeadersWidth = 25;
            book_list_datagrid.RowTemplate.Height = 25;
            book_list_datagrid.Size = new Size(962, 571);
            book_list_datagrid.TabIndex = 0;
            // 
            // dBConBindingSource
            // 
            dBConBindingSource.DataSource = typeof(The_Database.DBCon);
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(302, 35);
            label1.TabIndex = 1;
            label1.Text = "Bücherliste";
            // 
            // Booklist_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(exit_label);
            Name = "Booklist_UC";
            Size = new Size(974, 646);
            Load += Booklist_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)book_list_datagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBConBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exit_label;
        private Panel panel1;
        private DataGridView book_list_datagrid;
        private Label label1;
        private BindingSource dBConBindingSource;
        private TextBox search_tb;
    }
}
