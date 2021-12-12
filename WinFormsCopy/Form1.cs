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
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            System.Threading.Timer timer = new System.Threading.Timer(ChangeColor, progressBar1, 1000, 1000);
        }

        private void ChangeColor(object data)
        {
            if(data == null) { return; }
            Control control = data as Control;
            if(control == null) { return; }
            control.ForeColor = Color.Red;
        }

        private async void buttonCopy_Click(object sender, EventArgs e)
        {
            await CopyAsync();
        }

        private async Task CopyAsync()
        {
            byte[] buffer = new byte[1024 * 1024];
            string From = textBox1.Text
                , Where = textBox2.Text;

            using (FileStream source = new FileStream(From, FileMode.Open, FileAccess.Read))
            {
                long fileLength = source.Length;
                using (FileStream fs = new FileStream(Where, FileMode.CreateNew, FileAccess.Write))
                {
                    long totalBytes = 0;
                    int currentBlockSize = 0;

                    while ((currentBlockSize = source.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytes += currentBlockSize;
                        double percentage = (double)totalBytes * 100.0 / fileLength;

                        fs.Write(buffer, 0, currentBlockSize);

                        progressBar1.Value = (int)percentage;
                    }
                }
            }
        }
    }
}
