using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangerBug
{
    internal class Mygg : Bug
    {
        public Mygg(bool CanFly, int Legs, string Attribute, bool Poisonuous, string Name) : base(CanFly, Legs, Attribute, Poisonuous, Name)
        {
        }

        public override void ShowAttributes()
        {
            Console.Clear();
            Console.WriteLine(@"A mosquito is a small, flying insect known for its slender body, long legs, and ability to feed on the blood of animals and humans, often transmitting diseases such as malaria and dengue fever through its bite.");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Can fly: {this.GetFly()}");
            Console.WriteLine($"Legs: {this.GetLegs()}");
            Console.WriteLine($"Attribute: {this.GetAttribute()}");
            Console.WriteLine($"Poisonous: {this.IsPoisonous()}");
            Console.ReadKey();
        }
    }
}
