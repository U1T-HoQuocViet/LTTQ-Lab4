using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH5
{
    public partial class FormThemSinhVien1 : Form
    {
        

        public event Action<SinhVien> ThemSinhVienEvent;
        public FormThemSinhVien1()
        {
            InitializeComponent();
        }

        private void themButton_Click(object sender, EventArgs e)
        {
            try
            {
                ThemSinhVienEvent?.Invoke(new SinhVien(
            
                    mssvTextBox.Text,
                    tenSVTextBox.Text,
                    khoaComboBox.Text,
                    float.Parse(diemTBTextBox.Text)
                ));
                mssvTextBox.Text = string.Empty;
                tenSVTextBox.Text = string.Empty;
                khoaComboBox.Text = string.Empty;
                diemTBTextBox.Text = string.Empty;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thông tin không hợp lệ.");
            }

        }

        private void thoatButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
