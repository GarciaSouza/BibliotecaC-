using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Domain.Repositories;
using Biblioteca.Domain.Entities;

namespace Biblioteca.WebCore.Controllers
{
    [Route("api/[controller]")]
    public class RevistasController : Controller
    {
        IRevistaRepository revistas = Program.Container.GetInstance<IRevistaRepository>();

        // GET api/values
        [HttpGet]
        public IEnumerable<Revista> Get()
        {
            return revistas.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Revista Get(int id)
        {
            return revistas.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Revista revista)
        {
            revistas.Add(revista);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody]Revista revista)
        {
            revistas.Update(revista);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var revista = revistas.GetById(id);
            revistas.Remove(revista);
        }
    }
}
