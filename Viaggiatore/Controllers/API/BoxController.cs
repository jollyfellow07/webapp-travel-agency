using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Viaggiatore.Data;
using Viaggiatore.Models;

namespace Viaggiatore.Controllers.API
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BoxController : ControllerBase
    {
        public IActionResult Get()
        {
            List<Pacchetto> boxViaggi;
            using (ViaggioContext db = new ViaggioContext())
            {
                boxViaggi = db.pacchetti.ToList();
            }
            return Ok(boxViaggi);
        }
    }
}
