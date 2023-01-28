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
      HandleVendorA Light1 = new HandleVendorA();
      HandleVendorB Light2 = new HandleVendorB();
      HandleVendorB Light3 = new HandleVendorB();
      HandleVendorA Light4 = new HandleVendorA();
      HandleVendorB Light5 = new HandleVendorB();
      HandleVendorB Light6 = new HandleVendorB();

      Branch BranchA = new Branch( Light1, Light2 );
      Branch BranchB = new Branch( Light3, Light4 );
      Branch BranchC = new Branch( Light5, Light6 );

      CrossRoad Pertigaan = new CrossRoad( BranchA, BranchB, BranchC );
      while( true )
      {
        Pertigaan.NextLight();
        Pertigaan.Report();
        Console.ReadLine();
      }





    }
  }
}
