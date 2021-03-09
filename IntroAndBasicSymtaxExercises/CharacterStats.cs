using System;

namespace CharacterStats
{
    class CharacterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            int leftHealth = maxHealth - currentHealth;
            int leftEnergy = maxEnergy - currentEnergy;

            string currHealthAsString = new string('|', currentHealth);  //explanation:
            string currEnergyAsString = new string('|', currentEnergy);  //new string('symbol', how many times to be pasted)

            string leftHealthASString = new string('.', leftHealth);
            string leftEnergyAsString = new string('.', leftEnergy);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currHealthAsString}{leftHealthASString}|");
            Console.WriteLine($"Energy: |{currEnergyAsString}{leftEnergyAsString}|");
        }
    }
}
