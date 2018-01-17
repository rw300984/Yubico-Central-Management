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
        Me.grb_admin_personal_tools = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_admin_personal_pivmanager = New System.Windows.Forms.Button()
        Me.btn_admin_personal_yubi_personalization = New System.Windows.Forms.Button()
        Me.lbl_admin_personal_yubi_driver = New System.Windows.Forms.Label()
        Me.lbl_admin_personal_yubi_personalization = New System.Windows.Forms.Label()
        Me.lbl_admin_personal_yubi_pivmanager = New System.Windows.Forms.Label()
        Me.btn_admin_personal_yubi_driver = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New Yubico_Agent.CustomizableProgressBar()
        Me.ProgressBar2 = New Yubico_Agent.CustomizableProgressBar()
        Me.ProgressBar3 = New Yubico_Agent.CustomizableProgressBar()
        Me.grb_admin_general.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grb_admin_personal_tools.SuspendLayout()
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
        Me.grb_admin_general.Margin = New System.Windows.Forms.Padding(2)
        Me.grb_admin_general.Name = "grb_admin_general"
        Me.grb_admin_general.Padding = New System.Windows.Forms.Padding(2)
        Me.grb_admin_general.Size = New System.Drawing.Size(292, 115)
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
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 0)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(288, 98)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_admin_general_language
        '
        Me.lbl_admin_general_language.AutoSize = True
        Me.lbl_admin_general_language.Location = New System.Drawing.Point(4, 2)
        Me.lbl_admin_general_language.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_admin_general_language.Name = "lbl_admin_general_language"
        Me.lbl_admin_general_language.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_general_language.TabIndex = 0
        '
        'lbl_admin_general_theme
        '
        Me.lbl_admin_general_theme.AutoSize = True
        Me.lbl_admin_general_theme.Location = New System.Drawing.Point(4, 34)
        Me.lbl_admin_general_theme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_admin_general_theme.Name = "lbl_admin_general_theme"
        Me.lbl_admin_general_theme.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_general_theme.TabIndex = 1
        '
        'lbl_admin_general_mode
        '
        Me.lbl_admin_general_mode.AutoSize = True
        Me.lbl_admin_general_mode.Location = New System.Drawing.Point(4, 66)
        Me.lbl_admin_general_mode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_admin_general_mode.Name = "lbl_admin_general_mode"
        Me.lbl_admin_general_mode.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_general_mode.TabIndex = 2
        '
        'cbx_admin_general_theme
        '
        Me.cbx_admin_general_theme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_theme.FormattingEnabled = True
        Me.cbx_admin_general_theme.Items.AddRange(New Object() {"Gray (default)", "Light", "Dark"})
        Me.cbx_admin_general_theme.Location = New System.Drawing.Point(117, 37)
        Me.cbx_admin_general_theme.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbx_admin_general_theme.Name = "cbx_admin_general_theme"
        Me.cbx_admin_general_theme.Size = New System.Drawing.Size(101, 23)
        Me.cbx_admin_general_theme.TabIndex = 4
        '
        'cbx_admin_general_mode
        '
        Me.cbx_admin_general_mode.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cbx_admin_general_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_mode.FormattingEnabled = True
        Me.cbx_admin_general_mode.Items.AddRange(New Object() {"Personal", "Business"})
        Me.cbx_admin_general_mode.Location = New System.Drawing.Point(117, 69)
        Me.cbx_admin_general_mode.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbx_admin_general_mode.Name = "cbx_admin_general_mode"
        Me.cbx_admin_general_mode.Size = New System.Drawing.Size(101, 23)
        Me.cbx_admin_general_mode.TabIndex = 5
        '
        'cbx_admin_general_language
        '
        Me.cbx_admin_general_language.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbx_admin_general_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_admin_general_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbx_admin_general_language.FormattingEnabled = True
        Me.cbx_admin_general_language.Items.AddRange(New Object() {"English", "Deutsch"})
        Me.cbx_admin_general_language.Location = New System.Drawing.Point(117, 5)
        Me.cbx_admin_general_language.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cbx_admin_general_language.Name = "cbx_admin_general_language"
        Me.cbx_admin_general_language.Size = New System.Drawing.Size(101, 23)
        Me.cbx_admin_general_language.TabIndex = 6
        '
        'grb_admin_personal_tools
        '
        Me.grb_admin_personal_tools.Controls.Add(Me.TableLayoutPanel2)
        Me.grb_admin_personal_tools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_admin_personal_tools.Location = New System.Drawing.Point(0, 115)
        Me.grb_admin_personal_tools.Margin = New System.Windows.Forms.Padding(2)
        Me.grb_admin_personal_tools.Name = "grb_admin_personal_tools"
        Me.grb_admin_personal_tools.Padding = New System.Windows.Forms.Padding(2)
        Me.grb_admin_personal_tools.Size = New System.Drawing.Size(292, 128)
        Me.grb_admin_personal_tools.TabIndex = 2
        Me.grb_admin_personal_tools.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_personal_yubi_driver, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_personal_yubi_personalization, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_admin_personal_yubi_pivmanager, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgressBar1, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_admin_personal_yubi_driver, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgressBar2, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_admin_personal_yubi_personalization, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.ProgressBar3, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_admin_personal_pivmanager, 1, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 15)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(288, 111)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'btn_admin_personal_pivmanager
        '
        Me.btn_admin_personal_pivmanager.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_admin_personal_pivmanager.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_admin_personal_pivmanager.FlatAppearance.BorderSize = 0
        Me.btn_admin_personal_pivmanager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin_personal_pivmanager.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_admin_personal_pivmanager.Location = New System.Drawing.Point(117, 75)
        Me.btn_admin_personal_pivmanager.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_admin_personal_pivmanager.Name = "btn_admin_personal_pivmanager"
        Me.btn_admin_personal_pivmanager.Size = New System.Drawing.Size(82, 27)
        Me.btn_admin_personal_pivmanager.TabIndex = 10
        Me.btn_admin_personal_pivmanager.UseVisualStyleBackColor = False
        '
        'btn_admin_personal_yubi_personalization
        '
        Me.btn_admin_personal_yubi_personalization.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_admin_personal_yubi_personalization.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_admin_personal_yubi_personalization.FlatAppearance.BorderSize = 0
        Me.btn_admin_personal_yubi_personalization.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin_personal_yubi_personalization.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_admin_personal_yubi_personalization.Location = New System.Drawing.Point(117, 39)
        Me.btn_admin_personal_yubi_personalization.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_admin_personal_yubi_personalization.Name = "btn_admin_personal_yubi_personalization"
        Me.btn_admin_personal_yubi_personalization.Size = New System.Drawing.Size(82, 27)
        Me.btn_admin_personal_yubi_personalization.TabIndex = 9
        Me.btn_admin_personal_yubi_personalization.UseVisualStyleBackColor = False
        '
        'lbl_admin_personal_yubi_driver
        '
        Me.lbl_admin_personal_yubi_driver.AutoSize = True
        Me.lbl_admin_personal_yubi_driver.Location = New System.Drawing.Point(2, 0)
        Me.lbl_admin_personal_yubi_driver.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_admin_personal_yubi_driver.Name = "lbl_admin_personal_yubi_driver"
        Me.lbl_admin_personal_yubi_driver.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_personal_yubi_driver.TabIndex = 0
        '
        'lbl_admin_personal_yubi_personalization
        '
        Me.lbl_admin_personal_yubi_personalization.AutoSize = True
        Me.lbl_admin_personal_yubi_personalization.Location = New System.Drawing.Point(2, 36)
        Me.lbl_admin_personal_yubi_personalization.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_admin_personal_yubi_personalization.Name = "lbl_admin_personal_yubi_personalization"
        Me.lbl_admin_personal_yubi_personalization.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_personal_yubi_personalization.TabIndex = 1
        '
        'lbl_admin_personal_yubi_pivmanager
        '
        Me.lbl_admin_personal_yubi_pivmanager.AutoSize = True
        Me.lbl_admin_personal_yubi_pivmanager.Location = New System.Drawing.Point(2, 72)
        Me.lbl_admin_personal_yubi_pivmanager.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_admin_personal_yubi_pivmanager.Name = "lbl_admin_personal_yubi_pivmanager"
        Me.lbl_admin_personal_yubi_pivmanager.Size = New System.Drawing.Size(0, 15)
        Me.lbl_admin_personal_yubi_pivmanager.TabIndex = 2
        '
        'btn_admin_personal_yubi_driver
        '
        Me.btn_admin_personal_yubi_driver.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_admin_personal_yubi_driver.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_admin_personal_yubi_driver.FlatAppearance.BorderSize = 0
        Me.btn_admin_personal_yubi_driver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_admin_personal_yubi_driver.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_admin_personal_yubi_driver.Location = New System.Drawing.Point(117, 3)
        Me.btn_admin_personal_yubi_driver.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btn_admin_personal_yubi_driver.Name = "btn_admin_personal_yubi_driver"
        Me.btn_admin_personal_yubi_driver.Size = New System.Drawing.Size(82, 27)
        Me.btn_admin_personal_yubi_driver.TabIndex = 8
        Me.btn_admin_personal_yubi_driver.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(204, 3)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(81, 23)
        Me.ProgressBar1.TabIndex = 11
        Me.ProgressBar1.Visible = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar2.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar2.Location = New System.Drawing.Point(204, 39)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(81, 23)
        Me.ProgressBar2.TabIndex = 12
        Me.ProgressBar2.Visible = False
        '
        'ProgressBar3
        '
        Me.ProgressBar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar3.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ProgressBar3.Location = New System.Drawing.Point(204, 75)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(81, 23)
        Me.ProgressBar3.TabIndex = 13
        Me.ProgressBar3.Visible = False
        '
        'frm_admin_personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 243)
        Me.Controls.Add(Me.grb_admin_personal_tools)
        Me.Controls.Add(Me.grb_admin_general)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "frm_admin_personal"
        Me.Text = "frm_admin_personal"
        Me.grb_admin_general.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.grb_admin_personal_tools.ResumeLayout(False)
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
    Friend WithEvents grb_admin_personal_tools As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents btn_admin_personal_pivmanager As Button
    Friend WithEvents btn_admin_personal_yubi_personalization As Button
    Friend WithEvents lbl_admin_personal_yubi_driver As Label
    Friend WithEvents lbl_admin_personal_yubi_personalization As Label
    Friend WithEvents lbl_admin_personal_yubi_pivmanager As Label
    Friend WithEvents btn_admin_personal_yubi_driver As Button
    Friend WithEvents ProgressBar1 As CustomizableProgressBar
    Friend WithEvents ProgressBar3 As CustomizableProgressBar
    Friend WithEvents ProgressBar2 As CustomizableProgressBar
End Class
