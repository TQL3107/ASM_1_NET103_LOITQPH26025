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
    public partial class Login : Form
    {
        AccountService acs = new AccountService();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (acs.CheckEmtyDB())
            {
                MessageBox.Show("There is no Account exists in database, please create a new one");
            }
            else
            {
                Account ac = acs.CheckLogin(txt_username.Text, txt_password.Text);
                if (ac == null) MessageBox.Show("The Account does not exists!");
                else
                {
                    QuanLyDiem cm = new QuanLyDiem();
                    cm.Ac = ac;
                    cm.ShowDialog();
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
