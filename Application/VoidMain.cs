// Main Program begins here...

using VoidMainAPI;

namespace VoidMain
{
    internal sealed class VoidMain
    {
        internal static int Main(string[] args)
        {
            TestAPI api = new();
            api.PrintAPIState();

            return (int)ExitCode.ExitSuccess;
        }
    }
}