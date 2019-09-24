using System.Collections.Generic;

namespace LivrariaApi.Models.DTO
{
    public class PedidoDTO
    {
        public List<long> IdsLivros { get; set; }
        public long UsuarioId { get; set; }
    }
}