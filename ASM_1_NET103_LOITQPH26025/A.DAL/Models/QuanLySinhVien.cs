using System;
using System.Collections.Generic;

namespace ASM_1_NET103_LOITQPH26025.A.DAL.Models
{
    public partial class QuanLySinhVien
    {
        public string MaSv { get; set; } = null!;
        public string? Ten { get; set; }
        public string? Email { get; set; }
        public string? Sdt { get; set; }
        public int? GioiTinh { get; set; }
        public byte[]? Anh { get; set; }
        public string? DiaChi { get; set; }
    }
}
