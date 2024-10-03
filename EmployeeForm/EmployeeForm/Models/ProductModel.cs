using System.ComponentModel.DataAnnotations;

namespace EmployeeForm.Models
{
    public class ProductModel
    {
        [Required]
        public int? ProductId { get; set; }


        [Required (ErrorMessage ="Please enter Product Name")]
        [RegularExpression(@"^[a-zA-z]+[a-zA-Z_]*$" , ErrorMessage ="Product name cannot be numbers")]
        
        public string ProductName { get; set; }


        [Required (ErrorMessage ="Please enter Product Price")]
       
        public int ProductPrice { get; set; }


        [Required (ErrorMessage ="Please Enter product code")]
        public string ProductCode { get; set; }


        [Required (ErrorMessage ="Please enter description")]
        public string Description { get; set; }

        public int UserId { get; set; }

    }

    public class ProductDropdownModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
