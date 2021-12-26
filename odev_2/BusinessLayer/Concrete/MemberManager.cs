using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MemberManager:IMemberService
    {
        IMemberDal _memberDal;

        public MemberManager(IMemberDal memberDal)
        {
            this._memberDal = memberDal;
        }

        public void MemberAdd(Member a)
        {
            _memberDal.Insert(a);
        }

        public void MemberDelete(Member member)
        {
            _memberDal.Delete(member);
        }



        public void MemberUpdate(Member member)
        {
            _memberDal.Update(member);
        }

        public Member GetByID(int id)
        {
            return _memberDal.Get(x => x.memberID == id);
        }

        public List<Member> GetList()
        {
            return _memberDal.list();
        }
    }
}
