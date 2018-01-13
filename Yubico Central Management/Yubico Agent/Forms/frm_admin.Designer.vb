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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_admin_general_language = New System.Windows.Forms.Label()
        Me.lbl_admin_general_theme = New System.Windows.Forms.Label()
        Me.lbl_admin_general_mode = New System.Windows.Forms.Label()
        Me.cbx_admin_general_language = New System.Windows.Forms.ComboBox()
        Me.cbx_admin_general_theme = New System.Windows.Forms.ComboBox()
        Me.cbx_admin_general_mode = New System.Windows.Forms.ComboBox()
        Me.grb_admin_management = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_admin_central_server = New System.Windows.Forms.Label()
        Me.lbl_admin_central_auth = New System.Windows.Forms.Label()
        Me.lbl_admin_central_username = New System.Windows.Forms.Label()
        Me.lbl_admin_central_password = New System.Windows.Forms.Label()
        Me.cbx_admin_central_auth = New System.Windows.Forms.ComboBox()
        Me.txt_admin_central_server = New System.Windows.Forms.TextBox()
        Me.txt_admin_central_username = New System.Windows.Forms.TextBox()
        Me.txt_admin_central_password = New System.Windows.Forms.TextBox()
        Me.grb_admin_general.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grb_admin_management.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_admin_general
        '
        Me.grb_admin_general.Controls.Add(Me.TableLayoutPanel1)
        Me.grb_admin_general.Dock = System.Windows.Forms.DockStyle.Top
        Me.grb_admin_general.Location = New System.Drawing.Point(2, 3)
        Me.grb_admin_general.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grb_admin_general.Name = "grb_admin_general"
        Me.grb_admin_general.Padding = New System.Windows.Forms.Padding(2)
        Me.grb_admin_general.Size = New System.Drawing.Size(288, 98)
        Me.grb_admin_general.TabIndex = 0
        Me.grb_admin_general.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_admin_general_language, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_admin_general_theme, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_admin_general_mode, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_admin_general_language, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_admin_general_theme, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_admin_general_mode, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(284, 81)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_admin_general_language
        '
        Me.lbl_admin_general_language.AutoSize = True
        Me.lbl_admin_general_language.Location = New System.Drawing.Point(5, 2)
        Me.lbl_admin_general_language.Name = "lbl_admin_general_language"
        Me.lbl_admin_general_language.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_general_language.TabIndex = 0
        '
        'lbl_admin_general_theme
        '
        Me.lbl_admin_general_theme.AutoSize = True
        Me.lbl_admin_general_theme.Location = New System.Drawing.Point(5, 28)
        Me.lbl_admin_general_theme.Name = "lbl_admin_general_theme"
        Me.lbl_admin_general_theme.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_general_theme.TabIndex = 1
        '
        'lbl_admin_general_mode
        '
        Me.lbl_admin_general_mode.AutoSize = True
        Me.lbl_admin_general_mode.Location = New System.Drawing.Point(5, 54)
        Me.lbl_admin_general_mode.Name = "lbl_admin_general_mode"
        Me.lbl_admin_general_mode.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_general_mode.TabIndex = 2
        '
        'cbx_admin_general_language
        '
        Me.cbx_admin_general_language.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbx_admin_general_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_language.FormattingEnabled = True
        Me.cbx_admin_general_language.Items.AddRange(New Object() {"English", "Deutsch"})
        Me.cbx_admin_general_language.Location = New System.Drawing.Point(117, 5)
        Me.cbx_admin_general_language.Name = "cbx_admin_general_language"
        Me.cbx_admin_general_language.Size = New System.Drawing.Size(121, 23)
        Me.cbx_admin_general_language.TabIndex = 3
        '
        'cbx_admin_general_theme
        '
        Me.cbx_admin_general_theme.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbx_admin_general_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_theme.FormattingEnabled = True
        Me.cbx_admin_general_theme.Items.AddRange(New Object() {"Gray (default)", "Light", "Dark"})
        Me.cbx_admin_general_theme.Location = New System.Drawing.Point(117, 31)
        Me.cbx_admin_general_theme.Name = "cbx_admin_general_theme"
        Me.cbx_admin_general_theme.Size = New System.Drawing.Size(121, 23)
        Me.cbx_admin_general_theme.TabIndex = 4
        '
        'cbx_admin_general_mode
        '
        Me.cbx_admin_general_mode.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbx_admin_general_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_mode.FormattingEnabled = True
        Me.cbx_admin_general_mode.Items.AddRange(New Object() {"Personal", "Business"})
        Me.cbx_admin_general_mode.Location = New System.Drawing.Point(117, 57)
        Me.cbx_admin_general_mode.Name = "cbx_admin_general_mode"
        Me.cbx_admin_general_mode.Size = New System.Drawing.Size(121, 23)
        Me.cbx_admin_general_mode.TabIndex = 5
        '
        'grb_admin_management
        '
        Me.grb_admin_management.Controls.Add(Me.TableLayoutPanel2)
        Me.grb_admin_management.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_admin_management.Location = New System.Drawing.Point(2, 101)
        Me.grb_admin_management.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grb_admin_management.Name = "grb_admin_management"
        Me.grb_admin_management.Padding = New System.Windows.Forms.Padding(2)
        Me.grb_admin_management.Size = New System.Drawing.Size(288, 139)
        Me.grb_admin_management.TabIndex = 1
        Me.grb_admin_management.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_central_server, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_central_auth, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_central_username, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_central_password, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.cbx_admin_central_auth, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_admin_central_server, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_admin_central_username, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txt_admin_central_password, 1, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(284, 122)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lbl_admin_central_server
        '
        Me.lbl_admin_central_server.AutoSize = True
        Me.lbl_admin_central_server.Location = New System.Drawing.Point(3, 0)
        Me.lbl_admin_central_server.Name = "lbl_admin_central_server"
        Me.lbl_admin_central_server.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_central_server.TabIndex = 0
        '
        'lbl_admin_central_auth
        '
        Me.lbl_admin_central_auth.AutoSize = True
        Me.lbl_admin_central_auth.Location = New System.Drawing.Point(3, 30)
        Me.lbl_admin_central_auth.Name = "lbl_admin_central_auth"
        Me.lbl_admin_central_auth.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_central_auth.TabIndex = 1
        '
        'lbl_admin_central_username
        '
        Me.lbl_admin_central_username.AutoSize = True
        Me.lbl_admin_central_username.Location = New System.Drawing.Point(3, 60)
        Me.lbl_admin_central_username.Name = "lbl_admin_central_username"
        Me.lbl_admin_central_username.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_central_username.TabIndex = 2
        '
        'lbl_admin_central_password
        '
        Me.lbl_admin_central_password.AutoSize = True
        Me.lbl_admin_central_password.Location = New System.Drawing.Point(3, 90)
        Me.lbl_admin_central_password.Name = "lbl_admin_central_password"
        Me.lbl_admin_central_password.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_central_password.TabIndex = 3
        '
        'cbx_admin_central_auth
        '
        Me.cbx_admin_central_auth.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbx_admin_central_auth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_central_auth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_central_auth.FormattingEnabled = True
        Me.cbx_admin_central_auth.Items.AddRange(New Object() {"Basic", "Windows"})
        Me.cbx_admin_central_auth.Location = New System.Drawing.Point(116, 33)
        Me.cbx_admin_central_auth.Name = "cbx_admin_central_auth"
        Me.cbx_admin_central_auth.Size = New System.Drawing.Size(121, 23)
        Me.cbx_admin_central_auth.TabIndex = 6
        '
        'txt_admin_central_server
        '
        Me.txt_admin_central_server.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_admin_central_server.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_admin_central_server.Location = New System.Drawing.Point(116, 3)
        Me.txt_admin_central_server.Name = "txt_admin_central_server"
        Me.txt_admin_central_server.Size = New System.Drawing.Size(121, 13)
        Me.txt_admin_central_server.TabIndex = 7
        '
        'txt_admin_central_username
        '
        Me.txt_admin_central_username.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_admin_central_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_admin_central_username.Location = New System.Drawing.Point(116, 63)
        Me.txt_admin_central_username.Name = "txt_admin_central_username"
        Me.txt_admin_central_username.Size = New System.Drawing.Size(121, 13)
        Me.txt_admin_central_username.TabIndex = 8
        '
        'txt_admin_central_password
        '
        Me.txt_admin_central_password.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txt_admin_central_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_admin_central_password.Location = New System.Drawing.Point(116, 93)
        Me.txt_admin_central_password.Name = "txt_admin_central_password"
        Me.txt_admin_central_password.Size = New System.Drawing.Size(121, 13)
        Me.txt_admin_central_password.TabIndex = 9
        '
        'frm_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(292, 243)
        Me.Controls.Add(Me.grb_admin_management)
        Me.Controls.Add(Me.grb_admin_general)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frm_admin"
        Me.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Text = "frm_admin"
        Me.grb_admin_general.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grb_admin_management.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grb_admin_general As GroupBox
    Friend WithEvents grb_admin_management As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_admin_general_language As Label
    Friend WithEvents lbl_admin_general_theme As Label
    Friend WithEvents lbl_admin_general_mode As Label
    Friend WithEvents cbx_admin_general_language As ComboBox
    Friend WithEvents cbx_admin_general_theme As ComboBox
    Friend WithEvents cbx_admin_general_mode As ComboBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_admin_central_server As Label
    Friend WithEvents lbl_admin_central_auth As Label
    Friend WithEvents lbl_admin_central_username As Label
    Friend WithEvents lbl_admin_central_password As Label
    Friend WithEvents cbx_admin_central_auth As ComboBox
    Friend WithEvents txt_admin_central_server As TextBox
    Friend WithEvents txt_admin_central_username As TextBox
    Friend WithEvents txt_admin_central_password As TextBox
End Class
