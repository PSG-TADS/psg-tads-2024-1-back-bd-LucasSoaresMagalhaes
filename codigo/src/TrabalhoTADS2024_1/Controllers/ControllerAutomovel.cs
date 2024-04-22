// Controller para a classe Automovel
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabalhoTADS2024_1.Models;

[ApiController]
[Route("[controller]")]
public class AutomovelController : Controller
{
    private readonly ApplicationContext _context;

    public AutomovelController(ApplicationContext context)
    {
        _context = context;
    }

    // GET: api/Automovel
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Automoveis.ToList());
    }

    // GET: api/Automovel/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var automovel = _context.Automoveis.FirstOrDefault(a => a.Id == id);
        if (automovel == null)
        {
            return NotFound();
        }
        return Ok(automovel);
    }

    // POST: api/Automovel
    [HttpPost]
    public IActionResult Post([FromBody] Automovel automovel)
    {
        _context.Automoveis.Add(automovel);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = automovel.Id }, automovel);
    }

    // PUT: api/Automovel/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Automovel automovel)
    {
        if (id != automovel.Id)
        {
            return BadRequest();
        }
        _context.Entry(automovel).State = EntityState.Modified;
        _context.SaveChanges();
        return NoContent();
    }

    // DELETE: api/Automovel/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var automovel = _context.Automoveis.FirstOrDefault(a => a.Id == id);
        if (automovel == null)
        {
            return NotFound();
        }
        _context.Automoveis.Remove(automovel);
        _context.SaveChanges();
        return NoContent();
    }
}