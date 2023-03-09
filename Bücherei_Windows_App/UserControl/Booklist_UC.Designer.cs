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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            exit_label = new Label();
            panel1 = new Panel();
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
            panel1.Controls.Add(book_list_datagrid);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 608);
            panel1.TabIndex = 1;
            // 
            // book_list_datagrid
            // 
            book_list_datagrid.AllowUserToAddRows = false;
            book_list_datagrid.AllowUserToDeleteRows = false;
            book_list_datagrid.AllowUserToResizeColumns = false;
            book_list_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            book_list_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            book_list_datagrid.BackgroundColor = Color.FromArgb(46, 49, 49);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            book_list_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            book_list_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            book_list_datagrid.DefaultCellStyle = dataGridViewCellStyle3;
            book_list_datagrid.GridColor = Color.Black;
            book_list_datagrid.Location = new Point(3, 3);
            book_list_datagrid.Name = "book_list_datagrid";
            book_list_datagrid.ReadOnly = true;
            book_list_datagrid.RowHeadersWidth = 25;
            book_list_datagrid.RowTemplate.Height = 25;
            book_list_datagrid.Size = new Size(962, 602);
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
    }
}
