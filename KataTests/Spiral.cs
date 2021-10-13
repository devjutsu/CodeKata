using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class SpiralTest
    {
        // https://www.codewars.com/kata/61559bc4ead5b1004f1aba83/train/csharp

        [Test]
        public void Test05()
        {
            BigInteger input = 5;
            BigInteger expected = 17;

            BigInteger actual = Spiral.Sum(input);

            //var z = BigInteger.Parse("584757902734057049235907840235937429075234");
            //var psst = Spiral.Sum(z);
            //var bz = BigInteger.Parse("170970902404966462328920047488181969596690166234976092377640121561715772973645152611");

            var hzzzzzzzzzzz = Enumerable.Range(5, 10)
                                            .Select(i => new { Index = i, Sum = Spiral.Sum(i) })
                                            .Select(o => new
                                            {
                                                Index = o.Index,
                                                Sum = o.Sum,
                                                Current = o.Index % 2 == 0 ? o.Index : o.Index + 1,
                                                Hz = (o.Index * o.Index) - o.Sum
                                            }).ToList();

            //Assert.AreEqual(psst, z);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test10()
        {
            BigInteger input = 10;
            BigInteger expected = 59;

            BigInteger actual = Spiral.Sum(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test1000()
        {
            BigInteger input = 1000;
            BigInteger expected = 500999;

            BigInteger actual = Spiral.Sum(input);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void TestWTF()
        {
            BigInteger input = BigInteger.Parse("301277554139032144469112633266650242748425230421529704188857370076335856939566060937256535397393617186363167227459680928440252270801114118999662762531989202412106265272169568908447569845283558063402484634814999");
            BigInteger expected = BigInteger.Parse("45384082313998722422693851298915518199333229065904212626915893470106431843783637050849216510573450398708495039524245635047539426960328612710127490071279899878498838172135172660011747994754146966059251481664488865343501331055566795539059828403256465251538696597244161039447462657734414449750257731946336917969639353005593684602899431516925320913407492221070816723343764779718111140299314901691400703976081955042112499999");
            BigInteger actual = Spiral.Sum(input);
            Assert.AreEqual(true, false);
        }
    }
}
