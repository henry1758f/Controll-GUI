Imports System.IO.Ports
Imports System.Threading

Public Class Form1
    Dim ReceiveStr As String = ""
    Dim TransmitStr As String = ""
    Dim Connect_Status As Boolean = False
    Dim com As SerialPort = Nothing
    Private t As Thread





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
        'Parity list
        ComboBox_Parity.Items.Add("None 無")
        ComboBox_Parity.Items.Add("Odd 奇同位")
        ComboBox_Parity.Items.Add("Even 偶同位")

        'Stopbit list
        ComboBox_Stopbits.Items.Add("1")
        ComboBox_Stopbits.Items.Add("1.5")
        ComboBox_Stopbits.Items.Add("2")
        'Databit List
        ComboBox_Databit.Items.Add("8 bits")
        'Initial select
        If ComboBox_Portselect.Items.Count = 0 Then
            ComboBox_Portselect.Text = "未偵測到"
            Button_Conect.Enabled = False
        Else
            ComboBox_Portselect.SelectedIndex = 0
        End If
        ComboBox_Baudrate.SelectedIndex = 2
        ComboBox_Parity.SelectedIndex = 0
        ComboBox_Stopbits.SelectedIndex = 0
        ComboBox_Databit.SelectedIndex = 0

    End Sub

    Sub SendSerialData(ByVal data As String)
        If Connect_Status = False Then
            MsgBox("尚未連線", vbExclamation, "注意")
        Else
            ' Send strings to a serial port.
            Using com As IO.Ports.SerialPort =
                        My.Computer.Ports.OpenSerialPort(ComboBox_Portselect.Text)
                com.WriteLine("BUTTON 1!")
                Thread.Sleep(20)
            End Using
        End If


    End Sub

    Function ReceiveSerialData(ByVal port As String) As String
        ' Receive strings from a serial port.
        Dim returnStr As String = ""




        Return returnStr
    End Function




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1_initial()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SendSerialData("Button1")
    End Sub

    Sub COM_setting()
        Using com As SerialPort =
                        My.Computer.Ports.OpenSerialPort(ComboBox_Portselect.Text)
            If ComboBox_Baudrate.SelectedItem = 2400 Then     'Baudrate Set
                com.BaudRate = 2400
            ElseIf ComboBox_Baudrate.SelectedItem = 4800 Then
                com.BaudRate = 4800
            ElseIf ComboBox_Baudrate.SelectedItem = 9600 Then
                com.BaudRate = 9600
            ElseIf ComboBox_Baudrate.SelectedItem = 14400 Then
                com.BaudRate = 14400
            ElseIf ComboBox_Baudrate.SelectedItem = 19200 Then
                com.BaudRate = 19200
            ElseIf ComboBox_Baudrate.SelectedItem = 28800 Then
                com.BaudRate = 28800
            ElseIf ComboBox_Baudrate.SelectedItem = 38400 Then
                com.BaudRate = 38400
            ElseIf ComboBox_Baudrate.SelectedItem = 57600 Then
                com.BaudRate = 57600
            ElseIf ComboBox_Baudrate.SelectedItem = 76800 Then
                com.BaudRate = 76800
            ElseIf ComboBox_Baudrate.SelectedItem = 115200 Then
                com.BaudRate = 115200
            End If
            If ComboBox_Parity.SelectedItem = "None 無" Then        'Parity Set
                com.Parity = Parity.None
            ElseIf ComboBox_Parity.SelectedItem = "Odd 奇同位" Then
                com.Parity = Parity.Odd
            ElseIf ComboBox_Parity.SelectedItem = "Even 偶同位" Then
                com.Parity = Parity.Even
            End If
            If ComboBox_Stopbits.SelectedItem = 1 Then      'Stopbits Set
                com.StopBits = 1
            ElseIf ComboBox_Stopbits.SelectedItem = 1.5 Then
                com.StopBits = 1.5
            ElseIf ComboBox_Stopbits.SelectedItem = 2 Then
                com.StopBits = 2
            End If
            If ComboBox_Databit.SelectedItem = "8 bits" Then          'Databits Set
                com.DataBits = 8
            End If

            ' Other Setting
            If Connect_Status = False Then
                Connect_Status = True
                Button_Conect.Text = "中斷連線"
                ComboBox_Portselect.Enabled = False
                ComboBox_Baudrate.Enabled = False
                ComboBox_Parity.Enabled = False
                ComboBox_Stopbits.Enabled = False
                ComboBox_Databit.Enabled = False
            Else
                Connect_Status = False
                Button_Conect.Text = "連線"
                If ComboBox_Portselect.Items.Count = 0 Then
                    ComboBox_Portselect.Enabled = False
                Else
                    ComboBox_Portselect.Enabled = True
                End If
                ComboBox_Parity.Enabled = True
                ComboBox_Stopbits.Enabled = True
                ComboBox_Databit.Enabled = True
            End If

        End Using

    End Sub

    Private Sub Button_Conect_Click(sender As Object, e As EventArgs) Handles Button_Conect.Click
        ' COM Port Setting

        COM_setting()

    End Sub

    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click
        RichTextBox1.Text = RichTextBox1.Text + ReceiveSerialData(ComboBox_Portselect.Text)

    End Sub
End Class
