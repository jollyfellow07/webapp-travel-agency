using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Viaggiatore.Data;
using Viaggiatore.Models;

namespace Viaggiatore.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RichiestaController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            using (ViaggioContext db = new ViaggioContext())
            {
                List<RichiestaUtente> listaRichieste = db.richiesteUtenti.ToList();
                return Ok(listaRichieste);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] RichiestaUtente model)
        {
            if (!ModelState.IsValid)
            {
                return UnprocessableEntity(ModelState);
            }
            using (ViaggioContext db = new ViaggioContext())
            {
                db.Add(model);
                db.SaveChanges();
                return Ok();
            }
        }
    }
}
