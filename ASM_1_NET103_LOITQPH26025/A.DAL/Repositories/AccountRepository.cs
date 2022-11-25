using ASM_1_NET103_LOITQPH26025.A.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ASM_1_NET103_LOITQPH26025.A.DAL.Repositories
{
    internal class AccountRepository
    {
        ASM1Context context = new ASM1Context();
        public List<Account> GetAllAccount()
        {
            return context.Accounts.ToList();
        }
        public Account GetAccount(string username, string password)
        {
            Account account = context.Accounts.FirstOrDefault(x => x.Username == username && x.Pass == password);
            return account;
        }
    }
}
