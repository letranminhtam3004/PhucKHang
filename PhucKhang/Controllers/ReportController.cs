using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhucKhang.Entities;
using System.Data.Entity.SqlServer;

namespace PhucKhang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ReportController : ControllerBase
    {
        private readonly MyDbContext _context;

        public ReportController(MyDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetDonHangs()
        {
            try
            {
                var donHangs = await _context.CuaHangs.ToListAsync();
                return Ok(donHangs);

            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }


        [HttpPost]
        public ActionResult<BaoCaoTongDoanhThu> GetBaoCaoTongDoanhThu(string tungay, string denngay, string listidcuahang = null)
        {
            if (listidcuahang == "" || listidcuahang == null || listidcuahang == "all")
            {
                // Chuyển đổi chuỗi ngày thành kiểu DateTime
                DateTime fromDate, toDate;
                if (!DateTime.TryParse(tungay, out fromDate) || !DateTime.TryParse(denngay, out toDate))
                {
                    return BadRequest("Invalid date format.");
                }

                var result = (from b in _context.DonHangs
                              join c in _context.DonHang_SanPhams on b.IDDonHang equals c.IDDonHang
                              join d in _context.SanPhams on c.IDSanPham equals d.IDSanPham
                              where b.NgayDatHang >= fromDate && b.NgayDatHang <= toDate
                              group new { b, c } by new { d.IDCuaHang, b.HinhThucThanhToan, Thang = b.NgayDatHang.Month } into g
                              select new BaoCaoTongDoanhThu
                              {
                                  SoLuong1 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 1).Sum(x => x.c.SoLuong),
                                  //SoLuong1 = g.Where(x => x.c != null && x.Thang == 1).Sum(x => x.c.SoLuong),
                                  SoLuong2 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 1).Sum(x => x.c.SoLuong),
                                  SoLuong12 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 12).Sum(x => x.c.SoLuong),
                                  SoLuong3 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 3).Sum(x => x.c.SoLuong),
                                  SoLuong4 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 4).Sum(x => x.c.SoLuong),
                                  SoLuong5 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 5).Sum(x => x.c.SoLuong),
                                  SoLuong6 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 6).Sum(x => x.c.SoLuong),
                                  SoLuong7 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 7).Sum(x => x.c.SoLuong),
                                  SoLuong8 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 8).Sum(x => x.c.SoLuong),
                                  SoLuong9 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 9).Sum(x => x.c.SoLuong),
                                  SoLuong10 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 10).Sum(x => x.c.SoLuong),
                                  SoLuong11 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 11).Sum(x => x.c.SoLuong),



                                  DoanhThu1 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 1).Sum(x => x.c.ThanhTien),
                                  DoanhThu2 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 2).Sum(x => x.c.ThanhTien),
                                  DoanhThu3 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 3).Sum(x => x.c.ThanhTien),
                                  DoanhThu4 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 4).Sum(x => x.c.ThanhTien),
                                  DoanhThu5 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 5).Sum(x => x.c.ThanhTien),
                                  DoanhThu6 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 6).Sum(x => x.c.ThanhTien),
                                  DoanhThu7 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 7).Sum(x => x.c.ThanhTien),
                                  DoanhThu8 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 8).Sum(x => x.c.ThanhTien),
                                  DoanhThu9 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 9).Sum(x => x.c.ThanhTien),
                                  DoanhThu10 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 10).Sum(x => x.c.ThanhTien),
                                  DoanhThu11 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 11).Sum(x => x.c.ThanhTien),
                                  DoanhThu12 = g.Where(x => x.c != null && x.b.NgayDatHang.Month == 12).Sum(x => x.c.ThanhTien),


                                  //DoanhThu2 = g.Where(x => x.c != null && x.Thang == 2).Sum(x => x.c.ThanhTien),
                                  //DoanhThu3 = g.Where(x => x.c != null && x.Thang == 3).Sum(x => x.c.ThanhTien),
                                  //DoanhThu4 = g.Where(x => x.c != null && x.Thang == 4).Sum(x => x.c.ThanhTien),
                                  //DoanhThu5 = g.Where(x => x.c != null && x.Thang == 5).Sum(x => x.c.ThanhTien),
                                  //DoanhThu6 = g.Where(x => x.c != null && x.Thang == 6).Sum(x => x.c.ThanhTien),
                                  //DoanhThu7 = g.Where(x => x.c != null && x.Thang == 7).Sum(x => x.c.ThanhTien),
                                  //DoanhThu8 = g.Where(x => x.c != null && x.Thang == 8).Sum(x => x.c.ThanhTien),
                                  //DoanhThu9 = g.Where(x => x.c != null && x.Thang == 9).Sum(x => x.c.ThanhTien),
                                  //DoanhThu10 = g.Where(x => x.c != null && x.Thang == 10).Sum(x => x.c.ThanhTien),
                                  //DoanhThu11 = g.Where(x => x.c != null && x.Thang == 11).Sum(x => x.c.ThanhTien),
                                  //DoanhThu12 = g.Where(x => x.c != null && x.Thang == 12).Sum(x => x.c.ThanhTien)
                              }).FirstOrDefault();

                return result;
            }
            else
            {
                return BadRequest("Eror");
            }
        }

        //public BaoCaoTongDoanhThu GetBaoCaoTongDoanhThuTheoNam(string tungay, string denngay, string listidcuahang)
        //{

        //    var query = from b in donHangList
        //                where b.NgayDatHang >= DateTime.Parse(tungay) && b.NgayDatHang <= DateTime.Parse(denngay)
        //                && (listidcuahang == null || listidcuahang == "all" || b.DonHang_SanPham.Any(c => c.SanPham.IDCuaHang.ToString() == listidcuahang))
        //                group new { b, c = b.DonHang_SanPham } by new { b.HinhThucThanhToan, Thang = b.NgayDatHang.Value.Month } into g
        //                select new BaoCaoTongDoanhThu
        //                {
        //                    SoLuong1 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                    SoLuong2 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                    SoLuong3 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                    SoLuong4 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                    SoLuong5 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                    SoLuong6 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                    SoLuong7 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                    SoLuong8 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                        SoLuong9 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                        SoLuong10 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                        SoLuong11 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                        SoLuong12 = g.Sum(x => x.c.Sum(y => y.SoLuong)),
        //                        DoanhThu1 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu2 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu3 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu4 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu5 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu6 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu7 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu8 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu9 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu10 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu11 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                        DoanhThu12 = g.Sum(x => x.c.Sum(y => y.ThanhTien)),
        //                    };

        //        return query.FirstOrDefault();
        //    }
        //}
    }
}
