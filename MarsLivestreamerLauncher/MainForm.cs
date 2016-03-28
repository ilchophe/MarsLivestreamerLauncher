using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MarsLivestreamerLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex=0;
        }

        private void Launchbutton_Click(object sender, EventArgs e)
        {
            LaunchTwitchStreamer(textBox1.Text,comboBox1.SelectedText);
        }

        private void LaunchTwitchStreamer(string url, string quality)
        {
            ProcessStartInfo p = new ProcessStartInfo("livestreamer.exe");
            p.Arguments = url + @" " + quality;
            p.UseShellExecute = true;
           // Process.Start("livestreamer.exe", ,);
             Process.Start(p);
        }
    }
}
