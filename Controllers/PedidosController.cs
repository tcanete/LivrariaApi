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
        /// <summary>
        /// Lista os pedidos do usuario
        /// </summary>
        [HttpGet("usuario/{id}")]
        public ActionResult<List<Pedido>> GetPedidosUsuario(int id)
        {
            var pedidos = new PedidosMock().ListarPedidosUsuario(id);
            return pedidos;
        }

        // GET api/pedidos/5
        /// <summary>
        /// Busca um pedido pelo ID
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<Pedido> Get(int id)
        {
            return new Pedido
            {
                Id = id,
                Status = "Entregue",
                UsuarioId = id,
                Livros = new List<Models.Livros.Livro>(){
                    new Models.Livros.Livro(){
                        Ano = 1234,
                        Autor = "José",
                        Id = 1111,
                        Nome = "Nome do Livro",
                        QuantidadePaginas = 100,
                        Comentarios = new List<Models.Livros.Comentario>()
                    }
                }
            };
        }

        // POST api/pedidos
        /// <summary>
        /// Cria um pedido a partir do carrinho
        /// </summary>
        [HttpPost]
        public ActionResult<Pedido> Post([FromBody] PedidoDTO pedidoDTO)
        {
            //pedido.Id = DateTime.Now.Ticks;
            var livros = new int[]{1,2,3,4}.Select(id => new Livro
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
                Livros = livros,
                FormaPagamento = pedidoDTO.FormaPagamento,
                Valor = pedidoDTO.Valor
            };
        }

        /// <summary>
        /// Cria um carrinho com o id do usuario
        /// </summary>
        [HttpPost("carrinho/{id}")]
        public ActionResult<Carrinho> CriarCarrinho(long id)
        {
            var carrinho = new CarrinhoMock().CriarCarrinho(id);

            return carrinho;
        }

        /// <summary>
        /// Atualiza os itens do carrinho
        /// </summary>
        [HttpPut("carrinho")]
        public ActionResult<Carrinho> AtualizarCarrinho([FromBody] Carrinho carrinho)
        {
            if (carrinho == null)
            {
                return new BadRequestResult();
            }

            return new CarrinhoMock().AtualizarCarrinho(carrinho);
        }
    }
}