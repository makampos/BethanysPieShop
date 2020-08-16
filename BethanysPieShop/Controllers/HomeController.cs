using BethanysPieShop.Models;
using BethanysPieShop.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        // GET
        public IActionResult Index()
        {

            var homeViewModel = new HomeViewModel
            {
                PiesOfWeek = _pieRepository.PiesOfWeek
            };
            return View(homeViewModel);
        }
    }
}