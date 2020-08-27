using ECSystem.DAO;
using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.BUS
{
    public class DoiTacBUS
    {
        private DoiTacBUS() { }

        private static DoiTacBUS instance;

        public static DoiTacBUS Instance 
        { 
            get { if (instance == null) instance = new DoiTacBUS(); return instance; }
            private set => instance = value; 
        }

        public DoiTacDTO LayDoiTac(string maDoiTac)
        {
            return DoiTacDAO.Instance.LayDoiTac(maDoiTac);
        }
    }
}
