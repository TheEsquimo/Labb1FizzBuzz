using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1FizzBuzz
{
    class ReadConsole : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
