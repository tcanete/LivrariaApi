using System.Collections.Generic;

namespace LivrariaApi.Models.DTO
{
    public class PedidoDTO
    {
        public long IdCarrinho { get; set; }
        public long UsuarioId { get; set; }
        public string FormaPagamento { get; set; }
        public decimal Valor { get; set; }
    }
}