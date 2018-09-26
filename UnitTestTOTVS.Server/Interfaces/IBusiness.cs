using UnitTestTOTVS.Data.Models;

namespace UnitTestTOTVS.Server
{
  public interface IBusiness
  {
    bool Salvar(Esportista esportista, ref string motivoDeNaoSerEsportista);
  }
}
