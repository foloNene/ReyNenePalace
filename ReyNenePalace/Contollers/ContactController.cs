using Microsoft.AspNetCore.Mvc;

namespace ReyNenePalace.Contollers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
