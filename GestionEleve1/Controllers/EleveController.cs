using GestionEleve1.data;
using GestionEleve1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GestionEleve1.Controllers
{
    public class EleveController : Controller
    {
        // create object linked to db
        private readonly AppDbContext _db;
        // constructeur pour initialiser l'objet lie a la bdd
        public EleveController(AppDbContext db)
        {
            _db = db;
        }
        // GET: EleveController
        public ActionResult Index()
        {
            // create list to fill from db
            IEnumerable<Eleve> eleve = _db.Eleve.Include(e => e.Etablissement).ToList();
            return View(eleve);
        }

        // GET: EleveController/Details/5
        public ActionResult Details(int id)
        {
            Eleve eleve = _db.Eleve.Include(e => e.Etablissement).Where(eleve => eleve.Id == id).FirstOrDefault();
            return View(eleve);
        }

        // GET: EleveController/Create
        public ActionResult Create()
        {
            IEnumerable<Etablissement> etablissements = _db.Etablissement.ToList();
            ViewBag.Etablissement = new SelectList(etablissements, "EtablissementId", "EtablissementName");
            return View();
        }

        // POST: EleveController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Eleve eleve)
        {
            try
            {
                _db.Eleve.Add(eleve);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EleveController/Edit/5
        public ActionResult Edit(int id)
        {
            IEnumerable<Etablissement> etablissement = _db.Etablissement.ToList();
            ViewBag.Etablissement = new SelectList(etablissement, "EtablissementId", "EtablissementName");
            Eleve eleve = _db.Eleve.Include(e => e.Etablissement).Where(e => e.Id == id).FirstOrDefault();
            return View(eleve);
        }

        // POST: EleveController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Eleve eleve)
        {
            try
            {
                _db.Eleve.Update(eleve);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EleveController/Delete/5
        public ActionResult Delete(int id)
        {
            Eleve eleve = _db.Eleve.Include(e => e.Etablissement).Where(e => e.Id == id).FirstOrDefault();
            return View(eleve);
        }

        // POST: EleveController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Eleve eleve)
        {
            try
            {
                _db.Eleve.Remove(eleve);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
