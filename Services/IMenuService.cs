using System.Collections.Generic;
using System.Threading.Tasks;
using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Services
{
    public interface IMenuService
    {
        Task<IEnumerable<MenuModel>> GetAllMenusAsync(); 
        Task<MenuModel> GetMenuByIdAsync(int menuId);
        Task AddMenuAsync(MenuModel menu); 
        Task UpdateMenuAsync(MenuModel menu);
        Task DeleteMenuAsync(int menuId);
        //Task<bool> MenuExistsAsync(int menuId); 
        
    }
}
