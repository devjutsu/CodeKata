using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    public class CureCancerTest
    {
        [Test]
        public void TestSomething1()
        {
            char[][] body =
            {
            "thisIsAsmallerPerson".ToCharArray(),
            "thisIsAsmallerPerson".ToCharArray(),
            "thisIsAsmallerPerson".ToCharArray(),
            "thisssAsmallerPerson".ToCharArray()
        };
            int[] answer = CureCancer.MutationLocation(body);
            Assert.AreEqual(new int[] { 3, 4 }, answer);
        }
        [Test]
        public void TestSomething2()
        {
            char[][] body =
            {
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuff1thinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray(),
            "someGreaTstuffIthinkThisIs".ToCharArray()
        };
            int[] answer = CureCancer.MutationLocation(body);
            Assert.AreEqual(new int[] { 9, 14 }, answer);
        }
    }
}
