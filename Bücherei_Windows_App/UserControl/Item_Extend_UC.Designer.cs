namespace Bücherei_Windows_App.UserControl
{
    partial class Item_Extend_UC : System.Windows.Forms.UserControl
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
            label6 = new Label();
            item_count_tb = new Label();
            item_type_tb = new Label();
            today_date_label = new Label();
            item_del_why_tb = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label2 = new Label();
            item_name_cb = new ComboBox();
            label1 = new Label();
            exit_label = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(item_count_tb);
            panel1.Controls.Add(item_type_tb);
            panel1.Controls.Add(today_date_label);
            panel1.Controls.Add(item_del_why_tb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(item_name_cb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 643);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 175);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 20;
            label6.Text = "menge";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_count_tb
            // 
            item_count_tb.BackColor = Color.White;
            item_count_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_count_tb.ForeColor = Color.Black;
            item_count_tb.Location = new Point(176, 179);
            item_count_tb.Name = "item_count_tb";
            item_count_tb.Size = new Size(207, 23);
            item_count_tb.TabIndex = 19;
            item_count_tb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_type_tb
            // 
            item_type_tb.BackColor = Color.White;
            item_type_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_type_tb.ForeColor = Color.Black;
            item_type_tb.Location = new Point(176, 121);
            item_type_tb.Name = "item_type_tb";
            item_type_tb.Size = new Size(207, 23);
            item_type_tb.TabIndex = 18;
            item_type_tb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // today_date_label
            // 
            today_date_label.BackColor = Color.White;
            today_date_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            today_date_label.ForeColor = Color.Black;
            today_date_label.Location = new Point(176, 237);
            today_date_label.Name = "today_date_label";
            today_date_label.Size = new Size(207, 23);
            today_date_label.TabIndex = 15;
            today_date_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_del_why_tb
            // 
            item_del_why_tb.Location = new Point(176, 418);
            item_del_why_tb.Multiline = true;
            item_del_why_tb.Name = "item_del_why_tb";
            item_del_why_tb.Size = new Size(207, 96);
            item_del_why_tb.TabIndex = 14;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
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
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 237);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 9;
            label5.Text = "Gelöscht am:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 114);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Art";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_name_cb
            // 
            item_name_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            item_name_cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_name_cb.FormattingEnabled = true;
            item_name_cb.Location = new Point(176, 53);
            item_name_cb.Name = "item_name_cb";
            item_name_cb.Size = new Size(207, 33);
            item_name_cb.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 53);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "Buch";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exit_label
            // 
            exit_label.AutoSize = true;
            exit_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
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
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 32);
            label4.TabIndex = 6;
            label4.Text = "Buch Verlängern";
            // 
            // Item_Extend_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(exit_label);
            Controls.Add(panel1);
            Name = "Item_Extend_UC";
            Size = new Size(404, 681);
            Load += Item_Extend_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit_label;
        private ComboBox item_name_cb;
        private Label label1;
        private Label label5;
        private Label label2;
        private Label label4;
        private TextBox item_del_why_tb;
        private Label label7;
        private Label today_date_label;
        private Label item_type_tb;
        private Label label6;
        private Label item_count_tb;
    }
}
