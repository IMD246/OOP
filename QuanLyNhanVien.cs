using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPractice
{
    class QuanLyNhanVien
    {
        private List<GiaoVien> listGiaoVien = new List<GiaoVien>(); 
        private List<NhanVienPhongBan> listNhanVienPhongBan = new List<NhanVienPhongBan>();
        public static string kiemTraSoChuoi = null;
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
                    if ((s[i] >= 'A' && s[i] <= 'Z') || (s[i]>='a' && s[i]<='z'))
                    {
                        kiemTra = true;
                    }
                }
            }
            return kiemTra;
        }
        private bool kiemTraRong(string s)
        {
            if(s.Length ==0)
            {
                return false;
            }
            return true;
        }
        private bool kiemTraSo(int k)
        {
            bool kiemTra = false;
            while(k>=0 && k<=9)
            {
                kiemTra = true;
            }
            return kiemTra;
        }
        public bool kiemTraSoNangCao(string k)
        {
            for (int i = 0; i < k.Length; i++)
            {
                if (k[i] >= '0' && k[i]<='9')
                {
                    return true;
                }
            }         
            return false;
        }
        private void themNhanVien()
        {
            int chon = 0;
            int dem = 0;
            do
            {
                Console.Clear();
                dem++;
                if (dem == 3)
                {
                    dem = 0;
                    Console.WriteLine("Hay thu lai");
                    break;
                }
                Console.WriteLine("1. Giao Vien");
                Console.WriteLine("2. Nhan Vien Phong Ban");
                Console.Write("Chon loai nhan vien ban muon them <1:2>: ");
                chon = int.Parse(Console.ReadLine());
            } while (chon != 1 && chon != 2);
            if (chon == 1)
            {               
                GiaoVien gv = new GiaoVien();
                do
                {
                    Console.Clear();
                    Console.Write("Nhap vao ma ID :");
                    gv.MaID = Console.ReadLine();
                } while (kiemTraRong(gv.MaID) == false);
                do
                {
                    Console.Clear();
                    Console.Write("Nhap vao ten :");
                    gv.Ten1 = Console.ReadLine();
                } while (kiemTraChu(gv.Ten1) == false);
                do
                {
                    Console.Clear();
                    Console.Write("Nhap vao Truong :");
                    gv.Truong1 = Console.ReadLine();
                } while (kiemTraChu(gv.Truong1) == false);
                do
                {
                    Console.Clear();
                    kiemTraSoChuoi = null;                  
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao tuoi : ");
                        kiemTraSoChuoi = Console.ReadLine();
                    } while (kiemTraSoNangCao(kiemTraSoChuoi)==false);
                    gv.Tuoi1 = int.Parse(kiemTraSoChuoi);
                } while (gv.Tuoi1 <18 || gv.Tuoi1>=50);                    
                do
                {
                    Console.Clear();
                    kiemTraSoChuoi = null;                  
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao luong co ban :");
                        kiemTraSoChuoi = Console.ReadLine();
                    } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                    gv.LuongCB = int.Parse(kiemTraSoChuoi);
                } while (gv.LuongCB<4000000);                         
                Console.Clear();
                mon[] mangMon = new mon[0];
                mangMon = gv.nhapDanhSachMon();
                bool ketQua = true;
                for (int i = 0; i < listGiaoVien.Count; i++)
                {
                    if (gv.MaID.Equals(listGiaoVien[i].MaID))
                    {
                        ketQua = false;
                        break;
                    }
                }
                if (ketQua == true)
                {
                    listGiaoVien.Add(gv);
                    luuFileGiaoVien();
                    Console.WriteLine("Them Thanh Cong!");
                }
                else
                {
                    Console.WriteLine("Trung ma ID");
                    Console.WriteLine("Them that bai !");
                }
            }
            else if(chon==2)
            {
                NhanVienPhongBan nvPhongBan = new NhanVienPhongBan();
                do
                {
                    Console.Clear();
                    Console.Write("Nhap vao ma ID :");
                    nvPhongBan.MaID = Console.ReadLine();
                } while (kiemTraRong(nvPhongBan.MaID) == false);
                do
                {
                    Console.Clear();
                    Console.Write("Nhap vao ten :");
                    nvPhongBan.Ten1 = Console.ReadLine();
                } while (kiemTraChu(nvPhongBan.Ten1) == false);
                do
                {
                    Console.Clear();
                    Console.Write("Nhap vao Cong Ty :");
                    nvPhongBan.Truong1 = Console.ReadLine();
                } while (kiemTraChu(nvPhongBan.Truong1) == false);
                do
                {
                    Console.Clear();
                    kiemTraSoChuoi = null;
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao tuoi : ");
                        kiemTraSoChuoi = Console.ReadLine();
                    } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                    nvPhongBan.Tuoi1 = int.Parse(kiemTraSoChuoi);
                } while (nvPhongBan.Tuoi1 < 18 || nvPhongBan.Tuoi1 >= 50);
                do
                {
                    Console.Clear();
                    kiemTraSoChuoi = null;
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao luong Co Ban : ");
                        kiemTraSoChuoi = Console.ReadLine();
                    } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                    nvPhongBan.LuongCB = int.Parse(kiemTraSoChuoi);
                } while (nvPhongBan.LuongCB < 4000000);
                do
                {
                    Console.Clear();
                    kiemTraSoChuoi = null;
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao so gio lam : ");
                        kiemTraSoChuoi = Console.ReadLine();
                    } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                    nvPhongBan.SoGioLam = int.Parse(kiemTraSoChuoi);
                } while (nvPhongBan.SoGioLam < 100 || nvPhongBan.SoGioLam >250);
                bool ketQua = true;
                for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                {
                    if(nvPhongBan.MaID == listNhanVienPhongBan[i].MaID)
                    {
                        ketQua = false;
                        break;
                    }
                }              
                if (ketQua == true)
                {
                    listNhanVienPhongBan.Add(nvPhongBan);
                    luuFileNhanVienPhongBan();
                    Console.WriteLine("Them Thanh Cong!");
                }
                else
                {
                    Console.WriteLine("Trung ma ID");
                    Console.WriteLine("Them that bai !");
                }
            }   
        }
        private void xoaNhanVien()
        {
            int chon = 0;
            int dem = 0;
            string maID = "";
            bool kqua = false;
            int k = 0;
            do
            {
                Console.Clear();
                dem++;
                if (dem == 3)
                {
                    dem = 0;
                    break;
                }
                Console.WriteLine("1. Giao Vien");
                Console.WriteLine("2. Nhan Vien Phong Ban");
                Console.Write("Chon loai nhan vien ban muon xoa <1:2>: ");
                chon = int.Parse(Console.ReadLine());
            } while (chon != 1 && chon != 2);
            if (chon == 1)
            {
                Console.Write("Nhap vao ma ID :");
                maID = Console.ReadLine();
                for (int i = 0; i < listGiaoVien.Count; i++)
                {
                    if (listGiaoVien[i].MaID.Equals(maID))
                    {
                        kqua = true;
                        k = i;                      
                        break;
                    }
                }
                if(kqua == true)
                {
                    listGiaoVien.Remove(listGiaoVien[k]);
                    Console.WriteLine("Xoa thanh cong !!");
                    luuFileGiaoVien();
                }
                else
                {
                    Console.WriteLine("Khong tim thay");
                }
            }
            else
            {
                Console.Write("Nhap vao ma ID :");
                maID = Console.ReadLine();
                for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                {
                    if(listNhanVienPhongBan[i].MaID.Equals(maID))
                    {
                        kqua = true;
                        k = i;
                        break;
                    }
                }
                if (kqua == true)
                {
                    listNhanVienPhongBan.Remove(listNhanVienPhongBan[k]);
                    Console.WriteLine("Xoa thanh cong !!");
                    luuFileNhanVienPhongBan();
                }
                else
                {
                    Console.WriteLine("Khong tim thay");
                }
            }
        }
        private void suaNhanVien()
        {
            int chon = 0;
            int dem = 0;
            string maID = "";
            bool kqua = false;
            int l = 0;
            do
            {
                Console.Clear();
                dem++;
                if (dem == 3)
                {
                    dem = 0;
                    break;
                }
                Console.WriteLine("1. Giao Vien");
                Console.WriteLine("2. Nhan Vien Phong Ban");
                Console.Write("Chon loai nhan vien ban muon xoa <1:2>: ");
                chon = int.Parse(Console.ReadLine());
            } while (chon != 1 && chon != 2);
            if (chon == 1)
            {
                Console.Write("Nhap vao ma ID :");
                maID = Console.ReadLine();
                for (int i = 0; i < listGiaoVien.Count; i++)
                {
                    if (listGiaoVien[i].MaID.Equals(maID))
                    {
                        kqua = true;
                        l = i;
                        Console.Clear();
                        break;
                    }
                }
                if (kqua == true)
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao ten :");
                        listGiaoVien[l].Ten1 = Console.ReadLine();
                    } while (kiemTraChu(listGiaoVien[l].Ten1) == false);
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao Cong Ty :");
                        listGiaoVien[l].Truong1 = Console.ReadLine();
                    } while (kiemTraChu(listGiaoVien[l].Truong1) == false);
                    do
                    {
                        Console.Clear();
                        kiemTraSoChuoi = null;
                        do
                        {
                            Console.Clear();
                            Console.Write("Nhap vao tuoi : ");
                            kiemTraSoChuoi = Console.ReadLine();
                        } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                        listGiaoVien[l].Tuoi1 = int.Parse(kiemTraSoChuoi);
                    } while (listGiaoVien[l].Tuoi1 < 18 || listGiaoVien[l].Tuoi1 >= 50);
                    do
                    {
                        Console.Clear();
                        kiemTraSoChuoi = null;
                        do
                        {
                            Console.Clear();
                            Console.Write("Nhap vao luong Co Ban : ");
                            kiemTraSoChuoi = Console.ReadLine();
                        } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                        listGiaoVien[l].LuongCB = int.Parse(kiemTraSoChuoi);
                    } while (listGiaoVien[l].LuongCB < 4000000);
                    Console.Clear();
                    mon[] mangMon = new mon[0];
                    mangMon = listGiaoVien[l].nhapDanhSachMon();
                    Console.WriteLine("Sửa thành công");
                    luuFileGiaoVien();
                }
                else
                {
                    Console.WriteLine("Khong tim thay");
                }
            }
            else
            {
                Console.Write("Nhap vao ma ID :");
                maID = Console.ReadLine();
                for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                {
                    if (listNhanVienPhongBan[i].MaID.Equals(maID))
                    {
                        kqua = true;
                        l = i;
                        break;
                    }
                }
                if (kqua == true)
                {
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao ten :");
                        listNhanVienPhongBan[l].Ten1 = Console.ReadLine();
                    } while (kiemTraChu(listNhanVienPhongBan[l].Ten1) == false);
                    do
                    {
                        Console.Clear();
                        Console.Write("Nhap vao Cong Ty :");
                        listNhanVienPhongBan[l].Truong1 = Console.ReadLine();
                    } while (kiemTraChu(listNhanVienPhongBan[l].Truong1) == false);
                    do
                    {
                        Console.Clear();
                        kiemTraSoChuoi = null;
                        do
                        {
                            Console.Clear();
                            Console.Write("Nhap vao tuoi : ");
                            kiemTraSoChuoi = Console.ReadLine();
                        } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                        listNhanVienPhongBan[l].Tuoi1 = int.Parse(kiemTraSoChuoi);
                    } while (listNhanVienPhongBan[l].Tuoi1 < 18 || listNhanVienPhongBan[l].Tuoi1 >= 50);
                    do
                    {
                        Console.Clear();
                        kiemTraSoChuoi = null;
                        do
                        {
                            Console.Clear();
                            Console.Write("Nhap vao luong Co Ban : ");
                            kiemTraSoChuoi = Console.ReadLine();
                        } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                        listNhanVienPhongBan[l].LuongCB = int.Parse(kiemTraSoChuoi);
                    } while (listNhanVienPhongBan[l].LuongCB < 4000000);
                    do
                    {
                        Console.Clear();
                        kiemTraSoChuoi = null;
                        do
                        {
                            Console.Clear();
                            Console.Write("Nhap vao so gio lam : ");
                            kiemTraSoChuoi = Console.ReadLine();
                        } while (kiemTraSoNangCao(kiemTraSoChuoi) == false);
                        listNhanVienPhongBan[l].SoGioLam = int.Parse(kiemTraSoChuoi);
                    } while (listNhanVienPhongBan[l].SoGioLam < 100 || listNhanVienPhongBan[l].SoGioLam > 250);
                    Console.WriteLine("Sua thanh cong !!");
                    luuFileNhanVienPhongBan();
                }
                else
                {
                    Console.WriteLine("Khong tim thay");
                }
            }
        }
        private void hienThiDanhSach()
        {
            int chon = 0;
            int dem = 0;
            do
            {
                Console.Clear();
                dem++;
                if(dem == 3)
                {
                    dem = 0;
                    Console.WriteLine("Hay thu lai");
                }
                Console.Write("Chon loai danh sach ban muon in ra (1:2): ");
                chon = int.Parse(Console.ReadLine());
            } while (chon!=1 && chon!=2);
            if(chon == 1)
            {            
                if(listGiaoVien.Count == 0)
                {
                    Console.WriteLine("Danh sach trong");
                }
                else
                {
                    for (int i = 0; i < listGiaoVien.Count; i++)
                    {
                        Console.WriteLine(listGiaoVien[i].toString());
                    }
                }
            }
            else
            {
                if (listNhanVienPhongBan.Count == 0)
                {
                    Console.WriteLine("Danh sach trong");
                }
                else
                {
                    for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                    {
                        Console.WriteLine(listNhanVienPhongBan[i].toString());
                    }
                }
            }
        }
        private void menuChucNang()
        {
            int chonChucNang = 0;
            Console.WriteLine("1.Them Nhan Su");
            Console.WriteLine("2.Xoa Nhan Su");
            Console.WriteLine("3.Sua Nhan Su");
            Console.WriteLine("4.Hien Thi Nhan Su");
            Console.WriteLine("5.Tim kiem nhan su");
            Console.WriteLine("6.Xem tinh trang chuc vu cua nhan su");
            Console.WriteLine("7.Tinh luong nhan su");
            Console.WriteLine("8.Thoat");
            do
            {
                Console.Write("Chon Chuc Nang: ");
                chonChucNang = int.Parse(Console.ReadLine());
            } while (chonChucNang != 1 && chonChucNang != 2 && chonChucNang != 3 && chonChucNang != 4 && chonChucNang != 5 && chonChucNang != 6 && chonChucNang != 7 && chonChucNang!=8);
            if (chonChucNang == 1)
            {
                Console.Clear();
                themNhanVien();
                char tt = ' ';
                Console.Write("An 'k' de tiep tuc: ");
                tt = char.Parse(Console.ReadLine());
                if (tt == 'k')
                {
                    Console.Clear();
                    menuChucNang();
                }
                else
                {
                    Console.Clear();
                    hienThiMenu();
                }
            }
            else if (chonChucNang == 2)
            {
                Console.Clear();
                xoaNhanVien();
                char tt = ' ';
                Console.Write("An 'K' de tiep tuc: ");
                tt = char.Parse(Console.ReadLine());
                if (tt == 'k' || tt == 'K')
                {
                    Console.Clear();
                    menuChucNang();
                }
                else
                {
                    Console.Clear();
                    hienThiMenu();
                }
            }
            else if (chonChucNang == 3)
            {
                Console.Clear();
                suaNhanVien();
                char tt = ' ';
                Console.Write("An 'K' de tiep tuc: ");
                tt = char.Parse(Console.ReadLine());
                if (tt == 'k' || tt == 'K')
                {
                    Console.Clear();
                    menuChucNang();
                }
                else
                {
                    Console.Clear();
                    hienThiMenu();
                }
            }
            else if (chonChucNang == 4)
            {
                Console.Clear();
                hienThiDanhSach();
                char tt = ' ';
                Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                tt = char.Parse(Console.ReadLine());
                if (tt == 'k' || tt == 'K')
                {
                    Console.Clear();
                    menuChucNang();
                }
                else
                {
                    Console.Clear();
                    hienThiMenu();
                }
            }
            else if (chonChucNang == 5)
            {
                int d = 0;
                int k = 0;
                bool kq = false;
                bool kq1 = false;
                string maID = "";
                do
                {
                    Console.WriteLine("1.Giao Vien");
                    Console.WriteLine("2.Nhan Vien Phong Ban");
                    Console.Write("Nhap vao loai nhan vien ban muon tim kiem:");
                    d = int.Parse(Console.ReadLine());
                } while (d != 1 && d != 2);
                if (d == 1)
                {
                    Console.WriteLine("Nhap vao ma ID de tim kiem : ");
                    maID = Console.ReadLine();
                    for (int i = 0; i < listGiaoVien.Count; i++)
                    {
                        if (listGiaoVien[i].MaID.Equals(maID))
                        {
                            k = i;
                            kq = true;
                            break;
                        }
                    }
                    if (kq == true)
                    {
                        Console.WriteLine(listGiaoVien[k].toString());
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay ");
                    }
                }
                else
                {
                    for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                    {
                        if (listNhanVienPhongBan[i].MaID.Equals(maID))
                        {
                            k = i;
                            kq1 = true;
                            break;
                        }
                    }
                    if (kq1 == true)
                    {
                        Console.WriteLine(listNhanVienPhongBan[k].toString());
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay");
                    }
                }
                char tt = ' ';
                Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                tt = char.Parse(Console.ReadLine());
                if (tt == 'k' || tt == 'K')
                {
                    Console.Clear();
                    menuChucNang();
                }
                else
                {
                    Console.Clear();
                    hienThiMenu();
                }
            }
            else if (chonChucNang == 6)
            {
                for (int i = 0; i < listGiaoVien.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Danh sach giao vien : ");
                    }
                    listGiaoVien[i].HoiThangChuc(listGiaoVien[i].Tuoi1, listGiaoVien[i].Ten1);
                }
                for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("Danh sach Nhan Vien Phong Ban : ");
                    }
                    listNhanVienPhongBan[i].HoiThangChuc(listNhanVienPhongBan[i].Tuoi1, listNhanVienPhongBan[i].Ten1);
                }
                if (listGiaoVien.Count == 0)
                {
                    Console.WriteLine("List's Teacher are empty");
                }
                if (listNhanVienPhongBan.Count == 0)
                {
                    Console.WriteLine("List's Department Stuff are empty");
                }
                char tt = ' ';
                Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                tt = char.Parse(Console.ReadLine());
                if (tt == 'k' || tt == 'K')
                {
                    Console.Clear();
                    menuChucNang();
                }
                else
                {
                    Console.Clear();
                    hienThiMenu();
                }
            }
            else if (chonChucNang == 7)
            {
                if (listGiaoVien.Count == 0)
                {
                    Console.WriteLine("Khong co du lieu");
                }
                for (int i = 0; i < listGiaoVien.Count; i++)
                {
                    listGiaoVien[i].TinhLuong();
                }
                if (listNhanVienPhongBan.Count == 0)
                {
                    Console.WriteLine("Khong co du lieu");
                }
                for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                {
                    listNhanVienPhongBan[i].TinhLuong();
                }
                char tt = ' ';
                Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                tt = char.Parse(Console.ReadLine());
                if (tt == 'k' || tt == 'K')
                {
                    Console.Clear();
                    menuChucNang();
                }
                else
                {
                    Console.Clear();
                    hienThiMenu();
                }
            }
            else if(chonChucNang == 8)
            {
                Console.Clear();
                hienThiMenu();          
            }
        }
        private void luuFileGiaoVien()
        {
            StreamWriter sw = new StreamWriter("FileGiaoVien.txt");
            string chuoi = "";
            int dem = 0;
            try
            {
                using (sw)
                {
                    sw.Write("So Luong : " + listGiaoVien.Count);
                    foreach (GiaoVien gv in listGiaoVien)
                    {
                        chuoi = null;
                        foreach (mon m in gv.Mon)
                        {
                            chuoi += $"{gv.Mon.Length}#";
                            dem++;
                            if (dem < gv.Mon.Length)
                            {
                                chuoi += $"{m.MaMon}#{m.TenMon}#";
                            }
                            else
                            {
                                chuoi += $"{m.MaMon}#{m.TenMon}";
                            }
                        }
                        sw.WriteLine("");
                        sw.WriteLine($"{gv.MaID}#{gv.Ten1}#{gv.Truong1}#{gv.Tuoi1}#{gv.LuongCB}#{chuoi}");                     
                    }
                }
            }
            catch (Exception)
            {
                throw;              
            }
            finally
            {
                sw.Close();
            }
        }
        private void luuFileNhanVienPhongBan()
        {
            StreamWriter sw = new StreamWriter("FileNhanVienPhongBan.txt");
            try
            {
                using (sw)
                {
                    sw.Write("So Luong : " + listNhanVienPhongBan.Count);
                    foreach (NhanVienPhongBan npt in listNhanVienPhongBan)
                    {      
                      sw.WriteLine();
                      sw.WriteLine($"{npt.MaID}#{npt.Ten1}#{npt.Truong1}#{npt.Tuoi1}#{npt.LuongCB}#{npt.SoGioLam}");           
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sw.Close();
            }
        }
        private void docFileGiaoVien()
        {
            StreamReader sr = new StreamReader("FileGiaoVien.txt");          
            string[] str;
            listGiaoVien.Clear();
            int doDai = 0;
            try
            {
                using (sr)
                {
                    while (sr.ReadLine() != null)
                    {
                        str = sr.ReadLine().Split('#');
                        GiaoVien gv = new GiaoVien();
                        gv.MaID = str[0];
                        gv.Ten1 = str[1];
                        gv.Truong1 = str[2];
                        gv.Tuoi1 = int.Parse(str[3]);
                        gv.LuongCB = int.Parse(str[4]);
                        doDai = int.Parse(str[5].ToString());
                        gv.Mon = new mon[doDai];
                        for (int i = 0; i < gv.Mon.Length; i++)
                        {
                            gv.Mon[i] = new mon();
                            gv.Mon[i].MaMon = str[5+i+1];
                            gv.Mon[i].TenMon = str[5+i+2];
                        }                            
                        listGiaoVien.Add(gv);
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
        private void docFileNhanVienPhongBan()
        {
            StreamReader sr = new StreamReader("FileNhanVienPhongBan.txt");
            listNhanVienPhongBan.Clear();
            string[] str;
            try
            {
                using (sr)
                {
                    while (sr.ReadLine() != null)
                    {
                        str = sr.ReadLine().Split('#');
                        NhanVienPhongBan npt = new NhanVienPhongBan(str[0], str[1], str[2], int.Parse(str[3]),int.Parse(str[4]),int.Parse(str[5]));
                        listNhanVienPhongBan.Add(npt);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }
        }
        public void hienThiMenu()
        {
            if(listGiaoVien.Count==0)
            {
                docFileGiaoVien();                           
            }
            if(listNhanVienPhongBan.Count==0)
            {
                docFileNhanVienPhongBan();                                
            }           
            Console.WriteLine("1.Quan Ly nhan su");
            Console.WriteLine("2.Thoat");
            int chon = 0;          
            do
            {
               Console.Write("Chon: ");
               chon = int.Parse(Console.ReadLine());
            } while (chon!=1 && chon!=2);
            Console.Clear();
            if(chon == 1)
            {
                int chonChucNang = 0;
                Console.WriteLine("1.Them Nhan Su");
                Console.WriteLine("2.Xoa Nhan Su");
                Console.WriteLine("3.Sua Nhan Su");
                Console.WriteLine("4.Hien Thi Nhan Su");
                Console.WriteLine("5.Tim kiem nhan su");
                Console.WriteLine("6.Xem tinh trang chuc vu cua nhan su");
                Console.WriteLine("7.Tinh luong nhan su");
                Console.WriteLine("8.Thoat");
                do
                {
                    Console.Write("Chon Chuc Nang: ");
                    chonChucNang = int.Parse(Console.ReadLine());
                } while (chonChucNang != 1 && chonChucNang != 2 && chonChucNang != 3 && chonChucNang != 4 && chonChucNang != 5 && chonChucNang != 6 && chonChucNang!=7 && chonChucNang != 8);
                if(chonChucNang == 1)
                {
                    Console.Clear();
                    themNhanVien();
                    char tt = ' ';
                    Console.Write("An 'k' de tiep tuc: ");
                    tt = char.Parse(Console.ReadLine());
                    if(tt=='k')
                    {
                        Console.Clear();
                        menuChucNang();
                    }
                    else
                    {
                        Console.Clear();
                        hienThiMenu();
                    }
                }
                else if (chonChucNang == 2)
                {
                    Console.Clear();
                    xoaNhanVien();
                    char tt = ' ';
                    Console.Write("An 'K' de tiep tuc: ");
                    tt = char.Parse(Console.ReadLine());
                    if (tt == 'k' || tt == 'K')
                    {
                        Console.Clear();
                        menuChucNang();
                    }
                    else
                    {
                        Console.Clear();
                        hienThiMenu();
                    }
                }
                else if (chonChucNang == 3)
                {
                    Console.Clear();
                    suaNhanVien();
                    char tt = ' ';
                    Console.Write("An 'K' de tiep tuc: ");
                    tt = char.Parse(Console.ReadLine());
                    if (tt == 'k' || tt == 'K')
                    {
                        Console.Clear();
                        menuChucNang();
                    }
                    else
                    {
                        Console.Clear();
                        hienThiMenu();
                    }
                }
                else if (chonChucNang == 4)
                {
                    Console.Clear();
                    hienThiDanhSach();
                    char tt = ' ';
                    Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                    tt = char.Parse(Console.ReadLine());
                    if (tt == 'k' || tt == 'K')
                    {
                        Console.Clear();
                        menuChucNang();
                    }
                    else
                    {
                        Console.Clear();
                        hienThiMenu();
                    }
                }              
                else if(chonChucNang==5)
                {
                    int d = 0;
                    int k = 0;
                    bool kq = false;
                    bool kq1 = false;
                    string maID = "";
                    do
                    {
                        Console.WriteLine("1.Giao Vien");
                        Console.WriteLine("2.Nhan Vien Phong Ban");
                        Console.Write("Nhap vao loai nhan vien ban muon tim kiem:");
                        d = int.Parse(Console.ReadLine());
                    } while (d!=1 && d!=2);
                    if (d == 1)
                    {                   
                        Console.WriteLine("Nhap vao ma ID de tim kiem : ");
                        maID = Console.ReadLine();               
                        for (int i = 0; i < listGiaoVien.Count; i++)
                        {
                            if (listGiaoVien[i].MaID.Equals(maID))
                            {
                                k = i;
                                kq = true;
                                break;
                            }
                        }
                        if (kq == true)
                        {
                            Console.WriteLine(listGiaoVien[k].toString());
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay ");
                        }
                    }
                    else
                    {
                        for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                        {
                            if (listNhanVienPhongBan[i].MaID.Equals(maID))
                            {
                                k = i;
                                kq1 = true;
                                break;
                            }
                        }
                        if (kq1 == true)
                        {
                            Console.WriteLine(listNhanVienPhongBan[k].toString());
                        }
                        else
                        {
                            Console.WriteLine("Khong tim thay");
                        }                       
                    }
                    char tt = ' ';
                    Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                    tt = char.Parse(Console.ReadLine());
                    if (tt == 'k' || tt == 'K')
                    {
                        Console.Clear();
                        menuChucNang();
                    }
                    else
                    {
                        Console.Clear();
                        hienThiMenu();
                    }
                }
                else if(chonChucNang == 6)
                {
                    for (int i = 0; i < listGiaoVien.Count; i++)
                    {
                        if(i==0)
                        {
                            Console.WriteLine("Danh sach giao vien : ");                          
                        }
                        listGiaoVien[i].HoiThangChuc(listGiaoVien[i].Tuoi1, listGiaoVien[i].Ten1);
                    }
                    for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                    {
                        if (i == 0)
                        {
                            Console.WriteLine("Danh sach nhan vien phong ban : ");                          
                        }
                        listNhanVienPhongBan[i].HoiThangChuc(listNhanVienPhongBan[i].Tuoi1, listNhanVienPhongBan[i].Ten1);
                    }
                    if(listGiaoVien.Count==0)
                    {
                        Console.WriteLine("List's Teacher are empty");
                    }
                    if(listNhanVienPhongBan.Count == 0)
                    {
                        Console.WriteLine("List's Department Stuff are empty");
                    }
                    char tt = ' ';
                    Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                    tt = char.Parse(Console.ReadLine());
                    if (tt == 'k' || tt == 'K')
                    {
                        Console.Clear();
                        menuChucNang();
                    }
                    else
                    {
                        Console.Clear();
                        hienThiMenu();
                    }
                }
                else if(chonChucNang == 7)
                {
                    if(listGiaoVien.Count==0)
                    {
                        Console.WriteLine("Khong co du lieu");
                    }
                    for (int i = 0; i < listGiaoVien.Count; i++)
                    {
                        listGiaoVien[i].TinhLuong();
                    }
                    if (listNhanVienPhongBan.Count == 0)
                    {
                        Console.WriteLine("Khong co du lieu");
                    }
                    for (int i = 0; i < listNhanVienPhongBan.Count; i++)
                    {
                        listNhanVienPhongBan[i].TinhLuong();
                    }
                    char tt = ' ';
                    Console.Write("An 'K' hoac 'k' de tiep tuc: ");
                    tt = char.Parse(Console.ReadLine());
                    if (tt == 'k' || tt == 'K')
                    {
                        Console.Clear();
                        menuChucNang();
                    }
                    else
                    {
                        Console.Clear();
                        hienThiMenu();
                    }
                }
                else if(chonChucNang==8)
                {
                    Console.Clear();
                    hienThiMenu();                   
                }
            }
            else
            {
                Console.WriteLine("Cam on , hen gap lai !");
            }
        }
    }
}
