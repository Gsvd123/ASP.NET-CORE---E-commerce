using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;
using ServiceContracts.Enum;

namespace Asp_Net_Core_L1__Excercise_2_.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly IProductService _ProductService;

        public HomeController(IProductService productservice)
        {
            _ProductService = productservice;
        }
        [Route("[action]")]
        [Route("/")]    
        public async Task<IActionResult> Index(string? Category,string? Brand)
        {
            var ProductList=await _ProductService.GetAllProducts();
            ViewBag.ProductListCount=ProductList.Count;

          ViewBag.CurrentCategory = Category;
            ViewBag.CurrentBrand = Brand;


            List<ProductResponse> SortedList = await _ProductService.GetFilterdProducts(Category,Brand);
            ViewBag.SortedListCount= SortedList.Count;
            return View(SortedList);
        }


    }
}
