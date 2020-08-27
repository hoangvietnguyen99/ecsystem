using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class TinQuangCaoKhachHangDTO
    {
        private string maTin;

        private string maKH;

        private DateTime ngayGui;

        public string MaTin { get => maTin; set => maTin = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public DateTime NgayGui { get => ngayGui; set => ngayGui = value; }

        public TinQuangCaoKhachHangDTO(string maTin, string maKH, DateTime ngayGui)
        {
            MaTin = maTin;
            MaKH = maKH;
            NgayGui = ngayGui;
        }

        public TinQuangCaoKhachHangDTO(DataRow row)
        {
            MaTin = row["MaTin"].ToString();
            MaKH = row["MaKH"].ToString();
            ngayGui = DateTime.Parse(row["NgayGui"].ToString());
        }
    }
}
