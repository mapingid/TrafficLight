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
      HandleVendorB Light7 = new HandleVendorB();
      HandleVendorB Light8 = new HandleVendorB();
      HandleVendorB Light9 = new HandleVendorB();

      Branch BranchA = new Branch( Light1, Light2, Light3  );
      Branch BranchB = new Branch( Light4, Light5, Light6 );
      Branch BranchC = new Branch( Light7, Light8, Light9 );

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
