using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class MemberManager:IMemberService
    {
        private IMemberdal _memberdal;

        public MemberManager(IMemberdal memberdal)
        {
            _memberdal = memberdal;
        }

        public void Add(Member member)
        {
            _memberdal.Add(member);
        }

        public bool MemberSearch(string username, string password)
        {
            return _memberdal.MemberSearch(username, password);
        }

        public bool GetUserName(string username)
        {
            return _memberdal.GetUserName(username);
        }
    }
}
