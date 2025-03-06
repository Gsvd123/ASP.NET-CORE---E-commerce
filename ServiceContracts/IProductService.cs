using ServiceContracts.DTO;

namespace ServiceContracts
{
    public interface IProductService
    {
        public Task<List<ProductResponse>> GetAllProducts();

        public Task<List<ProductResponse>> GetFilterdProducts(string? Category, string? Brand);
        


    }
}
