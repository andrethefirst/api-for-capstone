using Microsoft.EntityFrameworkCore;

namespace SuperHero.Models
{
  public class SuperHeroContext : DbContext
  {
    public SuperHeroContext(DbContextOptions<SuperHeroContext> options)
    : base(options)
    {

    }

    public DbSet<Character> Characters { get; set; }
  }
}