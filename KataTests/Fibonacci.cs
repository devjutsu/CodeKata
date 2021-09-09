using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    public class FibonacciTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(5, Fibonacci.fib(5));
            Assert.AreEqual(55, Fibonacci.fib(10));
        }
    }
}
