using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class MemberRepository : IMemberRepository
    {
        public bool CheckCredentials(string username, string password)
                => DAOFactory.GetInstance<MemberDAO>().CheckCredentials(username, password);

        public void DeleteMember(MemberObject member)
                => DAOFactory.GetInstance<MemberDAO>().DeleteMember(member);

        public IEnumerable<MemberObject> GetMembers()
                => DAOFactory.GetInstance<MemberDAO>().GetMembers();

        public void InsertMember(MemberObject member)
                => DAOFactory.GetInstance<MemberDAO>().InsertMember(member);

        public void UpdateMember(MemberObject member)
                => DAOFactory.GetInstance<MemberDAO>().UpdateMember(member);
    }
}
