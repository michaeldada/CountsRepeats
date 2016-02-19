using System.Collections.Generic;
using System;

namespace CountRepeatsNS.Objects
{
  public class CountRepeats
  {
    private string _word;
    private string _phrase;


  public CountRepeats(string word, string phrase)
  {
    _word = word;
    _phrase = phrase;
  }

  public string GetWord()
  {
    return _word;
  }

  public string GetPhrase()
  {
    return _phrase;
  }

  public bool RepeatCounter()
  {
    if(GetWord() == GetPhrase())
    {
      return true;
    }
    else
    {
      return false;
    }
  }

  }
}
