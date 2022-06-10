using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CsharpTerminal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            serialPort1.Open();
            backgroundWorker1.RunWorkerAsync();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // key on textbox pressed, read key and transmit down serial line
            Console.WriteLine("keypress " + e.KeyChar);
            char[] data = { e.KeyChar };
            string s = new string(data);
            serialPort1.Write(s);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("background worker");
            while(true)
            {
                // check for characters received from serial port and display on textbox
                char[] data=new char[100];
                serialPort1.Read(data,0,100);
                // replace "\n" with "\r\n" for newlines in textbox
                char[] data2 = new char[200];
                int i, j;
                for (i = j = 0; i < 100; i++)
                    if(data[i]=='\n')
                        { data2[j++] = '\r'; data2[j++] = '\n'; }
                    else
                        data2[j++]=data[i];
                string sdata = new string(data2);
                textBox1.AppendText(sdata);
            }
        }
    }
}
