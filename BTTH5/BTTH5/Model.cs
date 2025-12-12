using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH5
{
    public class SinhVien
    {
        public SinhVien(string mssv, string ten, string khoa, float diem) 
        {
            MSSV = mssv;
            tenSV = ten;
            this.khoa = khoa;
            diemTB = diem;
        }
        public string MSSV;
        public string tenSV;
        public string khoa;
        public float diemTB;
    }
}
