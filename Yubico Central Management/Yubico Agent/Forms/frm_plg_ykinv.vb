Public Class frm_plg_ykinv
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_frm_plg_ykinv_ignore.Click
        Dim ykinv_input As ykinv
        ykinv_input.Serial = res_ykinfo.serial
        ykinv_input.Name = "#ignore#"
        Dim ykinv_status As Boolean = plg_ykinv.ykinv_serial_add(ykinv_input)
        If ykinv_status = True Then

        Else

        End If
        My.Forms.frm_main.ShowForms("nothing")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_frm_plg_ykinv_addname.Click
        Dim ykinv_input As ykinv
        ykinv_input.Serial = res_ykinfo.serial
        ykinv_input.Name = txt_frm_plg_ykinv.Text
        Dim ykinv_status As Boolean = plg_ykinv.ykinv_serial_add(ykinv_input)
        If ykinv_status = True Then

        Else

        End If
        My.Forms.frm_main.ShowForms("nothing")
    End Sub

    Private Sub frm_plg_ykinv_Load(sender As Object, e As EventArgs) Handles Me.Load
        txt_frm_plg_ykinv.AutoSize = False
        txt_frm_plg_ykinv.Size = New System.Drawing.Size(121, 23)
        Enable_Disable_btn()
    End Sub

    Private Sub frm_plg_ykinv_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            txt_frm_plg_ykinv.Text = ""
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_frm_plg_ykinv.TextChanged
        Enable_Disable_btn()

    End Sub

    Private Function Enable_Disable_btn()
        If txt_frm_plg_ykinv.Text = "" Then
            btn_frm_plg_ykinv_addname.Enabled = False
            btn_frm_plg_ykinv_ignore.Enabled = True
        Else
            btn_frm_plg_ykinv_addname.Enabled = True
            btn_frm_plg_ykinv_ignore.Enabled = False
        End If
    End Function
End Class