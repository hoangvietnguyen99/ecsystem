using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    public class DonNhapHangDAO
    {
        private DonNhapHangDAO() { }

        private static DonNhapHangDAO instance;

        public static DonNhapHangDAO Instance 
        {
            get { if (instance == null) instance = new DonNhapHangDAO(); return instance; }
            private set => instance = value; 
        }

        public List<DonNhapHangDTO> LayDSDonNHChuaDuyet()
        {
            List<DonNhapHangDTO> ds = new List<DonNhapHangDTO>();

            string query = "USP_LayDSDonNhapHangChuaDuyet";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(new DonNhapHangDTO(row));
                }
            }

            return ds;
        }

        public List<DonNhapHangDTO> LayDSDonChuaDuyetCuaNhanVien(string NVNhapHang)
        {
            List<DonNhapHangDTO> ds = new List<DonNhapHangDTO>();

            string query = "SELECT * FROM DON_NHAP_HANG WHERE QuanLyXacNhan IS NULL AND NVNhapHang = '" + NVNhapHang + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(new DonNhapHangDTO(row));
                }
            }

            return ds;
        }

        public DonNhapHangDTO LayDonNhapHang(string maDNH)
        {
            string query = "SELECT * FROM DON_NHAP_HANG WHERE MaDNH = '" + maDNH + "'";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            if (dataTable.Rows.Count > 0)
            {
                return new DonNhapHangDTO(dataTable.Rows[0]);
            }

            return null;
        }

        public List<DonNhapHangDTO> LayDSDaDuocDuyetCuaNhanVien(string NVNhapHang)
        {
            List<DonNhapHangDTO> ds = new List<DonNhapHangDTO>();

            string query = "SELECT * FROM DON_NHAP_HANG WHERE QuanLyXacNhan IN (SELECT MaNV FROM NHAN_VIEN WHERE ChucVu = N'Quản lý') AND NVNhapHang = '" + NVNhapHang + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
            {
                foreach (DataRow row in data.Rows)
                {
                    ds.Add(new DonNhapHangDTO(row));
                }
            }

            return ds;
        }

        public int ThemDonNhapHang(DonNhapHangDTO donNhapHangDTO)
        {
            string query = "INSERT INTO DON_NHAP_HANG VALUES ('" + donNhapHangDTO.MaDNH + "', '" + donNhapHangDTO.NgayNhap.ToString() + "','" + donNhapHangDTO.LyDoNhapHang + "'," + donNhapHangDTO.TongTien + ",'" + donNhapHangDTO.NVNhapHang + "',null,null)";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool MaDonNHTonTai(string maDNH)
        {
            string query = "SELECT * FROM DON_NHAP_HANG WHERE MaDNH = '" + maDNH + "'";

            if (DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0)
            {
                return true;
            }

            return false;
        }

        public List<MatHangDTO> DSMatHangCuaDonNhapHang(string maDNH)
        {
            string query = "SELECT * FROM MAT_HANG WHERE MaMH IN (SELECT MaMH FROM CT_DNH WHERE MaDNH = '" + maDNH + "')";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            List<MatHangDTO> dsMatHang = new List<MatHangDTO>();

            if (dataTable.Rows.Count > 0)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    dsMatHang.Add(new MatHangDTO(row));
                }
            }

            return dsMatHang;
        }

        public DataTable DSCT_DNH(string maDNH)
        {
            string query = "SELECT * FROM CT_DNH WHERE MaDNH = '" + maDNH + "'";

            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int CapNhatDNH(DonNhapHangDTO donNhapHang)
        {
            string query = "UPDATE DON_NHAP_HANG SET NgayNhap = '" + donNhapHang.NgayNhap.ToString() + "', LyDoNhapHang = N'" + donNhapHang.LyDoNhapHang + "', TongSL = " + donNhapHang.TongTien + ", NVNhapHang = '" + donNhapHang.NVNhapHang + "' WHERE MaDNH = '" + donNhapHang.MaDNH + "'";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int ThemCT_DNH(string maDNH, string maMH, int soLuong)
        {
            string query = "INSERT INTO CT_DNH VALUES ('" + maDNH + "','" + maMH + "'," + soLuong + ")";

            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
