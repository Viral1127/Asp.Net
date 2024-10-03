using System.ComponentModel.DataAnnotations;

namespace EmployeeForm.Models
{
    public class OrderDetailModel
    {
        [Required]
        public int OrderDetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]

        public int Quantity { get; set; }
        [Required]

        public decimal Amount { get; set; }
        [Required]

        public decimal TotalAmount { get; set; }
        [Required]

        public int UserID { get; set; }


    }
}
