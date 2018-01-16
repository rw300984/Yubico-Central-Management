<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_personal
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
        Me.grb_admin_general = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_admin_general_language = New System.Windows.Forms.Label()
        Me.lbl_admin_general_theme = New System.Windows.Forms.Label()
        Me.lbl_admin_general_mode = New System.Windows.Forms.Label()
        Me.cbx_admin_general_theme = New System.Windows.Forms.ComboBox()
        Me.cbx_admin_general_mode = New System.Windows.Forms.ComboBox()
        Me.cbx_admin_general_language = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_admin_personal_driver = New System.Windows.Forms.Label()
        Me.lbl_admin_personal_yubi_personalization = New System.Windows.Forms.Label()
        Me.lbl_admin_personal_yubi_pivmanager = New System.Windows.Forms.Label()
        Me.lbl_admin_yubi_authenticator = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar4 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.grb_admin_general.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grb_admin_general
        '
        Me.grb_admin_general.BackColor = System.Drawing.SystemColors.Control
        Me.grb_admin_general.Controls.Add(Me.TableLayoutPanel1)
        Me.grb_admin_general.Dock = System.Windows.Forms.DockStyle.Top
        Me.grb_admin_general.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grb_admin_general.Location = New System.Drawing.Point(0, 0)
        Me.grb_admin_general.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grb_admin_general.Name = "grb_admin_general"
        Me.grb_admin_general.Padding = New System.Windows.Forms.Padding(2)
        Me.grb_admin_general.Size = New System.Drawing.Size(292, 98)
        Me.grb_admin_general.TabIndex = 1
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
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_admin_general_theme, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_admin_general_mode, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_admin_general_language, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(288, 81)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_admin_general_language
        '
        Me.lbl_admin_general_language.AutoSize = True
        Me.lbl_admin_general_language.Location = New System.Drawing.Point(5, 2)
        Me.lbl_admin_general_language.Name = "lbl_admin_general_language"
        Me.lbl_admin_general_language.Size = New System.Drawing.Size(0, 13)
        Me.lbl_admin_general_language.TabIndex = 0
        '
        'lbl_admin_general_theme
        '
        Me.lbl_admin_general_theme.AutoSize = True
        Me.lbl_admin_general_theme.Location = New System.Drawing.Point(5, 28)
        Me.lbl_admin_general_theme.Name = "lbl_admin_general_theme"
        Me.lbl_admin_general_theme.Size = New System.Drawing.Size(0, 13)
        Me.lbl_admin_general_theme.TabIndex = 1
        '
        'lbl_admin_general_mode
        '
        Me.lbl_admin_general_mode.AutoSize = True
        Me.lbl_admin_general_mode.Location = New System.Drawing.Point(5, 54)
        Me.lbl_admin_general_mode.Name = "lbl_admin_general_mode"
        Me.lbl_admin_general_mode.Size = New System.Drawing.Size(0, 13)
        Me.lbl_admin_general_mode.TabIndex = 2
        '
        'cbx_admin_general_theme
        '
        Me.cbx_admin_general_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_theme.FormattingEnabled = True
        Me.cbx_admin_general_theme.Items.AddRange(New Object() {"Gray (default)", "Light", "Dark"})
        Me.cbx_admin_general_theme.Location = New System.Drawing.Point(118, 31)
        Me.cbx_admin_general_theme.Name = "cbx_admin_general_theme"
        Me.cbx_admin_general_theme.Size = New System.Drawing.Size(121, 21)
        Me.cbx_admin_general_theme.TabIndex = 4
        '
        'cbx_admin_general_mode
        '
        Me.cbx_admin_general_mode.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbx_admin_general_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_mode.FormattingEnabled = True
        Me.cbx_admin_general_mode.Items.AddRange(New Object() {"Personal", "Business"})
        Me.cbx_admin_general_mode.Location = New System.Drawing.Point(118, 57)
        Me.cbx_admin_general_mode.Name = "cbx_admin_general_mode"
        Me.cbx_admin_general_mode.Size = New System.Drawing.Size(121, 21)
        Me.cbx_admin_general_mode.TabIndex = 5
        '
        'cbx_admin_general_language
        '
        Me.cbx_admin_general_language.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_admin_general_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_language.FormattingEnabled = True
        Me.cbx_admin_general_language.Items.AddRange(New Object() {"English", "Deutsch"})
        Me.cbx_admin_general_language.Location = New System.Drawing.Point(118, 5)
        Me.cbx_admin_general_language.Name = "cbx_admin_general_language"
        Me.cbx_admin_general_language.Size = New System.Drawing.Size(121, 21)
        Me.cbx_admin_general_language.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 145)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.72028!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.11189!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.51748!))
        Me.TableLayoutPanel2.Controls.Add(Me.Button4, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Button3, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Button2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgressBar4, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgressBar3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgressBar2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_personal_driver, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_personal_yubi_personalization, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_personal_yubi_pivmanager, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_yubi_authenticator, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgressBar1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Button1, 2, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(286, 126)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lbl_admin_personal_driver
        '
        Me.lbl_admin_personal_driver.AutoSize = True
        Me.lbl_admin_personal_driver.Location = New System.Drawing.Point(3, 0)
        Me.lbl_admin_personal_driver.Name = "lbl_admin_personal_driver"
        Me.lbl_admin_personal_driver.Size = New System.Drawing.Size(0, 13)
        Me.lbl_admin_personal_driver.TabIndex = 0
        '
        'lbl_admin_personal_yubi_personalization
        '
        Me.lbl_admin_personal_yubi_personalization.AutoSize = True
        Me.lbl_admin_personal_yubi_personalization.Location = New System.Drawing.Point(3, 31)
        Me.lbl_admin_personal_yubi_personalization.Name = "lbl_admin_personal_yubi_personalization"
        Me.lbl_admin_personal_yubi_personalization.Size = New System.Drawing.Size(0, 13)
        Me.lbl_admin_personal_yubi_personalization.TabIndex = 1
        '
        'lbl_admin_personal_yubi_pivmanager
        '
        Me.lbl_admin_personal_yubi_pivmanager.AutoSize = True
        Me.lbl_admin_personal_yubi_pivmanager.Location = New System.Drawing.Point(3, 62)
        Me.lbl_admin_personal_yubi_pivmanager.Name = "lbl_admin_personal_yubi_pivmanager"
        Me.lbl_admin_personal_yubi_pivmanager.Size = New System.Drawing.Size(0, 13)
        Me.lbl_admin_personal_yubi_pivmanager.TabIndex = 2
        '
        'lbl_admin_yubi_authenticator
        '
        Me.lbl_admin_yubi_authenticator.AutoSize = True
        Me.lbl_admin_yubi_authenticator.Location = New System.Drawing.Point(3, 93)
        Me.lbl_admin_yubi_authenticator.Name = "lbl_admin_yubi_authenticator"
        Me.lbl_admin_yubi_authenticator.Size = New System.Drawing.Size(0, 13)
        Me.lbl_admin_yubi_authenticator.TabIndex = 3
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(87, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar1.TabIndex = 4
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(87, 34)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar2.TabIndex = 5
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(87, 65)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar3.TabIndex = 6
        '
        'ProgressBar4
        '
        Me.ProgressBar4.Location = New System.Drawing.Point(87, 96)
        Me.ProgressBar4.Name = "ProgressBar4"
        Me.ProgressBar4.Size = New System.Drawing.Size(100, 23)
        Me.ProgressBar4.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(195, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(195, 34)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(195, 65)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(195, 96)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'frm_admin_personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 243)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grb_admin_general)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_admin_personal"
        Me.Text = "frm_admin_personal"
        Me.grb_admin_general.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grb_admin_general As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_admin_general_language As Label
    Friend WithEvents lbl_admin_general_theme As Label
    Friend WithEvents lbl_admin_general_mode As Label
    Friend WithEvents cbx_admin_general_theme As ComboBox
    Friend WithEvents cbx_admin_general_mode As ComboBox
    Friend WithEvents cbx_admin_general_language As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ProgressBar4 As ProgressBar
    Friend WithEvents ProgressBar3 As ProgressBar
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents lbl_admin_personal_driver As Label
    Friend WithEvents lbl_admin_personal_yubi_personalization As Label
    Friend WithEvents lbl_admin_personal_yubi_pivmanager As Label
    Friend WithEvents lbl_admin_yubi_authenticator As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
End Class
