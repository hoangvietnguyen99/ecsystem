using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class TinQuangCaoKhachHangBUS
    {
        private TinQuangCaoKhachHangBUS() { }

        private static TinQuangCaoKhachHangBUS instance;

        public static TinQuangCaoKhachHangBUS Instance 
        {
            get { if (instance == null) instance = new TinQuangCaoKhachHangBUS(); return instance; } 
            private set => instance = value;
        }

        public List<TinQuangCaoKhachHangDTO> LayDSTinQCKHTheoTin(string maTin)
        {
            return TinQuangCaoKhachHangDAO.Instance.LayDSTinQCKH(maTin);
        }
    }
}
