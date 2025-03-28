using System.ComponentModel.DataAnnotations;

namespace RestaurantMVCCodeFirst.Models
{
    public class CategoryModel
    {
        [Key]
        public int CategoryId { get; set; }

        [Required, StringLength(100)]
        public string? CategoryName { get; set; }
    }
}
