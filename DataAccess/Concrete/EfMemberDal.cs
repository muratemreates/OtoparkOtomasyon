using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfMemberDal:EfEntitiyRespositoryBase<Member,PARKOTContext>,IMemberdal
    {
        private readonly PARKOTContext context = new PARKOTContext();

        public bool MemberSearch(string username, string password)
        {
            using (context)
            {
                var result = context.Members.FirstOrDefault(p => p.UserName == username && p.Password == password);
                if (username != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool GetUserName(string username)
        {
            using (context)
            {
                var result = context.Members.Any(p => p.UserName == username);
                return result;
            }
        }
    }
}
