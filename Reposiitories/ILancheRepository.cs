using LancheMac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMac.Reposiitories
{
    interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
    }
}
