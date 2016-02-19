using System.Collections.Generic;
using Xunit;
namespace CountRepeatsNS.Objects
{
  public class CountRepeatsTest
  {
    [Fact]
    public void CountRepeats_twoIdenticalCharacters_1()
    {
      CountRepeats test = new CountRepeats("a", "a");
      Assert.Equal(1, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_twoDifferentCharacters_0()
    {
      CountRepeats test = new CountRepeats("a", "b");
      Assert.Equal(0, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_twoIdenticalWords_1()
    {
      CountRepeats test = new CountRepeats("apple", "apple");
      Assert.Equal(1, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_twoDifferentWords_0()
    {
      CountRepeats test = new CountRepeats("apple", "banana");
      Assert.Equal(0, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_IsAWordInAGivenPhrase_1()
    {
      CountRepeats test = new CountRepeats("apple", "an apple a day keeps the doctor away");
      Assert.Equal(1, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_OnlyWholeInstancesOfWords_1()
    {
      CountRepeats test = new CountRepeats("cat", "I will walk my cat to the cathedral");
      Assert.Equal(1, test.RepeatCounter());
    }
    [Fact]
    public void CountRepeats_IfWordNeverExistsInPhrase_0()
    {
      CountRepeats test = new CountRepeats("cat", "I will walk my dog to the cathedral");
      Assert.Equal(0, test.RepeatCounter());
    }
  }
}
