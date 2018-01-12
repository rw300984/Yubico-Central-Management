<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin
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
        Me.grb_admin_general = New System.Windows.Forms.GroupBox()
        Me.grb_admin_management = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'grb_admin_general
        '
        Me.grb_admin_general.Dock = System.Windows.Forms.DockStyle.Top
        Me.grb_admin_general.Location = New System.Drawing.Point(3, 3)
        Me.grb_admin_general.Name = "grb_admin_general"
        Me.grb_admin_general.Size = New System.Drawing.Size(344, 80)
        Me.grb_admin_general.TabIndex = 0
        Me.grb_admin_general.TabStop = False
        '
        'grb_admin_management
        '
        Me.grb_admin_management.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_admin_management.Location = New System.Drawing.Point(3, 83)
        Me.grb_admin_management.Name = "grb_admin_management"
        Me.grb_admin_management.Size = New System.Drawing.Size(344, 125)
        Me.grb_admin_management.TabIndex = 1
        Me.grb_admin_management.TabStop = False
        '
        'frm_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(350, 211)
        Me.Controls.Add(Me.grb_admin_management)
        Me.Controls.Add(Me.grb_admin_general)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_admin"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Text = "frm_admin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grb_admin_general As GroupBox
    Friend WithEvents grb_admin_management As GroupBox
End Class
