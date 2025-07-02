using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using ProgramacionGUIAej4.Models;

namespace ProgramacionGUIAej4.Views
{
    public class ProductView
    {
        public static void ShowMsg(string msg) => Console.WriteLine(msg);
        public static Product AddProduct()
        {
            Console.Clear();
            try
            {
                Console.WriteLine(" - LOAD PRODUCT -");

                Console.WriteLine("Name: ");
                string name = GetValidInput();
                Console.WriteLine("ID (unique!): ");
                int id = int.Parse(GetValidInput(true));
                Console.WriteLine("Price: ");
                double price = double.Parse(GetValidInput(true));
                Console.WriteLine("Stock: ");
                int stock = int.Parse(GetValidInput(true));


                Console.Clear();
                Console.WriteLine("Product added ! Press a key to return");
                Console.ReadKey();
                return new Product(name, id, price, stock);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR]: {ex.Message}");
                return null;
            }
        }

        public static void ShowProducts(List<Product> list)
        {
            int index=0;
            foreach (var i in list)
            {
                Console.WriteLine($"Product {index+1}: ");
                index++;
                Console.WriteLine($"Name: {i.Name} ~ ID: {i.Id} ~ Price: {i.Price} ~ Stock: {i.Stock}");
            }
        }

        public static string GetValidInput(bool isNumeric = false)
        {
            bool isValid = false;
            string input;
            do
            {
                input = Console.ReadLine();
                if (isNumeric && double.TryParse(input, out double value) && !string.IsNullOrEmpty(input))
                {
                    isValid = true;
                }
                else if (!isNumeric  && !string.IsNullOrEmpty(input))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input, please try again! ");
                }
            } while (!isValid);

            return input;
        }
    }
}
