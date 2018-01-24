Imports Microsoft.Win32

Public Class frm_main_action

    Private Sub frm_main_action_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim key As RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Yubico Agent (Alpha)", False)
            If key IsNot Nothing Then
                RadioButton1.Enabled = False
                RadioButton2.Checked = True
                RadioButton2.Enabled = True
                RadioButton3.Enabled = True
                RadioButton4.Enabled = True
                RadioButton1.Text = "Install (already installed)"
            Else
                RadioButton1.Enabled = True
                RadioButton1.Checked = True
                RadioButton1.Text = "Install"
                RadioButton2.Enabled = False
                RadioButton3.Enabled = False
                RadioButton4.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            TextBox1.Enabled = True
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            cfg.main_action = 1
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            RadioButton3.Checked = False
            RadioButton4.Checked = False
            TextBox1.Enabled = False
            TextBox2.Enabled = True
            TextBox3.Enabled = False
            TextBox4.Enabled = False
            cfg.main_action = 2
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            RadioButton2.Checked = False
            RadioButton1.Checked = False
            RadioButton4.Checked = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = True
            TextBox4.Enabled = False
            cfg.main_action = 3
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            RadioButton2.Checked = False
            RadioButton3.Checked = False
            RadioButton1.Checked = False
            TextBox1.Enabled = False
            TextBox2.Enabled = False
            TextBox3.Enabled = False
            TextBox4.Enabled = True
            cfg.main_action = 4
        End If
    End Sub
End Class