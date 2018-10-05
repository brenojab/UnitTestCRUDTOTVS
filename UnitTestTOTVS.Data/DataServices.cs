using System;
using System.Collections.Generic;
using UnitTestTOTVS.Data.Interfaces;
using UnitTestTOTVS.Data.Models;

namespace UnitTestTOTVS.Data
{
  public static class DataServices
  {
    private static decimal GetRandomDecimal(double min, double max)
    {
      var val = new Random().NextDouble() * (max - min) + min;

      return Convert.ToDecimal(val);
    }

    public static List<Esportista> GenerateListEsportistas()
    {
      return new List<Esportista>()
      {
        new Esportista()
        {
          Id = Guid.NewGuid(),
          Altura = GetRandomDecimal(1.5, 2.0),
          Peso = GetRandomDecimal(50, 100),
          Nome = Guid.NewGuid().ToString(),
          PraticaEsportes = true,
          QuantidadeVezesSemana = new Random().Next(1,7)
        }
        ,
        new Esportista()
        {
          Id = Guid.NewGuid(),
          Altura = GetRandomDecimal(1.5, 2.0),
          Peso = GetRandomDecimal(50, 100),
          Nome = Guid.NewGuid().ToString(),
          PraticaEsportes = true,
          QuantidadeVezesSemana = new Random().Next(1,7)
        },

        new Esportista()
        {
          Id = Guid.NewGuid(),
          Altura = GetRandomDecimal(1.5, 2.0),
          Peso = GetRandomDecimal(50, 100),
          Nome = Guid.NewGuid().ToString(),
          PraticaEsportes = true,
          QuantidadeVezesSemana = new Random().Next(1,7)
        },

        new Esportista()
        {
          Id = Guid.NewGuid(),
          Altura = GetRandomDecimal(1.5, 2.0),
          Peso = GetRandomDecimal(50, 100),
          Nome = Guid.NewGuid().ToString(),
          PraticaEsportes = true,
          QuantidadeVezesSemana = new Random().Next(1,7)
        }
        ,
        new Esportista()
        {
          Id = Guid.NewGuid(),
          Altura = GetRandomDecimal(1.5, 2.0),
          Peso = GetRandomDecimal(50, 100),
          Nome = Guid.NewGuid().ToString(),
          PraticaEsportes = true,
          QuantidadeVezesSemana = new Random().Next(1,7)
        }
      };
    }
  }
}
