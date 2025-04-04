﻿using Microsoft.EntityFrameworkCore;
using RestaurantMVCCodeFirst.Data;
using RestaurantMVCCodeFirst.Models;

namespace RestaurantMVCCodeFirst.Repository
{
    public class MenuRepository : IMenuRepository
    {
        private readonly AppDbContext _context;

        public MenuRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<MenuModel>> GetAllMenusAsync()
        {
            return await _context.Menu.Include(m => m.Category).Where(m => m.IsActive).ToListAsync();
        }

        public async Task<MenuModel> GetMenuByIdAsync(int menuId)
        {
            return await _context.Menu.Include(m => m.Category).FirstOrDefaultAsync(m => m.MenuId == menuId && m.IsActive);
        }

        public async Task AddMenuAsync(MenuModel menu)
        {
            await _context.Menu.AddAsync(menu);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMenuAsync(MenuModel menu)
        {
            _context.Menu.Update(menu);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMenuAsync(int menuId)
        {
            var menu = await _context.Menu.FindAsync(menuId);
            if (menu != null)
            {
                menu.IsActive = false; // Soft delete
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> MenuExistsAsync(int id)
        {
            return await _context.Menu.AnyAsync(m => m.MenuId == id && m.IsActive);
        }
    }
}
