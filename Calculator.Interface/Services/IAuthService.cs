using Calculator.Main.Entities;
using System.Threading.Tasks;

namespace Calculator.Interface.Services
{
    public interface IAuthService
    {
        Task<string> GenerateToken(User user);
        Task<string> GenerateRefreshToken();
    }
}
