using System.Data;
using Microsoft.EntityFrameworkCore;
using RestaurantMVCCodeFirst.Data;
using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository (AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserModel> AuthenticateUser(string username, string password)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
          
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        
        }

        public async Task<List<RoleModel>> GetRoles()
        {
            return await _context.Role.ToListAsync();
        }

        public async Task<UserModel> GetUserById(int userId)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserId == userId);
            //return await _context.Users.FindAsync(userId);
        }

        //public async Task<UserModel> GetUserByUsername(string username)
        //{
        //    return await _context.Users.FirstOrDefaultAsync(u => u.Username == username);

        //}
        public async Task<UserModel> GetUserByUsername(string username)
        {
            return await _context.Users
                .Include(u => u.Role)  
                .FirstOrDefaultAsync(u => u.Username == username);
        }


        public async Task<bool> IsUsernameExists(string username)
        {
            return await _context.Users.AnyAsync(u => u.Username == username);
           
        }

        public async Task<bool> RegisterUser(UserModel user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return true;
            
        }

        public async Task Update(UserModel user)
        {
            user.UpdatedDT = DateTime.UtcNow;
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
