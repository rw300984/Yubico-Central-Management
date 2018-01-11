<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.tlp_main = New System.Windows.Forms.TableLayoutPanel()
        Me.picb_yubico_logo = New System.Windows.Forms.PictureBox()
        Me.p_main_status = New System.Windows.Forms.Panel()
        Me.tlp_main.SuspendLayout()
        CType(Me.picb_yubico_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_main
        '
        Me.tlp_main.ColumnCount = 1
        Me.tlp_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_main.Controls.Add(Me.picb_yubico_logo, 0, 0)
        Me.tlp_main.Controls.Add(Me.p_main_status, 0, 2)
        Me.tlp_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_main.Location = New System.Drawing.Point(0, 0)
        Me.tlp_main.Margin = New System.Windows.Forms.Padding(0)
        Me.tlp_main.Name = "tlp_main"
        Me.tlp_main.RowCount = 3
        Me.tlp_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tlp_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.tlp_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlp_main.Size = New System.Drawing.Size(343, 305)
        Me.tlp_main.TabIndex = 0
        '
        'picb_yubico_logo
        '
        Me.picb_yubico_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picb_yubico_logo.Location = New System.Drawing.Point(0, 0)
        Me.picb_yubico_logo.Margin = New System.Windows.Forms.Padding(0)
        Me.picb_yubico_logo.Name = "picb_yubico_logo"
        Me.picb_yubico_logo.Size = New System.Drawing.Size(343, 76)
        Me.picb_yubico_logo.TabIndex = 0
        Me.picb_yubico_logo.TabStop = False
        '
        'p_main_status
        '
        Me.p_main_status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.p_main_status.Location = New System.Drawing.Point(0, 289)
        Me.p_main_status.Margin = New System.Windows.Forms.Padding(0)
        Me.p_main_status.Name = "p_main_status"
        Me.p_main_status.Size = New System.Drawing.Size(343, 16)
        Me.p_main_status.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 305)
        Me.Controls.Add(Me.tlp_main)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.tlp_main.ResumeLayout(False)
        CType(Me.picb_yubico_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_main As TableLayoutPanel
    Friend WithEvents picb_yubico_logo As PictureBox
    Friend WithEvents p_main_status As Panel
End Class
