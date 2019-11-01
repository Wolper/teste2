using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Teste2.WebAPI.Data;
using Teste2.WebAPI.Models;

namespace Teste2.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext context;

        public ValuesController(DataContext context){
            this.context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {
            return this.context.Usuarios.ToList();            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
           return this.context.Usuarios.FirstOrDefault(x => x.id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
