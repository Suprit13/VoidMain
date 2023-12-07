// Main Program begins here...

using VoidMainAPI;

namespace VoidMain
{
    internal sealed class VoidMain
    {
        internal static int Main()
        {
            TestAPI api = new();
            api.PrintAPIState();

            return (int)ExitCode.ExitSuccess;
        }
    }
}