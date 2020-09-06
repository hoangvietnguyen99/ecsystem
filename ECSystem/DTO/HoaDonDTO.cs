using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    class HoaDon
    {
        public HoaDon(string maHoaDon, string ngayLap, double tongTien, string hinhThucThanhToan, string nvLapHD, string nvGiaoHang, string thuQuyXacNhan, string maKH)
        {
            this.MaHoaDon = maHoaDon;
            this.NgayLap = ngayLap;
            this.TongTien = tongTien;
            this.HinhThucThanhToan = hinhThucThanhToan;
            this.NVLapHD = nvLapHD;
            this.NVGiaoHang = nvGiaoHang;
            this.ThuQuyXacNhan = thuQuyXacNhan;
            this.MaKH = maKH;
        }

        public HoaDon(DataRow row)
        {
            this.MaHoaDon = row["MaHD"].ToString();
            this.NgayLap = row["NgayLap"].ToString();
            this.TongTien = (double)row["TongTien"];
            this.HinhThucThanhToan = row["HinhThucTT"].ToString();
            this.NVLapHD = row["NVLapHD"].ToString();
            this.NVGiaoHang = row["NVGiaoHang"].ToString();
            this.ThuQuyXacNhan = row["ThuQuyXacNhan"].ToString();
            this.MaKH = row["MaKH"].ToString();
        }

        private string maHoaDon;
        public string MaHoaDon { get; set; }
        private string ngayLap;
        public string NgayLap { get; set; }

        private double tongTien;
        public double TongTien { get; set; }

        private string hinhThucThanhToan;
        public string HinhThucThanhToan { get; set; }

        private string nvLapHD;
        public string NVLapHD { get; set; }

        private string nvGiaoHang;
        public string NVGiaoHang { get; set; }

        private string thuQuyXacNhan;
        public string ThuQuyXacNhan { get; set; }

        private string maKH;
        public string MaKH { get; set; }
    }
}
