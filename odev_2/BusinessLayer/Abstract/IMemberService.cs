using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public class IMemberService
    {
        List<Member> GetList();

        void MemberAdd(Member a);

        Member GetByID(int id);

        void MemberDelete(Member member);

        void MemberUpdate(Member member);
    }
}
