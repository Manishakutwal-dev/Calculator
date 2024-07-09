using Calculator.Main.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Interface.Services
{
   public interface IUserService
    {
        Task<User> LoginCheck(string email, string password);
        Task<User> GetByRefreshToken(string token);
        Task<User> Update(User user);
    }
}
