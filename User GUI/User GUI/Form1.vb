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

    Dim CAMERA As VideoCaptureDevice    'Video Camera
    Dim bmp As Bitmap

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
            Try
                ConnectStatus = False
                SerialPort1.Close()
                SerialPort1.DiscardInBuffer()

                ComboBox_PortSelect.Enabled = True
                ComboBox_BaudSelect.Enabled = True
                ComboBox_Mode.Enabled = True
                Button_Connect.Text = "Connect"

            Catch ex As Exception
                MsgBox("CAUTION!" + vbCrLf + ex.Message, MsgBoxStyle.Information, "CAUTION!")
                ConnectStatus = False
                ComboBox_PortSelect.Enabled = True
                ComboBox_BaudSelect.Enabled = True
                ComboBox_Mode.Enabled = True
                Button_Connect.Text = "Connect"
                RichTextBox_Message.Text = ""
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
            Me.BeginInvoke(x, New Object() {([Text])})
            Me.DataFlow &= [Text]
        Else
            Me.RichTextBox_Message.Text &= [Text]
            Me.DataFlow &= [Text]
        End If
    End Sub

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

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            CAMERA.Stop()
            SerialPort1.Close()
        Catch ex As Exception

        End Try
    End Sub

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

    Private Sub Button_Goforward_Click(sender As Object, e As EventArgs) Handles Button_Goforward.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("A")
                Button_Goforward.ForeColor = Color.White        ''
                Button_Goforward.BackColor = Color.DarkRed      ''
                Button_GoBackward.ForeColor = Color.Black
                Button_GoBackward.BackColor = DefaultBackColor
                Button_GoLeft.ForeColor = Color.Black
                Button_GoLeft.BackColor = DefaultBackColor
                Button_GoRight.ForeColor = Color.Black
                Button_GoRight.BackColor = DefaultBackColor
                Button_STOP.ForeColor = Color.Black
                Button_STOP.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else

        End If
    End Sub

    Private Sub Button_STOP_Click(sender As Object, e As EventArgs) Handles Button_STOP.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("E")
                Button_Goforward.ForeColor = Color.Black
                Button_Goforward.BackColor = DefaultBackColor
                Button_GoBackward.ForeColor = Color.Black
                Button_GoBackward.BackColor = DefaultBackColor
                Button_GoLeft.ForeColor = Color.Black
                Button_GoLeft.BackColor = DefaultBackColor
                Button_GoRight.ForeColor = Color.Black
                Button_GoRight.BackColor = DefaultBackColor
                Button_STOP.ForeColor = Color.White             ''
                Button_STOP.BackColor = Color.DarkRed           ''
            Catch ex As Exception
                '指令未送成功
            End Try
        Else

        End If
    End Sub

    Private Sub Button_GoRight_Click(sender As Object, e As EventArgs) Handles Button_GoRight.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("B")
                Button_Goforward.ForeColor = Color.Black
                Button_Goforward.BackColor = DefaultBackColor
                Button_GoBackward.ForeColor = Color.Black
                Button_GoBackward.BackColor = DefaultBackColor
                Button_GoLeft.ForeColor = Color.Black
                Button_GoLeft.BackColor = DefaultBackColor
                Button_GoRight.ForeColor = Color.White          ''
                Button_GoRight.BackColor = Color.DarkRed        ''
                Button_STOP.ForeColor = Color.Black
                Button_STOP.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else

        End If
    End Sub

    Private Sub Button_GoLeft_Click(sender As Object, e As EventArgs) Handles Button_GoLeft.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("C")
                Button_Goforward.ForeColor = Color.Black
                Button_Goforward.BackColor = DefaultBackColor
                Button_GoBackward.ForeColor = Color.Black
                Button_GoBackward.BackColor = DefaultBackColor
                Button_GoLeft.ForeColor = Color.White           ''
                Button_GoLeft.BackColor = Color.DarkRed         ''
                Button_GoRight.ForeColor = Color.Black
                Button_GoRight.BackColor = DefaultBackColor
                Button_STOP.ForeColor = Color.Black
                Button_STOP.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else

        End If
    End Sub

    Private Sub Button_GoBackward_Click(sender As Object, e As EventArgs) Handles Button_GoBackward.Click
        If ConnectStatus Then
            Try
                SerialPort1.Write("D")
                Button_Goforward.ForeColor = Color.Black
                Button_Goforward.BackColor = DefaultBackColor
                Button_GoBackward.ForeColor = Color.White           ''
                Button_GoBackward.BackColor = Color.DarkRed         ''
                Button_GoLeft.ForeColor = Color.Black
                Button_GoLeft.BackColor = DefaultBackColor
                Button_GoRight.ForeColor = Color.Black
                Button_GoRight.BackColor = DefaultBackColor
                Button_STOP.ForeColor = Color.Black
                Button_STOP.BackColor = DefaultBackColor
            Catch ex As Exception
                '指令未送成功
            End Try
        Else

        End If
    End Sub

    Private Sub Button_VLight_Click(sender As Object, e As EventArgs) Handles Button_VLight.Click
        If ConnectStatus Then
            Try
                If VLight Then
                    SerialPort1.Write("G")
                    VLight = False
                    Button_VLight.BackgroundImage = My.Resources.光源圖示_暗
                Else
                    SerialPort1.Write("F")
                    VLight = True
                    Button_VLight.BackgroundImage = My.Resources.光源圖示_亮
                End If
            Catch ex As Exception
                '指令未送成功
            End Try
        Else

        End If
    End Sub

    Private Sub RichTextBox_Message_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox_Message.TextChanged
        If RichTextBox_Message.Text.EndsWith("$~") Then
            LabelNOW.Text = RichTextBox_Message.Text
            RichTextBox_MessageFlow.Text &= RichTextBox_Message.Text
            RichTextBox_Message.Text = ""
        End If
    End Sub
End Class
