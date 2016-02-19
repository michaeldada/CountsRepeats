using Nancy;
using CountRepeatsNS.Objects;
using System.Collections.Generic;
using System;

namespace CountRepeatsNS.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {

      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/output"] = _ => {
        return "output";
        // long outputlong = long.Parse(Request.Form["number"]);
        // NumbersToWords newNumbersToWords = new NumbersToWords(outputlong);
        // string output = newNumbersToWords.Convert();
        // return View["output.cshtml", output];
      };
    }
  }
}
