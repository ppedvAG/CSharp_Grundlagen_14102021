using Baummanager.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Baummanager.Data.DataProviders
{
    class JsonData : IData
    {
        public IEnumerable<Baum> LoadBäume(string datasource)
        {
            using (StreamReader sr = new StreamReader(datasource))
                return JsonSerializer.Deserialize<IEnumerable<Baum>>(sr.ReadToEnd());
        }

        public void SaveBäume(string datasource, IEnumerable<Baum> bäume)
        {
            string json = JsonSerializer.Serialize(bäume);
            File.WriteAllText(datasource, json);
        }
    }
}
