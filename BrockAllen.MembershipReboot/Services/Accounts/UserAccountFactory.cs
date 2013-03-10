using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrockAllen.MembershipReboot
{
    public class UserAccountFactory : IUserAccountFactory
    {
        public UserAccount CreateAccount()
        {
            return new UserAccount();
        }

        public UserAccount CreateAccount(string tenant, string username, string password, string email)
        {
            return new UserAccount(tenant, username, password, email);
        }
    }
}
