using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;

namespace KataTests
{
    public class Calculator
    {
        Evaluator Evaluator { get; set; } = new Evaluator();

        [Test]
        [TestCase("33 + (395 - 95) + (((300 * 3) + 100) + (30*(0/0.5) + 100) - 100) - 33", ExpectedResult = 1300)]
        [TestCase("1-1", ExpectedResult = 0)]
        [TestCase("1+1", ExpectedResult = 2)]
        [TestCase("1 - 1", ExpectedResult = 0)]
        [TestCase("1* 1", ExpectedResult = 1)]
        [TestCase("1 /1", ExpectedResult = 1)]
        public double TestEvaluation(string expression)
        {
            return Evaluator.Evaluate(expression);
        }
    }
}
