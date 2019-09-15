using System.Threading.Tasks;

namespace Coworking.AppContracts.ApiCaller
{
    public interface IApiCaller
    {
        Task<T> GetServiceResponseById<T>(string controller, int id);
    }
}
