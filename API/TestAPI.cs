// API test...

using System;

namespace VoidMainAPI
{
    public sealed class TestAPI
    {
        private readonly string buildCondition;
        private readonly int buildCode;

        public TestAPI()
        {
            buildCondition = "API constructed successfully!";
            buildCode = 0;
        }

        public void PrintAPIState() => Console.WriteLine($"{buildCondition}\nBuild Code: {buildCode}\n");

        public static string CheckNumberType(in int data) => CheckNumbers.CheckNumber(in data);
    }
}