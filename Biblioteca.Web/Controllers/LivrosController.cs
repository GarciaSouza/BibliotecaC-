using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Domain.Entities;
using SimpleInjector;
using Biblioteca.Domain.Repositories;

namespace Biblioteca.Web.Controllers
{
    public class LivrosController : Controller
    {
        ILivroRepository livros = MvcApplication.Container.GetInstance<ILivroRepository>();

        // GET: Livros
        public async Task<ActionResult> Index()
        {
            return View(await Task.Run(() => livros.GetAll().ToList()));
        }

        // GET: Livros/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = await Task.Run(() => livros.GetById(id.Value));
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // GET: Livros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Livros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,ISBN,Titulo,Autor,DataPublicacao,Versao,Genero,PalavraChave,Sinopse")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                await Task.Run(() => livros.Add(livro));
                return RedirectToAction("Index");
            }

            return View(livro);
        }

        // GET: Livros/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = await Task.Run(() => livros.GetById(id.Value));
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // POST: Livros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,ISBN,Titulo,Autor,DataPublicacao,Versao,Genero,PalavraChave,Sinopse")] Livro livro)
        {
            if (ModelState.IsValid)
            {
                await Task.Run(() => livros.Update(livro));
                return RedirectToAction("Index");
            }
            return View(livro);
        }

        // GET: Livros/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Livro livro = await Task.Run(() => livros.GetById(id.Value));
            if (livro == null)
            {
                return HttpNotFound();
            }
            return View(livro);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Livro livro = await Task.Run(() => livros.GetById(id));
            await Task.Run(() => livros.Remove(livro));
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                livros = null;
            }
            base.Dispose(disposing);
        }
    }
}
