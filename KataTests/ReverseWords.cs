using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class ReverseWordsTest
    {
        [Test]
        public void Example()
        {
            Assert.AreEqual("sihT si na !elpmaxe", ReverseThem.ReverseWords("This is an example!"));
        }
    }
}
