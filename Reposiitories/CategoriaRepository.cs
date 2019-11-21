using LancheMac.Models;
using LanchesMac.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Reposiitories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        IEnumerable<Categoria> ICategoriaRepository.Lanches { get => _context.Categorias; set => throw new NotImplementedException(); }
    }
}
