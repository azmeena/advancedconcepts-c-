using System.Collections.Generic;

namespace Generics
{
    public interface IRepository<T> where T: new()
    {
        #region Methods

        T GetById(object id);
        T GetById(int id);
        void Insert(T entity);
        void Insert(IEnumerable<T> entities);
        void Update(T entity);
        void Update(IEnumerable<T> entities);
        void Delete(T entity);
        void Delete(IEnumerable<T> entities);

        #endregion
    }
}
