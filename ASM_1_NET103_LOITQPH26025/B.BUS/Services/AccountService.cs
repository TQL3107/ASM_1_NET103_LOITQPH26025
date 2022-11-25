using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using ASM_1_NET103_LOITQPH26025.A.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1_NET103_LOITQPH26025.B.BUS.Services
{
    internal class AccountService
    {
        AccountRepository acr = new AccountRepository();

        public bool CheckEmtyDB()
        {
            return acr.GetAllAccount() == null;
        }
        public Account CheckLogin(string username, string password)
        {
            Account ac = acr.GetAccount(username, password);
            return ac;
        }
        //public string CreateAccount(string username, string password)
        //{
        //    if (acr.CreateAccount(username, password))
        //    {
        //        return "Tạo tài khoản thành công";
        //    }
        //    return "Tạo tài khoản thất bại";
        //}
        //public bool CheckAccAxists(string username)
        //{
        //    var x = acr.GetAllAccounts().Find(x => x.Username == username); // tìm account có username đó 
        //    if (x != null) return true; // nếu tài khoản có tồn tại
        //    else return false;

        //}
    }
}
