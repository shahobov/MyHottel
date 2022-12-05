using MyHottel.DBContext.ApplicationContext;
using MyHottel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MyHottel.DataProvider
{


    public class DatabaseDataProvider<T> : IDataProvider<T> where T : EntityBase
    {
        private ApplicationContext Db = new ApplicationContext();
        public void Add(T entity)
        {
            Db.AddRange(entity);
            Db.SaveChanges();
        }

        public void Delete(T entity)
        {
            Db.Remove(entity);
        }

        public T GetAll()
        {
            return null;
        }

        public T GetById(int Id)
        {
            return Db.Set<T>().FirstOrDefault(d => d.Id == Id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
