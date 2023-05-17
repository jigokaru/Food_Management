using EFC_02.Enitities;
using EFC_02.Iservices;
using EFC_02.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.view
{
    public class MonAnView
    {
        ICongThucServices congThucServices = new CongThucServices();
        IMonAnServices monAnServices = new MonAnServices();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------Chuong Trinh Quan Ly Nau An--------");
            Console.WriteLine("1 Them mon an.");
            Console.WriteLine("2 Hien thi danh sach cong thuc nau an.");
            Console.WriteLine("3 Tim kiem nhung mon an theo nguyen lieu");
            Console.WriteLine();
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            RequestController(c);
        }
        public void RequestController(char c)
        {
            List<LoaiMonAn> loaiMonAns = new List<LoaiMonAn>();
            List<MonAn> monAns = new List<MonAn>();
            List<CongThuc> congThucs = new List<CongThuc>();
            List<NguyenLieu> nguyenLieus = new List<NguyenLieu>();
            switch (c)
            {
                case '1':
                    MonAn monAn = new MonAn();
                    monAn.NhapThongTin();
                    monAnServices.ThemMonAn(monAn);
                    MonAn newMonAn = monAnServices.newMonAn();
                    Console.WriteLine("ban muon bao nhieu cong thuc");
                    bool check = false;
                    int a;
                    do
                    {
                        check = int.TryParse(Console.ReadLine(), out a);
                        if (!check || a <= 0)
                        {
                            Console.WriteLine("nhap lieu sai, yeu cau nhap lai");
                        }
                    } while (!check);
                    for(int i = 0; i < a; i++)
                    {
                        
                        CongThuc congThuc = new CongThuc();
                        congThuc.NhapThongTin();
                        congThuc.MonAnID = newMonAn.MonAnID;
                        congThucServices.ThemCongThuc(congThuc);
                    }
                    break;
                case '2':
                    List<MonAn> monAns1 = monAnServices.DanhSachMonAn();
                    foreach(MonAn monAn1 in monAns1)
                    {
                        Console.WriteLine($"mon an: {monAn1.TenMon}");
                        monAn1.DanhSachCongThuc.ToList().ForEach(x=> Console.WriteLine($"nguyen lieu {x.nguyenLieu.TenNguyenLieu}, so luong {x.SoLuong}, don vi tinh {x.DonViTinh}"));

                    }
                    break;
                case '3':
                    Console.WriteLine("nhap ten nguyen lieu:");
                    string tennguyenlieu = Console.ReadLine();
                    List<MonAn> monancantim = monAnServices.TimKiemMonAnTheoNgLieu(tennguyenlieu);
                    foreach(MonAn monAn1 in monancantim)
                    {
                        Console.WriteLine($"mon an: {monAn1.TenMon}");
                    }
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
