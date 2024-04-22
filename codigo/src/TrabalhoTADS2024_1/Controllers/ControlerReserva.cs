// Controller para a classe Reserva
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabalhoTADS2024_1.Models;

[ApiController]
[Route("[controller]")]
public class ReservaController : Controller
{
    private readonly ApplicationContext _context;

    public ReservaController(ApplicationContext context)
    {
        _context = context;
    }

    // GET: api/Reserva
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Reservas.ToList());
    }

    // GET: api/Reserva/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var reserva = _context.Reservas.FirstOrDefault(a => a.Id == id);
        if (reserva == null)
        {
            return NotFound();
        }
        return Ok(reserva);
    }

    // POST: api/Reserva
    [HttpPost]
    public IActionResult Post([FromBody] Reserva reserva)
    {
        _context.Reservas.Add(reserva);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = reserva.Id }, reserva);
    }

    // PUT: api/Reserva/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Reserva reserva)
    {
        if (id != reserva.Id)
        {
            return BadRequest();
        }
        _context.Entry(reserva).State = EntityState.Modified;
        _context.SaveChanges();
        return NoContent();
    }

    // DELETE: api/Reserva/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var reserva = _context.Reservas.FirstOrDefault(a => a.Id == id);
        if (reserva == null)
        {
            return NotFound();
        }
        _context.Reservas.Remove(reserva);
        _context.SaveChanges();
        return NoContent();
    }
}