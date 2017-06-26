using Biblioteca.Domain.Entities;
using Biblioteca.Domain.Repositories;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Biblioteca.Web.Controllers
{
    public class RevistasController : Controller
    {
        IRevistaRepository revistas = MvcApplication.Container.GetInstance<IRevistaRepository>();

        // GET: Revistas
        public async Task<ActionResult> Index()
        {
            return View(await Task.Run(() => revistas.GetAll().ToList()));
        }

        // GET: Revistas/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = await Task.Run(() => revistas.GetById(id.Value));
            if (revista == null)
            {
                return HttpNotFound();
            }
            return View(revista);
        }

        // GET: Revistas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Revistas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID,Nome,Numero,DataPublicacao,Genero,PalavraChave,Sinopse")] Revista revista)
        {
            if (ModelState.IsValid)
            {
                await Task.Run(() => revistas.Add(revista));
                return RedirectToAction("Index");
            }

            return View(revista);
        }

        // GET: Revistas/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = await Task.Run(() => revistas.GetById(id.Value));
            if (revista == null)
            {
                return HttpNotFound();
            }
            return View(revista);
        }

        // POST: Revistas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID,Nome,Numero,DataPublicacao,Genero,PalavraChave,Sinopse")] Revista revista)
        {
            if (ModelState.IsValid)
            {
                await Task.Run(() => revistas.Update(revista));
                return RedirectToAction("Index");
            }
            return View(revista);
        }

        // GET: Revistas/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Revista revista = await Task.Run(() => revistas.GetById(id.Value));
            if (revista == null)
            {
                return HttpNotFound();
            }
            return View(revista);
        }

        // POST: Revistas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Revista revista = await Task.Run(() => revistas.GetById(id));
            await Task.Run(() => revistas.Remove(revista));
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                revistas = null;
            }
            base.Dispose(disposing);
        }
    }
}
