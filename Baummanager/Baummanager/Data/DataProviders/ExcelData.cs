using Baummanager.Model;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baummanager.Data.DataProviders
{
    class ExcelData : IData
    {
        public IEnumerable<Baum> LoadBäume(string datasource)
        {
            using (XLWorkbook wb = new XLWorkbook(datasource))
            {
                // Tabelle mit dem Namen "Bäume" ind variable wb speichern
                var ws = wb.Worksheets.FirstOrDefault(x => x.Name == "Bäume");
                if (ws != null)
                {
                    int row = 1;

                    while (ws.Row(row).Cell(1).Value != null && ws.Row(row).Cell(1).Value.ToString() != "")
                    {
                        yield return new Baum()
                        {
                            Id = int.Parse(ws.Row(row).Cell(1).Value.ToString()),
                            Art = ws.Row(row).Cell(2).Value.ToString(),
                            Gattung = Enum.Parse<Gattung>(ws.Row(row).Cell(3).Value.ToString()),
                            MaxAlter = int.Parse(ws.Row(row).Cell(4).Value.ToString()),
                            MaxSize = double.Parse(ws.Row(row).Cell(5).Value.ToString()),
                        };
                        row++;
                    }
                }
            }
        }

        public void SaveBäume(string datasource, IEnumerable<Baum> bäume)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                // Tabelle mit dem Namen "Bäume" ind variable wb speichern
                var ws = wb.Worksheets.FirstOrDefault(x => x.Name == "Bäume");
                if (ws == null) // wenn eine Tabelle gefunden wurde ist wb nicht null
                    ws = wb.AddWorksheet("Bäume"); //neues Tabelle anlegen

                for (int i = 0; i < bäume.Count(); i++) //alle bäume aus der auflistung
                {
                    ws.Row(i + 1).Cell(1).Value = bäume.ElementAt(i).Id; //id in spalte 1
                    ws.Row(i + 1).Cell(2).Value = bäume.ElementAt(i).Art; //art in spalte 2
                    ws.Row(i + 1).Cell(3).Value = bäume.ElementAt(i).Gattung; //...
                    ws.Row(i + 1).Cell(4).Value = bäume.ElementAt(i).MaxAlter;
                    ws.Row(i + 1).Cell(5).Value = bäume.ElementAt(i).MaxSize;
                }
                wb.SaveAs(datasource); //datei abspeichern
            }
        }
    }
}
