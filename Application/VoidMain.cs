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

            List<int> list = new() {9, 2, 3, 7, 4, 2, 1, 0, 10, 4, 41, 6, 80, 100};

            list.RemoveAt(2);
            list.RemoveAt(4);

            list[5] = list[1];

            list.Sort();

            foreach (int num in list)
                Console.Write($" {num}");

            Console.WriteLine("\n\n");

            Console.WriteLine(list.Search(4));

            Console.Write("Input a number: ");
            Console.WriteLine("\n" + TestAPI.CheckNumberType(Convert.ToInt32(Console.ReadLine())));

            return (int)ExitCode.ExitSuccess;
        }
    }
}