using Microsoft.EntityFrameworkCore;
using PhucKhang.Entities;

namespace PhucKhang
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<ChiPhi> ChiPhis { get; set; }
        public DbSet<CuaHang> CuaHangs { get; set; }
        public DbSet<DonHang_SanPham> DonHang_SanPhams { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

    }
}
