using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class ValidSpacingTest
    {
        [Test(Description = "Sample tests")]
        public void SampleTests()
        {
            Test(true, "Hello world");
            Test(false, " Hello world");
            Test(false, "Hello world ");
            Test(true, "Hello");
            Test(true, "Helloworld");
        }

        private void Test(bool solution, string input)
        {
            Assert.AreEqual(solution, ValidSpacingClass.ValidSpacing(input), $"Incorrect answer for input \"{input}\"");
        }
    }
}
