﻿Public Class frm_install_password
    Private Sub frm_install_password_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cfg.install_password_mode = 0 Then
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            GroupBox2.Enabled = False
            cfg.install_password_mode = 0
            cfg.install_password_success = 1
        Else
            RadioButton2.Checked = True
            GroupBox2.Enabled = True
            cfg.install_password_mode = 1
            If TextBox3.Text = "" Then
                cfg.install_password_success = 0
            Else
                cfg.install_password_success = 1
            End If
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            GroupBox1.Enabled = False
            cfg.install_password_mode = 1
            If TextBox3.Text = "" Then
                cfg.install_password_success = 0
            Else
                cfg.install_password_success = 1
            End If
        Else
            RadioButton1.Checked = True
            GroupBox1.Enabled = True
            cfg.install_password_mode = 0
            cfg.install_password_success = 1
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        cfg.install_password_custom = TextBox3.Text
        If TextBox3.Text = "" Then
            cfg.install_password_success = 0
        Else
            cfg.install_password_success = 1
        End If
    End Sub
End Class