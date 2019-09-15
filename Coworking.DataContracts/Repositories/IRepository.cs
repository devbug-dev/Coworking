using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coworking.DataContracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Exist(int id);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T element);
        Task<T> Update(int id, T element);
        Task DeleteAsync(int id);
    }
}