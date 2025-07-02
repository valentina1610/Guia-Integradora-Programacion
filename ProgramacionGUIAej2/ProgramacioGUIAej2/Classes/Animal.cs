using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacioGUIAej2.Classes
{
    public abstract class Animal
    {
        public string name { get; set; }

        public Animal(string name)
        {
            this.name = name;
        }

        public virtual string MakeASound()
        {
            return "";
        }
    }
}
