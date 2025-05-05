namespace AnimalEnumExample
{
    class AnimalManager
    {
        private Dictionary<AnimalType, Animal> animalData;

        public AnimalManager()
        {
            animalData = new Dictionary<AnimalType, Animal>
            {
                { AnimalType.Hund, new Animal(AnimalType.Hund, "Theodor", "Woof", "Kjøtt") },
                { AnimalType.Kat, new Animal(AnimalType.Kat, "Ludvig", "Meow", "Fisk") },
                { AnimalType.Ku, new Animal(AnimalType.Ku, "Bernt", "Moo", "Grass") },
                { AnimalType.And, new Animal(AnimalType.And, "Berit", "Quack", "Korn") },
                { AnimalType.Løve, new Animal(AnimalType.Løve, "Knut", "Roar", "Zebra") },
            };
        }

        public void Run()
        {
            var animalTypes = Enum.GetValues(typeof(AnimalType)).Cast<AnimalType>().ToList();
            bool continueLoop = true;

            while (continueLoop)
            {
                Console.Clear();
                Console.WriteLine("Velg et dyr ved å skrive et tall:\n");

                for (int i = 0; i < animalTypes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {animalTypes[i]}");
                }

                Console.Write("\nSkriv nummeret på dyret du vil velge: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) &&
                    choice >= 1 && choice <= animalTypes.Count)
                {
                    var selectedType = animalTypes[choice - 1];
                    animalData[selectedType].DisplayInfo();
                }
                else
                {
                    Console.WriteLine("\nUgyldig valg.");
                }

                Console.Write("\nVil du velge et nytt dyr? (j/n): ");
                string again = Console.ReadLine().Trim().ToLower();
                continueLoop = again == "j";
            }

            Console.WriteLine("\nTakk for at du brukte dyrevelgeren!");
        }
    }
}
