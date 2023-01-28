using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
  class Program
  {
    static void Main( string[] args )
    {

      /*
       * Phase0
       * LAJUR A : HIJAU
       * LAJUR B : MERAH
       * LAJUR C : MERAH
       * 
       * Phase1
       * LAJUR A : MERAH
       * LAJUR B : HIJAU
       * LAJUR C : MERAH
       * 
       * Phase2
       * LAJUR A : MERAH
       * LAJUR B : MERAH
       * LAJUR C : HIJAU
       */

      CrossRoad Pertigaan = new CrossRoad();
      while( true )
      {
        Pertigaan.NextLight();
        Pertigaan.Report();
        Console.ReadLine();
      }





    }
  }
}
