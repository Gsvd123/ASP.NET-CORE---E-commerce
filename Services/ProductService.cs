using Entities;
using ServiceContracts;
using ServiceContracts.DTO;
using ServiceContracts.Enum;
using System.Reflection.Metadata.Ecma335;

namespace Services
{
    public class ProductService : IProductService
    {
        private List<Product> ProductList;
        public ProductService() { 
        
            ProductList=new List<Product>()
            {
                new Product(){ ProductID=Guid.Parse("6D2CD1DA-4551-4D4A-9862-EF4878790971"),ProductName="Black Sweat shirt",Category=CategoryOptions.Hoody.ToString(),Price=599,Brand=BrandOptions.Puma.ToString(),ImageFileName="cskHoody.jpg"},
                 new Product(){ ProductID=Guid.Parse("15CC737E-43B9-449D-976E-D975AB2025CA"),ProductName="White Mug",Category=CategoryOptions.Mug.ToString(),Price=99,Brand=BrandOptions.wipro.ToString(),ImageFileName="WhiteMug.jpg"},
                  new Product(){ ProductID=Guid.Parse("4BC9FEC6-B179-4E7C-847C-57B3C9111F9B"),ProductName="Black Jens",Category=CategoryOptions.Pant.ToString(),Price=599,Brand=BrandOptions.Adidas.ToString(), ImageFileName = "BlackJens.jpg"},
                   new Product(){ ProductID=Guid.Parse("37DF6D74-35A1-4FB5-ADB2-1E5B0266D5DF"),ProductName="Yellow T-shirt",Category=CategoryOptions.Tshirt.ToString(),Price=299,Brand=BrandOptions.Nike.ToString(),ImageFileName="csk.jpg"},
                   new Product(){ ProductID=Guid.Parse("37DF6D74-35A1-4FB5-ADB2-1E5B0266D5DD"),ProductName="White T-Shirt",Category=CategoryOptions.Tshirt.ToString(),Price=199,Brand=BrandOptions.Puma.ToString(), ImageFileName = "whiteShirt.jpg"},
                   new Product(){ ProductID=Guid.Parse("37DF6D74-35A1-4FB5-ADB2-1E5B0266D5DA"),ProductName="Red T-shirt",Category=CategoryOptions.Tshirt.ToString(),Price=399,Brand=BrandOptions.Nike.ToString(), ImageFileName = "Rcbtshirt.jpg"},
                   new Product(){ ProductID=Guid.Parse("37DF6D74-35A1-4FB5-ADB2-1E5B0266D5DB"),ProductName="silver mug",Category=CategoryOptions.Mug.ToString(),Price=299,Brand=BrandOptions.wipro.ToString(), ImageFileName = "SilverMug.jpg"},
                   new Product(){ ProductID=Guid.Parse("37DF6D74-35A1-4FB5-ADB2-1E5B0266D5DC"),ProductName="Gold Mug",Category=CategoryOptions.Mug.ToString(),Price=499,Brand=BrandOptions.wipro.ToString(), ImageFileName = "GoldMug.jpg"},
                   new Product(){ ProductID=Guid.Parse("37DF6D74-35A1-4FB5-ADB2-1E5B0266D5DE"),ProductName="White Jens",Category=CategoryOptions.Pant.ToString(),Price=599,Brand=BrandOptions.Adidas.ToString(), ImageFileName = "WhiteJens.jpg"}

            };
        }
        #region GetAllProducts
        public async Task<List<ProductResponse>> GetAllProducts()
        {
            return ProductList.Select(temp=>temp.ToProductResponse()).ToList();
        }

        public async Task<List<ProductResponse>> GetFilterdProducts(string? Category, string? Brand)
        {
            if (Category == null && Brand == null) return await GetAllProducts();

            List<ProductResponse> Productlist =await GetAllProducts();

            List<ProductResponse> matchedList = Productlist;

            if(Category!=null && Brand == null)
            {
              return  matchedList=Productlist.Where(temp=>temp.Category==Category.ToString()).ToList();
            }

            if(Category==null && Brand!=null) { 

               return matchedList=Productlist.Where(temp=>temp.Brand==Brand.ToString()).ToList();    

            }
            if(Category != null && Brand != null)
            {
               return matchedList=Productlist.Where(temp=>temp.Category==Category.ToString() &&temp.Brand==Brand.ToString()).ToList();
            }



            return matchedList;



        }

        #endregion

        #region AddPerson

        #endregion
    }
}
