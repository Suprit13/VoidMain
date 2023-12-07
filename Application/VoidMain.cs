// Main Program begins here...

using System;
using VoidMainAPI;

namespace VoidMain
{
    internal sealed class VoidMain
    {
        internal static int Main(string[] args)
        {
            TestAPI api = new TestAPI();
            api.PrintAPIState();

            return (int)ExitCode.ExitSuccess;
        }
    }
}