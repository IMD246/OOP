using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPractice
{
    public abstract class AbstractNhanVien
    {
        public virtual bool HoiThangChuc(int tuoi,string ten)
        {
            bool ketQua = false;
            if (tuoi>=20 && tuoi<30)
            {
                Console.WriteLine($"{ten} dang la tap su");               
            }
            else if(tuoi>=30)
            {
                Console.WriteLine($"{ten} duoc thang chuc");
                ketQua = true;
            }
            return ketQua;
        }
    }
}
