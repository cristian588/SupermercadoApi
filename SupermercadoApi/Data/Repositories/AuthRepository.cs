using Microsoft.EntityFrameworkCore;
using SupermercadoApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermercadoApi.Data.Repositories
{
    public class AuthRepository : IAuthRepository
    {
        public readonly DataContext _context;
        public AuthRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<User> Login(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Username == username);
            if (user == null) return null;
            if (user.Password != password) return null;
            return user;
        }
    }
}
