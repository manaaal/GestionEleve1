using GestionEleve1.data;
using GestionEleve1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace GestionEleve1.Controllers
{
    public class EtablissementController : Controller
    {
        private readonly AppDbContext _db;
        public EtablissementController(AppDbContext db)
        {
            _db = db;
        }
        // GET: EtablissementController
        public ActionResult Index()
        {
            IEnumerable<Etablissement> etablissements = _db.Etablissement.ToList();
            return View(etablissements);
        }

        // GET: EtablissementController/Details/5
        public ActionResult Details(int id)
        {
            Etablissement  etablissement = _db.Etablissement.Where(e => e.EtablissementId == id).FirstOrDefault();
            return View(etablissement);
        }

        // GET: EtablissementController/Create
        public ActionResult Create()
        {
            return View(new Etablissement());
        }

        // POST: EtablissementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Etablissement etablissement)
        {
            try
            {
                _db.Etablissement.Add(etablissement);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtablissementController/Edit/5
        public ActionResult Edit(int id)
        {
            Etablissement etablissement = _db.Etablissement.Where(e => e.EtablissementId == id).FirstOrDefault();
            return View(etablissement);
        }

        // POST: EtablissementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Etablissement etablissement)
        {
            try
            {
                _db.Etablissement.Update(etablissement);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EtablissementController/Delete/5
        public ActionResult Delete(int id)
        {
            Etablissement etablissement = _db.Etablissement.Where(e => e.EtablissementId == id).FirstOrDefault();
            return View(etablissement);
        }

        // POST: EtablissementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Etablissement etablissement)
        {
            try
            {
                _db.Etablissement.Remove(etablissement);
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



//Controllers: Classes that:
//Handle browser requests.
//Retrieve model data.
//Call view templates that return a response.


