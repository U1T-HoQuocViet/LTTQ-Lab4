using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTTH4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach (var font in FontFamily.Families)
            {
                fontComboBox.Items.Add(font.Name);
            }

            int[] sizes = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (var size in sizes)
            {
                sizeComboBox.Items.Add(size.ToString());
            }

            SetDefault();
        }

        //Font mainFont;
        string currentWorkingFile = string.Empty;
        bool _isDirty = false;

        void SetDefault()
        {
            richTextBox.Text = string.Empty;
            fontComboBox.SelectedItem = "Tahoma";
            sizeComboBox.SelectedItem = "14";
            boldButton.Checked = false;
            italicButton.Checked = false;
            underlineButton.Checked = false;
            SetSelectedFont();
        }

        void SetSelectedFont()
        {
            try
            {
                FontStyle style = FontStyle.Regular;
                if (boldButton.Checked) style |= FontStyle.Bold;
                if (italicButton.Checked) style |= FontStyle.Italic;
                if (underlineButton.Checked) style |= FontStyle.Underline;

                richTextBox.SelectionFont = new Font(fontComboBox?.SelectedItem?.ToString() ?? "Tahoma", float.Parse(sizeComboBox?.SelectedItem?.ToString() ?? "14"), style);
                _isDirty = true;
            }
            catch
            {
                MessageBox.Show("Font nhập không hợp lệ.");
            }
        }

        void OpenTextFile()
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Select a file to open";
            fileDialog.Filter = "Text files (*.txt;*.rtf)|*.txt;*.rtf|" +
                         "All Files (*.*)|*.*";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            fileDialog.Multiselect = false;

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (fileDialog.FileName.Split(".").Last() == "txt")
                        richTextBox.LoadFile(fileDialog.FileName, RichTextBoxStreamType.PlainText);
                    else if (fileDialog.FileName.Split(".").Last() == "rtf")
                        richTextBox.LoadFile(fileDialog.FileName, RichTextBoxStreamType.RichText);
                    currentWorkingFile = fileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while reading file.");
                }
            }
        }

        void SaveFile()
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "*.rtf";
                saveFile.Filter = "RTF Files|*.rtf|Text Files|*.txt|All Files|*.*";
                if (currentWorkingFile != string.Empty)
                {
                    if (_isDirty)
                    {
                        richTextBox.SaveFile(currentWorkingFile, RichTextBoxStreamType.RichText);
                        _isDirty = false;
                        MessageBox.Show("Save file successfully");
                    }

                }
                else
                    if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
                    currentWorkingFile = saveFile.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving file.");
            }
        }

        void OpenNewFile()
        {
            currentWorkingFile = string.Empty;
            _isDirty = true;
            SetDefault();
        }

        private void formatButton_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font chosenFont = fontDialog.Font;

                fontComboBox.SelectedItem = chosenFont.FontFamily.Name;
                sizeComboBox.SelectedItem = chosenFont.Size.ToString();
                boldButton.Checked = chosenFont.Style == FontStyle.Bold;
                italicButton.Checked = chosenFont.Style == FontStyle.Italic;
                underlineButton.Checked = chosenFont.Style == FontStyle.Underline;
            }
            SetSelectedFont();
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedFont();
        }

        private void sizeComboBox_Click(object sender, EventArgs e)
        {
            SetSelectedFont();
        }

        private void boldButton_Click(object sender, EventArgs e)
        {
            CheckOrUncheck(sender);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            CheckOrUncheck(sender);
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            CheckOrUncheck(sender);
        }

        void CheckOrUncheck(object button)
        {
            ((ToolStripButton)button).Checked = !((ToolStripButton)button).Checked;
            SetSelectedFont();
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            OpenNewFile();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            OpenTextFile();
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            _isDirty = true;
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSelectedFont();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            OpenNewFile();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
