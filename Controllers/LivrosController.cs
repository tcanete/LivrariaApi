using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaApi.Mocks;
using LivrariaApi.Models.DTO;
using LivrariaApi.Models.Livros;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers
{
    [Route("v1/public/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        // GET api/livros
        /// <summary>
        /// Lista os livros cadastrados
        /// </summary>
        [HttpGet]
        public ActionResult<IEnumerable<Livro>> Get([FromQuery] string nome, [FromQuery] string autor, [FromQuery] int ano, [FromQuery]long idInicio, [FromQuery] int qtdRegistros)
        {
            var livros = new LivroMock().ListarLivros(nome, autor, ano);

            return livros;
        }

        // GET api/livros/5
        /// <summary>
        /// Busca um livro especifico
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<Livro> Get(long id)
        {
            var livro = new LivroMock().ListarLivros().Where(l => l.Id == id).FirstOrDefault();

            if (livro != null)
            {
                return livro;
            }
            else
            {
                return StatusCode(404);
            }
        }

        // POST api/livros
        /// <summary>
        /// Cadastra um livro
        /// </summary>
        [HttpPost]
        public ActionResult<Livro> Post([FromBody] Livro livro)
        {
            livro.Id = DateTime.Now.Ticks;

            return livro;
        }

        // PUT api/livros
        /// <summary>
        /// Apaga comentários em lotes a partis de id de livros
        /// </summary>
        [HttpPut]
        public ActionResult Put([FromBody] List<long> ids)
        {            
            //operacao demorada

            return Ok();
        }

        // DELETE api/livros/5
        /// <summary>
        /// Exclui um livro
        /// </summary>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return StatusCode(501);
        }

        // POST api/livros/comentario
        /// <summary>
        /// Adiciona comentario a um livro
        /// </summary>
        [HttpPost("comentario")]
        public ActionResult<Comentario> Post([FromBody] ComentarioDTO comentarioDTO)
        {
            if (comentarioDTO != null && !string.IsNullOrEmpty(comentarioDTO.Comentario) && comentarioDTO.IdLivro != 0)
            {
                var comentario = new Comentario(comentarioDTO.IdLivro, comentarioDTO.Comentario);
                comentario.Id = DateTime.Now.Ticks;
                return comentario;                
            }
            else
            {
                return StatusCode(400);            
            }
        }
    }
}
