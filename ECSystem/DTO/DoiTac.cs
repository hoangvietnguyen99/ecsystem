using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class DoiTac
    {
        private string maDoiTac;

        private string tenDoiTac;

        private string diaChi;

        private string sDT;

        private string danhGia;

        private int soLanDanhGia;

        public DoiTac(string maDoiTac, string tenDoiTac, string diaChi, string danhGia, int soLanDanhGia, string sDT)
        {
            MaDoiTac = maDoiTac;
            TenDoiTac = tenDoiTac;
            DiaChi = diaChi;
            DanhGia = danhGia;
            SoLanDanhGia = soLanDanhGia;
            SDT = sDT;
        }

        public DoiTac(DataRow row)
        {
            MaDoiTac = row["MaDoiTac"].ToString();
            TenDoiTac = row["TenDoiTac"].ToString();
            DiaChi = row["DiaChi"].ToString();
            DanhGia = row["DanhGia"].ToString();
            SoLanDanhGia = (int)row["SoLanDanhGia"];
            SDT = row["SDT"].ToString();
        }

        public string MaDoiTac { get => maDoiTac; set => maDoiTac = value; }
        public string TenDoiTac { get => tenDoiTac; set => tenDoiTac = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public int SoLanDanhGia { get => soLanDanhGia; set => soLanDanhGia = value; }
        public string SDT { get => sDT; set => sDT = value; }
    }
}
