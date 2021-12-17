using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordFinding
{
    public static class WordFinder
    {
        public static async Task<WordFinderReport> WordsInFileAsync(string path, string str)
        {
            string line;
            line = await File.ReadAllTextAsync(path);
            string[] lines = line.Split(' ', '\n', '.', ',', '\r', '?', '!');
            return new WordFinderReport(lines.Where(l => l == str).Count(), new FileInfo(path));
        }

        public static async Task<WordFinderReport> WordsInDirectoryAsync(string path, string str)
        {
            WordFinderReport report = new WordFinderReport(0, "");
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (var item in dir.GetFiles())
            {
                report += await WordsInFileAsync(item.FullName, str);
            }
            foreach (var item in dir.GetDirectories())
            {
                report += await WordsInDirectoryAsync(item.FullName, str);
            }
            return report;
        }
    }
}
