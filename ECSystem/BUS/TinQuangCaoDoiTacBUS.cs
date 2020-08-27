using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class TinQuangCaoDoiTacBUS
    {
        private TinQuangCaoDoiTacBUS() { }

        private static TinQuangCaoDoiTacBUS instance;

        public static TinQuangCaoDoiTacBUS Instance
        {
            get { if (instance == null) instance = new TinQuangCaoDoiTacBUS(); return instance; }
            private set => instance = value; 
        }

        public List<TinQuangCaoDoiTacDTO> LayDSTinQCKHTheoTin(string maTin)
        {
            return TinQuangCaoDoiTacDAO.Instance.LayDSTinQCDT(maTin);
        }
    }
}
