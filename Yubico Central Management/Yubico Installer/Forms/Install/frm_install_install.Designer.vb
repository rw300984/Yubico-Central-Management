<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_install_install
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomizableProgressBar1 = New Yubico_Installer.CustomizableProgressBar()
        Me.CustomizableProgressBar2 = New Yubico_Installer.CustomizableProgressBar()
        Me.lbl_install_install_status = New System.Windows.Forms.Label()
        Me.bgw_install = New System.ComponentModel.BackgroundWorker()
        Me.bgw_rollback = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.CustomizableProgressBar1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomizableProgressBar2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_install_install_status, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(395, 295)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'CustomizableProgressBar1
        '
        Me.CustomizableProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar1.Location = New System.Drawing.Point(3, 113)
        Me.CustomizableProgressBar1.Name = "CustomizableProgressBar1"
        Me.CustomizableProgressBar1.Size = New System.Drawing.Size(389, 23)
        Me.CustomizableProgressBar1.TabIndex = 3
        '
        'CustomizableProgressBar2
        '
        Me.CustomizableProgressBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar2.Location = New System.Drawing.Point(3, 142)
        Me.CustomizableProgressBar2.Name = "CustomizableProgressBar2"
        Me.CustomizableProgressBar2.Size = New System.Drawing.Size(389, 23)
        Me.CustomizableProgressBar2.TabIndex = 0
        '
        'lbl_install_install_status
        '
        Me.lbl_install_install_status.AutoSize = True
        Me.lbl_install_install_status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_install_install_status.Location = New System.Drawing.Point(3, 168)
        Me.lbl_install_install_status.Name = "lbl_install_install_status"
        Me.lbl_install_install_status.Size = New System.Drawing.Size(389, 14)
        Me.lbl_install_install_status.TabIndex = 4
        Me.lbl_install_install_status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bgw_install
        '
        Me.bgw_install.WorkerReportsProgress = True
        Me.bgw_install.WorkerSupportsCancellation = True
        '
        'bgw_rollback
        '
        Me.bgw_rollback.WorkerReportsProgress = True
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
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CustomizableProgressBar1 As CustomizableProgressBar
    Friend WithEvents CustomizableProgressBar2 As CustomizableProgressBar
    Friend WithEvents bgw_install As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgw_rollback As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_install_install_status As Label
End Class
