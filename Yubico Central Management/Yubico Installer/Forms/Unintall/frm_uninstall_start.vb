Public Class frm_uninstall_start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        My.Forms.frm_main.ShowForms("frm_uninstall_uninstall")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        My.Forms.frm_main.ShowForms("frm_main_action")
    End Sub
End Class