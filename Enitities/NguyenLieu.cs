using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Enitities
{
    public class NguyenLieu
    {
        public int NguyenLieuID{ get; set; }
        [Required(ErrorMessage = "ten nguyen lieu khong duoc de trong!")]
        public string TenNguyenLieu { get; set; }
        public IEnumerable<CongThuc> DanhSachCongThuc { get; set; }
        public void NhapThongTin()
        {
            Console.WriteLine("nhap ten nguyen lieu:");
            TenNguyenLieu = Console.ReadLine();
        }
    }
}
