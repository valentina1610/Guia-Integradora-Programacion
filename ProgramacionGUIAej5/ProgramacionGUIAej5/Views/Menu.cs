using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProgramacionGUIAej5.Views
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("~ LIBRARY MENU ~");
            Console.WriteLine("1. Lend book ");
            Console.WriteLine("2. Show available books");
            Console.WriteLine("3. Return book");
            Console.WriteLine("4. Update available book");
            Console.WriteLine("0. Exit");
        }
    }
}
