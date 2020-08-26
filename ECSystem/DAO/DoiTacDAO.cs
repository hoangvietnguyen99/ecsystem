using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class DoiTacDAO
    {
        private DoiTacDAO() { }

        private static DoiTacDAO instance;

        public static DoiTacDAO Instance 
        {
            get { if (instance == null) instance = new DoiTacDAO(); return instance; }
            private set => instance = value;
        }

        public List<DoiTac> loadDSDoiTacTheoTinQuangCao(TinQuangCao tin)
        {
            List<DoiTac> dsDoiTac = null;

            

            return dsDoiTac;
        }
    }
}
