using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmsLibrary.Models
{
    public class Auth : IAuth
    {
        private readonly FL_DbContext _context;
        private readonly IEncrypt _encrypt = new Encrypt();
        public static Auth Instance { get => AuthCreate.instance; }
        private Auth()
        {
            _context = new FL_DbContext();
        }
        private class AuthCreate
        {
            private AuthCreate() { }
            internal static readonly Auth instance = new Auth();
        }

        public async Task<bool> CreateUser(User user)
        {
            try
            {
                user.Salt = Guid.NewGuid().ToString();
                user.Password = _encrypt.HashPassword(user.Password, user.Salt);
                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<User> GetUser(int id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetUser(string login)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Login == login);
        }
        public async Task<User> Login(string login, string password)
        {
            User user = await GetUser(login);
            if (user == null)
                return null;
            if(user.Password == _encrypt.HashPassword(password, user.Salt))
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
