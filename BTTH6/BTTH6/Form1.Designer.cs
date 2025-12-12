namespace BTTH6
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            copyButton = new Button();
            destDirButton = new Button();
            destDirTextBox = new TextBox();
            label2 = new Label();
            sourceDirButton = new Button();
            sourceDirTextBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            progressBar = new ProgressBar();
            toolTip = new ToolTip(components);
            statusStrip1 = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(copyButton);
            groupBox1.Controls.Add(destDirButton);
            groupBox1.Controls.Add(destDirTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(sourceDirButton);
            groupBox1.Controls.Add(sourceDirTextBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(26, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(741, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sao chép tập tin";
            // 
            // copyButton
            // 
            copyButton.Location = new Point(299, 194);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(105, 33);
            copyButton.TabIndex = 6;
            copyButton.Text = "Sao chép";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // destDirButton
            // 
            destDirButton.Location = new Point(660, 131);
            destDirButton.Name = "destDirButton";
            destDirButton.Size = new Size(38, 38);
            destDirButton.TabIndex = 5;
            destDirButton.Text = "...";
            destDirButton.UseVisualStyleBackColor = true;
            destDirButton.Click += destDirButton_Click;
            // 
            // destDirTextBox
            // 
            destDirTextBox.Location = new Point(226, 137);
            destDirTextBox.Name = "destDirTextBox";
            destDirTextBox.Size = new Size(418, 27);
            destDirTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 140);
            label2.Name = "label2";
            label2.Size = new Size(174, 20);
            label2.TabIndex = 3;
            label2.Text = "Đường dẫn thư mục đích";
            // 
            // sourceDirButton
            // 
            sourceDirButton.Location = new Point(660, 58);
            sourceDirButton.Name = "sourceDirButton";
            sourceDirButton.Size = new Size(38, 38);
            sourceDirButton.TabIndex = 2;
            sourceDirButton.Text = "...";
            sourceDirButton.UseVisualStyleBackColor = true;
            sourceDirButton.Click += sourceDirButton_Click;
            // 
            // sourceDirTextBox
            // 
            sourceDirTextBox.Location = new Point(226, 64);
            sourceDirTextBox.Name = "sourceDirTextBox";
            sourceDirTextBox.Size = new Size(418, 27);
            sourceDirTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 67);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 0;
            label1.Text = "Đường dẫn thư mục nguồn";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar);
            groupBox2.Location = new Point(26, 314);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(741, 109);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tiến trình sao chép";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(32, 52);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(656, 29);
            progressBar.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip1.Location = new Point(0, 429);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(0, 16);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Sao chép tập tin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button destDirButton;
        private TextBox destDirTextBox;
        private Label label2;
        private Button sourceDirButton;
        private TextBox sourceDirTextBox;
        private Label label1;
        private GroupBox groupBox2;
        private Button copyButton;
        private ProgressBar progressBar;
        private ToolTip toolTip;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
    }
}
