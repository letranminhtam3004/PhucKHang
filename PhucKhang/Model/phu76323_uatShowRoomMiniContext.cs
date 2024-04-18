using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhucKhang.Model
{
    public partial class phu76323_uatShowRoomMiniContext : DbContext
    {
        public phu76323_uatShowRoomMiniContext()
        {
        }

        public phu76323_uatShowRoomMiniContext(DbContextOptions<phu76323_uatShowRoomMiniContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaiViet> BaiViets { get; set; } = null!;
        public virtual DbSet<ChiPhi> ChiPhis { get; set; } = null!;
        public virtual DbSet<CuaHang> CuaHangs { get; set; } = null!;
        public virtual DbSet<DanhMucBaoCao> DanhMucBaoCaos { get; set; } = null!;
        public virtual DbSet<DanhMucChiTietDichVuCongThem> DanhMucChiTietDichVuCongThems { get; set; } = null!;
        public virtual DbSet<DanhMucChuyenMuc> DanhMucChuyenMucs { get; set; } = null!;
        public virtual DbSet<DanhMucCungMenh> DanhMucCungMenhs { get; set; } = null!;
        public virtual DbSet<DanhMucDichVuCongThem> DanhMucDichVuCongThems { get; set; } = null!;
        public virtual DbSet<DanhMucDichVuNumerology> DanhMucDichVuNumerologies { get; set; } = null!;
        public virtual DbSet<DanhMucDonViTinh> DanhMucDonViTinhs { get; set; } = null!;
        public virtual DbSet<DanhMucHinhThucNhanHang> DanhMucHinhThucNhanHangs { get; set; } = null!;
        public virtual DbSet<DanhMucHinhThucThanhToan> DanhMucHinhThucThanhToans { get; set; } = null!;
        public virtual DbSet<DanhMucLoaiChiPhi> DanhMucLoaiChiPhis { get; set; } = null!;
        public virtual DbSet<DanhMucLoaiGiamGium> DanhMucLoaiGiamGia { get; set; } = null!;
        public virtual DbSet<DanhMucLoaiMail> DanhMucLoaiMails { get; set; } = null!;
        public virtual DbSet<DanhMucLoaiSanPham> DanhMucLoaiSanPhams { get; set; } = null!;
        public virtual DbSet<DanhMucLoaiThe> DanhMucLoaiThes { get; set; } = null!;
        public virtual DbSet<DanhMucMauTinZaloOa> DanhMucMauTinZaloOas { get; set; } = null!;
        public virtual DbSet<DanhMucNhaVanChuyen> DanhMucNhaVanChuyens { get; set; } = null!;
        public virtual DbSet<DanhMucTinhTrangDonHang> DanhMucTinhTrangDonHangs { get; set; } = null!;
        public virtual DbSet<DanhMucVaiTro> DanhMucVaiTros { get; set; } = null!;
        public virtual DbSet<DoiTacThanhToanMomo> DoiTacThanhToanMomos { get; set; } = null!;
        public virtual DbSet<DoiTacThanhToanVnpay> DoiTacThanhToanVnpays { get; set; } = null!;
        public virtual DbSet<DonHang> DonHangs { get; set; } = null!;
        public virtual DbSet<DonHangDichVuCongThem> DonHangDichVuCongThems { get; set; } = null!;
        public virtual DbSet<DonHangSanPham> DonHangSanPhams { get; set; } = null!;
        public virtual DbSet<DonHangSanPhamHuy> DonHangSanPhamHuys { get; set; } = null!;
        public virtual DbSet<DonHangThanhToan> DonHangThanhToans { get; set; } = null!;
        public virtual DbSet<DonHangTinhTrangDonHang> DonHangTinhTrangDonHangs { get; set; } = null!;
        public virtual DbSet<GopY> Gopies { get; set; } = null!;
        public DbSet<GopY> GopY { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; } = null!;
        public virtual DbSet<KhachHangCheckIn> KhachHangCheckIns { get; set; } = null!;
        public virtual DbSet<KhachHangDiaChiNhanHang> KhachHangDiaChiNhanHangs { get; set; } = null!;
        public virtual DbSet<KhachHangLienQuan> KhachHangLienQuans { get; set; } = null!;
        public virtual DbSet<KhachHangNumerology> KhachHangNumerologies { get; set; } = null!;
        public virtual DbSet<LichSuGuiMail> LichSuGuiMails { get; set; } = null!;
        public virtual DbSet<LichSuNumerology> LichSuNumerologies { get; set; } = null!;
        public virtual DbSet<LogCapNhatKhachHang> LogCapNhatKhachHangs { get; set; } = null!;
        public virtual DbSet<LogGuiVanDon> LogGuiVanDons { get; set; } = null!;
        public virtual DbSet<LogSendZaloOa> LogSendZaloOas { get; set; } = null!;
        public virtual DbSet<MaGiamGium> MaGiamGia { get; set; } = null!;
        public virtual DbSet<MailMau> MailMaus { get; set; } = null!;
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; } = null!;
        public virtual DbSet<NguoiDungGioHang> NguoiDungGioHangs { get; set; } = null!;
        public virtual DbSet<SanPham> SanPhams { get; set; } = null!;
        public virtual DbSet<SanPhamFile> SanPhamFiles { get; set; } = null!;
        public virtual DbSet<SanPhamNhapXuat> SanPhamNhapXuats { get; set; } = null!;
        public virtual DbSet<SanPhamYeuThich> SanPhamYeuThiches { get; set; } = null!;
        public virtual DbSet<ThanhToanMomoLog> ThanhToanMomoLogs { get; set; } = null!;
        public virtual DbSet<ThanhToanVnpayLog> ThanhToanVnpayLogs { get; set; } = null!;
        public virtual DbSet<ThongSoZaloOa> ThongSoZaloOas { get; set; } = null!;
        public virtual DbSet<VaiTroChuyenMuc> VaiTroChuyenMucs { get; set; } = null!;
        public virtual DbSet<WebhookGhtk> WebhookGhtks { get; set; } = null!;
        public virtual DbSet<ZThongSoKetNoi> ZThongSoKetNois { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=112.78.2.50;Initial Catalog=phu76323_uat.ShowRoomMini;Persist Security Info=True;User ID=phu70569_uat.phuckhang;Password=phuckhang@2023");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("phu70569_uat.phuckhang");

            modelBuilder.Entity<BaiViet>(entity =>
            {
                entity.HasKey(e => e.IdbaiViet);

                entity.ToTable("BaiViet", "dbo");

                entity.Property(e => e.IdbaiViet)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDBaiViet");

                entity.Property(e => e.IdchuyenMuc).HasColumnName("IDChuyenMuc");

                entity.Property(e => e.IdnguoiDang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiDang");

                entity.Property(e => e.LienHe).HasMaxLength(500);

                entity.Property(e => e.NgayBatDau).HasColumnType("date");

                entity.Property(e => e.NgayDang).HasColumnType("datetime");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayKetThuc).HasColumnType("date");

                entity.Property(e => e.StickyStyle).IsUnicode(false);

                entity.Property(e => e.UrlhinhDaiDien)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URLHinhDaiDien");
            });

            modelBuilder.Entity<ChiPhi>(entity =>
            {
                entity.HasKey(e => e.IdchiPhi);

                entity.ToTable("ChiPhi", "dbo");

                entity.Property(e => e.IdchiPhi)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDChiPhi");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.IdloaiChiPhi)
                    .HasColumnName("IDLoaiChiPhi")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdnguoiNhap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiNhap");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayPhatSinh)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SoTien)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<CuaHang>(entity =>
            {
                entity.HasKey(e => e.IdcuaHang);

                entity.ToTable("CuaHang", "dbo");

                entity.HasIndex(e => e.MaCuaHang, "UQ_CuaHang_MaCuaHang")
                    .IsUnique();

                entity.Property(e => e.IdcuaHang)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDCuaHang");

                entity.Property(e => e.CapDoCuaHang).HasDefaultValueSql("((0))");

                entity.Property(e => e.DiaChiCuaHang).HasMaxLength(100);

                entity.Property(e => e.DiaChiWebCuaHang)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DienThoaiCuaHang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailCuaHang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdcuaHangCha)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDCuaHangCha")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaBang)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaCuaHang)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("La duy nhat");

                entity.Property(e => e.MaQuocGia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TenBang).HasMaxLength(50);

                entity.Property(e => e.TenCuaHang).HasMaxLength(50);

                entity.Property(e => e.TenNguoiDaiDienCuaHang).HasMaxLength(50);

                entity.Property(e => e.TenQuan).HasMaxLength(50);

                entity.Property(e => e.TenQuocGia).HasMaxLength(50);

                entity.Property(e => e.ThanhPho).HasMaxLength(500);

                entity.Property(e => e.Urllogo)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URLLogo");
            });

            modelBuilder.Entity<DanhMucBaoCao>(entity =>
            {
                entity.HasKey(e => e.IdbaoCao);

                entity.ToTable("DanhMucBaoCao", "dbo");

                entity.Property(e => e.IdbaoCao).HasColumnName("IDBaoCao");

                entity.Property(e => e.IsUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenBaoCao).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucChiTietDichVuCongThem>(entity =>
            {
                entity.HasKey(e => e.IdchiTietDichVuCongThem);

                entity.ToTable("DanhMucChiTietDichVuCongThem", "dbo");

                entity.Property(e => e.IdchiTietDichVuCongThem)
                    .ValueGeneratedNever()
                    .HasColumnName("IDChiTietDichVuCongThem");

                entity.Property(e => e.MaDichVuCongThem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenChiTietDichVuCongThem).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucChuyenMuc>(entity =>
            {
                entity.HasKey(e => e.IdchuyenMuc);

                entity.ToTable("DanhMucChuyenMuc", "dbo");

                entity.Property(e => e.IdchuyenMuc).HasColumnName("IDChuyenMuc");

                entity.Property(e => e.LoaiChuyenMuc)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaChuyenMuc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenChuyenMuc).HasMaxLength(50);

                entity.Property(e => e.Thuoc)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DanhMucCungMenh>(entity =>
            {
                entity.HasKey(e => e.IdAuto)
                    .HasName("PK__DanhMucC__4F5B47C51E91804F");

                entity.ToTable("DanhMucCungMenh", "dbo");

                entity.Property(e => e.IdAuto).HasColumnName("ID_Auto");

                entity.Property(e => e.Cung).HasMaxLength(10);

                entity.Property(e => e.CungMenh)
                    .HasMaxLength(50)
                    .HasColumnName("Cung_Menh");

                entity.Property(e => e.GioiTinh).HasColumnName("Gioi_Tinh");

                entity.Property(e => e.HuongTot1)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Tot_1");

                entity.Property(e => e.HuongTot2)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Tot_2");

                entity.Property(e => e.HuongTot3)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Tot_3");

                entity.Property(e => e.HuongTot4)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Tot_4");

                entity.Property(e => e.HuongXau1)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Xau_1");

                entity.Property(e => e.HuongXau2)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Xau_2");

                entity.Property(e => e.HuongXau3)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Xau_3");

                entity.Property(e => e.HuongXau4)
                    .HasMaxLength(50)
                    .HasColumnName("Huong_Xau_4");

                entity.Property(e => e.MauBanMenh)
                    .HasMaxLength(50)
                    .HasColumnName("Mau_Ban_Menh");

                entity.Property(e => e.MauTuongKhac)
                    .HasMaxLength(50)
                    .HasColumnName("Mau_Tuong_Khac");

                entity.Property(e => e.MauTuongSinh)
                    .HasMaxLength(50)
                    .HasColumnName("Mau_Tuong_Sinh");

                entity.Property(e => e.Menh).HasMaxLength(10);

                entity.Property(e => e.SoCungMenh).HasColumnName("So_Cung_Menh");
            });

            modelBuilder.Entity<DanhMucDichVuCongThem>(entity =>
            {
                entity.HasKey(e => e.IddichVuCongThem);

                entity.ToTable("DanhMucDichVuCongThem", "dbo");

                entity.Property(e => e.IddichVuCongThem).HasColumnName("IDDichVuCongThem");

                entity.Property(e => e.GiaCoDinh).HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaTien).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaDichVuCongThem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenDichVuCongThem).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucDichVuNumerology>(entity =>
            {
                entity.HasKey(e => e.MaGoiDichVu)
                    .HasName("PK__DanhMucD__D08A071A632DDC32");

                entity.ToTable("DanhMucDichVuNumerologies", "dbo");

                entity.Property(e => e.MaGoiDichVu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GiaTien).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NgaySuDung).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.TenGoiDichVu).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucDonViTinh>(entity =>
            {
                entity.HasKey(e => e.IddonViTinh);

                entity.ToTable("DanhMucDonViTinh", "dbo");

                entity.Property(e => e.IddonViTinh).HasColumnName("IDDonViTinh");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenDonViTinh).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucHinhThucNhanHang>(entity =>
            {
                entity.HasKey(e => e.IdhinhThucNhanHang);

                entity.ToTable("DanhMucHinhThucNhanHang", "dbo");

                entity.Property(e => e.IdhinhThucNhanHang).HasColumnName("IDHinhThucNhanHang");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SuDungCongCong).HasDefaultValueSql("((0))");

                entity.Property(e => e.SvgHinhThuc)
                    .IsUnicode(false)
                    .HasColumnName("svgHinhThuc");

                entity.Property(e => e.TenHinhThucNhanHang).HasMaxLength(20);
            });

            modelBuilder.Entity<DanhMucHinhThucThanhToan>(entity =>
            {
                entity.HasKey(e => e.IdhinhThucThanhToan);

                entity.ToTable("DanhMucHinhThucThanhToan", "dbo");

                entity.Property(e => e.IdhinhThucThanhToan).HasColumnName("IDHinhThucThanhToan");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SuDungCongCong).HasDefaultValueSql("((0))");

                entity.Property(e => e.TenHinhThucThanhToan).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucLoaiChiPhi>(entity =>
            {
                entity.HasKey(e => e.IdloaiChiPhi);

                entity.ToTable("DanhMucLoaiChiPhi", "dbo");

                entity.Property(e => e.IdloaiChiPhi)
                    .ValueGeneratedNever()
                    .HasColumnName("IDLoaiChiPhi");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenLoaiChiPhi).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucLoaiGiamGium>(entity =>
            {
                entity.HasKey(e => e.MaLoaiGiamGia)
                    .HasName("PK_DanhMucLoaiGiamGia_1");

                entity.ToTable("DanhMucLoaiGiamGia", "dbo");

                entity.Property(e => e.MaLoaiGiamGia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenLoaiGiamGia).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucLoaiMail>(entity =>
            {
                entity.HasKey(e => e.MaLoaiMail);

                entity.ToTable("DanhMucLoaiMail", "dbo");

                entity.Property(e => e.MaLoaiMail)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenLoaiMail).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucLoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.IdloaiSanPham);

                entity.ToTable("DanhMucLoaiSanPham", "dbo");

                entity.Property(e => e.IdloaiSanPham).HasColumnName("IDLoaiSanPham");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenLoaiSanPham).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucLoaiThe>(entity =>
            {
                entity.HasKey(e => e.IdloaiThe);

                entity.ToTable("DanhMucLoaiThe", "dbo");

                entity.Property(e => e.IdloaiThe)
                    .ValueGeneratedNever()
                    .HasColumnName("IDLoaiThe");

                entity.Property(e => e.MaDauThe)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MaLoaiThe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaMau)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TenLoaiThe).HasMaxLength(50);
            });

            modelBuilder.Entity<DanhMucMauTinZaloOa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DanhMucMauTinZaloOA", "dbo");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("id");

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("template_id");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(500)
                    .HasColumnName("template_name");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DanhMucNhaVanChuyen>(entity =>
            {
                entity.ToTable("DanhMucNhaVanChuyen", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContentType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Content-Type");

                entity.Property(e => e.GiaToiThieuLienTinh)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GiaToiThieuNoiTinh)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsEdit).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsUse).HasDefaultValueSql("((1))");

                entity.Property(e => e.MaBangHoTro)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaNhaVanChuyen)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ShopId)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ShopID");

                entity.Property(e => e.SoThuTu).HasDefaultValueSql("((1))");

                entity.Property(e => e.Token)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TokenIn)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeUrl)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("URL");
            });

            modelBuilder.Entity<DanhMucTinhTrangDonHang>(entity =>
            {
                entity.HasKey(e => e.IdtinhTrangDonHang);

                entity.ToTable("DanhMucTinhTrangDonHang", "dbo");

                entity.HasIndex(e => e.Code, "unique_code")
                    .IsUnique();

                entity.Property(e => e.IdtinhTrangDonHang)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("IDTinhTrangDonHang");

                entity.Property(e => e.Code)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KhachHangDuocHuy).HasDefaultValueSql("((0))");

                entity.Property(e => e.LoaiTrangThai).HasDefaultValueSql("((0))");

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoiBoDuocHuy).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DanhMucVaiTro>(entity =>
            {
                entity.HasKey(e => e.IdvaiTro);

                entity.ToTable("DanhMucVaiTro", "dbo");

                entity.Property(e => e.IdvaiTro)
                    .ValueGeneratedNever()
                    .HasColumnName("IDVaiTro");

                entity.Property(e => e.CapDoQuanLy).HasDefaultValueSql("((1))");

                entity.Property(e => e.GhiChu).HasMaxLength(100);

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DoiTacThanhToanMomo>(entity =>
            {
                entity.HasKey(e => e.MaDoiTac)
                    .HasName("PK_IdDoiTacMomo");

                entity.ToTable("DoiTacThanhToanMomo", "dbo");

                entity.Property(e => e.MaDoiTac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccessKey)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IpnUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ipn_Url");

                entity.Property(e => e.MomoUrl)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Momo_Url");

                entity.Property(e => e.PartnerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerName).HasMaxLength(255);

                entity.Property(e => e.RedirectUrl)
                    .HasMaxLength(255)
                    .HasColumnName("Redirect_Url");

                entity.Property(e => e.SecretKey)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TenDoiTac).HasMaxLength(255);
            });

            modelBuilder.Entity<DoiTacThanhToanVnpay>(entity =>
            {
                entity.HasKey(e => e.MaDoiTac)
                    .HasName("PK_IdDoiTac");

                entity.ToTable("DoiTacThanhToanVnpay", "dbo");

                entity.Property(e => e.MaDoiTac).HasMaxLength(50);

                entity.Property(e => e.HashSecret).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ReturnUrl)
                    .HasMaxLength(255)
                    .HasColumnName("Return_Url");

                entity.Property(e => e.TenDoiTac).HasMaxLength(255);

                entity.Property(e => e.TmnCode).HasMaxLength(20);

                entity.Property(e => e.Version).HasMaxLength(50);

                entity.Property(e => e.VnpayUrl)
                    .HasMaxLength(255)
                    .HasColumnName("Vnpay_Url");
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.HasKey(e => e.IddonHang);

                entity.ToTable("DonHang", "dbo");

                entity.Property(e => e.IddonHang)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDDonHang");

                entity.Property(e => e.DiaChiNhan).HasMaxLength(100);

                entity.Property(e => e.DienThoaiKhachHang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DienThoaiNguoiNhan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("Dien thoai nguoi lien lac nhan hang");

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.HoTenNguoiNhan).HasMaxLength(50);

                entity.Property(e => e.IdkhachHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDKhachHang")
                    .HasComment("= IDNguoiDung neu la khach hang cu");

                entity.Property(e => e.IdnguoiCapNhat)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiCapNhat")
                    .HasComment("= IDNguoiDung neu co thay doi thong tin don hang");

                entity.Property(e => e.IdnguoiTaoDon)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiTaoDon")
                    .HasComment("= IDNguoiDung la nhan vien cua hang");

                entity.Property(e => e.IdtrangThaiHienTai).HasColumnName("IDTrangThaiHienTai");

                entity.Property(e => e.LoaiDonHang).HasMaxLength(50);

                entity.Property(e => e.MaBangNhan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaDonChung)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaGiamGia)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaQuocGiaNhan)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

                entity.Property(e => e.NgayDatHang).HasColumnType("datetime");

                entity.Property(e => e.NgayGiaoHangDuKien).HasColumnType("datetime");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PhiShip)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoTienGiam)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SoTienGiamTrenSanPham)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TenBangNhan).HasMaxLength(50);

                entity.Property(e => e.TenQuanNhan).HasMaxLength(50);

                entity.Property(e => e.TenQuocGiaNhan).HasMaxLength(50);

                entity.Property(e => e.ThanhPhoNhan).HasMaxLength(200);

                entity.Property(e => e.TongSoLuong).HasDefaultValueSql("((0))");

                entity.Property(e => e.TongSoTien)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TongSoTienThanhToan)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TongTienDichVuCongThem)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DonHangDichVuCongThem>(entity =>
            {
                entity.HasKey(e => new { e.IddonHang, e.IddichVuCongThem });

                entity.ToTable("DonHang_DichVuCongThem", "dbo");

                entity.Property(e => e.IddonHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDDonHang");

                entity.Property(e => e.IddichVuCongThem).HasColumnName("IDDichVuCongThem");

                entity.Property(e => e.IdchiTietDichVuCongThem)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IDChiTietDichVuCongThem");
            });

            modelBuilder.Entity<DonHangSanPham>(entity =>
            {
                entity.HasKey(e => new { e.IddonHang, e.IdsanPham });

                entity.ToTable("DonHang_SanPham", "dbo");

                entity.Property(e => e.IddonHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDDonHang");

                entity.Property(e => e.IdsanPham)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.IdnguoiXacNhan)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiXacNhan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NgayBatDauBaoHanh).HasColumnType("date");

                entity.Property(e => e.NgayHetHanBaoHanh).HasColumnType("date");

                entity.Property(e => e.ThanhTien).HasColumnType("money");

                entity.Property(e => e.TongDonGia).HasColumnType("money");
            });

            modelBuilder.Entity<DonHangSanPhamHuy>(entity =>
            {
                entity.HasKey(e => new { e.IddonHang, e.IdsanPham });

                entity.ToTable("DonHang_SanPhamHuy", "dbo");

                entity.Property(e => e.IddonHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDDonHang");

                entity.Property(e => e.IdsanPham)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.IdnguoiXacNhan)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiXacNhan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NgayBatDauBaoHanh).HasColumnType("date");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayHetHanBaoHanh).HasColumnType("date");

                entity.Property(e => e.ThanhTien).HasColumnType("money");
            });

            modelBuilder.Entity<DonHangThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaDonHang);

                entity.ToTable("DonHang_ThanhToan", "dbo");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChuKy)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MaDoiTac)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaThamChieu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaThanhToan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayTrangThai).HasColumnType("datetime");

                entity.Property(e => e.TongThanhToan).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TrangThaiThanhToan)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DonHangTinhTrangDonHang>(entity =>
            {
                entity.HasKey(e => new { e.IddonHang, e.IdtrangThaiDonHang });

                entity.ToTable("DonHang_TinhTrangDonHang", "dbo");

                entity.Property(e => e.IddonHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDDonHang");

                entity.Property(e => e.IdtrangThaiDonHang).HasColumnName("IDTrangThaiDonHang");

                entity.Property(e => e.GhiChu).HasMaxLength(250);

                entity.Property(e => e.IdnguoiXuLy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiXuLy");

                entity.Property(e => e.NgayXuLy)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GopY>(entity =>
            {
                entity.HasKey(e => e.IdgopY);

                entity.ToTable("GopY", "dbo");

                entity.Property(e => e.IdgopY)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDGopY");

                entity.Property(e => e.DienThoai).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.GopY1).HasColumnName("GopY");

                entity.Property(e => e.HoTen).HasMaxLength(200);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.IdkhachHang);

                entity.ToTable("KhachHang", "dbo");

                entity.HasIndex(e => e.DienThoai, "UQ_KhachHang_DienThoai")
                    .IsUnique();

                entity.Property(e => e.IdkhachHang)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDKhachHang");

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.DanhXung).HasMaxLength(20);

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GhiNo).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ho).HasMaxLength(50);

                entity.Property(e => e.IdloaiThe)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDLoaiThe")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Isuse).HasColumnName("isuse");

                entity.Property(e => e.MaBang)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaQuocGia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaThe)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaySinhNhat).HasColumnType("date");

                entity.Property(e => e.NhanEmail).HasDefaultValueSql("((1))");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.TenBang).HasMaxLength(50);

                entity.Property(e => e.TenQuan).HasMaxLength(50);

                entity.Property(e => e.TenQuocGia).HasMaxLength(50);

                entity.Property(e => e.ThanhPho).HasMaxLength(200);
            });

            modelBuilder.Entity<KhachHangCheckIn>(entity =>
            {
                entity.ToTable("KhachHang_CheckIn", "dbo");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.Ho).HasMaxLength(50);

                entity.Property(e => e.Idgoi).HasColumnName("IDGoi");

                entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.NgayXemDuKien).HasColumnType("datetime");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.TenGoi).HasMaxLength(100);

                entity.Property(e => e.TraLoiKhaoSat).IsUnicode(false);

                entity.Property(e => e.UserNguoiXacNhan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.XacNhan).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<KhachHangDiaChiNhanHang>(entity =>
            {
                entity.HasKey(e => e.IddiaChiNhanHang);

                entity.ToTable("KhachHang_DiaChiNhanHang", "dbo");

                entity.Property(e => e.IddiaChiNhanHang)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDDiaChiNhanHang");

                entity.Property(e => e.DiaChi).HasMaxLength(100);

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ho).HasMaxLength(50);

                entity.Property(e => e.IdkhachHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDKhachHang");

                entity.Property(e => e.MaBang)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaQuocGia)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MacDinh).HasDefaultValueSql("((0))");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.TenBang).HasMaxLength(50);

                entity.Property(e => e.TenQuan).HasMaxLength(50);

                entity.Property(e => e.TenQuocGia).HasMaxLength(50);

                entity.Property(e => e.ThanhPho).HasMaxLength(200);
            });

            modelBuilder.Entity<KhachHangLienQuan>(entity =>
            {
                entity.HasKey(e => e.IdkhachHangLienQuan)
                    .HasName("PK__KhachHan__7E4091FEADEACC79");

                entity.ToTable("KhachHang_LienQuan", "dbo");

                entity.Property(e => e.IdkhachHangLienQuan)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("IDKhachHangLienQuan");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HoTen).HasMaxLength(255);

                entity.Property(e => e.IdkhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.MoiQuanHe).HasMaxLength(50);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaySinh).HasColumnType("date");
            });

            modelBuilder.Entity<KhachHangNumerology>(entity =>
            {
                entity.HasKey(e => e.IdnguoiDung)
                    .HasName("PK__KhachHan__FCD7DB095DF0C310");

                entity.ToTable("KhachHang_Numerologies", "dbo");

                entity.Property(e => e.IdnguoiDung)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiDung");

                entity.Property(e => e.IdnguoiCapQuyen)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiCapQuyen");

                entity.Property(e => e.MaGoiDichVu)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayBatDau).HasColumnType("datetime");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgayHetHan).HasColumnType("datetime");
            });

            modelBuilder.Entity<LichSuGuiMail>(entity =>
            {
                entity.HasKey(e => e.IdlichSuGuiMail);

                entity.ToTable("LichSuGuiMail", "dbo");

                entity.Property(e => e.IdlichSuGuiMail)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDLichSuGuiMail");

                entity.Property(e => e.DiaChiMailNguoiNhan)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdkhachHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDKhachHang")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdnguoiXuLy)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiXuLy")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoaiMail)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaySinhNhat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TieuDe).HasMaxLength(250);
            });

            modelBuilder.Entity<LichSuNumerology>(entity =>
            {
                entity.ToTable("LichSu_Numerologies", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CanBang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Chan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DamMe)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DuongDoi)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.GioiTinh).HasMaxLength(10);

                entity.Property(e => e.HoTen).HasMaxLength(255);

                entity.Property(e => e.HoTenGoc).HasMaxLength(250);

                entity.Property(e => e.IdnguoiTao).HasColumnName("IDNguoiTao");

                entity.Property(e => e.IgenCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IGenCode");

                entity.Property(e => e.KetNoiDuongDoiSuMenh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.KetNoiLinhHonNhanCach)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinhHon)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nam)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaySinh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NhanCach)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SinhNhat).HasColumnType("date");

                entity.Property(e => e.SoCungMenh)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SuMenh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SucManhTiemThuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ThachThuc)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Thang)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Thieu)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TruongThanh)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TuDuyLyTri)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogCapNhatKhachHang>(entity =>
            {
                entity.ToTable("Log_CapNhatKhachHang", "dbo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdkhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.IdnguoiThucHien).HasColumnName("IDNguoiThucHien");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaySinhCu).HasColumnType("date");

                entity.Property(e => e.NgaySinhMoi).HasColumnType("date");
            });

            modelBuilder.Entity<LogGuiVanDon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Log_GuiVanDon", "dbo");

                entity.Property(e => e.DiaChiCap4).HasMaxLength(250);

                entity.Property(e => e.DiaChiCuaHang).HasMaxLength(255);

                entity.Property(e => e.DiaChiNhan).HasMaxLength(255);

                entity.Property(e => e.DienThoaiGui).HasMaxLength(50);

                entity.Property(e => e.DienThoaiNguoiNhan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GhiChu).HasMaxLength(500);

                entity.Property(e => e.HoTenNguoiNhan).HasMaxLength(255);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.KhaiGia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MaDonHang)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaInNhan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaVanDon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NgayGiao).HasColumnType("datetime");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NhaVanChuyen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenCuaHang).HasMaxLength(255);

                entity.Property(e => e.TenHuyenGui).HasMaxLength(50);

                entity.Property(e => e.TenHuyenNhan).HasMaxLength(50);

                entity.Property(e => e.TenTinhGui).HasMaxLength(50);

                entity.Property(e => e.TenTinhNhan).HasMaxLength(50);

                entity.Property(e => e.TenXaGui).HasMaxLength(250);

                entity.Property(e => e.TenXaNhan).HasMaxLength(250);

                entity.Property(e => e.ThuHo).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TongKhoiLuong).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.TongPhiShip).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<LogSendZaloOa>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK__Log_Send__9E2397E0F7646702");

                entity.ToTable("Log_SendZaloOA", "dbo");

                entity.Property(e => e.LogId).HasColumnName("log_id");

                entity.Property(e => e.CreatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("creator_id");

                entity.Property(e => e.Loai)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("loai");

                entity.Property(e => e.LogTime)
                    .HasColumnType("datetime")
                    .HasColumnName("log_time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("order_code");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Response).HasColumnName("response");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("status_code");

                entity.Property(e => e.TemplateId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("template_id");
            });

            modelBuilder.Entity<MaGiamGium>(entity =>
            {
                entity.HasKey(e => e.MaGiamGia);

                entity.ToTable("MaGiamGia", "dbo");

                entity.Property(e => e.MaGiamGia)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DenNgay).HasColumnType("date");

                entity.Property(e => e.LoaiGiamGia).HasMaxLength(20);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NoiBo).HasDefaultValueSql("((1))");

                entity.Property(e => e.SoTienGiamGia).HasDefaultValueSql("((0))");

                entity.Property(e => e.TuNgay)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TyLeGiamGia).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<MailMau>(entity =>
            {
                entity.HasKey(e => e.IdmailMau);

                entity.ToTable("MailMau", "dbo");

                entity.Property(e => e.IdmailMau)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDMailMau");

                entity.Property(e => e.IdnguoiThem)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiThem")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LoaiMail)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MoTa).HasMaxLength(50);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TieuDe).HasMaxLength(250);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.IdnguoiDung);

                entity.ToTable("NguoiDung", "dbo");

                entity.HasIndex(e => e.DienThoai, "UQ_NguoiDung_DienThoai")
                    .IsUnique();

                entity.Property(e => e.IdnguoiDung)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDNguoiDung");

                entity.Property(e => e.ChuDe).HasMaxLength(255);

                entity.Property(e => e.Cmnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CMND");

                entity.Property(e => e.DienThoai)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ho).HasMaxLength(50);

                entity.Property(e => e.IdcuaHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDCuaHang");

                entity.Property(e => e.IdkhachHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDKhachHang");

                entity.Property(e => e.IdvaiTro).HasColumnName("IDVaiTro");

                entity.Property(e => e.IsLock).HasDefaultValueSql("((0))");

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NgaySinhNhat).HasColumnType("date");

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ten).HasMaxLength(50);

                entity.Property(e => e.Token)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NguoiDungGioHang>(entity =>
            {
                entity.HasKey(e => new { e.IdnguoiDung, e.IdsanPham })
                    .HasName("PK_NguoiDung_GioHang_1");

                entity.ToTable("NguoiDung_GioHang", "dbo");

                entity.Property(e => e.IdnguoiDung)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiDung");

                entity.Property(e => e.IdsanPham)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.IdsanPham);

                entity.ToTable("SanPham", "dbo");

                entity.Property(e => e.IdsanPham)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.Cao).HasComment("milimet");

                entity.Property(e => e.Dai).HasComment("milimet");

                entity.Property(e => e.GiaBan).HasColumnType("money");

                entity.Property(e => e.GiaSauGiam).HasColumnType("money");

                entity.Property(e => e.GiaTriTienTe)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdcuaHang)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDCuaHang")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IddonViTinh).HasColumnName("IDDonViTinh");

                entity.Property(e => e.IdnguoiNhap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiNhap");

                entity.Property(e => e.KhoiLuong).HasComment("gram");

                entity.Property(e => e.MaSanPham)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NgayHetHan)
                    .HasColumnType("date")
                    .HasComment("Ngày kết thúc bảo hành, Ngày hết hạn sản phẩm");

                entity.Property(e => e.NgaySanXuat)
                    .HasColumnType("date")
                    .HasComment("Ngày bắt đầu bảo hành, Ngày sản xuất");

                entity.Property(e => e.NgayTaoDauTien)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rong).HasComment("milimet");

                entity.Property(e => e.SanPhamTrucTuyen).HasDefaultValueSql("((1))");

                entity.Property(e => e.TenSanPham).HasMaxLength(100);

                entity.Property(e => e.ThoiGianBaoHanh).HasComment("tính theo tháng");

                entity.Property(e => e.TriGia).HasColumnType("money");
            });

            modelBuilder.Entity<SanPhamFile>(entity =>
            {
                entity.HasKey(e => new { e.IdsanPham, e.TenTapTin });

                entity.ToTable("SanPham_File", "dbo");

                entity.Property(e => e.IdsanPham)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.TenTapTin).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UrlhinhAnh)
                    .HasMaxLength(200)
                    .HasColumnName("URLHinhAnh");
            });

            modelBuilder.Entity<SanPhamNhapXuat>(entity =>
            {
                entity.ToTable("SanPham_NhapXuat", "dbo");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdnguoiNhap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiNhap");

                entity.Property(e => e.IdsanPham)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.Loai)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0: Xuất; 1: Nhập");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SoLuong).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SanPhamYeuThich>(entity =>
            {
                entity.ToTable("SanPham_YeuThich", "dbo");

                entity.Property(e => e.Id)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IdnguoiNhap)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDNguoiNhap");

                entity.Property(e => e.IdsanPham)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDSanPham");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.YeuThich)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0: Xuất; 1: Nhập");
            });

            modelBuilder.Entity<ThanhToanMomoLog>(entity =>
            {
                entity.ToTable("ThanhToanMomo_Log", "dbo");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("amount");

                entity.Property(e => e.ExtraData)
                    .HasMaxLength(255)
                    .HasColumnName("extraData");

                entity.Property(e => e.Message)
                    .HasMaxLength(255)
                    .HasColumnName("message");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orderId");

                entity.Property(e => e.OrderInfo)
                    .HasMaxLength(255)
                    .HasColumnName("orderInfo");

                entity.Property(e => e.OrderType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("orderType");

                entity.Property(e => e.PartnerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("partnerCode");

                entity.Property(e => e.PayType)
                    .HasMaxLength(50)
                    .HasColumnName("payType");

                entity.Property(e => e.RequestId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("requestId");

                entity.Property(e => e.ResponseTime).HasColumnName("responseTime");

                entity.Property(e => e.ResultCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("resultCode");

                entity.Property(e => e.Signature)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("signature");

                entity.Property(e => e.TransId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transId");
            });

            modelBuilder.Entity<ThanhToanVnpayLog>(entity =>
            {
                entity.ToTable("ThanhToanVnpay_Log", "dbo");

                entity.Property(e => e.IpAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ipAddress");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("update_Time")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VnpAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("vnp_Amount");

                entity.Property(e => e.VnpBankCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vnp_BankCode");

                entity.Property(e => e.VnpBankTranNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vnp_BankTranNo");

                entity.Property(e => e.VnpCardType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vnp_CardType");

                entity.Property(e => e.VnpOrderInfo)
                    .HasMaxLength(255)
                    .HasColumnName("vnp_OrderInfo");

                entity.Property(e => e.VnpPayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("vnp_PayDate");

                entity.Property(e => e.VnpResponseCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("vnp_ResponseCode");

                entity.Property(e => e.VnpSecureHash)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("vnp_SecureHash");

                entity.Property(e => e.VnpTmnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vnp_TmnCode");

                entity.Property(e => e.VnpTransactionNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vnp_TransactionNo");

                entity.Property(e => e.VnpTransactionStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("vnp_TransactionStatus");

                entity.Property(e => e.VnpTxnRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vnp_TxnRef");
            });

            modelBuilder.Entity<ThongSoZaloOa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ThongSoZaloOA", "dbo");

                entity.Property(e => e.AccessToken)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("access_token");

                entity.Property(e => e.AppId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("app_id");

                entity.Property(e => e.ExpiresToken)
                    .HasColumnType("datetime")
                    .HasColumnName("expires_token");

                entity.Property(e => e.RefreshToken)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("refresh_token");

                entity.Property(e => e.SecretKey)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("secret_key");
            });

            modelBuilder.Entity<VaiTroChuyenMuc>(entity =>
            {
                entity.HasKey(e => new { e.IdvaiTro, e.IdchuyenMuc })
                    .HasName("PK_VaiTro_ChuyenMuc");

                entity.ToTable("_VaiTro_ChuyenMuc", "dbo");

                entity.Property(e => e.IdvaiTro)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDVaiTro");

                entity.Property(e => e.IdchuyenMuc)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("IDChuyenMuc");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<WebhookGhtk>(entity =>
            {
                entity.ToTable("WebhookGHTK", "dbo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActionTime)
                    .HasColumnType("datetime")
                    .HasColumnName("action_time");

                entity.Property(e => e.Fee).HasColumnName("fee");

                entity.Property(e => e.LabelId)
                    .HasMaxLength(255)
                    .HasColumnName("label_id");

                entity.Property(e => e.NgayHeThong)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PartnerId)
                    .HasMaxLength(255)
                    .HasColumnName("partner_id");

                entity.Property(e => e.Reason)
                    .HasMaxLength(255)
                    .HasColumnName("reason");

                entity.Property(e => e.ReasonCode)
                    .HasMaxLength(255)
                    .HasColumnName("reason_code");

                entity.Property(e => e.ReturnPartPackage).HasColumnName("return_part_package");

                entity.Property(e => e.StatusId).HasColumnName("status_id");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<ZThongSoKetNoi>(entity =>
            {
                entity.HasKey(e => e.MaThongSo);

                entity.ToTable("zThongSoKetNoi", "dbo");

                entity.Property(e => e.MaThongSo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Auth)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MaKetNoi).HasMaxLength(500);

                entity.Property(e => e.UserHost)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
