using System.ComponentModel.DataAnnotations;

namespace EmployeeForm.Models
{
    public class BillsModel
    {
        [Required]
        public int BillID { get; set; }
        [Required]
        public string BillNumber { get; set; }
        [Required]

        public string BillDate { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public decimal TotalAmount  { get; set; }
        [Required]
        public decimal? Discount { get; set; }
        [Required]
        public decimal? NetAmount { get; set; }
        [Required]
        public int UserID{ get; set; }

    }
}
