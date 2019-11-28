﻿using LancheMac.Models;
using System.ComponentModel.DataAnnotations;
namespace LanchesMac.Models
{
    public class CarrinhoCompraItem
    {
       public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }
        
        [StringLength(200)]
        public string CarrinhoCompraId { get; set;  }

    }
}
