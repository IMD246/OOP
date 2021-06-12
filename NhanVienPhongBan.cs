using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    class NhanVienPhongBan : NhanVien,InterfaceNhanVien
    {      
        private int soGioLam;

        public int SoGioLam { get => soGioLam; set => soGioLam = value; }

        public NhanVienPhongBan(string maID,string ten , string Truong, int tuoi , int luongCB,int soGioLam):base(maID,ten,Truong, tuoi,luongCB)
        {
            this.soGioLam = soGioLam;
        }
        public NhanVienPhongBan()
        {
            soGioLam = 0;
        }
        public override bool HoiThangChuc(int tuoi, string ten)
        {
           return base.HoiThangChuc(tuoi, ten);
        }
        public override string toString()
        {
            return $"{base.toString()} \nSo Gio Lam : {soGioLam}";
        }
        public void TinhLuong()
        {
            float heSoLuong = 2.5f;          
            if (HoiThangChuc(Tuoi1,Ten1) == true)
            {
                heSoLuong = 2.7f;
            }
            else
            {
                heSoLuong = 2.5f;
            }
            double luongThat = heSoLuong * LuongCB;
            Console.WriteLine($"{MaID}\nLuong that : {luongThat}");
        }
    }
}
