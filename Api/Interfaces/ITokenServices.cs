using Api.Model;
using System.Threading.Tasks;

namespace Api.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);

    }
}
