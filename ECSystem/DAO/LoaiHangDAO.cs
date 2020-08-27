using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class LoaiHangDAO
    {
        private LoaiHangDAO() { }

        private static LoaiHangDAO instance;

        public static LoaiHangDAO Instance 
        {
            get { if (instance == null) instance = new LoaiHangDAO(); return instance; }
            private set => instance = value; 
        }

        public List<string> LayDSTenLoaiHang()
        {
            List<string> ds = new List<string>();

            string query = "USP_LayDSTenLoaiHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(row["TenLH"].ToString());
                }
            }

            return ds;
        }
    }
}
