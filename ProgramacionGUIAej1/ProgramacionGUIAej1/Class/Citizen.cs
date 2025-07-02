using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionGUIAej1
{
    public class Citizen
    {
        private string fullName { get; set; }
        private string dni { get; set; }
        private int age { get; set; }

        public Citizen(string fullName, string dni, int age)
        {
            this.fullName = fullName;
            this.dni = dni;
            this.age = age;
        }

        public void Greet()
        {
            if (age >= 0)
            {
                Console.WriteLine($"{fullName}: Hello! i am {age} years old.");
            }
            else
            {
                Console.WriteLine("(ERROR): Invalid age");
            }
        }

        public void IsAdult()
        {
            if (age >= 18)
            {
                Console.WriteLine("The citizen is an adult.");
            }
            else
            {
                Console.WriteLine("The citizen is a minor");
            }
        }
    }
}
