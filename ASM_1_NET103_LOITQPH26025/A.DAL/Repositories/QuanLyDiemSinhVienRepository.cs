using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1_NET103_LOITQPH26025.A.DAL.Repositories
{
    internal class QuanLyDiemSinhVienRepository
    {
        ASM1Context context = new ASM1Context();
        public QuanLyDiemSinhVienRepository()
        {

        }
        public List<QuanLyDiemSinhVien> GetAll()
        {
            return context.QuanLyDiemSinhViens.ToList();
        }
        //public List<QuanLyDiemSinhVien> GetQuanLyDiemSinhViens(string ma)
        //{
        //    var QLD = context.QuanLySinhViens.Where(x => x.MaSv.Contains(ma));
        //    return QLD.ToList();
        //}
        public bool Delete(string Ma)
        {
            try
            {
                QuanLyDiemSinhVien ql = context.QuanLyDiemSinhViens.SingleOrDefault(a =>a.MaSv == Ma);
                context.QuanLyDiemSinhViens.Remove(ql);
                context.SaveChanges();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool Add(string ma, string ten, int tienganh , int tinhoc, int tc, int dtb)
        {
            QuanLyDiemSinhVien ql = new QuanLyDiemSinhVien();
            ql.MaSv = ma;
            ql.Ten = ten;
            ql.TiengAnh = tienganh;
            ql.TinHoc = tinhoc;
            ql.Gdtc = tc;
            ql.DiemTb = dtb;
            try
            {
                context.QuanLyDiemSinhViens.Add(ql);
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
        public bool Edit(string ma, string ten, int tienganh, int tinhoc, int tc, int dtb)
        {
            try
            {
                QuanLyDiemSinhVien ql = context.QuanLyDiemSinhViens.SingleOrDefault(a => a.MaSv == ma);
                ql.MaSv = ma;
                ql.Ten = ten;
                ql.TiengAnh = tienganh;
                ql.TinHoc = tinhoc;
                ql.Gdtc = tc;
                ql.DiemTb = dtb;
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
