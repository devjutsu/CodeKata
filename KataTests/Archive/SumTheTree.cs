using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KataLib;
using NUnit.Framework;

namespace KataTests
{
    internal class SumTheTreeTest
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(new TreeNode(10, new TreeNode(1), new TreeNode(2))).Returns(13).SetDescription("Simple Test");
                yield return new TestCaseData(new TreeNode(11, new TreeNode(0), new TreeNode(0, null, new TreeNode(1)))).Returns(12).SetDescription("Handles unbalanced trees");
            }
        }

        [Test, TestCaseSource("testCases")]
        public int Test(TreeNode root) =>
          SumTheTree.SumTree(root);
    }
}
