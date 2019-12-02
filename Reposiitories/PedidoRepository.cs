using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanchesMac.context;
using LanchesMac.Models;

namespace LanchesMac.Reposiitories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }
        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItens;

            foreach(var carrinhoItem in carrinhoCompraItens)
            {
                var pedidosDetalhe = new PedidoDetalhe()
                {
                    Quantidade = carrinhoItem.Quantidade,
                    LancheId = carrinhoItem.Lanche.LancheId,
                    PedidoId =  pedido.PedidoId,
                    Preco = carrinhoItem.Lanche.Preco
                };

                _appDbContext.PedidoDetalhes.Add(pedidosDetalhe);

            }
            _appDbContext.SaveChanges();
        }
    }
}
