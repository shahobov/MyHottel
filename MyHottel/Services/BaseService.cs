using MyHottel.Abstractions.Services;
using MyHottel.DataProvider;
using MyHottel.Models;

namespace Hottel.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : EntityBase
    {
        private readonly IDataProvider<T> _dataProvider;
        public BaseService(IDataProvider<T> dataProvider)
        {
            _dataProvider = dataProvider;
        }

        public void Add(T entity)
        {
            if (entity == null) throw new 
                    Exception("Entity can't be null ");
            ValidateEntity(entity);
            _dataProvider.Add(entity);
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
        private void ValidateEntity(T entity)
        {
            if (!IsEntityValid(entity, out string reason))
                throw new Exception(reason);
        }

        protected abstract bool IsEntityValid(T entity, out string reason);
        
    }
}
