using System;
using KataLib;
using NUnit.Framework;
  
namespace Solution 
{  
  [TestFixture]
  public class SumOfMinimumsTest
  {
    [Test]
    public void MyTest()
    {
      Assert.AreEqual(26, SumOfMinimumsClass.SumOfMinimums(new int[3,5] { {1,2,3,4,5}, {5,6,7,8,9}, {20,21,34,56,100} }));
      Assert.AreEqual(9, SumOfMinimumsClass.SumOfMinimums(new int[3,5] { {7,9,8,6,2 }, {6,3,5,4,3}, {5,8,7,4,5} }));
      Assert.AreEqual(76, SumOfMinimumsClass.SumOfMinimums(new int[4,4] { {11,12,14,54}, {67,89,90,56}, {7,9,4,3}, {9,8,6,7} }));
    }
  }
}