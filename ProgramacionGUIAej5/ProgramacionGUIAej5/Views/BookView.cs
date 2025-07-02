using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej5.Models;

namespace ProgramacionGUIAej5.Views
{
    public static class BookView
    {
        public static void ShowBooks(List<Book> list)
        {
            Console.Clear();
            Console.WriteLine("--- AVAILABLE BOOKS ---");
            int index = 0;
            foreach (var i in list)
            {
                Console.WriteLine($"Book {index + 1}: ");
                Console.WriteLine($"Title: {i.Title} ~ Author: {i.Author} ~ ISBN: {i.ISBN}");
                Console.WriteLine();
                index++;
            }
        }

        public static Book CreateBook()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("--- NEW BOOK ---");

                Console.Write("Title: ");
                string title = Utils.Utils.getValidInput();

                Console.Write("Author: ");
                string author = Utils.Utils.getValidInput();

                Console.Write("ISBN(numeric): ");
                string ISBN = Utils.Utils.getValidInput(true);

                return new Book(title, author, ISBN);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR]: {ex.Message}");
                return null;
            }
            
        }
    }
}
