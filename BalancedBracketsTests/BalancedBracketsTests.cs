
namespace BalancedBracketsTests;
using BalancedBrackets;

[TestClass]
public class BalancedBracketsTests
{
    // TODO: Add tests to this file.

    [TestMethod]
    public void EmptyTest()
    {
        Assert.AreEqual(true, true);
    }

    [TestMethod]
    public void OnlyBracketsReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));  //just brackets should return true
    }

    [TestMethod]
    public void StringInBracketsReturnTrue() 
    { 
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[launchcode]"));  //should return true
    }


    [TestMethod]
    public void StringInsideBracketsReturnTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[code]"));
    }

    [TestMethod]
    public void BracketsBeforeStringReturnTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]Launchcode"));  
    }

    [TestMethod]
    public void DoubleBracketsStringReturnTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[Launchcode]]")); //should return true
    }

    [TestMethod]
    public void TwoPariBracketsReturnTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]")); //still equals zero so should still return true.
    }

    [TestMethod]
    public void EmptyStringReturnsTrue()
    {
        Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));  //returns true because method starts with 0 and ends with zero so even though there are no brackets it still returns true.
    }

    [TestMethod]
    public void SingleBracketWithStringReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[Launchcode"));
    }

    [TestMethod]
    public void BackwardBracketWithinStringReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]code["));
    }

    [TestMethod]
    public void SingleBracketWithinStringReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
    }

    [TestMethod]
    public void BackwardBracketInStringReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));  //should return false, so we have to update the HasBalancedBrackets method
    }

    [TestMethod]
    public void BackwardBracketsOutsideWordStringReturnsFalse()
    {
        Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]Launchcode["));
    }


}


