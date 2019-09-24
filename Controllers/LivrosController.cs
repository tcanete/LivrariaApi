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
        [HttpGet]
        public ActionResult<IEnumerable<Livro>> Get([FromQuery] string nome, [FromQuery] string autor, [FromQuery] int ano)
        {
            var livros = new LivroMock().ListarLivros(nome, autor, ano);

            return livros;
        }

        // GET api/livros/5
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
        [HttpPost]
        public ActionResult<Livro> Post([FromBody] Livro livro)
        {
            livro.Id = DateTime.Now.Ticks;

            return livro;
        }

        // PUT api/livros/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] string value)
        {
            return StatusCode(501);
        }

        // DELETE api/livros/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return StatusCode(501);
        }

        // POST api/livros/comentario
        [HttpPost("/comentario")]
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
