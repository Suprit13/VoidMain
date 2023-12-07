// API test...

using System;

namespace VoidMainAPI
{
    public sealed class TestAPI
    {
        private string builtCondition;

        public TestAPI()
        {
            builtCondition = "API constructed successfully!";
        }

        public void PrintAPIState()
        {
            Console.WriteLine(builtCondition);
        }
    }
}