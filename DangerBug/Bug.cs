using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangerBug
{
    internal abstract class Bug
    {
        private string _name;
        private bool _canFly;
        private int _legs;
        private string _attribute;
        private bool _poisonous;


        public Bug(bool CanFly, int Legs, string Attribute, bool Poisonuous, string Name)
        {
            _canFly = CanFly;
            _legs = Legs;
            _attribute = Attribute;
            _poisonous = Poisonuous;
            _name = Name;
        }

        public virtual void ShowAttributes()
        {
            Console.Clear();
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Can fly: {_canFly}");
            Console.WriteLine($"Legs: {_legs}");
            Console.WriteLine($"Attribute: {_attribute}");
            Console.WriteLine($"Poisonous: {_poisonous}");
            Console.ReadKey();
        }

        public bool GetFly()
        {
            return _canFly;
        }

        public int GetLegs()
        {
            return _legs;
        }

        public string GetAttribute()
        {
            return _attribute;
        }

        public bool IsPoisonous()
        {
            return _poisonous;
        }

        public string GetName()
        {
            return _name;
        }




    }
}
