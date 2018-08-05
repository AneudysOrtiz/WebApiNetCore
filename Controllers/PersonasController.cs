using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Data;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PersonasController : ControllerBase
    {
        private readonly MyApiContext _db;

        public PersonasController(MyApiContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var personas = _db.personas.ToList();

            return Ok(personas);
        }

    }
}