using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CNLTTH_WebThiTHPT2020_DoTienThanh.DTO
{
    public class HocVien
    {
        public string UserName   { get; set; }
        public string Pass { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public int SoDienThoai { get; set; }
        public string Email { get; set; }
        public DateTime ThoiGianDangKy { get; set; }

        public HocVien(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.Pass = row["Pass"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = DateTime.Parse(row["NgaySinh"].ToString());
            this.DiaChi = row["DiaChi"].ToString();
            this.SoDienThoai = int.Parse(row["SoDienThoai"].ToString());
            this.Email = row["Email"].ToString();
            this.ThoiGianDangKy = DateTime.Parse(row["ThoiGianDangKy"].ToString());

        }

        public HocVien(string Pass, string HoTen, DateTime NgaySinh, string DiaChi, int SoDienThoai, string Email, DateTime ThoiGianDangKy)
        {
            this.Pass = Pass;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.Email = Email;
            this.ThoiGianDangKy = ThoiGianDangKy;
        }
        public HocVien(string UserName, string Pass, string HoTen, DateTime NgaySinh, string DiaChi, int SoDienThoai, string Email, DateTime ThoiGianDangKy)
        {
            this.UserName = UserName;
            this.Pass = Pass;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.SoDienThoai = SoDienThoai;
            this.Email = Email;
            this.ThoiGianDangKy = ThoiGianDangKy;
        }

        public HocVien() {}
    }
}