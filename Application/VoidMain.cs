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

            List<int> list = new() {1, 2, 3};
            list.Insert(1, 5);

            foreach(var num in list)
            {
                Console.WriteLine(num);
            }

            // Console.Write("Input a number: ");
            // Console.WriteLine("\n" + TestAPI.CheckNumberType(Convert.ToInt32(Console.ReadLine())));

            return (int)ExitCode.ExitSuccess;
        }
    }
}