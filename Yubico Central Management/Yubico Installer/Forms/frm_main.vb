
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
        frm_install_install.Visible = False
        frm_install_finish.Visible = False

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

        Else
            lbl_main_eula.Visible = True
            lbl_main_updates.Visible = True
            lbl_main_path.Visible = True
            lbl_main_password.Visible = True
            lbl_main_options.Visible = True
            lbl_main_start_install.Visible = True
            lbl_main_finish.Visible = True

        End If
        If lbl_enabled = 1 Then
            lbl_main_eula.Enabled = True
            lbl_main_updates.Enabled = True
            lbl_main_path.Enabled = True
            lbl_main_password.Enabled = True
            lbl_main_options.Enabled = True
            lbl_main_start_install.Enabled = True
            lbl_main_finish.Enabled = True

        Else
            lbl_main_eula.Enabled = False
            lbl_main_updates.Enabled = False
            lbl_main_path.Enabled = False
            lbl_main_password.Enabled = False
            lbl_main_options.Enabled = False
            lbl_main_start_install.Enabled = False
            lbl_main_finish.Enabled = False

        End If

        SetFontUnderline(lbl_main_eula, 0)
        SetFontUnderline(lbl_main_updates, 0)
        SetFontUnderline(lbl_main_path, 0)
        SetFontUnderline(lbl_main_password, 0)
        SetFontUnderline(lbl_main_options, 0)
        SetFontUnderline(lbl_main_start_install, 0)
        SetFontUnderline(lbl_main_finish, 0)


        ' Disable the navigation buttons

        btn_main_next.Visible = False
        btn_main_back.Visible = False

        ' RoundedPanel1 and Installer Status disabled

        RoundedPanel1.Visible = False

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


            Case "frm_install_finish"
                ' Frm visibility

                ShowFormsDefaults(1, 0)
                frm_install_finish.Visible = True

                ' Button config

                btn_main_next.Visible = True
                btn_main_next.Text = "Exit"

                'Label Menue Config

                SetFontUnderline(lbl_main_finish, 1)

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
        cfg.install_update_mode = 1
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

    Private Sub Label_Click(sender As Label, e As EventArgs) Handles lbl_main_password.Click, lbl_main_options.Click, lbl_main_path.Click, lbl_main_updates.Click, lbl_main_eula.Click
        Select Case sender.Name
            Case "lbl_main_password"
                ShowForms("frm_install_password")
            Case "lbl_main_options"
                ShowForms("frm_install_options")
            Case "lbl_main_path"
                ShowForms("frm_install_path")
            Case "lbl_main_updates"
                ShowForms("frm_install_update")
            Case "lbl_main_eula"
                ShowForms("frm_read_eula")
        End Select
    End Sub

    Private Sub Label_MouseHover(sender As Label, e As EventArgs) Handles lbl_main_password.MouseHover, lbl_main_options.MouseHover, lbl_main_path.MouseHover, lbl_main_updates.MouseHover, lbl_main_eula.MouseHover
        SetFontUnderline(sender, 1)
    End Sub

    Private Sub Label_MouseLeave(sender As Label, e As EventArgs) Handles lbl_main_password.MouseLeave, lbl_main_options.MouseLeave, lbl_main_path.MouseLeave, lbl_main_updates.MouseLeave, lbl_main_eula.MouseLeave
        SetFontUnderline(sender, 0)
    End Sub

    Public Function SetFontUnderline(ByVal label As Label, mode As Integer)
        Select Case mode
            Case 0 ' normal
                label.Font = New Font(label.Font.Name, label.Font.SizeInPoints)
            Case 1 ' underline
                label.Font = New Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Underline)
        End Select
    End Function

    Private Sub MoveWindow_MouseDown(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel2.MouseDown, TableLayoutPanel6.MouseDown, TableLayoutPanel5.MouseDown, TableLayoutPanel4.MouseDown, TableLayoutPanel3.MouseDown, TableLayoutPanel1.MouseDown, RoundedPanel1.MouseDown, PictureBox1.MouseDown, Panel3.MouseDown, Panel2.MouseDown, Panel1.MouseDown, lbl_main_updates.MouseDown, lbl_main_start_install.MouseDown, lbl_main_path.MouseDown, lbl_main_password.MouseDown, lbl_main_options.MouseDown, lbl_main_finish.MouseDown, lbl_main_eula.MouseDown, Label1.MouseDown, btn_main_next.MouseDown, btn_main_back.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub

    Private Sub MoveWindow_MouseUp(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel2.MouseUp, TableLayoutPanel6.MouseUp, TableLayoutPanel5.MouseUp, TableLayoutPanel4.MouseUp, TableLayoutPanel3.MouseUp, TableLayoutPanel1.MouseUp, RoundedPanel1.MouseUp, PictureBox1.MouseUp, Panel3.MouseUp, Panel2.MouseUp, Panel1.MouseUp, lbl_main_updates.MouseUp, lbl_main_start_install.MouseUp, lbl_main_path.MouseUp, lbl_main_password.MouseUp, lbl_main_options.MouseUp, lbl_main_finish.MouseUp, lbl_main_eula.MouseUp, Label1.MouseUp, btn_main_next.MouseUp, btn_main_back.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = False
        End If
    End Sub

    Private Sub MoveWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles TableLayoutPanel2.MouseMove, TableLayoutPanel6.MouseMove, TableLayoutPanel5.MouseMove, TableLayoutPanel4.MouseMove, TableLayoutPanel3.MouseMove, TableLayoutPanel1.MouseMove, RoundedPanel1.MouseMove, PictureBox1.MouseMove, Panel3.MouseMove, Panel2.MouseMove, Panel1.MouseMove, lbl_main_updates.MouseMove, lbl_main_start_install.MouseMove, lbl_main_path.MouseMove, lbl_main_password.MouseMove, lbl_main_options.MouseMove, lbl_main_finish.MouseMove, lbl_main_eula.MouseMove, Label1.MouseMove, btn_main_next.MouseMove, btn_main_back.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

End Class
