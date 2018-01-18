Public Class frm_admin_save
    Private Sub btn_admin_save_yes_Click(sender As Object, e As EventArgs) Handles btn_admin_save_yes.Click
        If My.Forms.frm_main.IntegrityCheck(1) > 0 Then
            My.Forms.frm_main.IntegrityFailedFor_btn_admin_login()
        Else
            Config.Write_Config("config.xml", cfg_config.initial_verify)
            Config.GetConfig("config.xml", cfg_config.initial_verify)
            My.Forms.frm_main.FillControlsWithConfig()
            My.Forms.frm_main.ShowForms("frm_monitor")
        End If
    End Sub
    Private Sub btn_admin_save_no_Click(sender As Object, e As EventArgs) Handles btn_admin_save_no.Click
        My.Forms.frm_main.ShowForms("frm_monitor")
    End Sub
End Class