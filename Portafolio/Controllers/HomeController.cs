using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;
using System.Diagnostics;

namespace Portafolio.Controllers
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
            var projects = GetProjects().Take(3).ToList();
            var model = new HomeIndexViewModel() {Projects=projects };
         
            return View(model);
        }
        private List<Project> GetProjects()
        {
            return new List<Project>() { 
            new Project("Amazon", "E-Commerce realizado en AaSP.NET Core", "/Imagenes/amazon.png", "https://amazon.com"),
            new Project("New York Times","Página de noticias en React","/Imagenes/nyt.png","https://nytimes.com"),
            new Project("Reddit","Red social para compartir en comunidades","/Imagenes/reddit.png","https://reddit.com"),
            new Project("Steam","Tienda en línea para comprar videojuegos","/Imagenes/steam.png","https://store.steampowered.com")
            };
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
    }
}