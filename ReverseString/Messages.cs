using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    public class Messages
    {
        public static void InitialString()
        {
            Console.Write("Please enter a word or sentence: ");
        }

        public static void InvalidString()
        {
            Console.Write("Please enter a valid string, any word or sentence will do, 100 characters or less: ");
        }

        public static void HasDouble()
        {
            Console.WriteLine("The array has a double.");
        }

        public static void NoDouble()
        {
            Console.WriteLine("The array does not have a double.");
        }
    }
}
