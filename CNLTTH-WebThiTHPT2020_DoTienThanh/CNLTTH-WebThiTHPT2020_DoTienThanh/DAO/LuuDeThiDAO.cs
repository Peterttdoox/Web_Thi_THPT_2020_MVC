using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DAO
{
    public class LuuDeThiDAO
    {
        private LuuDeThiDAO() { }

        private static volatile LuuDeThiDAO instance;

        static object key = new object();

        public static LuuDeThiDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new LuuDeThiDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<LuuDeThi> GetList()
        {
            List<LuuDeThi> list = new List<LuuDeThi>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.LuuDeThi");
            foreach (DataRow item in data.Rows)
            {
                LuuDeThi obj = new LuuDeThi(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(DateTime ThoiDiemLuu, int TrangThai)
        {
            string query = $"INSERT dbo.LuuDeThi VALUES  ( N'{ThoiDiemLuu}',  {TrangThai})";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int MaLuuDeThi, DateTime ThoiDiemLuu, string UserName, string MaDeThi, int TrangThai)
        {
            string query = $"UPDATE dbo.LuuDeThi SET thoidiemluu=N'{ThoiDiemLuu}',trangthai={TrangThai}";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int MaLuuDeThi)
        {
            string query = $"DELETE dbo.LuuDeThi WHERE MaLuuDeThi={MaLuuDeThi}";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }

        //public List<FeedBack> TimKiemDeThi(string madethi, string tendethi)
        //{
        //    List<FeedBack> list = new List<FeedBack>();
        //    string query = $"SELECT * FROM dbo.FeedBack WHERE dbo.FeedBack.mafeedback IN(SELECT masv FROM dbo.Diem WHERE mamon={mamon} AND manamhoc={manamhoc} AND diem<{diem})";
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
