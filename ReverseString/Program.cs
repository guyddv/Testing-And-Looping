using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseStringInput testString = new ReverseStringInput();
            Messages.InitialString();
            Console.WriteLine(testString.GetInput());

            IsDouble haveDouble = new IsDouble();
            int[] newArray = new int[] { 2, 4, 6, 8};
            haveDouble.VerifyDouble(newArray);
        }
    }
}
