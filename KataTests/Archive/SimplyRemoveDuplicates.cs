﻿using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class SimplyRemoveDuplicatesTest
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual(new int[] { 4, 6, 3 }, SimplyRemoveDuplicates.solve(new int[] { 3, 4, 4, 3, 6, 3 }));
            Assert.AreEqual(new int[] { 1, 2, 3 }, SimplyRemoveDuplicates.solve(new int[] { 1, 2, 1, 2, 1, 2, 3 }));
            Assert.AreEqual(new int[] { 1, 2, 3, 4 }, SimplyRemoveDuplicates.solve(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(new int[] { 4, 5, 2, 1 }, SimplyRemoveDuplicates.solve(new int[] { 1, 1, 4, 5, 1, 2, 1 }));
        }
    }
}
