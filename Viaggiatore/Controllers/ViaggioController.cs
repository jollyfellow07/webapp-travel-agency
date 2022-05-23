using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Viaggiatore.Data;
using Viaggiatore.Models;

namespace Viaggiatore.Controllers
{
    public class ViaggioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<Pacchetto> pacchettoList = new List<Pacchetto>();
            using(ViaggioContext db = new ViaggioContext())
            {
                pacchettoList = db.pacchetti.ToList<Pacchetto>();
            }
            return View("Index", pacchettoList);
        }
        [HttpGet]
        public IActionResult Dettagli(int id)
        {
            using (ViaggioContext db = new ViaggioContext())
            {
                if(db.pacchetti != null)
                {
                Pacchetto pacchettoTrovato = db.pacchetti
                    .Where(pacchetto => pacchetto.id == id)
                    .FirstOrDefault();
                return View("Dettagli", pacchettoTrovato);
                }
                else
                {
                   return Content("Non ci sono pacchetti");
                }
            }
        }
        [HttpGet]
        public IActionResult Aggiungi()
        {
            return View();
        }

        //CRUD AGGIUNGI BOX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Aggiungi(Pacchetto box)
        {
            if (!ModelState.IsValid)
            {
                return View("aggiungi", box);
            }
            //Se il modello è vallido inseriamo nel nostro database il nostro box
            using (ViaggioContext db = new ViaggioContext())
            {
                Pacchetto aggiungoPacchetto = new Pacchetto();
                aggiungoPacchetto.titolo = box.titolo;
                aggiungoPacchetto.descrizione = box.descrizione;
                aggiungoPacchetto.Prezzo = box.Prezzo;
                aggiungoPacchetto.immagine = box.immagine;

                db.pacchetti.Add(aggiungoPacchetto);
                db.SaveChanges();
            }
            return RedirectToAction("index", "Viaggio");
        }

        
    }
}