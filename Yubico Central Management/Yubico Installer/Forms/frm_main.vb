
Public Class frm_main


    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Dim frm_install_path As New frm_install_path
    Dim frm_read_eula As New frm_read_eula



    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        ' MessageBox.Show("fire")
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(Control.MousePosition)

            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position

            Me.Location = mousePos
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Select Case True
            Case frm_install_path.Visible
                ShowForms("nothing")
            Case frm_read_eula.Visible
                ShowForms("frm_install_path")
            Case Else
                ShowForms("frm_read_eula")
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case True
            Case frm_install_path.Visible
                ShowForms("frm_read_eula")
            Case frm_read_eula.Visible
                ShowForms("nothing")
            Case Else
                ShowForms("frm_install_path")
        End Select


        ' System.IO.File.WriteAllBytes("Yubico Agent.exe", My.Resources.Yubico_Agent)
    End Sub

    Public Function LoadForms()
        Me.Visible = True
        frm_install_path.Visible = False
        frm_read_eula.Visible = False

        frm_install_path.WindowState = FormWindowState.Maximized
        frm_install_path.Dock = DockStyle.Fill
        frm_install_path.TopLevel = False
        frm_install_path.FormBorderStyle = FormBorderStyle.None

        frm_read_eula.WindowState = FormWindowState.Maximized
        frm_read_eula.Dock = DockStyle.Fill
        frm_read_eula.TopLevel = False
        frm_read_eula.FormBorderStyle = FormBorderStyle.None

        Me.Panel2.Controls.Add(frm_install_path)
        Me.Panel2.Controls.Add(frm_read_eula)


    End Function

    Public Function ShowForms(ByVal frm As String)
        Select Case frm
            Case "nothing"
                frm_install_path.Visible = False
                frm_read_eula.Visible = False
            Case "frm_read_eula"
                frm_install_path.Visible = False
                frm_read_eula.Visible = True
            Case "frm_install_path"
                frm_install_path.Visible = True
                frm_read_eula.Visible = False
        End Select
    End Function

    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadForms()

    End Sub

    Private Sub Panel3_Click(sender As Object, e As EventArgs) Handles Panel3.Click
        Application.Exit()
    End Sub
End Class
