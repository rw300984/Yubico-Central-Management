Imports System.ComponentModel

Public Class frm_install_install
    Dim count As Integer = 0
    Private Sub frm_install_install_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub frm_install_install_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Visible Then
            My.Forms.frm_main.btn_main_next.Visible = False
            My.Forms.frm_main.btn_main_next.Enabled = False
            bgw_switchpicture.RunWorkerAsync()
        End If
    End Sub

    Public Function SwitchPicture() As Integer
        Do While count <= 3
            Dim image As Bitmap = My.Resources.install_pic1
            Select Case count
                Case 0
                    image = My.Resources.install_pic1
                Case 1
                    image = My.Resources.install_pic2
                Case 2
                    image = My.Resources.install_pic3
                Case 3
                    image = My.Resources.install_pic4
            End Select
            bgw_switchpicture.ReportProgress(0, image)
            Threading.Thread.Sleep(2000)
            count = count + 1
        Loop
        count = 0
    End Function

    Private Sub bgw_switchpicture_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_switchpicture.DoWork
        SwitchPicture()
    End Sub

    Private Sub bgw_switchpicture_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bgw_switchpicture.ProgressChanged
        PictureBox1.Image = TryCast(e.UserState(), Bitmap)
    End Sub

    Private Sub bgw_switchpicture_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw_switchpicture.RunWorkerCompleted
        My.Forms.frm_main.btn_main_next.Enabled = True
        My.Forms.frm_main.btn_main_next.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(StopAllServicesAndProcess())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If cfg.install_path_mode = 0 Then
            MessageBox.Show(Others.CreateFolderStructure(cfg.install_path_default))
            MessageBox.Show(Others.SetPermissions(cfg.install_path_default))
        Else
            MessageBox.Show(Others.CreateFolderStructure(cfg.install_path_custom))
            MessageBox.Show(Others.SetPermissions(cfg.install_path_custom))
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If cfg.install_path_mode = 0 Then
            MessageBox.Show(ExtractApplication(cfg.install_path_default))
        Else
            MessageBox.Show(ExtractApplication(cfg.install_path_custom))
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If cfg.install_path_mode = 0 Then
            MessageBox.Show(RegisterDLLs(cfg.install_path_default & "\plugins\ykclient\yubiclientapi.dll"))
        Else
            MessageBox.Show(RegisterDLLs(cfg.install_path_custom & "\plugins\ykclient\yubiclientapi.dll"))
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If cfg.install_path_mode = 0 Then
            MessageBox.Show(RegisterInstallation(cfg.install_path_default))
            MessageBox.Show(InstallService(cfg.install_path_default & "\services\Yubico Agent Service.exe"))

        Else
            MessageBox.Show(RegisterInstallation(cfg.install_path_custom))
            MessageBox.Show(InstallService(cfg.install_path_custom & "\services\Yubico Agent Service.exe"))

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim path As String
        Dim password As String
        Dim agent_mode As String

        If cfg.install_path_mode = 0 Then
            path = cfg.install_path_default
        Else
            path = cfg.install_path_custom
        End If
        If cfg.install_password_mode = 0 Then
            password = GeneratePassword(12)
            MessageBox.Show(password)
        Else
            password = cfg.install_password_custom
        End If
        If cfg.install_options_mode = 0 Then
            agent_mode = "Personal"
        Else
            agent_mode = "Business"
        End If

        MessageBox.Show(GenerateDefaultConfig(path, password, agent_mode))
        MessageBox.Show(StartService)
    End Sub
End Class