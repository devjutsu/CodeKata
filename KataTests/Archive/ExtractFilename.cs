using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    [TestFixture]
    public class ExtractFilename
    {
        [Test]
        public void ExampleTests()
        {
            Assert.AreEqual("FILE_NAME.EXTENSION", FileNameExtractor.ExtractFileName("1_FILE_NAME.EXTENSION.OTHEREXTENSIONadasdassdassds34"));
            Assert.AreEqual("FILE_NAME.EXTENSION", FileNameExtractor.ExtractFileName("1231231223123131_FILE_NAME.EXTENSION.OTHEREXTENSION"));
        }
    }
}
