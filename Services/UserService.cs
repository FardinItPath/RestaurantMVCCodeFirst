using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RestaurantMVCCodeFirst.Models;
using RestaurantMVCCodeFirst.Repository;
using RestaurantMVCCodeFirst.View_Model;



namespace RestaurantMVCCodeFirst.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public object Role => throw new NotImplementedException();

        public async Task<UserModel> AuthenticateUser(string username, string password)
        {
            var user = await _userRepository.GetUserByUsername(username);
            if (user == null)
            {
                return null; // User does not exist
            }
            if (user.Password == password)
            {
                return user;            
            }
            return null;
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
            
        }

        public async Task<UserModel> GetUserById(int userId)
        {
            return await _userRepository.GetUserById(userId);
            
        }

        public async Task<UserModel> GetUserByUsername(string username)
        {
            return await _userRepository.GetUserByUsername(username);
           
        }

        public async Task<bool> IsUsernameExists(string username)
        {
            return await _userRepository.IsUsernameExists(username);
           
        }

        public async Task<bool> RegisterUser(UserModel user)
        {
            if (await IsUsernameExists(user.Username))
            {
                return false; 
            }

            return await _userRepository.RegisterUser(user);
        }
        public async Task<List<RoleModel>> GetRoles()
        {
            return await _userRepository.GetRoles();
        }
        public async Task ResetPassword(ResetPasswordViewModel model)
        {
            var user = await _userRepository.GetUserByUsername(model.UserName); // Await the async method
            if (user != null)
            {
                user.Password = model.NewPassword; // Consider hashing before saving
                await _userRepository.Update(user); // Make sure this is async
            }
        }
    }
}
