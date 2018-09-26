using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnitTestTOTVS.Data.Models;

namespace UnitTestTOTVS.Data
{
  public class DataAccess : IDataAccess
  {
    private void SerializeClassList(List<Esportista> list)
    {
      File.WriteAllText(Constants.JSON_DB_FILENAME, JsonConvert.SerializeObject(list));
    }

    public void Save(Esportista esportista)
    {
      List<Esportista> list = DeserializeJson();

      if (list.Count > 0 && list.Exists(e => e.Id == esportista.Id))
      {
        for (int i = list.Count - 1; i >= 0; i--)
        {
          if (list[i].Id == esportista.Id)
            list[i] = esportista;
        }
      }
      else
      {
        list.Add(esportista);
      }

      SerializeClassList(list);

      //using (StreamWriter file = File.CreateText(Constants.JSON_DB_FILENAME))
      //{
      //  JsonSerializer serializer = new JsonSerializer();
      //  serializer.Serialize(file, list);
      //}
    }

    public List<Esportista> DeserializeJson()
    {
      if (File.Exists(Constants.JSON_DB_FILENAME))
        using (StreamReader r = new StreamReader(Constants.JSON_DB_FILENAME))
        {
          string json = r.ReadToEnd();
          return JsonConvert.DeserializeObject<List<Esportista>>(json);
        }

      return new List<Esportista>();
    }

    public Esportista RetornaRegistro(Guid id)
    {
      return DeserializeJson().Where(e => e.Id == id).First();
    }

    public void RemoveRegistro(Esportista esportista)
    {
      List<Esportista> list = DeserializeJson();

      if (list.Count > 0 && list.Exists(e => e.Id == esportista.Id))
      {
        list = list.Where(e => e.Id != esportista.Id).ToList();
      }

      SerializeClassList(list);
    }
  }
}
