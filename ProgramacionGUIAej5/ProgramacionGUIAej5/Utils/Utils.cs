using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ProgramacionGUIAej5.Utils
{
    public static class Utils
    {
        public static void ShowMsg(string msg) => Console.WriteLine(msg);

        public static string getValidInput(bool isNumeric = false, bool isEmail = false)
        {
            bool valueIsGood = false;
            string input;

            do
            {
                input = Console.ReadLine();
                if (isNumeric && double.TryParse(input, out double parsedValue) && !string.IsNullOrEmpty(input)) 
                {                                                                                               
                    valueIsGood = true;                                                                         
                }
                else if (!isNumeric && !string.IsNullOrEmpty(input) && !isEmail) 
                {                                                               
                    valueIsGood = true;
                }
                else if (!isNumeric && isEmail && !string.IsNullOrEmpty(input) && input.Contains("@") && input.Contains(".com")) 
                {                                                                                                              
                    valueIsGood = true;                                                                                        
                }
                else
                {    
                    Console.WriteLine("Invalid input, please try again");
                }
            } while (!valueIsGood);

            return input;

        }
    }
}
