using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_07_24_DataAccess;
using Check_Validate;
namespace BE_07_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("BÀI TẬP NHÂN VIÊN ");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine();
            BE_07_24_DataAccess.DAL.Nhanvien_Business.nhanvienInPut();
            Console.ReadLine();
        }
    }
}
