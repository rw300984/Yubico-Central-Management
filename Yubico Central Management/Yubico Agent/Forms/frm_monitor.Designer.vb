<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_monitor
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
        Me.grb_monitor_systeminfo = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_monitor_sys_devicemodel_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_sys_os_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_sys_hostname_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_sys_ip_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_sys_username_output = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_sys_hostname_text = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_sys_username_text = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_sys_devicemodel_text = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_sys_os_text = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_sys_ip_text = New System.Windows.Forms.Label()
        Me.grb_monitor_yubiinfo = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_yub_firmware_text = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_yub_vendor_text = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_yub_touch_text = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_yub_serial_text = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lbl_monitor_yub_model_text = New System.Windows.Forms.Label()
        Me.lbl_monitor_yub_vendor_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_yub_model_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_yub_firmware_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_yub_serial_output = New System.Windows.Forms.Label()
        Me.lbl_monitor_yub_touch_output = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grb_monitor_systeminfo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.grb_monitor_yubiinfo.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.grb_monitor_yubiinfo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.grb_monitor_systeminfo, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(350, 211)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'grb_monitor_systeminfo
        '
        Me.grb_monitor_systeminfo.Controls.Add(Me.TableLayoutPanel2)
        Me.grb_monitor_systeminfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_monitor_systeminfo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_monitor_systeminfo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grb_monitor_systeminfo.Location = New System.Drawing.Point(3, 3)
        Me.grb_monitor_systeminfo.Name = "grb_monitor_systeminfo"
        Me.grb_monitor_systeminfo.Size = New System.Drawing.Size(344, 99)
        Me.grb_monitor_systeminfo.TabIndex = 0
        Me.grb_monitor_systeminfo.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_monitor_sys_devicemodel_output, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_monitor_sys_os_output, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_monitor_sys_hostname_output, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_monitor_sys_ip_output, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_monitor_sys_username_output, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel6, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel3, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel5, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(338, 80)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lbl_monitor_sys_devicemodel_output
        '
        Me.lbl_monitor_sys_devicemodel_output.AutoSize = True
        Me.lbl_monitor_sys_devicemodel_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_devicemodel_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_devicemodel_output.Location = New System.Drawing.Point(138, 64)
        Me.lbl_monitor_sys_devicemodel_output.Name = "lbl_monitor_sys_devicemodel_output"
        Me.lbl_monitor_sys_devicemodel_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_sys_devicemodel_output.TabIndex = 10
        '
        'lbl_monitor_sys_os_output
        '
        Me.lbl_monitor_sys_os_output.AutoSize = True
        Me.lbl_monitor_sys_os_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_os_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_os_output.Location = New System.Drawing.Point(138, 48)
        Me.lbl_monitor_sys_os_output.Name = "lbl_monitor_sys_os_output"
        Me.lbl_monitor_sys_os_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_sys_os_output.TabIndex = 9
        '
        'lbl_monitor_sys_hostname_output
        '
        Me.lbl_monitor_sys_hostname_output.AutoSize = True
        Me.lbl_monitor_sys_hostname_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_hostname_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_hostname_output.Location = New System.Drawing.Point(138, 32)
        Me.lbl_monitor_sys_hostname_output.Name = "lbl_monitor_sys_hostname_output"
        Me.lbl_monitor_sys_hostname_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_sys_hostname_output.TabIndex = 8
        '
        'lbl_monitor_sys_ip_output
        '
        Me.lbl_monitor_sys_ip_output.AutoSize = True
        Me.lbl_monitor_sys_ip_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_ip_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_ip_output.Location = New System.Drawing.Point(138, 16)
        Me.lbl_monitor_sys_ip_output.Name = "lbl_monitor_sys_ip_output"
        Me.lbl_monitor_sys_ip_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_sys_ip_output.TabIndex = 7
        '
        'lbl_monitor_sys_username_output
        '
        Me.lbl_monitor_sys_username_output.AutoSize = True
        Me.lbl_monitor_sys_username_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_username_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_username_output.Location = New System.Drawing.Point(138, 0)
        Me.lbl_monitor_sys_username_output.Name = "lbl_monitor_sys_username_output"
        Me.lbl_monitor_sys_username_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_sys_username_output.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Control
        Me.Panel6.Controls.Add(Me.lbl_monitor_sys_hostname_text)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 32)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(135, 16)
        Me.Panel6.TabIndex = 5
        '
        'lbl_monitor_sys_hostname_text
        '
        Me.lbl_monitor_sys_hostname_text.AutoSize = True
        Me.lbl_monitor_sys_hostname_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_hostname_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_hostname_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_sys_hostname_text.Name = "lbl_monitor_sys_hostname_text"
        Me.lbl_monitor_sys_hostname_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_sys_hostname_text.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.Controls.Add(Me.lbl_monitor_sys_username_text)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 3)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(135, 13)
        Me.Panel4.TabIndex = 3
        '
        'lbl_monitor_sys_username_text
        '
        Me.lbl_monitor_sys_username_text.AutoSize = True
        Me.lbl_monitor_sys_username_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_username_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_username_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_sys_username_text.Name = "lbl_monitor_sys_username_text"
        Me.lbl_monitor_sys_username_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_sys_username_text.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.lbl_monitor_sys_devicemodel_text)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 64)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(135, 16)
        Me.Panel2.TabIndex = 1
        '
        'lbl_monitor_sys_devicemodel_text
        '
        Me.lbl_monitor_sys_devicemodel_text.AutoSize = True
        Me.lbl_monitor_sys_devicemodel_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_devicemodel_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_devicemodel_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_sys_devicemodel_text.Name = "lbl_monitor_sys_devicemodel_text"
        Me.lbl_monitor_sys_devicemodel_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_sys_devicemodel_text.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.lbl_monitor_sys_os_text)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 48)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(135, 16)
        Me.Panel3.TabIndex = 2
        '
        'lbl_monitor_sys_os_text
        '
        Me.lbl_monitor_sys_os_text.AutoSize = True
        Me.lbl_monitor_sys_os_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_os_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_os_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_sys_os_text.Name = "lbl_monitor_sys_os_text"
        Me.lbl_monitor_sys_os_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_sys_os_text.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.lbl_monitor_sys_ip_text)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 16)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(135, 16)
        Me.Panel5.TabIndex = 4
        '
        'lbl_monitor_sys_ip_text
        '
        Me.lbl_monitor_sys_ip_text.AutoSize = True
        Me.lbl_monitor_sys_ip_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_sys_ip_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_sys_ip_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_sys_ip_text.Name = "lbl_monitor_sys_ip_text"
        Me.lbl_monitor_sys_ip_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_sys_ip_text.TabIndex = 0
        '
        'grb_monitor_yubiinfo
        '
        Me.grb_monitor_yubiinfo.BackColor = System.Drawing.SystemColors.Control
        Me.grb_monitor_yubiinfo.Controls.Add(Me.TableLayoutPanel3)
        Me.grb_monitor_yubiinfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grb_monitor_yubiinfo.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grb_monitor_yubiinfo.Location = New System.Drawing.Point(3, 108)
        Me.grb_monitor_yubiinfo.Name = "grb_monitor_yubiinfo"
        Me.grb_monitor_yubiinfo.Size = New System.Drawing.Size(344, 100)
        Me.grb_monitor_yubiinfo.TabIndex = 2
        Me.grb_monitor_yubiinfo.TabStop = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Panel7, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel8, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel10, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel11, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel12, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_monitor_yub_vendor_output, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_monitor_yub_model_output, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_monitor_yub_firmware_output, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_monitor_yub_serial_output, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_monitor_yub_touch_output, 1, 4)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(338, 81)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Controls.Add(Me.lbl_monitor_yub_firmware_text)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 32)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(135, 16)
        Me.Panel7.TabIndex = 5
        '
        'lbl_monitor_yub_firmware_text
        '
        Me.lbl_monitor_yub_firmware_text.AutoSize = True
        Me.lbl_monitor_yub_firmware_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_firmware_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_firmware_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_yub_firmware_text.Name = "lbl_monitor_yub_firmware_text"
        Me.lbl_monitor_yub_firmware_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_yub_firmware_text.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.Control
        Me.Panel8.Controls.Add(Me.lbl_monitor_yub_vendor_text)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 3)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(135, 13)
        Me.Panel8.TabIndex = 3
        '
        'lbl_monitor_yub_vendor_text
        '
        Me.lbl_monitor_yub_vendor_text.AutoSize = True
        Me.lbl_monitor_yub_vendor_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_vendor_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_vendor_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_yub_vendor_text.Name = "lbl_monitor_yub_vendor_text"
        Me.lbl_monitor_yub_vendor_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_yub_vendor_text.TabIndex = 0
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.Control
        Me.Panel10.Controls.Add(Me.lbl_monitor_yub_touch_text)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(0, 64)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(135, 17)
        Me.Panel10.TabIndex = 1
        '
        'lbl_monitor_yub_touch_text
        '
        Me.lbl_monitor_yub_touch_text.AutoSize = True
        Me.lbl_monitor_yub_touch_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_touch_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_yub_touch_text.Name = "lbl_monitor_yub_touch_text"
        Me.lbl_monitor_yub_touch_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_yub_touch_text.TabIndex = 2
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.Controls.Add(Me.lbl_monitor_yub_serial_text)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(0, 48)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(135, 16)
        Me.Panel11.TabIndex = 2
        '
        'lbl_monitor_yub_serial_text
        '
        Me.lbl_monitor_yub_serial_text.AutoSize = True
        Me.lbl_monitor_yub_serial_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_serial_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_serial_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_yub_serial_text.Name = "lbl_monitor_yub_serial_text"
        Me.lbl_monitor_yub_serial_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_yub_serial_text.TabIndex = 2
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.Controls.Add(Me.lbl_monitor_yub_model_text)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(0, 16)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(135, 16)
        Me.Panel12.TabIndex = 4
        '
        'lbl_monitor_yub_model_text
        '
        Me.lbl_monitor_yub_model_text.AutoSize = True
        Me.lbl_monitor_yub_model_text.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_model_text.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_model_text.Location = New System.Drawing.Point(0, 0)
        Me.lbl_monitor_yub_model_text.Name = "lbl_monitor_yub_model_text"
        Me.lbl_monitor_yub_model_text.Size = New System.Drawing.Size(0, 15)
        Me.lbl_monitor_yub_model_text.TabIndex = 1
        '
        'lbl_monitor_yub_vendor_output
        '
        Me.lbl_monitor_yub_vendor_output.AutoSize = True
        Me.lbl_monitor_yub_vendor_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_vendor_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_vendor_output.Location = New System.Drawing.Point(138, 0)
        Me.lbl_monitor_yub_vendor_output.Name = "lbl_monitor_yub_vendor_output"
        Me.lbl_monitor_yub_vendor_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_yub_vendor_output.TabIndex = 6
        '
        'lbl_monitor_yub_model_output
        '
        Me.lbl_monitor_yub_model_output.AutoSize = True
        Me.lbl_monitor_yub_model_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_model_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_model_output.Location = New System.Drawing.Point(138, 16)
        Me.lbl_monitor_yub_model_output.Name = "lbl_monitor_yub_model_output"
        Me.lbl_monitor_yub_model_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_yub_model_output.TabIndex = 7
        '
        'lbl_monitor_yub_firmware_output
        '
        Me.lbl_monitor_yub_firmware_output.AutoSize = True
        Me.lbl_monitor_yub_firmware_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_firmware_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_firmware_output.Location = New System.Drawing.Point(138, 32)
        Me.lbl_monitor_yub_firmware_output.Name = "lbl_monitor_yub_firmware_output"
        Me.lbl_monitor_yub_firmware_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_yub_firmware_output.TabIndex = 8
        '
        'lbl_monitor_yub_serial_output
        '
        Me.lbl_monitor_yub_serial_output.AutoSize = True
        Me.lbl_monitor_yub_serial_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_serial_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_serial_output.Location = New System.Drawing.Point(138, 48)
        Me.lbl_monitor_yub_serial_output.Name = "lbl_monitor_yub_serial_output"
        Me.lbl_monitor_yub_serial_output.Size = New System.Drawing.Size(197, 16)
        Me.lbl_monitor_yub_serial_output.TabIndex = 9
        '
        'lbl_monitor_yub_touch_output
        '
        Me.lbl_monitor_yub_touch_output.AutoSize = True
        Me.lbl_monitor_yub_touch_output.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_monitor_yub_touch_output.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monitor_yub_touch_output.Location = New System.Drawing.Point(138, 64)
        Me.lbl_monitor_yub_touch_output.Name = "lbl_monitor_yub_touch_output"
        Me.lbl_monitor_yub_touch_output.Size = New System.Drawing.Size(197, 17)
        Me.lbl_monitor_yub_touch_output.TabIndex = 10
        '
        'frm_monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(350, 211)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_monitor"
        Me.Text = "frm_monitor"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grb_monitor_systeminfo.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.grb_monitor_yubiinfo.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents grb_monitor_systeminfo As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_monitor_sys_hostname_text As Label
    Friend WithEvents lbl_monitor_sys_username_text As Label
    Friend WithEvents lbl_monitor_sys_devicemodel_text As Label
    Friend WithEvents lbl_monitor_sys_os_text As Label
    Friend WithEvents lbl_monitor_sys_ip_text As Label
    Friend WithEvents lbl_monitor_sys_devicemodel_output As Label
    Friend WithEvents lbl_monitor_sys_os_output As Label
    Friend WithEvents lbl_monitor_sys_hostname_output As Label
    Friend WithEvents lbl_monitor_sys_ip_output As Label
    Friend WithEvents lbl_monitor_sys_username_output As Label
    Friend WithEvents grb_monitor_yubiinfo As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lbl_monitor_yub_firmware_text As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl_monitor_yub_vendor_text As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents lbl_monitor_yub_touch_text As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lbl_monitor_yub_serial_text As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents lbl_monitor_yub_model_text As Label
    Friend WithEvents lbl_monitor_yub_vendor_output As Label
    Friend WithEvents lbl_monitor_yub_model_output As Label
    Friend WithEvents lbl_monitor_yub_firmware_output As Label
    Friend WithEvents lbl_monitor_yub_serial_output As Label
    Friend WithEvents lbl_monitor_yub_touch_output As Label
End Class
