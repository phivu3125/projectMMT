﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
namespace server
{
    static class Program
    {
        static public Socket server;
        static public Socket client;
        static public NetworkStream ns;
        static public StreamReader nr;
        static public StreamWriter nw;
        //static public void sendData(ref string s)
        //{
        //    byte[] data = new Byte[1024];
        //    data = Encoding.ASCII.GetBytes(s);
        //    client.Send(data, data.Length, SocketFlags.None);
        //}
        //static public bool receiveData(ref string s)
        //{
        //    byte[] data = new Byte[1024];
        //    //data = Encoding.ASCII.GetBytes(s);
        //    int rec = Program.client.Receive(data);
        //    if (rec == 0)
        //        return false;
        //    s = Encoding.ASCII.GetString(data, 0, rec);
        //    return true;
        //}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new server());
        }
    }
}
