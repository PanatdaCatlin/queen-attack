using Microsoft.VisualStudio.TestTools.UnitTesting;
using QueenAttack;

namespace QueenAttack.Tests
{
  [TestClass]
  public class QueenAttackTest
  {
    [TestMethod]
    public void InputCheck_InputIsNumber_True()
    {
      Queen testQueen = new Queen("4", "5");
      Assert.AreEqual(true, testQueen.InputCheck("4", "5"));
    }

    [TestMethod]
    public void InputCheck_InputIsNumber_False()
    {
      Queen testQueen = new Queen("4", "5");
      Assert.AreEqual(false, testQueen.InputCheck("4t", "$5"));
    }

    [TestMethod]
    public void HorizontalAttack_CanAttackHorizontally_True()
    {
      Queen testQueen = new Queen("4", "5");
      Assert.AreEqual(true, testQueen.HorizontalAttack("6", "5"));
    }

    [TestMethod]
    public void VerticalAttack_CanAttackVertically_True()
    {
      Queen testQueen = new Queen("4", "5");
      Assert.AreEqual(true, testQueen.VerticalAttack("4", "8"));
    }

    [TestMethod]
    public void DiagonalAttack_CanAttackDiagonally_True()
    {
      Queen testQueen = new Queen("4", "5");
      Assert.AreEqual(true, testQueen.DiagonalAttack("6", "7"));
    }


  }
}
