using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DAO
{
    public class HocVienDAO
    {
        private HocVienDAO() { }

        private static volatile HocVienDAO instance;

        static object key = new object();

        public static HocVienDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new HocVienDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<HocVien> GetList()
        {
            List<HocVien> list = new List<HocVien>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HocVien");
            foreach (DataRow item in data.Rows)
            {
                HocVien obj = new HocVien(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create()
        {
            string query = $"";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update()
        {
            string query = $"";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int id)
        {
            string query = $"";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
    }
}
