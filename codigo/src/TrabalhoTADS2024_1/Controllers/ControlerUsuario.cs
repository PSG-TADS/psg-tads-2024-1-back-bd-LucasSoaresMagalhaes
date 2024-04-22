// Controller para a classe Usuario
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrabalhoTADS2024_1.Models;

[ApiController]
[Route("[controller]")]
public class UsuarioController : Controller
{
    private readonly ApplicationContext _context;

    public UsuarioController(ApplicationContext context)
    {
        _context = context;
    }

    // GET: api/Usuario
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Usuarios.ToList());
    }

    // GET: api/Usuario/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(a => a.Id == id);
        if (usuario == null)
        {
            return NotFound();
        }
        return Ok(usuario);
    }

    // POST: api/Usuario
    [HttpPost]
    public IActionResult Post([FromBody] Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = usuario.Id }, usuario);
    }

    // PUT: api/Usuario/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Usuario usuario)
    {
        if (id != usuario.Id)
        {
            return BadRequest();
        }
        _context.Entry(usuario).State = EntityState.Modified;
        _context.SaveChanges();
        return NoContent();
    }

    // DELETE: api/Usuario/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var usuario = _context.Usuarios.FirstOrDefault(a => a.Id == id);
        if (usuario == null)
        {
            return NotFound();
        }
        _context.Usuarios.Remove(usuario);
        _context.SaveChanges();
        return NoContent();
    }
}