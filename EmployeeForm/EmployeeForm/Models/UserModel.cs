using System.ComponentModel.DataAnnotations;

namespace EmployeeForm.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }
    
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string MobileNumber { get; set; }
            
        [Required]
        public string Address { get; set; }

        public bool IsActive { get; set; }

        public class UserDropDownModel
        {
            public int UserId { get; set; }
            public string UserName { get; set; }
        }

    }
}
