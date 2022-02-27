using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHero.Models;
using System.Linq;

namespace SuperHero.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CharactersController : ControllerBase
  {
    private readonly SuperHeroContext _db;
    
    public CharactersController(SuperHeroContext db)
    {
      _db = db;
    }

    //GET api/characters
    [HttpGet]
    
    public async Task <ActionResult<PaginationModel>> Get(string name, string secretId, int page, int perPage)
    {
      var query = _db.Characters.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (secretId != null)
      {
        query= query.Where(entry => entry.SecretID == secretId);
      }

      List<Character> characters = await query.ToListAsync();

      if (perPage == 0) perPage = 3;

      int total = characters.Count;
      List<Character> characterPage = new List<Character>();
      
      if(page < (total / perPage))
      {
        characterPage = characters.GetRange(page * perPage, perPage);
      }

      if (page == (total/perPage))
      {
        characterPage = characters.GetRange(page * perPage, total - (page * perPage));
      }

      return new PaginationModel()
      {
        Data = characterPage,
        Total = total,
        PerPage = perPage,
        Page = page,
        PreviousPage = page == 0 ? "No previous page" : $"/api/characters?page={page - 1}&perPage={perPage}",
        NextPage = page == total/perPage ? "No next page" : $"/api/characters?page={page + 1}&perPage={perPage}"
      };
    }

    // POST api/character
    [HttpPost]
    public async Task<ActionResult<Character>> Post(Character character)
    {
      _db.Characters.Add(character);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetCharacter), new { id = character.CharacterId }, character);
    }

    // GET: api/Character/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Character>> GetCharacter(int id)
    {
      var character = await _db.Characters.FindAsync(id);

      if(character == null)
      {
        return NotFound();
      }

      return character;
    }

    // PUT: api/Character/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Character character)
    {
      if (id != character.CharacterId)
      {
        return BadRequest();
      }

      _db.Entry(character).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!CharacterExists(id))
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
     // DELETE: api/Players/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCharacter(int id)
    {
      var character = await _db.Characters.FindAsync(id);
      if (character == null)
      {
        return NotFound();
      }

      _db.Characters.Remove(character);
      await _db.SaveChangesAsync();

      return NoContent();
    }
    private bool CharacterExists(int id)
    {
      return _db.Characters.Any(e => e.CharacterId == id);
    }
  }
}