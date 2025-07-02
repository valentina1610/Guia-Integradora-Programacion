using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej5.Models;

namespace ProgramacionGUIAej5.Views
{
    public static class LoanView
    {
        

        public static void ShowLoans(List<Loan> list)
        {
            Console.Clear();
            Console.WriteLine("--- BORROWED BOOKS ---");
            int index = 0;
            foreach (var i in list)
            {
                Console.WriteLine($"== Book {index+1} == ");
                Console.WriteLine($"User: {i.User.Name} | {i.User.Email}: ");
                Console.WriteLine($"Title: {i.Book.Title} ~ Author: {i.Book.Author} ~ ISBN: {i.Book.ISBN} ~ Date time: {i.Date}");
                Console.WriteLine();
                index++;
            }
        }
    }
}
