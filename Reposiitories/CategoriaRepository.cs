using LancheMac.Models;
using LanchesMac.context;
using System;
using System.Collections.Generic;

namespace LanchesMac.Reposiitories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

      

        IEnumerable<Categoria> ICategoriaRepository.Categorias { get => _context.Categorias; set => throw new NotImplementedException(); }
    }
}
