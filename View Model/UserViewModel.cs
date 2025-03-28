using System.ComponentModel.DataAnnotations;

namespace RestaurantMVCCodeFirst.View_Model
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        [Required, StringLength(100)]
        public string? Username { get; set; }

        [Required, DataType(DataType.Password)]
        public string? Password { get; set; }


        public bool IsActive { get; set; } = true;

        public int RoleId { get; set; }
        public string? RoleName { get; set; }

    }
}
