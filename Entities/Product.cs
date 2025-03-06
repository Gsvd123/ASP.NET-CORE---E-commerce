using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Product
    {
        [Required]
        public Guid ProductID {  get; set; }

        [Required(ErrorMessage ="Producte Name should not be Blank")]
        [DisplayName("Product Name")]
        public string? ProductName {  get; set; }

        [Required]
        public string Category {  get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public double? Price {  get; set; }

        public string? ImageFileName { get; set; }  


    }
}
