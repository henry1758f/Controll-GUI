Imports System
Imports System.Threading
Imports System.IO
Imports System.ComponentModel

Public Class Form1
    Dim myport As Array
    Delegate Sub Settextcallback(ByVal [test] As String)
    Dim DataFlow As String
    Dim DataNow As String
    Dim ConnectStatus As Boolean
    Private MaybeEnd As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myport = IO.Ports.SerialPort.GetPortNames()
        ComboBox_PortSelect.Items.AddRange(myport)
        ComboBox_BaudSelect.Items.Add("2400")
        ComboBox_BaudSelect.Items.Add("4800")
        ComboBox_BaudSelect.Items.Add("9600")
        ComboBox_BaudSelect.Items.Add("14400")
        ComboBox_BaudSelect.Items.Add("19200")
        ComboBox_BaudSelect.Items.Add("28800")
        ComboBox_BaudSelect.Items.Add("38400")
        ComboBox_BaudSelect.Items.Add("57600")
        ComboBox_BaudSelect.Items.Add("76800")
        ComboBox_BaudSelect.Items.Add("115200")
    End Sub

    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click
        If ConnectStatus = False Then
            Try
                SerialPort1.PortName = ComboBox_PortSelect.Text
                SerialPort1.BaudRate = ComboBox_BaudSelect.Text
                Button_Connect.Text = "Disconnect"
                ComboBox_PortSelect.Enabled = False
                ComboBox_BaudSelect.Enabled = False
                ComboBox_Mode.Enabled = False
                ConnectStatus = True
                SerialPort1.Open()
            Catch ex As Exception
                MsgBox("ERROR!" + vbCrLf + ex.Message, MsgBoxStyle.Information, "Error!")
            End Try
        Else
            'myport = IO.Ports.SerialPort.GetPortNames()
            'ComboBox_PortSelect.Items.AddRange(myport)
            Try
                ConnectStatus = False
                SerialPort1.Close()
                SerialPort1.DiscardInBuffer()

                ComboBox_PortSelect.Enabled = True
                ComboBox_BaudSelect.Enabled = True
                ComboBox_Mode.Enabled = True
                Button_Connect.Text = "Connect"

            Catch ex As Exception
                MsgBox("ERROR!" + vbCrLf + ex.Message, MsgBoxStyle.Information, "Error!")
                ConnectStatus = False
                ComboBox_PortSelect.Enabled = True
                ComboBox_BaudSelect.Enabled = True
                ComboBox_Mode.Enabled = True
                Button_Connect.Text = "Connect"
            End Try

        End If

    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If ConnectStatus = True Then
            ReceiveText(SerialPort1.ReadExisting())
        End If

    End Sub
    Private Sub ReceiveText(ByVal [Text] As String)
        If Me.RichTextBox_Message.InvokeRequired Then
            Dim x As New Settextcallback(AddressOf ReceiveText)
            Me.BeginInvoke(x, New Object() {(Text)})
        Else
            If MaybeEnd = True And [Text] = "~" Then    'The DATA String End
                Me.RichTextBox_Message.Text &= [Text]
                DataFlow &= [Text]
                MaybeEnd = False
                LabelNOW.Text = DataFlow
                DataFlow = ""

            Else
                If [Text] = "$" Then                    'Maybe the DATA String End or begin
                    MaybeEnd = True
                    Me.RichTextBox_Message.Text &= [Text]
                    DataFlow &= [Text]
                Else                                    'Surely not the DATAString End
                    MaybeEnd = False
                    Me.RichTextBox_Message.Text &= [Text]
                    DataFlow &= [Text]
                End If

            End If
        End If

    End Sub
End Class
