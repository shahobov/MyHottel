using MyHottel.DBContext.ApplicationContext;
using MyHottel.Models;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace MyHottel.DataProvider
{


    public class DatabaseDataProvider<T> : IDataProvider<T> where T : EntityBase
    {
        ApplicationContext Db = new();

        //private readonly  List<T> _data;
        public List<T> ListOfEntity = new();


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
            var item = ListOfEntity.FirstOrDefault(d => d.Id == Id);
            return item;
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
