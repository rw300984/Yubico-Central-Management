<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_uninstall_uninstall
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_uninstall_status = New System.Windows.Forms.Label()
        Me.bgw_uninstall = New System.ComponentModel.BackgroundWorker()
        Me.CustomizableProgressBar1 = New Yubico_Installer.CustomizableProgressBar()
        Me.CustomizableProgressBar2 = New Yubico_Installer.CustomizableProgressBar()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_uninstall_status, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.CustomizableProgressBar2, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.CustomizableProgressBar1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(395, 295)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lbl_uninstall_status
        '
        Me.lbl_uninstall_status.AutoSize = True
        Me.lbl_uninstall_status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_uninstall_status.Location = New System.Drawing.Point(3, 168)
        Me.lbl_uninstall_status.Name = "lbl_uninstall_status"
        Me.lbl_uninstall_status.Size = New System.Drawing.Size(389, 14)
        Me.lbl_uninstall_status.TabIndex = 2
        Me.lbl_uninstall_status.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'bgw_uninstall
        '
        Me.bgw_uninstall.WorkerReportsProgress = True
        '
        'CustomizableProgressBar1
        '
        Me.CustomizableProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar1.Location = New System.Drawing.Point(0, 110)
        Me.CustomizableProgressBar1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
        Me.CustomizableProgressBar1.Name = "CustomizableProgressBar1"
        Me.CustomizableProgressBar1.Size = New System.Drawing.Size(395, 26)
        Me.CustomizableProgressBar1.TabIndex = 0
        '
        'CustomizableProgressBar2
        '
        Me.CustomizableProgressBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar2.Location = New System.Drawing.Point(0, 142)
        Me.CustomizableProgressBar2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.CustomizableProgressBar2.Name = "CustomizableProgressBar2"
        Me.CustomizableProgressBar2.Size = New System.Drawing.Size(395, 26)
        Me.CustomizableProgressBar2.TabIndex = 1
        '
        'frm_uninstall_uninstall
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 295)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_uninstall_uninstall"
        Me.Text = "frm_uninstall_uninstall"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CustomizableProgressBar1 As CustomizableProgressBar
    Friend WithEvents CustomizableProgressBar2 As CustomizableProgressBar
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_uninstall_status As Label
    Friend WithEvents bgw_uninstall As System.ComponentModel.BackgroundWorker
End Class
