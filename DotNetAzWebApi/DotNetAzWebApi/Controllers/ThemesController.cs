using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DotNetAzWebApi.Data.DbContexts;
using DotNetAzWebApi.Data.Models;

namespace DotNetAzWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ThemesController : ControllerBase
    {
        private readonly DotNetAzDbContext _context;

        public ThemesController(DotNetAzDbContext context)
        {
            _context = context;
        }

        // GET: api/Themes
        [HttpGet(Name = "GetThemes")]
        public async Task<ActionResult<IEnumerable<Theme>>> GetThemes()
        {
          if (_context.Themes == null)
          {
              return NotFound();
          }
            return await _context.Themes.ToListAsync();
        }

        // GET: api/Themes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Theme>> GetTheme(int id)
        {
          if (_context.Themes == null)
          {
              return NotFound();
          }
            var theme = await _context.Themes.FindAsync(id);

            if (theme == null)
            {
                return NotFound();
            }

            return theme;
        }

        // PUT: api/Themes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTheme(int id, Theme theme)
        {
            if (id != theme.Id)
            {
                return BadRequest();
            }

            _context.Entry(theme).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ThemeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Themes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Theme>> PostTheme(Theme theme)
        {
          if (_context.Themes == null)
          {
              return Problem("Entity set 'DotNetAzDbContext.Themes'  is null.");
          }
            _context.Themes.Add(theme);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTheme", new { id = theme.Id }, theme);
        }

        // DELETE: api/Themes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTheme(int id)
        {
            if (_context.Themes == null)
            {
                return NotFound();
            }
            var theme = await _context.Themes.FindAsync(id);
            if (theme == null)
            {
                return NotFound();
            }

            _context.Themes.Remove(theme);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ThemeExists(int id)
        {
            return (_context.Themes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
