using GeekShopping.Web.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _prouctService;

        public ProductController(IProductService prouctService)
        {
            _prouctService = prouctService ?? throw new ArgumentNullException(nameof(prouctService));
        }

        public async Task<IActionResult> ProductIndex()    
        {
            var products = await _prouctService.FindAllProducts();

            return View(products);
        }
    }
}