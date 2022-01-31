using System;
using KataLib;
using NUnit.Framework;

namespace Solution
{
    [TestFixture]
    public class MorseCodeDecoderTest
    {
        [Test]
        public void MorseCodeDecoderBasicTest_1()
        {
            try
            {
                string input = ".... . -.--   .--- ..- -.. .";
                string expected = "HEY JUDE";

                string actual = MorseCodeDecoder.Decode(input);

                Assert.AreEqual(expected, actual);

                Assert.AreEqual("E", MorseCodeDecoder.Decode("."));

                Assert.AreEqual("SOS", MorseCodeDecoder.Decode("...---..."));
            }
            catch (Exception ex)
            {
                Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
            }
        }
    }
}