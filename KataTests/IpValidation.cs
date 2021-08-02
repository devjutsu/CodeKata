﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void TestCases()
        {
            Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.00"));
            Assert.AreEqual(true, Kata.is_valid_IP("0.0.0.0"));
            Assert.AreEqual(false, Kata.is_valid_IP(""));
            Assert.AreEqual(true, Kata.is_valid_IP("12.255.56.1"));
            Assert.AreEqual(true, Kata.is_valid_IP("137.255.156.100"));
            Assert.AreEqual(false, Kata.is_valid_IP("abc.def.ghi.jkl"));
            Assert.AreEqual(false, Kata.is_valid_IP("123.456.789.0"));
            Assert.AreEqual(false, Kata.is_valid_IP("12.34.56"));
            Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.7.8"));
            Assert.AreEqual(false, Kata.is_valid_IP("12.34.256.78"));
            Assert.AreEqual(false, Kata.is_valid_IP("1234.34.56"));
            Assert.AreEqual(false, Kata.is_valid_IP("pr12.34.56.78"));
            Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.78sf"));
            Assert.AreEqual(false, Kata.is_valid_IP("12.34.56 .1"));
            Assert.AreEqual(false, Kata.is_valid_IP("12.34.56.-1"));
            Assert.AreEqual(false, Kata.is_valid_IP("123.045.067.089"));
        }
    }
}
