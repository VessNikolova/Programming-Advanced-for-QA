namespace PokemonTrainer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Trainer> trainers = new List<Trainer>();

            while(input != "Tournament")
            {
                string[] inputArr = input.Split(" ");

                string trainerName = inputArr[0];
                string pokemonName = inputArr[1];
                string element = inputArr[2];
                int health = int.Parse(inputArr[3]);

                Pokemon pokemon = new Pokemon(pokemonName, element, health);

                Trainer existingTrainer = trainers.FirstOrDefault(t => t.Name == trainerName);

                if (existingTrainer == null)
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(pokemon);
                    trainers.Add(newTrainer);
                }
                else
                {
                    existingTrainer.Pokemons.Add(pokemon);
                }

                input = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while(command != "End")
            {
                foreach (Trainer trainer in trainers)
                {
                    if (trainer.Pokemons.Any(p => p.Element == command))
                    {
                        trainer.NumberBadges++;
                    }
                    else
                    {
                        // Reduce 10 health for all Pokemons
                        foreach (var p in trainer.Pokemons)
                        {
                            p.Health -= 10;
                        }

                        // Remove dead Pokemons
                        trainer.Pokemons = trainer.Pokemons
                            .Where(p => p.Health > 0)
                            .ToList();
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(t => t.NumberBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberBadges} {trainer.Pokemons.Count}");
            }

        }
    }
}

