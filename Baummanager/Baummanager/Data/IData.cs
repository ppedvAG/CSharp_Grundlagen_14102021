using Baummanager.Model;
using System.Collections.Generic;

namespace Baummanager.Data
{
    public interface IData
    {
        IEnumerable<Baum> LoadBäume(string datasource);

        void SaveBäume(string datasource, IEnumerable<Baum> bäume);
    }
}
