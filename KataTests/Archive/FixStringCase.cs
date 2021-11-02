using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class FixStringCaseTest
    {
        [TestCase("code", "code")]
        [TestCase("CODe", "CODE")]
        [TestCase("COde", "code")]
        [TestCase("Code", "code")]
        public void BasicTests(string s, string expected)
        {
            Assert.That(FixStringCase.Solve(s), Is.EqualTo(expected));
        }
    }
}
