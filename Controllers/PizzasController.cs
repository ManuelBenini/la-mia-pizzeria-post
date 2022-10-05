using la_mia_pizzeria_post.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_post.Controllers
{
    public class PizzasController : Controller
    {

        public List<Pizza> Pizzas()
        {
            List<Pizza> pizzas = new()
            {
                new Pizza("Margherita", "La pizza Margherita", "https://www.finedininglovers.it/sites/g/files/xknfdk1106/files/styles/recipes_1200_800_fallback/public/fdl_content_import_it/margherita-50kalo.jpg?itok=v9nHxNMS", 10.50),
                new Pizza("Napoli", "La pizza Napoli", "https://media-cdn.tripadvisor.com/media/photo-s/18/03/98/d6/received-665664433902722.jpg", 14.50),
                new Pizza("Romana", "La pizza Romana", "https://recipesblob.oetker.com/files/95bdfe7334364b41b557c734cd1c64c4/889e39b112414a9aa2b3ae5a9f787f6b/1272x764/pizza-alla-romanajpg.jpg", 17.50),
                new Pizza("4 Gusti", "La pizza 4 Gusti", "https://media-cdn.tripadvisor.com/media/photo-s/07/61/12/f1/pizza-4-gusti.jpg", 5.50)
            };
            return pizzas;
        }

        public IActionResult Index()
        {
            return View(Pizzas());
        }
        public IActionResult Show(int id)
        {
            return View(Pizzas()[id]);
        }

    }
}