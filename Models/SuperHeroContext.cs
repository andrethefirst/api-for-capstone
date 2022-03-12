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
          new Character {CharacterId = 10, Name = "The Last Air Bender" , SecretID = "Aang" , Intelligence = 60 , Speed = 89 , Power = 87 , Combat = 84 , Strength = 60 , Durability = 70 },
          new Character {CharacterId = 11, Name = "Spawn" , SecretID = "Albert Simmons" , Intelligence = 90 , Speed = 80 , Power = 92 , Combat = 86 , Strength = 76 , Durability = 90 },
          new Character {CharacterId = 12, Name = "Deadpool" , SecretID = "Wade Wilson" , Intelligence = 30 , Speed = 65 , Power = 25 , Combat = 83, Strength = 80, Durability = 99 },
          new Character {CharacterId = 13, Name = "Green Lantern" , SecretID = "Hal Jordan" , Intelligence = 50, Speed = 70 , Power = 93 , Combat = 60 , Strength = 60 , Durability = 79},
          new Character {CharacterId = 14, Name = "Professor X" , SecretID = "Charles Xavier" , Intelligence = 99 , Speed = 1, Power = 94 , Combat = 30 , Strength = 86 , Durability = 60 },
          new Character {CharacterId = 15, Name = "Dr.Doom" , SecretID = "Victor Von Doom" , Intelligence = 94 , Speed = 30, Power = 93, Combat = 60 , Strength = 70 , Durability = 89 },
          new Character {CharacterId = 16, Name = "Master Chief" , SecretID = "John 117" , Intelligence = 70 , Speed = 70 , Power = 70 , Combat = 70 , Strength = 70 , Durability = 70 },
          new Character {CharacterId = 17, Name = "Unenlightened" , SecretID = "Amerik Velasquez" , Intelligence = 35, Speed = 35 , Power = 35 , Combat = 35 , Strength = 35 , Durability = 35 },
          new Character {CharacterId = 18, Name = "Enlightened Apprentice" , SecretID = "Shaun Kent" , Intelligence = 80 , Speed = 80 , Power = 80 , Combat = 80 , Strength = 80 , Durability = 80 },
          new Character {CharacterId = 19, Name = "The Enlightened One" , SecretID = "Andre Velasquez" , Intelligence = 100 , Speed = 100 , Power = 100 , Combat = 100 , Strength = 100 , Durability = 100 },
          new Character {CharacterId = 20, Name = "Wolverine" , SecretID = "James Howlett" , Intelligence = 40 , Speed = 70 , Power = 80 , Combat = 90 , Strength = 90 , Durability = 99 },
          new Character {CharacterId = 21, Name = "Super Man" , SecretID = "Clark Kent" , Intelligence = 70 , Speed = 90 , Power = 95 , Combat = 97 , Strength = 98 , Durability = 94 },
          new Character {CharacterId = 22, Name = "Pain" , SecretID = "Nagato Uzumaki" , Intelligence = 80 , Speed = 60 , Power = 92 , Combat = 70, Strength = 80, Durability = 91 },
          new Character {CharacterId = 23, Name = "console.log" , SecretID = "Microsoft Documentation" , Intelligence = 0, Speed = 0 , Power = 99 , Combat = 0 , Strength = 99 , Durability = 99},
          new Character {CharacterId = 24, Name = "Psylocke" , SecretID = "Betsy Braddock" , Intelligence = 86 , Speed = 68, Power = 80 , Combat = 70 , Strength = 79 , Durability = 67 },
          new Character {CharacterId = 25, Name = "Kingpin" , SecretID = "Wilson Fisk" , Intelligence = 78 , Speed = 40, Power = 80, Combat = 78 , Strength = 84 , Durability = 74 },
          new Character {CharacterId = 26, Name = "Dani Moonstar" , SecretID = "Dani Moonstar" , Intelligence = 80 , Speed = 80 , Power = 89 , Combat = 70 , Strength = 80 , Durability = 86 },
          new Character {CharacterId = 27, Name = "Darth Maul" , SecretID = "Maul" , Intelligence = 80, Speed = 80 , Power = 87 , Combat = 87 , Strength = 78 , Durability = 77 },
          new Character {CharacterId = 28, Name = "Spider-Man" , SecretID = "Peter Parker" , Intelligence = 96 , Speed = 89 , Power = 87 , Combat = 84 , Strength = 83 , Durability = 60 },
          new Character {CharacterId = 29, Name = "Darkseid" , SecretID = "Uxas" , Intelligence = 50 , Speed = 70 , Power = 90 , Combat = 94 , Strength = 89 , Durability = 95 },
          new Character {CharacterId = 30, Name = "Exodia Kanye" , SecretID = "Kanye West" , Intelligence = 99 , Speed = 99 , Power = 99 , Combat = 99 , Strength = 99 , Durability = 99 }
        );
    }
  }
}