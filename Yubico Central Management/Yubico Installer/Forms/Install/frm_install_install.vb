Imports System.ComponentModel

Public Class frm_install_install

    Private Sub frm_install_install_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            My.Forms.frm_main.btn_main_next.Visible = False
            My.Forms.frm_main.btn_main_next.Enabled = False
            bgw_install.RunWorkerAsync()
        End If
    End Sub

    Private Sub bgw_install_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_install.DoWork
        Dim install_path As String
        Dim password As String
        If cfg.install_path_mode = 0 Then
            install_path = cfg.install_path_default
        Else
            install_path = cfg.install_path_custom
        End If
        If cfg.install_password_mode = 0 Then
            password = cfg.install_password_random
        Else
            password = cfg.install_password_custom
        End If
        bgw_install.ReportProgress(100, "Prepare")
        cfg.install_success_status = StopAllServicesAndProcess()
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "StopService")
        cfg.install_success_status = CreateFolderStructure(install_path)
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "CreateFolder")
        cfg.install_success_status = SetPermissions(install_path)
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "SetPermissions")
        cfg.install_success_status = ExtractApplication(install_path)
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "ExtractAgent")
        cfg.install_success_status = RegisterDLLs(install_path & "\plugins\ykclient\yubiclientapi.dll")
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "RegisterDLL")
        cfg.install_success_status = RegisterInstallation(install_path)
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "RegisterInstall")
        cfg.install_success_status = InstallService(install_path & "\services\Yubico Agent Service.exe")
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "InstallService")
        cfg.install_success_status = GenerateDefaultConfig(install_path, password)
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "DefaultConfig")
        cfg.install_success_status = StartService()
        If cfg.install_success_status = 0 Then
            Exit Sub
        End If
        bgw_install.ReportProgress(100, "StartService")
    End Sub

    Private Sub bgw_install_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_install.ProgressChanged
        Select Case TryCast(e.UserState, String)
            Case "Prepare"
                lbl_install_install_status.Text = "Successfully prepared necessary variables..."
                lbl_install_install_status.Update()
                CustomizableProgressBar2.Value = 10
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
            Case "StopService"
                lbl_install_install_status.Text = "Check if Agent process or service is running..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic2
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 20
            Case "CreateFolder"
                lbl_install_install_status.Text = "Create Yubico agent directory..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic3
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 30
            Case "SetPermissions"
                lbl_install_install_status.Text = "Set permissions on Yubico Agent directory..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic4
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 40
            Case "ExtractAgent"
                lbl_install_install_status.Text = "Extract Agent from installer and copy to directory..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 50
            Case "RegisterDLL"
                lbl_install_install_status.Text = "Register Plugin Libraries..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic2
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 60
            Case "RegisterInstall"
                lbl_install_install_status.Text = "Register installation to Windows Installer libraries..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic3
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 70
            Case "InstallService"
                lbl_install_install_status.Text = "Install Yubico Agent Service..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic4
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 80
            Case "DefaultConfig"
                lbl_install_install_status.Text = "Generate initial configuration..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 90
            Case "StartService"
                lbl_install_install_status.Text = "Start Yubico Agent Service..."
                lbl_install_install_status.Update()
                SmoothProgressBarStatusForward()
                PictureBox1.Image = My.Resources.install_pic2
                PictureBox1.Update()
                CustomizableProgressBar2.Value = 100
        End Select
    End Sub

    Public Function SmoothProgressBarStatusForward()
        For i = 1 To 100
            CustomizableProgressBar1.Value = i
            Threading.Thread.Sleep(10)
        Next
    End Function

    Public Function SmoothProgressBarStatusrewind()
        Dim count As Integer = 100
        Do While count >= 1
            CustomizableProgressBar1.Value = count
            Threading.Thread.Sleep(10)
            count = count - 1
        Loop
    End Function

    Private Sub bgw_install_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_install.RunWorkerCompleted
        If cfg.install_success_status = 0 Then
            bgw_rollback.RunWorkerAsync()
        Else
            lbl_install_install_status.Text = "Installation successfully finished."
            lbl_install_install_status.Update()
            My.Forms.frm_main.btn_main_next.Visible = True
            My.Forms.frm_main.btn_main_next.Enabled = True
        End If
    End Sub

    Private Sub bgw_rollback_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgw_rollback.DoWork
        Dim install_path As String
        If cfg.install_path_mode = 0 Then
            install_path = cfg.install_path_default
        Else
            install_path = cfg.install_path_custom
        End If
        cfg.install_rollback_status = StopAllServicesAndProcess()
        bgw_rollback.ReportProgress(100, "StopAllServicesAndProcess")
        cfg.install_rollback_status = UninstallService(install_path & "\services\Yubico Agent Service.exe")
        bgw_rollback.ReportProgress(100, "UninstallService")
        cfg.install_rollback_status = UnRegisterDLLs(install_path & "\plugins\ykclient\yubiclientapi.dll")
        bgw_rollback.ReportProgress(100, "UnregisterDll")
        cfg.install_rollback_status = UnregisterInstallation(install_path)
        bgw_rollback.ReportProgress(100, "UnregisterInstall")
        cfg.install_rollback_status = RemoveFolderStructure(install_path)
        bgw_rollback.ReportProgress(100, "RemoveFolderStructure")
    End Sub

    Private Sub bgw_rollback_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_rollback.ProgressChanged
        Select Case TryCast(e.UserState, String)
            Case "StopAllServicesAndProcess"

                lbl_install_install_status.Text = "Rollback: Stop services and processes..."
                lbl_install_install_status.Update()
                CustomizableProgressBar2.Value = 20
                SmoothProgressBarStatusrewind()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
            Case "UninstallService"

                lbl_install_install_status.Text = "Rollback: Uninstall Yubico Agent service..."
                lbl_install_install_status.Update()
                CustomizableProgressBar2.Value = 40
                SmoothProgressBarStatusrewind()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
            Case "UnregisterDll"

                lbl_install_install_status.Text = "Rollback: Unregister plugins..."
                lbl_install_install_status.Update()
                CustomizableProgressBar2.Value = 60
                SmoothProgressBarStatusrewind()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
            Case "UnregisterInstall"

                lbl_install_install_status.Text = "Rollback: Remove installer entries..."
                lbl_install_install_status.Update()
                CustomizableProgressBar2.Value = 80
                SmoothProgressBarStatusrewind()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
            Case "RemoveFolderStructure"

                lbl_install_install_status.Text = "Rollback: Remove installer entries..."
                lbl_install_install_status.Update()
                CustomizableProgressBar2.Value = 100
                SmoothProgressBarStatusrewind()
                PictureBox1.Image = My.Resources.install_pic1
                PictureBox1.Update()
        End Select
    End Sub

    Private Sub bgw_rollback_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_rollback.RunWorkerCompleted
        lbl_install_install_status.Text = "Rollback successfull. Please try to reinstall"
        lbl_install_install_status.Update()
        My.Forms.frm_main.btn_main_next.Visible = True
        My.Forms.frm_main.btn_main_next.Enabled = True
    End Sub
End Class