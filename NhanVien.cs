using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    class NhanVien : AbstractNhanVien
    {
        private string maID;
        private string Ten;
        private string Truong;
        private int Tuoi;
        private int luongCB;

        public NhanVien()
        {
            maID = default;
            Tuoi = default;
            Truong = default;
            luongCB = default;
        }

        public NhanVien(string maID,string Ten, string Truong, int Tuoi,int luongCB)
        {
            this.maID = maID;
            this.Ten = Ten;
            this.Truong = Truong;
            Tuoi1 = Tuoi;
            this.luongCB = luongCB;
        }     
        public string Ten1 { get => Ten; set => Ten = value; }
        public string Truong1 { get => Truong; set => Truong = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
        public string MaID { get => maID; set => maID = value; }
        public int LuongCB { get => luongCB; set => luongCB = value; }

        public override bool HoiThangChuc(int tuoi, string ten)
        {
           return base.HoiThangChuc(tuoi, ten);
        }
        public virtual string toString()
        {
            return $"MaID:{maID}\nTen:{Ten}\nCong Ty: {Truong}\ntuoi:{Tuoi}\nluong Co Ban:{luongCB}";            
        }
    }
}
