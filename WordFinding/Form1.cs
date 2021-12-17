    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonFile_Click(object sender, EventArgs e)
        {
            WordFinderReport report =
                await WordFinder.WordsInFileAsync(textBoxPath.Text, textBoxString.Text);
            textBoxResult.Text = report.Report;
            labelCount.Text = $"Occurences: {report.Count}";
        }

        private async void buttonDirectory_Click(object sender, EventArgs e)
        {
            WordFinderReport report =
                await WordFinder.WordsInDirectoryAsync(textBoxPath.Text, textBoxString.Text);
            textBoxResult.Text = report.Report;
            labelCount.Text = $"Occurences: {report.Count}";
        }
    }
}
