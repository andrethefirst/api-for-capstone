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

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Character>()
        .HasData(
          new Character {CharacterId = 1, Name = "Raven" , SecretID = "Raven" , Intelligence = 90 , Speed = 62 , Power = 92 , Combat = 30 , Strength = 50 , Durability = 85 },
          new Character {CharacterId = 2, Name = "Human Torch" , SecretID = "Johnny Storm" , Intelligence = 55 , Speed = 87 , Power = 81 , Combat = 50, Strength = 70, Durability = 70 },
          new Character {CharacterId = 3, Name = "Dr Strange" , SecretID = "Stephen Strange" , Intelligence = 96, Speed = 76 , Power = 99 , Combat = 50 , Strength = 80 , Durability = 40},
          new Character {CharacterId = 4, Name = "Spider Man 2099" , SecretID = "Miguel O'Hara" , Intelligence = 87 , Speed = 77, Power = 45 , Combat = 89 , Strength = 88 , Durability = 87 },
          new Character {CharacterId = 5, Name = "Green Arrow" , SecretID = "Oliver Queen" , Intelligence = 50 , Speed = 48, Power = 20, Combat = 95 , Strength = 60 , Durability = 40 },
          new Character {CharacterId = 6, Name = "Zatanna" , SecretID = "Zatanna Zatara" , Intelligence = 78 , Speed = 50 , Power = 89 , Combat = 68 , Strength = 58 , Durability = 66 },
          new Character {CharacterId = 7, Name = "Capt. of Heart Pirates" , SecretID = "Trafalgar Law" , Intelligence = 80, Speed = 35 , Power = 93 , Combat = 84 , Strength = 70 , Durability = 60 },
          new Character {CharacterId = 8, Name = "Yami Yugi" , SecretID = "Yami Yugi" , Intelligence = 95 , Speed = 10 , Power = 90 , Combat = 10 , Strength = 40 , Durability = 35 },
          new Character {CharacterId = 9, Name = "Darth Vader" , SecretID = "Anakin Skywalker" , Intelligence = 80 , Speed = 50 , Power = 94 , Combat = 85 , Strength = 90 , Durability = 95 },
          new Character {CharacterId = 10, Name = "The Last Air Bender" , SecretID = "Aang" , Intelligence = 60 , Speed = 89 , Power = 87 , Combat = 84 , Strength = 60 , Durability = 70 }
        );
    }
  }
}