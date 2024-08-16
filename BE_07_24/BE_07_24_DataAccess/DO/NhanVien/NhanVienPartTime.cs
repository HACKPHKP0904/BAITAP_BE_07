using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_07_24_DataAccess.DO.NhanVien
{
    public class NhanVienPartTime : NhanVien
    {
        private double SoGioLamViec { get; set; }
        private double LuongGio { get; set; }

        // hàm input NhanVienPartTime
        public NhanVienPartTime(string hoten,string manhanvien,double sogiolamviec,double luonggio) : base(hoten,manhanvien,0) 
        {
            SoGioLamViec = sogiolamviec;
            LuongGio = luonggio;
        }
        // hàm tính lương of NhanVienPartTime
        public override double TinhLuong()
        {
            return SoGioLamViec * LuongGio; 

        }
        //hiển thị thông tin nhân viên partitme
        public override void HienThiThongTinNhanVien()
        {
            Console.OutputEncoding = Encoding.UTF8;
            base.HienThiThongTinNhanVien();
            Console.WriteLine("Số giờ làm việc : {0}", SoGioLamViec);
            Console.WriteLine("Lương giờ :{0}", LuongGio);  
        }
    }
}
