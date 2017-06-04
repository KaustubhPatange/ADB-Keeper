<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportADBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KillServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowDevicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootNormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootRecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootBootloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryToAndroidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryToBootloaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastbootToAndroidToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisitWebpageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(254, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportADBToolStripMenuItem, Me.KillServerToolStripMenuItem, Me.ShowDevicesToolStripMenuItem, Me.RebootToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'ImportADBToolStripMenuItem
        '
        Me.ImportADBToolStripMenuItem.Name = "ImportADBToolStripMenuItem"
        Me.ImportADBToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ImportADBToolStripMenuItem.Text = "Start Server"
        '
        'KillServerToolStripMenuItem
        '
        Me.KillServerToolStripMenuItem.Name = "KillServerToolStripMenuItem"
        Me.KillServerToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.KillServerToolStripMenuItem.Text = "Kill Server"
        '
        'ShowDevicesToolStripMenuItem
        '
        Me.ShowDevicesToolStripMenuItem.Name = "ShowDevicesToolStripMenuItem"
        Me.ShowDevicesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ShowDevicesToolStripMenuItem.Text = "Show Devices"
        '
        'RebootToolStripMenuItem
        '
        Me.RebootToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RebootNormalToolStripMenuItem, Me.RebootRecoveryToolStripMenuItem, Me.RebootBootloaderToolStripMenuItem, Me.RecoveryToAndroidToolStripMenuItem, Me.RecoveryToBootloaderToolStripMenuItem, Me.FastbootToAndroidToolStripMenuItem})
        Me.RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
        Me.RebootToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RebootToolStripMenuItem.Text = "Reboot"
        '
        'RebootNormalToolStripMenuItem
        '
        Me.RebootNormalToolStripMenuItem.Name = "RebootNormalToolStripMenuItem"
        Me.RebootNormalToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RebootNormalToolStripMenuItem.Text = "Reboot Normal"
        '
        'RebootRecoveryToolStripMenuItem
        '
        Me.RebootRecoveryToolStripMenuItem.Name = "RebootRecoveryToolStripMenuItem"
        Me.RebootRecoveryToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RebootRecoveryToolStripMenuItem.Text = "Reboot Recovery"
        '
        'RebootBootloaderToolStripMenuItem
        '
        Me.RebootBootloaderToolStripMenuItem.Name = "RebootBootloaderToolStripMenuItem"
        Me.RebootBootloaderToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RebootBootloaderToolStripMenuItem.Text = "Reboot Bootloader"
        '
        'RecoveryToAndroidToolStripMenuItem
        '
        Me.RecoveryToAndroidToolStripMenuItem.Name = "RecoveryToAndroidToolStripMenuItem"
        Me.RecoveryToAndroidToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RecoveryToAndroidToolStripMenuItem.Text = "Recovery to Android"
        '
        'RecoveryToBootloaderToolStripMenuItem
        '
        Me.RecoveryToBootloaderToolStripMenuItem.Name = "RecoveryToBootloaderToolStripMenuItem"
        Me.RecoveryToBootloaderToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.RecoveryToBootloaderToolStripMenuItem.Text = "Recovery to Bootloader"
        '
        'FastbootToAndroidToolStripMenuItem
        '
        Me.FastbootToAndroidToolStripMenuItem.Name = "FastbootToAndroidToolStripMenuItem"
        Me.FastbootToAndroidToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.FastbootToAndroidToolStripMenuItem.Text = "Fastboot to Android"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisitWebpageToolStripMenuItem, Me.HelpSupportToolStripMenuItem, Me.OpenSourceToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'VisitWebpageToolStripMenuItem
        '
        Me.VisitWebpageToolStripMenuItem.Name = "VisitWebpageToolStripMenuItem"
        Me.VisitWebpageToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.VisitWebpageToolStripMenuItem.Text = "Visit Webpage"
        '
        'HelpSupportToolStripMenuItem
        '
        Me.HelpSupportToolStripMenuItem.Name = "HelpSupportToolStripMenuItem"
        Me.HelpSupportToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.HelpSupportToolStripMenuItem.Text = "Help && Support"
        '
        'OpenSourceToolStripMenuItem
        '
        Me.OpenSourceToolStripMenuItem.Name = "OpenSourceToolStripMenuItem"
        Me.OpenSourceToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OpenSourceToolStripMenuItem.Text = "Open Source"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 95)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Main "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(64, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 26)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Uninstall App"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 26)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Install App"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 126)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manager"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(64, 83)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 26)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Sideload File"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(64, 51)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 26)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Pull Files"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(64, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(91, 26)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Push Files"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 262)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 127)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tweaks"
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(63, 83)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(91, 26)
        Me.Button8.TabIndex = 17
        Me.Button8.Text = "Screen Record"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(63, 51)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(91, 26)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "ScreenShot"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(63, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(91, 26)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "Logcat"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkRed
        Me.PictureBox1.Location = New System.Drawing.Point(13, 398)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 401)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Status : None"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(201, 398)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(41, 23)
        Me.Button9.TabIndex = 14
        Me.Button9.Text = "Stop"
        Me.Button9.UseVisualStyleBackColor = True
        Me.Button9.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(254, 430)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "ADB Keeper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportADBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KillServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShowDevicesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RebootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RebootNormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RebootRecoveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RebootBootloaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoveryToAndroidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoveryToBootloaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastbootToAndroidToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VisitWebpageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpSupportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenSourceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button9 As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
