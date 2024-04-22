using Microsoft.AspNetCore.Mvc;
using TrabalhoTADS2024_1.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TrabalhoTADS2024_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdministradorController : Controller
    {
        private readonly ApplicationContext _context;

        public AdministradorController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/Administrador
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Administradores.ToList());
        }

        // GET: api/Administrador/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var admin = _context.Administradores.FirstOrDefault(a => a.Id == id);
            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin);
        }

        // POST: api/Administrador
        [HttpPost]
        public IActionResult Post([FromBody] Administrador admin)
        {
            _context.Administradores.Add(admin);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = admin.Id }, admin);
        }

        // PUT: api/Administrador/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Administrador admin)
        {
            if (id != admin.Id)
            {
                return BadRequest();
            }
            _context.Entry(admin).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/Administrador/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var admin = _context.Administradores.FirstOrDefault(a => a.Id == id);
            if (admin == null)
            {
                return NotFound();
            }
            _context.Administradores.Remove(admin);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
