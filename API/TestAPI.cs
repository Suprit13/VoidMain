// API test...

using System;

namespace VoidMainAPI
{
    public sealed class TestAPI
    {
        private readonly string builtCondition;
        private readonly int builtCode;

        public TestAPI()
        {
            builtCondition = "API constructed successfully!";
            builtCode = 0;
        }

        public void PrintAPIState() => Console.WriteLine($"{builtCondition}\nBuild Code: {builtCode}\n");

        public static string CheckNumberType(in int data) => CheckNumbers.CheckNumber(in data);
    }
}