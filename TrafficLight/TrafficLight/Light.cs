using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
  interface ILight
  {
    //agar semua class yang digunakan untuk menghandle Light
    //menggunakan standar ini
    void TurnOn();
    void TurnOff();

  }

  class HandleVendorA : ILight
  {
    VendorA light = new VendorA();
    public void TurnOn()
    {
      light.TurnOn();
    }
    public void TurnOff()
    {
      light.TurnOff();
    }
  }

  class HandleVendorB : ILight
  {
    VendorB light = new VendorB();
    public void TurnOn()
    {
      light.TurnLight( true );
    }
    public void TurnOff()
    {
      light.TurnLight( false );
    }
  }



}
