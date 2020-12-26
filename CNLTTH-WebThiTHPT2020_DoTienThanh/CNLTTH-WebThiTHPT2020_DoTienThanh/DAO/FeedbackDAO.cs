using CNLTTH_WebThiTHPT2020_DoTienThanh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DAO
{
    public class FeedbackDAO
    {
        private FeedbackDAO() { }

        private static volatile FeedbackDAO instance;

        static object key = new object();

        public static FeedbackDAO Instance
        {
            get
            {
                lock (key)
                {
                    if (instance == null)
                    {
                        instance = new FeedbackDAO();
                    }
                }

                return instance;
            }

            private set
            {
                instance = value;
            }
        }


        public List<Feedback> GetList()
        {
            List<Feedback> list = new List<Feedback>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Feedback");
            foreach (DataRow item in data.Rows)
            {
                Feedback obj = new Feedback(item);
                list.Add(obj);
            }
            return list;
        }

        public int Create(string noidung, DateTime thoigiandang)
        {
            string query = $"INSERT dbo.Feedback VALUES  ( N'{noidung}',  {thoigiandang})";

            DataProvider.Instance.ExecuteNonQuery(query);

            return 1;
        }
        public int Update(int mafeedback, string username, string noidung, DateTime thoigiandang)
        {
            string query = $"UPDATE dbo.Feedback SET noidung=N'{noidung}',thoigiandang={thoigiandang}";
            DataProvider.Instance.ExecuteNonQuery(query);
            return 1;
        }
        public int Delete(int mafeedback)
        {
            string query = $"DELETE dbo.Feedback WHERE mafeedback={mafeedback}";

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
