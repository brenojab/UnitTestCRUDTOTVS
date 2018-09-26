using UnitTestTOTVS.Data;
using UnitTestTOTVS.Data.Models;

namespace UnitTestTOTVS.Server
{
  public class Business : IBusiness
  {
    private DataAccess _dataAccess;

    public DataAccess DataAccess
    {
      get
      {
        if (_dataAccess == null)
          _dataAccess = new DataAccess();

        return _dataAccess;
      }
    }

    public bool Salvar(Esportista esportista, ref string motivoDeNaoSerEsportista)
    {
      bool saved = false;

      if (EsportistaValido(esportista, ref motivoDeNaoSerEsportista))
      {
        DataAccess.Save(esportista);
        return saved = true;
      }

      return saved;
    }

    private bool EsportistaValido(Esportista esportista, ref string motivoDeNaoSerEsportista)
    {
      return EhEsportistaValido(esportista, ref motivoDeNaoSerEsportista) &&
             !EsportistaEhAnao(esportista, ref motivoDeNaoSerEsportista) &&
             !EsportistaEhGordao(esportista, ref motivoDeNaoSerEsportista) &&
             EsportistaTemIMCMinimo(esportista, ref motivoDeNaoSerEsportista); ;
    }

    private bool EhEsportistaValido(Esportista esportista, ref string motivoDeNaoSerEsportista)
    {
      bool valido = esportista is Esportista;
      motivoDeNaoSerEsportista = $"O esportista é to tipo {esportista.GetType().ToString()}";

      return valido;
    }

    private bool EsportistaEhAnao(Esportista esportista, ref string motivoDeNaoSerEsportista)
    {
      bool valido = esportista.Altura < 1.5m;
      motivoDeNaoSerEsportista = $"O esportista tem menos que 1,5m: {esportista.Altura.ToString()}";

      return valido;
    }

    private bool EsportistaEhGordao(Esportista esportista, ref string motivoDeNaoSerEsportista)
    {
      bool valido = esportista.Peso > 100;
      motivoDeNaoSerEsportista = $"O esportista tem mais de que 100 kg: {esportista.Peso.ToString()}";

      return valido;
    }

    private bool EsportistaTemIMCMinimo(Esportista esportista, ref string motivoDeNaoSerEsportista)
    {
      decimal imcValido = (decimal)new UtilServices().CalculaIMC(esportista.Altura, esportista.Peso);

      motivoDeNaoSerEsportista = $"O esportista tem IMC menor que 15: {imcValido.ToString()}";

      return imcValido > 15;
    }
  }
}
