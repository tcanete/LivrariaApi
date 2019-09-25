using System;
using System.Collections.Generic;
using LivrariaApi.Models.Livros;

namespace LivrariaApi.Models.Pedidos {
    public class Pedido
    {
        public long Id { get; set; }
        public long UsuarioId { get; set; }
        public List<Livro> Livros { get; set; }
        public string Status { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPedido { get; set; }
    }
}