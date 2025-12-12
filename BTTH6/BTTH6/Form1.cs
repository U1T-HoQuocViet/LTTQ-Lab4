
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string sourceDir = sourceDirTextBox.Text;
            string destDir = destDirTextBox.Text;
            if (!Directory.Exists(sourceDir))
            {
                MessageBox.Show("Đường dẫn nguồn không hợp lệ.");
                return;
            }

            if (!Directory.Exists(destDir))
            {
                MessageBox.Show("Đường dẫn đích không hợp lệ.");
                return;
            }

            int copiedCount = 0, filesToCopy = 0;
            DeepCopy(sourceDir, destDir, ref copiedCount, ref filesToCopy);

            statusLabel.Text = "";
            toolTip.SetToolTip(progressBar, "");
        }

        void DeepCopy(string sourceDir, string destDir, ref int count, ref int max)
        {
            if (!Directory.Exists(sourceDir))
                return;
            if (!Directory.Exists(destDir))
                return;

            string[] folders = Directory.GetDirectories(sourceDir);
            string[] files = Directory.GetFiles(sourceDir);
            max += files.Length;

            foreach(string folder in folders)
            {
                string destPath = Path.Combine(destDir, folder.Split(@"\").Last());
                Directory.CreateDirectory(destPath);

                
                DeepCopy(folder, destPath, ref count, ref max);
            }
            
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                string status = $"Đang sao chép : {file}";
                statusLabel.Text = status;
                toolTip.SetToolTip(progressBar, status);

                fileInfo.CopyTo(Path.Combine(destDir, Path.GetFileName(file)));
                progressBar.Value = Math.Min(Math.Max((int)((++count / (float)max) * 100), 0), 100);

                Application.DoEvents();
                Thread.Sleep(1000);
            }
        }

        private void sourceDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                sourceDirTextBox.Text = dialog.SelectedPath;
        }

        private void destDirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                destDirTextBox.Text = dialog.SelectedPath;
        }
    }
}
