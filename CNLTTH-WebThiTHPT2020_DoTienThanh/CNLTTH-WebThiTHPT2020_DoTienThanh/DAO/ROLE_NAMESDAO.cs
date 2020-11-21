using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DAO
{
    public class ROLE_NAMESDAO
    {
        private ROLE_NAMESDAO() { }

        private static volatile ROLE_NAMESDAO instance;

        static object key = new object();

        public static ROLE_NAMESDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new ROLE_NAMESDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<ROLE_NAMES> GetList()
        {
            List<ROLE_NAMES> list = new List<ROLE_NAMES>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ROLE_NAMES");
            foreach (DataRow item in data.Rows)
            {
                ROLE_NAMES obj = new ROLE_NAMES(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(int id, string role_name)
        {
            string query = $"INSERT dbo.ROLE_NAMES VALUES  ( N'{id}',  N'{role_name}')";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int id, string role_name)
        {
            string query = $"UPDATE dbo.ROLE_NAMES SET ROLE_NAME=N'{role_name}' ID_ROLE={id}";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int id)
        {
            string query = $"DELETE dbo.ROLE_NAMES WHERE ID_ROLE={id}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        //public List<SinhVien> TimKiemSinhvienThiLai()
        //{
        //    List<SinhVien> list = new List<SinhVien>();
        //    string query = "select sinhvien.MaSinhVien, TenSinhVien,QueQuan,NamSinh,MaLop from SinhVien, MonHoc, Diem where Diem.MaSinhVien = SinhVien.MaSinhVien and Diem.MaMonHoc = MonHoc.MaMon and Diem.Diem < 5";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    foreach (DataRow item in data.Rows)
        //    {
        //        SinhVien obj = new SinhVien(item);
        //        list.Add(obj);
        //    }
        //    return list;
        //}

    }
}