using System;
using ProgramacionGUIAej4.Controller;

namespace ProgramacionGUIAej4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            ProductController controller = new();
            
            do
            {
                Console.Clear();

                Console.WriteLine("- HARDWARE STORE -");
                Console.WriteLine("Products: ");
                controller.ShowProducts();

                Console.WriteLine("- Actions -");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Update product");
                Console.WriteLine("3. Delete product");
                Console.WriteLine("0. Exit");

                Console.Write("Enter an option: ");


                try
                {
                    input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1: controller.AddProduct(); break;
                        case 2: controller.UpdateProduct(); Console.ReadKey(); break;
                        case 3: controller.DeleteProduct(); Console.ReadKey(); break;
                        case 0: Console.WriteLine("Exiting..."); break;
                        default: Console.WriteLine("[ERROR]: Invalid input. Press any key to continue"); Console.ReadKey(); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[ERROR]: {ex.Message} Press any key to continue");
                    input = 1;
                    Console.ReadKey();
                }

            } while (input != 0);
        }

    }
}
