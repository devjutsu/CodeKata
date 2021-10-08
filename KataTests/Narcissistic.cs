using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class NarcissisticTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(1)
                                .Returns(true)
                                .SetDescription("1 is narcissitic");
                yield return new TestCaseData(371)
                                .Returns(true)
                                .SetDescription("371 is narcissitic");

            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(int n) => NarcissisticKata.Narcissistic(n);
    }
}
