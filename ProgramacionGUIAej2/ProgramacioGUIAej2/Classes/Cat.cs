using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacioGUIAej2.Classes
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override string MakeASound()
        {
            return "Miau miau!";
        }

        public void Presentation()
        {
            Console.WriteLine($"My name is {name} and i am a cat {MakeASound()}");
        }
    }
}