using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;

namespace DataAccessLayer.Concrete
{
    public class Repository<T>:IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        public Repository()
        {
            _object = c.Set<T>();

        }
        public List<T> List()
        {
           return _object.ToList();
        }

        public int Insert(T p)
        {
            _object.Add(p);
            return c.SaveChanges();
        }

        public int Update(T p)
        {
            return c.SaveChanges();
        }

        public int Delete(T p)
        {
            _object.Remove(p);
            return c.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
           return _object.Where(filter).ToList();
        }

        public static implicit operator Repository<T>(Repository<Author> v)
        {
            throw new NotImplementedException();
        }
    }
}
