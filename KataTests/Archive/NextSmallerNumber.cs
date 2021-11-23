using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class NextSmallerNumberTest
    {
        [TestCase(100, ExpectedResult = -1)]
        [TestCase(1027, ExpectedResult = -1)]

        [TestCase(21, ExpectedResult = 12)]
        [TestCase(315, ExpectedResult = 153)]
        [TestCase(907, ExpectedResult = 790)]

        [TestCase(29009, ExpectedResult = 20990)]
        [TestCase(51226262651257, ExpectedResult = 51226262627551)]
        [TestCase(7311535, ExpectedResult = 7311355)]
        [TestCase(9, ExpectedResult = -1)]
        [TestCase(531, ExpectedResult = 513)]
        [TestCase(12345, ExpectedResult = -1)]
        [TestCase(441, ExpectedResult = 414)]
        [TestCase(123456798, ExpectedResult = 123456789)]
        [TestCase(1207, ExpectedResult = 1072)]
        [TestCase(59884848483559, ExpectedResult = 59884848459853)]
        [TestCase(267904464599, ExpectedResult = 267904459964)]
        public long FixedTests(long n)
        {
            return NextSmallerNumber.NextSmaller(n);
        }
    }
}
