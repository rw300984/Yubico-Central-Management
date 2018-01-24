Public Class frm_install_start
    Private Sub frm_install_start_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            FillInstallSummary()
        End If
    End Sub

    Public Function FillInstallSummary()
        If cfg.install_update_mode = 0 Then
            lbl_install_start_install_mode.Text = "Online Installation"
        Else
            lbl_install_start_install_mode.Text = "Offline Installation"
        End If
        If cfg.install_path_mode = 0 Then
            lbl_install_start_install_path.Text = cfg.install_path_default
        Else
            lbl_install_start_install_path.Text = cfg.install_path_custom
        End If
        If cfg.install_password_mode = 0 Then
            lbl_install_start_install_password.Text = "Random generated"
        Else
            lbl_install_start_install_password.Text = "Custom password"
        End If
        If cfg.install_options_mode = "Personal" Then
            lbl_install_start_install_agent_mode.Text = "Personal"
        Else
            lbl_install_start_install_agent_mode.Text = "Business (" & cfg.install_options_business_auth & ")"
        End If
    End Function
End Class