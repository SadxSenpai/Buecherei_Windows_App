namespace Bücherei_Windows_App
{
    partial class Item_add_UC
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
            item_note_tb = new TextBox();
            item_type_tb = new TextBox();
            item_id_tb = new TextBox();
            item_origin_tb = new TextBox();
            item_count_tb = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label7 = new Label();
            label5 = new Label();
            item_add_finish_btn = new Button();
            label2 = new Label();
            label1 = new Label();
            exit_label = new Label();
            label4 = new Label();
            item_name_tb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(46, 49, 49);
            panel1.Controls.Add(item_name_tb);
            panel1.Controls.Add(item_note_tb);
            panel1.Controls.Add(item_type_tb);
            panel1.Controls.Add(item_id_tb);
            panel1.Controls.Add(item_origin_tb);
            panel1.Controls.Add(item_count_tb);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(item_add_finish_btn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 643);
            panel1.TabIndex = 0;
            // 
            // item_note_tb
            // 
            item_note_tb.Location = new Point(175, 417);
            item_note_tb.Multiline = true;
            item_note_tb.Name = "item_note_tb";
            item_note_tb.Size = new Size(208, 96);
            item_note_tb.TabIndex = 32;
            // 
            // item_type_tb
            // 
            item_type_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            item_type_tb.Location = new Point(176, 343);
            item_type_tb.Name = "item_type_tb";
            item_type_tb.Size = new Size(207, 33);
            item_type_tb.TabIndex = 31;
            // 
            // item_id_tb
            // 
            item_id_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            item_id_tb.Location = new Point(176, 269);
            item_id_tb.Name = "item_id_tb";
            item_id_tb.Size = new Size(207, 33);
            item_id_tb.TabIndex = 30;
            // 
            // item_origin_tb
            // 
            item_origin_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            item_origin_tb.Location = new Point(176, 195);
            item_origin_tb.Name = "item_origin_tb";
            item_origin_tb.Size = new Size(207, 33);
            item_origin_tb.TabIndex = 29;
            // 
            // item_count_tb
            // 
            item_count_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            item_count_tb.Location = new Point(176, 121);
            item_count_tb.Name = "item_count_tb";
            item_count_tb.Size = new Size(207, 33);
            item_count_tb.TabIndex = 28;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 124);
            label6.Name = "label6";
            label6.Size = new Size(156, 23);
            label6.TabIndex = 26;
            label6.Text = "item_count";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 270);
            label3.Name = "label3";
            label3.Size = new Size(156, 23);
            label3.TabIndex = 24;
            label3.Text = "item_id";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(3, 416);
            label7.Name = "label7";
            label7.Size = new Size(156, 23);
            label7.TabIndex = 13;
            label7.Text = "item_note";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 197);
            label5.Name = "label5";
            label5.Size = new Size(156, 23);
            label5.TabIndex = 9;
            label5.Text = "item_origin";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // item_add_finish_btn
            // 
            item_add_finish_btn.Location = new Point(67, 582);
            item_add_finish_btn.Name = "item_add_finish_btn";
            item_add_finish_btn.Size = new Size(250, 42);
            item_add_finish_btn.TabIndex = 7;
            item_add_finish_btn.Text = "Hinzufügen";
            item_add_finish_btn.UseVisualStyleBackColor = true;
            item_add_finish_btn.Click += item_add_finish_btn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 343);
            label2.Name = "label2";
            label2.Size = new Size(156, 23);
            label2.TabIndex = 2;
            label2.Text = "item_type";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 51);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 0;
            label1.Text = "Item_name";
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
            label4.Size = new Size(148, 32);
            label4.TabIndex = 6;
            label4.Text = "Neues Buch";
            // 
            // item_name_tb
            // 
            item_name_tb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            item_name_tb.Location = new Point(175, 47);
            item_name_tb.Name = "item_name_tb";
            item_name_tb.Size = new Size(207, 33);
            item_name_tb.TabIndex = 33;
            // 
            // Book_add_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(exit_label);
            Controls.Add(panel1);
            Name = "Book_add_UC";
            Size = new Size(404, 681);
            Load += Book_add_UC_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit_label;
        private ComboBox book_type_cb;
        private Label label1;
        private Label label5;
        private Button item_add_finish_btn;
        private Label label2;
        private Label label4;
        private Label label7;
        private TextBox book_name_tb;
        private TextBox book_author_tb;
        private Label label3;
        private TextBox book_isbn_tb;
        private Label label6;
        private TextBox item_type_tb;
        private TextBox item_id_tb;
        private TextBox item_origin_tb;
        private TextBox item_count_tb;
        private TextBox book_count_tb;
        private TextBox item_note_tb;
        private TextBox item_name_tb;
    }
}
