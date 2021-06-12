using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    class GiaoVien : NhanVien,InterfaceNhanVien
    {
        private mon[] mon;

        internal mon[] Mon { get => mon; set => mon = value; }

        public GiaoVien(string maID,string ten, string Truong, int tuoi, int luongCB, mon[] mon) : base(maID,ten, Truong, tuoi,luongCB)
        {
            this.mon = mon;
        }
        public GiaoVien()
        {
        }
        public override bool HoiThangChuc(int tuoi , string ten)
        {
            return base.HoiThangChuc(tuoi,ten);
        }
        private bool kiemTraChu(string s)
        {
            bool kiemTra = false;
            if (s.Length == 0)
            {
                kiemTra = false;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z'))
                    {
                        kiemTra = true;
                    }
                }
            }
            return kiemTra;
        }
        private bool kiemTraRong(string s)
        {
            if (s.Length == 0)
            {
                return false;
            }
            return true;
        }
        public mon[] nhapDanhSachMon()
        {
            int n = 0;
            do
            {
                Console.Write("Nhap vao so luong mon: ");
                n = int.Parse(Console.ReadLine());
            } while (n<0 || n>2);
            Mon = new mon[n];
            for (int i = 0; i < Mon.Length; i++)
            {
                Mon[i] = new mon();
                do
                {                   
                    Console.Write("Nhap vao ma mon : ");
                    Mon[i].MaMon = Console.ReadLine();
                } while (kiemTraRong(Mon[i].MaMon) == false);
                do
                {
                    Console.Write("Nhap vao ten mon : ");
                    Mon[i].TenMon = Console.ReadLine();
                } while (kiemTraChu(Mon[i].TenMon) == false);
            }
            return Mon;
        }
        public override string toString()
        {
            string chuoi = "";
            for (int i = 0; i < Mon.Length; i++)
            {
                chuoi += $"Môn {i+1}: {Mon[i].toString()}\n ";
            }
            return $"{base.toString()}\n{chuoi}";
        }

        public void TinhLuong()
        {
            float heSoLuong = 0.0f;
            if (HoiThangChuc(Tuoi1, Ten1) == true)
            {
                heSoLuong = 2.0f;
            }
            else
            {
                heSoLuong = 1.5f;
            }
            double luongThat = heSoLuong * LuongCB;
            Console.WriteLine($"{MaID} \n Luong that : {luongThat}");
        }
    }
}
