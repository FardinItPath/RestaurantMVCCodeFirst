using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace RestaurantMVCCodeFirst.Models
{
    
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }

        [Required, StringLength(100)]
        public string? Username { get; set; }

        [Required]
        public string? Password { get; set; } 

        public bool IsActive { get; set; } = true;

        [DataType(DataType.DateTime)]
        public DateTime CreatedDT { get; set; } = DateTime.UtcNow;

        [DataType(DataType.DateTime)]
        public DateTime? UpdatedDT { get; set; }

        [ForeignKey("RoleModel")]
        public int RoleId { get; set; }
        public virtual RoleModel? Role { get; set; }

    }
}
