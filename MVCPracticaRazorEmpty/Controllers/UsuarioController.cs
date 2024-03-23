using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCPracticaRazorEmpty.Models;

namespace MVCPracticaRazorEmpty.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly DbContexto _DbContexto;
        public UsuarioController(DbContexto DbContexto)
        {
            _DbContexto = DbContexto;
        }
        public IActionResult Index()
        {
            var lista = (from u in _DbContexto.USUARIOS
                                select new
                                {
                                    nombre = u.nombre,
                                    genero = u.genero,
                                    direccion = u.direccion,
                                    curso = u.curso
                                }).ToList();
            ViewData["listaUsu"] = lista;
            return View();
        }
        public IActionResult Agregar(usuario nuevo)
        {
            _DbContexto.Add(nuevo);
            _DbContexto.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
