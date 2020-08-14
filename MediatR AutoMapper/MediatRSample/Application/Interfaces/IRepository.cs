using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediatRSample.Application.Interfaces
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(int id);

        Task Add(T item);

        Task Edit(T item);

        Task Delete(int id);
    }
}
