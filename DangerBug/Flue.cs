using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangerBug
{
    internal class Flue : Bug
    {
        public Flue(bool CanFly, int Legs, string Attribute, bool Poisonuous, string Name) : base(CanFly, Legs, Attribute, Poisonuous, Name)
        {
        }

        public override void ShowAttributes()
        {
            Console.Clear();
            Console.WriteLine(@"A fly is a small, fast-moving insect with a pair of wings and large compound eyes, known for its rapid flight and attraction to food and waste.");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Can fly: {this.GetFly()}");
            Console.WriteLine($"Legs: {this.GetLegs()}");
            Console.WriteLine($"Attribute: {this.GetAttribute()}");
            Console.WriteLine($"Poisonous: {this.IsPoisonous()}");
            Console.ReadKey();
        }
    }
}
