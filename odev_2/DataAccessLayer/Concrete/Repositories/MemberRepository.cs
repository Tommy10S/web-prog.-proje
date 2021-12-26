using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class MemberRepository : IMemberDal
    {
        Context c = new Context();
        DbSet<Member> _object;
        public void Delete(Member p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Member Get(Expression<Func<Member, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Member p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Member> list()
        {
            return _object.ToList();
        }

        public List<Member> list(Expression<Func<Member, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Member p)
        {
            c.SaveChanges();
        }
    }
}
