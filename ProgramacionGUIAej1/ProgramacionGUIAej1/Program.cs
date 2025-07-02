using System;

namespace ProgramacionGUIAej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizen newCitizen = new Citizen("Valentina Olmos", "46206232", 20);
            newCitizen.Greet();
            newCitizen.IsAdult();
        }
    }
}
