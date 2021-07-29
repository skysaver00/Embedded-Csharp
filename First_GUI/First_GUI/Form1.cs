﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace First_GUI
{
    public partial class stationMainForm : Form
    {
        UdpClient listen = new UdpClient(8080); //포트 번호
        IPEndPoint RemoteIP = new IPEndPoint(IPAddress.Any, 60240);

        public struct UdpState
        {
            public UdpClient u;
            public IPEndPoint e;
        }

        UdpState state = new UdpState();

        String data = "";

        public stationMainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
