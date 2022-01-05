using Microsoft.AspNetCore.Mvc;
using ReyNenePalace.Models;
using ReyNenePalace.ViewModels;

namespace ReyNenePalace.Contollers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PiesOfTheWeek = _pieRepository.PiesOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
