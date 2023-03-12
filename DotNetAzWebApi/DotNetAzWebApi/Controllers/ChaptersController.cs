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
    public class ChaptersController : ControllerBase
    {
        private readonly DotNetAzDbContext _context;

        public ChaptersController(DotNetAzDbContext context)
        {
            _context = context;
        }

        // GET: api/Chapters
        [HttpGet(Name = "GetChapters")]
        public async Task<ActionResult<IEnumerable<Chapter>>> GetChapters()
        {
          if (_context.Chapters == null)
          {
              return NotFound();
          }
            return await _context.Chapters.ToListAsync();
        }

        // GET: api/Chapters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Chapter>> GetChapter(int id)
        {
          if (_context.Chapters == null)
          {
              return NotFound();
          }
            var chapter = await _context.Chapters.FindAsync(id);

            if (chapter == null)
            {
                return NotFound();
            }

            return chapter;
        }

        // PUT: api/Chapters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChapter(int id, Chapter chapter)
        {
            if (id != chapter.Id)
            {
                return BadRequest();
            }

            _context.Entry(chapter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChapterExists(id))
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

        // POST: api/Chapters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Chapter>> PostChapter(Chapter chapter)
        {
          if (_context.Chapters == null)
          {
              return Problem("Entity set 'DotNetAzDbContext.Chapters'  is null.");
          }
            _context.Chapters.Add(chapter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChapter", new { id = chapter.Id }, chapter);
        }

        // DELETE: api/Chapters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChapter(int id)
        {
            if (_context.Chapters == null)
            {
                return NotFound();
            }
            var chapter = await _context.Chapters.FindAsync(id);
            if (chapter == null)
            {
                return NotFound();
            }

            _context.Chapters.Remove(chapter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChapterExists(int id)
        {
            return (_context.Chapters?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
