using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin ad = new Admin();
            QuanLyNhanVien qlNhanVien = new QuanLyNhanVien();
            dangNhap(ad, qlNhanVien);
        }
        static void dangNhap(Admin ad,QuanLyNhanVien qlNhanVien)
        {
            int k = 3;
            string tt = "";
            int dem = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t Menu Dang Nhap");
            do
            {
                if (ad.dangNhap() == true)
                {
                    dem = 0;
                    break;
                }
                else
                {
                    dem++;
                }
            } while (dem != 3);
            if (dem < 3)
            {
                Console.Clear();
                Console.WriteLine("Dang nhap thanh cong !!");
                qlNhanVien.hienThiMenu();
            }
            else
            {
                Console.WriteLine("Dang nhap khong thanh cong !!");
                dem = 0;
                do
                {
                    do
                    {
                        Console.Write("\t1.Tiep Tuc \n\t0. Khong \nBan co muon tiep tuc hay khong <0,1>: ");
                        tt = Console.ReadLine();
                    } while (ad.kiemTraSo(tt) == false);
                    k = int.Parse(tt);
                } while (k != 0 && k != 1);
                if (k == 1)
                {
                    Console.Clear();
                    dangNhap(ad, qlNhanVien);
                }
                else if (k == 0)
                {
                    Console.WriteLine("Cam on , hen gap lai !");
                }
            }
        }
    }
}
