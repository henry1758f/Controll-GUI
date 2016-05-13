<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeriesPortSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.說明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Down = New System.Windows.Forms.Button()
        Me.Button_Up = New System.Windows.Forms.Button()
        Me.Button_STOP = New System.Windows.Forms.Button()
        Me.Button_GoLeft = New System.Windows.Forms.Button()
        Me.Button_GoBackward = New System.Windows.Forms.Button()
        Me.Button_GoRight = New System.Windows.Forms.Button()
        Me.Button_Goforward = New System.Windows.Forms.Button()
        Me.GroupBox_ControlPanel = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNOW = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RichTextBox_Message = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button_VideoSet = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_Mode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_BaudSelect = New System.Windows.Forms.ComboBox()
        Me.ComboBox_PortSelect = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox_ControlPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadTimeout = 255
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.設定ToolStripMenuItem, Me.說明ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1334, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeriesPortSettingToolStripMenuItem})
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.設定ToolStripMenuItem.Text = "設定"
        '
        'SeriesPortSettingToolStripMenuItem
        '
        Me.SeriesPortSettingToolStripMenuItem.Name = "SeriesPortSettingToolStripMenuItem"
        Me.SeriesPortSettingToolStripMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.SeriesPortSettingToolStripMenuItem.Text = "Series Port Setting"
        '
        '說明ToolStripMenuItem
        '
        Me.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem"
        Me.說明ToolStripMenuItem.Size = New System.Drawing.Size(51, 23)
        Me.說明ToolStripMenuItem.Text = "說明"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 780)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1334, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_Down)
        Me.Panel1.Controls.Add(Me.Button_Up)
        Me.Panel1.Controls.Add(Me.Button_STOP)
        Me.Panel1.Controls.Add(Me.Button_GoLeft)
        Me.Panel1.Controls.Add(Me.Button_GoBackward)
        Me.Panel1.Controls.Add(Me.Button_GoRight)
        Me.Panel1.Controls.Add(Me.Button_Goforward)
        Me.Panel1.Location = New System.Drawing.Point(6, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 171)
        Me.Panel1.TabIndex = 3
        '
        'Button_Down
        '
        Me.Button_Down.Location = New System.Drawing.Point(169, 92)
        Me.Button_Down.Name = "Button_Down"
        Me.Button_Down.Size = New System.Drawing.Size(40, 50)
        Me.Button_Down.TabIndex = 6
        Me.Button_Down.Text = "↘"
        Me.Button_Down.UseVisualStyleBackColor = True
        '
        'Button_Up
        '
        Me.Button_Up.Location = New System.Drawing.Point(169, 10)
        Me.Button_Up.Name = "Button_Up"
        Me.Button_Up.Size = New System.Drawing.Size(40, 50)
        Me.Button_Up.TabIndex = 5
        Me.Button_Up.Text = "↗"
        Me.Button_Up.UseVisualStyleBackColor = True
        '
        'Button_STOP
        '
        Me.Button_STOP.Location = New System.Drawing.Point(55, 56)
        Me.Button_STOP.Name = "Button_STOP"
        Me.Button_STOP.Size = New System.Drawing.Size(40, 40)
        Me.Button_STOP.TabIndex = 4
        Me.Button_STOP.Text = "⊕"
        Me.Button_STOP.UseVisualStyleBackColor = True
        '
        'Button_GoLeft
        '
        Me.Button_GoLeft.Location = New System.Drawing.Point(9, 56)
        Me.Button_GoLeft.Name = "Button_GoLeft"
        Me.Button_GoLeft.Size = New System.Drawing.Size(40, 40)
        Me.Button_GoLeft.TabIndex = 3
        Me.Button_GoLeft.Text = "←"
        Me.Button_GoLeft.UseVisualStyleBackColor = True
        '
        'Button_GoBackward
        '
        Me.Button_GoBackward.Location = New System.Drawing.Point(55, 102)
        Me.Button_GoBackward.Name = "Button_GoBackward"
        Me.Button_GoBackward.Size = New System.Drawing.Size(40, 40)
        Me.Button_GoBackward.TabIndex = 2
        Me.Button_GoBackward.Text = "↓"
        Me.Button_GoBackward.UseVisualStyleBackColor = True
        '
        'Button_GoRight
        '
        Me.Button_GoRight.Location = New System.Drawing.Point(101, 56)
        Me.Button_GoRight.Name = "Button_GoRight"
        Me.Button_GoRight.Size = New System.Drawing.Size(40, 40)
        Me.Button_GoRight.TabIndex = 1
        Me.Button_GoRight.Text = "→"
        Me.Button_GoRight.UseVisualStyleBackColor = True
        '
        'Button_Goforward
        '
        Me.Button_Goforward.Location = New System.Drawing.Point(55, 10)
        Me.Button_Goforward.Name = "Button_Goforward"
        Me.Button_Goforward.Size = New System.Drawing.Size(40, 40)
        Me.Button_Goforward.TabIndex = 0
        Me.Button_Goforward.Text = "↑"
        Me.Button_Goforward.UseVisualStyleBackColor = True
        '
        'GroupBox_ControlPanel
        '
        Me.GroupBox_ControlPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox_ControlPanel.Controls.Add(Me.GroupBox1)
        Me.GroupBox_ControlPanel.Location = New System.Drawing.Point(226, 30)
        Me.GroupBox_ControlPanel.Name = "GroupBox_ControlPanel"
        Me.GroupBox_ControlPanel.Size = New System.Drawing.Size(300, 248)
        Me.GroupBox_ControlPanel.TabIndex = 4
        Me.GroupBox_ControlPanel.TabStop = False
        Me.GroupBox_ControlPanel.Text = "Control Panel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 209)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.PictureBox2)
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 284)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(514, 483)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.TextBox4)
        Me.GroupBox6.Controls.Add(Me.TextBox5)
        Me.GroupBox6.Controls.Add(Me.TextBox6)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Location = New System.Drawing.Point(206, 20)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(291, 100)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Location"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(258, 47)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "o"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微軟正黑體", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label12.Location = New System.Drawing.Point(188, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 42)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "N"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微軟正黑體", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label11.Location = New System.Drawing.Point(188, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 42)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "000"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(79, 73)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(103, 25)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(79, 46)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(103, 25)
        Me.TextBox5.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(79, 18)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(103, 25)
        Me.TextBox6.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Lontitude"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "ffffff"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 15)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Latitude"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox3)
        Me.GroupBox5.Controls.Add(Me.TextBox2)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(188, 100)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tempurature"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(116, 73)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(42, 25)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(42, 25)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(116, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(42, 25)
        Me.TextBox1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Inside of Vehicle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Out of Buoy"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Out of Vehicle"
        '
        'LabelNOW
        '
        Me.LabelNOW.AutoSize = True
        Me.LabelNOW.Location = New System.Drawing.Point(106, 156)
        Me.LabelNOW.Name = "LabelNOW"
        Me.LabelNOW.Size = New System.Drawing.Size(0, 15)
        Me.LabelNOW.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.LabelNOW)
        Me.GroupBox3.Controls.Add(Me.RichTextBox_Message)
        Me.GroupBox3.Location = New System.Drawing.Point(532, 588)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(503, 179)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(263, 24)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(234, 129)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NOW DATA :"
        '
        'RichTextBox_Message
        '
        Me.RichTextBox_Message.Location = New System.Drawing.Point(12, 24)
        Me.RichTextBox_Message.Name = "RichTextBox_Message"
        Me.RichTextBox_Message.Size = New System.Drawing.Size(245, 129)
        Me.RichTextBox_Message.TabIndex = 0
        Me.RichTextBox_Message.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_VideoSet)
        Me.GroupBox4.Controls.Add(Me.Button_Connect)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.ComboBox_Mode)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.ComboBox_BaudSelect)
        Me.GroupBox4.Controls.Add(Me.ComboBox_PortSelect)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 248)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Setting and Configuration"
        '
        'Button_VideoSet
        '
        Me.Button_VideoSet.Location = New System.Drawing.Point(60, 181)
        Me.Button_VideoSet.Name = "Button_VideoSet"
        Me.Button_VideoSet.Size = New System.Drawing.Size(75, 23)
        Me.Button_VideoSet.TabIndex = 7
        Me.Button_VideoSet.Text = "Video Set"
        Me.Button_VideoSet.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.Location = New System.Drawing.Point(60, 152)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(75, 23)
        Me.Button_Connect.TabIndex = 6
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mode"
        '
        'ComboBox_Mode
        '
        Me.ComboBox_Mode.FormattingEnabled = True
        Me.ComboBox_Mode.Location = New System.Drawing.Point(81, 97)
        Me.ComboBox_Mode.Name = "ComboBox_Mode"
        Me.ComboBox_Mode.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_Mode.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Baud Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Port Select"
        '
        'ComboBox_BaudSelect
        '
        Me.ComboBox_BaudSelect.FormattingEnabled = True
        Me.ComboBox_BaudSelect.Location = New System.Drawing.Point(81, 65)
        Me.ComboBox_BaudSelect.Name = "ComboBox_BaudSelect"
        Me.ComboBox_BaudSelect.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_BaudSelect.TabIndex = 1
        '
        'ComboBox_PortSelect
        '
        Me.ComboBox_PortSelect.FormattingEnabled = True
        Me.ComboBox_PortSelect.Location = New System.Drawing.Point(81, 36)
        Me.ComboBox_PortSelect.Name = "ComboBox_PortSelect"
        Me.ComboBox_PortSelect.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox_PortSelect.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(532, 31)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(789, 556)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox2.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?maptype=satellite&center=22.649419" &
    ",120.328509&zoom=18&size=498x349&key=AIzaSyBDNQ2wZ3Lt73qKvn6lfzztrsc_X7ixBdM"
        Me.PictureBox2.Location = New System.Drawing.Point(10, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(498, 349)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(250, 284)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(67, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1334, 802)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox_ControlPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SCH01 - v0.1.1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox_ControlPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Down As Button
    Friend WithEvents Button_Up As Button
    Friend WithEvents Button_STOP As Button
    Friend WithEvents Button_GoLeft As Button
    Friend WithEvents Button_GoBackward As Button
    Friend WithEvents Button_GoRight As Button
    Friend WithEvents Button_Goforward As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents GroupBox_ControlPanel As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents 說明ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 設定ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RichTextBox_Message As RichTextBox
    Friend WithEvents SeriesPortSettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox_BaudSelect As ComboBox
    Friend WithEvents ComboBox_PortSelect As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox_Mode As ComboBox
    Friend WithEvents Button_Connect As Button
    Friend WithEvents LabelNOW As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_VideoSet As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
