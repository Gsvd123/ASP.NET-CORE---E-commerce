using Entities;
using ServiceContracts.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
   public  class ProductRequest
    {
        [Required(ErrorMessage = "Producte Name should not be Blank")]
        [DisplayName("Product Name")]
        public string? ProdctName { get; set; }


        [Required]
        public CategoryOptions CategoryOptions { get; set; }

        [Required]
        public double? Price { get; set; }

        [Required]
        public BrandOptions BrandOptions{ get; set; }

        public string? ImageFileName { get; set; }

        public Product ToProduct()
        {
            return new Product() { ProductName = ProdctName, Category = CategoryOptions.ToString(), Price = Price,Brand=BrandOptions.ToString() };
        }
    }
}
