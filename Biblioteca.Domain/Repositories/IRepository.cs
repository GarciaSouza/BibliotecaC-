using System.Collections.Generic;

namespace Biblioteca.Domain.Repositories
{
    public interface IRepository<TYPE, IDTYPE>
    {
        void Add(TYPE entity);
        void Update(TYPE entity);
        void Remove(TYPE entity);
        TYPE GetById(IDTYPE id);
        IList<TYPE> GetAll();
    }
}
