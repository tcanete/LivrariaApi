using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaApi.Mocks;
using LivrariaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        // GET api/livro
        [HttpGet]
        public ActionResult<IEnumerable<Livro>> Get()
        {
            var livros = new LivroMock().ListarLivros();

            return livros;//new string[] { "livro1", "livro2" };
        }

        // GET api/livro/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "livro" + id;
        }

        // POST api/livro
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/livro/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/livro/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
