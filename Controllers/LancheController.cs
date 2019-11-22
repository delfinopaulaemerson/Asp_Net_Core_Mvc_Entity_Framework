using LanchesMac.Reposiitories;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller

    {
        private readonly ILancheRepository _lancheRespository;
         private readonly ICategoriaRepository _categoriaRepository;
        public LancheController(ILancheRepository lacheRepository, ICategoriaRepository categoriaRepository)
        {
            _lancheRespository = lacheRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult List()
        {
            ViewBag.Lanche = "Lanches";
            ViewData["Categoria"] = "Categoria";

            var lanches = _lancheRespository.Lanches;
            
            //passando informacoes para view
            return View(lanches);
        }
    }
}