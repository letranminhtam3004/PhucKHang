﻿using System.ComponentModel.DataAnnotations;

namespace PhucKhang.Entities
{
    public class DonHang_SanPham
    {
        [Key]
        public decimal IDDonHang { get; set; }
        public decimal IDSanPham { get; set; }
        public short SoLuong { get; set; }
        public decimal TongDonGia { get; set; }
        public decimal ThanhTien { get; set; }
        public DateTime NgayBatDauBaoHanh { get; set; }
        public DateTime NgayHetHanBaoHanh { get; set; }
        public decimal IDNguoiXacNhan { get; set; }
    }
}
