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

        public bool MemberSearch(string username, string password)
        {
            using (PARKOTContext context = new PARKOTContext())
            {
                try
                {
                       var result = context.Members.FirstOrDefault(p => p.UserName == username && p.Password == password);
               
                if (result != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
             
            }
        }

        public bool GetUserName(string username)
        {
            using (PARKOTContext context = new PARKOTContext())
            {
                var result = context.Members.Any(p => p.UserName == username);
                return result;
            }
        }
    }
}
