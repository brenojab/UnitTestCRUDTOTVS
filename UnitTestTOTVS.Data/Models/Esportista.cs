using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestTOTVS.Data.Models
{
  public class Esportista : Pessoa
  {
    public bool PraticaEsportes { get; set; }
    public int QuantidadeVezesSemana { get; set; }
  }
}
