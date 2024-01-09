using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IMemberRepository
    {
        void InsertMember(MemberObject member);
        IEnumerable<MemberObject> GetMembers();
        void UpdateMember(MemberObject member);
        void DeleteMember(MemberObject member);
        bool CheckCredentials(string username, string password);
    }
}
