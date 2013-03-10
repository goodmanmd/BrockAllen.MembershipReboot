using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrockAllen.MembershipReboot
{
    public interface IUserAccountFactory
    {
        UserAccount CreateAccount();
        UserAccount CreateAccount(string tenant, string username, string password, string email);
    }
}
