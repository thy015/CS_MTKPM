namespace Flyweight;

public class Flyweight
{
    
    // 1️⃣ Abstract Class (Flyweight)
    abstract class Animal
    {
        public string Name { get; protected set; }
        public string Type { get; protected set; }
        public int Age { get; set; }

        public abstract void Eat();
    }

    // 2️⃣ Concrete Class (Flyweight Instance)
    class CarAnimal : Animal
    {
        public CarAnimal(string name)
        {
            Name = name;
            Type = "Carnivore";  // Động vật ăn thịt
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating meat.");
        }
    }

    class HerbAnimal : Animal
    {
        public HerbAnimal(string name)
        {
            Name = name;
            Type = "Herbivore";  // Động vật ăn cỏ
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating vegetable.");
        }
    }

    // 3️⃣ Flyweight Factory
    class AnimalFactory
    {
        private static Dictionary<string, Animal> animalCache = new Dictionary<string, Animal>();

        public static Animal GetAnimalFromFactory(string animalType, string name)
        {
            string key = animalType + "_" + name;

            // Kiểm tra xem đã có Animal trong cache chưa
            if (!animalCache.ContainsKey(key))
            {
                if (animalType == "Carnivore")
                {
                    animalCache[key] = new CarAnimal(name);
                }
                else if (animalType == "Herbivore")
                {
                    animalCache[key] = new HerbAnimal(name);
                }
                else
                {
                    throw new ArgumentException("Invalid animal type.");
                }
            }

            return animalCache[key]; // Trả về đối tượng đã có (hoặc mới tạo)
        }
    }
}