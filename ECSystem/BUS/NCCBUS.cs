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
    public class NCCBUS
    {
        private NCCBUS() { }

        private static NCCBUS instance;

        public static NCCBUS Instance
        {
            get { if (instance == null) instance = new NCCBUS(); return instance; }
            private set => instance = value;
        }

        public List<string> LayDSTenNCC()
        {
            List<string> dsMaNCC = new List<string>();

            List<NCCDTO> dsNCC = NCCDAO.Instance.LayDSNCC();

            foreach (NCCDTO nCCDTO in dsNCC)
            {
                dsMaNCC.Add(nCCDTO.MaNCC);
            }

            return dsMaNCC;
        }

        public List<NCCDTO> LayDSNCC()
        {
            return NCCDAO.Instance.LayDSNCC();
        }

        public int ThemNCC(NCCDTO ncc)
        {
            return NCCDAO.Instance.ThemNCC(ncc);
        }
    }
}
