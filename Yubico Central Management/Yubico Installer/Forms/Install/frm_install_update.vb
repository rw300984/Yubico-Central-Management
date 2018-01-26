Public Class frm_install_update
    Private Sub frm_install_update_Load(sender As Object, e As EventArgs) Handles Me.Load

        If cfg.install_update_mode = 0 Then
            RadioButton1.Checked = True
        Else
            RadioButton2.Checked = True
        End If
    End Sub

    Private Sub RadioButtons_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            GroupBox2.Enabled = False
            cfg.install_update_mode = 0
        Else
            RadioButton2.Checked = True
            GroupBox2.Enabled = True
            cfg.install_update_mode = 1
        End If

    End Sub
End Class