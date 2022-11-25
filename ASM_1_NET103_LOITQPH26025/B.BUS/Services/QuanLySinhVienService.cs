using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using ASM_1_NET103_LOITQPH26025.A.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ASM_1_NET103_LOITQPH26025.B.BUS.Services
{
    internal class QuanLySinhVienService
    {
        QuanLySinhVienRepository qlsv = new QuanLySinhVienRepository();
        public List<QuanLySinhVien> ShowAll()
        {
            return qlsv.GetAll();
        }
        public string Delete(string ma)
        {
            if (qlsv.Delete(ma)) return "Xóa điểm thành công";
            else return "Xóa điểm thất bại";
        }
        public string Create(string ma, string ten, string email, string sdt, int gioitinh, byte anh, string diachi)
        {
            if (qlsv.Add(ma, ten, email, sdt,gioitinh,anh,diachi)) return "Thêm mới thành công";
            else return "Thêm mới thất bại";
        }
        public string Update(string ma, string ten, string email, string sdt, int gioitinh, byte anh, string diachi)
        {
            if (qlsv.Edit(ma, ten, email, sdt, gioitinh, anh, diachi)) return "Update thành công";
            else return "Update thất bại";
        }
    }
}
