using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    public class DayCountTest
    {
        [Test]
        public void DefaultTests()
        {
            Day d = new Day();
            Assert.AreEqual("The day is in the past!", d.countDays(new DateTime(2016, 12, 2)));
            Assert.AreEqual("Today is the day!", d.countDays(DateTime.Now));
        }
    }
}
