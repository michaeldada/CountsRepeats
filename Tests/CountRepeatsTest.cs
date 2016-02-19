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
  }
}
