using EFC_02.Enitities;
using EFC_02.Iservices;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Services
{
    public class MonAnServices : IMonAnServices
    {
        private readonly AppDbContext _dbContext;

        public MonAnServices()
        {
            _dbContext = new AppDbContext();
        }

        public MonAn ThemMonAn(MonAn monAn)
        {
            bool check = _dbContext.MonAn.Any(x => x.TenMon == monAn.TenMon);
            if (!check)
            {
                if (!_dbContext.LoaiMonAn.Any(x => x.LoaiMonAnID == monAn.LoaiMonAnID))
                {
                    Console.WriteLine("loai mon an chua ton tai, yeu cau nhap:");
                    LoaiMonAn loaiMonAn = new LoaiMonAn();
                    loaiMonAn.NhapThongTin();
                    _dbContext.LoaiMonAn.Add(loaiMonAn);
                    monAn.LoaiMonAnID = loaiMonAn.LoaiMonAnID;
                    monAn.LoaiMonAn = loaiMonAn;
                }
                _dbContext.MonAn.Add(monAn);
                _dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("mon an ton tai!");
            }
            
            return monAn;
        }
        public List<MonAn> DanhSachMonAn()
        {
            return _dbContext.MonAn.Include(x => x.DanhSachCongThuc).ThenInclude(x => x.nguyenLieu).ToList();
        }
        public MonAn newMonAn()
        {
            return _dbContext.MonAn.OrderBy(x => x.MonAnID).Last() ;
        }
        public List<MonAn> TimKiemMonAnTheoNgLieu(string TenNguyenLieu)
        {
            List<MonAn> MonAnCanTim = _dbContext.MonAn.Include(x => x.DanhSachCongThuc)
                                      .ThenInclude(x => x.nguyenLieu).Where(x => x.DanhSachCongThuc.Any(x => x.nguyenLieu.TenNguyenLieu == TenNguyenLieu)).ToList();
            return MonAnCanTim;
        }
    }
}
