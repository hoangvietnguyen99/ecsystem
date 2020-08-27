using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class DoiTacDTO
    {
        private string maDoiTac;

        private string tenDoiTac;

        private string diaChi;

        private string sDT;

        private string danhGia;

        private int soLanGiaHan;

        public DoiTacDTO(string maDoiTac, string tenDoiTac, string diaChi, string danhGia, int soLanDanhGia, string sDT)
        {
            MaDoiTac = maDoiTac;
            TenDoiTac = tenDoiTac;
            DiaChi = diaChi;
            DanhGia = danhGia;
            SoLanGiaHan = soLanDanhGia;
            SDT = sDT;
        }

        public DoiTacDTO(DataRow row)
        {
            MaDoiTac = row["MaDoiTac"].ToString();
            TenDoiTac = row["TenDoiTac"].ToString();
            DiaChi = row["DiaChi"].ToString();
            DanhGia = row["DanhGia"].ToString();
            SoLanGiaHan = (int)row["SoLanGiaHan"];
            SDT = row["SDT"].ToString();
        }

        public string MaDoiTac { get => maDoiTac; set => maDoiTac = value; }
        public string TenDoiTac { get => tenDoiTac; set => tenDoiTac = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DanhGia { get => danhGia; set => danhGia = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public int SoLanGiaHan { get => soLanGiaHan; set => soLanGiaHan = value; }
    }
}
