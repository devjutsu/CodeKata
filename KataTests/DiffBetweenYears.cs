using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class DiffBetweenYearsKata
    {
        [Test]
        public void SampleTest()
        {
            Assert.AreEqual(18, DiffBetweenYears.HowManyYears("1997/10/10", "2015/10/10"));
            Assert.AreEqual(25, DiffBetweenYears.HowManyYears("1990/10/10", "2015/10/10"));
            Assert.AreEqual(25, DiffBetweenYears.HowManyYears("2015/10/10", "1990/10/10"));
            Assert.AreEqual(23, DiffBetweenYears.HowManyYears("1992/10/24", "2015/10/24"));
            Assert.AreEqual(18, DiffBetweenYears.HowManyYears("2018/10/10", "2000/10/10"));
            Assert.AreEqual(0, DiffBetweenYears.HowManyYears("2000/10/10", "2000/10/10"));
        }
    }
}
