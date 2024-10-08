﻿using System;
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
        public static string check_hoten(string hoten)
        {
            while (true)
            {
                if (string.IsNullOrWhiteSpace(hoten))
                {
                    Console.WriteLine("Họ tên không được để trống. Vui lòng nhập lại: ");
                    hoten = Console.ReadLine();
                }
                else if (hoten.Any(char.IsDigit))
                {
                    Console.WriteLine("Họ tên không được chứa số. Vui lòng nhập lại: ");
                    hoten = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return hoten;
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
