namespace Bücherei_Windows_App
{
    partial class Itemout_UC
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            exit_label = new Label();
            panel1 = new Panel();
            search_tb = new TextBox();
            Item_list_datagrid = new DataGridView();
            dBConBindingSource = new BindingSource(components);
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Item_list_datagrid).BeginInit();
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
            panel1.Controls.Add(Item_list_datagrid);
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
            // Item_list_datagrid
            // 
            Item_list_datagrid.AllowUserToAddRows = false;
            Item_list_datagrid.AllowUserToDeleteRows = false;
            Item_list_datagrid.AllowUserToResizeColumns = false;
            Item_list_datagrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            Item_list_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            Item_list_datagrid.BackgroundColor = Color.FromArgb(46, 49, 49);
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            Item_list_datagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            Item_list_datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            Item_list_datagrid.DefaultCellStyle = dataGridViewCellStyle9;
            Item_list_datagrid.GridColor = Color.Black;
            Item_list_datagrid.Location = new Point(3, 34);
            Item_list_datagrid.Name = "Item_list_datagrid";
            Item_list_datagrid.ReadOnly = true;
            Item_list_datagrid.RowHeadersWidth = 25;
            Item_list_datagrid.RowTemplate.Height = 25;
            Item_list_datagrid.Size = new Size(962, 571);
            Item_list_datagrid.TabIndex = 0;
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
            label1.Text = "Ausgeliehendes";
            // 
            // Itemout_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(exit_label);
            Name = "Itemout_UC";
            Size = new Size(974, 646);
            Load += Itemout_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Item_list_datagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)dBConBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label exit_label;
        private Panel panel1;
        private DataGridView Item_list_datagrid;
        private Label label1;
        private BindingSource dBConBindingSource;
        private TextBox search_tb;
    }
}
