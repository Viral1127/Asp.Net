using System.ComponentModel.DataAnnotations;

namespace EmployeeForm.Models
{
    public class OrderModel
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public String OrderDate { get; set; }
        [Required]

        public int CustomerId { get; set; }
        [Required]

        public string? PaymentMode { get; set; }
        [Required]

        public int? TotalAmount { get; set; } 
        [Required]

        public string ShippingAddress { get; set; }
        [Required]

        public int UserId { get; set; }
        
    }
    public class OrderDropdownModel
    {
        public int OrderId { get; set; }
    }

}
