using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LancheMac.Models;
using LanchesMac.context;

namespace LanchesMac.Reposiitories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }
        IEnumerable<Lanche> ILancheRepository.Lanches => _context.Lanches.Include(c=> c.Categoria);

        IEnumerable<Lanche> ILancheRepository.LanchesPreferidos => _context.Lanches.Where(p=> p.isLanchePreferido).Include(c => c.Categoria);

        Lanche ILancheRepository.GetLancheById(int lancheId)
        {
           return  _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }
    }
}
