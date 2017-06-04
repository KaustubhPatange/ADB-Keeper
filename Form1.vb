Imports RegawMOD.Android
Imports KPMod.mfastboot

Public Class Form1
    Delegate Sub UpdateTextBoxDelg(text As String)
    Public myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateTextBox)
    Dim android As AndroidController
    Dim device As Device
    Public Sub UpdateTextBox(text As String)
    End Sub

    Public Sub proc_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        If Me.InvokeRequired = True Then
            Me.Invoke(myDelegate, e.Data)
        Else
            UpdateTextBox(e.Data)
        End If
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        android = AndroidController.Instance

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        android.UpdateDeviceList()
        If (android.HasConnectedDevices) Then
            PictureBox1.BackColor = Color.Lime
        Else
            PictureBox1.BackColor = Color.Maroon
            Label1.Text = "Status : None"
        End If
    End Sub

    Private Sub ImportADBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportADBToolStripMenuItem.Click
        Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("start-server"))
        Label1.Text = "Status : Server Started..!"
    End Sub

    Private Sub KillServerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillServerToolStripMenuItem.Click
        Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("kill-server"))
        Label1.Text = "Status : Server Stopped..!"
    End Sub

    Private Sub ShowDevicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowDevicesToolStripMenuItem.Click
        If PictureBox1.BackColor = Color.Lime Then
            Dim test = Adb.ExecuteAdbCommand(Adb.FormAdbCommand("devices"))
            MsgBox(test)
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub RebootNormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootNormalToolStripMenuItem.Click
        If PictureBox1.BackColor = Color.Lime Then
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot"))
            Label1.Text = "Status : Device Rebooting..!"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub RebootRecoveryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootRecoveryToolStripMenuItem.Click
        If PictureBox1.BackColor = Color.Lime Then
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot recovery"))
            Label1.Text = "Status : Device Rebooting to Recovery..!"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub RebootBootloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootBootloaderToolStripMenuItem.Click
        If PictureBox1.BackColor = Color.Lime Then
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot bootloader"))
            Label1.Text = "Status : Device Rebooting to Fastboot..!"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub RecoveryToAndroidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryToAndroidToolStripMenuItem.Click
        If PictureBox1.BackColor = Color.Lime Then
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot"))
            Label1.Text = "Status : Device Rebooting..!"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub RecoveryToBootloaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryToBootloaderToolStripMenuItem.Click
        If PictureBox1.BackColor = Color.Lime Then
            Adb.ExecuteAdbCommand(Adb.FormAdbCommand("reboot recovery"))
            Label1.Text = "Status : Device Rebooting to Recovery..!"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub FastbootToAndroidToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastbootToAndroidToolStripMenuItem.Click
        Reboot_continue()
        Label1.Text = "Status : Device Rebooting to Android..!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If PictureBox1.BackColor = Color.Lime Then
            OpenFileDialog1.Filter = "Apk Files|*.apk;*.zip|All Files|*.*"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim pathname = """" + OpenFileDialog1.FileName + """"
                Label1.Text = "Status : Installing App..!"
                Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("install -r", pathname))
                Label1.Text = "Status : Done..!"
            End If
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PictureBox1.BackColor = Color.Lime Then
            Dim a = InputBox("Enter Package Name of App", "Give an Input")
            Adb.ExecuteAdbCommandNoReturn(Adb.FormAdbCommand("uninstall", a))
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If PictureBox1.BackColor = Color.Lime Then
            OpenFileDialog1.Filter = "All Files|*.*"
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim temp = """" + OpenFileDialog1.FileName + """"
                Dim p As New Process()
                p.StartInfo.FileName = "adb.exe"
                p.StartInfo.Arguments = "push " + temp + " /sdcard/" + OpenFileDialog1.SafeFileName
                p.StartInfo.UseShellExecute = False
                p.StartInfo.CreateNoWindow = True
                p.EnableRaisingEvents = True
                p.Start()
                Do Until p.HasExited()
                    Label1.Text = "Status : Working..!"
                Loop
                Label1.Text = "Status : File Pushed..!"
            Else
                Label1.Text = "Status : No Device Connected !"
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If PictureBox1.BackColor = Color.Lime Then
            Dim a = InputBox("Enter Directory Path of Filename", "Give an Input")

            Dim p As New Process()
            p.StartInfo.FileName = "adb.exe"
            p.StartInfo.Arguments = "pull " + a + " Backups"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = True
            p.EnableRaisingEvents = True
            p.Start()
            Do Until p.HasExited()
                Label1.Text = "Status : Working..!"
            Loop
            Label1.Text = "Status : File Pulled to Backups..!"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If PictureBox1.BackColor = Color.Lime Then
            OpenFileDialog1.Filter = "Zip Files|*.zip|All Files|*.*"
            MsgBox("Make Sure your Phone is in Sideload Mode" + Environment.NewLine + "To do it boot your Phone to recovery mode, click on Advance then Sideload in TWRP !")
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Dim passon = """" + OpenFileDialog1.FileName + """"
                Dim p As New Process()
                p.StartInfo.FileName = "adb.exe"
                p.StartInfo.Arguments = "sideload " + passon
                p.StartInfo.RedirectStandardError = True
                p.StartInfo.RedirectStandardOutput = True
                p.StartInfo.UseShellExecute = False
                p.StartInfo.CreateNoWindow = True
                p.EnableRaisingEvents = True
                Application.DoEvents()
                AddHandler p.ErrorDataReceived, AddressOf proc_OutputDataReceived
                AddHandler p.OutputDataReceived, AddressOf proc_OutputDataReceived
                p.Start()
                p.BeginErrorReadLine()
                p.BeginOutputReadLine()
                Do Until p.HasExited()
                    GroupBox1.Enabled = False
                    GroupBox2.Enabled = False
                    GroupBox3.Enabled = False
                    Label1.Text = "Status : Working.. !"
                Loop
                GroupBox1.Enabled = True
                GroupBox2.Enabled = True
                GroupBox3.Enabled = True
                Button9.Visible = False
                Label1.Text = "Status : Done.. !"
            End If
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If PictureBox1.BackColor = Color.Lime Then
            Dim p As New Process()
            p.StartInfo.FileName = "logfunctions.bat"
            p.Start()
            Do Until p.HasExited()
            Loop
            Label1.Text = "Status : Done.. !"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For Each p1 As Process In Process.GetProcessesByName("adb.exe")
            p1.Kill()
            p1.Close()
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If PictureBox1.BackColor = Color.Lime Then
            SaveFileDialog1.Filter = "Png Files|*.png"
            Dim tmp = """" + SaveFileDialog1.FileName + """"
            Dim p As New Process()
            p.StartInfo.FileName = "screencap.bat"
            p.StartInfo.UseShellExecute = False
            p.StartInfo.CreateNoWindow = True
            p.Start()
            Do Until p.HasExited
            Loop
            Label1.Text = "Status : Screenshot Saved !"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If PictureBox1.BackColor = Color.Lime Then
            Dim tmp = """" + SaveFileDialog1.FileName + """"
            Dim p As New Process()
            p.StartInfo.FileName = "screenrecord.bat"
            p.Start()
            Do Until p.HasExited
            Loop
            Dim p1 As New Process()
            p1.StartInfo.FileName = "adb.exe"
            p1.StartInfo.Arguments = "pull /sdcard/record.mp4 Backups"
            p1.StartInfo.UseShellExecute = False
            p1.StartInfo.CreateNoWindow = True
            p1.Start()
            Label1.Text = "Status : ScreenRecord Saved !"
        Else
            Label1.Text = "Status : No Device Connected !"
        End If
    End Sub

    Private Sub OpenSourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenSourceToolStripMenuItem.Click
        Process.Start("https://github.com/KaustubhPatange/ADB-Keeper")
    End Sub

    Private Sub HelpSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpSupportToolStripMenuItem.Click
        Process.Start("http://developerkp.capstricks.net/index.php/support/")
    End Sub

    Private Sub VisitWebpageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisitWebpageToolStripMenuItem.Click
        Process.Start("http://wp.me/p8uAVI-4D")
    End Sub
End Class
