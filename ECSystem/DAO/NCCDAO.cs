using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class NCCDAO
    {
        private NCCDAO() { }

        private static NCCDAO instance;

        public static NCCDAO Instance
        {
            get { if (instance == null) instance = new NCCDAO(); return instance; }
            private set => instance = value;
        }

        public List<NCCDTO> LayDSNCC()
        {
            string query = "SELECT * FROM NHA_CUNG_CAP";

            List<NCCDTO> dsNCC = new List<NCCDTO>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dsNCC.Add(new NCCDTO(row));
                }
            }

            return dsNCC;
        }

        public int ThemNCC(NCCDTO nCC)
        {
            string query = "INSERT INTO NHA_CUNG_CAP VALUES ('" + nCC.MaNCC + "',N'" + nCC.TenNCC + "',N'" + nCC.DiaChi + "','" + nCC.SDT + "')";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public NCCDTO ThongTinNCC(string maNCC)
        {
            string query = "SELECT * FROM NHA_CUNG_CAP WHERE MaNCC = '" + maNCC + "'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                return new NCCDTO(dataTable.Rows[0]);
            }

            return null;
        }
    }
}
