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
    Dim ConnectStatus As Boolean
    Private MaybeEnd As Boolean

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
End Class
