﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Viaggiatore.Data;
using Viaggiatore.Models;

namespace Viaggiatore.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BoxController : ControllerBase
    {
        public IActionResult Get(string? cerca)
        {

            List<Pacchetto> box = new List<Pacchetto>();
            using (ViaggioContext db = new ViaggioContext())
            {
                box = db.pacchetti.ToList();
                // LOGICA PER RICERCARE I POST CHE CONTENGONO NEL TIUOLO O NELLA DESCRIZIONE LA STRINGA DI RICERCA
                if (cerca != null && cerca != "")
                {
                    box = db.pacchetti
                        .Where(box => box.titolo
                        .Contains(cerca))
                        .ToList<Pacchetto>();
                }
            }
            return Ok(box);
        }


        [HttpGet("{id}")]
        public IActionResult GetId(int? id)
        {
            using (ViaggioContext db = new ViaggioContext())
            {
                if (id != null)
                {

                    Pacchetto box = db.pacchetti.Where(box => box.id == id).FirstOrDefault<Pacchetto>();
                    return Ok(box);
                }
                else
                {
                    return NotFound();
                }
            }
        }

    }
}
