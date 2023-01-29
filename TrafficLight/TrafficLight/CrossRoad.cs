using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
  

  class CrossRoad
  {
    private int Phase;
    Branch BranchA, BranchB, BranchC;

    public CrossRoad( Branch _BranchA, Branch _BranchB, Branch _BranchC )
    {
      BranchA = _BranchA;
      BranchB = _BranchB;
      BranchC = _BranchC;
    }


    public void NextLight()
    {
      switch( Phase )
      {
        case 0:
          BranchA.RedOn();
          BranchB.RedOn();
          BranchC.GreenOn();
          break;

        case 1:
          BranchA.YellowOn();
          BranchB.RedOn();
          BranchC.YellowOn();
          break;

        case 2:
          BranchA.GreenOn();
          BranchB.RedOn();
          BranchC.RedOn();
          break;
        
        case 3:
          BranchA.YellowOn();
          BranchB.YellowOn();
          BranchC.RedOn();
          break;

        case 4:
          BranchA.RedOn();
          BranchB.GreenOn();
          BranchC.RedOn();
          break;

        case 5:
          BranchA.RedOn();
          BranchB.YellowOn();
          BranchC.YellowOn();
          break;



      }

      Phase++;
      if( Phase > 5 ) Phase = 0;
      Console.WriteLine( $"PHASE : {Phase}" );
    }
    public void Report()
    {
      Console.WriteLine( $"{nameof( BranchA )} : {BranchA.GetColor()}" );
      Console.WriteLine( $"{nameof( BranchB )} : {BranchB.GetColor()}" );
      Console.WriteLine( $"{nameof( BranchC )} : {BranchC.GetColor()}" );
    }

  }

}
