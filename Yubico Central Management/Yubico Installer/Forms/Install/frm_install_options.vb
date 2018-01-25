Public Class frm_install_options

    Dim config_combobox As Integer = 0
    Dim config_textbox2 As Integer = 0
    Dim config_textbox3 As Integer = 0
    Dim config_textbox6 As Integer = 0
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        cfg.install_options_success = 0
        If RadioButton2.Checked Then
            RadioButton1.Checked = False
            GroupBox1.Enabled = False
            cfg.install_options_mode = "Business"
            cfg.install_options_success = 0
            If ComboBox1.Text <> "" Then
                config_combobox = 1
            End If
            If TextBox2.Text <> "" Then
                config_textbox2 = 1
            End If
            If TextBox3.Text <> "" Then
                config_textbox3 = 1
            End If
            If TextBox6.Text <> "" Then
                config_textbox6 = 1
            End If
            If config_combobox + config_textbox2 + config_textbox3 + config_textbox6 = 4 Then
                cfg.install_options_success = 1
            Else
                cfg.install_options_success = 0
            End If
        Else
            RadioButton1.Checked = True
            GroupBox1.Enabled = True
            cfg.install_options_mode = "Personal"
            cfg.install_options_success = 1
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        cfg.install_options_success = 0
        If RadioButton1.Checked Then
            RadioButton2.Checked = False
            GroupBox2.Enabled = False
            cfg.install_options_mode = "Personal"
            cfg.install_options_success = 1
        Else
            RadioButton2.Checked = True
            GroupBox2.Enabled = True
            cfg.install_options_mode = "Business"
            cfg.install_options_success = 0
            If ComboBox1.Text <> "" Then
                config_combobox = 1
            End If
            If TextBox2.Text <> "" Then
                config_textbox2 = 1
            End If
            If TextBox3.Text <> "" Then
                config_textbox3 = 1
            End If
            If TextBox6.Text <> "" Then
                config_textbox6 = 1
            End If
            If config_combobox + config_textbox2 + config_textbox3 + config_textbox6 = 4 Then
                cfg.install_options_success = 1
            Else
                cfg.install_options_success = 0
            End If
        End If
    End Sub

    Private Sub frm_install_options_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cfg.install_options_mode = 0 Then
            RadioButton1.Checked = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        config_combobox = 0
        cfg.install_options_business_auth = ComboBox1.Text
        If ComboBox1.Text = "" Then
            config_combobox = 0
            cfg.install_options_success = 0
        Else
            If ComboBox1.Text = "Integrated" Then
                TextBox2.Enabled = False
                TextBox3.Enabled = False
                TextBox6.Enabled = True
                config_combobox = 1
                If config_combobox + config_textbox6 = 2 Then
                    cfg.install_options_success = 1
                Else
                    cfg.install_options_success = 0
                End If
            Else
                TextBox2.Enabled = True
                TextBox3.Enabled = True
                TextBox6.Enabled = True
                config_combobox = 1
                If config_combobox + config_textbox2 + config_textbox3 + config_textbox6 = 4 Then
                    cfg.install_options_success = 1
                Else
                    cfg.install_options_success = 0
                End If
            End If
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        config_textbox2 = 0
        cfg.install_options_business_username = TextBox2.Text
        If TextBox2.Text = "" Then
            config_textbox2 = 0
            cfg.install_options_success = 0
        Else
            config_textbox2 = 1
            If config_combobox + config_textbox2 + config_textbox3 + config_textbox6 = 4 Then
                cfg.install_options_success = 1
            Else
                cfg.install_options_success = 0
            End If
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        config_textbox3 = 0
        cfg.install_options_business_password = TextBox3.Text
        If TextBox3.Text = "" Then
            config_textbox3 = 0
            cfg.install_options_success = 0
        Else
            config_textbox3 = 1
            If config_combobox + config_textbox2 + config_textbox3 + config_textbox6 = 4 Then
                cfg.install_options_success = 1
            Else
                cfg.install_options_success = 0
            End If
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        config_textbox6 = 0
        cfg.install_options_business_server = TextBox6.Text
        If TextBox6.Text = "" Then
            config_textbox6 = 0
            cfg.install_options_success = 0
        Else
            config_textbox6 = 1
            Select Case cfg.install_options_business_auth
                Case "Integrated"
                    If config_combobox + config_textbox6 = 2 Then
                        cfg.install_options_success = 1
                    Else
                        cfg.install_options_success = 0
                    End If
                Case "Basic"
                    If config_combobox + config_textbox2 + config_textbox3 + config_textbox6 = 4 Then
                        cfg.install_options_success = 1
                    Else
                        cfg.install_options_success = 0
                    End If
            End Select

        End If
    End Sub

    Private Sub frm_install_options_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            If ComboBox1.Text <> "" Then
                config_combobox = 1
            Else
                config_combobox = 0
            End If
            If TextBox2.Text <> "" Then
                config_textbox2 = 1
            Else
                config_textbox2 = 0
            End If
            If TextBox3.Text <> "" Then
                config_textbox3 = 1
            Else
                config_textbox3 = 0
            End If
            If TextBox6.Text <> "" Then
                config_textbox6 = 1
            Else
                config_textbox6 = 0
            End If

        End If
    End Sub
End Class