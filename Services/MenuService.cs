
using RestaurantMVCCodeFirst.Repository;
using RestaurantMVCCodeFirst.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestaurantMVCCodeFirst.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<IEnumerable<MenuModel>> GetAllMenusAsync()
        {
            return await _menuRepository.GetAllMenusAsync();
        }

        public async Task<MenuModel> GetMenuByIdAsync(int id)
        {
            return await _menuRepository.GetMenuByIdAsync(id);
        }

        public async Task AddMenuAsync(MenuModel menu)
        {
            menu.IsActive = true;
            await _menuRepository.AddMenuAsync(menu);
        }

        public async Task UpdateMenuAsync(MenuModel menu)
        {
            await _menuRepository.UpdateMenuAsync(menu);
        }

        public async Task DeleteMenuAsync(int id)
        {
            await _menuRepository.DeleteMenuAsync(id);
        }
    }
}
