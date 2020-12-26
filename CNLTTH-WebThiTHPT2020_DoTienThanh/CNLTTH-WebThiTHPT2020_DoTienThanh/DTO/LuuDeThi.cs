using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DTO
{
    public class LuuDeThi
    {
        public int MaLuuDeThi { get; set; }
        public DateTime ThoiDiemLuu { get; set; }
        public string UserName { get; set; }
        public string MaDeThi { get; set; }
        public int TrangThai { get; set; }

        public LuuDeThi(DataRow row)
        {
            this.MaLuuDeThi = int.Parse(row["MaLuuDeThi"].ToString());
            this.ThoiDiemLuu = DateTime.Parse(row["ThoiDiemLuu"].ToString());
            this.UserName = row["UserName"].ToString();
            this.MaDeThi = row["MaDeThi"].ToString();
            this.TrangThai = int.Parse(row["TrangThai"].ToString());

        }

        public LuuDeThi(DateTime ThoiDiemLuu, int TrangThai)
        {
            this.ThoiDiemLuu = ThoiDiemLuu;
            this.TrangThai = TrangThai;
        }
        public LuuDeThi(int MaLuuDeThi, DateTime ThoiDiemLuu, string UserName, string MaDeThi, int TrangThai)
        {
            this.MaLuuDeThi = MaLuuDeThi;
            this.ThoiDiemLuu = ThoiDiemLuu;
            this.UserName = UserName;
            this.MaDeThi = MaDeThi;
            this.TrangThai = TrangThai;
        }

        public LuuDeThi() {}
    }
}