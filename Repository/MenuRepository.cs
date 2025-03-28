using RestaurantMVCCodeFirst.Data;
using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly IMenuRepository _menuRepository;
        public MenuRepository (AppDbContext context)
        {
            _menuRepository = new MenuRepository (context);
        }
        Task IMenuRepository.AddMenuAsync(MenuModel menu)
        {
            throw new NotImplementedException();
        }

        Task IMenuRepository.DeleteMenuAsync(int menuId)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<MenuModel>> IMenuRepository.GetAllMenusAsync()
        {
            throw new NotImplementedException();
        }

        Task<MenuModel> IMenuRepository.GetMenuByIdAsync(int menuId)
        {
            throw new NotImplementedException();
        }

        Task IMenuRepository.UpdateMenuAsync(MenuModel menu)
        {
            throw new NotImplementedException();
        }
    }
}
