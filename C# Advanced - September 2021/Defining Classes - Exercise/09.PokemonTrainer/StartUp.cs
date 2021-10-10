using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] trainerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            List<Trainer> trainers = new List<Trainer>();
            while (trainerInfo[0] != "Tournament")
            {
                string trainerName = trainerInfo[0];
                string pokemonName = trainerInfo[1];
                string pokemonElement = trainerInfo[2];
                int pokemonHealth = Convert.ToInt32(trainerInfo[3]);
                Trainer newTrainer = new Trainer(trainerName);
                Pokemon newPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.Exists(t=>t.Name == trainerName))
                {
                    trainers.Add(newTrainer);
                }
                trainers.First(t => t.Name == trainerName).Pokemons.Add(newPokemon);
                
                trainerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            
            string cmd = Console.ReadLine();
            while (cmd != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p=>p.Element == cmd))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.Pokemons.ForEach(p => p.Health -= 10);
                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
                cmd = Console.ReadLine();
            }
            Console.WriteLine(string.Join(Environment.NewLine,trainers.OrderByDescending(t=>t.Badges)));
        }
    }
}
