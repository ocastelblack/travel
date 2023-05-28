using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class LibrosController : Controller
{
    private readonly ApplicationDbContext _context;

    public LibrosController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var libros = await _context.Libros.Include(l => l.Editorial).ToListAsync();
        return View(libros);
    }

    public async Task<IActionResult> Detalles(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var libro = await _context.Libros.Include(l => l.Editorial).FirstOrDefaultAsync(l => l.ISBN == id);
        if (libro == null)
        {
            return NotFound();
        }

        return View(libro);
    }
}
