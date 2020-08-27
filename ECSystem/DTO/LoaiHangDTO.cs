using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class LoaiHangDTO
    {
        private string maLH;

        private string tenLH;

        private string nhanVienQL;

        public string MaLH { get => maLH; set => maLH = value; }
        public string TenLH { get => tenLH; set => tenLH = value; }
        public string NhanVienQL { get => nhanVienQL; set => nhanVienQL = value; }

        public LoaiHangDTO(string maLH, string tenLH, string nhanVienQL)
        {
            MaLH = maLH;
            TenLH = tenLH;
            NhanVienQL = nhanVienQL;
        }

        public LoaiHangDTO(DataRow row)
        {
            MaLH = row["MaLH"].ToString();
            TenLH = row["TenLH"].ToString();
            NhanVienQL = row["NVQuanLy"].ToString();
        }
    }
}
