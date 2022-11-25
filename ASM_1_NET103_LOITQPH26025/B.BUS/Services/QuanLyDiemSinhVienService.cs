using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using ASM_1_NET103_LOITQPH26025.A.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1_NET103_LOITQPH26025.B.BUS.Services
{
    internal class QuanLyDiemSinhVienService
    {
        QuanLyDiemSinhVienRepository ql = new QuanLyDiemSinhVienRepository();
        public List<QuanLyDiemSinhVien> ShowAll()
        {
            return ql.GetAll();
        }
        public string Delete(string ma)
        {
            if (ql.Delete(ma)) return "Xóa điểm thành công";
            else return "Xóa điểm thất bại";
        }
        public string Create(string ma, string ten, int tienganh, int tinhoc, int tc, int dtb)
        {
            if (ql.Add(ma, ten, tienganh, tinhoc, tc, dtb)) return "Thêm mới thành công";
            else return "Thêm mới thất bại";
        }
        public string Update(string ma, string ten, int tienganh, int tinhoc, int tc, int dtb)
        {
            if (ql.Edit(ma, ten, tienganh, tinhoc, tc, dtb)) return "Update thành công";
            else return "Update thất bại";
        }
    }
}
