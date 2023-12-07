// Main Program begins here...

using System;
using VoidMainAPI;

namespace VoidMain
{
  public sealed class VoidMain
  {
    public static void Main(string[] args)
    {
      TestAPI api = new TestAPI();
      api.PrintAPIState();
            
      Environment.Exit(0);
    }
  }
}