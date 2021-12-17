using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinding
{
    public class WordFinderReport
    {
        public int Count { get; set; }
        public string Report { get; set; }

        public WordFinderReport(int count, string report)
        {
            Count = count;
            Report = report;
        }
        public WordFinderReport(int count, FileInfo file)
        {
            Count = count;
            Report = $"File name: {file.Name};\r\n" +
                $"File path: {file.FullName};\r\n" +
                $"Word count: {count};\r\n\r\n";
        }

        public static WordFinderReport operator +(WordFinderReport left, WordFinderReport right)
        {
            return new WordFinderReport(left.Count + right.Count, left.Report + right.Report);
        } 
    }
}
