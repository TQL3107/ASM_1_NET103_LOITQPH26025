using System;
using System.Collections.Generic;

namespace ASM_1_NET103_LOITQPH26025.A.DAL.Models
{
    public partial class QuanLyDiemSinhVien
    {
        public string MaSv { get; set; } = null!;
        public string? Ten { get; set; }
        public int? TiengAnh { get; set; }
        public int? TinHoc { get; set; }
        public int? Gdtc { get; set; }
        public int? DiemTb { get; set; }
    }
}
