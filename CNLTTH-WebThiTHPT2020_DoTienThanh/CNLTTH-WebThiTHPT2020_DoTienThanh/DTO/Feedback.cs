using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DTO
{
    public class Feedback
    {
        public int MaFeedback { get; set; }
        public string UserName { get; set; }
        public string NoiDung { get; set; }
        public DateTime ThoiGianDang { get; set; }

        public Feedback(DataRow row)
        {
            this.MaFeedback = int.Parse(row["MaFeedback"].ToString());
            this.UserName = row["UserName"].ToString();
            this.NoiDung = row["NoiDung"].ToString();
            this.ThoiGianDang = DateTime.Parse(row["ThoiGianDang"].ToString());

        }

        public Feedback(string NoiDung)
        {
            this.NoiDung = NoiDung;
        }
        public Feedback(int MaFeedback, string UserName, string NoiDung, DateTime ThoiGianDang)
        {
            this.MaFeedback = MaFeedback;
            this.UserName = UserName;
            this.NoiDung = NoiDung;
            this.ThoiGianDang = ThoiGianDang;
        }

        public Feedback() {}
    }
}