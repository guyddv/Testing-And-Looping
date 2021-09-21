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
            Console.WriteLine("Please enter a string, any word or sentence will do: ");
            UserInput = Console.ReadLine();
            VerifyInput(UserInput);
            //for (int i = UserInput.Length - 1; i > -1; i--)
            //{
            //    StringOutput += UserInput[i];
            //}

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
