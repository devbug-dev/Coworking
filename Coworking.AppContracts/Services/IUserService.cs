
using System.Collections.Generic;
using System.Threading.Tasks;
using Coworking.Business.Models;

namespace Coworking.AppContracts.Services
{
    public interface IUserService
    {
        Task<User> AddUser(User user);
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUser(int id);
        Task DeleteUser(int id);
        Task<User> UpdateUser(User user);


    }
}
