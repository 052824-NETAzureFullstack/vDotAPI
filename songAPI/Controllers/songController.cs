using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using songAPI.Models;
using songAPI.Data;

namespace songAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class songController : ControllerBase
    {
        // Field (context)
        readonly DataContext _context;

        public songController( DataContext context)
        {
            this._context = context;
        }
        // Methods

        // GET: api/<songController>
        [HttpGet]
        public async Task<ActionResult<List<Title>>> Get()
        {
            // List<Title> songs = await _context.Titles.Include(s => s.Album).Include(s => s.Artist).ToListAsync();
            return Ok(await _context.Titles
                                .Include(a => a.Album)
                                .Include(ar => ar.Artist)
                                .ToListAsync());
        }

        // GET api/<songController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Title>> Get(int id)
        {
            Title? findSong = await _context.Titles.FindAsync(id);
            if (findSong == null)
                return NotFound();
            
            return Ok(await _context.Titles
                                .Include(a => a.Album)
                                .Include(ar => ar.Artist)
                                .FirstAsync(s => s.Id == id));
        }

        // POST api/<songController>
        [HttpPost]
        public async Task<ActionResult<Title>> Post([FromBody] Title newSong)
        {
            List<Title> songs = await _context.Titles.ToListAsync();

            foreach(Title t in songs)
            {
                if (t.SongName == newSong.SongName)
                    return Conflict(newSong);
            }

            // Add new items
            await _context.Titles.AddAsync(newSong);
            await _context.SaveChangesAsync();
            return Ok();
        }

        // PUT api/<songController>/5
        
        [HttpPut("{id}")]
        public async Task<ActionResult<Title>> Put(int id, [FromBody] Title update)
        {
            Title? song = await _context.Titles.FindAsync(id);
            if (song == null)
                return NotFound();
            
            song.SongName = update.SongName;
            song.Genre = update.Genre;
            song.Tempo = update.Tempo;

            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE api/<songController>/5
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Title>> Delete(int id)
        {
            Title? endSong = await _context.Titles.FindAsync(id);
            if (endSong == null)
                return NotFound();
            
            _context.Titles.Remove(endSong);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
