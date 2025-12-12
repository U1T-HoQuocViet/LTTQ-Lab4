namespace BTTH5
{
    partial class FormQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanLy));
            menuStrip1 = new MenuStrip();
            chucToolStripMenuItem = new ToolStripMenuItem();
            thêmMớiToolStripMenuItem = new ToolStripMenuItem();
            exitButton = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            addNewButton = new ToolStripButton();
            findTextBox = new ToolStripTextBox();
            toolStripLabel2 = new ToolStripLabel();
            dataGridView = new DataGridView();
            STTCollumn = new DataGridViewTextBoxColumn();
            MSSVCollumn = new DataGridViewTextBoxColumn();
            NameCollumn = new DataGridViewTextBoxColumn();
            KhoaCollumn = new DataGridViewTextBoxColumn();
            DiemTBCollumn = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { chucToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chucToolStripMenuItem
            // 
            chucToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmMớiToolStripMenuItem, exitButton });
            chucToolStripMenuItem.Name = "chucToolStripMenuItem";
            chucToolStripMenuItem.Size = new Size(93, 24);
            chucToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmMớiToolStripMenuItem
            // 
            thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            thêmMớiToolStripMenuItem.Size = new Size(224, 26);
            thêmMớiToolStripMenuItem.Text = "Thêm mới";
            thêmMớiToolStripMenuItem.Click += addNewButton_Click;
            // 
            // exitButton
            // 
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(224, 26);
            exitButton.Text = "Thoát";
            exitButton.Click += exitButton_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { addNewButton, findTextBox, toolStripLabel2 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 45);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // addNewButton
            // 
            addNewButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addNewButton.Image = (Image)resources.GetObject("addNewButton.Image");
            addNewButton.ImageTransparentColor = Color.Magenta;
            addNewButton.Name = "addNewButton";
            addNewButton.Size = new Size(168, 42);
            addNewButton.Text = "Thêm Mới";
            addNewButton.Click += addNewButton_Click;
            // 
            // findTextBox
            // 
            findTextBox.Alignment = ToolStripItemAlignment.Right;
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(350, 45);
            findTextBox.TextChanged += findTextBox_TextChanged;
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Alignment = ToolStripItemAlignment.Right;
            toolStripLabel2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(149, 42);
            toolStripLabel2.Text = "Tìm kiếm theo tên";
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { STTCollumn, MSSVCollumn, NameCollumn, KhoaCollumn, DiemTBCollumn });
            dataGridView.Location = new Point(0, 75);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(800, 373);
            dataGridView.TabIndex = 2;
            // 
            // STTCollumn
            // 
            STTCollumn.HeaderText = "Số TT";
            STTCollumn.MinimumWidth = 6;
            STTCollumn.Name = "STTCollumn";
            STTCollumn.Width = 75;
            // 
            // MSSVCollumn
            // 
            MSSVCollumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MSSVCollumn.FillWeight = 60F;
            MSSVCollumn.HeaderText = "Mã Số SV";
            MSSVCollumn.MinimumWidth = 6;
            MSSVCollumn.Name = "MSSVCollumn";
            // 
            // NameCollumn
            // 
            NameCollumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameCollumn.FillWeight = 40F;
            NameCollumn.HeaderText = "Tên Sinh Viên";
            NameCollumn.MinimumWidth = 6;
            NameCollumn.Name = "NameCollumn";
            // 
            // KhoaCollumn
            // 
            KhoaCollumn.HeaderText = "Khoa";
            KhoaCollumn.MinimumWidth = 6;
            KhoaCollumn.Name = "KhoaCollumn";
            KhoaCollumn.Width = 125;
            // 
            // DiemTBCollumn
            // 
            DiemTBCollumn.HeaderText = "Điểm TB";
            DiemTBCollumn.MinimumWidth = 6;
            DiemTBCollumn.Name = "DiemTBCollumn";
            DiemTBCollumn.Width = 125;
            // 
            // FormQuanLy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormQuanLy";
            Text = "Quản Lý Sinh Viên";
            KeyDown += FormQuanLy_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem chucToolStripMenuItem;
        private ToolStripMenuItem thêmMớiToolStripMenuItem;
        private ToolStripMenuItem exitButton;
        private ToolStripButton addNewButton;
        private ToolStripTextBox findTextBox;
        private ToolStripLabel toolStripLabel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn STTCollumn;
        private DataGridViewTextBoxColumn MSSVCollumn;
        private DataGridViewTextBoxColumn NameCollumn;
        private DataGridViewTextBoxColumn KhoaCollumn;
        private DataGridViewTextBoxColumn DiemTBCollumn;
    }
}
