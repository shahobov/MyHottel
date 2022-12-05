
using MyHottel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHottel.DataProvider
{
    public interface IDataProvider<T> where T : EntityBase
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int Id);
        T GetAll();
    }
}
