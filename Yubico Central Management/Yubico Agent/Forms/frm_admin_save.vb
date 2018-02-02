Public Class frm_admin_save
    Private Sub btn_admin_save_yes_Click(sender As Object, e As EventArgs) Handles btn_admin_save_yes.Click
        Dim user As auth_user = plg_auth.GetUserFromDB()
        Config.AddConfigGeneralToDB(My.Forms.frm_main.machinekey_cache, cfg_config)
        cfg_config = Config.GetConfigGeneralFromDB(My.Forms.frm_main.machinekey_cache)

        My.Forms.frm_main.FillGlobalFixedVariables()
        My.Forms.frm_main.FillControlsWithConfig()
        My.Forms.frm_main.ShowForms("frm_monitor")
        '' End If
    End Sub
    Private Sub btn_admin_save_no_Click(sender As Object, e As EventArgs) Handles btn_admin_save_no.Click
        My.Forms.frm_main.ShowForms("frm_monitor")
    End Sub
End Class