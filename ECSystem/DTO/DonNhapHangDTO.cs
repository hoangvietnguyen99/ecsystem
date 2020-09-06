using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class DonNhapHangDTO
    {
        private string maDNH;

        private DateTime ngayNhap;

        private string lyDoNhapHang;

        private int tongTien;

        private string nVNhapHang;

        private string quanLyXacNhan;

        private string maNCC;

        public DonNhapHangDTO(string maDNH, DateTime ngayNhap, string lyDoNhapHang, int tongTien, string nVNhapHang, string quanLyXacNhan, string maNCC)
        {
            MaDNH = maDNH;
            NgayNhap = ngayNhap;
            LyDoNhapHang = lyDoNhapHang;
            TongTien = tongTien;
            NVNhapHang = nVNhapHang;
            QuanLyXacNhan = quanLyXacNhan;
            MaNCC = maNCC;
        }

        public DonNhapHangDTO(string maDNH, DateTime ngayNhap, string lyDoNhapHang, string nVNhapHang, string maNCC)
        {
            MaDNH = maDNH;
            NgayNhap = ngayNhap;
            LyDoNhapHang = lyDoNhapHang;
            NVNhapHang = nVNhapHang;
            MaNCC = maNCC;
        }

        public DonNhapHangDTO()
        {
        }

        public DonNhapHangDTO(DataRow row)
        {
            MaDNH = row["MaDNH"].ToString();
            NgayNhap = DateTime.Parse(row["NgayNhap"].ToString());
            LyDoNhapHang = row["LyDoNhapHang"].ToString(); ;
            TongTien = (int)row["TongSL"];
            NVNhapHang = row["NVNhapHang"].ToString();
            QuanLyXacNhan = row["QuanLyXacNhan"].ToString();
            MaNCC = row["MaNCC"].ToString();
        }

        public string MaDNH { get => maDNH; set => maDNH = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public string LyDoNhapHang { get => lyDoNhapHang; set => lyDoNhapHang = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public string NVNhapHang { get => nVNhapHang; set => nVNhapHang = value; }
        public string QuanLyXacNhan { get => quanLyXacNhan; set => quanLyXacNhan = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
    }
}
