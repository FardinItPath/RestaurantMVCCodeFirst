using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantMVCCodeFirst.Models
{
    public class MenuModel
    {
        [Key]
        public int MenuId { get; set; }

        [Required, StringLength(100)]
        public string? Name { get; set; }

        [Required]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }
      
        public bool IsActive { get; set; } = true;

        [DataType(DataType.DateTime)]
        public DateTime CreatedDT { get; set; } = DateTime.UtcNow;

        public int CreatedBy { get; set; }

        public int? UpdatedBy { get; set; } 

        public DateTime? UpdatedDT { get; set; } = DateTime.UtcNow;

        // Foreign Key for Category
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual CategoryModel? Category { get; set; }

    }
}
