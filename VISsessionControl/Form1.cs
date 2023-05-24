using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VISsessionControl
{
    public partial class Form1 : Form
    {
        NotifyIcon MyIcon = new NotifyIcon();
        public Form1()
        {
            InitializeComponent();
            string yol = Application.StartupPath + @"\icon.ico";
            MyIcon.Icon = new Icon(yol);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            //foreach (var item in Process.GetProcesses())
            //{
            //    listBox1.Items.Add(item.ProcessName.ToString());
            //}
            GlobalTimer.Enabled = true;
            GlobalTimer.Interval = 1800000;
            GlobalTimer.Start();


            //System.Diagnostics.Process.Start("shutdown", "-s -f -t 0"); // bilgisayarı kapatma komutu 
            //System.Diagnostics.Process.Start("shutdown", "-l -f"); //oturumu kapatma kodları
            //System.Diagnostics.Process.Start("shutdown", "-r -f -t 0"); //bilgisayarı yeniden başlatmak için
            //System.Diagnostics.Process.Start("shutdown", "-h -f"); // bilgisayarı hazırda beklet 
        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            Process[] aas = Process.GetProcessesByName("TeamViewer");
            foreach (var proc in aas)
            {
                proc.Kill();
            }
            LocalTimer.Enabled = true;
            LocalTimer.Interval = 3000;
            LocalTimer.Start();
        }

        private void LocalTimer_Tick(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\TeamViewer\TeamViewer.exe");
            LocalTimer.Enabled = false;
            LocalTimer.Stop();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Process[] aas = Process.GetProcessesByName("TeamViewer");
        //    foreach (var proc in aas)
        //    {
        //        proc.Kill();
        //    }
        //    LocalTimer.Enabled = true;
        //    LocalTimer.Interval = 3000;
        //    LocalTimer.Start();

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Process.Start(@"C:\Program Files (x86)\TeamViewer\TeamViewer.exe");
        //}

        void MyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            MyIcon.Visible = false;
        }
                private void _btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            MyIcon.Visible = true;
            MyIcon.Text = "Kordsa QEye Session Control Programı";
            MyIcon.BalloonTipTitle = "QEye Session Control Program Çalışıyor";
            MyIcon.BalloonTipText = "Program alt köşede konumlandı.";
            MyIcon.BalloonTipIcon = ToolTipIcon.Info;
            MyIcon.ShowBalloonTip(5000);
            MyIcon.MouseDoubleClick += new MouseEventHandler(MyIcon_MouseDoubleClick);
            MyIcon.ContextMenuStrip = contextMenuStrip1;
        }

        private void gösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
