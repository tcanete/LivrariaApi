using System;
using System.Collections.Generic;
using System.Linq;
using LivrariaApi.Models.Livros;
using LivrariaApi.Models.Pedidos;

namespace LivrariaApi.Mocks
{
    public class CarrinhoMock
    {
        private static List<Carrinho> carrinhos = new List<Carrinho>();

        public Carrinho CriarCarrinho(long id)
        {
            var carrinho = new Carrinho
            {
                Id = DateTime.Now.Ticks,
                UserId = id,
                Livros = new List<Livro>()
            };

            carrinhos.Add(carrinho);
            return carrinho;
        }

        public Carrinho AtualizarCarrinho(Carrinho carrinho)
        {
            var carrinhoBanco = carrinhos.Where(c => c.Id == carrinho.Id).FirstOrDefault();

            carrinhoBanco = carrinho;

            return carrinho;
        }
    }
}