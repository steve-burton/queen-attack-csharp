using Nancy;
using System.Collections;
using QueenAttack.Objects;

namespace QueenAttack
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] =_=>
      {
        return View["index.cshtml"];
      };
      Get["/result"] =_=>
      {
        int QueenXCoordinate = int.Parse(Request.Query["queen-x"]);
        int QueenYCoordinate = int.Parse(Request.Query["queen-y"]);
        int TargetXCoordinate = int.Parse(Request.Query["target-x"]);
        int TargetYCoordinate = int.Parse(Request.Query["target-y"]);
        Queen newQueen = new Queen (QueenXCoordinate, QueenYCoordinate);
        bool result = newQueen.CanAttack(TargetXCoordinate, TargetYCoordinate);
        return View["index.cshtml", result];
      };
    }
  }
}
