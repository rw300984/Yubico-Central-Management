Public Class frm_install_update
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            GroupBox2.Enabled = False
        Else
            RadioButton2.Checked = True
            GroupBox2.Enabled = True
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            GroupBox1.Enabled = False
        Else
            RadioButton1.Checked = True
            GroupBox1.Enabled = True
        End If
    End Sub
End Class