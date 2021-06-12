using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace OOPractice
{
    class Admin
    {
         private string tenDangNhap;
         private string matKhau;
         private List<Admin> listAdmin = new List<Admin>();
        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }

            set
            {
                tenDangNhap = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public Admin()
        {
            
        }
        public Admin(string tenDangNhap,string matKhau)
        {

        }
        public bool kiemTraSo(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= '0' && s[i] <= '9')
                {
                    return true;
                }
            }          
            return false;
        }
        private void docFileAdmin()
        {
            StreamReader sr = new StreamReader("FileAdmin.txt");
            string[] str;
            listAdmin.Clear();
            try
            {
                using (sr)
                {
                    while (sr.ReadLine() != null)
                    {
                        str = sr.ReadLine().Split('#');
                        Admin ad = new Admin();
                        ad.TenDangNhap = str[0];
                        ad.MatKhau = str[1];                     
                        listAdmin.Add(ad);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            finally
            {
                sr.Close();
            }
        }
        public bool dangNhap()
        {
            docFileAdmin();
            bool ketQua = false;
            Console.Write("Nhap vao admin : ");
            TenDangNhap = Console.ReadLine();
            Console.Write("Nhap vao Mat Khau : ");
            MatKhau = Console.ReadLine();
            for (int i = 0; i < listAdmin.Count; i++)
            {
                if ((listAdmin[i].tenDangNhap == TenDangNhap) && (listAdmin[i].matKhau == MatKhau))
                {
                    ketQua = true;
                    break;
                }
            }
            return ketQua;
        }
    }
}
