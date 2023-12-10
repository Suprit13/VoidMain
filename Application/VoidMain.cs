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
            api.PrintAPIState();

            List<int> list = new() {9, 2, 3, 7, 4, 2, 1, 0};
            list.Sort();

            Console.WriteLine(list.Search(3));

            // Console.Write("Input a number: ");
            // Console.WriteLine("\n" + TestAPI.CheckNumberType(Convert.ToInt32(Console.ReadLine())));

            return (int)ExitCode.ExitSuccess;
        }
    }
}