using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using ASM_1_NET103_LOITQPH26025.B.BUS.Services;
using ASM_1_NET103_LOITQPH26025.A.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ASM_1_NET103_LOITQPH26025.C.GUI.View
{
    public partial class QuanLyDiem : Form
    {
        private QuanLyDiemSinhVienService ql = new QuanLyDiemSinhVienService ();
        public string Ma { get; set; }
        public Account Ac { get; set; } 
        public QuanLyDiem()
        {
            InitializeComponent();
            //loaddata();
        }
        public void loaddata(List<QuanLyDiemSinhVien> list)
        {
            dtg_show.ColumnCount = 6;
            dtg_show.Columns[0].Name = "Mã";
            dtg_show.Columns[1].Name = "Tên sinh viên ";
            dtg_show.Columns[2].Name = "Tiếng Anh";
            dtg_show.Columns[3].Name = "Tin học";
            dtg_show.Columns[4].Name = "Giáo dục TC";
            dtg_show.Columns[5].Name = "Điểm TB";
            dtg_show.Rows.Clear();
            
            foreach (var item in list )
            {
                dtg_show.Rows.Add(item.MaSv,item.Ten,item.TiengAnh,item.TinHoc,item.Gdtc,item.Gdtc,item.DiemTb);  
            }    

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            List<QuanLyDiemSinhVien> all = ql.ShowAll();
            loaddata(all);
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ma.Text = dtg_show.CurrentRow.Cells[0].Value.ToString();
            tb_name.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tb_tienganh.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            tb_tin.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            tb_gdtc.Text = dtg_show.CurrentRow.Cells[4].Value.ToString();
            tb_diemTb.Text = dtg_show.CurrentRow.Cells[5].Value.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ma = tb_ma.Text;
                string ten = tb_name.Text;
                int tienganh = Convert.ToInt32(tb_tienganh.Text);
                int tin = Convert.ToInt32(tb_tin.Text);
                int gdtc = Convert.ToInt32(tb_gdtc.Text);
                int diemTb = Convert.ToInt32(tb_diemTb.Text);
                MessageBox.Show(ql.Create(ma, ten, tienganh, tin, gdtc, diemTb));
                List<QuanLyDiemSinhVien> all = ql.ShowAll();
                loaddata(all);
            }
            else
            {
                return;
            }
        }

        private void btn_detele_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(ql.Delete(Ma));
                List<QuanLyDiemSinhVien> all = ql.ShowAll();
                loaddata(all);
            }
            else
            {
                return;
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string ma = tb_ma.Text;
                string ten = tb_name.Text;
                int tienganh = Convert.ToInt32(tb_tienganh.Text);
                int tin = Convert.ToInt32(tb_tin.Text);
                int gdtc = Convert.ToInt32(tb_gdtc.Text);
                int diemTb = Convert.ToInt32(tb_diemTb.Text);
                MessageBox.Show(ql.Update(ma, ten, tienganh, tin, gdtc, diemTb));
                List<QuanLyDiemSinhVien> all = ql.ShowAll();
                loaddata(all);
            }
            else
            {
                return;
            }
        }

        private void btn_chuyen_Click(object sender, EventArgs e)
        {
            QuanLySinhVien sv = new QuanLySinhVien();
            sv.ShowDialog();
        }
        public void timkiem()
        {
            dtg_show.ColumnCount = 6;
            dtg_show.Columns[0].Name = "Mã";
            dtg_show.Columns[1].Name = "Tên sinh viên ";
            dtg_show.Columns[2].Name = "Tiếng Anh";
            dtg_show.Columns[3].Name = "Tin học";
            dtg_show.Columns[4].Name = "Giáo dục TC";
            dtg_show.Columns[5].Name = "Điểm TB";
            dtg_show.Rows.Clear();

            foreach (var item in ql.ShowAll().Where(c => c.MaSv.StartsWith(Ma)))
            {
                dtg_show.Rows.Add(item.MaSv, item.Ten, item.TiengAnh, item.TinHoc, item.Gdtc, item.Gdtc, item.DiemTb);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_timkiem.Text == "")
                {
                    tb_timkiem.Text = "Tìm kiếm theo tên,cmnd, quê quán và email nhân viên";
                    tb_timkiem.ForeColor = Color.Black;
                    List<QuanLyDiemSinhVien> all = ql.ShowAll();
                    loaddata(all);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(Convert.ToString(ex.Message), "Hãy Liên Hệ Với Thắng Để Sửa Lỗi");
            }
        }

        private void btn_search_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
    }
}
