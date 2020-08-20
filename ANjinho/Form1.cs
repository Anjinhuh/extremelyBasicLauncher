using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANjinho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotaoConectar_Click(object sender, EventArgs e)
        {
            Process.Start("fivem://connect/200.9.154.118");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("chrome.exe");
        }

        private void DeletarPrefetch_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"C:\Windows\Prefetch\", true);
        }

        private void FivemClose_Click(object sender, EventArgs e)
        {
            var processoFechar = Process.GetProcessesByName("chrome.exe");
            foreach (Process opp in processoFechar)
            {
                opp.Kill();
            }
        }

        private void Conectar_Click(object sender, EventArgs e)
        {
            Process.Start("fivem://connect/200.9.154.118");
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
                    }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
