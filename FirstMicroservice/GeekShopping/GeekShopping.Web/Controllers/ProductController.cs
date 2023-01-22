using GeekShopping.Web.Models;
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

        public async Task<IActionResult> ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductModel model)
        {
            if (ModelState.IsValid)
            {
                var response = await _prouctService.CreateProduct(model);
                
                if (response != null)
                {
                    return RedirectToAction(nameof(ProductIndex));
                }
            }
            return View(model);
        }
    }
}