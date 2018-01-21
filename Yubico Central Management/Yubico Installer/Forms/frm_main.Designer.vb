<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_main_next = New System.Windows.Forms.Button()
        Me.btn_main_back = New System.Windows.Forms.Button()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_main_start_agent = New System.Windows.Forms.Label()
        Me.lbl_main_finish = New System.Windows.Forms.Label()
        Me.lbl_main_start_install = New System.Windows.Forms.Label()
        Me.lbl_main_options = New System.Windows.Forms.Label()
        Me.lbl_main_password = New System.Windows.Forms.Label()
        Me.lbl_main_path = New System.Windows.Forms.Label()
        Me.lbl_main_updates = New System.Windows.Forms.Label()
        Me.lbl_main_eula = New System.Windows.Forms.Label()
        Me.RoundedPanel1 = New Yubico_Installer.RoundedPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.RoundedPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(715, 454)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(500, 454)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.Yubico_Installer.My.Resources.Resources.img_yubico_logo_small
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 5
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_main_next, 3, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_main_back, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 422)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(500, 32)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btn_main_next
        '
        Me.btn_main_next.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_main_next.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_main_next.FlatAppearance.BorderSize = 0
        Me.btn_main_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_main_next.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_main_next.Location = New System.Drawing.Point(400, 0)
        Me.btn_main_next.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_main_next.Name = "btn_main_next"
        Me.btn_main_next.Size = New System.Drawing.Size(75, 27)
        Me.btn_main_next.TabIndex = 1
        Me.btn_main_next.Text = "Next"
        Me.btn_main_next.UseVisualStyleBackColor = False
        '
        'btn_main_back
        '
        Me.btn_main_back.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_main_back.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_main_back.FlatAppearance.BorderSize = 0
        Me.btn_main_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_main_back.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_main_back.Location = New System.Drawing.Point(315, 0)
        Me.btn_main_back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_main_back.Name = "btn_main_back"
        Me.btn_main_back.Size = New System.Drawing.Size(75, 27)
        Me.btn_main_back.TabIndex = 0
        Me.btn_main_back.Text = "Back"
        Me.btn_main_back.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.RoundedPanel1, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(0, 68)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(500, 354)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(50, 35)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 293)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TableLayoutPanel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(500, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(215, 454)
        Me.Panel1.TabIndex = 1
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.Panel3, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 3
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(215, 454)
        Me.TableLayoutPanel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.BackgroundImage = Global.Yubico_Installer.My.Resources.Resources.ico_close_window
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel3.Location = New System.Drawing.Point(193, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(22, 20)
        Me.Panel3.TabIndex = 0
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_start_agent, 0, 7)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_finish, 0, 6)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_start_install, 0, 5)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_options, 0, 4)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_password, 0, 3)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_path, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_updates, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lbl_main_eula, 0, 0)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 71)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 8
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(187, 320)
        Me.TableLayoutPanel6.TabIndex = 1
        '
        'lbl_main_start_agent
        '
        Me.lbl_main_start_agent.AutoSize = True
        Me.lbl_main_start_agent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_start_agent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_start_agent.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_start_agent.Location = New System.Drawing.Point(3, 280)
        Me.lbl_main_start_agent.Name = "lbl_main_start_agent"
        Me.lbl_main_start_agent.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_start_agent.TabIndex = 7
        Me.lbl_main_start_agent.Text = "Start Yubico Agent"
        Me.lbl_main_start_agent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_main_finish
        '
        Me.lbl_main_finish.AutoSize = True
        Me.lbl_main_finish.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_finish.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_finish.Location = New System.Drawing.Point(3, 240)
        Me.lbl_main_finish.Name = "lbl_main_finish"
        Me.lbl_main_finish.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_finish.TabIndex = 6
        Me.lbl_main_finish.Text = "Finish Installation"
        Me.lbl_main_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_main_start_install
        '
        Me.lbl_main_start_install.AutoSize = True
        Me.lbl_main_start_install.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_start_install.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_start_install.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_start_install.Location = New System.Drawing.Point(3, 200)
        Me.lbl_main_start_install.Name = "lbl_main_start_install"
        Me.lbl_main_start_install.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_start_install.TabIndex = 5
        Me.lbl_main_start_install.Text = "Start Installation"
        Me.lbl_main_start_install.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_main_options
        '
        Me.lbl_main_options.AutoSize = True
        Me.lbl_main_options.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_options.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_options.Location = New System.Drawing.Point(3, 160)
        Me.lbl_main_options.Name = "lbl_main_options"
        Me.lbl_main_options.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_options.TabIndex = 4
        Me.lbl_main_options.Text = "Choose Options"
        Me.lbl_main_options.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_main_password
        '
        Me.lbl_main_password.AutoSize = True
        Me.lbl_main_password.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_password.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_password.Location = New System.Drawing.Point(3, 120)
        Me.lbl_main_password.Name = "lbl_main_password"
        Me.lbl_main_password.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_password.TabIndex = 3
        Me.lbl_main_password.Text = "Choose Master Password"
        Me.lbl_main_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_main_path
        '
        Me.lbl_main_path.AutoSize = True
        Me.lbl_main_path.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_path.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_path.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_path.Location = New System.Drawing.Point(3, 80)
        Me.lbl_main_path.Name = "lbl_main_path"
        Me.lbl_main_path.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_path.TabIndex = 2
        Me.lbl_main_path.Text = "Choose Install Path"
        Me.lbl_main_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_main_updates
        '
        Me.lbl_main_updates.AutoSize = True
        Me.lbl_main_updates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_updates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_updates.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_updates.Location = New System.Drawing.Point(3, 40)
        Me.lbl_main_updates.Name = "lbl_main_updates"
        Me.lbl_main_updates.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_updates.TabIndex = 1
        Me.lbl_main_updates.Text = "Check for Updates"
        Me.lbl_main_updates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_main_eula
        '
        Me.lbl_main_eula.AutoSize = True
        Me.lbl_main_eula.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_main_eula.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_main_eula.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_main_eula.Location = New System.Drawing.Point(3, 0)
        Me.lbl_main_eula.Name = "lbl_main_eula"
        Me.lbl_main_eula.Size = New System.Drawing.Size(181, 40)
        Me.lbl_main_eula.TabIndex = 0
        Me.lbl_main_eula.Text = "End User License Agreement"
        Me.lbl_main_eula.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RoundedPanel1
        '
        Me.RoundedPanel1.BackColor = System.Drawing.Color.LightCoral
        Me.RoundedPanel1.BorderColor = System.Drawing.Color.LightCoral
        Me.RoundedPanel1.Controls.Add(Me.Label1)
        Me.RoundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoundedPanel1.Edge = 10
        Me.RoundedPanel1.Location = New System.Drawing.Point(53, 331)
        Me.RoundedPanel1.Name = "RoundedPanel1"
        Me.RoundedPanel1.Size = New System.Drawing.Size(419, 20)
        Me.RoundedPanel1.TabIndex = 0
        Me.RoundedPanel1.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Error: Please check logfile"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 454)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_main"
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.RoundedPanel1.ResumeLayout(False)
        Me.RoundedPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_main_next As Button
    Friend WithEvents btn_main_back As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lbl_main_start_agent As Label
    Friend WithEvents lbl_main_finish As Label
    Friend WithEvents lbl_main_start_install As Label
    Friend WithEvents lbl_main_options As Label
    Friend WithEvents lbl_main_password As Label
    Friend WithEvents lbl_main_path As Label
    Friend WithEvents lbl_main_updates As Label
    Friend WithEvents lbl_main_eula As Label
    Friend WithEvents RoundedPanel1 As RoundedPanel
    Friend WithEvents Label1 As Label
End Class
