using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DO.NhanVien
{
    public class NhanVien
    {
        private string HoTen { get; set; }
        private string MaNhanVien { get; set; } 

        protected double LuongCoBan {  get; set; }

       // input nhanvien
        public  NhanVien (string hoten,string manhanvien, double luongcoban)
        {
            HoTen = hoten;
            MaNhanVien = manhanvien;
            LuongCoBan = luongcoban;
        }
        //hàm trả ra kết quả họ tên
        public string HoTenOutPut()
        {
            return HoTen;
        }
        //hàm tra ra kết quả manhanvien
        public string MaNhanVienOutPut()
        {
            return MaNhanVien;
        }
        // hàm trả ra kết quả lương cơ bản
        public double LuongCoBanOutPut()
        {
            return LuongCoBan;  
        }
        //hàm tinhluong có thể được viết đè bởi lớp con sử dụng virtual
        public virtual double TinhLuong()
        {
            return LuongCoBan;
        }
        // hiển thị thông tin nhân viên 
        public virtual void HienThiThongTinNhanVien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ và tên : {0}", HoTen);
            Console.WriteLine("Mã Nhân viên : {0}", MaNhanVien);
            Console.WriteLine("Lương : {0} ",TinhLuong());
        }


    }
}
