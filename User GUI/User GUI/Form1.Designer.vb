<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea7 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series21 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea8 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series22 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series23 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series24 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeriesPortSettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.說明ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_VehicleLight = New System.Windows.Forms.Button()
        Me.Button_VehicleStop = New System.Windows.Forms.Button()
        Me.Button_VehicleLeft = New System.Windows.Forms.Button()
        Me.Button_VehicleBackward = New System.Windows.Forms.Button()
        Me.Button_VehicleRight = New System.Windows.Forms.Button()
        Me.Button_VehicleForward = New System.Windows.Forms.Button()
        Me.Button_BuoyReelDown = New System.Windows.Forms.Button()
        Me.Button_BuoyReelUp = New System.Windows.Forms.Button()
        Me.GroupBox_ControlPanel = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button_BuoyReelStop = New System.Windows.Forms.Button()
        Me.Button_BuoyStop = New System.Windows.Forms.Button()
        Me.Button_BuoyLeft = New System.Windows.Forms.Button()
        Me.Button_BuoyBackward = New System.Windows.Forms.Button()
        Me.Button_BuoyRight = New System.Windows.Forms.Button()
        Me.Button_BuoyForward = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label_VehicleFacing = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label_VehicleFacingAngel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button_mapZoomOUT = New System.Windows.Forms.Button()
        Me.Button_mapZoomIN = New System.Windows.Forms.Button()
        Me.Label_BuoyFacing = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox_MapZoom = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox_Altitude = New System.Windows.Forms.TextBox()
        Me.TextBox_Lontitude = New System.Windows.Forms.TextBox()
        Me.TextBox_Latitude = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_BuoyFacingAngle = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label_titlePRESSURE = New System.Windows.Forms.Label()
        Me.TextBox_BuoyTemp = New System.Windows.Forms.TextBox()
        Me.Chart_Tempurature = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TextBox_VehicleTemp = New System.Windows.Forms.TextBox()
        Me.TextBox_VehicleOUTtemp = New System.Windows.Forms.TextBox()
        Me.Label_VehicleTemp = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNOW = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label_DATAreceiveTitle = New System.Windows.Forms.Label()
        Me.Label_DATAreceive = New System.Windows.Forms.Label()
        Me.RichTextBox_MessageFlow = New System.Windows.Forms.RichTextBox()
        Me.Label_NOWDATAtitle = New System.Windows.Forms.Label()
        Me.RichTextBox_Message = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox_BaudSelect = New System.Windows.Forms.ComboBox()
        Me.Button_VideoSet = New System.Windows.Forms.Button()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_Mode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_PortSelect = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer_DriverConnectionCheck = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_BuoyConnectionCheck = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox_Video = New System.Windows.Forms.GroupBox()
        Me.Timer_TemperatureRecorder = New System.Windows.Forms.Timer(Me.components)
        Me.Chart_TemperatureBigger = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox_ControlPanel.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.Chart_Tempurature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Video.SuspendLayout()
        CType(Me.Chart_TemperatureBigger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.ReadTimeout = 255
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft JhengHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.設定ToolStripMenuItem, Me.說明ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1662, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeriesPortSettingToolStripMenuItem})
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(56, 26)
        Me.設定ToolStripMenuItem.Text = "設定"
        '
        'SeriesPortSettingToolStripMenuItem
        '
        Me.SeriesPortSettingToolStripMenuItem.Name = "SeriesPortSettingToolStripMenuItem"
        Me.SeriesPortSettingToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.SeriesPortSettingToolStripMenuItem.Text = "Series Port Setting"
        '
        '說明ToolStripMenuItem
        '
        Me.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem"
        Me.說明ToolStripMenuItem.Size = New System.Drawing.Size(56, 26)
        Me.說明ToolStripMenuItem.Text = "說明"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 979)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1662, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(110, 19)
        Me.ToolStripStatusLabel1.Text = "Driver Status : "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(110, 19)
        Me.ToolStripStatusLabel2.Text = "Disconnected"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(114, 19)
        Me.ToolStripStatusLabel3.Text = "   Buoy Status : "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(110, 19)
        Me.ToolStripStatusLabel4.Text = "Disconnected"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.BackColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(129, 19)
        Me.ToolStripStatusLabel5.Text = "   Vehicle Status : "
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel6.Font = New System.Drawing.Font("Microsoft JhengHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ToolStripStatusLabel6.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(110, 19)
        Me.ToolStripStatusLabel6.Text = "Disconnected"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button_VehicleLight)
        Me.Panel1.Controls.Add(Me.Button_VehicleStop)
        Me.Panel1.Controls.Add(Me.Button_VehicleLeft)
        Me.Panel1.Controls.Add(Me.Button_VehicleBackward)
        Me.Panel1.Controls.Add(Me.Button_VehicleRight)
        Me.Panel1.Controls.Add(Me.Button_VehicleForward)
        Me.Panel1.Location = New System.Drawing.Point(6, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 152)
        Me.Panel1.TabIndex = 3
        '
        'Button_VehicleLight
        '
        Me.Button_VehicleLight.BackgroundImage = Global.User_GUI.My.Resources.Resources.光源圖示_暗
        Me.Button_VehicleLight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button_VehicleLight.Location = New System.Drawing.Point(9, 9)
        Me.Button_VehicleLight.Name = "Button_VehicleLight"
        Me.Button_VehicleLight.Size = New System.Drawing.Size(40, 40)
        Me.Button_VehicleLight.TabIndex = 5
        Me.Button_VehicleLight.Text = "   "
        Me.Button_VehicleLight.UseVisualStyleBackColor = True
        '
        'Button_VehicleStop
        '
        Me.Button_VehicleStop.Location = New System.Drawing.Point(55, 56)
        Me.Button_VehicleStop.Name = "Button_VehicleStop"
        Me.Button_VehicleStop.Size = New System.Drawing.Size(40, 40)
        Me.Button_VehicleStop.TabIndex = 4
        Me.Button_VehicleStop.Text = "⊕"
        Me.Button_VehicleStop.UseVisualStyleBackColor = True
        '
        'Button_VehicleLeft
        '
        Me.Button_VehicleLeft.Location = New System.Drawing.Point(9, 56)
        Me.Button_VehicleLeft.Name = "Button_VehicleLeft"
        Me.Button_VehicleLeft.Size = New System.Drawing.Size(40, 40)
        Me.Button_VehicleLeft.TabIndex = 3
        Me.Button_VehicleLeft.Text = "←"
        Me.Button_VehicleLeft.UseVisualStyleBackColor = True
        '
        'Button_VehicleBackward
        '
        Me.Button_VehicleBackward.Location = New System.Drawing.Point(55, 102)
        Me.Button_VehicleBackward.Name = "Button_VehicleBackward"
        Me.Button_VehicleBackward.Size = New System.Drawing.Size(40, 40)
        Me.Button_VehicleBackward.TabIndex = 2
        Me.Button_VehicleBackward.Text = "↓"
        Me.Button_VehicleBackward.UseVisualStyleBackColor = True
        '
        'Button_VehicleRight
        '
        Me.Button_VehicleRight.Location = New System.Drawing.Point(101, 56)
        Me.Button_VehicleRight.Name = "Button_VehicleRight"
        Me.Button_VehicleRight.Size = New System.Drawing.Size(40, 40)
        Me.Button_VehicleRight.TabIndex = 1
        Me.Button_VehicleRight.Text = "→"
        Me.Button_VehicleRight.UseVisualStyleBackColor = True
        '
        'Button_VehicleForward
        '
        Me.Button_VehicleForward.Location = New System.Drawing.Point(55, 10)
        Me.Button_VehicleForward.Name = "Button_VehicleForward"
        Me.Button_VehicleForward.Size = New System.Drawing.Size(40, 40)
        Me.Button_VehicleForward.TabIndex = 0
        Me.Button_VehicleForward.TabStop = False
        Me.Button_VehicleForward.Text = "↑"
        Me.Button_VehicleForward.UseVisualStyleBackColor = True
        '
        'Button_BuoyReelDown
        '
        Me.Button_BuoyReelDown.Location = New System.Drawing.Point(147, 102)
        Me.Button_BuoyReelDown.Name = "Button_BuoyReelDown"
        Me.Button_BuoyReelDown.Size = New System.Drawing.Size(40, 50)
        Me.Button_BuoyReelDown.TabIndex = 6
        Me.Button_BuoyReelDown.Text = "↘"
        Me.Button_BuoyReelDown.UseVisualStyleBackColor = True
        '
        'Button_BuoyReelUp
        '
        Me.Button_BuoyReelUp.Location = New System.Drawing.Point(147, 0)
        Me.Button_BuoyReelUp.Name = "Button_BuoyReelUp"
        Me.Button_BuoyReelUp.Size = New System.Drawing.Size(40, 50)
        Me.Button_BuoyReelUp.TabIndex = 5
        Me.Button_BuoyReelUp.Text = "↗"
        Me.Button_BuoyReelUp.UseVisualStyleBackColor = True
        '
        'GroupBox_ControlPanel
        '
        Me.GroupBox_ControlPanel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox_ControlPanel.Controls.Add(Me.GroupBox7)
        Me.GroupBox_ControlPanel.Controls.Add(Me.GroupBox1)
        Me.GroupBox_ControlPanel.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_ControlPanel.Location = New System.Drawing.Point(279, 51)
        Me.GroupBox_ControlPanel.Name = "GroupBox_ControlPanel"
        Me.GroupBox_ControlPanel.Size = New System.Drawing.Size(402, 234)
        Me.GroupBox_ControlPanel.TabIndex = 4
        Me.GroupBox_ControlPanel.TabStop = False
        Me.GroupBox_ControlPanel.Text = "Control Panel"
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox7.Controls.Add(Me.Panel2)
        Me.GroupBox7.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(6, 28)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(210, 201)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Buoy"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button_BuoyReelStop)
        Me.Panel2.Controls.Add(Me.Button_BuoyReelDown)
        Me.Panel2.Controls.Add(Me.Button_BuoyStop)
        Me.Panel2.Controls.Add(Me.Button_BuoyReelUp)
        Me.Panel2.Controls.Add(Me.Button_BuoyLeft)
        Me.Panel2.Controls.Add(Me.Button_BuoyBackward)
        Me.Panel2.Controls.Add(Me.Button_BuoyRight)
        Me.Panel2.Controls.Add(Me.Button_BuoyForward)
        Me.Panel2.Location = New System.Drawing.Point(9, 33)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(195, 152)
        Me.Panel2.TabIndex = 3
        '
        'Button_BuoyReelStop
        '
        Me.Button_BuoyReelStop.Location = New System.Drawing.Point(147, 56)
        Me.Button_BuoyReelStop.Name = "Button_BuoyReelStop"
        Me.Button_BuoyReelStop.Size = New System.Drawing.Size(40, 40)
        Me.Button_BuoyReelStop.TabIndex = 7
        Me.Button_BuoyReelStop.Text = "≡"
        Me.Button_BuoyReelStop.UseVisualStyleBackColor = True
        '
        'Button_BuoyStop
        '
        Me.Button_BuoyStop.Location = New System.Drawing.Point(55, 56)
        Me.Button_BuoyStop.Name = "Button_BuoyStop"
        Me.Button_BuoyStop.Size = New System.Drawing.Size(40, 40)
        Me.Button_BuoyStop.TabIndex = 4
        Me.Button_BuoyStop.Text = "⊕"
        Me.Button_BuoyStop.UseVisualStyleBackColor = True
        '
        'Button_BuoyLeft
        '
        Me.Button_BuoyLeft.Location = New System.Drawing.Point(9, 56)
        Me.Button_BuoyLeft.Name = "Button_BuoyLeft"
        Me.Button_BuoyLeft.Size = New System.Drawing.Size(40, 40)
        Me.Button_BuoyLeft.TabIndex = 3
        Me.Button_BuoyLeft.Text = "←"
        Me.Button_BuoyLeft.UseVisualStyleBackColor = True
        '
        'Button_BuoyBackward
        '
        Me.Button_BuoyBackward.Location = New System.Drawing.Point(55, 102)
        Me.Button_BuoyBackward.Name = "Button_BuoyBackward"
        Me.Button_BuoyBackward.Size = New System.Drawing.Size(40, 40)
        Me.Button_BuoyBackward.TabIndex = 2
        Me.Button_BuoyBackward.Text = "↓"
        Me.Button_BuoyBackward.UseVisualStyleBackColor = True
        '
        'Button_BuoyRight
        '
        Me.Button_BuoyRight.Location = New System.Drawing.Point(101, 56)
        Me.Button_BuoyRight.Name = "Button_BuoyRight"
        Me.Button_BuoyRight.Size = New System.Drawing.Size(40, 40)
        Me.Button_BuoyRight.TabIndex = 1
        Me.Button_BuoyRight.Text = "→"
        Me.Button_BuoyRight.UseVisualStyleBackColor = True
        '
        'Button_BuoyForward
        '
        Me.Button_BuoyForward.Location = New System.Drawing.Point(55, 10)
        Me.Button_BuoyForward.Name = "Button_BuoyForward"
        Me.Button_BuoyForward.Size = New System.Drawing.Size(40, 40)
        Me.Button_BuoyForward.TabIndex = 0
        Me.Button_BuoyForward.Text = "↑"
        Me.Button_BuoyForward.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(227, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(168, 198)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.Label_VehicleFacing)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label_VehicleFacingAngel)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.Button_mapZoomOUT)
        Me.GroupBox6.Controls.Add(Me.Button_mapZoomIN)
        Me.GroupBox6.Controls.Add(Me.Label_BuoyFacing)
        Me.GroupBox6.Controls.Add(Me.PictureBox3)
        Me.GroupBox6.Controls.Add(Me.TextBox_MapZoom)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.PictureBox2)
        Me.GroupBox6.Controls.Add(Me.TextBox_Altitude)
        Me.GroupBox6.Controls.Add(Me.TextBox_Lontitude)
        Me.GroupBox6.Controls.Add(Me.TextBox_Latitude)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label_BuoyFacingAngle)
        Me.GroupBox6.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox6.Location = New System.Drawing.Point(12, 507)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(641, 463)
        Me.GroupBox6.TabIndex = 8
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Location"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(535, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 44)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Vehicle " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Facing"
        '
        'Label_VehicleFacing
        '
        Me.Label_VehicleFacing.AutoSize = True
        Me.Label_VehicleFacing.Font = New System.Drawing.Font("微軟正黑體", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label_VehicleFacing.Location = New System.Drawing.Point(544, 317)
        Me.Label_VehicleFacing.Name = "Label_VehicleFacing"
        Me.Label_VehicleFacing.Size = New System.Drawing.Size(45, 42)
        Me.Label_VehicleFacing.TabIndex = 15
        Me.Label_VehicleFacing.Text = "N"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微軟正黑體", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label15.Location = New System.Drawing.Point(607, 262)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 18)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "o"
        '
        'Label_VehicleFacingAngel
        '
        Me.Label_VehicleFacingAngel.AutoSize = True
        Me.Label_VehicleFacingAngel.Font = New System.Drawing.Font("微軟正黑體", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label_VehicleFacingAngel.Location = New System.Drawing.Point(532, 275)
        Me.Label_VehicleFacingAngel.Name = "Label_VehicleFacingAngel"
        Me.Label_VehicleFacingAngel.Size = New System.Drawing.Size(78, 42)
        Me.Label_VehicleFacingAngel.TabIndex = 14
        Me.Label_VehicleFacingAngel.Text = "000"
        Me.Label_VehicleFacingAngel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(517, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Buoy Facing"
        '
        'Button_mapZoomOUT
        '
        Me.Button_mapZoomOUT.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_mapZoomOUT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_mapZoomOUT.Location = New System.Drawing.Point(11, 122)
        Me.Button_mapZoomOUT.Name = "Button_mapZoomOUT"
        Me.Button_mapZoomOUT.Size = New System.Drawing.Size(25, 25)
        Me.Button_mapZoomOUT.TabIndex = 12
        Me.Button_mapZoomOUT.Text = "-"
        Me.Button_mapZoomOUT.UseVisualStyleBackColor = True
        '
        'Button_mapZoomIN
        '
        Me.Button_mapZoomIN.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_mapZoomIN.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_mapZoomIN.Location = New System.Drawing.Point(11, 71)
        Me.Button_mapZoomIN.Name = "Button_mapZoomIN"
        Me.Button_mapZoomIN.Size = New System.Drawing.Size(25, 25)
        Me.Button_mapZoomIN.TabIndex = 11
        Me.Button_mapZoomIN.Text = "+"
        Me.Button_mapZoomIN.UseVisualStyleBackColor = True
        '
        'Label_BuoyFacing
        '
        Me.Label_BuoyFacing.AutoSize = True
        Me.Label_BuoyFacing.Font = New System.Drawing.Font("微軟正黑體", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label_BuoyFacing.Location = New System.Drawing.Point(544, 150)
        Me.Label_BuoyFacing.Name = "Label_BuoyFacing"
        Me.Label_BuoyFacing.Size = New System.Drawing.Size(45, 42)
        Me.Label_BuoyFacing.TabIndex = 9
        Me.Label_BuoyFacing.Text = "N"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(11, 61)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(506, 396)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'TextBox_MapZoom
        '
        Me.TextBox_MapZoom.Location = New System.Drawing.Point(523, 419)
        Me.TextBox_MapZoom.Name = "TextBox_MapZoom"
        Me.TextBox_MapZoom.Size = New System.Drawing.Size(50, 29)
        Me.TextBox_MapZoom.TabIndex = 10
        Me.TextBox_MapZoom.Text = "15"
        Me.TextBox_MapZoom.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微軟正黑體", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label13.Location = New System.Drawing.Point(607, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 18)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "o"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox2.ImageLocation = "https://maps.googleapis.com/maps/api/staticmap?maptype=satellite&center=22.649419" &
    ",120.328509&zoom=18&size=511x396&key=AIzaSyBDNQ2wZ3Lt73qKvn6lfzztrsc_X7ixBdM"
        Me.PictureBox2.InitialImage = Nothing
        Me.PictureBox2.Location = New System.Drawing.Point(6, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(511, 396)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'TextBox_Altitude
        '
        Me.TextBox_Altitude.Location = New System.Drawing.Point(521, 26)
        Me.TextBox_Altitude.Name = "TextBox_Altitude"
        Me.TextBox_Altitude.Size = New System.Drawing.Size(87, 29)
        Me.TextBox_Altitude.TabIndex = 7
        '
        'TextBox_Lontitude
        '
        Me.TextBox_Lontitude.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Lontitude.Location = New System.Drawing.Point(311, 28)
        Me.TextBox_Lontitude.Name = "TextBox_Lontitude"
        Me.TextBox_Lontitude.Size = New System.Drawing.Size(103, 27)
        Me.TextBox_Lontitude.TabIndex = 6
        Me.TextBox_Lontitude.Text = "120.328509"
        '
        'TextBox_Latitude
        '
        Me.TextBox_Latitude.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Latitude.Location = New System.Drawing.Point(97, 28)
        Me.TextBox_Latitude.Name = "TextBox_Latitude"
        Me.TextBox_Latitude.Size = New System.Drawing.Size(103, 27)
        Me.TextBox_Latitude.TabIndex = 5
        Me.TextBox_Latitude.Text = "22.649419"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(218, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 22)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Lontitude"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(444, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 22)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Altitude"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 22)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Latitude"
        '
        'Label_BuoyFacingAngle
        '
        Me.Label_BuoyFacingAngle.AutoSize = True
        Me.Label_BuoyFacingAngle.Font = New System.Drawing.Font("微軟正黑體", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label_BuoyFacingAngle.Location = New System.Drawing.Point(532, 108)
        Me.Label_BuoyFacingAngle.Name = "Label_BuoyFacingAngle"
        Me.Label_BuoyFacingAngle.Size = New System.Drawing.Size(78, 42)
        Me.Label_BuoyFacingAngle.TabIndex = 8
        Me.Label_BuoyFacingAngle.Text = "000"
        Me.Label_BuoyFacingAngle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.Label_titlePRESSURE)
        Me.GroupBox5.Controls.Add(Me.TextBox_BuoyTemp)
        Me.GroupBox5.Controls.Add(Me.Chart_Tempurature)
        Me.GroupBox5.Controls.Add(Me.TextBox_VehicleTemp)
        Me.GroupBox5.Controls.Add(Me.TextBox_VehicleOUTtemp)
        Me.GroupBox5.Controls.Add(Me.Label_VehicleTemp)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox5.Location = New System.Drawing.Point(12, 301)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(641, 200)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tempurature"
        '
        'Label_titlePRESSURE
        '
        Me.Label_titlePRESSURE.AutoSize = True
        Me.Label_titlePRESSURE.BackColor = System.Drawing.Color.DarkCyan
        Me.Label_titlePRESSURE.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_titlePRESSURE.Location = New System.Drawing.Point(6, 126)
        Me.Label_titlePRESSURE.Name = "Label_titlePRESSURE"
        Me.Label_titlePRESSURE.Size = New System.Drawing.Size(190, 44)
        Me.Label_titlePRESSURE.TabIndex = 13
        Me.Label_titlePRESSURE.Text = "Atmospheric pressure" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "On Buoy:"
        Me.Label_titlePRESSURE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox_BuoyTemp
        '
        Me.TextBox_BuoyTemp.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_BuoyTemp.Location = New System.Drawing.Point(186, 79)
        Me.TextBox_BuoyTemp.Name = "TextBox_BuoyTemp"
        Me.TextBox_BuoyTemp.Size = New System.Drawing.Size(42, 27)
        Me.TextBox_BuoyTemp.TabIndex = 7
        '
        'Chart_Tempurature
        '
        Me.Chart_Tempurature.BackColor = System.Drawing.Color.Silver
        Me.Chart_Tempurature.BorderlineColor = System.Drawing.Color.Gainsboro
        Me.Chart_Tempurature.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea7.AxisY.LineWidth = 2
        ChartArea7.Name = "ChartArea1"
        Me.Chart_Tempurature.ChartAreas.Add(ChartArea7)
        Me.Chart_Tempurature.Location = New System.Drawing.Point(239, 23)
        Me.Chart_Tempurature.Name = "Chart_Tempurature"
        Series19.BorderWidth = 3
        Series19.ChartArea = "ChartArea1"
        Series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series19.Name = "Temp_OutsideVehicle"
        Series20.BorderWidth = 3
        Series20.ChartArea = "ChartArea1"
        Series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series20.Name = "Temp_InsideVehicle"
        Series21.BorderWidth = 3
        Series21.ChartArea = "ChartArea1"
        Series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series21.Name = "Temp_Buoy"
        Me.Chart_Tempurature.Series.Add(Series19)
        Me.Chart_Tempurature.Series.Add(Series20)
        Me.Chart_Tempurature.Series.Add(Series21)
        Me.Chart_Tempurature.Size = New System.Drawing.Size(391, 171)
        Me.Chart_Tempurature.TabIndex = 11
        Me.Chart_Tempurature.Text = "Chart1"
        '
        'TextBox_VehicleTemp
        '
        Me.TextBox_VehicleTemp.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_VehicleTemp.Location = New System.Drawing.Point(186, 51)
        Me.TextBox_VehicleTemp.Name = "TextBox_VehicleTemp"
        Me.TextBox_VehicleTemp.Size = New System.Drawing.Size(42, 27)
        Me.TextBox_VehicleTemp.TabIndex = 6
        '
        'TextBox_VehicleOUTtemp
        '
        Me.TextBox_VehicleOUTtemp.BackColor = System.Drawing.Color.White
        Me.TextBox_VehicleOUTtemp.Font = New System.Drawing.Font("Meiryo UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_VehicleOUTtemp.Location = New System.Drawing.Point(186, 23)
        Me.TextBox_VehicleOUTtemp.Name = "TextBox_VehicleOUTtemp"
        Me.TextBox_VehicleOUTtemp.Size = New System.Drawing.Size(42, 27)
        Me.TextBox_VehicleOUTtemp.TabIndex = 5
        '
        'Label_VehicleTemp
        '
        Me.Label_VehicleTemp.AutoSize = True
        Me.Label_VehicleTemp.BackColor = System.Drawing.Color.DarkOrange
        Me.Label_VehicleTemp.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_VehicleTemp.Location = New System.Drawing.Point(7, 54)
        Me.Label_VehicleTemp.Name = "Label_VehicleTemp"
        Me.Label_VehicleTemp.Size = New System.Drawing.Size(158, 22)
        Me.Label_VehicleTemp.TabIndex = 4
        Me.Label_VehicleTemp.Text = "Inside the Vehicle"
        Me.Label_VehicleTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Firebrick
        Me.Label6.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Out of Buoy"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 22)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Out of Vehicle"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.GroupBox3.Controls.Add(Me.Label_DATAreceiveTitle)
        Me.GroupBox3.Controls.Add(Me.Label_DATAreceive)
        Me.GroupBox3.Controls.Add(Me.RichTextBox_MessageFlow)
        Me.GroupBox3.Controls.Add(Me.Label_NOWDATAtitle)
        Me.GroupBox3.Controls.Add(Me.LabelNOW)
        Me.GroupBox3.Controls.Add(Me.RichTextBox_Message)
        Me.GroupBox3.Location = New System.Drawing.Point(721, 742)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(503, 228)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message"
        '
        'Label_DATAreceiveTitle
        '
        Me.Label_DATAreceiveTitle.AutoSize = True
        Me.Label_DATAreceiveTitle.Location = New System.Drawing.Point(9, 184)
        Me.Label_DATAreceiveTitle.Name = "Label_DATAreceiveTitle"
        Me.Label_DATAreceiveTitle.Size = New System.Drawing.Size(132, 15)
        Me.Label_DATAreceiveTitle.TabIndex = 4
        Me.Label_DATAreceiveTitle.Text = "NOW RECEIVING : "
        '
        'Label_DATAreceive
        '
        Me.Label_DATAreceive.AutoSize = True
        Me.Label_DATAreceive.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Label_DATAreceive.Location = New System.Drawing.Point(147, 184)
        Me.Label_DATAreceive.Name = "Label_DATAreceive"
        Me.Label_DATAreceive.Size = New System.Drawing.Size(0, 15)
        Me.Label_DATAreceive.TabIndex = 3
        '
        'RichTextBox_MessageFlow
        '
        Me.RichTextBox_MessageFlow.Location = New System.Drawing.Point(263, 24)
        Me.RichTextBox_MessageFlow.Name = "RichTextBox_MessageFlow"
        Me.RichTextBox_MessageFlow.Size = New System.Drawing.Size(234, 129)
        Me.RichTextBox_MessageFlow.TabIndex = 2
        Me.RichTextBox_MessageFlow.Text = ""
        '
        'Label_NOWDATAtitle
        '
        Me.Label_NOWDATAtitle.AutoSize = True
        Me.Label_NOWDATAtitle.Location = New System.Drawing.Point(9, 156)
        Me.Label_NOWDATAtitle.Name = "Label_NOWDATAtitle"
        Me.Label_NOWDATAtitle.Size = New System.Drawing.Size(91, 15)
        Me.Label_NOWDATAtitle.TabIndex = 1
        Me.Label_NOWDATAtitle.Text = "NOW DATA :"
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
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.ComboBox_BaudSelect)
        Me.GroupBox4.Controls.Add(Me.Button_VideoSet)
        Me.GroupBox4.Controls.Add(Me.Button_Connect)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.ComboBox_Mode)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.ComboBox_PortSelect)
        Me.GroupBox4.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(261, 234)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Setting"
        '
        'ComboBox_BaudSelect
        '
        Me.ComboBox_BaudSelect.FormattingEnabled = True
        Me.ComboBox_BaudSelect.Location = New System.Drawing.Point(128, 67)
        Me.ComboBox_BaudSelect.Name = "ComboBox_BaudSelect"
        Me.ComboBox_BaudSelect.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox_BaudSelect.TabIndex = 1
        Me.ComboBox_BaudSelect.Text = "19200"
        '
        'Button_VideoSet
        '
        Me.Button_VideoSet.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_VideoSet.Location = New System.Drawing.Point(123, 174)
        Me.Button_VideoSet.Name = "Button_VideoSet"
        Me.Button_VideoSet.Size = New System.Drawing.Size(132, 39)
        Me.Button_VideoSet.TabIndex = 7
        Me.Button_VideoSet.Text = "Video Set"
        Me.Button_VideoSet.UseVisualStyleBackColor = True
        '
        'Button_Connect
        '
        Me.Button_Connect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button_Connect.Location = New System.Drawing.Point(123, 133)
        Me.Button_Connect.Name = "Button_Connect"
        Me.Button_Connect.Size = New System.Drawing.Size(132, 39)
        Me.Button_Connect.TabIndex = 6
        Me.Button_Connect.Text = "Connect"
        Me.Button_Connect.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Mode"
        '
        'ComboBox_Mode
        '
        Me.ComboBox_Mode.FormattingEnabled = True
        Me.ComboBox_Mode.Location = New System.Drawing.Point(128, 97)
        Me.ComboBox_Mode.Name = "ComboBox_Mode"
        Me.ComboBox_Mode.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox_Mode.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Baud Select"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Meiryo UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Port Select"
        '
        'ComboBox_PortSelect
        '
        Me.ComboBox_PortSelect.FormattingEnabled = True
        Me.ComboBox_PortSelect.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboBox_PortSelect.Location = New System.Drawing.Point(128, 33)
        Me.ComboBox_PortSelect.Name = "ComboBox_PortSelect"
        Me.ComboBox_PortSelect.Size = New System.Drawing.Size(121, 30)
        Me.ComboBox_PortSelect.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(67, 4)
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureBox1.Location = New System.Drawing.Point(6, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(951, 559)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Timer_DriverConnectionCheck
        '
        Me.Timer_DriverConnectionCheck.Interval = 5000
        '
        'Timer_BuoyConnectionCheck
        '
        Me.Timer_BuoyConnectionCheck.Interval = 5000
        '
        'GroupBox_Video
        '
        Me.GroupBox_Video.Controls.Add(Me.PictureBox1)
        Me.GroupBox_Video.Font = New System.Drawing.Font("Meiryo UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Video.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox_Video.Location = New System.Drawing.Point(687, 51)
        Me.GroupBox_Video.Name = "GroupBox_Video"
        Me.GroupBox_Video.Size = New System.Drawing.Size(963, 638)
        Me.GroupBox_Video.TabIndex = 11
        Me.GroupBox_Video.TabStop = False
        Me.GroupBox_Video.Text = "Main Camera on Vehicle"
        '
        'Timer_TemperatureRecorder
        '
        Me.Timer_TemperatureRecorder.Interval = 1000
        '
        'Chart_TemperatureBigger
        '
        Me.Chart_TemperatureBigger.BackColor = System.Drawing.Color.Silver
        Me.Chart_TemperatureBigger.BorderlineColor = System.Drawing.Color.Gainsboro
        Me.Chart_TemperatureBigger.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea8.AxisY.LineWidth = 2
        ChartArea8.Name = "ChartArea1"
        Me.Chart_TemperatureBigger.ChartAreas.Add(ChartArea8)
        Me.Chart_TemperatureBigger.Location = New System.Drawing.Point(251, 324)
        Me.Chart_TemperatureBigger.Name = "Chart_TemperatureBigger"
        Series22.BorderWidth = 3
        Series22.ChartArea = "ChartArea1"
        Series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series22.Name = "Temp_OutsideVehicle"
        Series23.BorderWidth = 3
        Series23.ChartArea = "ChartArea1"
        Series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series23.Name = "Temp_InsideVehicle"
        Series24.BorderWidth = 3
        Series24.ChartArea = "ChartArea1"
        Series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series24.Name = "Temp_Buoy"
        Me.Chart_TemperatureBigger.Series.Add(Series22)
        Me.Chart_TemperatureBigger.Series.Add(Series23)
        Me.Chart_TemperatureBigger.Series.Add(Series24)
        Me.Chart_TemperatureBigger.Size = New System.Drawing.Size(1202, 436)
        Me.Chart_TemperatureBigger.TabIndex = 12
        Me.Chart_TemperatureBigger.Text = "Chart1"
        Me.Chart_TemperatureBigger.Visible = False
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(608, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(27, 22)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "m"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.ClientSize = New System.Drawing.Size(1662, 1003)
        Me.Controls.Add(Me.Chart_TemperatureBigger)
        Me.Controls.Add(Me.GroupBox_Video)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox_ControlPanel.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.Chart_Tempurature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Video.ResumeLayout(False)
        CType(Me.Chart_TemperatureBigger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_BuoyReelDown As Button
    Friend WithEvents Button_BuoyReelUp As Button
    Friend WithEvents Button_VehicleStop As Button
    Friend WithEvents Button_VehicleLeft As Button
    Friend WithEvents Button_VehicleBackward As Button
    Friend WithEvents Button_VehicleRight As Button
    Friend WithEvents Button_VehicleForward As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents GroupBox_ControlPanel As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents 說明ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 設定ToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents Label_NOWDATAtitle As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TextBox_Altitude As TextBox
    Friend WithEvents TextBox_Lontitude As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBox_BuoyTemp As TextBox
    Friend WithEvents TextBox_VehicleTemp As TextBox
    Friend WithEvents TextBox_VehicleOUTtemp As TextBox
    Friend WithEvents Label_VehicleTemp As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Latitude As TextBox
    Friend WithEvents Label_BuoyFacing As Label
    Friend WithEvents Label_BuoyFacingAngle As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents RichTextBox_MessageFlow As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button_VideoSet As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox_MapZoom As TextBox
    Friend WithEvents Chart_Tempurature As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button_BuoyStop As Button
    Friend WithEvents Button_BuoyLeft As Button
    Friend WithEvents Button_BuoyBackward As Button
    Friend WithEvents Button_BuoyRight As Button
    Friend WithEvents Button_BuoyForward As Button
    Friend WithEvents Button_VehicleLight As Button
    Friend WithEvents Button_BuoyReelStop As Button
    Friend WithEvents Label_DATAreceiveTitle As Label
    Friend WithEvents Label_DATAreceive As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As ToolStripStatusLabel
    Friend WithEvents Timer_DriverConnectionCheck As Timer
    Friend WithEvents Timer_BuoyConnectionCheck As Timer
    Friend WithEvents GroupBox_Video As GroupBox
    Friend WithEvents Button_mapZoomOUT As Button
    Friend WithEvents Button_mapZoomIN As Button
    Friend WithEvents Timer_TemperatureRecorder As Timer
    Friend WithEvents Chart_TemperatureBigger As DataVisualization.Charting.Chart
    Friend WithEvents Label7 As Label
    Friend WithEvents Label_VehicleFacing As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label_VehicleFacingAngel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_titlePRESSURE As Label
    Friend WithEvents Label17 As Label
End Class
