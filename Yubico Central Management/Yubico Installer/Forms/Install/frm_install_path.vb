Public Class frm_install_path
    Private Sub frm_install_path_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cfg.install_path_mode = 0 Then
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            GroupBox2.Enabled = False
            cfg.install_path_mode = 0
            cfg.install_path_success = 1
            My.Forms.frm_main.btn_main_next.Enabled = True
        Else
            RadioButton2.Checked = True
            GroupBox2.Enabled = True
            cfg.install_path_mode = 1
            ValidatePath(TextBox1.Text)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            GroupBox1.Enabled = False
            cfg.install_path_mode = 1
            ValidatePath(TextBox1.Text)
        Else
            RadioButton1.Checked = True
            GroupBox1.Enabled = True
            cfg.install_path_mode = 1
            cfg.install_path_success = 1
            My.Forms.frm_main.btn_main_next.Enabled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        cfg.install_path_custom = TextBox1.Text
        ValidatePath(TextBox1.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fbd_install_path_custom_path.ShowDialog()
        TextBox1.Text = fbd_install_path_custom_path.SelectedPath
    End Sub

    Public Function ValidatePath(ByVal path As String) As Boolean
        If System.IO.Path.IsPathRooted(path) Then
            My.Forms.frm_main.btn_main_next.Enabled = True
            cfg.install_path_success = 1
            TextBox1.BackColor = Color.LightGreen
            Return True
        Else
            My.Forms.frm_main.btn_main_next.Enabled = False
            cfg.install_path_success = 0
            TextBox1.BackColor = Color.LightCoral
            Return False
        End If

    End Function

    Private Sub frm_install_path_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            If cfg.install_path_mode = 0 Then
                My.Forms.frm_main.btn_main_next.Enabled = True
            Else
                ValidatePath(TextBox1.Text)
            End If
        End If
    End Sub
End Class