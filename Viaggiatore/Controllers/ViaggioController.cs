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
            using (ViaggioContext db = new ViaggioContext())
            {
                pacchettoList = db.pacchetti.ToList<Pacchetto>();
            }
            return View("Index", pacchettoList);
        }
        [HttpGet]
        // 
        public IActionResult Dettagli(int id)
        {
            using (ViaggioContext db = new ViaggioContext())
            {
                try
                {

                    Pacchetto? pacchettoTrovato = db.pacchetti
                        .Where(box => box.id == id)
                        .FirstOrDefault<Pacchetto>();
                    return View("Dettagli", pacchettoTrovato);
                }
                catch (InvalidOperationException ex)
                {
                    return NotFound("Il box non  è stato trovato");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
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
        //******************************CRUD MODIFICA BOX***********************************************
        [HttpGet]
        public IActionResult Modifica(int id)
        {
            using (ViaggioContext db = new ViaggioContext())
            {
                try
                {

                    Pacchetto? modificaPacchetto = db.pacchetti
                        .Where(box => box.id == id)
                        .FirstOrDefault<Pacchetto>();
                    return View("Modifica", modificaPacchetto);
                }
                catch (InvalidOperationException ex)
                {
                    return NotFound("Il box non  è stato trovato");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }

            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Modifica(Pacchetto box, int id)
        {
            if (!ModelState.IsValid)
            {
                return View("Modifica", box);
            }

            Pacchetto boxViaggio = null;

            //Se il modello è valido inseriamo nel nostro database il nostro box
            using (ViaggioContext db = new ViaggioContext())
            {

                boxViaggio = db.pacchetti
                .Where(pacchetto => pacchetto.id == id)
                .FirstOrDefault();
                if (boxViaggio != null)
                {
                    Pacchetto aggiungoPacchetto = new Pacchetto();
                    boxViaggio.titolo =  box.titolo;
                    boxViaggio.descrizione = box.descrizione;
                    boxViaggio.Prezzo = box.Prezzo;
                    boxViaggio.immagine = box.immagine;
                    db.SaveChanges();
                    return RedirectToAction("index", "Viaggio");
                }
                else
                {
                    return NotFound();
                }
            }
        }

        //Eliminare un BOX
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Elimina(int id)
        {
            using (ViaggioContext db = new ViaggioContext())
            {
                    Pacchetto boxDaCancellare = db.pacchetti
                     .Where(box1 => box1.id == id)
                     .FirstOrDefault();

                if (boxDaCancellare != null)
                {
                    db.pacchetti.Remove(boxDaCancellare);
                    db.SaveChanges();

                    return RedirectToAction("Index", "Viaggio");
                }
                else
                {
                    return Content("Non è andata a buon fine l'eliminazione");
                }
            }
        }
    }
    
}
    