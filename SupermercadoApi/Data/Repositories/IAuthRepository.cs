using SupermercadoApi.Data.Entities;
using System.Threading.Tasks;

namespace SupermercadoApi.Data.Repositories
{
    public interface IAuthRepository
    {
        Task<User> Login(string username, string password);
    }
}
