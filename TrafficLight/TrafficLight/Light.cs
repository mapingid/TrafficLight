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
    string Display();
  }

  class HandleVendorA : ILight
  {
    public string Color;
    
    public HandleVendorA(string _color)
    {
      Color = _color;
    }
    VendorA light = new VendorA();
    public void TurnOn()
    {
      light.TurnOn();
    }
    public void TurnOff()
    {
      light.TurnOff();
    }
    public string Display() => $"Color : {Color} Status : {light.Light} Vendor : Vendor A";
  }

  class HandleVendorB : ILight
  {
    public string Color;
    public HandleVendorB( string _color )
    {
      Color = _color;
    }
    VendorB light = new VendorB();
    public void TurnOn()
    {
      light.TurnLight( true );
    }
    public void TurnOff()
    {
      light.TurnLight( false );
    }
    public string Display() => $"Color : {Color} Status : {light.Light} Vendor : Vendor A";
  }



}
