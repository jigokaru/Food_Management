using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Enitities
{
    public class LoaiMonAn
    {
        public int LoaiMonAnID { get; set; }
        [Required(ErrorMessage = "ten loai khong duoc de trong!")]
        public string TenLoai { get; set; }
        public IEnumerable<MonAn> MonAnList { get; set; }

        public LoaiMonAn()
        {

        }

        public void NhapThongTin()
        {
            
            Console.WriteLine("nhap ten loai:");
            TenLoai = Console.ReadLine();
        }

       
    }
}
