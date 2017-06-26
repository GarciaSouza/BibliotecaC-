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
    public class LivrosController : Controller
    {
        ILivroRepository livros = Program.Container.GetInstance<ILivroRepository>();

        // GET api/values
        [HttpGet]
        public IEnumerable<Livro> Get()
        {
            return livros.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Livro Get(int id)
        {
            return livros.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Livro livro)
        {
            livros.Add(livro);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromBody]Livro livro)
        {
            livros.Update(livro);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var livro = livros.GetById(id);
            livros.Remove(livro);
        }
    }
}
