Public Class frm_plg_ykinv
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ret_add_serial As Boolean = plg_ykinv.Serial_AddName(cfg_ykinv.dt, cfg_ykinv.Serial, "#none#")
        If ret_add_serial = False Then
            MessageBox.Show("something went wrong")
        Else
            Serial_WriteDTtoXML(Application.StartupPath & "\temp\serial.xml", cfg_ykinv.dt)
            My.Forms.frm_main.ShowForms("nothing")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ret_add_serial As Boolean = plg_ykinv.Serial_AddName(cfg_ykinv.dt, cfg_ykinv.Serial, cfg_ykinv.Name)
        If ret_add_serial = False Then
            MessageBox.Show("something went wrong")
        Else
            Serial_WriteDTtoXML(Application.StartupPath & "\temp\serial.xml", cfg_ykinv.dt)
            My.Forms.frm_main.ShowForms("nothing")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cfg_ykinv.Name = TextBox1.Text
    End Sub
End Class