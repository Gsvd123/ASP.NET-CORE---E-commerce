using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    public  class ProductResponse
    {
       public Guid ProductID {  get; set; }

        public string? ProductName { get; set; } 

        public string? Category {  get; set; }

        public string Brand { get; set; }

        public double? Price { get; set; }

        public string? ImageFileName { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj==null) return false;

            if (obj.GetType() != typeof(ProductResponse)) return false;
                
            ProductResponse productResponse = (ProductResponse)obj;

            return productResponse.ProductID==ProductID && productResponse.ProductName==ProductName && productResponse.Category==Category && productResponse.Price==Price && productResponse.Brand==Brand && productResponse.ImageFileName==ImageFileName;
        }

    }

    public static class ProductExtension
    {
        public static ProductResponse ToProductResponse(this Product product)
        {
            return new ProductResponse { ProductID = product.ProductID, ProductName = product.ProductName, Category = product.Category, Price = product.Price,Brand=product.Brand,ImageFileName=product.ImageFileName };
        }
    }
}
