using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Check_Validate
{
    public class check_bien
    {
        public static void check_dulieu(out double number)
        {
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Bạn đã nhập sai . Vui lòng nhập lại : ");
            }
        }
        // check cho họ tên 
        public static string check_hoten(string text)
        {
            bool isvalid = false;
            while (!isvalid)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Họ tên không được để trống . Vui lòng nhập lại: ");
                    text = Console.ReadLine();
                }
                else if (HasNumbers(text))
                {
                    Console.WriteLine("Họ tên không được nhập số . Vui lòng nhập lại: ");
                    text =Console.ReadLine();
                }
                else
                {
                    isvalid = true;
                }
            }
            return text;
           
        }
        // check có số không 
        private static bool HasNumbers(string text)
        {
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        // check mã nhân viên 
        public static string check_manhanvien(string text)
        {
            bool istext = false;
            while (!istext)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    Console.WriteLine("Mã Nhân Viên Không Được Để Trống . Vui Lòng Nhập Lại : ");
                    text = Console.ReadLine();
                }
                else
                {
                    istext = true;
                }
            }
            return text;
        }
    }
}
