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
    public class AnimalsRepository : IAnimalsDal
    {
        Context c = new Context();

        DbSet<Animals> _object;

        public void Delete(Animals a)
        {
            _object.Remove(a);
            c.SaveChanges();
        }

        public Animals Get(Expression<Func<Animals, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Animals a)
        {
            _object.Add(a);
            c.SaveChanges();
        }

        public List<Animals> List()
        {
            return _object.ToList();
        }

        public List<Animals> list()
        {
            throw new NotImplementedException();
        }

        public List<Animals> list(Expression<Func<Animals, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Animals a)
        {
            c.SaveChanges();
        }
    }
}
