using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    internal class EmailObfuscatorTest
    {
		[Test]
		public void test1()
		{
			Assert.AreEqual("test [at] 123 [dot] com",
			EmailObfuscator.Obfuscate("test@123.com"));
		}
		[Test]
		public void test2()
		{
			Assert.AreEqual("Code_warrior [at] foo [dot] ac [dot] uk",
			EmailObfuscator.Obfuscate("Code_warrior@foo.ac.uk"));
		}
	}
}
