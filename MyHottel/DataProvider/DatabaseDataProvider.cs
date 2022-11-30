using MyHottel.DBContext.ApplicationContext;
using MyHottel.Models;
using System.Linq;

namespace MyHottel.DataProvider
{


    public class DatabaseDataProvider<T> : IDataProvider<T> where T : EntityBase
    {
        private ApplicationContext Db = new ApplicationContext();

        public List<T> ListOfEntity = new List<T>();

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
            var selected = (from itemOfList in ListOfEntity
                    where itemOfList.Id == Id
                    select itemOfList) as T;
            return selected;
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
