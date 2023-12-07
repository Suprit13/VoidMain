// Main Program begins here...

using System;
using VoidMainAPI;

namespace VoidMain
{
    internal sealed class VoidMain
    {
        internal static int Main()
        {
            TestAPI api = new();

            Console.Write("Input a number: ");
            Console.WriteLine("\n" + api.CheckNumberType(Convert.ToInt32(Console.ReadLine())));

            return (int)ExitCode.ExitSuccess;
        }
    }
}