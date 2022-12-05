using MyHottel.Models;

namespace MyHottel.Abstractions.Services
{
    public interface IBaseService<T> where T : EntityBase
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        T GetAll();
    }
}
