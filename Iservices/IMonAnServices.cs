using EFC_02.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Iservices
{
    public interface IMonAnServices
    {
        MonAn newMonAn();
        MonAn ThemMonAn(MonAn monAn);
        List<MonAn> DanhSachMonAn();
        List<MonAn> TimKiemMonAnTheoNgLieu(string TenNguyenLieu);
    }
}
