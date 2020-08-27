using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class TinQuangCaoKhachHangDAO
    {
        private TinQuangCaoKhachHangDAO() { }

        private static TinQuangCaoKhachHangDAO instance;

        public static TinQuangCaoKhachHangDAO Instance {
            get { if (instance == null) instance = new TinQuangCaoKhachHangDAO(); return instance; }
            private set => instance = value;
        }

        public List<TinQuangCaoKhachHangDTO> LayDSTinQCKH(string maTin)
        {
            string query = "USP_LayDSLICH_SU_TIN_QC_KHTHEOTIN @MaTin";

            List<TinQuangCaoKhachHangDTO> ds = new List<TinQuangCaoKhachHangDTO>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { maTin });

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    ds.Add(new TinQuangCaoKhachHangDTO(row));
                }
            }

            return ds;
        }
    }
}
