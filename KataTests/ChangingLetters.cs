using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class ChangingLettersTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData("HelloWorld!").Returns("HEllOWOrld!");
                yield return new TestCaseData("Sunday").Returns("SUndAy");
            }
        }

        [Test, TestCaseSource("testCases")]
        public string Test(string s) =>
          ChangingLetters.Swap(s);
    }
}
