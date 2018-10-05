using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestTOTVS.Data.Models;

namespace UnitTestTOTVS.Data.Interfaces
{
  public interface IDataServices
  {
    List<Esportista> GenerateListEsportistas();
  }
}
