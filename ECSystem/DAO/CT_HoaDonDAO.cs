using ECSystem.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECSystem.DAO
{
    class CT_HoaDonDAO
    {
        private static CT_HoaDonDAO instance;
        public static CT_HoaDonDAO Instance
        {
            get
            {
                if (instance == null) instance = new CT_HoaDonDAO();
                return CT_HoaDonDAO.instance;
            }
            private set { CT_HoaDonDAO.instance = value; }
        }

        private CT_HoaDonDAO() { }

        public List<CT_HoaDonDTO> LoadDSLoadHoaDon()
        {
            List<CT_HoaDonDTO> hoaDonList = new List<CT_HoaDonDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_LayDSCTHoaDon");

            foreach (DataRow item in data.Rows)
            {
                CT_HoaDonDTO hoadon = new CT_HoaDonDTO(item);
                hoaDonList.Add(hoadon);
            }
            return hoaDonList;
        }

        public void insertCT_HoaDon(string maHD, string maMH, double donGia, int soLuong)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_ThemCTHoaDon @maHD ='" + maHD + "', @maMH ='" + maMH + "', @donGia =" + donGia + ", @soLuong = " + soLuong);
        }

    }
}
