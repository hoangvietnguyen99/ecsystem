using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DTO
{
    public class TinQuangCaoDTO
    {
        private string maTin;

        private DateTime ngayLap;

        private string noiDung;

        private string nVDangTin;

        public string MaTin { get => maTin; set => maTin = value; }
        public string NoiDung { get => noiDung; set => noiDung = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public string NVDangTin { get => nVDangTin; set => nVDangTin = value; }

        public TinQuangCaoDTO(string maTin, string noiDung, DateTime ngayLap, string nVDangTin)
        {
            MaTin = maTin;
            NoiDung = noiDung;
            NgayLap = ngayLap;
            NVDangTin = nVDangTin;
        }

        public TinQuangCaoDTO(DataRow row)
        {
            MaTin = row["MaTin"].ToString();
            NoiDung = row["Noidung"].ToString();
            NgayLap = DateTime.Parse(row["NgayLap"].ToString());
            NVDangTin = row["NVDangTin"].ToString();
        }
    }
}
