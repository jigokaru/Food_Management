using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Enitities
{
    public class MonAn 
    {
        public int MonAnID { get; set; }
        [Required(ErrorMessage = "ten mon an khong duoc de trong!")]
        public string TenMon { get; set; }
        
        public string GhiChu { get; set; }
        public int LoaiMonAnID { get; set; }
        public LoaiMonAn LoaiMonAn { get; set; }
        public IEnumerable<CongThuc> DanhSachCongThuc { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("Nhap ID loai mon an:");
            LoaiMonAnID = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap ten mon an:");
            TenMon = Console.ReadLine();
            Console.WriteLine("nhap ghi chu:");
            GhiChu = Console.ReadLine();
            
        }

        public MonAn()
        {
        }
    }
}
