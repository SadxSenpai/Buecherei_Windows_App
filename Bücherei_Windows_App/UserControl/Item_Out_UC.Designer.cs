namespace Bücherei_Windows_App
{
    partial class Item_Out_UC
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
            item_date_in_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            item_name_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            item_note_tb = new TextBox();
            item_date_out_tb = new TextBox();
            item_with_who_tb = new TextBox();
            item_type_tb = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            book_out_finish_btn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            exit_label = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(item_date_in_cb);
            panel1.Controls.Add(item_name_cb);
            panel1.Controls.Add(item_note_tb);
            panel1.Controls.Add(item_date_out_tb);
            panel1.Controls.Add(item_with_who_tb);
            panel1.Controls.Add(item_type_tb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(book_out_finish_btn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 643);
            panel1.TabIndex = 0;
            // 
            // item_date_in_cb
            // 
            item_date_in_cb.BackColor = Color.Transparent;
            item_date_in_cb.DrawMode = DrawMode.OwnerDrawFixed;
            item_date_in_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            item_date_in_cb.FocusedColor = Color.FromArgb(94, 148, 255);
            item_date_in_cb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            item_date_in_cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_date_in_cb.ForeColor = Color.FromArgb(68, 88, 112);
            item_date_in_cb.ItemHeight = 30;
            item_date_in_cb.Location = new Point(176, 343);
            item_date_in_cb.Name = "item_date_in_cb";
            item_date_in_cb.Size = new Size(207, 36);
            item_date_in_cb.TabIndex = 40;
            // 
            // item_name_cb
            // 
            item_name_cb.BackColor = Color.Transparent;
            item_name_cb.DrawMode = DrawMode.OwnerDrawFixed;
            item_name_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            item_name_cb.FocusedColor = Color.FromArgb(94, 148, 255);
            item_name_cb.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            item_name_cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_name_cb.ForeColor = Color.FromArgb(68, 88, 112);
            item_name_cb.ItemHeight = 30;
            item_name_cb.Location = new Point(176, 51);
            item_name_cb.Name = "item_name_cb";
            item_name_cb.Size = new Size(207, 36);
            item_name_cb.TabIndex = 39;
            item_name_cb.SelectedIndexChanged += item_name_cb_SelectedIndexChanged;
            // 
            // item_note_tb
            // 
            item_note_tb.Location = new Point(176, 417);
            item_note_tb.Multiline = true;
            item_note_tb.Name = "item_note_tb";
            item_note_tb.Size = new Size(207, 96);
            item_note_tb.TabIndex = 38;
            // 
            // item_date_out_tb
            // 
            item_date_out_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_date_out_tb.Location = new Point(176, 269);
            item_date_out_tb.Name = "item_date_out_tb";
            item_date_out_tb.ReadOnly = true;
            item_date_out_tb.Size = new Size(207, 39);
            item_date_out_tb.TabIndex = 36;
            // 
            // item_with_who_tb
            // 
            item_with_who_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_with_who_tb.Location = new Point(176, 195);
            item_with_who_tb.Name = "item_with_who_tb";
            item_with_who_tb.Size = new Size(207, 39);
            item_with_who_tb.TabIndex = 35;
            // 
            // item_type_tb
            // 
            item_type_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            item_type_tb.Location = new Point(176, 121);
            item_type_tb.Name = "item_type_tb";
            item_type_tb.Size = new Size(207, 39);
            item_type_tb.TabIndex = 34;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 416);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 13;
            label7.Text = "Bemerkung";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 343);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 11;
            label6.Text = "Abgabe am:";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 270);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 9;
            label5.Text = "Ausgabe am:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // book_out_finish_btn
            // 
            book_out_finish_btn.Location = new Point(67, 582);
            book_out_finish_btn.Name = "book_out_finish_btn";
            book_out_finish_btn.Size = new Size(250, 42);
            book_out_finish_btn.TabIndex = 7;
            book_out_finish_btn.Text = "Ausgabe";
            book_out_finish_btn.UseVisualStyleBackColor = true;
            book_out_finish_btn.Click += book_out_finish_btn_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 197);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 4;
            label3.Text = "An";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 124);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "item_type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 51);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "item_name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exit_label
            // 
            exit_label.AutoSize = true;
            exit_label.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            exit_label.Location = new Point(374, 0);
            exit_label.Name = "exit_label";
            exit_label.Size = new Size(38, 41);
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
            label4.Size = new Size(217, 41);
            label4.TabIndex = 6;
            label4.Text = "Buch Ausgabe";
            // 
            // Book_Out_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(exit_label);
            Controls.Add(panel1);
            Name = "Book_Out_UC";
            Size = new Size(404, 681);
            Load += Book_Out_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit_label;
        private Label label1;
        private Label label6;
        private Label label5;
        private Button book_out_finish_btn;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label7;
        private TextBox item_note_tb;
        private TextBox item_date_out_tb;
        private TextBox item_with_who_tb;
        private TextBox item_type_tb;
        private Guna.UI2.WinForms.Guna2ComboBox item_name_cb;
        private Guna.UI2.WinForms.Guna2ComboBox item_date_in_cb;
    }
}
