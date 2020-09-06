using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class TinQuangCaoDoiTacDTO
    {
        private string maTin;

        private string maDoiTac;

        private DateTime ngayKyHD;

        private int thoiGianQC;

        private string thongTinViTriDang;

        public string MaTin { get => maTin; set => maTin = value; }
        public string MaDoiTac { get => maDoiTac; set => maDoiTac = value; }
        public DateTime NgayKyHD { get => ngayKyHD; set => ngayKyHD = value; }
        public int ThoiGianQC { get => thoiGianQC; set => thoiGianQC = value; }
        public string ThongTinViTriDang { get => thongTinViTriDang; set => thongTinViTriDang = value; }

        public TinQuangCaoDoiTacDTO(string maTin, string maDoiTac, DateTime ngayKyHD, int thoiGianQC, string thongTinViTriDang)
        {
            MaTin = maTin;
            MaDoiTac = maDoiTac;
            NgayKyHD = ngayKyHD;
            ThoiGianQC = thoiGianQC;
            ThongTinViTriDang = thongTinViTriDang;
        }

        public TinQuangCaoDoiTacDTO(DataRow row)
        {
            MaTin = row["MaTin"].ToString();
            MaDoiTac = row["MaDoiTac"].ToString();
            NgayKyHD = DateTime.Parse(row["NgayKyHD"].ToString());
            ThoiGianQC = (int)row["ThoiGianQC"];
            ThongTinViTriDang = row["ThongTinViTriDang"].ToString();
        }
    }
}
