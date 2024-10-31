using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class GenresController : Controller
    {
        public IActionResult Index()
        {
            List<Genre> genres = new List<Genre>
            {
                new Genre(1, "Drama"),
                new Genre(2, "Comédia"),
                new Genre(3, "Terror"),
                new Genre(4, "Ação")
            };

            return View(genres);
        }
    }
}
