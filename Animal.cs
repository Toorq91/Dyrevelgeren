namespace AnimalEnumExample
{
    class Animal
    {
        public AnimalType Type { get; set; }
        public string Name { get; set; }
        public string Sound { get; set; }
        public string FavoriteFood { get; set; }

        public Animal(AnimalType type, string name, string sound, string food)
        {
            Type = type;
            Name = name;
            Sound = sound;
            FavoriteFood = food;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"\nDyr: {Type}");
            Console.WriteLine($"\nNavn: {Name}");
            Console.WriteLine($"\nLyd: {Sound}");
            Console.WriteLine($"\nFavorit mat: {FavoriteFood}");
        }

    }
}
