using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class DonNhapHangBUS
    {
        private static DonNhapHangBUS instance;

        private DonNhapHangBUS() { }

        public static DonNhapHangBUS Instance
        {
            get { if (instance == null) instance = new DonNhapHangBUS(); return instance; }
            private set => instance = value;
        }

        public DataTable DSCT_DNH(string maDNH)
        {
            return DonNhapHangDAO.Instance.DSCT_DNH(maDNH);
        }

        public int ThemCT_DNH(string maDNH, string maMH, int soLuong)
        {
            return DonNhapHangDAO.Instance.ThemCT_DNH(maDNH, maMH, soLuong);
        }

        public List<DonNhapHangDTO> DSDonChuaDuyet(string maNV)
        {
            return DonNhapHangDAO.Instance.LayDSDonChuaDuyetCuaNhanVien(maNV);
        }

        public List<DonNhapHangDTO> DSDonDaDuyet(string maNV)
        {
            return DonNhapHangDAO.Instance.LayDSDaDuocDuyetCuaNhanVien(maNV);
        }

        public int ThemDon(DonNhapHangDTO donNhapHang)
        {
            return DonNhapHangDAO.Instance.ThemDonNhapHang(donNhapHang);
        }

        public DonNhapHangDTO LayDonNhapHang(string maDNH)
        {
            return DonNhapHangDAO.Instance.LayDonNhapHang(maDNH);
        }

        public int CapNhatDon(DonNhapHangDTO donNhapHang)
        {
            return DonNhapHangDAO.Instance.CapNhatDNH(donNhapHang);
        }
    }
}
