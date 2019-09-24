using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaApi.Mocks;
using LivrariaApi.Models.DTO;
using LivrariaApi.Models.Livros;
using LivrariaApi.Models.Pedidos;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers
{

    [Route("v1/public/[controller]")]
    [ApiController]
    public class PedidosController
    {
        [HttpGet("usuario/{id}")]
        public ActionResult<List<Pedido>> GetPedidosUsuario(int id)
        {
            var pedidos = new PedidosMock().ListarPedidos(id);
            return pedidos;
        }

        // GET api/pedidos/5
        [HttpGet("{id}")]
        public ActionResult<Pedido> Get(int id)
        {
            return new Pedido();
        }

        // POST api/pedidos
        [HttpPost]
        public ActionResult<Pedido> Post([FromBody] PedidoDTO pedidoDTO)
        {
            //pedido.Id = DateTime.Now.Ticks;
            var livros = pedidoDTO.IdsLivros.Select(id => new Livro
            {
                Id = id,
                Nome = "Livro " + id,
                QuantidadePaginas = 120,
                Ano = 2000,
                Autor = "Autor " + id,
                Comentarios = new List<Comentario>()
            }).ToList();

            return new Pedido
            {
                Id = 12333,
                UsuarioId = pedidoDTO.UsuarioId,
                Status = "Processando",
                Livros = livros
            };
        }
    }
}