using System.ComponentModel.DataAnnotations;

namespace RestaurantMVCCodeFirst.Models
{
    public class RoleModel
    {
        [Key]
        public int RoleId { get; set; }
        [Required, StringLength(50)]
        public string? RoleName { get; set; }
    }
}
