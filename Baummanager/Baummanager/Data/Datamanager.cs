using Baummanager.Model;
using System.Collections.Generic;

namespace Baummanager.Data
{
    public class Datamanager
    {
        public IData Data { get; } = new DataProviders.JsonData();

        public IEnumerable<Baum> GetBaums()
        {
            return Data.LoadBäume("baum.json");
        }

        public void SaveAll(IEnumerable<Baum> bäume)
        {
            Data.SaveBäume("baum.json", bäume);
        }

    }
}
