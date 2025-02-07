namespace Bücherei_Windows_App
{
    partial class Dashboard_UC
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            due_soon_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)due_soon_dgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // due_soon_dgv
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            due_soon_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            due_soon_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            due_soon_dgv.ColumnHeadersHeight = 4;
            due_soon_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            due_soon_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            due_soon_dgv.GridColor = Color.FromArgb(231, 229, 255);
            due_soon_dgv.Location = new Point(25, 58);
            due_soon_dgv.Name = "due_soon_dgv";
            due_soon_dgv.RowHeadersVisible = false;
            due_soon_dgv.RowTemplate.Height = 25;
            due_soon_dgv.Size = new Size(240, 598);
            due_soon_dgv.TabIndex = 0;
            due_soon_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            due_soon_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            due_soon_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            due_soon_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            due_soon_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            due_soon_dgv.ThemeStyle.BackColor = Color.White;
            due_soon_dgv.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            due_soon_dgv.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            due_soon_dgv.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            due_soon_dgv.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            due_soon_dgv.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            due_soon_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            due_soon_dgv.ThemeStyle.HeaderStyle.Height = 4;
            due_soon_dgv.ThemeStyle.ReadOnly = false;
            due_soon_dgv.ThemeStyle.RowsStyle.BackColor = Color.White;
            due_soon_dgv.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            due_soon_dgv.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            due_soon_dgv.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            due_soon_dgv.ThemeStyle.RowsStyle.Height = 25;
            due_soon_dgv.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            due_soon_dgv.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 641);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(5, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 35);
            label1.TabIndex = 0;
            label1.Text = "Abgabetermine";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dashboard_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(due_soon_dgv);
            Controls.Add(panel1);
            Name = "Dashboard_UC";
            Size = new Size(1277, 681);
            Load += Dashboard_UC_Load;
            ((System.ComponentModel.ISupportInitialize)due_soon_dgv).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView due_soon_dgv;
        private Panel panel1;
        private Label label1;
    }
}
