using ProgramacionGUIAej3.Models;
using ProgramacionGUIAej3.Printers;
using ProgramacionGUIAej3.Services;
using System;

namespace ProgramacionGUIAej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a bill with amount 3500 and id 35
            Bill bill = new(3500, 35);

            BillPrinter printer = new();


            // Print in digital and in paper
            printer.DigitalPrint(bill);
            printer.PaperPrint(bill);

            Console.WriteLine("Done. Press a key to exit.");
            Console.ReadKey();
        }
    }
}
