using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class TinQuangCaoDAO
    {
        private static TinQuangCaoDAO instance;

        private TinQuangCaoDAO() { }

        public static TinQuangCaoDAO Instance
        { 
            get { if (instance == null) instance = new TinQuangCaoDAO(); return instance; }
            private set => instance = value;
        }

        public List<TinQuangCao> LoadTinQuangCao()
        {
            List<TinQuangCao> ds = new List<TinQuangCao>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM [dbo].[TIN_QUANG_CAO]");

            foreach (DataRow row in data.Rows)
            {
                TinQuangCao tin = new TinQuangCao(row);

                ds.Add(tin);
            }

            return ds;
        }

        public bool AddTinQuangCao(TinQuangCao tin)
        {
            string query = "USP_ThemTinQuangCao @MaTin , @NgayLap , @NoiDung , @NVDangTin";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tin.MaTin, tin.NgayLap, tin.NoiDung, tin.NVDangTin });

            return result.Rows.Count > 0;
        }

        public bool KiemTraTinQuangCao(TinQuangCao tin)
        {
            string query = "USP_KiemTraTinQuangCao @MaTin , @NgayLap , @NoiDung , @NVDangTin";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { tin.MaTin, tin.NgayLap, tin.NoiDung, tin.NVDangTin });

            return result.Rows.Count > 0;
        }
    }
}
