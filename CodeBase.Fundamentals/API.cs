using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace SimpleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadoresController : ControllerBase
    {
        // GET api/jogadores
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Jogador1", "Jogador2" };
        }

        // GET api/jogadores/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Jogador" + id;
        }

        // POST api/jogadores
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // Adicione o jogador
        }

        // PUT api/jogadores/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // Atualize o jogador
        }

        // DELETE api/jogadores/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // Delete o jogador
        }
    }
}