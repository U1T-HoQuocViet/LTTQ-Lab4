namespace BTTH5
{
    partial class FormThemSinhVien1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            mssvTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tenSVTextBox = new TextBox();
            diemTBTextBox = new TextBox();
            themButton = new Button();
            thoatButton = new Button();
            khoaComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 82);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã số Sinh Viên";
            // 
            // mssvTextBox
            // 
            mssvTextBox.Location = new Point(175, 79);
            mssvTextBox.Name = "mssvTextBox";
            mssvTextBox.Size = new Size(336, 27);
            mssvTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 148);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên Sinh Viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 217);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 3;
            label3.Text = "Khoa";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 281);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 4;
            label4.Text = "Điểm TB";
            // 
            // tenSVTextBox
            // 
            tenSVTextBox.Location = new Point(175, 145);
            tenSVTextBox.Name = "tenSVTextBox";
            tenSVTextBox.Size = new Size(390, 27);
            tenSVTextBox.TabIndex = 5;
            // 
            // diemTBTextBox
            // 
            diemTBTextBox.Location = new Point(175, 278);
            diemTBTextBox.Name = "diemTBTextBox";
            diemTBTextBox.Size = new Size(60, 27);
            diemTBTextBox.TabIndex = 7;
            // 
            // themButton
            // 
            themButton.BackColor = Color.Lime;
            themButton.Location = new Point(306, 347);
            themButton.Name = "themButton";
            themButton.Size = new Size(103, 35);
            themButton.TabIndex = 8;
            themButton.Text = "Thêm";
            themButton.UseVisualStyleBackColor = false;
            themButton.Click += themButton_Click;
            // 
            // thoatButton
            // 
            thoatButton.BackColor = Color.FromArgb(255, 128, 0);
            thoatButton.Location = new Point(445, 347);
            thoatButton.Name = "thoatButton";
            thoatButton.Size = new Size(100, 35);
            thoatButton.TabIndex = 9;
            thoatButton.Text = "Thoát";
            thoatButton.UseVisualStyleBackColor = false;
            thoatButton.Click += thoatButton_Click;
            // 
            // khoaComboBox
            // 
            khoaComboBox.FormattingEnabled = true;
            khoaComboBox.Items.AddRange(new object[] { "Khoa học Máy tính", "Kỹ thuật Máy tính", "Công nghệ Phần mềm", "Hệ thống Thông tin", "Mạng máy tính và Truyền thông", "Khoa học và Kĩ thuật máy tính" });
            khoaComboBox.Location = new Point(175, 214);
            khoaComboBox.Name = "khoaComboBox";
            khoaComboBox.Size = new Size(390, 28);
            khoaComboBox.TabIndex = 10;
            // 
            // FormThemSinhVien1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 428);
            Controls.Add(khoaComboBox);
            Controls.Add(thoatButton);
            Controls.Add(themButton);
            Controls.Add(diemTBTextBox);
            Controls.Add(tenSVTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(mssvTextBox);
            Controls.Add(label1);
            Name = "FormThemSinhVien1";
            Text = "Form Thêm Sinh Viên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox mssvTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tenSVTextBox;
        private TextBox diemTBTextBox;
        private Button themButton;
        private Button thoatButton;
        private ComboBox khoaComboBox;
    }
}