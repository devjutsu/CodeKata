using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class DigitalizeTest
    {
		[Test]
		public void Test()
		{
			Assert.AreEqual(new int[] { 1, 2, 3 }, Digitalize.digitize(123));
			Assert.AreEqual(new int[] { 1 }, Digitalize.digitize(1));
			Assert.AreEqual(new int[] { 0 }, Digitalize.digitize(0));
			Assert.AreEqual(new int[] { 1, 2, 3, 0 }, Digitalize.digitize(1230));
			Assert.AreEqual(new int[] { 8, 6, 7, 5, 3, 0, 9 }, Digitalize.digitize(8675309));
		}
	}
}
