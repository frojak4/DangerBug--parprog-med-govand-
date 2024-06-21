using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DangerBug
{
    internal class Edderkopp : Bug
    {
        public Edderkopp(bool CanFly, int Legs, string Attribute, bool Poisonuous, string Name) : base(CanFly, Legs, Attribute, Poisonuous, Name)
        {
        }

        public override void ShowAttributes()
        {
            Console.Clear();
            Console.WriteLine(@"A spider is an arachnid with eight legs, known for spinning webs to catch prey and possessing fangs that inject venom.");
            Console.WriteLine($"Name: {this.GetName()}");
            Console.WriteLine($"Can fly: {this.GetFly()}");
            Console.WriteLine($"Legs: {this.GetLegs()}");
            Console.WriteLine($"Attribute: {this.GetAttribute()}");
            Console.WriteLine($"Poisonous: {this.IsPoisonous()}");
            Console.ReadKey();
        }
    }
}
