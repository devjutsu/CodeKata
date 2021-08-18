using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class RemoveDuplicateWords
    {
        [Test, Description("Should handle sample case")]
        public void ExampleTest()
        {
            Assert.That(RemoveDuplicateWordsKata.RemoveDuplicateWords("alpha beta beta gamma gamma gamma delta alpha beta beta gamma gamma gamma delta"), Is.EqualTo("alpha beta gamma delta"));
        }
    }
}
