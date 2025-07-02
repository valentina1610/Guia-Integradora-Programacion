using System;
using System.Diagnostics;
using ProgramacionGUIAej5.Views;
using ProgramacionGUIAej5.Controllers;

namespace ProgramacionGUIAej5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int salida = 0;
            LoanController controller = new LoanController();
            do
            {
                Console.Clear();
                Menu.ShowMenu();

                try
                {
                    salida = int.Parse(Console.ReadLine());

                    switch (salida)
                    {
                        case 1: controller.LendBook(); Console.ReadKey();  break;
                        case 2: controller.ShowBooks(); Console.ReadKey(); break;
                        case 3: controller.ReturnBook(); Console.ReadKey(); break;
                        case 4: controller.UpdateBook(); Console.ReadKey(); break;
                        case 0: Console.WriteLine("Exiting..."); break;
                        default:
                            Console.WriteLine("[ERROR]: Invalid input, press a key to return");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR]: {ex.Message}, press a key to return.");
                    salida = 1;

                    Console.ReadKey();
                }

            } while (salida != 0);

        }
    }
}
