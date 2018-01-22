<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_install_install
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bgw_switchpicture = New System.ComponentModel.BackgroundWorker()
        Me.CustomizableProgressBar1 = New Yubico_Installer.CustomizableProgressBar()
        Me.CustomizableProgressBar2 = New Yubico_Installer.CustomizableProgressBar()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomizableProgressBar1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomizableProgressBar2, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(395, 295)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Yubico_Installer.My.Resources.Resources.install_pic1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(389, 215)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'bgw_switchpicture
        '
        Me.bgw_switchpicture.WorkerReportsProgress = True
        '
        'CustomizableProgressBar1
        '
        Me.CustomizableProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar1.Location = New System.Drawing.Point(3, 224)
        Me.CustomizableProgressBar1.Name = "CustomizableProgressBar1"
        Me.CustomizableProgressBar1.Size = New System.Drawing.Size(389, 23)
        Me.CustomizableProgressBar1.TabIndex = 3
        Me.CustomizableProgressBar1.Value = 70
        '
        'CustomizableProgressBar2
        '
        Me.CustomizableProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar2.Location = New System.Drawing.Point(3, 253)
        Me.CustomizableProgressBar2.Name = "CustomizableProgressBar2"
        Me.CustomizableProgressBar2.Size = New System.Drawing.Size(389, 23)
        Me.CustomizableProgressBar2.TabIndex = 4
        Me.CustomizableProgressBar2.Value = 40
        '
        'frm_install_install
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 295)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_install_install"
        Me.Text = "frm_install_install"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CustomizableProgressBar1 As CustomizableProgressBar
    Friend WithEvents CustomizableProgressBar2 As CustomizableProgressBar
    Friend WithEvents bgw_switchpicture As System.ComponentModel.BackgroundWorker
End Class
