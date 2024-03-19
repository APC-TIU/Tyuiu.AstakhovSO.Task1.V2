using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.AstakhovSO.Task1.V2
{
    internal class CSVReader
    {
        private readonly string path;


        public CSVReader(string path)
        {
            this.path = path;
        }

        public List<string[]> ReadCSVFile()
        {
            var csvData = new List<string[]>();

            using (var reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    try
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');

                        csvData.Add(values);
                    } catch (Exception _)
                    {
                        throw new Exception("Ошибка чтения файла");
                    } 

                }
            }

            return csvData;
        }
    }
}
