using System.Collections.Generic;

namespace Timesheets.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        bool Create(T item);

        bool Update(T item);

        bool Delete(int id);
    }
}
