using System;

namespace UnitTestTOTVS.Server
{
  public class UtilServices : IUtilServices
  {
    public double CalculaIMC(decimal altura, decimal peso)
    {
      return (double)peso / Math.Pow((double)altura, 2);
    }
  }
}
