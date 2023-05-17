using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_02.Enitities
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<NguyenLieu> NguyenLieu { get; set; }
        public virtual DbSet<LoaiMonAn> LoaiMonAn { get; set; }
        public virtual DbSet<CongThuc> CongThuc { get; set; }
        public virtual DbSet<MonAn> MonAn { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($"server = DESKTOP-OIAL4C8; database = QuanLyCongThucNauAn; trusted_connection = true; trustservercertificate = true");
        }
    }
}
