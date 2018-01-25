
Public Class frm_main
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim frm_main_action As New frm_main_action
    Dim frm_read_eula As New frm_read_eula
    Dim frm_install_update As New frm_install_update
    Dim frm_install_path As New frm_install_path
    Dim frm_install_password As New frm_install_password
    Dim frm_install_options As New frm_install_options
    Dim frm_install_start As New frm_install_start
    Dim frm_install_install As New frm_install_install
    Dim frm_install_finish As New frm_install_finish
    Dim frm_start_Agent As New frm_start_agent
    Dim frm_uninstall_start As New frm_uninstall_start
    Dim frm_uninstall_uninstall As New frm_uninstall_uninstall
    Dim frm_uninstall_finish As New frm_uninstall_finish

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_main_next.Click
        Select Case True
            Case frm_main_action.Visible
                Select Case cfg.main_action
                    Case 1
                        ShowForms("frm_read_eula")
                    Case 2
                        ShowForms("frm_uninstall_start")
                    Case 3
                    Case 4
                End Select
            Case frm_uninstall_start.Visible = True
                ShowForms("frm_uninstall_uninstall")
            Case frm_uninstall_uninstall.Visible = True
                ShowForms("frm_uninstall_finish")
            Case frm_uninstall_finish.Visible = True
                Application.Exit()
            Case frm_read_eula.Visible
                ShowForms("frm_install_update")
            Case frm_install_update.Visible
                ShowForms("frm_install_path")
            Case frm_install_path.Visible
                If cfg.install_path_success = 1 Then
                    ShowForms("frm_install_password")
                Else
                    RoundedPanel1.Visible = True
                    Label1.Text = "Error: Configuration missing, please check your entries."
                    Label1.Update()
                    Threading.Thread.Sleep(1000)
                    RoundedPanel1.Visible = False
                End If
            Case frm_install_password.Visible
                If cfg.install_password_success = 1 Then
                    ShowForms("frm_install_options")
                Else
                    RoundedPanel1.Visible = True
                    Label1.Text = "Error: Configuration missing, please check your entries."
                    Label1.Update()
                    Threading.Thread.Sleep(1000)
                    RoundedPanel1.Visible = False
                End If
            Case frm_install_options.Visible
                If cfg.install_options_success = 1 Then
                    ShowForms("frm_install_start")
                Else
                    RoundedPanel1.Visible = True
                    Label1.Text = "Error: Configuration missing, please check your entries."
                    Label1.Update()
                    Threading.Thread.Sleep(1000)
                    RoundedPanel1.Visible = False
                End If
            Case frm_install_start.Visible
                ShowForms("frm_install_install")
            Case frm_install_install.Visible
                ShowForms("frm_install_finish")
            Case frm_install_finish.Visible
                ShowForms("frm_start_agent")
            Case frm_start_Agent.Visible
                Application.Exit()
            Case Else
                ShowForms("nothing")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_main_back.Click
        Select Case True
            Case frm_main_action.Visible
                ShowForms("nothing")
            Case frm_read_eula.Visible
                ShowForms("frm_main_action")
            Case frm_uninstall_start.Visible
                ShowForms("frm_main_action")
            Case frm_uninstall_uninstall.Visible
                ShowForms("frm_uninstall_start")
            Case frm_uninstall_finish.Visible
                ShowForms("frm_uninstall_uninstall")
            Case frm_install_update.Visible
                ShowForms("frm_read_eula")
            Case frm_install_path.Visible
                If cfg.install_path_success = 1 Then
                    ShowForms("frm_install_update")
                Else
                    RoundedPanel1.Visible = True
                    Label1.Text = "Error: Configuration missing, please check your entries."
                    Label1.Update()
                    Threading.Thread.Sleep(1000)
                    RoundedPanel1.Visible = False
                End If
            Case frm_install_password.Visible
                If cfg.install_password_success = 1 Then
                    ShowForms("frm_install_path")
                Else
                    RoundedPanel1.Visible = True
                    Label1.Text = "Error: Configuration missing, please check your entries."
                    Label1.Update()
                    Threading.Thread.Sleep(1000)
                    RoundedPanel1.Visible = False
                End If
            Case frm_install_options.Visible
                If cfg.install_options_success = 1 Then
                    ShowForms("frm_install_password")
                Else
                    RoundedPanel1.Visible = True
                    Label1.Text = "Error: Configuration missing, please check your entries."
                    Label1.Update()
                    Threading.Thread.Sleep(1000)
                    RoundedPanel1.Visible = False
                End If
            Case frm_install_start.Visible
                ShowForms("frm_install_options")
            Case frm_install_finish.Visible
                ShowForms("nothing")
            Case frm_start_Agent.Visible
                ShowForms("nothing")
            Case Else
                ShowForms("nothing")
        End Select
    End Sub

    Public Function LoadForms()
        Me.Visible = True
        Dim forms As New List(Of Form)
        forms.Add(frm_main_action)
        forms.Add(frm_read_eula)
        forms.Add(frm_install_update)
        forms.Add(frm_install_path)
        forms.Add(frm_install_password)
        forms.Add(frm_install_options)
        forms.Add(frm_install_start)
        forms.Add(frm_install_install)
        forms.Add(frm_install_finish)
        forms.Add(frm_start_Agent)
        forms.Add(frm_uninstall_start)
        forms.Add(frm_uninstall_finish)
        forms.Add(frm_uninstall_uninstall)
        SetupForms(forms)
    End Function

    Public Function SetupForms(ByVal forms As List(Of Form))
        For Each form As Form In forms
            form.Visible = False
            form.WindowState = FormWindowState.Maximized
            form.Dock = DockStyle.Fill
            form.TopLevel = False
            form.FormBorderStyle = FormBorderStyle.None
            Me.Panel2.Controls.Add(form)
        Next
    End Function

    Public Function ShowFormsDefaults(Optional ByVal lbl_visible As Integer = 0, Optional ByVal lbl_enabled As Integer = 1)
        ' Set visible for all not used forms to false

        frm_main_action.Visible = False
        frm_read_eula.Visible = False
        frm_install_update.Visible = False
        frm_install_path.Visible = False
        frm_install_password.Visible = False
        frm_install_options.Visible = False
        frm_install_start.Visible = False
        frm_install_finish.Visible = False
        frm_start_Agent.Visible = False
        frm_uninstall_finish.Visible = False
        frm_uninstall_start.Visible = False
        frm_uninstall_uninstall.Visible = False

        ' Underline right menu structure (lbl) if form is selected

        If lbl_visible = 0 Then
            lbl_main_eula.Visible = False
            lbl_main_updates.Visible = False
            lbl_main_path.Visible = False
            lbl_main_password.Visible = False
            lbl_main_options.Visible = False
            lbl_main_start_install.Visible = False
            lbl_main_finish.Visible = False
            lbl_main_start_agent.Visible = False
        Else
            lbl_main_eula.Visible = True
            lbl_main_updates.Visible = True
            lbl_main_path.Visible = True
            lbl_main_password.Visible = True
            lbl_main_options.Visible = True
            lbl_main_start_install.Visible = True
            lbl_main_finish.Visible = True
            lbl_main_start_agent.Visible = True
        End If
        If lbl_enabled = 1 Then
            lbl_main_eula.Enabled = True
            lbl_main_updates.Enabled = True
            lbl_main_path.Enabled = True
            lbl_main_password.Enabled = True
            lbl_main_options.Enabled = True
            lbl_main_start_install.Enabled = True
            lbl_main_finish.Enabled = True
            lbl_main_start_agent.Enabled = True
        Else
            lbl_main_eula.Enabled = False
            lbl_main_updates.Enabled = False
            lbl_main_path.Enabled = False
            lbl_main_password.Enabled = False
            lbl_main_options.Enabled = False
            lbl_main_start_install.Enabled = False
            lbl_main_finish.Enabled = False
            lbl_main_start_agent.Enabled = False
        End If

        SetFontUnderline(lbl_main_eula, 0)
        SetFontUnderline(lbl_main_updates, 0)
        SetFontUnderline(lbl_main_path, 0)
        SetFontUnderline(lbl_main_password, 0)
        SetFontUnderline(lbl_main_options, 0)
        SetFontUnderline(lbl_main_start_install, 0)
        SetFontUnderline(lbl_main_finish, 0)
        SetFontUnderline(lbl_main_start_agent, 0)

        ' Disable the navigation buttons

        btn_main_next.Visible = False
        btn_main_back.Visible = False

    End Function
    Public Function ShowForms(ByVal frm As String)
        Select Case frm
            Case "nothing"
                ShowFormsDefaults(0, 0)
            Case "frm_main_action"

                ' Frm visibility
                ShowFormsDefaults(0, 0)
                frm_main_action.Visible = True

                ' Button Config

                btn_main_next.Visible = True
                btn_main_next.Text = "Next"

            Case "frm_read_eula"

                ' Frm visibility
                ShowFormsDefaults(1)
                frm_read_eula.Visible = True

                ' Button Config

                btn_main_back.Visible = True
                btn_main_next.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "I agree"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 1)

            Case "frm_install_update"

                ' Frm visibility

                ShowFormsDefaults(1)

                frm_install_update.Visible = True

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config

                SetFontUnderline(lbl_main_updates, 1)

            Case "frm_install_path"

                ' Frm visibility

                ShowFormsDefaults(1)
                frm_install_path.Visible = True


                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config
                SetFontUnderline(lbl_main_path, 1)

            Case "frm_install_password"
                ' Frm visibility

                ShowFormsDefaults(1)

                frm_install_password.Visible = True

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config

                SetFontUnderline(lbl_main_password, 1)

            Case "frm_install_options"
                ' Frm visibility

                ShowFormsDefaults(1)

                frm_install_options.Visible = True

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config
                SetFontUnderline(lbl_main_options, 1)

            Case "frm_install_start"
                ' Frm visibility

                ShowFormsDefaults(1)
                frm_install_start.Visible = True

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Install"

                ' Label Menue Config

                SetFontUnderline(lbl_main_start_install, 1)


            Case "frm_install_install"

                ' Frm visibility

                ShowFormsDefaults(1, 0)
                frm_install_install.Visible = True

                ' button config

                btn_main_next.Visible = True
                btn_main_next.Text = "Next"

                ' Label Menue Config

                lbl_main_finish.Enabled = True
                lbl_main_start_agent.Enabled = True

            Case "frm_install_finish"
                ' Frm visibility

                ShowFormsDefaults(1, 0)
                frm_install_finish.Visible = True

                ' Button config

                btn_main_next.Visible = True
                btn_main_next.Text = "Next"

                'Label Menue Config

                SetFontUnderline(lbl_main_finish, 1)

            Case "frm_start_agent"

                ' Frm visibility

                ShowFormsDefaults(1, 0)
                frm_start_Agent.Visible = True

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = False
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Exit"

                ' Label Menue Config

                SetFontUnderline(lbl_main_start_agent, 1)

            Case "frm_uninstall_start"

                ' Frm visibility

                ShowFormsDefaults(0, 0)
                frm_uninstall_start.Visible = True

            Case "frm_uninstall_uninstall"
                ' Frm visibility
                ShowFormsDefaults(0, 0)
                frm_uninstall_uninstall.Visible = True

                ' Button Config
                btn_main_next.Text = "Next"

            Case "frm_uninstall_finish"
                ' Frm visibility
                ShowFormsDefaults()
                frm_uninstall_finish.Visible = True

                ' Button Config
                btn_main_next.Visible = True
                btn_main_next.Text = "Exit"
        End Select
    End Function

    Public Function FillDefaultValue()
        cfg.install_options_mode = 0
        cfg.install_options_success = 0
        cfg.install_password_mode = 0
        cfg.install_password_success = 0
        cfg.install_path_mode = 0
        cfg.install_path_success = 0
        cfg.install_update_mode = 0
        cfg.install_update_success = 0
        cfg.install_path_default = My.Computer.FileSystem.SpecialDirectories.ProgramFiles & "\Yubico Agent"
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillDefaultValue()
        LoadForms()
        ShowForms("frm_main_action")
    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Application.Exit()
    End Sub

    Private Sub lbl_main_eula_Click(sender As Object, e As EventArgs) Handles lbl_main_eula.Click
        ShowForms("frm_read_eula")
    End Sub

    Private Sub lbl_main_updates_Click(sender As Object, e As EventArgs) Handles lbl_main_updates.Click
        ShowForms("frm_install_update")
    End Sub

    Private Sub lbl_main_path_Click(sender As Object, e As EventArgs) Handles lbl_main_path.Click
        ShowForms("frm_install_path")
    End Sub

    Private Sub lbl_main_password_Click(sender As Object, e As EventArgs) Handles lbl_main_password.Click
        ShowForms("frm_install_password")
    End Sub

    Private Sub lbl_main_options_Click(sender As Object, e As EventArgs) Handles lbl_main_options.Click
        ShowForms("frm_install_options")
    End Sub

    Public Function SetFontUnderline(ByVal label As Label, mode As Integer)
        Select Case mode
            Case 0 ' normal
                label.Font = New Font(label.Font.Name, label.Font.SizeInPoints)
            Case 1 ' underline
                label.Font = New Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Underline)
        End Select
    End Function

    Private Sub lbl_main_eula_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_eula.MouseHover
        SetFontUnderline(lbl_main_eula, 1)
    End Sub

    Private Sub lbl_main_eula_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_eula.MouseLeave
        SetFontUnderline(lbl_main_eula, 0)
    End Sub

    Private Sub lbl_main_updates_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_updates.MouseHover
        SetFontUnderline(lbl_main_updates, 1)
    End Sub

    Private Sub lbl_main_updates_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_updates.MouseLeave
        SetFontUnderline(lbl_main_updates, 0)
    End Sub

    Private Sub lbl_main_path_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_path.MouseHover
        SetFontUnderline(lbl_main_path, 1)
    End Sub

    Private Sub lbl_main_path_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_path.MouseLeave
        SetFontUnderline(lbl_main_path, 0)
    End Sub

    Private Sub lbl_main_password_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_password.MouseHover
        SetFontUnderline(lbl_main_password, 1)
    End Sub

    Private Sub lbl_main_password_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_password.MouseLeave
        SetFontUnderline(lbl_main_password, 0)
    End Sub

    Private Sub lbl_main_options_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_options.MouseHover
        SetFontUnderline(lbl_main_options, 1)
    End Sub

    Private Sub lbl_main_options_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_options.MouseLeave
        SetFontUnderline(lbl_main_options, 0)
    End Sub

    Private Sub lbl_main_start_install_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_start_install.MouseHover
        '   SetFontUnderline(lbl_main_start_install, 1)
    End Sub

    Private Sub lbl_main_start_install_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_start_install.MouseLeave
        '  SetFontUnderline(lbl_main_start_install, 0)
    End Sub

    Private Sub Llbl_main_finish_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_finish.MouseHover
        '  SetFontUnderline(lbl_main_finish, 1)
    End Sub

    Private Sub lbl_main_finish_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_finish.MouseLeave
        '    SetFontUnderline(lbl_main_finish, 0)
    End Sub

    Private Sub lbl_main_start_agent_MouseHover(sender As Object, e As EventArgs) Handles lbl_main_start_agent.MouseHover
        ' SetFontUnderline(lbl_main_start_agent, 1)
    End Sub

    Private Sub lbl_main_start_agent_MouseLeave(sender As Object, e As EventArgs) Handles lbl_main_start_agent.MouseLeave
        '    SetFontUnderline(lbl_main_start_agent, 0)
    End Sub

    Private Sub TableLayoutPanel2_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel2.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub TableLayoutPanel2_MouseUp(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel2.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = False
        End If
    End Sub

    Private Sub TableLayoutPanel2_MouseMove(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel2.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TableLayoutPanel5_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel5.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub TableLayoutPanel5_MouseMove(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel5.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TableLayoutPanel5_MouseUp(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel5.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = False
        End If
    End Sub

    Private Sub TableLayoutPanel3_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel3.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub TableLayoutPanel3_MouseMove(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel3.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TableLayoutPanel3_MouseUp(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel3.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = False
        End If
    End Sub

    Private Sub TableLayoutPanel4_MouseUp(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel4.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = False
        End If
    End Sub

    Private Sub TableLayoutPanel4_MouseMove(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel4.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TableLayoutPanel4_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel4.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = False
        End If
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
End Class
