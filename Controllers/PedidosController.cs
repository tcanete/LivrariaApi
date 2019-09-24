using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrariaApi.Models.Pedido;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers {

    [Route("v1/public/[controller]")]
    [ApiController]
    public class PedidosController {

        // GET api/pedido
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "pedido1", "pedido2" };
        }

        // GET api/pedido/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "pedido" + id;
        }

        // POST api/pedido
        [HttpPost]
        public ActionResult<Pedido> Post([FromBody] Pedido pedido)
        {
            pedido.Id = DateTime.Now.Ticks;

            return pedido;
        }
    }
}