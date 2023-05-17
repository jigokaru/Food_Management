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
    public class CongThucServices : ICongThucServices
    {
        private readonly AppDbContext _dbContext;

        public CongThucServices()
        {
            _dbContext = new AppDbContext();
        }

        public CongThuc ThemCongThuc(CongThuc congThuc)
        {
            bool check = _dbContext.NguyenLieu.Any(x => x.NguyenLieuID == congThuc.NguyenLieuID);
            if(!check)
            {
                NguyenLieu nguyenLieu = new NguyenLieu();
                nguyenLieu.NhapThongTin();
                _dbContext.Add(nguyenLieu);
                congThuc.NguyenLieuID = nguyenLieu.NguyenLieuID;
                congThuc.nguyenLieu = nguyenLieu;
            }
            _dbContext.Add(congThuc);
            _dbContext.SaveChanges();
            return congThuc;
        }
    }
}
