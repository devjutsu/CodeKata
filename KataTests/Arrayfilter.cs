using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class ArrayfilterTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2 })
                                             .Returns(new int[] { 2 });
                yield return new TestCaseData(new int[] { 2, 6, 8, 10 })
                                             .Returns(new int[] { 2, 6, 8, 10 });
                yield return new TestCaseData(new int[] { 12, 14, 15 })
                                             .Returns(new int[] { 12, 14 });
                yield return new TestCaseData(new int[] { 13, 15 })
                                             .Returns(new int[] { });
                yield return new TestCaseData(new int[] { 1, 3, 9 })
                                             .Returns(new int[] { });
                yield return new TestCaseData(new int[] { -1, -3, -9 })
                                             .Returns(new int[] { });
            }
        }

        [Test, TestCaseSource("testCases")]
        public int[] FixedTests(int[] numbers) => Arrayfilter.GetEvenNumbers(numbers);
    }
}
