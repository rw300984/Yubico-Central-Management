<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.panel_table_main = New System.Windows.Forms.TableLayoutPanel()
        Me.picture_logo = New System.Windows.Forms.PictureBox()
        Me.panel_table_main_work = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_main_admin_login = New System.Windows.Forms.Button()
        Me.panel_main_form = New System.Windows.Forms.Panel()
        Me.tray_notify_agent = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.cms_notify_agent = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cms_notify_agent_open = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_notify_agent_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_notify_agent_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.bgw_close = New System.ComponentModel.BackgroundWorker()
        Me.panel_table_main.SuspendLayout()
        CType(Me.picture_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_table_main_work.SuspendLayout()
        Me.cms_notify_agent.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_table_main
        '
        Me.panel_table_main.ColumnCount = 1
        Me.panel_table_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_table_main.Controls.Add(Me.picture_logo, 0, 0)
        Me.panel_table_main.Controls.Add(Me.panel_table_main_work, 0, 1)
        Me.panel_table_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_table_main.Location = New System.Drawing.Point(0, 0)
        Me.panel_table_main.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_table_main.Name = "panel_table_main"
        Me.panel_table_main.RowCount = 2
        Me.panel_table_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.panel_table_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.panel_table_main.Size = New System.Drawing.Size(350, 320)
        Me.panel_table_main.TabIndex = 0
        '
        'picture_logo
        '
        Me.picture_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picture_logo.Image = Global.Yubico_Agent.My.Resources.Resources.Yubico_Logo_Small
        Me.picture_logo.Location = New System.Drawing.Point(0, 0)
        Me.picture_logo.Margin = New System.Windows.Forms.Padding(0)
        Me.picture_logo.Name = "picture_logo"
        Me.picture_logo.Size = New System.Drawing.Size(350, 64)
        Me.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picture_logo.TabIndex = 2
        Me.picture_logo.TabStop = False
        '
        'panel_table_main_work
        '
        Me.panel_table_main_work.ColumnCount = 1
        Me.panel_table_main_work.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.panel_table_main_work.Controls.Add(Me.btn_main_admin_login, 0, 1)
        Me.panel_table_main_work.Controls.Add(Me.panel_main_form, 0, 0)
        Me.panel_table_main_work.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_table_main_work.Location = New System.Drawing.Point(0, 64)
        Me.panel_table_main_work.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_table_main_work.Name = "panel_table_main_work"
        Me.panel_table_main_work.RowCount = 2
        Me.panel_table_main_work.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.0!))
        Me.panel_table_main_work.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.panel_table_main_work.Size = New System.Drawing.Size(350, 256)
        Me.panel_table_main_work.TabIndex = 3
        '
        'btn_main_admin_login
        '
        Me.btn_main_admin_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btn_main_admin_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_main_admin_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_main_admin_login.FlatAppearance.BorderSize = 0
        Me.btn_main_admin_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_main_admin_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_main_admin_login.Location = New System.Drawing.Point(2, 227)
        Me.btn_main_admin_login.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_main_admin_login.Name = "btn_main_admin_login"
        Me.btn_main_admin_login.Size = New System.Drawing.Size(346, 27)
        Me.btn_main_admin_login.TabIndex = 0
        Me.btn_main_admin_login.UseVisualStyleBackColor = False
        '
        'panel_main_form
        '
        Me.panel_main_form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main_form.Location = New System.Drawing.Point(0, 0)
        Me.panel_main_form.Margin = New System.Windows.Forms.Padding(0)
        Me.panel_main_form.Name = "panel_main_form"
        Me.panel_main_form.Size = New System.Drawing.Size(350, 225)
        Me.panel_main_form.TabIndex = 1
        '
        'tray_notify_agent
        '
        Me.tray_notify_agent.ContextMenuStrip = Me.cms_notify_agent
        Me.tray_notify_agent.Icon = CType(resources.GetObject("tray_notify_agent.Icon"), System.Drawing.Icon)
        Me.tray_notify_agent.Text = "Yubico Agent"
        Me.tray_notify_agent.Visible = True
        '
        'cms_notify_agent
        '
        Me.cms_notify_agent.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cms_notify_agent_open, Me.cms_notify_agent_about, Me.cms_notify_agent_close})
        Me.cms_notify_agent.Name = "cms_notify_agent"
        Me.cms_notify_agent.ShowImageMargin = False
        Me.cms_notify_agent.Size = New System.Drawing.Size(43, 70)
        '
        'cms_notify_agent_open
        '
        Me.cms_notify_agent_open.Name = "cms_notify_agent_open"
        Me.cms_notify_agent_open.Size = New System.Drawing.Size(42, 22)
        '
        'cms_notify_agent_about
        '
        Me.cms_notify_agent_about.Name = "cms_notify_agent_about"
        Me.cms_notify_agent_about.Size = New System.Drawing.Size(42, 22)
        '
        'cms_notify_agent_close
        '
        Me.cms_notify_agent_close.Name = "cms_notify_agent_close"
        Me.cms_notify_agent_close.Size = New System.Drawing.Size(42, 22)
        '
        'bgw_close
        '
        Me.bgw_close.WorkerSupportsCancellation = True
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(350, 320)
        Me.Controls.Add(Me.panel_table_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(350, 320)
        Me.MinimizeBox = False
        Me.Name = "frm_main"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Yubico Agent"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.panel_table_main.ResumeLayout(False)
        CType(Me.picture_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_table_main_work.ResumeLayout(False)
        Me.cms_notify_agent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_table_main As TableLayoutPanel
    Friend WithEvents picture_logo As PictureBox
    Friend WithEvents tray_notify_agent As NotifyIcon
    Friend WithEvents cms_notify_agent As ContextMenuStrip
    Friend WithEvents cms_notify_agent_open As ToolStripMenuItem
    Friend WithEvents cms_notify_agent_about As ToolStripMenuItem
    Friend WithEvents cms_notify_agent_close As ToolStripMenuItem
    Friend WithEvents panel_table_main_work As TableLayoutPanel
    Friend WithEvents btn_main_admin_login As Button
    Friend WithEvents panel_main_form As Panel
    Friend WithEvents bgw_close As System.ComponentModel.BackgroundWorker
End Class
