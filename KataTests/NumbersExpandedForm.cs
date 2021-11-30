using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class NumbersExpandedFormTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.That(NumbersExpandedForm.ExpandedForm(12), Is.EqualTo("10 + 2"));
            Assert.That(NumbersExpandedForm.ExpandedForm(42), Is.EqualTo("40 + 2"));
            Assert.That(NumbersExpandedForm.ExpandedForm(70304), Is.EqualTo("70000 + 300 + 4"));
        }
    }
}
