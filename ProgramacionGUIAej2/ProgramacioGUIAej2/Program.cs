using System;
using ProgramacioGUIAej2.Classes;
namespace ProgramacioGUIAej2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VETERINARY");
            Cat newCat = new Cat("Tsukki");
            Dog newDog = new Dog("Merluza");
            newCat.Presentation();
            newDog.Presentation();
        }
    }
}
