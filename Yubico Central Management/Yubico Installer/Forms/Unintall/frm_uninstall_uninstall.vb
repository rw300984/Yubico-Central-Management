Imports System.ComponentModel

Public Class frm_uninstall_uninstall
    Dim uninstall_status As String = ""

    Private Sub frm_uninstall_uninstall_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            bgw_uninstall.RunWorkerAsync()
        End If
    End Sub


    Public Function SmoothProgressBarStatusForward()
        For i = 1 To 100
            CustomizableProgressBar1.Value = i
            Threading.Thread.Sleep(10)
        Next
    End Function

    Private Sub bgw_uninstall_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_uninstall.DoWork
        cfg.install_rollback_status = StopAllServicesAndProcess()
        bgw_uninstall.ReportProgress(100, "StopAllServicesAndProcess")
        cfg.install_rollback_status = UninstallService(cfg.install_path_custom & "\services\Yubico Agent Service.exe")
        bgw_uninstall.ReportProgress(100, "UninstallService")
        cfg.install_rollback_status = UnRegisterDLLs(cfg.install_path_custom & "\plugins\ykclient\yubiclientapi.dll")
        bgw_uninstall.ReportProgress(100, "UnregisterDll")
        cfg.install_rollback_status = UnregisterInstallation(cfg.install_path_custom)
        bgw_uninstall.ReportProgress(100, "UnregisterInstall")
        cfg.install_rollback_status = RemoveFolderStructure(cfg.install_path_custom)
        bgw_uninstall.ReportProgress(100, "RemoveFolderStructure")
    End Sub

    Private Sub bgw_uninstall_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_uninstall.ProgressChanged
        Select Case TryCast(e.UserState, String)
            Case "StopAllServicesAndProcess"
                lbl_uninstall_status.Text = "Uninstall: Stop services and processes..."
                lbl_uninstall_status.Update()
                CustomizableProgressBar2.Value = 20
                SmoothProgressBarStatusForward()
            Case "UninstallService"
                lbl_uninstall_status.Text = "Uninstall: Uninstall Yubico Agent service..."
                lbl_uninstall_status.Update()
                CustomizableProgressBar2.Value = 40
                SmoothProgressBarStatusForward()
            Case "UnregisterDll"
                lbl_uninstall_status.Text = "Uninstall: Unregister plugins..."
                lbl_uninstall_status.Update()
                CustomizableProgressBar2.Value = 60
                SmoothProgressBarStatusForward()
            Case "UnregisterInstall"
                lbl_uninstall_status.Text = "Uninstall: Remove installer entries..."
                lbl_uninstall_status.Update()
                CustomizableProgressBar2.Value = 80
                SmoothProgressBarStatusForward()
            Case "RemoveFolderStructure"
                lbl_uninstall_status.Text = "Uninstall: Remove files and folders..."
                lbl_uninstall_status.Update()
                CustomizableProgressBar2.Value = 100
                SmoothProgressBarStatusForward()
        End Select
    End Sub

    Private Sub bgw_uninstall_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_uninstall.RunWorkerCompleted
        lbl_uninstall_status.Text = "Uninstallation successfully completed."
        lbl_uninstall_status.Update()
        My.Forms.frm_main.btn_main_next.Visible = True
        My.Forms.frm_main.btn_main_next.Enabled = True
    End Sub
End Class