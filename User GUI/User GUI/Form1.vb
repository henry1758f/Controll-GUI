Imports System
Imports System.Threading
Imports System.IO
Imports System.ComponentModel
Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Form1
    Dim myport As Array
    Delegate Sub Settextcallback(ByVal [test] As String)
    Dim DataFlow As String
    Dim DataNow As String
    Dim ConnectStatus As Boolean        'SerialPort1 Connect status 1:connected; 2:disconnected
    Private MaybeEnd As Boolean         'The data flow string mabye end
    Dim VLight As Boolean               'The lights on vehicle
    Dim Connect_Driver As Boolean       'The Connect Status to Driver , Set 1 Before Timer_DriverConnectionCheck_Tick
    Dim retrying_num As Integer         'Interger of counting the retrying times of sending '0'

    Dim CAMERA As VideoCaptureDevice    'Video Camera
    Dim bmp As Bitmap

    Dim msg_FaildConnecton As String = " FAILED CONNECTION! "
    Dim msg_ConnectionNOTYET As String = "You haven't connect to the Transmit Device !" + vbCrLf + "Please check your serial port setting and click the CONNECT button."

    Dim Connect_Buoy As Boolean     '

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
        PictureBox3.BackgroundImage = PictureBox2.Image
        'MakeTransparent()

    End Sub

    '*************************************************************
    Private Sub ToolStripStatusLabel_DriverConnection(ByVal type)
        If type = 0 Then
            ToolStripStatusLabel2.BackColor = Color.Red
            ToolStripStatusLabel2.ForeColor = Color.White
            ToolStripStatusLabel2.Text = "Disconnected"
            ToolStripStatusLabel_BuoyConnection(0)
            ToolStripStatusLabel_VehicleConnection(0)
        ElseIf type = 1 Then
            ToolStripStatusLabel2.BackColor = Color.Gray
            ToolStripStatusLabel2.ForeColor = Color.Black
            ToolStripStatusLabel2.Text = "Connected"
        ElseIf type = 2 Then
            ToolStripStatusLabel2.BackColor = Color.Yellow
            ToolStripStatusLabel2.ForeColor = Color.Black
            ToolStripStatusLabel2.Text = "Lost Conection! Retrying...(" + retrying_num.ToString + ") "
        End If

    End Sub

    Private Sub ToolStripStatusLabel_BuoyConnection(ByVal type)
        If type = 0 Then
            ToolStripStatusLabel4.BackColor = Color.Red
            ToolStripStatusLabel4.ForeColor = Color.White
            ToolStripStatusLabel4.Text = "Disconnected"
            ToolStripStatusLabel_VehicleConnection(0)
        ElseIf type = 1 Then
            ToolStripStatusLabel4.BackColor = Color.Gray
            ToolStripStatusLabel4.ForeColor = Color.Black
            ToolStripStatusLabel4.Text = "Connected"
        ElseIf type = 2 Then
            ToolStripStatusLabel4.BackColor = Color.Yellow
            ToolStripStatusLabel4.ForeColor = Color.Black
            ToolStripStatusLabel4.Text = "Lost Conection! Retrying...(" + retrying_num.ToString + ") "
        End If

    End Sub
    Private Sub ToolStripStatusLabel_VehicleConnection(ByVal type)
        If type = 0 Then
            ToolStripStatusLabel6.BackColor = Color.Red
            ToolStripStatusLabel6.ForeColor = Color.White
            ToolStripStatusLabel6.Text = "Disconnected"
        ElseIf type = 1 Then
            ToolStripStatusLabel6.BackColor = Color.Gray
            ToolStripStatusLabel6.ForeColor = Color.Black
            ToolStripStatusLabel6.Text = "Connected"
        ElseIf type = 2 Then
            ToolStripStatusLabel6.BackColor = Color.Yellow
            ToolStripStatusLabel6.ForeColor = Color.Black
            ToolStripStatusLabel6.Text = "Lost Conection! Retrying...(" + retrying_num.ToString + ") "
        End If

    End Sub


    '************************** About Connection to ReceiveDriver
    Private Sub ComboBox_PortSelect_Click(sender As Object, e As EventArgs) Handles ComboBox_PortSelect.Click
        myport = IO.Ports.SerialPort.GetPortNames()
        ComboBox_PortSelect.Items.Clear()
        ComboBox_PortSelect.Items.AddRange(myport)
    End Sub
    Private Sub SerialPortCloseProcess()        ' Processing of Closing the Serial Port
        Try
            ConnectStatus = False

            SerialPort1.DiscardInBuffer()
            SerialPort1.Close()
            ComboBox_PortSelect.Enabled = True
            ComboBox_BaudSelect.Enabled = True
            ComboBox_Mode.Enabled = True
            Button_Connect.Text = "Connect"
            Timer_DriverConnectionCheck.Enabled = False
            Timer_BuoyConnectionCheck.Enabled = False
            ToolStripStatusLabel_DriverConnection(0)
            ToolStripStatusLabel_BuoyConnection(0)
        Catch ex As Exception
            MsgBox("CAUTION!" + vbCrLf + ex.Message, MsgBoxStyle.Information, "CAUTION!")
            ConnectStatus = False
            ComboBox_PortSelect.Enabled = True
            ComboBox_BaudSelect.Enabled = True
            ComboBox_Mode.Enabled = True
            Button_Connect.Text = "Connect"
            RichTextBox_Message.Text = ""
            Timer_DriverConnectionCheck.Enabled = False
            Timer_BuoyConnectionCheck.Enabled = False
        End Try
    End Sub
    Private Sub SerialPortOpenProcess()         ' Processing of Opening the Serial Port
        Try
            SerialPort1.PortName = ComboBox_PortSelect.Text
            SerialPort1.BaudRate = ComboBox_BaudSelect.Text
            SerialPort1.Open()
            Button_Connect.Text = "Disconnect"
            ComboBox_PortSelect.Enabled = False
            ComboBox_BaudSelect.Enabled = False
            ComboBox_Mode.Enabled = False

            ConnectStatus = True
            Timer_DriverConnectionCheck.Enabled = True

            SerialPort1.Write("0")
        Catch ex As Exception
            MsgBox("ERROR!" + vbCrLf + ex.Message, MsgBoxStyle.Information, "Error!")
        End Try

    End Sub
    Private Sub Button_Connect_Click(sender As Object, e As EventArgs) Handles Button_Connect.Click

        If ConnectStatus = False Then                       ' If we haven't Open Serial Port...
            SerialPortOpenProcess()         ' Processing of Opening the Serial Port
        Else                                                ' If we have already opened serial port ....
            SerialPortCloseProcess()        ' Processing of Closing the Serial Port
        End If

    End Sub

    Private Sub Timer_DriverConnectionCheck_Tick(sender As Object, e As EventArgs) Handles Timer_DriverConnectionCheck.Tick
        If Connect_Driver = True Then
            Connect_Driver = False                  'The Connect Status to Driver , Set 1 Before Timer_DriverConnectionCheck_Tick
            retrying_num = 0
            Timer_DriverConnectionCheck.Interval = 5000
            ToolStripStatusLabel_DriverConnection(1)
        Else
            Connect_Driver = False                  'The Connect Status to Driver , Set 1 Before Timer_DriverConnectionCheck_Tick
            retrying_num += 1
            ToolStripStatusLabel_DriverConnection(2)
            Timer_DriverConnectionCheck.Interval = 2000

        End If
        Try
            SerialPort1.Write("0")

        Catch ex As Exception                           ' Serial Port didn't work!
            ToolStripStatusLabel_DriverConnection(0)
            LabelNOW.Text = ""
            SerialPortCloseProcess()
        End Try

    End Sub
    '***************************************************************************
    '************************** About Connection to Buoy
    Private Sub Timer_BuoyConnectionCheck_Tick(sender As Object, e As EventArgs) Handles Timer_BuoyConnectionCheck.Tick
        If Connect_Buoy = True Then
            ToolStripStatusLabel_BuoyConnection(1)
            Connect_Buoy = False
        Else
            If Connect_Driver = True Then
                ToolStripStatusLabel_BuoyConnection(2)
            Else
                ToolStripStatusLabel_BuoyConnection(0)
            End If

        End If
    End Sub
    '***************************************************************************
    '************************** About Serial Port Receive
    Private Sub SerialPort1_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        If ConnectStatus = True Then
            ReceiveText(SerialPort1.ReadExisting())
        End If

    End Sub
    Private Sub ReceiveText(ByVal [Text] As String)

        'If Me.RichTextBox_Message.InvokeRequired Then
        '    Dim x As New Settextcallback(AddressOf ReceiveText)
        '    Me.BeginInvoke(x, New Object() {([Text])})
        '    Me.DataFlow &= [Text]
        'Else
        '    Me.RichTextBox_Message.Text &= [Text]
        '    Me.DataFlow &= [Text]
        'End If

        If Me.Label_DATAreceive.InvokeRequired Then
            Dim x As New Settextcallback(AddressOf ReceiveText)
            Me.BeginInvoke(x, New Object() {([Text])})
            Me.DataFlow &= [Text]
        Else
            Me.Label_DATAreceive.Text &= [Text]
            Me.DataFlow &= [Text]
        End If
    End Sub

    '***************************************************
    '************************** About Message String Processing
    Private Sub Label_DATAreceive_TextChanged(sender As Object, e As EventArgs) Handles Label_DATAreceive.TextChanged
        If Label_DATAreceive.Text.EndsWith("$~") Then
            LabelNOW.Text = ""
            LabelNOW.Text = Label_DATAreceive.Text
            RichTextBox_MessageFlow.Text = Label_DATAreceive.Text + vbCrLf + RichTextBox_MessageFlow.Text
            Label_DATAreceive.Text = ""
            Connect_Driver = True
        End If
    End Sub
    Private Sub LabelNOW_TextChanged(sender As Object, e As EventArgs) Handles LabelNOW.TextChanged
        If LabelNOW.Text.Contains("$DRIVER CONNECTED,1$~") Then
            ToolStripStatusLabel_DriverConnection(1)
            Connect_Driver = True
        End If
        If LabelNOW.Text.Contains("$BUOY_CONNECTED$~") Then
            Connect_Buoy = True
            If Timer_BuoyConnectionCheck.Enabled = False Then
                Timer_BuoyConnectionCheck.Enabled = True
            End If
            ToolStripStatusLabel_BuoyConnection(1)
        End If
    End Sub
    '********************************************************
    '************************* About Video Connection and setting
    Private Sub Button_VideoSet_Click(sender As Object, e As EventArgs) Handles Button_VideoSet.Click
        Dim Camera1 As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If Camera1.ShowDialog() = DialogResult.OK Then
            CAMERA = Camera1.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()
        End If
    End Sub
    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    '************************************************************

    '************************ About Activity after closed the app
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            CAMERA.Stop()
            SerialPort1.Close()
        Catch ex As Exception

        End Try
    End Sub

    '***********************************************************

    Private Sub PictureBox2_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox2.Paint
        'PictureBox3.BackgroundImage = PictureBox2.Image
    End Sub

    Private Sub PictureBox2_LoadCompleted(sender As Object, e As AsyncCompletedEventArgs) Handles PictureBox2.LoadCompleted
        PictureBox3.BackgroundImage = PictureBox2.Image
    End Sub

    Private Sub TextBoxLatitude_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Latitude.TextChanged
        PictureBox2.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?maptype=satellite&center=" + TextBox_Latitude.Text + "," + TextBox_Lontitude.Text + "&zoom=" + TextBox_MapZoom.Text + "&size=511x396&key=AIzaSyBDNQ2wZ3Lt73qKvn6lfzztrsc_X7ixBdM"
    End Sub

    Private Sub TextBox_Lontitude_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Lontitude.TextChanged
        PictureBox2.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?maptype=satellite&center=" + TextBox_Latitude.Text + "," + TextBox_Lontitude.Text + "&zoom=" + TextBox_MapZoom.Text + "&size=511x396&key=AIzaSyBDNQ2wZ3Lt73qKvn6lfzztrsc_X7ixBdM"
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseClick
        TextBox_MapZoom.Text = TextBox_MapZoom.Text + 1
        ' PictureBox2.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?maptype=satellite&center=" + TextBox_Latitude.Text + "," + TextBox_Lontitude.Text + "&zoom=" + TextBox_MapZoom.Text + "&size=1200x674&key=AIzaSyBDNQ2wZ3Lt73qKvn6lfzztrsc_X7ixBdM"
    End Sub

    Private Sub PictureBox3_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseDoubleClick
        TextBox_MapZoom.Text = TextBox_MapZoom.Text - 2
        'PictureBox2.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?maptype=satellite&center=" + TextBox_Latitude.Text + "," + TextBox_Lontitude.Text + "&zoom=" + TextBox_MapZoom.Text + "&size=1200x674&key=AIzaSyBDNQ2wZ3Lt73qKvn6lfzztrsc_X7ixBdM"
    End Sub

    Private Sub TextBox_MapZoom_TextChanged(sender As Object, e As EventArgs) Handles TextBox_MapZoom.TextChanged
        PictureBox2.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?maptype=satellite&center=" + TextBox_Latitude.Text + "," + TextBox_Lontitude.Text + "&zoom=" + TextBox_MapZoom.Text + "&size=511x396&key=AIzaSyBDNQ2wZ3Lt73qKvn6lfzztrsc_X7ixBdM"
    End Sub

    '********************************** Button Click about Vehicle
    Private Sub Button_VehicleForward_Click(sender As Object, e As EventArgs) Handles Button_VehicleForward.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("B")
                Button_VehicleForward.ForeColor = Color.White        ''
                Button_VehicleForward.BackColor = Color.DarkRed      ''
                Button_VehicleBackward.ForeColor = Color.Black
                Button_VehicleBackward.BackColor = DefaultBackColor
                Button_VehicleLeft.ForeColor = Color.Black
                Button_VehicleLeft.BackColor = DefaultBackColor
                Button_VehicleRight.ForeColor = Color.Black
                Button_VehicleRight.BackColor = DefaultBackColor
                Button_VehicleStop.ForeColor = Color.Black
                Button_VehicleStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_VehicleStop_Click(sender As Object, e As EventArgs) Handles Button_VehicleStop.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("A")
                Button_VehicleForward.ForeColor = Color.Black
                Button_VehicleForward.BackColor = DefaultBackColor
                Button_VehicleBackward.ForeColor = Color.Black
                Button_VehicleBackward.BackColor = DefaultBackColor
                Button_VehicleLeft.ForeColor = Color.Black
                Button_VehicleLeft.BackColor = DefaultBackColor
                Button_VehicleRight.ForeColor = Color.Black
                Button_VehicleRight.BackColor = DefaultBackColor
                Button_VehicleStop.ForeColor = Color.White             ''
                Button_VehicleStop.BackColor = Color.DarkRed           ''
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_VehicleRight_Click(sender As Object, e As EventArgs) Handles Button_VehicleRight.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("E")
                Button_VehicleForward.ForeColor = Color.Black
                Button_VehicleForward.BackColor = DefaultBackColor
                Button_VehicleBackward.ForeColor = Color.Black
                Button_VehicleBackward.BackColor = DefaultBackColor
                Button_VehicleLeft.ForeColor = Color.Black
                Button_VehicleLeft.BackColor = DefaultBackColor
                Button_VehicleRight.ForeColor = Color.White          ''
                Button_VehicleRight.BackColor = Color.DarkRed        ''
                Button_VehicleStop.ForeColor = Color.Black
                Button_VehicleStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_VehicleLeft_Click(sender As Object, e As EventArgs) Handles Button_VehicleLeft.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("D")
                Button_VehicleForward.ForeColor = Color.Black
                Button_VehicleForward.BackColor = DefaultBackColor
                Button_VehicleBackward.ForeColor = Color.Black
                Button_VehicleBackward.BackColor = DefaultBackColor
                Button_VehicleLeft.ForeColor = Color.White           ''
                Button_VehicleLeft.BackColor = Color.DarkRed         ''
                Button_VehicleRight.ForeColor = Color.Black
                Button_VehicleRight.BackColor = DefaultBackColor
                Button_VehicleStop.ForeColor = Color.Black
                Button_VehicleStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_VehicleBackward_Click(sender As Object, e As EventArgs) Handles Button_VehicleBackward.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("C")
                Button_VehicleForward.ForeColor = Color.Black
                Button_VehicleForward.BackColor = DefaultBackColor
                Button_VehicleBackward.ForeColor = Color.White           ''
                Button_VehicleBackward.BackColor = Color.DarkRed         ''
                Button_VehicleLeft.ForeColor = Color.Black
                Button_VehicleLeft.BackColor = DefaultBackColor
                Button_VehicleRight.ForeColor = Color.Black
                Button_VehicleRight.BackColor = DefaultBackColor
                Button_VehicleStop.ForeColor = Color.Black
                Button_VehicleStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_VehicleLightt_Click(sender As Object, e As EventArgs) Handles Button_VehicleLight.Click
        If ConnectStatus Then
            Try
                If VLight Then
                    SerialPort1.Write("G")
                    VLight = False
                    Button_VehicleLight.BackgroundImage = My.Resources.光源圖示_暗
                Else
                    SerialPort1.Write("F")
                    VLight = True
                    Button_VehicleLight.BackgroundImage = My.Resources.光源圖示_亮
                End If
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub
    '**********************************************************



    '********************************** Button Click about Buoy
    Private Sub Button_BuoyForward_Click(sender As Object, e As EventArgs) Handles Button_BuoyForward.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("U")
                Button_BuoyForward.ForeColor = Color.White           ''
                Button_BuoyForward.BackColor = Color.DarkRed         ''
                Button_BuoyBackward.ForeColor = Color.Black
                Button_BuoyBackward.BackColor = DefaultBackColor
                Button_BuoyLeft.ForeColor = Color.Black
                Button_BuoyLeft.BackColor = DefaultBackColor
                Button_BuoyRight.ForeColor = Color.Black
                Button_BuoyRight.BackColor = DefaultBackColor
                Button_BuoyStop.ForeColor = Color.Black
                Button_BuoyStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_BuoyRight_Click(sender As Object, e As EventArgs) Handles Button_BuoyRight.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("X")
                Button_BuoyForward.ForeColor = Color.Black
                Button_BuoyForward.BackColor = DefaultBackColor
                Button_BuoyBackward.ForeColor = Color.Black
                Button_BuoyBackward.BackColor = DefaultBackColor
                Button_BuoyLeft.ForeColor = Color.Black
                Button_BuoyLeft.BackColor = DefaultBackColor
                Button_BuoyRight.ForeColor = Color.White           ''
                Button_BuoyRight.BackColor = Color.DarkRed         ''
                Button_BuoyStop.ForeColor = Color.Black
                Button_BuoyStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_BuoyBackward_Click(sender As Object, e As EventArgs) Handles Button_BuoyBackward.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("V")
                Button_BuoyForward.ForeColor = Color.Black
                Button_BuoyForward.BackColor = DefaultBackColor
                Button_BuoyBackward.ForeColor = Color.White           ''
                Button_BuoyBackward.BackColor = Color.DarkRed         ''
                Button_BuoyLeft.ForeColor = Color.Black
                Button_BuoyLeft.BackColor = DefaultBackColor
                Button_BuoyRight.ForeColor = Color.Black
                Button_BuoyRight.BackColor = DefaultBackColor
                Button_BuoyStop.ForeColor = Color.Black
                Button_BuoyStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_BuoyLeft_Click(sender As Object, e As EventArgs) Handles Button_BuoyLeft.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("W")
                Button_BuoyForward.ForeColor = Color.Black
                Button_BuoyForward.BackColor = DefaultBackColor
                Button_BuoyBackward.ForeColor = Color.Black
                Button_BuoyBackward.BackColor = DefaultBackColor
                Button_BuoyLeft.ForeColor = Color.White           ''
                Button_BuoyLeft.BackColor = Color.DarkRed         ''
                Button_BuoyRight.ForeColor = Color.Black
                Button_BuoyRight.BackColor = DefaultBackColor
                Button_BuoyStop.ForeColor = Color.Black
                Button_BuoyStop.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_BuoyStop_Click(sender As Object, e As EventArgs) Handles Button_BuoyStop.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("T")
                Button_BuoyForward.ForeColor = Color.Black
                Button_BuoyForward.BackColor = DefaultBackColor
                Button_BuoyBackward.ForeColor = Color.Black
                Button_BuoyBackward.BackColor = DefaultBackColor
                Button_BuoyLeft.ForeColor = Color.Black
                Button_BuoyLeft.BackColor = DefaultBackColor
                Button_BuoyRight.ForeColor = Color.Black
                Button_BuoyRight.BackColor = DefaultBackColor
                Button_BuoyStop.ForeColor = Color.White           ''
                Button_BuoyStop.BackColor = Color.DarkRed         ''
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_BuoyReelUp_Click(sender As Object, e As EventArgs) Handles Button_BuoyReelUp.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("Y")
                Button_BuoyReelUp.ForeColor = Color.White           ''
                Button_BuoyReelUp.BackColor = Color.DarkRed         ''
                Button_BuoyReelStop.ForeColor = Color.Black
                Button_BuoyReelStop.BackColor = DefaultBackColor
                Button_BuoyReelDown.ForeColor = Color.Black
                Button_BuoyReelDown.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_BuoyReelDown_Click(sender As Object, e As EventArgs) Handles Button_BuoyReelDown.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("Z")
                Button_BuoyReelUp.ForeColor = Color.Black
                Button_BuoyReelUp.BackColor = DefaultBackColor
                Button_BuoyReelStop.ForeColor = Color.Black
                Button_BuoyReelStop.BackColor = DefaultBackColor
                Button_BuoyReelDown.ForeColor = Color.White           ''
                Button_BuoyReelDown.BackColor = Color.DarkRed         ''
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub

    Private Sub Button_BuoyReelStop_Click(sender As Object, e As EventArgs) Handles Button_BuoyReelStop.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("S")
                Button_BuoyReelUp.ForeColor = Color.Black
                Button_BuoyReelUp.BackColor = DefaultBackColor
                Button_BuoyReelStop.ForeColor = Color.White           ''
                Button_BuoyReelStop.BackColor = Color.DarkRed         ''
                Button_BuoyReelDown.ForeColor = Color.Black
                Button_BuoyReelDown.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else
            MsgBox(msg_ConnectionNOTYET, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, msg_FaildConnecton)
        End If
    End Sub







    '**********************************************************
End Class
