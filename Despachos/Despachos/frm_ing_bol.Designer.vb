<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ing_bol
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ing_bol))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_codejec = New System.Windows.Forms.Label()
        Me.lbl_idbd = New System.Windows.Forms.Label()
        Me.lbl_nrodp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_vendedor = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_bod = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_mto_boe = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_fe_boe = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_nro_boe = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.lbl_fe_actual = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_reg = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.ch_stop_timer = New System.Windows.Forms.CheckBox()
        Me.cmd_limpíar = New System.Windows.Forms.Button()
        Me.txt_bus_boe = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ch_anio_ant = New System.Windows.Forms.CheckBox()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.TP1 = New System.Windows.Forms.TabPage()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.TP2 = New System.Windows.Forms.TabPage()
        Me.grilla2 = New System.Windows.Forms.DataGridView()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.txt_obs_boe = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cbo_ampm = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.msk_fe_desp = New System.Windows.Forms.MaskedTextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cbo_acomodador = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_patente = New System.Windows.Forms.Label()
        Me.cbo_medio_tp = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbo_chofer = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_ciudad = New System.Windows.Forms.ComboBox()
        Me.txt_peso = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_nrobulto = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cedible = New System.Windows.Forms.TextBox()
        Me.txt_nroflete = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_tp = New System.Windows.Forms.ComboBox()
        Me.cmd_modifica2 = New System.Windows.Forms.Button()
        Me.txt_bus_boe_desp = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BuscarDespachoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_IngreseNroBoleta = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.TP1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP2.SuspendLayout()
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_codejec)
        Me.GroupBox1.Controls.Add(Me.lbl_idbd)
        Me.GroupBox1.Controls.Add(Me.lbl_nrodp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lbl_vendedor)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbl_bod)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_mto_boe)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lbl_fe_boe)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_nro_boe)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbl_nombre)
        Me.GroupBox1.Controls.Add(Me.lbl_rut)
        Me.GroupBox1.Controls.Add(Me.lbl_fe_actual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1056, 124)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Documento"
        '
        'lbl_codejec
        '
        Me.lbl_codejec.AutoSize = True
        Me.lbl_codejec.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_codejec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_codejec.Location = New System.Drawing.Point(413, 76)
        Me.lbl_codejec.Name = "lbl_codejec"
        Me.lbl_codejec.Size = New System.Drawing.Size(69, 17)
        Me.lbl_codejec.TabIndex = 24
        Me.lbl_codejec.Text = "lbl_codejec"
        '
        'lbl_idbd
        '
        Me.lbl_idbd.AutoSize = True
        Me.lbl_idbd.Location = New System.Drawing.Point(976, 19)
        Me.lbl_idbd.Name = "lbl_idbd"
        Me.lbl_idbd.Size = New System.Drawing.Size(50, 15)
        Me.lbl_idbd.TabIndex = 23
        Me.lbl_idbd.Text = "lbl_idbd"
        Me.lbl_idbd.Visible = False
        '
        'lbl_nrodp
        '
        Me.lbl_nrodp.AutoSize = True
        Me.lbl_nrodp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nrodp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrodp.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nrodp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_nrodp.Location = New System.Drawing.Point(814, 86)
        Me.lbl_nrodp.Name = "lbl_nrodp"
        Me.lbl_nrodp.Size = New System.Drawing.Size(88, 25)
        Me.lbl_nrodp.TabIndex = 22
        Me.lbl_nrodp.Text = "lbl_nrodp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(782, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "NRO. DE DESPACHO:"
        '
        'lbl_vendedor
        '
        Me.lbl_vendedor.AutoSize = True
        Me.lbl_vendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_vendedor.Location = New System.Drawing.Point(344, 92)
        Me.lbl_vendedor.Name = "lbl_vendedor"
        Me.lbl_vendedor.Size = New System.Drawing.Size(81, 17)
        Me.lbl_vendedor.TabIndex = 17
        Me.lbl_vendedor.Text = "lbl_vendedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(350, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Vendedor:"
        '
        'lbl_bod
        '
        Me.lbl_bod.AutoSize = True
        Me.lbl_bod.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_bod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_bod.Location = New System.Drawing.Point(679, 92)
        Me.lbl_bod.Name = "lbl_bod"
        Me.lbl_bod.Size = New System.Drawing.Size(47, 17)
        Me.lbl_bod.TabIndex = 15
        Me.lbl_bod.Text = "lbl_noc"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(662, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bodega:"
        '
        'lbl_mto_boe
        '
        Me.lbl_mto_boe.AutoSize = True
        Me.lbl_mto_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_mto_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mto_boe.Location = New System.Drawing.Point(671, 49)
        Me.lbl_mto_boe.Name = "lbl_mto_boe"
        Me.lbl_mto_boe.Size = New System.Drawing.Size(78, 17)
        Me.lbl_mto_boe.TabIndex = 13
        Me.lbl_mto_boe.Text = "lbl_mto_boe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(671, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Monto Facturado:"
        '
        'lbl_fe_boe
        '
        Me.lbl_fe_boe.AutoSize = True
        Me.lbl_fe_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_fe_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_boe.Location = New System.Drawing.Point(497, 49)
        Me.lbl_fe_boe.Name = "lbl_fe_boe"
        Me.lbl_fe_boe.Size = New System.Drawing.Size(66, 17)
        Me.lbl_fe_boe.TabIndex = 11
        Me.lbl_fe_boe.Text = "lbl_fe_boe"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(491, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha Boleta"
        '
        'lbl_nro_boe
        '
        Me.lbl_nro_boe.AutoSize = True
        Me.lbl_nro_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nro_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nro_boe.Location = New System.Drawing.Point(332, 49)
        Me.lbl_nro_boe.Name = "lbl_nro_boe"
        Me.lbl_nro_boe.Size = New System.Drawing.Size(74, 17)
        Me.lbl_nro_boe.TabIndex = 9
        Me.lbl_nro_boe.Text = "lbl_nro_boe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(329, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Nro. Boleta"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nombre.Location = New System.Drawing.Point(37, 92)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(72, 17)
        Me.lbl_nombre.TabIndex = 5
        Me.lbl_nombre.Text = "lbl_nombre"
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_rut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_rut.Location = New System.Drawing.Point(49, 49)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(45, 17)
        Me.lbl_rut.TabIndex = 4
        Me.lbl_rut.Text = "lbl_rut"
        '
        'lbl_fe_actual
        '
        Me.lbl_fe_actual.AutoSize = True
        Me.lbl_fe_actual.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_fe_actual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_actual.Location = New System.Drawing.Point(945, 74)
        Me.lbl_fe_actual.Name = "lbl_fe_actual"
        Me.lbl_fe_actual.Size = New System.Drawing.Size(77, 17)
        Me.lbl_fe_actual.TabIndex = 3
        Me.lbl_fe_actual.Text = "lbl_fe_actual"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(942, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(26, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre del Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(46, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut Cliente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_reg)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lbl_hora)
        Me.GroupBox2.Controls.Add(Me.ch_stop_timer)
        Me.GroupBox2.Controls.Add(Me.cmd_limpíar)
        Me.GroupBox2.Controls.Add(Me.txt_bus_boe)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.ch_anio_ant)
        Me.GroupBox2.Controls.Add(Me.Tab1)
        Me.GroupBox2.Controls.Add(Me.cmd_modificar)
        Me.GroupBox2.Controls.Add(Me.cmd_guardar)
        Me.GroupBox2.Controls.Add(Me.txt_obs_boe)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cbo_ampm)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.msk_fe_desp)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.cbo_acomodador)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lbl_patente)
        Me.GroupBox2.Controls.Add(Me.cbo_medio_tp)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.cbo_chofer)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.cbo_ciudad)
        Me.GroupBox2.Controls.Add(Me.txt_peso)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txt_nrobulto)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txt_cedible)
        Me.GroupBox2.Controls.Add(Me.txt_nroflete)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cbo_tp)
        Me.GroupBox2.Controls.Add(Me.cmd_modifica2)
        Me.GroupBox2.Controls.Add(Me.txt_bus_boe_desp)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1057, 505)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DATOS DEL DESPACHO"
        '
        'lbl_reg
        '
        Me.lbl_reg.AutoSize = True
        Me.lbl_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_reg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_reg.Location = New System.Drawing.Point(34, 464)
        Me.lbl_reg.Name = "lbl_reg"
        Me.lbl_reg.Size = New System.Drawing.Size(44, 15)
        Me.lbl_reg.TabIndex = 58
        Me.lbl_reg.Text = "lbl_reg"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 449)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 15)
        Me.Label25.TabIndex = 57
        Me.Label25.Text = "Nro. Reg:"
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Location = New System.Drawing.Point(904, 124)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(51, 15)
        Me.lbl_hora.TabIndex = 56
        Me.lbl_hora.Text = "lbl_hora"
        '
        'ch_stop_timer
        '
        Me.ch_stop_timer.AutoSize = True
        Me.ch_stop_timer.Location = New System.Drawing.Point(943, 101)
        Me.ch_stop_timer.Name = "ch_stop_timer"
        Me.ch_stop_timer.Size = New System.Drawing.Size(114, 19)
        Me.ch_stop_timer.TabIndex = 55
        Me.ch_stop_timer.Text = "Detiene Tiempo"
        Me.ch_stop_timer.UseVisualStyleBackColor = True
        '
        'cmd_limpíar
        '
        Me.cmd_limpíar.Image = Global.Despachos.My.Resources.Resources.undo
        Me.cmd_limpíar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpíar.Location = New System.Drawing.Point(798, 99)
        Me.cmd_limpíar.Name = "cmd_limpíar"
        Me.cmd_limpíar.Size = New System.Drawing.Size(100, 40)
        Me.cmd_limpíar.TabIndex = 54
        Me.cmd_limpíar.Text = "Limpiar Campos"
        Me.cmd_limpíar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpíar.UseVisualStyleBackColor = True
        '
        'txt_bus_boe
        '
        Me.txt_bus_boe.Location = New System.Drawing.Point(114, 467)
        Me.txt_bus_boe.Name = "txt_bus_boe"
        Me.txt_bus_boe.Size = New System.Drawing.Size(88, 23)
        Me.txt_bus_boe.TabIndex = 51
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(112, 449)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 15)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "Buscar Nro Boleta:"
        '
        'ch_anio_ant
        '
        Me.ch_anio_ant.AutoSize = True
        Me.ch_anio_ant.Location = New System.Drawing.Point(943, 85)
        Me.ch_anio_ant.Name = "ch_anio_ant"
        Me.ch_anio_ant.Size = New System.Drawing.Size(98, 19)
        Me.ch_anio_ant.TabIndex = 49
        Me.ch_anio_ant.Text = "Año Anterior"
        Me.ch_anio_ant.UseVisualStyleBackColor = True
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TP1)
        Me.Tab1.Controls.Add(Me.TP2)
        Me.Tab1.Location = New System.Drawing.Point(20, 142)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(1031, 295)
        Me.Tab1.TabIndex = 48
        '
        'TP1
        '
        Me.TP1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TP1.Controls.Add(Me.grilla)
        Me.TP1.Location = New System.Drawing.Point(4, 24)
        Me.TP1.Name = "TP1"
        Me.TP1.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1.Size = New System.Drawing.Size(1023, 267)
        Me.TP1.TabIndex = 0
        Me.TP1.Text = "Boletas Actuales"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla.DefaultCellStyle = DataGridViewCellStyle3
        Me.grilla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.grilla.Location = New System.Drawing.Point(5, 6)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(1012, 254)
        Me.grilla.TabIndex = 0
        '
        'TP2
        '
        Me.TP2.Controls.Add(Me.grilla2)
        Me.TP2.Location = New System.Drawing.Point(4, 24)
        Me.TP2.Name = "TP2"
        Me.TP2.Padding = New System.Windows.Forms.Padding(3)
        Me.TP2.Size = New System.Drawing.Size(1023, 267)
        Me.TP2.TabIndex = 1
        Me.TP2.Text = "Despachos Registrados"
        Me.TP2.UseVisualStyleBackColor = True
        '
        'grilla2
        '
        Me.grilla2.AllowUserToAddRows = False
        Me.grilla2.AllowUserToDeleteRows = False
        Me.grilla2.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grilla2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla2.Location = New System.Drawing.Point(5, 6)
        Me.grilla2.Name = "grilla2"
        Me.grilla2.ReadOnly = True
        Me.grilla2.Size = New System.Drawing.Size(1012, 324)
        Me.grilla2.TabIndex = 1
        '
        'cmd_modificar
        '
        Me.cmd_modificar.Image = Global.Despachos.My.Resources.Resources.refresh
        Me.cmd_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_modificar.Location = New System.Drawing.Point(692, 99)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(100, 40)
        Me.cmd_modificar.TabIndex = 47
        Me.cmd_modificar.Text = "Modificar Despacho"
        Me.cmd_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_modificar.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Image = Global.Despachos.My.Resources.Resources.save
        Me.cmd_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar.Location = New System.Drawing.Point(585, 99)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(101, 40)
        Me.cmd_guardar.TabIndex = 46
        Me.cmd_guardar.Text = "Registrar Despacho"
        Me.cmd_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'txt_obs_boe
        '
        Me.txt_obs_boe.Location = New System.Drawing.Point(226, 103)
        Me.txt_obs_boe.Name = "txt_obs_boe"
        Me.txt_obs_boe.Size = New System.Drawing.Size(312, 23)
        Me.txt_obs_boe.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Location = New System.Drawing.Point(223, 83)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(160, 17)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "Observaciones de Despacho"
        '
        'cbo_ampm
        '
        Me.cbo_ampm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_ampm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_ampm.FormattingEnabled = True
        Me.cbo_ampm.Location = New System.Drawing.Point(143, 103)
        Me.cbo_ampm.Name = "cbo_ampm"
        Me.cbo_ampm.Size = New System.Drawing.Size(59, 23)
        Me.cbo_ampm.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Location = New System.Drawing.Point(139, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 17)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "Despacho:"
        '
        'msk_fe_desp
        '
        Me.msk_fe_desp.Location = New System.Drawing.Point(29, 101)
        Me.msk_fe_desp.Mask = "0000-00-00"
        Me.msk_fe_desp.Name = "msk_fe_desp"
        Me.msk_fe_desp.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_desp.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.Location = New System.Drawing.Point(29, 83)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 17)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Fe. Despacho"
        '
        'cbo_acomodador
        '
        Me.cbo_acomodador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_acomodador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_acomodador.FormattingEnabled = True
        Me.cbo_acomodador.Location = New System.Drawing.Point(886, 57)
        Me.cbo_acomodador.Name = "cbo_acomodador"
        Me.cbo_acomodador.Size = New System.Drawing.Size(156, 23)
        Me.cbo_acomodador.TabIndex = 9
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Location = New System.Drawing.Point(907, 37)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(83, 17)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Acomodador:"
        '
        'lbl_patente
        '
        Me.lbl_patente.AutoSize = True
        Me.lbl_patente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_patente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_patente.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patente.Location = New System.Drawing.Point(814, 37)
        Me.lbl_patente.Name = "lbl_patente"
        Me.lbl_patente.Size = New System.Drawing.Size(64, 15)
        Me.lbl_patente.TabIndex = 37
        Me.lbl_patente.Text = "lbl_patente"
        '
        'cbo_medio_tp
        '
        Me.cbo_medio_tp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_medio_tp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_medio_tp.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_medio_tp.FormattingEnabled = True
        Me.cbo_medio_tp.Location = New System.Drawing.Point(731, 57)
        Me.cbo_medio_tp.Name = "cbo_medio_tp"
        Me.cbo_medio_tp.Size = New System.Drawing.Size(149, 21)
        Me.cbo_medio_tp.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.Location = New System.Drawing.Point(710, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 17)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Móvil: (Patente)"
        '
        'cbo_chofer
        '
        Me.cbo_chofer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_chofer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_chofer.FormattingEnabled = True
        Me.cbo_chofer.Location = New System.Drawing.Point(597, 55)
        Me.cbo_chofer.Name = "cbo_chofer"
        Me.cbo_chofer.Size = New System.Drawing.Size(129, 23)
        Me.cbo_chofer.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Location = New System.Drawing.Point(621, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(50, 17)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Chofer:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Location = New System.Drawing.Point(450, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 17)
        Me.Label16.TabIndex = 32
        Me.Label16.Text = "Ciudad"
        '
        'cbo_ciudad
        '
        Me.cbo_ciudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_ciudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_ciudad.FormattingEnabled = True
        Me.cbo_ciudad.Location = New System.Drawing.Point(413, 56)
        Me.cbo_ciudad.Name = "cbo_ciudad"
        Me.cbo_ciudad.Size = New System.Drawing.Size(178, 23)
        Me.cbo_ciudad.TabIndex = 6
        '
        'txt_peso
        '
        Me.txt_peso.Location = New System.Drawing.Point(351, 58)
        Me.txt_peso.Name = "txt_peso"
        Me.txt_peso.Size = New System.Drawing.Size(56, 23)
        Me.txt_peso.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Location = New System.Drawing.Point(351, 37)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 17)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Peso (grs)"
        '
        'txt_nrobulto
        '
        Me.txt_nrobulto.Location = New System.Drawing.Point(290, 58)
        Me.txt_nrobulto.Name = "txt_nrobulto"
        Me.txt_nrobulto.Size = New System.Drawing.Size(40, 23)
        Me.txt_nrobulto.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Location = New System.Drawing.Point(278, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 17)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Nro Bultos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(166, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Nro. Cedible"
        '
        'txt_cedible
        '
        Me.txt_cedible.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_cedible.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cedible.Location = New System.Drawing.Point(237, 13)
        Me.txt_cedible.Name = "txt_cedible"
        Me.txt_cedible.Size = New System.Drawing.Size(120, 21)
        Me.txt_cedible.TabIndex = 3
        '
        'txt_nroflete
        '
        Me.txt_nroflete.Location = New System.Drawing.Point(161, 56)
        Me.txt_nroflete.Name = "txt_nroflete"
        Me.txt_nroflete.Size = New System.Drawing.Size(112, 23)
        Me.txt_nroflete.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Location = New System.Drawing.Point(185, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Nro Flete"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(19, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Medio de Transporte"
        '
        'cbo_tp
        '
        Me.cbo_tp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_tp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_tp.FormattingEnabled = True
        Me.cbo_tp.Location = New System.Drawing.Point(6, 56)
        Me.cbo_tp.Name = "cbo_tp"
        Me.cbo_tp.Size = New System.Drawing.Size(149, 23)
        Me.cbo_tp.TabIndex = 1
        '
        'cmd_modifica2
        '
        Me.cmd_modifica2.Image = Global.Despachos.My.Resources.Resources.refresh
        Me.cmd_modifica2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_modifica2.Location = New System.Drawing.Point(692, 99)
        Me.cmd_modifica2.Name = "cmd_modifica2"
        Me.cmd_modifica2.Size = New System.Drawing.Size(100, 40)
        Me.cmd_modifica2.TabIndex = 60
        Me.cmd_modifica2.Text = "Guardar Cambios"
        Me.cmd_modifica2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_modifica2.UseVisualStyleBackColor = True
        '
        'txt_bus_boe_desp
        '
        Me.txt_bus_boe_desp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_bus_boe_desp.Location = New System.Drawing.Point(114, 467)
        Me.txt_bus_boe_desp.Name = "txt_bus_boe_desp"
        Me.txt_bus_boe_desp.Size = New System.Drawing.Size(88, 23)
        Me.txt_bus_boe_desp.TabIndex = 59
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarDespachoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1114, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BuscarDespachoToolStripMenuItem
        '
        Me.BuscarDespachoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_IngreseNroBoleta})
        Me.BuscarDespachoToolStripMenuItem.Name = "BuscarDespachoToolStripMenuItem"
        Me.BuscarDespachoToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.BuscarDespachoToolStripMenuItem.Text = "Buscar Despacho"
        '
        'mnu_IngreseNroBoleta
        '
        Me.mnu_IngreseNroBoleta.Name = "mnu_IngreseNroBoleta"
        Me.mnu_IngreseNroBoleta.Size = New System.Drawing.Size(171, 22)
        Me.mnu_IngreseNroBoleta.Text = "Ingrese Nro Boleta"
        '
        'Timer2
        '
        '
        'frm_ing_bol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1114, 691)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frm_ing_bol"
        Me.Text = "frm_ing_bol"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Tab1.ResumeLayout(False)
        Me.TP1.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP2.ResumeLayout(False)
        CType(Me.grilla2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbl_codejec As Label
    Friend WithEvents lbl_idbd As Label
    Friend WithEvents lbl_nrodp As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_vendedor As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_bod As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_mto_boe As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_fe_boe As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_nro_boe As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_rut As Label
    Friend WithEvents lbl_fe_actual As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_bus_boe_desp As TextBox
    Friend WithEvents lbl_reg As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_hora As Label
    Friend WithEvents ch_stop_timer As CheckBox
    Friend WithEvents cmd_limpíar As Button
    Friend WithEvents txt_bus_boe As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents ch_anio_ant As CheckBox
    Friend WithEvents Tab1 As TabControl
    Friend WithEvents TP1 As TabPage
    Friend WithEvents grilla As DataGridView
    Friend WithEvents TP2 As TabPage
    Friend WithEvents grilla2 As DataGridView
    Friend WithEvents cmd_modificar As Button
    Friend WithEvents cmd_guardar As Button
    Friend WithEvents txt_obs_boe As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbo_ampm As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents msk_fe_desp As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cbo_acomodador As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_patente As Label
    Friend WithEvents cbo_medio_tp As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cbo_chofer As ComboBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cbo_ciudad As ComboBox
    Friend WithEvents txt_peso As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_nrobulto As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_cedible As TextBox
    Friend WithEvents txt_nroflete As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_tp As ComboBox
    Friend WithEvents cmd_modifica2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BuscarDespachoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_IngreseNroBoleta As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
End Class
