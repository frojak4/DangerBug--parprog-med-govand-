using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangerBug
{
    internal class Flått : Bug
    {
        public Flått(bool CanFly, int Legs, string Attribute, bool Poisonuous, string Name) : base(CanFly, Legs, Attribute, Poisonuous, Name)
        {
        }

        public override void ShowAttributes()
        {
            Console.Clear();
            Console.WriteLine(@"A tick is a small arachnid parasite that feeds on the blood of mammals, birds, and sometimes reptiles and amphibians, often acting as a vector for various diseases.");
            Console.WriteLine($"Can fly: {this.GetFly()}");
            Console.WriteLine($"Legs: {this.GetLegs()}");
            Console.WriteLine($"Attribute: {this.GetAttribute()}");
            Console.WriteLine($"Poisonous: {this.IsPoisonous()}");
            Console.ReadKey();
        }
    }
}
