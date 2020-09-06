using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class MatHangDTO
    {
        private string maMH;

        private string tenMH;

        private double giaTien;

        private int sLTon;

        private string loaiHang;

        private string img;

        public string Img { get => img; set => img = value; }

        public string LoaiHang { get => loaiHang; set => loaiHang = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public int SLTon { get => sLTon; set => sLTon = value; }

        public MatHangDTO(DataRow row)
        {
            MaMH = row["MaMH"].ToString();
            TenMH = row["TenMH"].ToString();
            GiaTien = (double)row["GiaTien"];
            SLTon = (int)row["SLTon"];
            Img = row["HinhAnh"].ToString();
            LoaiHang = row["LoaiHang"].ToString();
        }

        public MatHangDTO(string loaiHang, string maMH, string tenMH, double giaTien, int sLTon)
        {
            LoaiHang = loaiHang;
            MaMH = maMH;
            TenMH = tenMH;
            GiaTien = giaTien;
            SLTon = sLTon;
        }
    }
}
