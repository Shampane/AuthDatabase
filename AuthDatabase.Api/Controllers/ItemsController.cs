using AuthDatabase.Api.DataAccess;
using AuthDatabase.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AuthDatabase.Api.Controllers;

[ApiController]
[Route("api/items")]
public class ItemsController : ControllerBase
{
    public ItemsController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    private readonly AppDbContext _dbContext;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var list = await _dbContext.Items.AsNoTracking().ToListAsync();
        return Ok(list);
    }

    [HttpPost]
    public async Task<IActionResult> Create(string name, int price)
    {
        ItemEntity item = new(name, price);
        await _dbContext.Items.AddAsync(item);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpGet("id")]
    public async Task<IActionResult> Remove(Guid id)
    {
        var item = await _dbContext.Items.FindAsync(id);
        if (item != null)
        {
            _dbContext.Items.Remove(item);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
        return BadRequest();
    }
}
