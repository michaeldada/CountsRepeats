using System.Collections.Generic;
using Xunit;
namespace CountRepeatsNS.Objects
{
  public class CountRepeatsTest
  {
    [Fact]
    public void CountRepeats_twoIdenticalCharacters_true()
    {
      CountRepeats test = new CountRepeats("a", "a");
      Assert.Equal(true, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_twoDifferentCharacters_false()
    {
      CountRepeats test = new CountRepeats("a", "b");
      Assert.Equal(false, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_twoIdenticalWords_true()
    {
      CountRepeats test = new CountRepeats("apple", "apple");
      Assert.Equal(true, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_twoDifferentWords_false()
    {
      CountRepeats test = new CountRepeats("apple", "banana");
      Assert.Equal(false, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_IsAWordInAGivenPhrase_true()
    {
      CountRepeats test = new CountRepeats("apple", "an apple a day keeps the doctor away");
      Assert.Equal(true, test.RepeatCounter());
    }
  }
}
