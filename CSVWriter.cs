using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.AstakhovSO.Task1.V2
{
    internal class CSVWriter
    {
        private readonly string path;
        private readonly List<string[]> strings;

        public CSVWriter(string path, List<string[]> strings)
        {
            this.path = path;
            this.strings = strings;
        }

        public void WriteCSV()
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var row in strings)
                {
                    sw.WriteLine(string.Join(";", row));
                }
            }
        }
    }
}
