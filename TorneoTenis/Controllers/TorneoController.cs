using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TorneoTenis.Context;
using TorneoTenis.Services;


namespace TorneoTenis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TorneoController : ControllerBase
    {

        private readonly ApplicationDbContext _context;

        public TorneoController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost("TorneoMasculino")]
        public async Task<IActionResult> TorneoMasculinoAsync([FromBody] List<JugadorMasculino> jugadores)
        {
            var torneoService = new TorneoService(_context);
            var ganador = await torneoService.IniciarTorneoMasculinoAsync(jugadores);

            return Ok($"Ganador del torneo: {ganador}");
        }


        [HttpPost("TorneoFemenino")]
        public async Task<IActionResult> TorneoFemeninoAsync([FromBody] List<JugadorFemenino> jugadoras)
        {
            var torneoService = new TorneoService(_context);
            var ganador = await torneoService.IniciarTorneoFemeninoAsync(jugadoras);

            return Ok($"Ganador del torneo: {ganador}");
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Torneo>>> Get()
        {
            return await _context.Torneos.ToListAsync();
        }

        [HttpGet("{id}")]
        public IActionResult GetTorneoById(int id)
        {
            var torneo = _context.Torneos.FirstOrDefault(t => t.Id == id);

            if (torneo == null)
            {
                return NotFound();
            }

            return Ok(torneo);
        }

        // GET: /Torneo/fecha/{fecha}
        [HttpGet("fecha/{fecha}")]
        public IActionResult GetTorneoByFecha(DateTime fecha)
        {
            var torneo = _context.Torneos.FirstOrDefault(t => t.Fecha == fecha);

            if (torneo == null)
            {
                return NotFound();
            }
            return Ok(torneo);
        }
    }

}
