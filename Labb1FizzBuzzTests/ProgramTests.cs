using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Labb1FizzBuzz;

namespace Labb1FizzBuzzTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestFizzBuzzRun()
        {
            using (StringWriter stringWriter = new StringWriter())
            {
                Program program = new Program();
                Console.SetOut(stringWriter);
                program.FizzBuzzRun(5);
                var expected = string.Format("1{0}2{0}Fizz{0}4{0}Buzz{0}", Environment.NewLine);
                Assert.AreEqual(expected, stringWriter.ToString());
            }
        }

        [TestMethod]
        public void TestGetFizzBuzzResult()
        {
            Program program = new Program();

            Assert.AreEqual("FizzBuzz", program.GetFizzBuzzResult(15));
            Assert.AreNotEqual("FizzBuzz", program.GetFizzBuzzResult(5));

            Assert.AreEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", program.GetFizzBuzzResult(42));
            Assert.AreNotEqual("Answer to the Ultimate Question of Life, the Universe, and Everything", program.GetFizzBuzzResult(5));

            Assert.AreEqual("Fizz", program.GetFizzBuzzResult(9));
            Assert.AreNotEqual("Fizz", program.GetFizzBuzzResult(5));

            Assert.AreEqual("Buzz", program.GetFizzBuzzResult(10));
            Assert.AreNotEqual("Buzz", program.GetFizzBuzzResult(8));
        }
    }
}
