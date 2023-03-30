using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockAndPrice.Data;
using StockAndPrice.Shared;

namespace StockAndPrice.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductsController : ControllerBase
{
    private readonly StockAndPriceContext _context;

    public ProductsController( StockAndPriceContext context)
    {
        _context = context;
    }
    // GET: api/<ProductsController>
    [HttpGet]
    public async Task<IEnumerable<Product>> GetAsync() => await _context.Products.ToListAsync();

    // GET api/<ProductsController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetAsync(int id)
    {
        var prod = await _context.Products.FirstOrDefaultAsync(p=>p.Id==id);
        if (prod == null) return NotFound(null);
        return Ok(prod);
    }
    
    // POST api/<ProductsController>
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] Product product)
    {
        //TODO: Validate object
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return CreatedAtAction("Post", product.Id, product);
    }

    // PUT api/<ProductsController>/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] Product product)
    {
        if (!await _context.Products.AnyAsync(x => x.Id == id)) return NotFound();
        _context.Update(product);
        await _context.SaveChangesAsync();
        return NoContent();
    }

    // DELETE api/<ProductsController>/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var prod = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
        if (prod==null) return NotFound();
        _context.Products.Remove(prod);
        await _context.SaveChangesAsync();
        return Ok(prod);
        
    }
}
