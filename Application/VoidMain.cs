// Main Program begins here...

using System;
using VoidMainAPI;

namespace VoidMain
{
    public sealed class VoidMain
    {
        public static void Main(string[] args)
        {
            SourceCode application = new();
            application.FunctionAPI();
            
            Environment.Exit(0);
        }
    }
}