using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangerBug
{
    internal class Veps : Bug
    {

        public Veps(bool CanFly, int Legs, string Attribute, bool Poisonuous, string Name) : base(CanFly, Legs,Attribute, Poisonuous, Name)
        {
        }

        public override void ShowAttributes()
        {
           Console.Clear();
           Console.WriteLine(@"A wasp is a slender, winged insect known for its narrow waist, stinging capability, and often vibrant yellow and black markings.");
           Console.WriteLine($"Can fly: {this.GetFly()}");
           Console.WriteLine($"Legs: {this.GetLegs()}");
           Console.WriteLine($"Attribute: {this.GetAttribute()}");
           Console.WriteLine($"Poisonous: {this.IsPoisonous()}");
           Console.ReadKey();
        }
    }
}
