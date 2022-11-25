using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using ASM_1_NET103_LOITQPH26025.B.BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASM_1_NET103_LOITQPH26025.C.GUI.View
{
    public partial class FrmQLSinhVien : Form
    {
        QuanLySinhVienService qlsv = new QuanLySinhVienService();
        public string Ma { get; set; }
        public FrmQLSinhVien()
        {
            InitializeComponent();
        }
        public void loaddata(List<QuanLySinhVien> list)
        {
            dtg_show.ColumnCount = 7;
            dtg_show.Columns[0].Name = "Mã";
            dtg_show.Columns[1].Name = "Tên sinh viên ";
            dtg_show.Columns[2].Name = "Email";
            dtg_show.Columns[3].Name = "Sđt";
            dtg_show.Columns[4].Name = "Giới tính";
            dtg_show.Columns[5].Name = "Ảnh";
            dtg_show.Columns[6].Name = "Địa chỉ";
            dtg_show.Rows.Clear();
            foreach (var item in list)
            {
                dtg_show.Rows.Add(item.MaSv, item.Ten, item.Email, item.Sdt, item.GioiTinh == 0 ? "Nam" : "Nữ", item.Anh, item.DiaChi);
            }
        }

        private void btn_hienThi_Click(object sender, EventArgs e)
        {
            List<QuanLySinhVien> all = qlsv.ShowAll();
            loaddata(all);
        }

        private void dtg_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_ma.Text = dtg_show.CurrentRow.Cells[0].Value.ToString();
            tb_name.Text = dtg_show.CurrentRow.Cells[1].Value.ToString();
            tb_mail.Text = dtg_show.CurrentRow.Cells[2].Value.ToString();
            tb_sdt.Text = dtg_show.CurrentRow.Cells[3].Value.ToString();
            ImageConverter objImageConverter = new ImageConverter();
            pic_Anh.Image = (Image)objImageConverter.ConvertFrom(dtg_show.CurrentRow.Cells[5].Value);
            
            //pic_Anh.Image = Image.FromStream(new MemoryStream((byte[])dtg_show.CurrentRow.Cells[5].Value));
            //pic_Anh.SizeMode = PictureBoxSizeMode.StretchImage;
            rd_nam.Checked = dtg_show.CurrentRow.Cells[4].Value.ToString() == "Nam";
            rd_nu.Checked = dtg_show.CurrentRow.Cells[4].Value.ToString() == "Nữ";
            tb_diachi.Text = dtg_show.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //MessageBox.Show(qlsv.Update(Ma, new QuanLySinhVien()
                //{
                string MaSv = tb_ma.Text;
                string Ten = tb_name.Text;
                string Email = tb_mail.Text;
                int Sdt = Convert.ToInt32(tb_sdt.Text);
               // byte Anh = (byte[])(new ImageConverter().ConvertTo(pic_Anh.Image, typeof(byte[])));
                int GioiTinh = rd_nam.Checked == true ? 0 : 1;
                string DiaChi = tb_diachi.Text;

                //}));
              //  MessageBox.Show(qlsv.Update(MaSv,Ten,Email,Sdt,GioiTinh,DiaChi));
                List <QuanLySinhVien> all = qlsv.ShowAll();
                loaddata(all);
            }
            else
            {
                return;
            }
        }
    }
}
