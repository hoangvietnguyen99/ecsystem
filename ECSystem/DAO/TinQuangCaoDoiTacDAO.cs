using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class TinQuangCaoDoiTacDAO
    {
        private TinQuangCaoDoiTacDAO() { }

        private static TinQuangCaoDoiTacDAO instance;

        public static TinQuangCaoDoiTacDAO Instance
        {
            get { if (instance == null) instance = new TinQuangCaoDoiTacDAO(); return instance; } 
            private set => instance = value;
        }

        public List<TinQuangCaoDoiTacDTO> LayDSTinQCDT(string maTin)
        {
            string query = "USP_LayDSLICH_SU_TIN_DOITAC_KHTHEOTIN @MaTin";

            List<TinQuangCaoDoiTacDTO> ds = new List<TinQuangCaoDoiTacDTO>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { maTin });

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    ds.Add(new TinQuangCaoDoiTacDTO(row));
                }
            }

            return ds;
        }
    }
}
