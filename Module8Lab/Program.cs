// set using directives from .NET framework
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;

// create a new pokemon class to create characters
class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
} 

// class contains the main method which is called when the program runs
class PokemonLINQLab
{
    static void Main()
    {
        // Sample data: list of Pokémon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { Id = 1, Name = "Bulbasaur", Type = "Grass", Level = 15 },
            new Pokemon { Id = 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { Id = 3, Name = "Squirtle", Type = "Water", Level = 10 },
            new Pokemon { Id = 4, Name = "Pikachu", Type = "Electric", Level = 22 },
            new Pokemon { Id = 5, Name = "Eevee", Type = "Normal", Level = 25 },
            new Pokemon { Id = 6, Name = "Poliwag", Type = "Water", Level = 5 },
            new Pokemon { Id = 7, Name = "Growlithe", Type = "Fire", Level = 16 },
            new Pokemon { Id = 8, Name = "Lapras", Type = "Water", Level = 32 },
            new Pokemon { Id = 9, Name = "Ludicolo", Type = "Water", Level = 42}
        };

        // LINQ Query to find Pokémon ready to evolve (assuming level 16 for first evolution)
        var readyToEvolveQuery = from p in pokemons
                                 where p.Level >= 16
                                 orderby p.Level
                                 select p;
        // LINQ Query tp find Water Type Pokemon
        var waterType = from p in pokemons
                                  where p.Type == "Water"
                                  orderby p.Level
                                  select p;

        // LINQ Query tp find Fire Type Pokemon
        var fireType = from p in pokemons
                                  where p.Type == "Fire"
                                  orderby p.Level
                                  select p;

        // Execute the query and display the results
        Console.WriteLine("Pokémon Ready to Evolve:");
        foreach (var pokemon in readyToEvolveQuery)
        {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");
        }

        // Water type LINQ query output
        Console.WriteLine(" ");
        Console.WriteLine("Water Type Pokemon:");
        foreach (var pokemon in waterType)
        {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");
        }
        // output from fire type LINQ query
        Console.WriteLine(" ");
        Console.WriteLine("Fire Type Pokemon:");
        foreach (var pokemon in fireType)
        {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");
        }
    }
}