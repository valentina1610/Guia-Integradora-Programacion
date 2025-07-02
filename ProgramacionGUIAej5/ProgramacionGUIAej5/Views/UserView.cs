using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionGUIAej5.Models;

namespace ProgramacionGUIAej5.Views
{
    public static class UserView
    {
        public static User AddUser()
        {
            Console.Clear();
            try
            {
                Console.Write("- LOAD USER -");

                Console.Write("Full name: ");
                string name = Utils.Utils.getValidInput();

                Console.Write("Email: ");
                string email = Utils.Utils.getValidInput(false, true);

                return new User(name, email);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR]: {ex.Message}");
                return null;
            }
        }
    }
}
