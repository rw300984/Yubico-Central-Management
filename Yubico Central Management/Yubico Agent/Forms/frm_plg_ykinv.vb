Public Class frm_plg_ykinv
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_frm_plg_ykinv_ignore.Click
        Dim ret_add_serial As Boolean = plg_ykinv.Serial_AddName(cfg_ykinv.dt, cfg_ykinv.Serial, "#ignore#")
        If ret_add_serial = False Then
        Else
            Serial_WriteDTtoXML(Application.StartupPath & "\temp\serial.cache", cfg_ykinv.dt)
            My.Forms.frm_main.ShowForms("nothing")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_frm_plg_ykinv_addname.Click
        Dim ret_add_serial As Boolean = plg_ykinv.Serial_AddName(cfg_ykinv.dt, cfg_ykinv.Serial, cfg_ykinv.Name)
        If ret_add_serial = False Then

        Else
            Serial_WriteDTtoXML(Application.StartupPath & "\temp\serial.cache", cfg_ykinv.dt)
            My.Forms.frm_main.ShowForms("nothing")
        End If

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
        cfg_ykinv.Name = txt_frm_plg_ykinv.Text
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