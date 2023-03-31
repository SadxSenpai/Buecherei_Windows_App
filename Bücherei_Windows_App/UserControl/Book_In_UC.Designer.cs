namespace Bücherei_Windows_App
{
    partial class Book_In_UC
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
            user_name_cb = new ComboBox();
            label3 = new Label();
            item_type_tb = new Label();
            today_date_label = new Label();
            item_note_tb = new TextBox();
            label7 = new Label();
            label5 = new Label();
            item_in_finish_btn = new Button();
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
            panel1.Controls.Add(user_name_cb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(item_type_tb);
            panel1.Controls.Add(today_date_label);
            panel1.Controls.Add(item_note_tb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(item_in_finish_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(item_name_cb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 643);
            panel1.TabIndex = 0;
            // 
            // user_name_cb
            // 
            user_name_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            user_name_cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            user_name_cb.FormattingEnabled = true;
            user_name_cb.Location = new Point(176, 53);
            user_name_cb.Name = "user_name_cb";
            user_name_cb.Size = new Size(207, 33);
            user_name_cb.TabIndex = 1;
            user_name_cb.SelectedIndexChanged += user_name_cb_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 19;
            label3.Text = "Teilnehmer";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_type_tb
            // 
            item_type_tb.BackColor = Color.White;
            item_type_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            item_type_tb.ForeColor = Color.Black;
            item_type_tb.Location = new Point(176, 185);
            item_type_tb.Name = "item_type_tb";
            item_type_tb.Size = new Size(207, 23);
            item_type_tb.TabIndex = 3;
            item_type_tb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // today_date_label
            // 
            today_date_label.BackColor = Color.White;
            today_date_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            today_date_label.ForeColor = Color.Black;
            today_date_label.Location = new Point(176, 251);
            today_date_label.Name = "today_date_label";
            today_date_label.Size = new Size(207, 23);
            today_date_label.TabIndex = 4;
            today_date_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_note_tb
            // 
            item_note_tb.Location = new Point(176, 418);
            item_note_tb.Multiline = true;
            item_note_tb.Name = "item_note_tb";
            item_note_tb.Size = new Size(207, 96);
            item_note_tb.TabIndex = 5;
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
            label5.Location = new Point(3, 251);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 9;
            label5.Text = "Rückgabe am:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_in_finish_btn
            // 
            item_in_finish_btn.Location = new Point(67, 582);
            item_in_finish_btn.Name = "item_in_finish_btn";
            item_in_finish_btn.Size = new Size(250, 42);
            item_in_finish_btn.TabIndex = 6;
            item_in_finish_btn.Text = "Rückgabe";
            item_in_finish_btn.UseVisualStyleBackColor = true;
            item_in_finish_btn.Click += item_in_finish_btn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 185);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "Art";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_name_cb
            // 
            item_name_cb.DropDownStyle = ComboBoxStyle.DropDownList;
            item_name_cb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            item_name_cb.FormattingEnabled = true;
            item_name_cb.Location = new Point(176, 115);
            item_name_cb.Name = "item_name_cb";
            item_name_cb.Size = new Size(207, 33);
            item_name_cb.TabIndex = 2;
            item_name_cb.SelectedIndexChanged += item_name_cb_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 119);
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
            label4.Size = new Size(189, 32);
            label4.TabIndex = 6;
            label4.Text = "Buch Rückgabe";
            // 
            // Book_In_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(exit_label);
            Controls.Add(panel1);
            Name = "Book_In_UC";
            Size = new Size(404, 681);
            Load += Book_In_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit_label;
        private Label label1;
        private Label label5;
        private Button item_in_finish_btn;
        private Label label2;
        private Label label4;
        private TextBox item_note_tb;
        private Label label7;
        private Label today_date_label;
        private Label item_type_tb;
        private ComboBox user_name_cb;
        private Label label3;
        private ComboBox item_name_cb;
    }
}
