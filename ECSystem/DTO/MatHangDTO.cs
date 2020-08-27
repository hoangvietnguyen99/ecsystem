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

        private float giaTien;

        private int sLTon;

        private string loaiHang;

        public string LoaiHang { get => loaiHang; set => loaiHang = value; }
        public string MaMH { get => maMH; set => maMH = value; }
        public string TenMH { get => tenMH; set => tenMH = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public int SLTon { get => sLTon; set => sLTon = value; }

        public MatHangDTO(DataRow row)
        {
            MaMH = row["MaMH"].ToString();
            TenMH = row["TenMH"].ToString();
            GiaTien = (float)row["GiaTien"];
            SLTon = (int)row["SLTon"];
            LoaiHang = row["LoaiHang"].ToString();
        }

        public MatHangDTO(string loaiHang, string maMH, string tenMH, float giaTien, int sLTon)
        {
            LoaiHang = loaiHang;
            MaMH = maMH;
            TenMH = tenMH;
            GiaTien = giaTien;
            SLTon = sLTon;
        }


    }
}
