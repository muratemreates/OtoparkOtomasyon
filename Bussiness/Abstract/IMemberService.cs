using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface IMemberService
    {
        void Add(Member member);
        bool MemberSearch(string username, string password);
        bool GetUserName(string username);
    }
}
