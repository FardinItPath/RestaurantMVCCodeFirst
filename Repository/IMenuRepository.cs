using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Repository
{
    public interface IMenuRepository
    {
        Task<IEnumerable<MenuModel>> GetAllMenusAsync();
        Task<MenuModel> GetMenuByIdAsync(int menuId);
        Task AddMenuAsync(MenuModel menu);
        Task UpdateMenuAsync(MenuModel menu);
        Task DeleteMenuAsync(int menuId);
    }
}
