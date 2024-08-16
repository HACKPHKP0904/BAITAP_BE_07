﻿using BE_07_24_DataAccess.DO.NhanVien;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Check_Validate;

namespace BE_07_24_DataAccess.DAL
{
    public class Nhanvien_Business 
    {
        public  static void nhanvienInPut()
        {
            List<NhanVien> danhsachnhanvien = new List<NhanVien>();
            string tieptuc = "y";
            do
            {
                Console.WriteLine("CHƯƠNG TRÌNH TÍNH TOÁN TIỀN LƯƠNG CHO NHÂN VIÊN ");
                Console.WriteLine("===================================================");
                Console.Write("Nhập Họ Và Tên : ");
                string hoten = Console.ReadLine();
                Check_Validate.check_bien.check_hoten(hoten);
                Console.Write("Nhập Mã Số Nhân Viên:");
                string manhanvien = Console.ReadLine();
                Check_Validate.check_bien.check_manhanvien(manhanvien);
                Console.Write("Nhập Lương Cơ Bản : ");
                double luongcoban;
                Check_Validate.check_bien.check_dulieu(out luongcoban);

                bool isluachon = false;
                while (!isluachon)
                {
                    Console.WriteLine("VUI LÒNG CHỌN DẠNG NHÂN VIÊN :");
                    Console.WriteLine("1. Nhân Viên PartTime");
                    Console.WriteLine("2. Nhân Viên FullTime");
                    string luachon = Console.ReadLine();
                    switch (luachon)
                    {
                        case "1":
                            isluachon=true;
                            Console.WriteLine("======================================");
                            Console.WriteLine("Nhập Số Giờ Làm Việc");
                            double sogiolamviec;
                            Check_Validate.check_bien.check_dulieu(out sogiolamviec);
                            Console.WriteLine("Nhập Lương Giờ :");
                            double luonggio;
                            Check_Validate.check_bien.check_dulieu(out luonggio);
                            NhanVienPartTime nhanVienPartTime = new NhanVienPartTime(hoten, manhanvien, sogiolamviec, luonggio);
                            danhsachnhanvien.Add(nhanVienPartTime);
                            break;
                        case "2":
                            isluachon=true;
                            Console.WriteLine("======================================");
                            Console.WriteLine("Nhập tiền thưởng cho nhân viên : ");
                            double thuong;
                            Check_Validate.check_bien.check_dulieu(out thuong);
                            NhanVienFullTime nhanVienFullTime = new NhanVienFullTime(hoten, manhanvien, luongcoban, thuong);
                            danhsachnhanvien.Add(nhanVienFullTime);
                            break;
                        default:
                            Console.Write("Bạn đã chọn ngoài lựa chọn 1 và 2. Vui lòng chọn lại : ");
                            break;
                    }
                }
                // hỏi người dùng có muốn thêm nhân viên tiếp không
                Console.Write("Bạn có muốn thêm nhân viên khác không ? (y/n) : ");
                tieptuc = Console.ReadLine().ToLower();
            } while (tieptuc == "y");
            //tạo danh sách riêng cho từng nhanvien 
            List<NhanVienFullTime> danhsachnhanVienFullTimes = new List<NhanVienFullTime>();
            List<NhanVienPartTime> danhsachnhanVienPartTimes = new List<NhanVienPartTime>();
            foreach(var nhanVien  in danhsachnhanvien)
            {
                if( nhanVien is NhanVienFullTime )
                {
                    danhsachnhanVienFullTimes.Add((NhanVienFullTime)nhanVien);
                }
                else if (nhanVien is NhanVienPartTime)
                {
                    danhsachnhanVienPartTimes.Add((NhanVienPartTime)nhanVien);
                }
            }
            // in ra danh sách nhân viên full time
            Console.WriteLine("\nDanh sách nhân viên Full Time");
            Console.WriteLine("==================================");
            foreach(var item in danhsachnhanVienFullTimes)
            {
                item.HienThiThongTinNhanVien();
                Console.WriteLine();
            }
            // in ra danh sách nhân viên part time
            Console.WriteLine("\nDanh sách nhân viên Part Time");
            Console.WriteLine("==================================");
            foreach (var item in danhsachnhanVienPartTimes)
            {
                item.HienThiThongTinNhanVien();
                Console.WriteLine();
            }

        }
    }
}
