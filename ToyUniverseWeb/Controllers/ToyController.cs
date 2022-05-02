using Microsoft.AspNetCore.Mvc;
using ToyUniverseWeb.Services;

namespace ToyUniverseWeb.Controllers
{
    public class ToyController : Controller
    {
        private readonly IToyService toyService;

        public ToyController(IToyService toyService)
        {
            this.toyService = toyService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(toyService.GetToyPage(1));
        }

        [HttpPost]
        public IActionResult Index(int currentPageIndex)
        {
            return View(toyService.GetToyPage(currentPageIndex));
        }
    }
}
