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
    ILight redLight, greenLight;

    public Branch( ILight _redLight, ILight _greenLight )
    {
      redLight = _redLight;
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
    public string GetColor() => BranchLightColor;

  }
}
