using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    class CT_HoaDonDTO
    {
        public CT_HoaDonDTO(string maHD, string maMH, double donGiaBan, int soLuong)
        {
            this.MaHD = maHD;
            this.MaMH = maMH;
            this.DonGiaBan = donGiaBan;
            this.SoLuong = soLuong;
        }

        public CT_HoaDonDTO(DataRow row)
        {
            this.MaHD = row["MaHD"].ToString();
            this.MaMH = row["MaMH"].ToString();
            this.DonGiaBan = (double)row["DonGiaBan"];
            this.SoLuong = (int)row["SoLuong"];
        }

        private string maHD;
        public string MaHD { get; set; }
        private string maMH;
        public string MaMH { get; set; }
        private double donGiaBan;
        public double DonGiaBan { get; set; }
        private int soLuong;
        public int SoLuong { get; set; }

    }
}
