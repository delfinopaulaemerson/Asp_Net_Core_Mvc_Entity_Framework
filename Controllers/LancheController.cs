using LancheMac.Models;
using LanchesMac.Reposiitories;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IActionResult List(string categoria)

        {
            string _categoria = categoria;
            IEnumerable<Lanche> lanches;
            
            string categoriaAtual = string.Empty;
            
            if (string.IsNullOrEmpty(categoria))
            {
                lanches = _lancheRespository.Lanches.OrderBy(l => l.LancheId);
                categoria = "Todos os Lanches";
            }
            else
            {
                if(string.Equals("Lanche Natural", _categoria, StringComparison.OrdinalIgnoreCase))
                {
                    lanches = _lancheRespository.Lanches.Where(l => l.Categoria.CategoriaId.Equals(1))
                        .OrderBy(l => l.Nome);
                }
                else
                {
                    lanches = _lancheRespository.Lanches.Where(l => l.Categoria.CategoriaId.Equals(2))
                      .OrderBy(l => l.Nome);
                }
                categoriaAtual = _categoria;
            }


            var lanchelistViewModel = new LancheListViewModel()
            {
                Lanches = lanches,
                CategoriaAtual = categoriaAtual
            };
          
            return View(lanchelistViewModel);
        }

        public IActionResult Details(int lancheId)
        {
            var lanche = _lancheRespository.Lanches.FirstOrDefault(l => l.LancheId == lancheId);

            if (lanche == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }

            return View(lanche);
        }

        public IActionResult Search(string searchString)
        {
            String _searchString = searchString;
            IEnumerable<Lanche> lanches;

            if (string.IsNullOrEmpty(_searchString))
            {
                lanches = _lancheRespository.Lanches.OrderBy(l => l.LancheId);
            }
            else
            {
                lanches = _lancheRespository.Lanches.Where(l => l.Nome.ToLower().Contains(_searchString.ToLower())) ;
            }

            return View("~/Views/Lanche/List.cshtml", new LancheListViewModel {Lanches = lanches, CategoriaAtual="Todos os lanches" });
        }


    }
}