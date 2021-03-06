﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Drawing.Imaging;

namespace ScreenIOShare
{
    [Serializable]
    public class Message 
    {
        public Image image { get; set; }
        public DateTime timeSent { get; set; }
        public int key { get; set; }

        public Message(Image data)
        {
            image = data;
            timeSent = DateTime.Now;
        }
    }
}
