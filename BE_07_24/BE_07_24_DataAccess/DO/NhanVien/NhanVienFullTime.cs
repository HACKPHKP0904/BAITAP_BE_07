using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DO.NhanVien
{
    public class NhanVienFullTime : NhanVien
    {
        private double Thuong { get; set; }

        public NhanVienFullTime(string hoten , string manhanvien, double luongcoban, double thuong) : base(hoten, manhanvien, luongcoban)
        {
            Thuong = thuong;
        }
        public override double TinhLuong()
        {
            double luong;
            luong = LuongCoBanOutPut() + Thuong;
            return luong;
        }
        public override void HienThiThongTinNhanVien()
        {
            Console.OutputEncoding  = Encoding.UTF8;
            base.HienThiThongTinNhanVien();
            Console.WriteLine("Tiền Thưởng : {0}", Thuong);
        }
    }
        
}

