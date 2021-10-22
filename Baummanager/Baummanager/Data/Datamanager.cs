using Baummanager.Model;
using System.Collections.Generic;

namespace Baummanager.Data
{
    public class Datamanager
    {
        public IData Data { get; }
        public string Datasource { get; }

        public Datamanager(IData data, string datasource) //dependency injection goes into here
        {
            Data = data;
            Datasource = datasource;
        }

        public IEnumerable<Baum> GetBaums()
        {
            return Data.LoadBäume(Datasource);
        }

        public void SaveAll(IEnumerable<Baum> bäume)
        {
            Data.SaveBäume(Datasource, bäume);
        }

    }
}
