using System;
using System.Collections.Generic;
using UnitTestTOTVS.Data.Models;

namespace UnitTestTOTVS.Data
{
  public interface IDataAccess
  {
    void Save(Esportista esportista);

    List<Esportista> DeserializeJson();

    Esportista RetornaRegistro(Guid id);

    void RemoveRegistro(Esportista esportista);
  }
}
