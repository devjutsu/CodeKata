using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using KataLib;

namespace KataTests
{
    public class AsciiXshapeTest
    {
        [Test]
        public void SampleTest()
        {
            Assert.That(AsciiXshape.X(3), Is.EqualTo("■□■\n□■□\n■□■"));
            Assert.That(AsciiXshape.X(5), Is.EqualTo("■□□□■\n□■□■□\n□□■□□\n□■□■□\n■□□□■"));
        }
    }
}
