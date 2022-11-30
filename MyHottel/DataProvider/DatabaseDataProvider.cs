using MyHottel.DBContext.ApplicationContext;
using MyHottel.Models;
using System.Linq;

namespace MyHottel.DataProvider
{


    public class DatabaseDataProvider<T> : IDataProvider<T> where T : EntityBase
    {
        private ApplicationContext Db = new ApplicationContext();

        private readonly List<T> _data;

     

        public DatabaseDataProvider()
        {
        
        }

        public void Add(T entity)
        {
            Db.AddRange(entity);
            Db.SaveChanges();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int Id)
        {
            return _data.First(d => d.Id == Id);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
