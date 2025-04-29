using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Repository
{
    public interface IUserRepository
    {
        Task<bool> RegisterUser(UserModel user); 
        Task<UserModel> AuthenticateUser(string username, string password); 
        Task<bool> IsUsernameExists(string username); 
        Task<UserModel> GetUserById(int userId); 
        Task<UserModel> GetUserByUsername(string username); 
        Task<List<UserModel>> GetAllUsers();
        Task<List<RoleModel>> GetRoles();
        Task Update(UserModel user);

        //Task<bool> UpdateUser(UserModel user); 
        //Task<bool> DeleteUser(int userId); 
    }
}
