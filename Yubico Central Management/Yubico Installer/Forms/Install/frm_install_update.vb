﻿Public Class frm_install_update
    Private Sub frm_install_update_Load(sender As Object, e As EventArgs) Handles Me.Load
        RadioButton2.Checked = True
        ' If cfg.install_update_mode = 0 Then
        'RadioButton1.Checked = True
        'End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
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

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            GroupBox1.Enabled = False
            cfg.install_update_mode = 1
        Else
            '  RadioButton1.Checked = True
            ' GroupBox1.Enabled = True
            ' cfg.install_update_mode = 0
        End If
    End Sub
End Class