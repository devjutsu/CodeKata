using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class HandshakeProblemTest
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.AreEqual(1, HandshakeProblem.GetParticipants(0));
            Assert.AreEqual(2, HandshakeProblem.GetParticipants(1));
            Assert.AreEqual(3, HandshakeProblem.GetParticipants(3));
            Assert.AreEqual(4, HandshakeProblem.GetParticipants(6));
            Assert.AreEqual(5, HandshakeProblem.GetParticipants(7));
        }
    }
}
