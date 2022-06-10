namespace CsharpTerminal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comPortsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baudRateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.echoONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.echoOFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handshakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handshakeRequestToSendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handshakeXonXoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handshakeRequestToSendXOnXOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(801, 462);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.PortName = "COM4";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitStripMenuItem,
            this.comPortsStripMenuItem,
            this.baudRateToolStripMenuItem,
            this.echoONToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitStripMenuItem
            // 
            this.exitStripMenuItem.Name = "exitStripMenuItem";
            this.exitStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitStripMenuItem.Text = "Exit";
            // 
            // comPortsStripMenuItem
            // 
            this.comPortsStripMenuItem.Name = "comPortsStripMenuItem";
            this.comPortsStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.comPortsStripMenuItem.Text = "COM Ports";
            // 
            // baudRateToolStripMenuItem
            // 
            this.baudRateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9});
            this.baudRateToolStripMenuItem.Name = "baudRateToolStripMenuItem";
            this.baudRateToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.baudRateToolStripMenuItem.Text = "Baud Rate";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem2.Text = "1200";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem3.Text = "2400";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem4.Text = "4800";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem5.Text = "9600";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem6.Text = "19200";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem7.Text = "38400";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem8.Text = "56700";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(110, 22);
            this.toolStripMenuItem9.Text = "115200";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.baudRateToolStripMenuItem_Click);
            // 
            // echoONToolStripMenuItem
            // 
            this.echoONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.echoOFFToolStripMenuItem,
            this.handshakeToolStripMenuItem,
            this.handshakeRequestToSendToolStripMenuItem,
            this.handshakeXonXoffToolStripMenuItem,
            this.handshakeRequestToSendXOnXOffToolStripMenuItem});
            this.echoONToolStripMenuItem.Name = "echoONToolStripMenuItem";
            this.echoONToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.echoONToolStripMenuItem.Text = "Settings";
            // 
            // echoOFFToolStripMenuItem
            // 
            this.echoOFFToolStripMenuItem.Name = "echoOFFToolStripMenuItem";
            this.echoOFFToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.echoOFFToolStripMenuItem.Text = "Echo OFF";
            this.echoOFFToolStripMenuItem.Click += new System.EventHandler(this.echoONToolStripMenuItem_Click);
            // 
            // handshakeToolStripMenuItem
            // 
            this.handshakeToolStripMenuItem.Name = "handshakeToolStripMenuItem";
            this.handshakeToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.handshakeToolStripMenuItem.Text = "Handshake None";
            this.handshakeToolStripMenuItem.Click += new System.EventHandler(this.handShakeNone);
            // 
            // handshakeRequestToSendToolStripMenuItem
            // 
            this.handshakeRequestToSendToolStripMenuItem.Name = "handshakeRequestToSendToolStripMenuItem";
            this.handshakeRequestToSendToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.handshakeRequestToSendToolStripMenuItem.Text = "Handshake RequestToSend";
            this.handshakeRequestToSendToolStripMenuItem.Click += new System.EventHandler(this.handShakeRequestToSend);
            // 
            // handshakeXonXoffToolStripMenuItem
            // 
            this.handshakeXonXoffToolStripMenuItem.Name = "handshakeXonXoffToolStripMenuItem";
            this.handshakeXonXoffToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.handshakeXonXoffToolStripMenuItem.Text = "Handshake Xon/Xoff";
            this.handshakeXonXoffToolStripMenuItem.Click += new System.EventHandler(this.handShakeXonXoff);
            // 
            // handshakeRequestToSendXOnXOffToolStripMenuItem
            // 
            this.handshakeRequestToSendXOnXOffToolStripMenuItem.Name = "handshakeRequestToSendXOnXOffToolStripMenuItem";
            this.handshakeRequestToSendXOnXOffToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.handshakeRequestToSendXOnXOffToolStripMenuItem.Text = "Handshake RequestToSendXOnXOff";
            this.handshakeRequestToSendXOnXOffToolStripMenuItem.Click += new System.EventHandler(this.handShakeRequestXonXoff);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 500);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comPortsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baudRateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem echoONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem echoOFFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handshakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handshakeRequestToSendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handshakeXonXoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handshakeRequestToSendXOnXOffToolStripMenuItem;
    }
}

