using LancheMac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Reposiitories
{
   public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Lanches { get; set; }
    }
}
