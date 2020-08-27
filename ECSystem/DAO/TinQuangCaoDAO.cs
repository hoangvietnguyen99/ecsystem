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

        public List<TinQuangCaoDTO> XemDSTinQuangCao()
        {
            List<TinQuangCaoDTO> ds = new List<TinQuangCaoDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_XemDSTinQuangCao");

            foreach (DataRow row in data.Rows)
            {
                TinQuangCaoDTO tin = new TinQuangCaoDTO(row);

                ds.Add(tin);
            }

            return ds;
        }

        public int ThemTinQuangCao(TinQuangCaoDTO tin)
        {
            string query = "USP_ThemTinQuangCao @MaTin , @NgayLap , @NoiDung , @NVDangTin";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tin.MaTin, tin.NgayLap, tin.NoiDung, tin.NVDangTin });

            return result;
        }

        public int ThemKhachHang(string maTin, string maKH)
        {
            string query = "USP_ThemKhachHangVaoTin @MaTin , @MaKH";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTin, maKH });

            return result;
        }

        public int ThemDoiTac(string maTin, string maDoiTac, int thoiGianQC, string TTVTD)
        {
            string query = "USP_ThemDoiTacVaoTin @MaTin , @MaDoiTac , @ThoiGianQC , @TTVTD";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTin, maDoiTac , thoiGianQC, TTVTD });

            return result;
        }

        public int XoaTinQuangCao(string maTin)
        {
            string query = "USP_XoaTinQuangCao @MaTin";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { maTin });

            return result;
        }

        public int CapNhatTinQuangCao(TinQuangCaoDTO tin)
        {
            string query = "USP_CapNhatTinQuangCao @MaTin , @NoiDung";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { tin.MaTin, tin.NoiDung });

            return result;
        }

        public TinQuangCaoDTO XemTinQuangCao(string maTin)
        {
            string query = "USP_XemTinQuangCao @MaTin";

            TinQuangCaoDTO tin = null;

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTin });

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                tin = new TinQuangCaoDTO(row);
            }

            return tin;
        }

        public List<string> XemDSMaKhachHangChuaThem(string maTin)
        {
            string query = "USP_LayDSKhachHangChuaThemVaoTin @MaTin";

            List<string> ds = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTin });

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(row["MaKH"].ToString());
                }
            }

            return ds;
        }

        public List<string> XemDSMaDoiTacChuaThem(string maTin)
        {
            string query = "USP_LayDSDoiTacChuaThemVaoTin @MaTin";

            List<string> ds = new List<string>();

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maTin });

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(row["MaDoiTac"].ToString());
                }
            }

            return ds;
        }
    }
}
