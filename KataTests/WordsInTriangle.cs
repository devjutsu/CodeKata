using NUnit.Framework;
using NUnit;
using KataLib;

namespace Exercises.Level2.Tests
{
    public class WordsInTriangleTests
    {
        private readonly WordsInTriangle _wordsInTriangle = new WordsInTriangle();

        [Test]
        public void Hello()
        {
            string[] expected = new string[]
            {
                "     *",
                "    * *",
                "   *   *",
                "  *     *",
                " * home  *",
                "***********",
            };

            string[] words = new string[] { "home" };

            Assert.AreEqual(expected, _wordsInTriangle.GetWordInTriangle(words));
        }

        [Test]
        public void ABeautifulHome()
        {
            string[] expected = new string[]
            {
                "        *",
                "       * *",
                "      *   *",
                "     *     *",
                "    *       *",
                "   * a       *",
                "  * beautiful *",
                " * home        *",
                "*****************",
            };

            string[] words = new string[] { "a", "beautiful", "home" };

            Assert.AreEqual(expected, _wordsInTriangle.GetWordInTriangle(words));
        }

        [Test]
        public void SunshineiSgREAT()
        {
            string[] expected = new string[]
            {
                "         *",
                "        * *",
                "       *   *",
                "      *     *",
                "     *       *",
                "    *         *",
                "   * sunshine  *",
                "  * is          *",
                " * great         *",
                "*******************",
            };

            string[] words = new string[] { "sunshine", "is", "great" };

            Assert.AreEqual(expected, _wordsInTriangle.GetWordInTriangle(words));
        }

        [Test]
        public void A()
        {
            string[] expected = new string[]
            {
                "   *",
                "  * *",
                " * A *",
                "*******",
            };

            string[] words = new string[] { "A" };

            Assert.AreEqual(expected, _wordsInTriangle.GetWordInTriangle(words));
        }

        [Test]
        public void Empty()
        {
            string[] expected = new string[]
            {
                "  *",
                " * *",
                "*****",
            };

            string[] words = new string[] { };

            Assert.AreEqual(expected, _wordsInTriangle.GetWordInTriangle(words));
        }
    }
}
