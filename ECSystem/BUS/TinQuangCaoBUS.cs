using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class TinQuangCaoBUS
    {
        private TinQuangCaoBUS() { }

        private static TinQuangCaoBUS instance;

        public static TinQuangCaoBUS Instance 
        {
            get { if (instance == null) instance = new TinQuangCaoBUS(); return instance; }
            private set => instance = value;
        }

        public TinQuangCaoDTO XemTinQuangCao(string maTin)
        {
            return TinQuangCaoDAO.Instance.XemTinQuangCao(maTin);
        }

        public List<TinQuangCaoDTO> XemDSTinQuangCao()
        {
            return TinQuangCaoDAO.Instance.XemDSTinQuangCao();
        }

        public int ThemTinQuangCao(string maTin, string noiDung, DateTime ngayLap, string maNV)
        {
            TinQuangCaoDTO tin = new TinQuangCaoDTO(maTin, noiDung, ngayLap, maNV);

            return TinQuangCaoDAO.Instance.ThemTinQuangCao(tin);
        }

        public int ThemKhachHang(string maTin, string maKH)
        {
            return TinQuangCaoDAO.Instance.ThemKhachHang(maTin, maKH);
        }

        public int ThemDoiTac(string maTin, string maDoiTac, int tgqc, string ttvtd)
        {
            return TinQuangCaoDAO.Instance.ThemDoiTac(maTin, maDoiTac, tgqc, ttvtd);
        }

        public int CapNhatTinQuangCao(string maTin, string noiDung, DateTime ngayLap, string maNV)
        {
            TinQuangCaoDTO tin = new TinQuangCaoDTO(maTin, noiDung, ngayLap, maNV);

            return TinQuangCaoDAO.Instance.CapNhatTinQuangCao(tin);
        }

        public int XoaTinQuangCao(string maTin)
        {
            return TinQuangCaoDAO.Instance.XoaTinQuangCao(maTin);
        }

        public List<string> LayDSMaKhachHangChuaThem(string maTin)
        {
            return TinQuangCaoDAO.Instance.XemDSMaKhachHangChuaThem(maTin);
        }

        public List<string> LayDSMaDoiTacChuaThem(string maTin)
        {
            return TinQuangCaoDAO.Instance.XemDSMaDoiTacChuaThem(maTin);
        }
    }
}
