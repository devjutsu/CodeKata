using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    public class RemoveExclamationsTest
    {
        [Test, Description("It should work for basic tests")]
    public void SampleTest()
    {
      Assert.AreEqual("Hi!", RemoveExclamations.Remove("Hi!"));
      Assert.AreEqual("Hi!!!", RemoveExclamations.Remove("Hi!!!"));
      Assert.AreEqual("Hi", RemoveExclamations.Remove("!Hi"));
      Assert.AreEqual("Hi!", RemoveExclamations.Remove("!Hi!"));
      Assert.AreEqual("Hi Hi!", RemoveExclamations.Remove("Hi! Hi!"));
      Assert.AreEqual("Hi", RemoveExclamations.Remove("Hi"));
    }
    }
}
