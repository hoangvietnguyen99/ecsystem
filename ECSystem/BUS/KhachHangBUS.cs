using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class KhachHangBUS
    {
        private KhachHangBUS() { }

        private static KhachHangBUS instance;

        public static KhachHangBUS Instance 
        {
            get { if (instance == null) instance = new KhachHangBUS(); return instance; }
            private set => instance = value; 
        }

        public KhachHangDTO LayKhachHang(string maKH)
        {
            return KhachHangDAO.Instance.LayKhachHang(maKH);
        }
    }
}
