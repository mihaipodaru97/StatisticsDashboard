using DuplicateService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StatisticsDashboard.Controllers
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
            var service = new Service();
            var cars = service.GetCars();
            return View(service.GetStats(cars));
        }
    }
}
