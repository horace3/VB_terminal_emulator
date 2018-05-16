' terminal emulator - in Visual Studio VB

Public Class Form1
    ' set up delegate to display data received from serial port
    Private Delegate Sub SerialDelegate(ByVal Buffer As String)
    Private adre As New SerialDelegate(AddressOf DisplayData)

    ' key pressed on terminal textbox
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Console.WriteLine("key hit" + e.KeyChar)
        If EchoOFFToolStripMenuItem.Text = "Echo ON" Then e.Handled = True ' if echo is off don't display on textbox
        If SerialPort1.IsOpen Then
            SerialPort1.Write(e.KeyChar)
        Else
            TextBox1.AppendText("No COM port open" + vbNewLine)
        End If
        Console.WriteLine("key done")
    End Sub

    ' character received from serial port
    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'TextBox1.AppendText(SerialPort1.ReadExisting())  'not thead safe use delegate
        Dim ReceivedData As String = SerialPort1.ReadExisting()
        Me.Invoke(adre, ReceivedData)     'invoke delegate
    End Sub
    ' delegate to display string received
    Private Sub DisplayData(ByVal sdata As String)
        TextBox1.AppendText(sdata)
    End Sub


    ' From is loading - scan for COM ports
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim port As Integer = 0
        Dim COMmenuitem As ToolStripMenuItem = MenuStrip1.Items.Item(1)
        Dim ports() As String = SerialPort1.GetPortNames()
        TextBox1.AppendText("The following serial ports were found:" + vbNewLine + "  ")

        ' Display each port name to the console.
        For Each port1 As String In ports 'foreach(String port In ports)
            Try
                TextBox1.AppendText("  " + port1)
                Dim item As ToolStripMenuItem = New ToolStripMenuItem(port1) ' create a new menu item
                AddHandler item.Click, AddressOf Me.COMToolStripMenuItem_Click              ' add event handler
                COMmenuitem.DropDownItems.Add(item)                                         ' add to the list of COM ports
            Catch ex As Exception
                Console.WriteLine("serial port open fail {0}", SerialPort1.PortName)
            End Try
        Next


        Console.WriteLine(" {0} COM ports found - select from COM ports menu", PortToolStripMenuItem.DropDownItems.Count)
        TextBox1.AppendText(String.Format(vbNewLine + " {0} COM ports found - select from COM ports menu",
                                           PortToolStripMenuItem.DropDownItems.Count) + vbNewLine)
        ' if no COM ports were found display message
        If PortToolStripMenuItem.DropDownItems.Count = 0 Then
            TextBox1.AppendText(vbNewLine + "No COM ports found" + vbNewLine)
        End If

    End Sub

    ' a COM port menu item has been selected
    Private Sub COMToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Console.WriteLine("item selected {0} {1}", e.ToString(), sender.ToString())
        SerialPort1.Close()
        SerialPort1.PortName = sender.ToString()
        SerialPort1.Open()
        TextBox1.AppendText("Opened Port " + sender.ToString() + " baud rate " + SerialPort1.BaudRate.ToString() + vbNewLine)
        Text = "Port " + sender.ToString() + " baud rate " + SerialPort1.BaudRate.ToString()
    End Sub

    ' a Baud rate has been sleceted
    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click, ToolStripMenuItem9.Click, ToolStripMenuItem8.Click, ToolStripMenuItem7.Click, ToolStripMenuItem6.Click, ToolStripMenuItem5.Click, ToolStripMenuItem4.Click, ToolStripMenuItem3.Click
        Console.WriteLine("item selected {0} {1}", e.ToString(), sender.ToString())
        SerialPort1.BaudRate = sender.ToString()
        TextBox1.AppendText(vbNewLine + " baud rate " + SerialPort1.BaudRate.ToString() + vbNewLine)
        Text = "Port " + SerialPort1.PortName.ToString() + " baud rate " + SerialPort1.BaudRate.ToString()
    End Sub

    ' Exit menu item has been selected
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    ' echo ON/OFF menu item has been selected
    Private Sub EchoOFFToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EchoOFFToolStripMenuItem.Click
        ' invert echo ON/OFF  display
        If EchoOFFToolStripMenuItem.Text = "Echo ON" Then
            EchoOFFToolStripMenuItem.Text = "Echo OFF"
        Else
            EchoOFFToolStripMenuItem.Text = "Echo ON"
        End If
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        SerialPort1.Close()
    End Sub
End Class
