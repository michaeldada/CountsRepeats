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

        CountRepeats test = new CountRepeats(Request.Form["word"], Request.Form["phrase"]);
        int output = test.RepeatCounter();
        
        return View["output.cshtml", output];
      };
    }
  }
}
