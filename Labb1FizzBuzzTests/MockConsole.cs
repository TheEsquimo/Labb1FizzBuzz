using Labb1FizzBuzz;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1FizzBuzzTests
{
    class MockConsole : IConsole
    {
        int testIndex = 0;
        string[] testStrings = new string[]
        {
            "-1",
            "500",
            "Test Text",
            "1"
        };

        public string ReadLine()
        {
            string sendText = testStrings[testIndex];
            testIndex++;
            return sendText;
        }
    }
}
