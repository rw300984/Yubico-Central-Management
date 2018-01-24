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
        Me.CustomizableProgressBar1 = New Yubico_Installer.CustomizableProgressBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CustomizableProgressBar2 = New Yubico_Installer.CustomizableProgressBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_install_install_status = New System.Windows.Forms.Label()
        Me.bgw_install = New System.ComponentModel.BackgroundWorker()
        Me.bgw_rollback = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomizableProgressBar1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(389, 276)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Yubico_Installer.My.Resources.Resources.install_pic1
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(383, 201)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'CustomizableProgressBar1
        '
        Me.CustomizableProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar1.Location = New System.Drawing.Point(3, 210)
        Me.CustomizableProgressBar1.Name = "CustomizableProgressBar1"
        Me.CustomizableProgressBar1.Size = New System.Drawing.Size(383, 21)
        Me.CustomizableProgressBar1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CustomizableProgressBar2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 21)
        Me.Panel1.TabIndex = 4
        '
        'CustomizableProgressBar2
        '
        Me.CustomizableProgressBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizableProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.CustomizableProgressBar2.Location = New System.Drawing.Point(0, 0)
        Me.CustomizableProgressBar2.Name = "CustomizableProgressBar2"
        Me.CustomizableProgressBar2.Size = New System.Drawing.Size(383, 21)
        Me.CustomizableProgressBar2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbl_install_install_status)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 261)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(389, 15)
        Me.Panel2.TabIndex = 5
        '
        'lbl_install_install_status
        '
        Me.lbl_install_install_status.AutoSize = True
        Me.lbl_install_install_status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_install_install_status.Location = New System.Drawing.Point(0, 0)
        Me.lbl_install_install_status.Name = "lbl_install_install_status"
        Me.lbl_install_install_status.Size = New System.Drawing.Size(0, 13)
        Me.lbl_install_install_status.TabIndex = 0
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(395, 295)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'frm_install_install
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 295)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_install_install"
        Me.Text = "frm_install_install"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CustomizableProgressBar1 As CustomizableProgressBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CustomizableProgressBar2 As CustomizableProgressBar
    Friend WithEvents bgw_install As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_install_install_status As Label
    Friend WithEvents bgw_rollback As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox1 As GroupBox
End Class
