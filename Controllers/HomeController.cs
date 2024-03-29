using eCommerceWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eCommerceWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("home/checkout")]
        public IActionResult Checkout(int? productId, decimal productPrice)
        {
            // Use productId as needed in your checkout logic
            ViewBag.ProductId = productId;
            ViewBag.ProductPrice = productPrice;

            return View();
        }
    }
}
