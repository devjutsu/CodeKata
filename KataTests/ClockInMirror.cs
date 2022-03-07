﻿using KataLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataTests
{
    internal class ClockInMirrorTest
    {
        [Test]
        public void FirstTest()
        {
            StringAssert.AreEqualIgnoringCase("06:35", ClockInMirror.WhatIsTheTime("05:25"));
        }

        [Test]
        public void SecondTest()
        {
            StringAssert.AreEqualIgnoringCase("11:59", ClockInMirror.WhatIsTheTime("12:01"));
        }

        [Test]
        public void ThirdTest()
        {
            StringAssert.AreEqualIgnoringCase("12:02", ClockInMirror.WhatIsTheTime("11:58"));
        }

        [Test]
        public void FourhTest()
        {
            StringAssert.AreEqualIgnoringCase("12:00", ClockInMirror.WhatIsTheTime("12:00"));
        }

        [Test]
        public void FifthTest()
        {
            StringAssert.AreEqualIgnoringCase("02:00", ClockInMirror.WhatIsTheTime("10:00"));
        }
    }
}
