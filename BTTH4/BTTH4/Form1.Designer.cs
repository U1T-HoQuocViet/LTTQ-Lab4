namespace BTTH4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            taoMoiVanBanButton = new ToolStripMenuItem();
            createNewButton = new ToolStripMenuItem();
            openFileButton = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            saveFileButton = new ToolStripMenuItem();
            exitButton = new ToolStripMenuItem();
            formatButton = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            fontComboBox = new ToolStripComboBox();
            sizeComboBox = new ToolStripComboBox();
            toolStripSeparator4 = new ToolStripSeparator();
            boldButton = new ToolStripButton();
            italicButton = new ToolStripButton();
            underlineButton = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            richTextBox = new RichTextBox();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { taoMoiVanBanButton, formatButton });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // taoMoiVanBanButton
            // 
            taoMoiVanBanButton.DropDownItems.AddRange(new ToolStripItem[] { createNewButton, openFileButton, toolStripSeparator3, saveFileButton, exitButton });
            taoMoiVanBanButton.Name = "taoMoiVanBanButton";
            taoMoiVanBanButton.Size = new Size(85, 24);
            taoMoiVanBanButton.Text = "Hệ thống";
            // 
            // createNewButton
            // 
            createNewButton.Name = "createNewButton";
            createNewButton.Size = new Size(235, 26);
            createNewButton.Text = "Tạo văn bản mới";
            createNewButton.Click += createNewButton_Click;
            // 
            // openFileButton
            // 
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(235, 26);
            openFileButton.Text = "Mở tập tin";
            openFileButton.Click += openFileButton_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(232, 6);
            // 
            // saveFileButton
            // 
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(235, 26);
            saveFileButton.Text = "Lưu nội dung văn bản";
            saveFileButton.Click += saveFileButton_Click;
            // 
            // exitButton
            // 
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(235, 26);
            exitButton.Text = "Thoát";
            exitButton.Click += exitButton_Click;
            // 
            // formatButton
            // 
            formatButton.Name = "formatButton";
            formatButton.Size = new Size(94, 24);
            formatButton.Text = "Định Dạng";
            formatButton.Click += formatButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripSeparator1, toolStripButton1, toolStripButton2, toolStripSeparator2, fontComboBox, sizeComboBox, toolStripSeparator4, boldButton, italicButton, underlineButton, toolStripSeparator5 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 28);
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 25);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 25);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 28);
            // 
            // fontComboBox
            // 
            fontComboBox.Name = "fontComboBox";
            fontComboBox.Size = new Size(180, 28);
            fontComboBox.SelectedIndexChanged += fontComboBox_SelectedIndexChanged;
            // 
            // sizeComboBox
            // 
            sizeComboBox.Name = "sizeComboBox";
            sizeComboBox.Size = new Size(75, 28);
            sizeComboBox.SelectedIndexChanged += sizeComboBox_SelectedIndexChanged;
            sizeComboBox.Click += sizeComboBox_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 28);
            // 
            // boldButton
            // 
            boldButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            boldButton.Image = (Image)resources.GetObject("boldButton.Image");
            boldButton.ImageTransparentColor = Color.Magenta;
            boldButton.Name = "boldButton";
            boldButton.Size = new Size(29, 25);
            boldButton.Text = "toolStripButton3";
            boldButton.Click += boldButton_Click;
            // 
            // italicButton
            // 
            italicButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            italicButton.Image = (Image)resources.GetObject("italicButton.Image");
            italicButton.ImageTransparentColor = Color.Magenta;
            italicButton.Name = "italicButton";
            italicButton.Size = new Size(29, 25);
            italicButton.Text = "toolStripButton4";
            italicButton.Click += italicButton_Click;
            // 
            // underlineButton
            // 
            underlineButton.BackgroundImageLayout = ImageLayout.None;
            underlineButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            underlineButton.Image = (Image)resources.GetObject("underlineButton.Image");
            underlineButton.ImageTransparentColor = Color.Magenta;
            underlineButton.Name = "underlineButton";
            underlineButton.Size = new Size(29, 25);
            underlineButton.Text = "toolStripButton5";
            underlineButton.Click += underlineButton_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 28);
            // 
            // richTextBox
            // 
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox.Location = new Point(0, 59);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(800, 389);
            richTextBox.TabIndex = 2;
            richTextBox.Text = "";
            richTextBox.TextChanged += richTextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Soạn thảo văn bản";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem taoMoiVanBanButton;
        private ToolStripMenuItem formatButton;
        private ToolStrip toolStrip1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripComboBox fontComboBox;
        private ToolStripComboBox sizeComboBox;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem createNewButton;
        private ToolStripMenuItem openFileButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem saveFileButton;
        private ToolStripMenuItem exitButton;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton boldButton;
        private ToolStripButton italicButton;
        private ToolStripButton underlineButton;
        private ToolStripSeparator toolStripSeparator5;
        private RichTextBox richTextBox;
    }
}
