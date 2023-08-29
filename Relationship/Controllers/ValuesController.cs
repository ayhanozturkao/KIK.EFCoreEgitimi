using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Relationship.Context;
using Relationship.Models;

namespace Relationship.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly AppDbContext _context;

    public ValuesController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Category category = new() { Id = id };
        _context.Remove(category);
        _context.SaveChanges();
        return NoContent();
    }
}
