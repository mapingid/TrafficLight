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

    public void NextLight()
    {
      switch( Phase )
      {
        case 0:

          break;
        
        case 1:
          
          break;
        
        case 2:
          
          break;
      }
      
      Phase++;
      if( Phase > 2 ) Phase = 0;
      Console.WriteLine( $"PHASE : {Phase}" );
    }
    public void Report()
    {
      Console.WriteLine( $"LAJUR A : MERAH" );
      Console.WriteLine( $"LAJUR B : HIJAU" );
      Console.WriteLine( $"LAJUR C : MERAH" );
    }

  }

}
