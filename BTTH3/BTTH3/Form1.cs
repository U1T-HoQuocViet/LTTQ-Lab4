using System.Windows.Forms;

namespace BTTH3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer.Interval = 1000;
            timer.Start();
            timer.Tick += OnTick;
        }

        void OnTick(object sender, EventArgs e)
        {
            statusStrip.Text = $"Hôm nay là ngày {DateTime.Now.ToShortDateString()} - Bây giờ là {DateTime.Now.ToLongTimeString()}";
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Select a file to open";
            fileDialog.Filter = "Media files (*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3)|*.avi;*.mpeg;*.wav;*.midi;*.mp4;*.mp3";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            fileDialog.Multiselect = false;

            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                mediaPlayer.URL = fileDialog.FileName;
            }

            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
