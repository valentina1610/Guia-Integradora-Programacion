using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacioGUIAej2.Classes
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override string MakeASound()
        {
            return "Guau guau!";
        }

        public void Presentation()
        {
            Console.WriteLine($"My name is {name} and i am a dog {MakeASound()}");
        }
    }
}
