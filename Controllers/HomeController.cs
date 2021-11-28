using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP09_Blaser_Garber.Models;

namespace TP09_Blaser_Garber.Controllers
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
            ViewBag.ListaPizzas=Pizzeria.ListarPizzas();
            return View();
        }

        public IActionResult AgregarPizzas()
        {
            ViewBag.ListaIngredientes=Pizzeria.ListarIngredientes();
            return View();
        }
        [HttpPost]
        public IActionResult GuardarPizza(string Nombre, double Precio, string UrlFoto, string Tamano, List<int> Ingredientes)
        {
            Pizza MiPizza = new Pizza (Nombre,Precio,UrlFoto,Tamano);
            List<Ingrediente> ListaIngrediente =Pizzeria.DevolverIngredientes(Ingredientes);
            MiPizza.AgregarIngredientes(ListaIngrediente);
            Pizzeria.AgregarPizza(MiPizza);
            ViewBag.ListaPizzas=Pizzeria.ListarPizzas();
            return View("Index");
        }

        public IActionResult EliminarPizza(int IdPizza){
            Pizza PizzaElegida=null;
            List<Pizza> ListaPizzas = Pizzeria.ListarPizzas();
                foreach(Pizza UnaPizza in ListaPizzas){
                    if (UnaPizza.IdPizza == IdPizza){
                        PizzaElegida = UnaPizza;
                    }
                }
            
            if(PizzaElegida!=null){
                Pizzeria.EliminarPizza(PizzaElegida);
            }else{
                ViewBag.Error="No se elimino la pizza";
            }
            ViewBag.ListaPizzas = Pizzeria.ListarPizzas();
            return View("Index");
        }

        public IActionResult VerPizza(int IdPizza){
            List<Pizza> ListaP = Pizzeria.ListarPizzas();
            foreach(Pizza UnaPizza in ListaP){
                if (UnaPizza.IdPizza == IdPizza){
                    ViewBag.PizzaElegida=UnaPizza;
                }else{
                    ViewBag.PizzaInexistente=true;
                }
            }
            return View("DetallePizza");
        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
