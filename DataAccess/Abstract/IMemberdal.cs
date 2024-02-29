using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Concrete;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IMemberdal : IEntitiyRespository<Member>
    {

        bool MemberSearch(string username, string password);
        bool GetUserName(string username);

    }
}
