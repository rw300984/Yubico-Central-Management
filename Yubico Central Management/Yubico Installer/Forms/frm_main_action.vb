Public Class frm_main_action
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