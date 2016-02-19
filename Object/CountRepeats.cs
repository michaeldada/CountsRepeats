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

  public int RepeatCounter()
  {
    int Counter = 0;
    string[] phrase = GetPhrase().Split(' ');
    foreach(string word in phrase)
    {
      if(word.ToLower() == GetWord().ToLower())
      {
        Counter++;
      }
    }
    return Counter;
  }

  }
}
