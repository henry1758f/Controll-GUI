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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RichTextBox_Message = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button_Connect = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_Mode = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox_BaudSelect = New System.Windows.Forms.ComboBox()
        Me.ComboBox_PortSelect = New System.Windows.Forms.ComboBox()
        Me.LabelNOW = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox_ControlPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(1047, 27)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 454)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1047, 22)
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
        Me.Panel1.Location = New System.Drawing.Point(38, 24)
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
        Me.GroupBox_ControlPanel.Location = New System.Drawing.Point(281, 30)
        Me.GroupBox_ControlPanel.Name = "GroupBox_ControlPanel"
        Me.GroupBox_ControlPanel.Size = New System.Drawing.Size(397, 414)
        Me.GroupBox_ControlPanel.TabIndex = 4
        Me.GroupBox_ControlPanel.TabStop = False
        Me.GroupBox_ControlPanel.Text = "Control Panel"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(20, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 239)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vehicle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LabelNOW)
        Me.GroupBox2.Location = New System.Drawing.Point(684, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 190)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RichTextBox_Message)
        Me.GroupBox3.Location = New System.Drawing.Point(684, 226)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(351, 218)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message"
        '
        'RichTextBox_Message
        '
        Me.RichTextBox_Message.Location = New System.Drawing.Point(12, 24)
        Me.RichTextBox_Message.Name = "RichTextBox_Message"
        Me.RichTextBox_Message.Size = New System.Drawing.Size(339, 188)
        Me.RichTextBox_Message.TabIndex = 0
        Me.RichTextBox_Message.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button_Connect)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.ComboBox_Mode)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.ComboBox_BaudSelect)
        Me.GroupBox4.Controls.Add(Me.ComboBox_PortSelect)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 408)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Setting and Configuration"
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
        'LabelNOW
        '
        Me.LabelNOW.AutoSize = True
        Me.LabelNOW.Location = New System.Drawing.Point(46, 25)
        Me.LabelNOW.Name = "LabelNOW"
        Me.LabelNOW.Size = New System.Drawing.Size(46, 15)
        Me.LabelNOW.TabIndex = 0
        Me.LabelNOW.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1047, 476)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox_ControlPanel)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "SCH01 - v0.1.0"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox_ControlPanel.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
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
End Class
