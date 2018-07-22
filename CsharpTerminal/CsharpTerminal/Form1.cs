using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace CsharpTerminal
{
    public partial class Form1 : Form
    {
        // delegate to transfer received data to TextBox
        public delegate void AddDataDelegate(String myString);
        public AddDataDelegate myDelegate;
        
        public Form1()
        {
            InitializeComponent();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();

            textBox1.AppendText("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in ports)
            {
                textBox1.AppendText("  " + port);
                ToolStripMenuItem item = new ToolStripMenuItem(port);   // create a new menu item
                item.Click += comPortsStripMenuItem_Click;  // add event handler
                comPortsStripMenuItem.DropDownItems.Add(item);  // add to the menu of COM ports
            }


            // scan for COM ports and add to menu item if found
          /*  for (int port = 0; port <= 20; port++)
				{
				serialPort1.PortName = "COM" + port.ToString();
				try
					{
					serialPort1.Open();			// attempt to open serial port
					serialPort1.BaudRate=115200;			
					textBox1.AppendText("Found " + serialPort1.PortName + "\n");
					Console.WriteLine("serial port open OK {0}", serialPort1.PortName);
					serialPort1.Close() ;														//open OK, close it
					ToolStripMenuItem item = new ToolStripMenuItem(serialPort1.PortName);	// create a new menu item
                    item.Click += comPortsStripMenuItem_Click;	// add event handler
                    comPortsStripMenuItem.DropDownItems.Add(item);	// add to the menu of COM ports
 					}
				catch ( Exception ex)
					{ Console.WriteLine("serial port open fail {0} ", serialPort1.PortName, ex); }
			}

        Console.WriteLine("COM ports found {0} ", comPortsStripMenuItem.DropDownItems.Count);
		textBox1.AppendText(String.Format("{0} COM ports found - select from COM ports menu\r\n\r\n", comPortsStripMenuItem.DropDownItems.Count));
        */
        // if no COM ports were found display message
        if(comPortsStripMenuItem.DropDownItems.Count == 0 )
           textBox1.AppendText("\r\n  No COM ports found\r\n");
        else textBox1.AppendText("\r\n  Found " + comPortsStripMenuItem.DropDownItems.Count + " COM ports \n");
        }

        // key on textbox pressed, read key and transmit down serial line
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {        
        if(echoOFFToolStripMenuItem.Text == "Echo ON") e.Handled = true; // if echo is off don't display on textbox
        if( serialPort1.IsOpen)
            serialPort1.Write(e.KeyChar.ToString());
        else
            textBox1.AppendText("No COM port open" + Environment.NewLine);
        }

     // data received from serial port - display on textbox
     private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            //textBox1.AppendText(serialPort1.ReadExisting());  // not thread safe
            string s = serialPort1.ReadExisting();
            textBox1.Invoke(this.myDelegate, new Object[] { s });
        }

     // display seral data on textbox
     public void AddDataMethod(String myString)
     {
         textBox1.AppendText(myString);
     }

     // COM port selected
     private void comPortsStripMenuItem_Click(object sender, EventArgs e)
     {
         try
         {
             Console.WriteLine("item selected {0} {1}", e.ToString(), sender.ToString());
             serialPort1.Close();
             serialPort1.PortName = sender.ToString();
             serialPort1.Open();
             textBox1.AppendText("Opened Port " + sender.ToString() + " baud rate " + serialPort1.BaudRate.ToString() + "\r\n");
             Text = "Port " + sender.ToString() + " baud rate " + serialPort1.BaudRate.ToString();
         }
         catch (Exception e1)
            //{ textBox1.AppendText("Failed to open Port " + sender.ToString() + "\r\n" + e1 + "\r\n"); }
            { textBox1.AppendText("Failed to open Port " + sender.ToString() + 
                    "\r\n   Is it already open in another program?? \r\n"); }
            // serialPort1.RtsEnable = true;
            // serialPort1.Handshake =  Handshake.RequestToSend;
        }

        // baud rate selected
        private void baudRateToolStripMenuItem_Click(object sender, EventArgs e)
     {
        Console.WriteLine("item selected {0} {1}", e.ToString(), sender.ToString());
        serialPort1.BaudRate = Convert.ToInt32(sender.ToString());
        textBox1.AppendText('\n' + " baud rate " + serialPort1.BaudRate.ToString() + '\n');
        Text = "Port " + serialPort1.PortName.ToString() + " baud rate " + serialPort1.BaudRate.ToString();

     }

     // echo selected
     private void echoONToolStripMenuItem_Click(object sender, EventArgs e)
     {
        // invert echo ON/OFF  display
        if(echoOFFToolStripMenuItem.Text == "Echo ON")
            echoOFFToolStripMenuItem.Text = "Echo OFF";
        else
            echoOFFToolStripMenuItem.Text = "Echo ON";
     }

     private void Form1_FormClosed(object sender, FormClosedEventArgs e)
     {
         serialPort1.Close();
     }

        // handshake mode selected
        private void handShakeNone(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.None;
        }

        private void handShakeRequestToSend(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.RequestToSend;
        }

        private void handShakeXonXoff(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.XOnXOff;
        }

        private void handShakeRequestXonXoff(object sender, EventArgs e)
        {
            serialPort1.Handshake = Handshake.RequestToSendXOnXOff;
        }
    }
}
