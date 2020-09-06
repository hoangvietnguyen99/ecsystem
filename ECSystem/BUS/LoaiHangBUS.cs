using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class LoaiHangBUS
    {
        private LoaiHangBUS() { }

        private static LoaiHangBUS instance;

        public static LoaiHangBUS Instance 
        {
            get { if (instance == null) instance = new LoaiHangBUS(); return instance; }
            private set => instance = value; 
        }

        public List<string> LayDSTenLoaiHang()
        {
            return LoaiHangDAO.Instance.LayDSTenLoaiHang();
        }

        public int ThemLoaiHang(string maLH, string tenLH, string nv)
        {
            LoaiHangDTO lh = new LoaiHangDTO(maLH, tenLH, nv);
            return LoaiHangDAO.Instance.ThemLoaiHang(lh);
        }

        public int XoaLoaiHang(string tenLH)
        {
            return LoaiHangDAO.Instance.XoaLoaiHang(LoaiHangDAO.Instance.LayLoaiHangTheoTen(tenLH).MaLH);
        }
    }
}
