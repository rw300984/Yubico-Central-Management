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
End Class