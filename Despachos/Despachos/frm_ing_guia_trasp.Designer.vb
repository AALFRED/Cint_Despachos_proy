<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ing_guia_trasp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ing_guia_trasp))
        Me.lbl_usuario_gt = New System.Windows.Forms.Label()
        Me.cbo_bod_destino_gt = New System.Windows.Forms.ComboBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.cbo_bod_origen_gt = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txt_obs_ing_gt = New System.Windows.Forms.TextBox()
        Me.txt_guia_gt = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.lbl_bod_destino = New System.Windows.Forms.Label()
        Me.lbl_bod_origen = New System.Windows.Forms.Label()
        Me.lbl_sol_tras = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.txt_nrobultos_gt = New System.Windows.Forms.TextBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.txt_peso_gt = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.cbo_chofer_gt = New System.Windows.Forms.ComboBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.lbl_patente_gt = New System.Windows.Forms.Label()
        Me.cbo_transp_gt = New System.Windows.Forms.ComboBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.msk_fe_desp_gt = New System.Windows.Forms.MaskedTextBox()
        Me.txt_direccion_gt = New System.Windows.Forms.TextBox()
        Me.cbo_rut_emp_gt = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.ch_anio_ant = New System.Windows.Forms.CheckBox()
        Me.cmd_buscar_gt = New System.Windows.Forms.Button()
        Me.cmd_cancelar_gt = New System.Windows.Forms.Button()
        Me.cmd_Limpiar_gt = New System.Windows.Forms.Button()
        Me.cmd_modif_gt = New System.Windows.Forms.Button()
        Me.lbl_empresa_gt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nrodp_gt = New System.Windows.Forms.Label()
        Me.lbl_idbd_gt = New System.Windows.Forms.Label()
        Me.cmd_guardar_datos_gt = New System.Windows.Forms.Button()
        Me.cmd_guardar_gt = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_ciu_trasp = New System.Windows.Forms.Label()
        Me.lbl_fe_trasp = New System.Windows.Forms.Label()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_usuario_gt
        '
        Me.lbl_usuario_gt.AutoSize = True
        Me.lbl_usuario_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_usuario_gt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_usuario_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_gt.Location = New System.Drawing.Point(542, 486)
        Me.lbl_usuario_gt.Name = "lbl_usuario_gt"
        Me.lbl_usuario_gt.Size = New System.Drawing.Size(85, 17)
        Me.lbl_usuario_gt.TabIndex = 126
        Me.lbl_usuario_gt.Text = "lbl_usuario_gt"
        '
        'cbo_bod_destino_gt
        '
        Me.cbo_bod_destino_gt.FormattingEnabled = True
        Me.cbo_bod_destino_gt.Location = New System.Drawing.Point(484, 47)
        Me.cbo_bod_destino_gt.Name = "cbo_bod_destino_gt"
        Me.cbo_bod_destino_gt.Size = New System.Drawing.Size(230, 23)
        Me.cbo_bod_destino_gt.TabIndex = 3
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(527, 29)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(103, 15)
        Me.Label80.TabIndex = 2
        Me.Label80.Text = "BODEGA DESTINO"
        '
        'cbo_bod_origen_gt
        '
        Me.cbo_bod_origen_gt.FormattingEnabled = True
        Me.cbo_bod_origen_gt.Location = New System.Drawing.Point(90, 47)
        Me.cbo_bod_origen_gt.Name = "cbo_bod_origen_gt"
        Me.cbo_bod_origen_gt.Size = New System.Drawing.Size(203, 23)
        Me.cbo_bod_origen_gt.TabIndex = 1
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(114, 29)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(98, 15)
        Me.Label77.TabIndex = 0
        Me.Label77.Text = "BODEGA ORIGEN"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.BackColor = System.Drawing.Color.Silver
        Me.Label87.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.DarkRed
        Me.Label87.Location = New System.Drawing.Point(527, 455)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(141, 18)
        Me.Label87.TabIndex = 125
        Me.Label87.Text = "Usuario que Registra:"
        '
        'txt_obs_ing_gt
        '
        Me.txt_obs_ing_gt.Location = New System.Drawing.Point(66, 483)
        Me.txt_obs_ing_gt.Name = "txt_obs_ing_gt"
        Me.txt_obs_ing_gt.Size = New System.Drawing.Size(360, 23)
        Me.txt_obs_ing_gt.TabIndex = 124
        '
        'txt_guia_gt
        '
        Me.txt_guia_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_guia_gt.Location = New System.Drawing.Point(416, 77)
        Me.txt_guia_gt.Name = "txt_guia_gt"
        Me.txt_guia_gt.Size = New System.Drawing.Size(115, 23)
        Me.txt_guia_gt.TabIndex = 1
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label49.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(395, 57)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(127, 15)
        Me.Label49.TabIndex = 122
        Me.Label49.Text = "INGRESE NRO DE GUIA"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.lbl_bod_destino)
        Me.GroupBox8.Controls.Add(Me.lbl_bod_origen)
        Me.GroupBox8.Controls.Add(Me.lbl_sol_tras)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.cbo_bod_destino_gt)
        Me.GroupBox8.Controls.Add(Me.Label80)
        Me.GroupBox8.Controls.Add(Me.cbo_bod_origen_gt)
        Me.GroupBox8.Controls.Add(Me.Label77)
        Me.GroupBox8.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(199, 214)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(774, 117)
        Me.GroupBox8.TabIndex = 121
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TRASPASOS ENTRE:"
        '
        'lbl_bod_destino
        '
        Me.lbl_bod_destino.AutoSize = True
        Me.lbl_bod_destino.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_bod_destino.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_bod_destino.Location = New System.Drawing.Point(636, 29)
        Me.lbl_bod_destino.Name = "lbl_bod_destino"
        Me.lbl_bod_destino.Size = New System.Drawing.Size(95, 17)
        Me.lbl_bod_destino.TabIndex = 7
        Me.lbl_bod_destino.Text = "lbl_bod_destino"
        '
        'lbl_bod_origen
        '
        Me.lbl_bod_origen.AutoSize = True
        Me.lbl_bod_origen.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_bod_origen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_bod_origen.Location = New System.Drawing.Point(218, 29)
        Me.lbl_bod_origen.Name = "lbl_bod_origen"
        Me.lbl_bod_origen.Size = New System.Drawing.Size(90, 17)
        Me.lbl_bod_origen.TabIndex = 6
        Me.lbl_bod_origen.Text = "lbl_bod_origen"
        '
        'lbl_sol_tras
        '
        Me.lbl_sol_tras.AutoSize = True
        Me.lbl_sol_tras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_sol_tras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_sol_tras.Location = New System.Drawing.Point(80, 82)
        Me.lbl_sol_tras.Name = "lbl_sol_tras"
        Me.lbl_sol_tras.Size = New System.Drawing.Size(71, 17)
        Me.lbl_sol_tras.TabIndex = 5
        Me.lbl_sol_tras.Text = "lbl_sol_tras"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Solicita:"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Silver
        Me.Label76.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.DarkRed
        Me.Label76.Location = New System.Drawing.Point(89, 455)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(156, 18)
        Me.Label76.TabIndex = 120
        Me.Label76.Text = "Observación de Ingreso:"
        '
        'txt_nrobultos_gt
        '
        Me.txt_nrobultos_gt.Location = New System.Drawing.Point(907, 395)
        Me.txt_nrobultos_gt.Name = "txt_nrobultos_gt"
        Me.txt_nrobultos_gt.Size = New System.Drawing.Size(82, 23)
        Me.txt_nrobultos_gt.TabIndex = 119
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Silver
        Me.Label75.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.DarkRed
        Me.Label75.Location = New System.Drawing.Point(904, 362)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(77, 18)
        Me.Label75.TabIndex = 118
        Me.Label75.Text = "Nro Bultos:"
        '
        'txt_peso_gt
        '
        Me.txt_peso_gt.Location = New System.Drawing.Point(742, 395)
        Me.txt_peso_gt.Name = "txt_peso_gt"
        Me.txt_peso_gt.Size = New System.Drawing.Size(82, 23)
        Me.txt_peso_gt.TabIndex = 117
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Silver
        Me.Label74.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.DarkRed
        Me.Label74.Location = New System.Drawing.Point(738, 362)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(79, 18)
        Me.Label74.TabIndex = 116
        Me.Label74.Text = "Peso (GRS):"
        '
        'cbo_chofer_gt
        '
        Me.cbo_chofer_gt.FormattingEnabled = True
        Me.cbo_chofer_gt.Location = New System.Drawing.Point(520, 394)
        Me.cbo_chofer_gt.Name = "cbo_chofer_gt"
        Me.cbo_chofer_gt.Size = New System.Drawing.Size(183, 23)
        Me.cbo_chofer_gt.TabIndex = 115
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Silver
        Me.Label73.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.DarkRed
        Me.Label73.Location = New System.Drawing.Point(563, 362)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(53, 18)
        Me.Label73.TabIndex = 114
        Me.Label73.Text = "Chofer:"
        '
        'lbl_patente_gt
        '
        Me.lbl_patente_gt.AutoSize = True
        Me.lbl_patente_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_patente_gt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_patente_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patente_gt.Location = New System.Drawing.Point(316, 362)
        Me.lbl_patente_gt.Name = "lbl_patente_gt"
        Me.lbl_patente_gt.Size = New System.Drawing.Size(89, 17)
        Me.lbl_patente_gt.TabIndex = 113
        Me.lbl_patente_gt.Text = "lbl_patente_gt"
        '
        'cbo_transp_gt
        '
        Me.cbo_transp_gt.FormattingEnabled = True
        Me.cbo_transp_gt.Location = New System.Drawing.Point(216, 393)
        Me.cbo_transp_gt.Name = "cbo_transp_gt"
        Me.cbo_transp_gt.Size = New System.Drawing.Size(276, 23)
        Me.cbo_transp_gt.TabIndex = 112
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Silver
        Me.Label72.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.DarkRed
        Me.Label72.Location = New System.Drawing.Point(240, 362)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(78, 18)
        Me.Label72.TabIndex = 111
        Me.Label72.Text = "Transporte:"
        '
        'msk_fe_desp_gt
        '
        Me.msk_fe_desp_gt.Location = New System.Drawing.Point(92, 394)
        Me.msk_fe_desp_gt.Mask = "0000-00-00"
        Me.msk_fe_desp_gt.Name = "msk_fe_desp_gt"
        Me.msk_fe_desp_gt.Size = New System.Drawing.Size(82, 23)
        Me.msk_fe_desp_gt.TabIndex = 110
        '
        'txt_direccion_gt
        '
        Me.txt_direccion_gt.Location = New System.Drawing.Point(520, 167)
        Me.txt_direccion_gt.Name = "txt_direccion_gt"
        Me.txt_direccion_gt.Size = New System.Drawing.Size(320, 23)
        Me.txt_direccion_gt.TabIndex = 108
        '
        'cbo_rut_emp_gt
        '
        Me.cbo_rut_emp_gt.FormattingEnabled = True
        Me.cbo_rut_emp_gt.Location = New System.Drawing.Point(24, 167)
        Me.cbo_rut_emp_gt.Name = "cbo_rut_emp_gt"
        Me.cbo_rut_emp_gt.Size = New System.Drawing.Size(121, 23)
        Me.cbo_rut_emp_gt.TabIndex = 106
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Silver
        Me.Label78.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.DarkRed
        Me.Label78.Location = New System.Drawing.Point(89, 362)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(111, 18)
        Me.Label78.TabIndex = 105
        Me.Label78.Text = "Fecha Despacho:"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Silver
        Me.Label79.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.DarkRed
        Me.Label79.Location = New System.Drawing.Point(795, 68)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(106, 18)
        Me.Label79.TabIndex = 104
        Me.Label79.Text = "Fecha Traspaso:"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Silver
        Me.Label81.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.DarkRed
        Me.Label81.Location = New System.Drawing.Point(609, 141)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(69, 18)
        Me.Label81.TabIndex = 103
        Me.Label81.Text = "Dirección:"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Silver
        Me.Label82.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.DarkRed
        Me.Label82.Location = New System.Drawing.Point(316, 139)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(65, 18)
        Me.Label82.TabIndex = 102
        Me.Label82.Text = "Empresa:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Silver
        Me.Label83.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.DarkRed
        Me.Label83.Location = New System.Drawing.Point(49, 141)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(79, 18)
        Me.Label83.TabIndex = 101
        Me.Label83.Text = "Rut Cliente:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label53.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Maroon
        Me.Label53.Location = New System.Drawing.Point(371, 25)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(183, 15)
        Me.Label53.TabIndex = 100
        Me.Label53.Text = "DATOS DE LA GUIA DE TRASPASO"
        '
        'ch_anio_ant
        '
        Me.ch_anio_ant.AutoSize = True
        Me.ch_anio_ant.BackColor = System.Drawing.Color.Silver
        Me.ch_anio_ant.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_anio_ant.ForeColor = System.Drawing.Color.Maroon
        Me.ch_anio_ant.Location = New System.Drawing.Point(552, 68)
        Me.ch_anio_ant.Name = "ch_anio_ant"
        Me.ch_anio_ant.Size = New System.Drawing.Size(98, 19)
        Me.ch_anio_ant.TabIndex = 99
        Me.ch_anio_ant.Text = "Año Anterior"
        Me.ch_anio_ant.UseVisualStyleBackColor = False
        '
        'cmd_buscar_gt
        '
        Me.cmd_buscar_gt.Image = Global.Despachos.My.Resources.Resources.search_minus
        Me.cmd_buscar_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_buscar_gt.Location = New System.Drawing.Point(342, 553)
        Me.cmd_buscar_gt.Name = "cmd_buscar_gt"
        Me.cmd_buscar_gt.Size = New System.Drawing.Size(122, 37)
        Me.cmd_buscar_gt.TabIndex = 131
        Me.cmd_buscar_gt.Text = "Buscar Guia"
        Me.cmd_buscar_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_buscar_gt.UseVisualStyleBackColor = True
        '
        'cmd_cancelar_gt
        '
        Me.cmd_cancelar_gt.Image = Global.Despachos.My.Resources.Resources.cancel
        Me.cmd_cancelar_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_cancelar_gt.Location = New System.Drawing.Point(783, 554)
        Me.cmd_cancelar_gt.Name = "cmd_cancelar_gt"
        Me.cmd_cancelar_gt.Size = New System.Drawing.Size(104, 36)
        Me.cmd_cancelar_gt.TabIndex = 130
        Me.cmd_cancelar_gt.Text = "Cancelar"
        Me.cmd_cancelar_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancelar_gt.UseVisualStyleBackColor = True
        '
        'cmd_Limpiar_gt
        '
        Me.cmd_Limpiar_gt.Image = Global.Despachos.My.Resources.Resources.undo
        Me.cmd_Limpiar_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Limpiar_gt.Location = New System.Drawing.Point(642, 554)
        Me.cmd_Limpiar_gt.Name = "cmd_Limpiar_gt"
        Me.cmd_Limpiar_gt.Size = New System.Drawing.Size(104, 36)
        Me.cmd_Limpiar_gt.TabIndex = 129
        Me.cmd_Limpiar_gt.Text = "Limpiar"
        Me.cmd_Limpiar_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Limpiar_gt.UseVisualStyleBackColor = True
        '
        'cmd_modif_gt
        '
        Me.cmd_modif_gt.Image = Global.Despachos.My.Resources.Resources.update
        Me.cmd_modif_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_modif_gt.Location = New System.Drawing.Point(491, 554)
        Me.cmd_modif_gt.Name = "cmd_modif_gt"
        Me.cmd_modif_gt.Size = New System.Drawing.Size(122, 36)
        Me.cmd_modif_gt.TabIndex = 128
        Me.cmd_modif_gt.Text = "Modificar"
        Me.cmd_modif_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_modif_gt.UseVisualStyleBackColor = True
        '
        'lbl_empresa_gt
        '
        Me.lbl_empresa_gt.AutoSize = True
        Me.lbl_empresa_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_empresa_gt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_empresa_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_empresa_gt.Location = New System.Drawing.Point(184, 167)
        Me.lbl_empresa_gt.Name = "lbl_empresa_gt"
        Me.lbl_empresa_gt.Size = New System.Drawing.Size(93, 17)
        Me.lbl_empresa_gt.TabIndex = 132
        Me.lbl_empresa_gt.Text = "lbl_empresa_gt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(127, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 15)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = " NRO CORRELATIVO INTERNO:"
        '
        'lbl_nrodp_gt
        '
        Me.lbl_nrodp_gt.AutoSize = True
        Me.lbl_nrodp_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nrodp_gt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrodp_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nrodp_gt.Location = New System.Drawing.Point(167, 80)
        Me.lbl_nrodp_gt.Name = "lbl_nrodp_gt"
        Me.lbl_nrodp_gt.Size = New System.Drawing.Size(78, 17)
        Me.lbl_nrodp_gt.TabIndex = 134
        Me.lbl_nrodp_gt.Text = "lbl_nrodp_gt"
        '
        'lbl_idbd_gt
        '
        Me.lbl_idbd_gt.AutoSize = True
        Me.lbl_idbd_gt.Location = New System.Drawing.Point(795, 515)
        Me.lbl_idbd_gt.Name = "lbl_idbd_gt"
        Me.lbl_idbd_gt.Size = New System.Drawing.Size(69, 15)
        Me.lbl_idbd_gt.TabIndex = 135
        Me.lbl_idbd_gt.Text = "lbl_idbd_gt"
        Me.lbl_idbd_gt.Visible = False
        '
        'cmd_guardar_datos_gt
        '
        Me.cmd_guardar_datos_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_guardar_datos_gt.Location = New System.Drawing.Point(491, 554)
        Me.cmd_guardar_datos_gt.Name = "cmd_guardar_datos_gt"
        Me.cmd_guardar_datos_gt.Size = New System.Drawing.Size(122, 36)
        Me.cmd_guardar_datos_gt.TabIndex = 136
        Me.cmd_guardar_datos_gt.Text = "Guardar Cambios"
        Me.cmd_guardar_datos_gt.UseVisualStyleBackColor = False
        '
        'cmd_guardar_gt
        '
        Me.cmd_guardar_gt.Image = Global.Despachos.My.Resources.Resources.save
        Me.cmd_guardar_gt.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cmd_guardar_gt.Location = New System.Drawing.Point(199, 554)
        Me.cmd_guardar_gt.Name = "cmd_guardar_gt"
        Me.cmd_guardar_gt.Size = New System.Drawing.Size(108, 37)
        Me.cmd_guardar_gt.TabIndex = 127
        Me.cmd_guardar_gt.Text = "Guardar"
        Me.cmd_guardar_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_guardar_gt.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(905, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Ciudad Trasp:"
        '
        'lbl_ciu_trasp
        '
        Me.lbl_ciu_trasp.AutoSize = True
        Me.lbl_ciu_trasp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_ciu_trasp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciu_trasp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ciu_trasp.Location = New System.Drawing.Point(907, 173)
        Me.lbl_ciu_trasp.Name = "lbl_ciu_trasp"
        Me.lbl_ciu_trasp.Size = New System.Drawing.Size(77, 17)
        Me.lbl_ciu_trasp.TabIndex = 140
        Me.lbl_ciu_trasp.Text = "lbl_ciu_trasp"
        '
        'lbl_fe_trasp
        '
        Me.lbl_fe_trasp.AutoSize = True
        Me.lbl_fe_trasp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_fe_trasp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_trasp.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fe_trasp.Location = New System.Drawing.Point(798, 93)
        Me.lbl_fe_trasp.Name = "lbl_fe_trasp"
        Me.lbl_fe_trasp.Size = New System.Drawing.Size(73, 17)
        Me.lbl_fe_trasp.TabIndex = 141
        Me.lbl_fe_trasp.Text = "lbl_fe_trasp"
        '
        'frm_ing_guia_trasp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1106, 685)
        Me.Controls.Add(Me.lbl_fe_trasp)
        Me.Controls.Add(Me.lbl_ciu_trasp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_idbd_gt)
        Me.Controls.Add(Me.lbl_nrodp_gt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_empresa_gt)
        Me.Controls.Add(Me.cmd_buscar_gt)
        Me.Controls.Add(Me.cmd_cancelar_gt)
        Me.Controls.Add(Me.cmd_Limpiar_gt)
        Me.Controls.Add(Me.cmd_modif_gt)
        Me.Controls.Add(Me.cmd_guardar_gt)
        Me.Controls.Add(Me.lbl_usuario_gt)
        Me.Controls.Add(Me.Label87)
        Me.Controls.Add(Me.txt_obs_ing_gt)
        Me.Controls.Add(Me.txt_guia_gt)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.Label76)
        Me.Controls.Add(Me.txt_nrobultos_gt)
        Me.Controls.Add(Me.Label75)
        Me.Controls.Add(Me.txt_peso_gt)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.cbo_chofer_gt)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.lbl_patente_gt)
        Me.Controls.Add(Me.cbo_transp_gt)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.msk_fe_desp_gt)
        Me.Controls.Add(Me.txt_direccion_gt)
        Me.Controls.Add(Me.cbo_rut_emp_gt)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.Label81)
        Me.Controls.Add(Me.Label82)
        Me.Controls.Add(Me.Label83)
        Me.Controls.Add(Me.Label53)
        Me.Controls.Add(Me.ch_anio_ant)
        Me.Controls.Add(Me.cmd_guardar_datos_gt)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_ing_guia_trasp"
        Me.Text = "frm_ing_guia_trasp"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_usuario_gt As Label
    Friend WithEvents cbo_bod_destino_gt As ComboBox
    Friend WithEvents Label80 As Label
    Friend WithEvents cbo_bod_origen_gt As ComboBox
    Friend WithEvents Label77 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents txt_obs_ing_gt As TextBox
    Friend WithEvents txt_guia_gt As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label76 As Label
    Friend WithEvents txt_nrobultos_gt As TextBox
    Friend WithEvents Label75 As Label
    Friend WithEvents txt_peso_gt As TextBox
    Friend WithEvents Label74 As Label
    Friend WithEvents cbo_chofer_gt As ComboBox
    Friend WithEvents Label73 As Label
    Friend WithEvents lbl_patente_gt As Label
    Friend WithEvents cbo_transp_gt As ComboBox
    Friend WithEvents Label72 As Label
    Friend WithEvents msk_fe_desp_gt As MaskedTextBox
    Friend WithEvents txt_direccion_gt As TextBox
    Friend WithEvents cbo_rut_emp_gt As ComboBox
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents ch_anio_ant As CheckBox
    Friend WithEvents cmd_buscar_gt As Button
    Friend WithEvents cmd_cancelar_gt As Button
    Friend WithEvents cmd_Limpiar_gt As Button
    Friend WithEvents cmd_modif_gt As Button
    Friend WithEvents cmd_guardar_gt As Button
    Friend WithEvents lbl_empresa_gt As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nrodp_gt As Label
    Friend WithEvents lbl_idbd_gt As Label
    Friend WithEvents cmd_guardar_datos_gt As Button
    Friend WithEvents lbl_sol_tras As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_bod_destino As Label
    Friend WithEvents lbl_bod_origen As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_ciu_trasp As Label
    Friend WithEvents lbl_fe_trasp As Label
End Class
