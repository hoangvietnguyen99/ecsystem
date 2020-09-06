using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class MatHangBUS
    {
        private MatHangBUS() { }

        private static MatHangBUS instance;

        public static MatHangBUS Instance 
        {
            get { if (instance == null) instance = new MatHangBUS(); return instance; }
            private set => instance = value; 
        }

        public List<MatHangDTO> LayDSMatHangTheoTenLoaiHang(string loaiHang)
        {
            LoaiHangDTO lh = LoaiHangDAO.Instance.LayLoaiHangTheoTen(loaiHang);
            if (loaiHang == "Tất cả")
            {
                return MatHangDAO.Instance.LayDSMatHang();
            }
            else if (loaiHang.Length > 0)
            {
                return MatHangDAO.Instance.LayDSMatHangTheoLoaiHang(lh.MaLH);
            }
            return null;
        }

        public int ThemMatHang(string maMH, string tenMH, double giaTien, int sLTon, string tenLH)
        {
            LoaiHangDTO lh = LoaiHangDAO.Instance.LayLoaiHangTheoTen(tenLH);
            MatHangDTO mh = new MatHangDTO(lh.MaLH, maMH, tenMH, giaTien, sLTon);
            return MatHangDAO.Instance.ThemMatHang(mh);
        }

        public LoaiHangDTO LayLoaiHang(string maMH)
        {
            return MatHangDAO.Instance.LayLoaiHang(maMH);
        }

        public MatHangDTO LayMatHang(string maMH)
        {
            return MatHangDAO.Instance.LayDSMatHang(maMH);
        }
    }
}
