// Main Program begins here...

using System;
using VoidMainAPI;

namespace VoidMain
{
    internal sealed class VoidMain
    {
        internal static void Main(string[] args)
        {
            TestAPI api = new TestAPI();
            api.PrintAPIState();

            Environment.Exit(0);
        }
    }
}