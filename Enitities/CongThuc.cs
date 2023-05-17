using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Enitities
{
    public class CongThuc
    {
        public int CongThucID { get; set; }
        public int MonAnID { get; set; }
        public MonAn MonAn { get; set; }
        public int NguyenLieuID { get; set; }
        public NguyenLieu nguyenLieu { get; set; }
        [Required(ErrorMessage = "so luong khong duoc de trong!")]
        public int SoLuong{ get; set; }
        [Required(ErrorMessage = "don vi tinh khong duoc de trong!")]
        public int DonViTinh { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap ID nguyen lieu:");
            NguyenLieuID = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap so luong:");
            SoLuong = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap don vi tinh:");
            DonViTinh = int.Parse(Console.ReadLine());

        }

       
    }
}
