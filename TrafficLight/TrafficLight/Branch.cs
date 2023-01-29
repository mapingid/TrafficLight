using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLight
{
  class Branch
  {
    string BranchLightColor;
    ILight redLight, yelowLight, greenLight;

    public Branch( ILight _redLight, ILight _yellowLight, ILight _greenLight )
    {
      redLight = _redLight;
      yelowLight = _yellowLight;
      greenLight = _greenLight;

    }

    public void RedOn()
    {
      redLight.TurnOn();
      greenLight.TurnOff();
      BranchLightColor = "RED";
    }
    public void GreenOn()
    {
      redLight.TurnOn();
      greenLight.TurnOff();
      BranchLightColor = "GREEN";
    }
    public void YellowOn()
    {
      redLight.TurnOff();
      yelowLight.TurnOn();
      greenLight.TurnOff();
      BranchLightColor = "YELLOW";
    }
    public string GetColor() => BranchLightColor;

  }
}
