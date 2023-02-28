using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public interface IAuth
    {
        Task<User> GetUser(int id);
        Task<User> GetUser(string login);
        Task<bool> CreateUser(User user);
    }
}
