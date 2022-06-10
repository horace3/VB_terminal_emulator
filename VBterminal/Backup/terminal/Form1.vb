Public Class Form1

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Console.WriteLine("key hit" + e.KeyChar)
        SerialPort1.Write(e.KeyChar)
    End Sub

    Private Sub SerialPort1_DataReceived(ByVal sender As System.Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        'Console.WriteLine("serial port receive" + SerialPort1.ReadExisting())
        'Console.WriteLine(SerialPort1.ReadExisting())
        TextBox1.AppendText(SerialPort1.ReadExisting())
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Console.WriteLine("form1 load")
        SerialPort1.Open()
    End Sub
End Class
