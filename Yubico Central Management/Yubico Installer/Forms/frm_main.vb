
Public Class frm_main
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public frm_read_eula As New frm_read_eula
    Public frm_install_update As New frm_install_update
    Public frm_install_path As New frm_install_path
    Public frm_install_password As New frm_install_password
    Public frm_install_options As New frm_install_options
    Public frm_install_start As New frm_install_start
    Public frm_install_install As New frm_install_install
    Public frm_install_finish As New frm_install_finish
    Public frm_start_Agent As New frm_start_agent

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_main_next.Click
        Select Case True
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
            Case frm_read_eula.Visible
                ShowForms("nothing")
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


        ' System.IO.File.WriteAllBytes("Yubico Agent.exe", My.Resources.Yubico_Agent)
    End Sub

    Public Function LoadForms()

        Me.Visible = True
        frm_read_eula.Visible = False
        frm_install_update.Visible = False
        frm_install_path.Visible = False
        frm_install_password.Visible = False
        frm_install_options.Visible = False
        frm_install_start.Visible = False
        frm_install_install.Visible = False
        frm_install_finish.Visible = False
        frm_start_Agent.Visible = False

        frm_read_eula.WindowState = FormWindowState.Maximized
        frm_read_eula.Dock = DockStyle.Fill
        frm_read_eula.TopLevel = False
        frm_read_eula.FormBorderStyle = FormBorderStyle.None

        frm_install_update.WindowState = FormWindowState.Maximized
        frm_install_update.Dock = DockStyle.Fill
        frm_install_update.TopLevel = False
        frm_install_update.FormBorderStyle = FormBorderStyle.None

        frm_install_path.WindowState = FormWindowState.Maximized
        frm_install_path.Dock = DockStyle.Fill
        frm_install_path.TopLevel = False
        frm_install_path.FormBorderStyle = FormBorderStyle.None

        frm_install_password.WindowState = FormWindowState.Maximized
        frm_install_password.Dock = DockStyle.Fill
        frm_install_password.TopLevel = False
        frm_install_password.FormBorderStyle = FormBorderStyle.None

        frm_install_options.WindowState = FormWindowState.Maximized
        frm_install_options.Dock = DockStyle.Fill
        frm_install_options.TopLevel = False
        frm_install_options.FormBorderStyle = FormBorderStyle.None

        frm_install_start.WindowState = FormWindowState.Maximized
        frm_install_start.Dock = DockStyle.Fill
        frm_install_start.TopLevel = False
        frm_install_start.FormBorderStyle = FormBorderStyle.None

        frm_install_install.WindowState = FormWindowState.Maximized
        frm_install_install.Dock = DockStyle.Fill
        frm_install_install.TopLevel = False
        frm_install_install.FormBorderStyle = FormBorderStyle.None

        frm_install_finish.WindowState = FormWindowState.Maximized
        frm_install_finish.Dock = DockStyle.Fill
        frm_install_finish.TopLevel = False
        frm_install_finish.FormBorderStyle = FormBorderStyle.None

        frm_start_Agent.WindowState = FormWindowState.Maximized
        frm_start_Agent.Dock = DockStyle.Fill
        frm_start_Agent.TopLevel = False
        frm_start_Agent.FormBorderStyle = FormBorderStyle.None

        Me.Panel2.Controls.Add(frm_read_eula)
        Me.Panel2.Controls.Add(frm_install_update)
        Me.Panel2.Controls.Add(frm_install_path)
        Me.Panel2.Controls.Add(frm_install_password)
        Me.Panel2.Controls.Add(frm_install_options)
        Me.Panel2.Controls.Add(frm_install_start)
        Me.Panel2.Controls.Add(frm_install_install)
        Me.Panel2.Controls.Add(frm_install_finish)
        Me.Panel2.Controls.Add(frm_start_Agent)

    End Function

    Public Function ShowForms(ByVal frm As String)
        Select Case frm
            Case "nothing"
                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)

                btn_main_next.Visible = False
                btn_main_back.Visible = False

            Case "frm_read_eula"

                ' Frm visibility

                frm_read_eula.Visible = True
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_install.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                ' Button Config

                btn_main_back.Visible = False
                btn_main_next.Text = "I agree"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 1)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)
            Case "frm_install_update"

                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = True
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_install.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 1)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)


            Case "frm_install_path"

                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = True
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_install.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 1)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)
            Case "frm_install_password"
                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = True
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_install.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 1)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)


            Case "frm_install_options"
                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = True
                frm_install_start.Visible = False
                frm_install_install.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 1)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)

            Case "frm_install_start"
                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = True
                frm_install_install.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = True
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Install"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 1)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)

            Case "frm_install_install"

                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_install.Visible = True
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = False

                ' button config

                btn_main_back.Visible = False
                'btn_main_next.Visible = False

                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 0)

            Case "frm_install_finish"
                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_install.Visible = False
                frm_start_Agent.Visible = False
                frm_install_finish.Visible = True

                ' Button config

                btn_main_next.Visible = True
                '   btn_main_next.Update()

                '  btn_main_back.Visible = True
                '  btn_main_back.Update()

                btn_main_back.Text = "Back"
                btn_main_next.Text = "Next"

                'Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 1)
                SetFontUnderline(lbl_main_start_agent, 0)

            Case "frm_start_agent"

                ' Frm visibility

                frm_read_eula.Visible = False
                frm_install_update.Visible = False
                frm_install_path.Visible = False
                frm_install_password.Visible = False
                frm_install_options.Visible = False
                frm_install_start.Visible = False
                frm_install_install.Visible = False
                frm_install_finish.Visible = False
                frm_start_Agent.Visible = True

                ' button config

                btn_main_next.Visible = True
                btn_main_back.Visible = False
                btn_main_back.Text = "Back"
                btn_main_next.Text = "Exit"

                ' Label Menue Config

                SetFontUnderline(lbl_main_eula, 0)
                SetFontUnderline(lbl_main_updates, 0)
                SetFontUnderline(lbl_main_path, 0)
                SetFontUnderline(lbl_main_password, 0)
                SetFontUnderline(lbl_main_options, 0)
                SetFontUnderline(lbl_main_start_install, 0)
                SetFontUnderline(lbl_main_finish, 0)
                SetFontUnderline(lbl_main_start_agent, 1)
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
        If Environment.Is64BitOperatingSystem Then
            cfg.install_path_default = "C:\Program Files(x86)\Yubico Agent\"
        Else
            cfg.install_path_default = "C:\Program Files\Yubico Agent\"
        End If
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        FillDefaultValue()
        LoadForms()
        ShowForms("frm_read_eula")
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
