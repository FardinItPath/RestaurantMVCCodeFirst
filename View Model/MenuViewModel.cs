using System.ComponentModel.DataAnnotations;

namespace RestaurantMVCCodeFirst.View_Model
{
    public class MenuViewModel
    {
        public int MenuId { get; set; }

        [Required, StringLength(255)]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required, Range(0.01, 10000)]
        public decimal Price { get; set; }

        public bool IsActive { get; set; } = true;

        [Required]
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }
}
