using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LivrariaApi.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController {

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
    }
}