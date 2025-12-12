namespace BTTH5
{
    public partial class FormQuanLy : Form
    {

        public FormQuanLy()
        {
            InitializeComponent();
            formThemSinhVien = new FormThemSinhVien1();
            formThemSinhVien.ThemSinhVienEvent += AddNew;
        }

        FormThemSinhVien1 formThemSinhVien;

        List<SinhVien> database = new();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            formThemSinhVien.ShowDialog();
        }

        void AddNew(SinhVien sv)
        {
            database.Add(sv);
            AddDataToGridView(sv);
        }

        void AddDataToGridView(SinhVien sv)
        {
            dataGridView.Rows.Add(dataGridView.Rows.Count, sv.MSSV, sv.tenSV, sv.khoa, sv.diemTB);
        }

        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();

            string tofind = findTextBox.Text;
            database.ForEach(sv =>
            {
                if (sv.tenSV.ToLower().Contains(tofind.ToLower()) || string.IsNullOrEmpty(tofind))
                {
                    AddDataToGridView(sv);
                }
            });
        }

        private void FormQuanLy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                formThemSinhVien.ShowDialog();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
