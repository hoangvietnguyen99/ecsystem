using ECSystem.DAO;
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
    }
}
