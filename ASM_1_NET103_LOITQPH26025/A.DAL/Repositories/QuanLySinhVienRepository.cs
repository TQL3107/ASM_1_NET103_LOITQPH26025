using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1_NET103_LOITQPH26025.A.DAL.Repositories
{
    internal class QuanLySinhVienRepository
    {
        ASM1Context context = new ASM1Context();
        public QuanLySinhVienRepository()
        {

        }
        public List<QuanLySinhVien> GetAll()
        {
            return context.QuanLySinhViens.ToList();
        }
        public bool Delete(string Ma)
        {
            try
            {
                QuanLySinhVien qlsv = context.QuanLySinhViens.SingleOrDefault(a => a.MaSv == Ma);
                context.QuanLySinhViens.Remove(qlsv);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool Add(string ma, string ten, string email, string sdt, int gioitinh, byte anh, string diachi)
        {
            QuanLySinhVien qlsv = new QuanLySinhVien();
            qlsv.MaSv = ma;
            qlsv.Ten = ten;
            qlsv.Email = email;
            qlsv.Sdt = sdt;
            qlsv.GioiTinh = gioitinh;
            // qlsv.Anh = anh;
            qlsv.DiaChi = diachi;
            try
            {
                context.QuanLySinhViens.Add(qlsv);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool Edit(string ma, string ten, string email, string sdt, int gioitinh, byte anh, string diachi)
        {
            try
            {
                QuanLySinhVien qlsv = context.QuanLySinhViens.SingleOrDefault(a => a.MaSv == ma);
                qlsv.MaSv = ma;
                qlsv.Ten = ten;
                qlsv.Email = email;
                qlsv.Sdt = sdt;
                qlsv.GioiTinh = gioitinh;
                // qlsv.Anh = anh;
                qlsv.DiaChi = diachi;
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
