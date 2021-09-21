using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class ReverseStringInput
    {
        string UserInput { get; set; }
        string StringOutput { get; set; }
        //Messages messages = new Messages();

        public string GetInput()
        {
            //UserInput = Console.ReadLine();
            UserInput = "Guy".ToLower();
            if (VerifyInput(UserInput) == true)
            {
                for (int i = UserInput.Length - 1; i > -1; i--)
                {
                    StringOutput += UserInput[i];
                }
            }

            return StringOutput;
        }

        public bool VerifyInput(string input)
        {
            string testInput = input;

            while (testInput.Length > 100 || testInput == null)
            {
                Messages.InvalidString();
                return false;
            }

            return true;
        }
    }
}
