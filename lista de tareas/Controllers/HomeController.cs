using Microsoft.AspNetCore.Mvc;
using lista_de_tareas.Models;
using System.Collections.Generic;

namespace lista_de_tareas.Controllers
{
    public class HomeController : Controller
    {
        private List<TareaEntity> Tareas;

        public HomeController()
        {
            Tareas = new List<TareaEntity>
            {
                new TareaEntity { Id = 1, Tarea = "Limpiar casa", Descripcion = "Limpiar baños y cuartos", Estatus = false },
                new TareaEntity { Id = 2, Tarea = "Comprar", Descripcion = "Comprar comida", Estatus = true }
            };
        }

        public IActionResult Index()
        {
            return View(Tareas);
        }
    }
}
