using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCopy
{
    public partial class Form1 : Form
    {
        List<ProgressBar> progressBars = new List<ProgressBar>();
        List<System.Threading.Timer> timers = new List<System.Threading.Timer>();
        Random random = new Random();
        Size defSize = new Size(600, 23);
        Point point = new Point(12, 41);
        bool hasWon = false;

        FibonacciNumberFinder fibonacci = new FibonacciNumberFinder();

        public Form1()
        {
            InitializeComponent();
        }

        private void SoftReset()
        {
            foreach (var item in timers)
            {
                item.Dispose();
            }
            timers.Clear();
            timers = new List<System.Threading.Timer>();
            hasWon = false;
        }

        private void HardReset()
        {
            SoftReset();
            
            foreach (var item in progressBars)
            {
                item.Value = 0;
                Controls.Remove(item);
                item.Dispose();
            }
            progressBars.Clear();
            progressBars = new List<ProgressBar>();
        }

        private void ChangeProgressBar(object? data)
        {
            if (data == null) { return; }
            ProgressBar? progressBar = data as ProgressBar;
            if (progressBar == null) { return; }
            progressBar.Value = random.Next(0, 101);
            progressBar.SetState(random.Next(1, 4));
        }

        private void AddRandomToProgressBar(object? data)
        {
            if (!hasWon)
            {
                if (data == null) { return; }
                ProgressBar? progressBar = data as ProgressBar;
                if (progressBar == null) { return; }
                int tmp = random.Next(0, 10);
                if(progressBar.Value + tmp > 100)
                {
                    progressBar.Value = 100;
                }
                else
                {
                    progressBar.Value += tmp;
                }

                if (progressBar.Value >= 100)
                {
                    hasWon = true;
                    MessageBox.Show($"{progressBar.Name} won!");
                    SoftReset();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in progressBars)
            {
                Controls.Remove(item);
            }
            timers.Clear();
            progressBars.Clear();
            point = new Point(12, 41);
            for (int i = 0; i < Int32.Parse(textBox1.Text); i++)
            {
                Form1.ActiveForm.Size = new Size(640, 90 + Int32.Parse(textBox1.Text) * 19);
                progressBars.Add(new ProgressBar());
                progressBars.ElementAt(i).Size = defSize;
                progressBars.ElementAt(i).Location = point;
                point = new Point(point.X, point.Y + 19);
                timers.Add(new System.Threading.Timer(ChangeProgressBar, progressBars.ElementAt(i), 1000, 1000));
            }
            foreach (var item in progressBars)
            {
                Controls.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HardReset();
            point = new Point(12, 41);
            for (int i = 0; i < Int32.Parse(textBox1.Text); i++)
            {
                Form1.ActiveForm.Size = new Size(640, 90 + Int32.Parse(textBox1.Text) * 19);
                progressBars.Add(new ProgressBar());
                progressBars.ElementAt(i).Size = defSize;
                progressBars.ElementAt(i).Location = point;
                progressBars.ElementAt(i).Name = $"{i + 1} horse";
                progressBars.ElementAt(i).Value = 0;
                point = new Point(point.X, point.Y + 19);
                timers.Add(new System.Threading.Timer(AddRandomToProgressBar, progressBars.ElementAt(i), 100, 100));
            }
            foreach (var item in progressBars)
            {
                Controls.Add(item);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int count = await fibonacci.CountNumbers(0, Int32.Parse(textBox1.Text));
            MessageBox.Show($"{count} numbers");
        }
    }
}
