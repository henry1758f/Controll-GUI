Imports System.IO.Ports

Public Class Form1
    Dim ReceiveStr As String = ""
    Dim TransmitStr As String = ""

    Sub Form1_initial()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox_Portselect.Items.Add(sp)
        Next
        'Baudrate list
        ComboBox_Baudrate.Items.Add("2400")
        ComboBox_Baudrate.Items.Add("4800")
        ComboBox_Baudrate.Items.Add("9600")
        ComboBox_Baudrate.Items.Add("14400")
        ComboBox_Baudrate.Items.Add("19200")
        ComboBox_Baudrate.Items.Add("28800")
        ComboBox_Baudrate.Items.Add("38400")
        ComboBox_Baudrate.Items.Add("57600")
        ComboBox_Baudrate.Items.Add("76800")
        ComboBox_Baudrate.Items.Add("115200")
        ComboBox_Baudrate.Items.Add("Auto")
        'Parity list
        ComboBox_Parity.Items.Add("None 無")
        ComboBox_Parity.Items.Add("Odd 奇同位")
        ComboBox_Parity.Items.Add("Even 偶同位")
        'Siopbit list
        ComboBox_Stopbits.Items.Add("0")
        ComboBox_Stopbits.Items.Add("1")
        ComboBox_Stopbits.Items.Add("2")
        'Databit List
        ComboBox_Databit.Items.Add("8 bits")
        'Initial select



    End Sub


    Sub GetSerialPortNames()
        ' Show all available COM ports.
        For Each sp As String In My.Computer.Ports.SerialPortNames
            ComboBox_Portselect.Items.Add(sp)
        Next

        Dim mySerialPort As New SerialPort("COM3")

        mySerialPort.BaudRate = 9600
        mySerialPort.Parity = Parity.None
        mySerialPort.StopBits = StopBits.One
        mySerialPort.DataBits = 8
        mySerialPort.Handshake = Handshake.None
        mySerialPort.RtsEnable = True

    End Sub

    Sub SendSerialData(ByVal data As String)
        ' Send strings to a serial port.
        Using com3 As IO.Ports.SerialPort =
            My.Computer.Ports.OpenSerialPort("COM3")
            com3.WriteLine(data)
        End Using
    End Sub

    Function ReceiveSerialData(ByVal port As String) As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""

        Dim com As IO.Ports.SerialPort = Nothing
        Try
            com = My.Computer.Ports.OpenSerialPort(port)
            com.ReadTimeout = 10000
            Do
                Dim Incoming As String = com.ReadLine()
                If Incoming Is Nothing Then
                    Exit Do
                Else
                    returnStr &= Incoming & vbCrLf
                End If
            Loop
        Catch ex As TimeoutException
            returnStr = "Error: Serial Port read timed out."
        Finally
            If com IsNot Nothing Then com.Close()
        End Try

        Return returnStr
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1_initial()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendSerialData("Button1")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
