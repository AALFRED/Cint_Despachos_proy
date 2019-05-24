<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_reingresos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_reingresos))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_VolverAIngresosFact = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_VolverAIngresosGuias = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_guia_DeCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_guia_SinAsignacionFactura = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_guia_DeTraspaso = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_VolverAIngresosBol = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenúToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Tab1 = New System.Windows.Forms.TabControl()
        Me.TP1 = New System.Windows.Forms.TabPage()
        Me.lbl_dirclie = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbl_patente = New System.Windows.Forms.Label()
        Me.lbl_movil = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.lbl_obs = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lbl_ampm = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbl_peso = New System.Windows.Forms.Label()
        Me.lbl_fe_desp = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lbl_fe_reg = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lbl_cedible = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_acomodador = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbl_chofer = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_medio_tp = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lbl_nrobultos = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_nroflete = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_nrodp = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_actualizar = New System.Windows.Forms.Button()
        Me.lbl_idbd = New System.Windows.Forms.Label()
        Me.txt_reing_obs = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_recep_desp = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.msk_fe_recep_clte = New System.Windows.Forms.MaskedTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.msk_fe_reing = New System.Windows.Forms.MaskedTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.ch_anio_ant = New System.Windows.Forms.CheckBox()
        Me.lbl_ciudad = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_vendedor = New System.Windows.Forms.Label()
        Me.lbl_noc = New System.Windows.Forms.Label()
        Me.lbl_fe_fact = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_mto_fact = New System.Windows.Forms.Label()
        Me.lbl_rut = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_bus_fact = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TP2 = New System.Windows.Forms.TabPage()
        Me.lbl_usr_reing_boe = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmd_cancelar_boe = New System.Windows.Forms.Button()
        Me.cmd_modificar_boe = New System.Windows.Forms.Button()
        Me.cmd_limpiar_boe = New System.Windows.Forms.Button()
        Me.cmd_actualiza_boe = New System.Windows.Forms.Button()
        Me.lbl_idbd_boe = New System.Windows.Forms.Label()
        Me.txt_obs_reing_boe = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_recep_desp_boe = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.msk_fe_recep_clie_boe = New System.Windows.Forms.MaskedTextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.msk_fe_reing_boe = New System.Windows.Forms.MaskedTextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.lbl_mto_boe = New System.Windows.Forms.Label()
        Me.lbl_vend_boe = New System.Windows.Forms.Label()
        Me.lbl_fe_boe = New System.Windows.Forms.Label()
        Me.lbl_ciudad_boe = New System.Windows.Forms.Label()
        Me.lbl_clie_boe = New System.Windows.Forms.Label()
        Me.lbl_rut_boe = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_usr_ingreso_boe = New System.Windows.Forms.Label()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.lbl_patente_boe = New System.Windows.Forms.Label()
        Me.lbl_movil_boe = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lbl_obs_desp_boe = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.lbl_ampm_boe = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.lbl_peso_boe = New System.Windows.Forms.Label()
        Me.lbl_fe_desp_boe = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.lbl_fe_crea_boe = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.lbl_cedi_boe = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.lbl_despachador_boe = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.lbl_chofer_boe = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.lbl_mediotp_boe = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.lbl_nrobulto_boe = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.lbl_nro_flete_boe = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.lbl_nrodp_boe = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.ch_anio_ant_boe = New System.Windows.Forms.CheckBox()
        Me.txt_bus_boe = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TP3 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.lbl_idbd_gc = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_limpiar_gc = New System.Windows.Forms.Button()
        Me.cmd_actualiza_gc = New System.Windows.Forms.Button()
        Me.txt_reing_obs_gc = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.txt_recep_des_gc = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.msk_fe_recep_clte_gc = New System.Windows.Forms.MaskedTextBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.msk_fe_reing_gc = New System.Windows.Forms.MaskedTextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lbl_patente_gc = New System.Windows.Forms.Label()
        Me.lbl_movil_gc = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.lbl_fe_reg_gc = New System.Windows.Forms.Label()
        Me.lbl_obs_desp_gc = New System.Windows.Forms.Label()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.lbl_despach_gc = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.lbl_chofer_gc = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.lbl_ciudad_gc = New System.Windows.Forms.Label()
        Me.lbl_transporte_gc = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.lbl_peso_gc = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.lbl_ncedible_gc = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.lbl_nbulto_gc = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.lbl_nro_flete_gc = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.lbl_nguia_gc = New System.Windows.Forms.Label()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.lbl_fe_desp_gc = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.lbl_nrodp_gc = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.lbl_salida_gc = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbl_destino_guia_gc = New System.Windows.Forms.Label()
        Me.Label109 = New System.Windows.Forms.Label()
        Me.lbl_tipo_guia_gc = New System.Windows.Forms.Label()
        Me.Label108 = New System.Windows.Forms.Label()
        Me.lbl_direc_gc = New System.Windows.Forms.Label()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.lbl_noc_gc = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.lbl_fe_docto_gc = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.lbl_nrofact_gc = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.lbl_monto_gc = New System.Windows.Forms.Label()
        Me.lbl_vend_gc = New System.Windows.Forms.Label()
        Me.lbl_nombre_gc = New System.Windows.Forms.Label()
        Me.lbl_rut_gc = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_guia_reing_gc = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TP4 = New System.Windows.Forms.TabPage()
        Me.lbl_usr_reing_gt = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.lbl_nrodp_gt = New System.Windows.Forms.Label()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.lbl_nrodpid = New System.Windows.Forms.Label()
        Me.txt_obs_reing_gt = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.cbo_recep_gt = New System.Windows.Forms.ComboBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.msk_fe_recep_gt = New System.Windows.Forms.MaskedTextBox()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.cmd_cancelar_gt = New System.Windows.Forms.Button()
        Me.cmd_Limpiar_gt = New System.Windows.Forms.Button()
        Me.cmd_modif_gt = New System.Windows.Forms.Button()
        Me.cmd_actualizar_gt = New System.Windows.Forms.Button()
        Me.lbl_usuario_gt = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.txt_obs_ingreso = New System.Windows.Forms.TextBox()
        Me.txt_guia_gt = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.cbo_bod_destino_gt = New System.Windows.Forms.ComboBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.cbo_bod_origen_gt = New System.Windows.Forms.ComboBox()
        Me.Label77 = New System.Windows.Forms.Label()
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
        Me.msk_fe_gt = New System.Windows.Forms.MaskedTextBox()
        Me.txt_direccion_gt = New System.Windows.Forms.TextBox()
        Me.cbo_empresa_gt = New System.Windows.Forms.ComboBox()
        Me.cbo_rut_emp_gt = New System.Windows.Forms.ComboBox()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.Tab1.SuspendLayout()
        Me.TP1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TP2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TP3.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TP4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresosToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1114, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresosToolStripMenuItem
        '
        Me.IngresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_VolverAIngresosFact, Me.ToolStripMenuItem1, Me.mnu_VolverAIngresosGuias, Me.ToolStripMenuItem2, Me.mnu_VolverAIngresosBol})
        Me.IngresosToolStripMenuItem.Name = "IngresosToolStripMenuItem"
        Me.IngresosToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.IngresosToolStripMenuItem.Text = "Volver a Ingresos"
        '
        'mnu_VolverAIngresosFact
        '
        Me.mnu_VolverAIngresosFact.Name = "mnu_VolverAIngresosFact"
        Me.mnu_VolverAIngresosFact.Size = New System.Drawing.Size(143, 22)
        Me.mnu_VolverAIngresosFact.Text = ".. de Facturas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(140, 6)
        '
        'mnu_VolverAIngresosGuias
        '
        Me.mnu_VolverAIngresosGuias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_guia_DeCliente, Me.mnu_guia_SinAsignacionFactura, Me.mnu_guia_DeTraspaso})
        Me.mnu_VolverAIngresosGuias.Name = "mnu_VolverAIngresosGuias"
        Me.mnu_VolverAIngresosGuias.Size = New System.Drawing.Size(143, 22)
        Me.mnu_VolverAIngresosGuias.Text = ".. de Guias"
        '
        'mnu_guia_DeCliente
        '
        Me.mnu_guia_DeCliente.Name = "mnu_guia_DeCliente"
        Me.mnu_guia_DeCliente.Size = New System.Drawing.Size(194, 22)
        Me.mnu_guia_DeCliente.Text = "de Cliente"
        '
        'mnu_guia_SinAsignacionFactura
        '
        Me.mnu_guia_SinAsignacionFactura.Name = "mnu_guia_SinAsignacionFactura"
        Me.mnu_guia_SinAsignacionFactura.Size = New System.Drawing.Size(194, 22)
        Me.mnu_guia_SinAsignacionFactura.Text = "Sin Asignacion Factura"
        '
        'mnu_guia_DeTraspaso
        '
        Me.mnu_guia_DeTraspaso.Name = "mnu_guia_DeTraspaso"
        Me.mnu_guia_DeTraspaso.Size = New System.Drawing.Size(194, 22)
        Me.mnu_guia_DeTraspaso.Text = "de Traspaso"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(140, 6)
        '
        'mnu_VolverAIngresosBol
        '
        Me.mnu_VolverAIngresosBol.Name = "mnu_VolverAIngresosBol"
        Me.mnu_VolverAIngresosBol.Size = New System.Drawing.Size(143, 22)
        Me.mnu_VolverAIngresosBol.Text = ".. de Boletas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverAlMenúToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VolverAlMenúToolStripMenuItem
        '
        Me.VolverAlMenúToolStripMenuItem.Name = "VolverAlMenúToolStripMenuItem"
        Me.VolverAlMenúToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.VolverAlMenúToolStripMenuItem.Text = "Volver al Menú.."
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.TP1)
        Me.Tab1.Controls.Add(Me.TP2)
        Me.Tab1.Controls.Add(Me.TP3)
        Me.Tab1.Controls.Add(Me.TP4)
        Me.Tab1.Location = New System.Drawing.Point(27, 41)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.SelectedIndex = 0
        Me.Tab1.Size = New System.Drawing.Size(1075, 635)
        Me.Tab1.TabIndex = 2
        '
        'TP1
        '
        Me.TP1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP1.Controls.Add(Me.lbl_dirclie)
        Me.TP1.Controls.Add(Me.Label9)
        Me.TP1.Controls.Add(Me.GroupBox2)
        Me.TP1.Controls.Add(Me.Label13)
        Me.TP1.Controls.Add(Me.GroupBox1)
        Me.TP1.Controls.Add(Me.txt_reing_obs)
        Me.TP1.Controls.Add(Me.Label29)
        Me.TP1.Controls.Add(Me.txt_recep_desp)
        Me.TP1.Controls.Add(Me.Label28)
        Me.TP1.Controls.Add(Me.msk_fe_recep_clte)
        Me.TP1.Controls.Add(Me.Label27)
        Me.TP1.Controls.Add(Me.msk_fe_reing)
        Me.TP1.Controls.Add(Me.Label26)
        Me.TP1.Controls.Add(Me.Label25)
        Me.TP1.Controls.Add(Me.ch_anio_ant)
        Me.TP1.Controls.Add(Me.lbl_ciudad)
        Me.TP1.Controls.Add(Me.Label15)
        Me.TP1.Controls.Add(Me.lbl_vendedor)
        Me.TP1.Controls.Add(Me.lbl_noc)
        Me.TP1.Controls.Add(Me.lbl_fe_fact)
        Me.TP1.Controls.Add(Me.lbl_cliente)
        Me.TP1.Controls.Add(Me.Label8)
        Me.TP1.Controls.Add(Me.lbl_mto_fact)
        Me.TP1.Controls.Add(Me.lbl_rut)
        Me.TP1.Controls.Add(Me.Label7)
        Me.TP1.Controls.Add(Me.Label6)
        Me.TP1.Controls.Add(Me.Label5)
        Me.TP1.Controls.Add(Me.Label4)
        Me.TP1.Controls.Add(Me.Label3)
        Me.TP1.Controls.Add(Me.Label2)
        Me.TP1.Controls.Add(Me.txt_bus_fact)
        Me.TP1.Controls.Add(Me.Label1)
        Me.TP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TP1.Location = New System.Drawing.Point(4, 24)
        Me.TP1.Name = "TP1"
        Me.TP1.Padding = New System.Windows.Forms.Padding(3)
        Me.TP1.Size = New System.Drawing.Size(1067, 607)
        Me.TP1.TabIndex = 0
        Me.TP1.Text = "Reing. Facturas"
        '
        'lbl_dirclie
        '
        Me.lbl_dirclie.AutoSize = True
        Me.lbl_dirclie.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_dirclie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_dirclie.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dirclie.ForeColor = System.Drawing.Color.Navy
        Me.lbl_dirclie.Location = New System.Drawing.Point(648, 73)
        Me.lbl_dirclie.Name = "lbl_dirclie"
        Me.lbl_dirclie.Size = New System.Drawing.Size(61, 17)
        Me.lbl_dirclie.TabIndex = 60
        Me.lbl_dirclie.Text = "lbl_dirclie"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Silver
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(669, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Direccion:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl_patente)
        Me.GroupBox2.Controls.Add(Me.lbl_movil)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.lbl_obs)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.lbl_ampm)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lbl_peso)
        Me.GroupBox2.Controls.Add(Me.lbl_fe_desp)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lbl_fe_reg)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lbl_cedible)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lbl_acomodador)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lbl_chofer)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lbl_medio_tp)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lbl_nrobultos)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lbl_nroflete)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.lbl_nrodp)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1023, 191)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Despacho"
        '
        'lbl_patente
        '
        Me.lbl_patente.AutoSize = True
        Me.lbl_patente.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_patente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_patente.ForeColor = System.Drawing.Color.Navy
        Me.lbl_patente.Location = New System.Drawing.Point(214, 122)
        Me.lbl_patente.Name = "lbl_patente"
        Me.lbl_patente.Size = New System.Drawing.Size(72, 17)
        Me.lbl_patente.TabIndex = 73
        Me.lbl_patente.Text = "lbl_patente"
        '
        'lbl_movil
        '
        Me.lbl_movil.AutoSize = True
        Me.lbl_movil.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_movil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_movil.ForeColor = System.Drawing.Color.Navy
        Me.lbl_movil.Location = New System.Drawing.Point(175, 146)
        Me.lbl_movil.Name = "lbl_movil"
        Me.lbl_movil.Size = New System.Drawing.Size(58, 17)
        Me.lbl_movil.TabIndex = 72
        Me.lbl_movil.Text = "lbl_movil"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.SystemColors.Info
        Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label30.ForeColor = System.Drawing.Color.Maroon
        Me.Label30.Location = New System.Drawing.Point(171, 122)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(39, 17)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "Movil"
        '
        'lbl_obs
        '
        Me.lbl_obs.AutoSize = True
        Me.lbl_obs.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_obs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_obs.ForeColor = System.Drawing.Color.Navy
        Me.lbl_obs.Location = New System.Drawing.Point(804, 52)
        Me.lbl_obs.Name = "lbl_obs"
        Me.lbl_obs.Size = New System.Drawing.Size(47, 17)
        Me.lbl_obs.TabIndex = 70
        Me.lbl_obs.Text = "lbl_obs"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.SystemColors.Info
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.ForeColor = System.Drawing.Color.Maroon
        Me.Label24.Location = New System.Drawing.Point(856, 31)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 17)
        Me.Label24.TabIndex = 69
        Me.Label24.Text = "Observacion Despacho"
        '
        'lbl_ampm
        '
        Me.lbl_ampm.AutoSize = True
        Me.lbl_ampm.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_ampm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ampm.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ampm.Location = New System.Drawing.Point(471, 144)
        Me.lbl_ampm.Name = "lbl_ampm"
        Me.lbl_ampm.Size = New System.Drawing.Size(63, 17)
        Me.lbl_ampm.TabIndex = 66
        Me.lbl_ampm.Text = "lbl_ampm"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.SystemColors.Info
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.ForeColor = System.Drawing.Color.Maroon
        Me.Label22.Location = New System.Drawing.Point(468, 122)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(40, 17)
        Me.Label22.TabIndex = 65
        Me.Label22.Text = "Salida"
        '
        'lbl_peso
        '
        Me.lbl_peso.AutoSize = True
        Me.lbl_peso.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_peso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_peso.ForeColor = System.Drawing.Color.Navy
        Me.lbl_peso.Location = New System.Drawing.Point(717, 52)
        Me.lbl_peso.Name = "lbl_peso"
        Me.lbl_peso.Size = New System.Drawing.Size(54, 17)
        Me.lbl_peso.TabIndex = 64
        Me.lbl_peso.Text = "lbl_peso"
        '
        'lbl_fe_desp
        '
        Me.lbl_fe_desp.AutoSize = True
        Me.lbl_fe_desp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_fe_desp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_desp.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_desp.Location = New System.Drawing.Point(503, 52)
        Me.lbl_fe_desp.Name = "lbl_fe_desp"
        Me.lbl_fe_desp.Size = New System.Drawing.Size(71, 17)
        Me.lbl_fe_desp.TabIndex = 63
        Me.lbl_fe_desp.Text = "lbl_fe_desp"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.SystemColors.Info
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.ForeColor = System.Drawing.Color.Maroon
        Me.Label21.Location = New System.Drawing.Point(714, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 17)
        Me.Label21.TabIndex = 62
        Me.Label21.Text = "Peso (gramos)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Info
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label20.ForeColor = System.Drawing.Color.Maroon
        Me.Label20.Location = New System.Drawing.Point(500, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 17)
        Me.Label20.TabIndex = 61
        Me.Label20.Text = "Fecha despacho "
        '
        'lbl_fe_reg
        '
        Me.lbl_fe_reg.AutoSize = True
        Me.lbl_fe_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_fe_reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_reg.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_reg.Location = New System.Drawing.Point(811, 146)
        Me.lbl_fe_reg.Name = "lbl_fe_reg"
        Me.lbl_fe_reg.Size = New System.Drawing.Size(63, 17)
        Me.lbl_fe_reg.TabIndex = 60
        Me.lbl_fe_reg.Text = "lbl_fe_reg"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.SystemColors.Info
        Me.Label19.ForeColor = System.Drawing.Color.Maroon
        Me.Label19.Location = New System.Drawing.Point(813, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 15)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Fecha Creación"
        '
        'lbl_cedible
        '
        Me.lbl_cedible.AutoSize = True
        Me.lbl_cedible.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_cedible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_cedible.ForeColor = System.Drawing.Color.Navy
        Me.lbl_cedible.Location = New System.Drawing.Point(265, 52)
        Me.lbl_cedible.Name = "lbl_cedible"
        Me.lbl_cedible.Size = New System.Drawing.Size(67, 17)
        Me.lbl_cedible.TabIndex = 58
        Me.lbl_cedible.Text = "lbl_cedible"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.SystemColors.Info
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label18.ForeColor = System.Drawing.Color.Maroon
        Me.Label18.Location = New System.Drawing.Point(303, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 17)
        Me.Label18.TabIndex = 57
        Me.Label18.Text = "Nro Cedible"
        '
        'lbl_acomodador
        '
        Me.lbl_acomodador.AutoSize = True
        Me.lbl_acomodador.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_acomodador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_acomodador.ForeColor = System.Drawing.Color.Navy
        Me.lbl_acomodador.Location = New System.Drawing.Point(594, 145)
        Me.lbl_acomodador.Name = "lbl_acomodador"
        Me.lbl_acomodador.Size = New System.Drawing.Size(96, 17)
        Me.lbl_acomodador.TabIndex = 56
        Me.lbl_acomodador.Text = "lbl_acomodador"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.SystemColors.Info
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(600, 124)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 17)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Acomodador"
        '
        'lbl_chofer
        '
        Me.lbl_chofer.AutoSize = True
        Me.lbl_chofer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_chofer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_chofer.ForeColor = System.Drawing.Color.Navy
        Me.lbl_chofer.Location = New System.Drawing.Point(352, 144)
        Me.lbl_chofer.Name = "lbl_chofer"
        Me.lbl_chofer.Size = New System.Drawing.Size(63, 17)
        Me.lbl_chofer.TabIndex = 54
        Me.lbl_chofer.Text = "lbl_chofer"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.SystemColors.Info
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(349, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 17)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "Chofer"
        '
        'lbl_medio_tp
        '
        Me.lbl_medio_tp.AutoSize = True
        Me.lbl_medio_tp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_medio_tp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_medio_tp.ForeColor = System.Drawing.Color.Navy
        Me.lbl_medio_tp.Location = New System.Drawing.Point(21, 145)
        Me.lbl_medio_tp.Name = "lbl_medio_tp"
        Me.lbl_medio_tp.Size = New System.Drawing.Size(81, 17)
        Me.lbl_medio_tp.TabIndex = 52
        Me.lbl_medio_tp.Text = "lbl_medio_tp"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Info
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(10, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Medio Transporte"
        '
        'lbl_nrobultos
        '
        Me.lbl_nrobultos.AutoSize = True
        Me.lbl_nrobultos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_nrobultos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrobultos.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nrobultos.Location = New System.Drawing.Point(619, 52)
        Me.lbl_nrobultos.Name = "lbl_nrobultos"
        Me.lbl_nrobultos.Size = New System.Drawing.Size(81, 17)
        Me.lbl_nrobultos.TabIndex = 50
        Me.lbl_nrobultos.Text = "lbl_nrobultos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Info
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(623, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Nro Bultos"
        '
        'lbl_nroflete
        '
        Me.lbl_nroflete.AutoSize = True
        Me.lbl_nroflete.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_nroflete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nroflete.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nroflete.Location = New System.Drawing.Point(112, 52)
        Me.lbl_nroflete.Name = "lbl_nroflete"
        Me.lbl_nroflete.Size = New System.Drawing.Size(73, 17)
        Me.lbl_nroflete.TabIndex = 48
        Me.lbl_nroflete.Text = "lbl_nroflete"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.SystemColors.Info
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(146, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 17)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Nro de Flete"
        '
        'lbl_nrodp
        '
        Me.lbl_nrodp.AutoSize = True
        Me.lbl_nrodp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_nrodp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrodp.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nrodp.Location = New System.Drawing.Point(21, 52)
        Me.lbl_nrodp.Name = "lbl_nrodp"
        Me.lbl_nrodp.Size = New System.Drawing.Size(61, 17)
        Me.lbl_nrodp.TabIndex = 46
        Me.lbl_nrodp.Text = "lbl_nrodp"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Info
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(11, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 17)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Nro Interno DP:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(489, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(0, 13)
        Me.Label13.TabIndex = 57
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_modificar)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_actualizar)
        Me.GroupBox1.Controls.Add(Me.lbl_idbd)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 480)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(700, 109)
        Me.GroupBox1.TabIndex = 56
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acciones"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_cancelar.Image = Global.Despachos.My.Resources.Resources.cancel
        Me.cmd_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_cancelar.Location = New System.Drawing.Point(486, 28)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(106, 62)
        Me.cmd_cancelar.TabIndex = 3
        Me.cmd_cancelar.Text = "CANCELAR"
        Me.cmd_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_cancelar.UseVisualStyleBackColor = False
        '
        'cmd_modificar
        '
        Me.cmd_modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_modificar.Image = Global.Despachos.My.Resources.Resources.refresh
        Me.cmd_modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_modificar.Location = New System.Drawing.Point(352, 28)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(106, 62)
        Me.cmd_modificar.TabIndex = 2
        Me.cmd_modificar.Text = "MODIFICAR"
        Me.cmd_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_modificar.UseVisualStyleBackColor = False
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_limpiar.Image = Global.Despachos.My.Resources.Resources.undo
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_limpiar.Location = New System.Drawing.Point(223, 28)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(106, 62)
        Me.cmd_limpiar.TabIndex = 1
        Me.cmd_limpiar.Text = "LIMPIAR"
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_limpiar.UseVisualStyleBackColor = False
        '
        'cmd_actualizar
        '
        Me.cmd_actualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_actualizar.Image = Global.Despachos.My.Resources.Resources.save
        Me.cmd_actualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_actualizar.Location = New System.Drawing.Point(95, 28)
        Me.cmd_actualizar.Name = "cmd_actualizar"
        Me.cmd_actualizar.Size = New System.Drawing.Size(106, 62)
        Me.cmd_actualizar.TabIndex = 0
        Me.cmd_actualizar.Text = "ACTUALIZAR"
        Me.cmd_actualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_actualizar.UseVisualStyleBackColor = False
        '
        'lbl_idbd
        '
        Me.lbl_idbd.AutoSize = True
        Me.lbl_idbd.Location = New System.Drawing.Point(27, 52)
        Me.lbl_idbd.Name = "lbl_idbd"
        Me.lbl_idbd.Size = New System.Drawing.Size(51, 13)
        Me.lbl_idbd.TabIndex = 45
        Me.lbl_idbd.Text = "lbl_idbd"
        Me.lbl_idbd.Visible = False
        '
        'txt_reing_obs
        '
        Me.txt_reing_obs.Location = New System.Drawing.Point(624, 451)
        Me.txt_reing_obs.Name = "txt_reing_obs"
        Me.txt_reing_obs.Size = New System.Drawing.Size(384, 20)
        Me.txt_reing_obs.TabIndex = 55
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label29.Location = New System.Drawing.Point(666, 433)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(167, 15)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "Observaciones del Reingreso:"
        '
        'txt_recep_desp
        '
        Me.txt_recep_desp.Location = New System.Drawing.Point(349, 451)
        Me.txt_recep_desp.Name = "txt_recep_desp"
        Me.txt_recep_desp.Size = New System.Drawing.Size(267, 20)
        Me.txt_recep_desp.TabIndex = 53
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(384, 433)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(118, 15)
        Me.Label28.TabIndex = 52
        Me.Label28.Text = "Recibió el Despacho:"
        '
        'msk_fe_recep_clte
        '
        Me.msk_fe_recep_clte.Location = New System.Drawing.Point(183, 451)
        Me.msk_fe_recep_clte.Mask = "0000-00-00"
        Me.msk_fe_recep_clte.Name = "msk_fe_recep_clte"
        Me.msk_fe_recep_clte.Size = New System.Drawing.Size(89, 20)
        Me.msk_fe_recep_clte.TabIndex = 51
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label27.Location = New System.Drawing.Point(167, 433)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(158, 15)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Fecha Recepcion del Cliente"
        '
        'msk_fe_reing
        '
        Me.msk_fe_reing.Location = New System.Drawing.Point(36, 451)
        Me.msk_fe_reing.Mask = "0000-00-00"
        Me.msk_fe_reing.Name = "msk_fe_reing"
        Me.msk_fe_reing.Size = New System.Drawing.Size(89, 20)
        Me.msk_fe_reing.TabIndex = 49
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label26.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label26.Location = New System.Drawing.Point(31, 433)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(95, 15)
        Me.Label26.TabIndex = 47
        Me.Label26.Text = "Fecha Reingreso"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Maroon
        Me.Label25.Location = New System.Drawing.Point(380, 392)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(197, 15)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "COMPLETAR RE-INGRESO DE DATOS"
        '
        'ch_anio_ant
        '
        Me.ch_anio_ant.AutoSize = True
        Me.ch_anio_ant.BackColor = System.Drawing.Color.Silver
        Me.ch_anio_ant.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_anio_ant.ForeColor = System.Drawing.Color.Maroon
        Me.ch_anio_ant.Location = New System.Drawing.Point(30, 73)
        Me.ch_anio_ant.Name = "ch_anio_ant"
        Me.ch_anio_ant.Size = New System.Drawing.Size(98, 19)
        Me.ch_anio_ant.TabIndex = 40
        Me.ch_anio_ant.Text = "Año Anterior"
        Me.ch_anio_ant.UseVisualStyleBackColor = False
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_ciudad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciudad.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ciudad.Location = New System.Drawing.Point(898, 73)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(63, 17)
        Me.lbl_ciudad.TabIndex = 25
        Me.lbl_ciudad.Text = "lbl_ciudad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Silver
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(907, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 17)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Ciudad"
        '
        'lbl_vendedor
        '
        Me.lbl_vendedor.AutoSize = True
        Me.lbl_vendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_vendedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_vendedor.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vendedor.ForeColor = System.Drawing.Color.Navy
        Me.lbl_vendedor.Location = New System.Drawing.Point(765, 140)
        Me.lbl_vendedor.Name = "lbl_vendedor"
        Me.lbl_vendedor.Size = New System.Drawing.Size(81, 17)
        Me.lbl_vendedor.TabIndex = 14
        Me.lbl_vendedor.Text = "lbl_vendedor"
        '
        'lbl_noc
        '
        Me.lbl_noc.AutoSize = True
        Me.lbl_noc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_noc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_noc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_noc.Location = New System.Drawing.Point(590, 140)
        Me.lbl_noc.Name = "lbl_noc"
        Me.lbl_noc.Size = New System.Drawing.Size(47, 17)
        Me.lbl_noc.TabIndex = 13
        Me.lbl_noc.Text = "lbl_noc"
        '
        'lbl_fe_fact
        '
        Me.lbl_fe_fact.AutoSize = True
        Me.lbl_fe_fact.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_fe_fact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_fact.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fe_fact.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_fact.Location = New System.Drawing.Point(387, 140)
        Me.lbl_fe_fact.Name = "lbl_fe_fact"
        Me.lbl_fe_fact.Size = New System.Drawing.Size(65, 17)
        Me.lbl_fe_fact.TabIndex = 12
        Me.lbl_fe_fact.Text = "lbl_fe_fact"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_cliente.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cliente.ForeColor = System.Drawing.Color.Navy
        Me.lbl_cliente.Location = New System.Drawing.Point(304, 75)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(65, 17)
        Me.lbl_cliente.TabIndex = 11
        Me.lbl_cliente.Text = "lbl_cliente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Silver
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(373, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Cliente:"
        '
        'lbl_mto_fact
        '
        Me.lbl_mto_fact.AutoSize = True
        Me.lbl_mto_fact.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_mto_fact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mto_fact.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mto_fact.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mto_fact.Location = New System.Drawing.Point(183, 140)
        Me.lbl_mto_fact.Name = "lbl_mto_fact"
        Me.lbl_mto_fact.Size = New System.Drawing.Size(77, 17)
        Me.lbl_mto_fact.TabIndex = 9
        Me.lbl_mto_fact.Text = "lbl_mto_fact"
        '
        'lbl_rut
        '
        Me.lbl_rut.AutoSize = True
        Me.lbl_rut.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_rut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_rut.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rut.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rut.Location = New System.Drawing.Point(170, 75)
        Me.lbl_rut.Name = "lbl_rut"
        Me.lbl_rut.Size = New System.Drawing.Size(45, 17)
        Me.lbl_rut.TabIndex = 8
        Me.lbl_rut.Text = "lbl_rut"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(807, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Vendedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Silver
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(590, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nro OC."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(376, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha Factura:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(169, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Monto Facturado:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(169, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Rut Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(267, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATOS DE LA FACTURA"
        '
        'txt_bus_fact
        '
        Me.txt_bus_fact.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bus_fact.Location = New System.Drawing.Point(31, 41)
        Me.txt_bus_fact.Name = "txt_bus_fact"
        Me.txt_bus_fact.Size = New System.Drawing.Size(87, 22)
        Me.txt_bus_fact.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Nro Factura:"
        '
        'TP2
        '
        Me.TP2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP2.Controls.Add(Me.lbl_usr_reing_boe)
        Me.TP2.Controls.Add(Me.Label107)
        Me.TP2.Controls.Add(Me.GroupBox4)
        Me.TP2.Controls.Add(Me.txt_obs_reing_boe)
        Me.TP2.Controls.Add(Me.Label39)
        Me.TP2.Controls.Add(Me.txt_recep_desp_boe)
        Me.TP2.Controls.Add(Me.Label41)
        Me.TP2.Controls.Add(Me.msk_fe_recep_clie_boe)
        Me.TP2.Controls.Add(Me.Label43)
        Me.TP2.Controls.Add(Me.msk_fe_reing_boe)
        Me.TP2.Controls.Add(Me.Label45)
        Me.TP2.Controls.Add(Me.Label38)
        Me.TP2.Controls.Add(Me.lbl_mto_boe)
        Me.TP2.Controls.Add(Me.lbl_vend_boe)
        Me.TP2.Controls.Add(Me.lbl_fe_boe)
        Me.TP2.Controls.Add(Me.lbl_ciudad_boe)
        Me.TP2.Controls.Add(Me.lbl_clie_boe)
        Me.TP2.Controls.Add(Me.lbl_rut_boe)
        Me.TP2.Controls.Add(Me.GroupBox3)
        Me.TP2.Controls.Add(Me.Label37)
        Me.TP2.Controls.Add(Me.Label36)
        Me.TP2.Controls.Add(Me.Label35)
        Me.TP2.Controls.Add(Me.Label34)
        Me.TP2.Controls.Add(Me.Label32)
        Me.TP2.Controls.Add(Me.Label33)
        Me.TP2.Controls.Add(Me.ch_anio_ant_boe)
        Me.TP2.Controls.Add(Me.txt_bus_boe)
        Me.TP2.Controls.Add(Me.Label23)
        Me.TP2.Controls.Add(Me.Label31)
        Me.TP2.Location = New System.Drawing.Point(4, 24)
        Me.TP2.Name = "TP2"
        Me.TP2.Padding = New System.Windows.Forms.Padding(3)
        Me.TP2.Size = New System.Drawing.Size(1067, 607)
        Me.TP2.TabIndex = 1
        Me.TP2.Text = "Reing. Boletas"
        '
        'lbl_usr_reing_boe
        '
        Me.lbl_usr_reing_boe.AutoSize = True
        Me.lbl_usr_reing_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_usr_reing_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_usr_reing_boe.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usr_reing_boe.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_usr_reing_boe.Location = New System.Drawing.Point(184, 403)
        Me.lbl_usr_reing_boe.Name = "lbl_usr_reing_boe"
        Me.lbl_usr_reing_boe.Size = New System.Drawing.Size(105, 17)
        Me.lbl_usr_reing_boe.TabIndex = 77
        Me.lbl_usr_reing_boe.Text = "lbl_usr_reing_boe"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(49, 403)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(136, 15)
        Me.Label107.TabIndex = 76
        Me.Label107.Text = "Usuario que Reingreso :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmd_cancelar_boe)
        Me.GroupBox4.Controls.Add(Me.cmd_modificar_boe)
        Me.GroupBox4.Controls.Add(Me.cmd_limpiar_boe)
        Me.GroupBox4.Controls.Add(Me.cmd_actualiza_boe)
        Me.GroupBox4.Controls.Add(Me.lbl_idbd_boe)
        Me.GroupBox4.Location = New System.Drawing.Point(154, 455)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(700, 121)
        Me.GroupBox4.TabIndex = 75
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Acciones"
        '
        'cmd_cancelar_boe
        '
        Me.cmd_cancelar_boe.BackColor = System.Drawing.Color.Gray
        Me.cmd_cancelar_boe.Image = Global.Despachos.My.Resources.Resources.cancel
        Me.cmd_cancelar_boe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_cancelar_boe.Location = New System.Drawing.Point(486, 28)
        Me.cmd_cancelar_boe.Name = "cmd_cancelar_boe"
        Me.cmd_cancelar_boe.Size = New System.Drawing.Size(106, 62)
        Me.cmd_cancelar_boe.TabIndex = 3
        Me.cmd_cancelar_boe.Text = "CANCELAR"
        Me.cmd_cancelar_boe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_cancelar_boe.UseVisualStyleBackColor = False
        '
        'cmd_modificar_boe
        '
        Me.cmd_modificar_boe.BackColor = System.Drawing.Color.Gray
        Me.cmd_modificar_boe.Image = Global.Despachos.My.Resources.Resources.refresh
        Me.cmd_modificar_boe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_modificar_boe.Location = New System.Drawing.Point(352, 28)
        Me.cmd_modificar_boe.Name = "cmd_modificar_boe"
        Me.cmd_modificar_boe.Size = New System.Drawing.Size(106, 62)
        Me.cmd_modificar_boe.TabIndex = 2
        Me.cmd_modificar_boe.Text = "MODIFICAR"
        Me.cmd_modificar_boe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_modificar_boe.UseVisualStyleBackColor = False
        '
        'cmd_limpiar_boe
        '
        Me.cmd_limpiar_boe.BackColor = System.Drawing.Color.Gray
        Me.cmd_limpiar_boe.Image = Global.Despachos.My.Resources.Resources.undo
        Me.cmd_limpiar_boe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_limpiar_boe.Location = New System.Drawing.Point(223, 28)
        Me.cmd_limpiar_boe.Name = "cmd_limpiar_boe"
        Me.cmd_limpiar_boe.Size = New System.Drawing.Size(106, 62)
        Me.cmd_limpiar_boe.TabIndex = 1
        Me.cmd_limpiar_boe.Text = "LIMPIAR"
        Me.cmd_limpiar_boe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_limpiar_boe.UseVisualStyleBackColor = False
        '
        'cmd_actualiza_boe
        '
        Me.cmd_actualiza_boe.BackColor = System.Drawing.Color.Gray
        Me.cmd_actualiza_boe.Image = Global.Despachos.My.Resources.Resources.save
        Me.cmd_actualiza_boe.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_actualiza_boe.Location = New System.Drawing.Point(95, 28)
        Me.cmd_actualiza_boe.Name = "cmd_actualiza_boe"
        Me.cmd_actualiza_boe.Size = New System.Drawing.Size(106, 62)
        Me.cmd_actualiza_boe.TabIndex = 0
        Me.cmd_actualiza_boe.Text = "ACTUALIZAR"
        Me.cmd_actualiza_boe.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_actualiza_boe.UseVisualStyleBackColor = False
        '
        'lbl_idbd_boe
        '
        Me.lbl_idbd_boe.AutoSize = True
        Me.lbl_idbd_boe.Location = New System.Drawing.Point(615, 90)
        Me.lbl_idbd_boe.Name = "lbl_idbd_boe"
        Me.lbl_idbd_boe.Size = New System.Drawing.Size(79, 15)
        Me.lbl_idbd_boe.TabIndex = 45
        Me.lbl_idbd_boe.Text = "lbl_idbd_boe"
        Me.lbl_idbd_boe.Visible = False
        '
        'txt_obs_reing_boe
        '
        Me.txt_obs_reing_boe.Location = New System.Drawing.Point(564, 352)
        Me.txt_obs_reing_boe.Name = "txt_obs_reing_boe"
        Me.txt_obs_reing_boe.Size = New System.Drawing.Size(440, 23)
        Me.txt_obs_reing_boe.TabIndex = 74
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label39.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label39.Location = New System.Drawing.Point(614, 334)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(167, 15)
        Me.Label39.TabIndex = 73
        Me.Label39.Text = "Observaciones del Reingreso:"
        '
        'txt_recep_desp_boe
        '
        Me.txt_recep_desp_boe.Location = New System.Drawing.Point(358, 352)
        Me.txt_recep_desp_boe.Name = "txt_recep_desp_boe"
        Me.txt_recep_desp_boe.Size = New System.Drawing.Size(191, 23)
        Me.txt_recep_desp_boe.TabIndex = 72
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label41.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(393, 334)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(118, 15)
        Me.Label41.TabIndex = 71
        Me.Label41.Text = "Recibió el Despacho:"
        '
        'msk_fe_recep_clie_boe
        '
        Me.msk_fe_recep_clie_boe.Location = New System.Drawing.Point(192, 352)
        Me.msk_fe_recep_clie_boe.Mask = "0000-00-00"
        Me.msk_fe_recep_clie_boe.Name = "msk_fe_recep_clie_boe"
        Me.msk_fe_recep_clie_boe.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_recep_clie_boe.TabIndex = 70
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label43.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label43.Location = New System.Drawing.Point(176, 334)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(158, 15)
        Me.Label43.TabIndex = 69
        Me.Label43.Text = "Fecha Recepcion del Cliente"
        '
        'msk_fe_reing_boe
        '
        Me.msk_fe_reing_boe.Location = New System.Drawing.Point(45, 352)
        Me.msk_fe_reing_boe.Mask = "0000-00-00"
        Me.msk_fe_reing_boe.Name = "msk_fe_reing_boe"
        Me.msk_fe_reing_boe.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_reing_boe.TabIndex = 68
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label45.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(40, 334)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(95, 15)
        Me.Label45.TabIndex = 67
        Me.Label45.Text = "Fecha Reingreso"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label38.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Maroon
        Me.Label38.Location = New System.Drawing.Point(281, 300)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(197, 15)
        Me.Label38.TabIndex = 66
        Me.Label38.Text = "COMPLETAR RE-INGRESO DE DATOS"
        '
        'lbl_mto_boe
        '
        Me.lbl_mto_boe.AutoSize = True
        Me.lbl_mto_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_mto_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mto_boe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mto_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mto_boe.Location = New System.Drawing.Point(692, 77)
        Me.lbl_mto_boe.Name = "lbl_mto_boe"
        Me.lbl_mto_boe.Size = New System.Drawing.Size(78, 17)
        Me.lbl_mto_boe.TabIndex = 65
        Me.lbl_mto_boe.Text = "lbl_mto_boe"
        '
        'lbl_vend_boe
        '
        Me.lbl_vend_boe.AutoSize = True
        Me.lbl_vend_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_vend_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_vend_boe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vend_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_vend_boe.Location = New System.Drawing.Point(893, 77)
        Me.lbl_vend_boe.Name = "lbl_vend_boe"
        Me.lbl_vend_boe.Size = New System.Drawing.Size(82, 17)
        Me.lbl_vend_boe.TabIndex = 64
        Me.lbl_vend_boe.Text = "lbl_vend_boe"
        '
        'lbl_fe_boe
        '
        Me.lbl_fe_boe.AutoSize = True
        Me.lbl_fe_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_fe_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_boe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fe_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_boe.Location = New System.Drawing.Point(788, 77)
        Me.lbl_fe_boe.Name = "lbl_fe_boe"
        Me.lbl_fe_boe.Size = New System.Drawing.Size(66, 17)
        Me.lbl_fe_boe.TabIndex = 63
        Me.lbl_fe_boe.Text = "lbl_fe_boe"
        '
        'lbl_ciudad_boe
        '
        Me.lbl_ciudad_boe.AutoSize = True
        Me.lbl_ciudad_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_ciudad_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciudad_boe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ciudad_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ciudad_boe.Location = New System.Drawing.Point(539, 77)
        Me.lbl_ciudad_boe.Name = "lbl_ciudad_boe"
        Me.lbl_ciudad_boe.Size = New System.Drawing.Size(90, 17)
        Me.lbl_ciudad_boe.TabIndex = 62
        Me.lbl_ciudad_boe.Text = "lbl_ciudad_boe"
        '
        'lbl_clie_boe
        '
        Me.lbl_clie_boe.AutoSize = True
        Me.lbl_clie_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_clie_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_clie_boe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clie_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_clie_boe.Location = New System.Drawing.Point(303, 77)
        Me.lbl_clie_boe.Name = "lbl_clie_boe"
        Me.lbl_clie_boe.Size = New System.Drawing.Size(73, 17)
        Me.lbl_clie_boe.TabIndex = 61
        Me.lbl_clie_boe.Text = "lbl_clie_boe"
        '
        'lbl_rut_boe
        '
        Me.lbl_rut_boe.AutoSize = True
        Me.lbl_rut_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_rut_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_rut_boe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rut_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rut_boe.Location = New System.Drawing.Point(196, 77)
        Me.lbl_rut_boe.Name = "lbl_rut_boe"
        Me.lbl_rut_boe.Size = New System.Drawing.Size(72, 17)
        Me.lbl_rut_boe.TabIndex = 60
        Me.lbl_rut_boe.Text = "lbl_rut_boe"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbl_usr_ingreso_boe)
        Me.GroupBox3.Controls.Add(Me.Label106)
        Me.GroupBox3.Controls.Add(Me.lbl_patente_boe)
        Me.GroupBox3.Controls.Add(Me.lbl_movil_boe)
        Me.GroupBox3.Controls.Add(Me.Label40)
        Me.GroupBox3.Controls.Add(Me.lbl_obs_desp_boe)
        Me.GroupBox3.Controls.Add(Me.Label42)
        Me.GroupBox3.Controls.Add(Me.lbl_ampm_boe)
        Me.GroupBox3.Controls.Add(Me.Label44)
        Me.GroupBox3.Controls.Add(Me.lbl_peso_boe)
        Me.GroupBox3.Controls.Add(Me.lbl_fe_desp_boe)
        Me.GroupBox3.Controls.Add(Me.Label47)
        Me.GroupBox3.Controls.Add(Me.Label48)
        Me.GroupBox3.Controls.Add(Me.lbl_fe_crea_boe)
        Me.GroupBox3.Controls.Add(Me.Label50)
        Me.GroupBox3.Controls.Add(Me.lbl_cedi_boe)
        Me.GroupBox3.Controls.Add(Me.Label52)
        Me.GroupBox3.Controls.Add(Me.lbl_despachador_boe)
        Me.GroupBox3.Controls.Add(Me.Label54)
        Me.GroupBox3.Controls.Add(Me.lbl_chofer_boe)
        Me.GroupBox3.Controls.Add(Me.Label56)
        Me.GroupBox3.Controls.Add(Me.lbl_mediotp_boe)
        Me.GroupBox3.Controls.Add(Me.Label58)
        Me.GroupBox3.Controls.Add(Me.lbl_nrobulto_boe)
        Me.GroupBox3.Controls.Add(Me.Label60)
        Me.GroupBox3.Controls.Add(Me.lbl_nro_flete_boe)
        Me.GroupBox3.Controls.Add(Me.Label62)
        Me.GroupBox3.Controls.Add(Me.lbl_nrodp_boe)
        Me.GroupBox3.Controls.Add(Me.Label64)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(21, 124)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1028, 160)
        Me.GroupBox3.TabIndex = 59
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Despacho"
        '
        'lbl_usr_ingreso_boe
        '
        Me.lbl_usr_ingreso_boe.AutoSize = True
        Me.lbl_usr_ingreso_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_usr_ingreso_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_usr_ingreso_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_usr_ingreso_boe.Location = New System.Drawing.Point(892, 111)
        Me.lbl_usr_ingreso_boe.Name = "lbl_usr_ingreso_boe"
        Me.lbl_usr_ingreso_boe.Size = New System.Drawing.Size(118, 17)
        Me.lbl_usr_ingreso_boe.TabIndex = 75
        Me.lbl_usr_ingreso_boe.Text = "lbl_usr_ingreso_boe"
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.BackColor = System.Drawing.Color.Gainsboro
        Me.Label106.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label106.Location = New System.Drawing.Point(889, 89)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(120, 15)
        Me.Label106.TabIndex = 74
        Me.Label106.Text = "Usuario que Registró"
        '
        'lbl_patente_boe
        '
        Me.lbl_patente_boe.AutoSize = True
        Me.lbl_patente_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_patente_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_patente_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_patente_boe.Location = New System.Drawing.Point(71, 89)
        Me.lbl_patente_boe.Name = "lbl_patente_boe"
        Me.lbl_patente_boe.Size = New System.Drawing.Size(99, 17)
        Me.lbl_patente_boe.TabIndex = 73
        Me.lbl_patente_boe.Text = "lbl_patente_boe"
        '
        'lbl_movil_boe
        '
        Me.lbl_movil_boe.AutoSize = True
        Me.lbl_movil_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_movil_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_movil_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_movil_boe.Location = New System.Drawing.Point(23, 110)
        Me.lbl_movil_boe.Name = "lbl_movil_boe"
        Me.lbl_movil_boe.Size = New System.Drawing.Size(85, 17)
        Me.lbl_movil_boe.TabIndex = 72
        Me.lbl_movil_boe.Text = "lbl_movil_boe"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.BackColor = System.Drawing.Color.Gainsboro
        Me.Label40.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label40.Location = New System.Drawing.Point(19, 89)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(39, 17)
        Me.Label40.TabIndex = 71
        Me.Label40.Text = "Movil"
        '
        'lbl_obs_desp_boe
        '
        Me.lbl_obs_desp_boe.AutoSize = True
        Me.lbl_obs_desp_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_obs_desp_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_obs_desp_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_obs_desp_boe.Location = New System.Drawing.Point(293, 111)
        Me.lbl_obs_desp_boe.Name = "lbl_obs_desp_boe"
        Me.lbl_obs_desp_boe.Size = New System.Drawing.Size(106, 17)
        Me.lbl_obs_desp_boe.TabIndex = 70
        Me.lbl_obs_desp_boe.Text = "lbl_obs_desp_boe"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Gainsboro
        Me.Label42.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(292, 91)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(131, 17)
        Me.Label42.TabIndex = 69
        Me.Label42.Text = "Observacion Despacho"
        '
        'lbl_ampm_boe
        '
        Me.lbl_ampm_boe.AutoSize = True
        Me.lbl_ampm_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_ampm_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ampm_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ampm_boe.Location = New System.Drawing.Point(477, 111)
        Me.lbl_ampm_boe.Name = "lbl_ampm_boe"
        Me.lbl_ampm_boe.Size = New System.Drawing.Size(90, 17)
        Me.lbl_ampm_boe.TabIndex = 66
        Me.lbl_ampm_boe.Text = "lbl_ampm_boe"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.BackColor = System.Drawing.Color.Gainsboro
        Me.Label44.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label44.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label44.Location = New System.Drawing.Point(490, 89)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(40, 17)
        Me.Label44.TabIndex = 65
        Me.Label44.Text = "Salida"
        '
        'lbl_peso_boe
        '
        Me.lbl_peso_boe.AutoSize = True
        Me.lbl_peso_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_peso_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_peso_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_peso_boe.Location = New System.Drawing.Point(757, 52)
        Me.lbl_peso_boe.Name = "lbl_peso_boe"
        Me.lbl_peso_boe.Size = New System.Drawing.Size(81, 17)
        Me.lbl_peso_boe.TabIndex = 64
        Me.lbl_peso_boe.Text = "lbl_peso_boe"
        '
        'lbl_fe_desp_boe
        '
        Me.lbl_fe_desp_boe.AutoSize = True
        Me.lbl_fe_desp_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_fe_desp_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_desp_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_desp_boe.Location = New System.Drawing.Point(469, 52)
        Me.lbl_fe_desp_boe.Name = "lbl_fe_desp_boe"
        Me.lbl_fe_desp_boe.Size = New System.Drawing.Size(98, 17)
        Me.lbl_fe_desp_boe.TabIndex = 63
        Me.lbl_fe_desp_boe.Text = "lbl_fe_desp_boe"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label47.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(754, 31)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(86, 17)
        Me.Label47.TabIndex = 62
        Me.Label47.Text = "Peso (gramos)"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Gainsboro
        Me.Label48.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(468, 31)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(97, 17)
        Me.Label48.TabIndex = 61
        Me.Label48.Text = "Fecha despacho "
        '
        'lbl_fe_crea_boe
        '
        Me.lbl_fe_crea_boe.AutoSize = True
        Me.lbl_fe_crea_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_fe_crea_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_crea_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_crea_boe.Location = New System.Drawing.Point(757, 111)
        Me.lbl_fe_crea_boe.Name = "lbl_fe_crea_boe"
        Me.lbl_fe_crea_boe.Size = New System.Drawing.Size(95, 17)
        Me.lbl_fe_crea_boe.TabIndex = 60
        Me.lbl_fe_crea_boe.Text = "lbl_fe_crea_boe"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.BackColor = System.Drawing.Color.Gainsboro
        Me.Label50.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label50.Location = New System.Drawing.Point(754, 91)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(90, 17)
        Me.Label50.TabIndex = 59
        Me.Label50.Text = "Fecha Creación"
        '
        'lbl_cedi_boe
        '
        Me.lbl_cedi_boe.AutoSize = True
        Me.lbl_cedi_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_cedi_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_cedi_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_cedi_boe.Location = New System.Drawing.Point(352, 52)
        Me.lbl_cedi_boe.Name = "lbl_cedi_boe"
        Me.lbl_cedi_boe.Size = New System.Drawing.Size(77, 17)
        Me.lbl_cedi_boe.TabIndex = 58
        Me.lbl_cedi_boe.Text = "lbl_cedi_boe"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.BackColor = System.Drawing.Color.Gainsboro
        Me.Label52.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label52.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label52.Location = New System.Drawing.Point(349, 31)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(74, 17)
        Me.Label52.TabIndex = 57
        Me.Label52.Text = "Nro Cedible"
        '
        'lbl_despachador_boe
        '
        Me.lbl_despachador_boe.AutoSize = True
        Me.lbl_despachador_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_despachador_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_despachador_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_despachador_boe.Location = New System.Drawing.Point(596, 111)
        Me.lbl_despachador_boe.Name = "lbl_despachador_boe"
        Me.lbl_despachador_boe.Size = New System.Drawing.Size(124, 17)
        Me.lbl_despachador_boe.TabIndex = 56
        Me.lbl_despachador_boe.Text = "lbl_despachador_boe"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Gainsboro
        Me.Label54.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(593, 91)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(69, 17)
        Me.Label54.TabIndex = 55
        Me.Label54.Text = "Ordenador"
        '
        'lbl_chofer_boe
        '
        Me.lbl_chofer_boe.AutoSize = True
        Me.lbl_chofer_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_chofer_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_chofer_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_chofer_boe.Location = New System.Drawing.Point(179, 111)
        Me.lbl_chofer_boe.Name = "lbl_chofer_boe"
        Me.lbl_chofer_boe.Size = New System.Drawing.Size(90, 17)
        Me.lbl_chofer_boe.TabIndex = 54
        Me.lbl_chofer_boe.Text = "lbl_chofer_boe"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Gainsboro
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label56.Location = New System.Drawing.Point(194, 89)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(46, 17)
        Me.Label56.TabIndex = 53
        Me.Label56.Text = "Chofer"
        '
        'lbl_mediotp_boe
        '
        Me.lbl_mediotp_boe.AutoSize = True
        Me.lbl_mediotp_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_mediotp_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_mediotp_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_mediotp_boe.Location = New System.Drawing.Point(894, 51)
        Me.lbl_mediotp_boe.Name = "lbl_mediotp_boe"
        Me.lbl_mediotp_boe.Size = New System.Drawing.Size(102, 17)
        Me.lbl_mediotp_boe.TabIndex = 52
        Me.lbl_mediotp_boe.Text = "lbl_mediotp_boe"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Gainsboro
        Me.Label58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label58.Location = New System.Drawing.Point(889, 31)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(104, 15)
        Me.Label58.TabIndex = 51
        Me.Label58.Text = "Medio Transporte"
        '
        'lbl_nrobulto_boe
        '
        Me.lbl_nrobulto_boe.AutoSize = True
        Me.lbl_nrobulto_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_nrobulto_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrobulto_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nrobulto_boe.Location = New System.Drawing.Point(619, 52)
        Me.lbl_nrobulto_boe.Name = "lbl_nrobulto_boe"
        Me.lbl_nrobulto_boe.Size = New System.Drawing.Size(103, 17)
        Me.lbl_nrobulto_boe.TabIndex = 50
        Me.lbl_nrobulto_boe.Text = "lbl_nrobulto_boe"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Gainsboro
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label60.Location = New System.Drawing.Point(623, 31)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(67, 17)
        Me.Label60.TabIndex = 49
        Me.Label60.Text = "Nro Bultos"
        '
        'lbl_nro_flete_boe
        '
        Me.lbl_nro_flete_boe.AutoSize = True
        Me.lbl_nro_flete_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_nro_flete_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nro_flete_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nro_flete_boe.Location = New System.Drawing.Point(175, 52)
        Me.lbl_nro_flete_boe.Name = "lbl_nro_flete_boe"
        Me.lbl_nro_flete_boe.Size = New System.Drawing.Size(106, 17)
        Me.lbl_nro_flete_boe.TabIndex = 48
        Me.lbl_nro_flete_boe.Text = "lbl_nro_flete_boe"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Gainsboro
        Me.Label62.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label62.Location = New System.Drawing.Point(172, 31)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(78, 17)
        Me.Label62.TabIndex = 47
        Me.Label62.Text = "Nro de Flete"
        '
        'lbl_nrodp_boe
        '
        Me.lbl_nrodp_boe.AutoSize = True
        Me.lbl_nrodp_boe.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_nrodp_boe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrodp_boe.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nrodp_boe.Location = New System.Drawing.Point(21, 52)
        Me.lbl_nrodp_boe.Name = "lbl_nrodp_boe"
        Me.lbl_nrodp_boe.Size = New System.Drawing.Size(88, 17)
        Me.lbl_nrodp_boe.TabIndex = 46
        Me.lbl_nrodp_boe.Text = "lbl_nrodp_boe"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Gainsboro
        Me.Label64.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label64.Location = New System.Drawing.Point(19, 31)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(96, 17)
        Me.Label64.TabIndex = 45
        Me.Label64.Text = "Nro Interno DP:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Silver
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label37.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.DarkRed
        Me.Label37.Location = New System.Drawing.Point(910, 57)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(65, 17)
        Me.Label37.TabIndex = 48
        Me.Label37.Text = "Vendedor:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.BackColor = System.Drawing.Color.Silver
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.DarkRed
        Me.Label36.Location = New System.Drawing.Point(785, 57)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(82, 17)
        Me.Label36.TabIndex = 47
        Me.Label36.Text = "Fecha Boleta:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BackColor = System.Drawing.Color.Silver
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.DarkRed
        Me.Label35.Location = New System.Drawing.Point(684, 57)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 17)
        Me.Label35.TabIndex = 46
        Me.Label35.Text = "Monto Boleta:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Silver
        Me.Label34.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label34.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.DarkRed
        Me.Label34.Location = New System.Drawing.Point(561, 57)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 17)
        Me.Label34.TabIndex = 45
        Me.Label34.Text = "Ciudad"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.BackColor = System.Drawing.Color.Silver
        Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label32.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.DarkRed
        Me.Label32.Location = New System.Drawing.Point(326, 57)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(50, 17)
        Me.Label32.TabIndex = 44
        Me.Label32.Text = "Cliente:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Silver
        Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label33.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DarkRed
        Me.Label33.Location = New System.Drawing.Point(197, 57)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(72, 17)
        Me.Label33.TabIndex = 43
        Me.Label33.Text = "Rut Cliente:"
        '
        'ch_anio_ant_boe
        '
        Me.ch_anio_ant_boe.AutoSize = True
        Me.ch_anio_ant_boe.BackColor = System.Drawing.Color.Silver
        Me.ch_anio_ant_boe.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_anio_ant_boe.ForeColor = System.Drawing.Color.Maroon
        Me.ch_anio_ant_boe.Location = New System.Drawing.Point(52, 77)
        Me.ch_anio_ant_boe.Name = "ch_anio_ant_boe"
        Me.ch_anio_ant_boe.Size = New System.Drawing.Size(98, 19)
        Me.ch_anio_ant_boe.TabIndex = 42
        Me.ch_anio_ant_boe.Text = "Año Anterior"
        Me.ch_anio_ant_boe.UseVisualStyleBackColor = False
        '
        'txt_bus_boe
        '
        Me.txt_bus_boe.Location = New System.Drawing.Point(53, 45)
        Me.txt_bus_boe.Name = "txt_bus_boe"
        Me.txt_bus_boe.Size = New System.Drawing.Size(87, 23)
        Me.txt_bus_boe.TabIndex = 41
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Maroon
        Me.Label23.Location = New System.Drawing.Point(437, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(121, 15)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "DATOS DE LA BOLETA"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(35, 27)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(127, 15)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Ingrese Nro de Boleta:"
        '
        'TP3
        '
        Me.TP3.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP3.Controls.Add(Me.GroupBox7)
        Me.TP3.Controls.Add(Me.GroupBox6)
        Me.TP3.Controls.Add(Me.GroupBox5)
        Me.TP3.Controls.Add(Me.CheckBox1)
        Me.TP3.Controls.Add(Me.txt_guia_reing_gc)
        Me.TP3.Controls.Add(Me.Label46)
        Me.TP3.Location = New System.Drawing.Point(4, 24)
        Me.TP3.Name = "TP3"
        Me.TP3.Padding = New System.Windows.Forms.Padding(3)
        Me.TP3.Size = New System.Drawing.Size(1067, 607)
        Me.TP3.TabIndex = 2
        Me.TP3.Text = "Reingreso Guias "
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.lbl_idbd_gc)
        Me.GroupBox7.Controls.Add(Me.cmd_salir)
        Me.GroupBox7.Controls.Add(Me.cmd_limpiar_gc)
        Me.GroupBox7.Controls.Add(Me.cmd_actualiza_gc)
        Me.GroupBox7.Controls.Add(Me.txt_reing_obs_gc)
        Me.GroupBox7.Controls.Add(Me.Label100)
        Me.GroupBox7.Controls.Add(Me.txt_recep_des_gc)
        Me.GroupBox7.Controls.Add(Me.Label99)
        Me.GroupBox7.Controls.Add(Me.msk_fe_recep_clte_gc)
        Me.GroupBox7.Controls.Add(Me.Label98)
        Me.GroupBox7.Controls.Add(Me.Label97)
        Me.GroupBox7.Controls.Add(Me.msk_fe_reing_gc)
        Me.GroupBox7.Controls.Add(Me.Label51)
        Me.GroupBox7.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox7.Location = New System.Drawing.Point(19, 373)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(1032, 185)
        Me.GroupBox7.TabIndex = 88
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "DATOS DEL REINGRESO"
        '
        'lbl_idbd_gc
        '
        Me.lbl_idbd_gc.AutoSize = True
        Me.lbl_idbd_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_idbd_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_idbd_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_idbd_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_idbd_gc.Location = New System.Drawing.Point(772, 119)
        Me.lbl_idbd_gc.Name = "lbl_idbd_gc"
        Me.lbl_idbd_gc.Size = New System.Drawing.Size(69, 17)
        Me.lbl_idbd_gc.TabIndex = 91
        Me.lbl_idbd_gc.Text = "lbl_idbd_gc"
        '
        'cmd_salir
        '
        Me.cmd_salir.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Image = Global.Despachos.My.Resources.Resources.arrow_undo
        Me.cmd_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_salir.Location = New System.Drawing.Point(635, 119)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(121, 54)
        Me.cmd_salir.TabIndex = 107
        Me.cmd_salir.Text = "        Salir a Menú"
        Me.cmd_salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_limpiar_gc
        '
        Me.cmd_limpiar_gc.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_limpiar_gc.Image = Global.Despachos.My.Resources.Resources.form_wizard
        Me.cmd_limpiar_gc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar_gc.Location = New System.Drawing.Point(467, 119)
        Me.cmd_limpiar_gc.Name = "cmd_limpiar_gc"
        Me.cmd_limpiar_gc.Size = New System.Drawing.Size(121, 54)
        Me.cmd_limpiar_gc.TabIndex = 105
        Me.cmd_limpiar_gc.Text = "     Limpiar Ventana"
        Me.cmd_limpiar_gc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar_gc.UseVisualStyleBackColor = True
        '
        'cmd_actualiza_gc
        '
        Me.cmd_actualiza_gc.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_actualiza_gc.Image = Global.Despachos.My.Resources.Resources.save
        Me.cmd_actualiza_gc.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_actualiza_gc.Location = New System.Drawing.Point(294, 119)
        Me.cmd_actualiza_gc.Name = "cmd_actualiza_gc"
        Me.cmd_actualiza_gc.Size = New System.Drawing.Size(121, 54)
        Me.cmd_actualiza_gc.TabIndex = 103
        Me.cmd_actualiza_gc.Text = "Actualizar Reingreso"
        Me.cmd_actualiza_gc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_actualiza_gc.UseVisualStyleBackColor = True
        '
        'txt_reing_obs_gc
        '
        Me.txt_reing_obs_gc.Location = New System.Drawing.Point(628, 74)
        Me.txt_reing_obs_gc.Name = "txt_reing_obs_gc"
        Me.txt_reing_obs_gc.Size = New System.Drawing.Size(370, 23)
        Me.txt_reing_obs_gc.TabIndex = 102
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.BackColor = System.Drawing.Color.Silver
        Me.Label100.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.ForeColor = System.Drawing.Color.DarkRed
        Me.Label100.Location = New System.Drawing.Point(688, 53)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(152, 15)
        Me.Label100.TabIndex = 101
        Me.Label100.Text = "Observación de Reingreso:"
        '
        'txt_recep_des_gc
        '
        Me.txt_recep_des_gc.Location = New System.Drawing.Point(362, 74)
        Me.txt_recep_des_gc.Name = "txt_recep_des_gc"
        Me.txt_recep_des_gc.Size = New System.Drawing.Size(233, 23)
        Me.txt_recep_des_gc.TabIndex = 100
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.BackColor = System.Drawing.Color.Silver
        Me.Label99.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.ForeColor = System.Drawing.Color.DarkRed
        Me.Label99.Location = New System.Drawing.Point(382, 53)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(118, 15)
        Me.Label99.TabIndex = 99
        Me.Label99.Text = "Recibió el Despacho:"
        '
        'msk_fe_recep_clte_gc
        '
        Me.msk_fe_recep_clte_gc.Location = New System.Drawing.Point(189, 74)
        Me.msk_fe_recep_clte_gc.Mask = "0000-00-00"
        Me.msk_fe_recep_clte_gc.Name = "msk_fe_recep_clte_gc"
        Me.msk_fe_recep_clte_gc.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_recep_clte_gc.TabIndex = 98
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Silver
        Me.Label98.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.DarkRed
        Me.Label98.Location = New System.Drawing.Point(169, 53)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(155, 15)
        Me.Label98.TabIndex = 97
        Me.Label98.Text = "Fecha de Recepción Cliente"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.Silver
        Me.Label97.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.DarkRed
        Me.Label97.Location = New System.Drawing.Point(20, 53)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(116, 15)
        Me.Label97.TabIndex = 96
        Me.Label97.Text = "Fecha de Reingreso:"
        '
        'msk_fe_reing_gc
        '
        Me.msk_fe_reing_gc.Location = New System.Drawing.Point(28, 74)
        Me.msk_fe_reing_gc.Mask = "0000-00-00"
        Me.msk_fe_reing_gc.Name = "msk_fe_reing_gc"
        Me.msk_fe_reing_gc.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_reing_gc.TabIndex = 69
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label51.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Maroon
        Me.Label51.Location = New System.Drawing.Point(350, 19)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(260, 15)
        Me.Label51.TabIndex = 47
        Me.Label51.Text = "INGRESE LOS DATOS DE REINGRESO DE LA GUIA"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_patente_gc)
        Me.GroupBox6.Controls.Add(Me.lbl_movil_gc)
        Me.GroupBox6.Controls.Add(Me.Label63)
        Me.GroupBox6.Controls.Add(Me.Label95)
        Me.GroupBox6.Controls.Add(Me.lbl_fe_reg_gc)
        Me.GroupBox6.Controls.Add(Me.lbl_obs_desp_gc)
        Me.GroupBox6.Controls.Add(Me.Label94)
        Me.GroupBox6.Controls.Add(Me.lbl_despach_gc)
        Me.GroupBox6.Controls.Add(Me.Label93)
        Me.GroupBox6.Controls.Add(Me.lbl_chofer_gc)
        Me.GroupBox6.Controls.Add(Me.Label92)
        Me.GroupBox6.Controls.Add(Me.lbl_ciudad_gc)
        Me.GroupBox6.Controls.Add(Me.lbl_transporte_gc)
        Me.GroupBox6.Controls.Add(Me.Label91)
        Me.GroupBox6.Controls.Add(Me.lbl_peso_gc)
        Me.GroupBox6.Controls.Add(Me.Label90)
        Me.GroupBox6.Controls.Add(Me.lbl_ncedible_gc)
        Me.GroupBox6.Controls.Add(Me.Label88)
        Me.GroupBox6.Controls.Add(Me.lbl_nbulto_gc)
        Me.GroupBox6.Controls.Add(Me.Label86)
        Me.GroupBox6.Controls.Add(Me.lbl_nro_flete_gc)
        Me.GroupBox6.Controls.Add(Me.Label85)
        Me.GroupBox6.Controls.Add(Me.lbl_nguia_gc)
        Me.GroupBox6.Controls.Add(Me.Label84)
        Me.GroupBox6.Controls.Add(Me.lbl_fe_desp_gc)
        Me.GroupBox6.Controls.Add(Me.Label65)
        Me.GroupBox6.Controls.Add(Me.lbl_nrodp_gc)
        Me.GroupBox6.Controls.Add(Me.Label61)
        Me.GroupBox6.Controls.Add(Me.lbl_salida_gc)
        Me.GroupBox6.Controls.Add(Me.Label67)
        Me.GroupBox6.Controls.Add(Me.Label69)
        Me.GroupBox6.Location = New System.Drawing.Point(19, 199)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(1033, 168)
        Me.GroupBox6.TabIndex = 85
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "DATOS DEL DESPACHO"
        '
        'lbl_patente_gc
        '
        Me.lbl_patente_gc.AutoSize = True
        Me.lbl_patente_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_patente_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_patente_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patente_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_patente_gc.Location = New System.Drawing.Point(235, 100)
        Me.lbl_patente_gc.Name = "lbl_patente_gc"
        Me.lbl_patente_gc.Size = New System.Drawing.Size(89, 17)
        Me.lbl_patente_gc.TabIndex = 103
        Me.lbl_patente_gc.Text = "lbl_patente_gc"
        '
        'lbl_movil_gc
        '
        Me.lbl_movil_gc.AutoSize = True
        Me.lbl_movil_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_movil_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_movil_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_movil_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_movil_gc.Location = New System.Drawing.Point(152, 124)
        Me.lbl_movil_gc.Name = "lbl_movil_gc"
        Me.lbl_movil_gc.Size = New System.Drawing.Size(75, 17)
        Me.lbl_movil_gc.TabIndex = 102
        Me.lbl_movil_gc.Text = "lbl_movil_gc"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Silver
        Me.Label63.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.DarkRed
        Me.Label63.Location = New System.Drawing.Point(186, 102)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(41, 15)
        Me.Label63.TabIndex = 101
        Me.Label63.Text = "Movil:"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.BackColor = System.Drawing.Color.Silver
        Me.Label95.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.DarkRed
        Me.Label95.Location = New System.Drawing.Point(966, 34)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(44, 15)
        Me.Label95.TabIndex = 100
        Me.Label95.Text = "Salida:"
        '
        'lbl_fe_reg_gc
        '
        Me.lbl_fe_reg_gc.AutoSize = True
        Me.lbl_fe_reg_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_fe_reg_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_reg_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fe_reg_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_reg_gc.Location = New System.Drawing.Point(483, 124)
        Me.lbl_fe_reg_gc.Name = "lbl_fe_reg_gc"
        Me.lbl_fe_reg_gc.Size = New System.Drawing.Size(80, 17)
        Me.lbl_fe_reg_gc.TabIndex = 99
        Me.lbl_fe_reg_gc.Text = "lbl_fe_reg_gc"
        '
        'lbl_obs_desp_gc
        '
        Me.lbl_obs_desp_gc.AutoSize = True
        Me.lbl_obs_desp_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_obs_desp_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_obs_desp_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_obs_desp_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_obs_desp_gc.Location = New System.Drawing.Point(569, 124)
        Me.lbl_obs_desp_gc.Name = "lbl_obs_desp_gc"
        Me.lbl_obs_desp_gc.Size = New System.Drawing.Size(96, 17)
        Me.lbl_obs_desp_gc.TabIndex = 98
        Me.lbl_obs_desp_gc.Text = "lbl_obs_desp_gc"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Silver
        Me.Label94.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.DarkRed
        Me.Label94.Location = New System.Drawing.Point(762, 102)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(149, 15)
        Me.Label94.TabIndex = 97
        Me.Label94.Text = "Observacion de Despacho:"
        '
        'lbl_despach_gc
        '
        Me.lbl_despach_gc.AutoSize = True
        Me.lbl_despach_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_despach_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_despach_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_despach_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_despach_gc.Location = New System.Drawing.Point(24, 124)
        Me.lbl_despach_gc.Name = "lbl_despach_gc"
        Me.lbl_despach_gc.Size = New System.Drawing.Size(114, 17)
        Me.lbl_despach_gc.TabIndex = 96
        Me.lbl_despach_gc.Text = "lbl_despachador_gc"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.BackColor = System.Drawing.Color.Silver
        Me.Label93.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.DarkRed
        Me.Label93.Location = New System.Drawing.Point(21, 102)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(82, 15)
        Me.Label93.TabIndex = 95
        Me.Label93.Text = "Despachador:"
        '
        'lbl_chofer_gc
        '
        Me.lbl_chofer_gc.AutoSize = True
        Me.lbl_chofer_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_chofer_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_chofer_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chofer_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_chofer_gc.Location = New System.Drawing.Point(832, 55)
        Me.lbl_chofer_gc.Name = "lbl_chofer_gc"
        Me.lbl_chofer_gc.Size = New System.Drawing.Size(80, 17)
        Me.lbl_chofer_gc.TabIndex = 94
        Me.lbl_chofer_gc.Text = "lbl_chofer_gc"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Silver
        Me.Label92.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.DarkRed
        Me.Label92.Location = New System.Drawing.Point(864, 34)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(47, 15)
        Me.Label92.TabIndex = 93
        Me.Label92.Text = "Chofer:"
        '
        'lbl_ciudad_gc
        '
        Me.lbl_ciudad_gc.AutoSize = True
        Me.lbl_ciudad_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_ciudad_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ciudad_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ciudad_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ciudad_gc.Location = New System.Drawing.Point(735, 55)
        Me.lbl_ciudad_gc.Name = "lbl_ciudad_gc"
        Me.lbl_ciudad_gc.Size = New System.Drawing.Size(80, 17)
        Me.lbl_ciudad_gc.TabIndex = 75
        Me.lbl_ciudad_gc.Text = "lbl_ciudad_gc"
        '
        'lbl_transporte_gc
        '
        Me.lbl_transporte_gc.AutoSize = True
        Me.lbl_transporte_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_transporte_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_transporte_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transporte_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_transporte_gc.Location = New System.Drawing.Point(605, 55)
        Me.lbl_transporte_gc.Name = "lbl_transporte_gc"
        Me.lbl_transporte_gc.Size = New System.Drawing.Size(104, 17)
        Me.lbl_transporte_gc.TabIndex = 92
        Me.lbl_transporte_gc.Text = "lbl_transporte_gc"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Silver
        Me.Label91.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.DarkRed
        Me.Label91.Location = New System.Drawing.Point(612, 34)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(71, 15)
        Me.Label91.TabIndex = 91
        Me.Label91.Text = "Transporte:"
        '
        'lbl_peso_gc
        '
        Me.lbl_peso_gc.AutoSize = True
        Me.lbl_peso_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_peso_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_peso_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_peso_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_peso_gc.Location = New System.Drawing.Point(513, 55)
        Me.lbl_peso_gc.Name = "lbl_peso_gc"
        Me.lbl_peso_gc.Size = New System.Drawing.Size(71, 17)
        Me.lbl_peso_gc.TabIndex = 90
        Me.lbl_peso_gc.Text = "lbl_peso_gc"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.Silver
        Me.Label90.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.DarkRed
        Me.Label90.Location = New System.Drawing.Point(516, 34)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(67, 15)
        Me.Label90.TabIndex = 89
        Me.Label90.Text = "Peso (GRS.)"
        '
        'lbl_ncedible_gc
        '
        Me.lbl_ncedible_gc.AutoSize = True
        Me.lbl_ncedible_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_ncedible_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_ncedible_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ncedible_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_ncedible_gc.Location = New System.Drawing.Point(362, 124)
        Me.lbl_ncedible_gc.Name = "lbl_ncedible_gc"
        Me.lbl_ncedible_gc.Size = New System.Drawing.Size(91, 17)
        Me.lbl_ncedible_gc.TabIndex = 88
        Me.lbl_ncedible_gc.Text = "lbl_ncedible_gc"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.BackColor = System.Drawing.Color.Silver
        Me.Label88.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.DarkRed
        Me.Label88.Location = New System.Drawing.Point(359, 102)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(74, 15)
        Me.Label88.TabIndex = 87
        Me.Label88.Text = "Nro Cedible:"
        '
        'lbl_nbulto_gc
        '
        Me.lbl_nbulto_gc.AutoSize = True
        Me.lbl_nbulto_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nbulto_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nbulto_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nbulto_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nbulto_gc.Location = New System.Drawing.Point(426, 55)
        Me.lbl_nbulto_gc.Name = "lbl_nbulto_gc"
        Me.lbl_nbulto_gc.Size = New System.Drawing.Size(81, 17)
        Me.lbl_nbulto_gc.TabIndex = 86
        Me.lbl_nbulto_gc.Text = "lbl_nbulto_gc"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.BackColor = System.Drawing.Color.Silver
        Me.Label86.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.DarkRed
        Me.Label86.Location = New System.Drawing.Point(432, 34)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(69, 15)
        Me.Label86.TabIndex = 85
        Me.Label86.Text = "Nro Bultos:"
        '
        'lbl_nro_flete_gc
        '
        Me.lbl_nro_flete_gc.AutoSize = True
        Me.lbl_nro_flete_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nro_flete_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nro_flete_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nro_flete_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nro_flete_gc.Location = New System.Drawing.Point(324, 55)
        Me.lbl_nro_flete_gc.Name = "lbl_nro_flete_gc"
        Me.lbl_nro_flete_gc.Size = New System.Drawing.Size(96, 17)
        Me.lbl_nro_flete_gc.TabIndex = 84
        Me.lbl_nro_flete_gc.Text = "lbl_nro_flete_gc"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.BackColor = System.Drawing.Color.Silver
        Me.Label85.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.DarkRed
        Me.Label85.Location = New System.Drawing.Point(321, 34)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(77, 15)
        Me.Label85.TabIndex = 83
        Me.Label85.Text = "Nro de Flete:"
        '
        'lbl_nguia_gc
        '
        Me.lbl_nguia_gc.AutoSize = True
        Me.lbl_nguia_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nguia_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nguia_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nguia_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nguia_gc.Location = New System.Drawing.Point(132, 55)
        Me.lbl_nguia_gc.Name = "lbl_nguia_gc"
        Me.lbl_nguia_gc.Size = New System.Drawing.Size(74, 17)
        Me.lbl_nguia_gc.TabIndex = 82
        Me.lbl_nguia_gc.Text = "lbl_nguia_gc"
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.BackColor = System.Drawing.Color.Silver
        Me.Label84.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.DarkRed
        Me.Label84.Location = New System.Drawing.Point(140, 34)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(66, 15)
        Me.Label84.TabIndex = 81
        Me.Label84.Text = "NRO GUIA:"
        '
        'lbl_fe_desp_gc
        '
        Me.lbl_fe_desp_gc.AutoSize = True
        Me.lbl_fe_desp_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_fe_desp_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_desp_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fe_desp_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_desp_gc.Location = New System.Drawing.Point(217, 55)
        Me.lbl_fe_desp_gc.Name = "lbl_fe_desp_gc"
        Me.lbl_fe_desp_gc.Size = New System.Drawing.Size(88, 17)
        Me.lbl_fe_desp_gc.TabIndex = 80
        Me.lbl_fe_desp_gc.Text = "lbl_fe_desp_gc"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.BackColor = System.Drawing.Color.Silver
        Me.Label65.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.DarkRed
        Me.Label65.Location = New System.Drawing.Point(214, 34)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(97, 15)
        Me.Label65.TabIndex = 79
        Me.Label65.Text = "Fecha Despacho:"
        '
        'lbl_nrodp_gc
        '
        Me.lbl_nrodp_gc.AutoSize = True
        Me.lbl_nrodp_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nrodp_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrodp_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nrodp_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nrodp_gc.Location = New System.Drawing.Point(24, 55)
        Me.lbl_nrodp_gc.Name = "lbl_nrodp_gc"
        Me.lbl_nrodp_gc.Size = New System.Drawing.Size(78, 17)
        Me.lbl_nrodp_gc.TabIndex = 78
        Me.lbl_nrodp_gc.Text = "lbl_nrodp_gc"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Silver
        Me.Label61.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.DarkRed
        Me.Label61.Location = New System.Drawing.Point(21, 34)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(97, 15)
        Me.Label61.TabIndex = 77
        Me.Label61.Text = "NRO DESPACHO:"
        '
        'lbl_salida_gc
        '
        Me.lbl_salida_gc.AutoSize = True
        Me.lbl_salida_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_salida_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_salida_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_salida_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_salida_gc.Location = New System.Drawing.Point(953, 55)
        Me.lbl_salida_gc.Name = "lbl_salida_gc"
        Me.lbl_salida_gc.Size = New System.Drawing.Size(75, 17)
        Me.lbl_salida_gc.TabIndex = 76
        Me.lbl_salida_gc.Text = "lbl_salida_gc"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Silver
        Me.Label67.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.DarkRed
        Me.Label67.Location = New System.Drawing.Point(475, 102)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(89, 15)
        Me.Label67.TabIndex = 70
        Me.Label67.Text = "Fecha Reg Guia"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Silver
        Me.Label69.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.DarkRed
        Me.Label69.Location = New System.Drawing.Point(732, 34)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(45, 15)
        Me.Label69.TabIndex = 68
        Me.Label69.Text = "Ciudad"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_destino_guia_gc)
        Me.GroupBox5.Controls.Add(Me.Label109)
        Me.GroupBox5.Controls.Add(Me.lbl_tipo_guia_gc)
        Me.GroupBox5.Controls.Add(Me.Label108)
        Me.GroupBox5.Controls.Add(Me.lbl_direc_gc)
        Me.GroupBox5.Controls.Add(Me.Label96)
        Me.GroupBox5.Controls.Add(Me.lbl_noc_gc)
        Me.GroupBox5.Controls.Add(Me.Label59)
        Me.GroupBox5.Controls.Add(Me.lbl_fe_docto_gc)
        Me.GroupBox5.Controls.Add(Me.Label57)
        Me.GroupBox5.Controls.Add(Me.lbl_nrofact_gc)
        Me.GroupBox5.Controls.Add(Me.Label55)
        Me.GroupBox5.Controls.Add(Me.lbl_monto_gc)
        Me.GroupBox5.Controls.Add(Me.lbl_vend_gc)
        Me.GroupBox5.Controls.Add(Me.lbl_nombre_gc)
        Me.GroupBox5.Controls.Add(Me.lbl_rut_gc)
        Me.GroupBox5.Controls.Add(Me.Label66)
        Me.GroupBox5.Controls.Add(Me.Label68)
        Me.GroupBox5.Controls.Add(Me.Label70)
        Me.GroupBox5.Controls.Add(Me.Label71)
        Me.GroupBox5.Location = New System.Drawing.Point(180, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(872, 165)
        Me.GroupBox5.TabIndex = 84
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DATOS DE LA FACTURA"
        '
        'lbl_destino_guia_gc
        '
        Me.lbl_destino_guia_gc.AutoSize = True
        Me.lbl_destino_guia_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_destino_guia_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_destino_guia_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destino_guia_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_destino_guia_gc.Location = New System.Drawing.Point(706, 116)
        Me.lbl_destino_guia_gc.Name = "lbl_destino_guia_gc"
        Me.lbl_destino_guia_gc.Size = New System.Drawing.Size(114, 17)
        Me.lbl_destino_guia_gc.TabIndex = 105
        Me.lbl_destino_guia_gc.Text = "lbl_destino_guia_gc"
        '
        'Label109
        '
        Me.Label109.AutoSize = True
        Me.Label109.BackColor = System.Drawing.Color.Silver
        Me.Label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label109.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.ForeColor = System.Drawing.Color.DarkRed
        Me.Label109.Location = New System.Drawing.Point(703, 95)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(107, 17)
        Me.Label109.TabIndex = 104
        Me.Label109.Text = "DESTINO DE GUIA:"
        '
        'lbl_tipo_guia_gc
        '
        Me.lbl_tipo_guia_gc.AutoSize = True
        Me.lbl_tipo_guia_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_tipo_guia_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_tipo_guia_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_guia_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_tipo_guia_gc.Location = New System.Drawing.Point(546, 116)
        Me.lbl_tipo_guia_gc.Name = "lbl_tipo_guia_gc"
        Me.lbl_tipo_guia_gc.Size = New System.Drawing.Size(95, 17)
        Me.lbl_tipo_guia_gc.TabIndex = 103
        Me.lbl_tipo_guia_gc.Text = "lbl_tipo_guia_gc"
        '
        'Label108
        '
        Me.Label108.AutoSize = True
        Me.Label108.BackColor = System.Drawing.Color.Silver
        Me.Label108.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label108.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.ForeColor = System.Drawing.Color.DarkRed
        Me.Label108.Location = New System.Drawing.Point(543, 95)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(85, 17)
        Me.Label108.TabIndex = 102
        Me.Label108.Text = "TIPO DE GUIA:"
        '
        'lbl_direc_gc
        '
        Me.lbl_direc_gc.AutoSize = True
        Me.lbl_direc_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_direc_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_direc_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_direc_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_direc_gc.Location = New System.Drawing.Point(297, 116)
        Me.lbl_direc_gc.Name = "lbl_direc_gc"
        Me.lbl_direc_gc.Size = New System.Drawing.Size(72, 17)
        Me.lbl_direc_gc.TabIndex = 101
        Me.lbl_direc_gc.Text = "lbl_direc_gc"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.Color.Silver
        Me.Label96.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label96.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.DarkRed
        Me.Label96.Location = New System.Drawing.Point(294, 95)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(135, 17)
        Me.Label96.TabIndex = 98
        Me.Label96.Text = "Dirección de Despacho:"
        '
        'lbl_noc_gc
        '
        Me.lbl_noc_gc.AutoSize = True
        Me.lbl_noc_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_noc_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_noc_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noc_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_noc_gc.Location = New System.Drawing.Point(756, 55)
        Me.lbl_noc_gc.Name = "lbl_noc_gc"
        Me.lbl_noc_gc.Size = New System.Drawing.Size(64, 17)
        Me.lbl_noc_gc.TabIndex = 97
        Me.lbl_noc_gc.Text = "lbl_noc_gc"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Silver
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label59.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.DarkRed
        Me.Label59.Location = New System.Drawing.Point(755, 36)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(55, 17)
        Me.Label59.TabIndex = 96
        Me.Label59.Text = "Nro O.C."
        '
        'lbl_fe_docto_gc
        '
        Me.lbl_fe_docto_gc.AutoSize = True
        Me.lbl_fe_docto_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_fe_docto_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_fe_docto_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fe_docto_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_fe_docto_gc.Location = New System.Drawing.Point(522, 55)
        Me.lbl_fe_docto_gc.Name = "lbl_fe_docto_gc"
        Me.lbl_fe_docto_gc.Size = New System.Drawing.Size(93, 17)
        Me.lbl_fe_docto_gc.TabIndex = 95
        Me.lbl_fe_docto_gc.Text = "lbl_fe_docto_gc"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Silver
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label57.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.DarkRed
        Me.Label57.Location = New System.Drawing.Point(519, 35)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(78, 17)
        Me.Label57.TabIndex = 94
        Me.Label57.Text = "Fecha Dcto. :"
        '
        'lbl_nrofact_gc
        '
        Me.lbl_nrofact_gc.AutoSize = True
        Me.lbl_nrofact_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nrofact_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrofact_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nrofact_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nrofact_gc.Location = New System.Drawing.Point(420, 55)
        Me.lbl_nrofact_gc.Name = "lbl_nrofact_gc"
        Me.lbl_nrofact_gc.Size = New System.Drawing.Size(84, 17)
        Me.lbl_nrofact_gc.TabIndex = 93
        Me.lbl_nrofact_gc.Text = "lbl_nrofact_gc"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Silver
        Me.Label55.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label55.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.DarkRed
        Me.Label55.Location = New System.Drawing.Point(429, 35)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(77, 17)
        Me.Label55.TabIndex = 92
        Me.Label55.Text = "Nro Factura:"
        '
        'lbl_monto_gc
        '
        Me.lbl_monto_gc.AutoSize = True
        Me.lbl_monto_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_monto_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_monto_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monto_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_monto_gc.Location = New System.Drawing.Point(630, 55)
        Me.lbl_monto_gc.Name = "lbl_monto_gc"
        Me.lbl_monto_gc.Size = New System.Drawing.Size(82, 17)
        Me.lbl_monto_gc.TabIndex = 91
        Me.lbl_monto_gc.Text = "lbl_monto_gc"
        '
        'lbl_vend_gc
        '
        Me.lbl_vend_gc.AutoSize = True
        Me.lbl_vend_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_vend_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_vend_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vend_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_vend_gc.Location = New System.Drawing.Point(53, 116)
        Me.lbl_vend_gc.Name = "lbl_vend_gc"
        Me.lbl_vend_gc.Size = New System.Drawing.Size(72, 17)
        Me.lbl_vend_gc.TabIndex = 90
        Me.lbl_vend_gc.Text = "lbl_vend_gc"
        '
        'lbl_nombre_gc
        '
        Me.lbl_nombre_gc.AutoSize = True
        Me.lbl_nombre_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nombre_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nombre_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nombre_gc.Location = New System.Drawing.Point(143, 55)
        Me.lbl_nombre_gc.Name = "lbl_nombre_gc"
        Me.lbl_nombre_gc.Size = New System.Drawing.Size(89, 17)
        Me.lbl_nombre_gc.TabIndex = 89
        Me.lbl_nombre_gc.Text = "lbl_nombre_gc"
        '
        'lbl_rut_gc
        '
        Me.lbl_rut_gc.AutoSize = True
        Me.lbl_rut_gc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_rut_gc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_rut_gc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_rut_gc.ForeColor = System.Drawing.Color.Navy
        Me.lbl_rut_gc.Location = New System.Drawing.Point(56, 55)
        Me.lbl_rut_gc.Name = "lbl_rut_gc"
        Me.lbl_rut_gc.Size = New System.Drawing.Size(62, 17)
        Me.lbl_rut_gc.TabIndex = 88
        Me.lbl_rut_gc.Text = "lbl_rut_gc"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.BackColor = System.Drawing.Color.Silver
        Me.Label66.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label66.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.DarkRed
        Me.Label66.Location = New System.Drawing.Point(53, 95)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(67, 17)
        Me.Label66.TabIndex = 87
        Me.Label66.Text = "Vendedor:"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Silver
        Me.Label68.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label68.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.DarkRed
        Me.Label68.Location = New System.Drawing.Point(633, 35)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(81, 17)
        Me.Label68.TabIndex = 86
        Me.Label68.Text = "Monto Dcto.:"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Silver
        Me.Label70.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label70.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.DarkRed
        Me.Label70.Location = New System.Drawing.Point(232, 35)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(52, 17)
        Me.Label70.TabIndex = 85
        Me.Label70.Text = "Cliente:"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Silver
        Me.Label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label71.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.DarkRed
        Me.Label71.Location = New System.Drawing.Point(53, 35)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(74, 17)
        Me.Label71.TabIndex = 84
        Me.Label71.Text = "Rut Cliente:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Silver
        Me.CheckBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBox1.Location = New System.Drawing.Point(65, 77)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 19)
        Me.CheckBox1.TabIndex = 45
        Me.CheckBox1.Text = "Año Anterior"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'txt_guia_reing_gc
        '
        Me.txt_guia_reing_gc.Location = New System.Drawing.Point(43, 48)
        Me.txt_guia_reing_gc.Name = "txt_guia_reing_gc"
        Me.txt_guia_reing_gc.Size = New System.Drawing.Size(87, 23)
        Me.txt_guia_reing_gc.TabIndex = 44
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.Location = New System.Drawing.Point(28, 30)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(121, 15)
        Me.Label46.TabIndex = 43
        Me.Label46.Text = "Ingrese Nro de Guia :"
        '
        'TP4
        '
        Me.TP4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.TP4.Controls.Add(Me.lbl_usr_reing_gt)
        Me.TP4.Controls.Add(Me.Label105)
        Me.TP4.Controls.Add(Me.lbl_nrodp_gt)
        Me.TP4.Controls.Add(Me.Label104)
        Me.TP4.Controls.Add(Me.lbl_nrodpid)
        Me.TP4.Controls.Add(Me.txt_obs_reing_gt)
        Me.TP4.Controls.Add(Me.Label103)
        Me.TP4.Controls.Add(Me.cbo_recep_gt)
        Me.TP4.Controls.Add(Me.Label101)
        Me.TP4.Controls.Add(Me.Label102)
        Me.TP4.Controls.Add(Me.msk_fe_recep_gt)
        Me.TP4.Controls.Add(Me.Label89)
        Me.TP4.Controls.Add(Me.cmd_cancelar_gt)
        Me.TP4.Controls.Add(Me.cmd_Limpiar_gt)
        Me.TP4.Controls.Add(Me.cmd_modif_gt)
        Me.TP4.Controls.Add(Me.cmd_actualizar_gt)
        Me.TP4.Controls.Add(Me.lbl_usuario_gt)
        Me.TP4.Controls.Add(Me.Label87)
        Me.TP4.Controls.Add(Me.txt_obs_ingreso)
        Me.TP4.Controls.Add(Me.txt_guia_gt)
        Me.TP4.Controls.Add(Me.Label49)
        Me.TP4.Controls.Add(Me.GroupBox8)
        Me.TP4.Controls.Add(Me.Label76)
        Me.TP4.Controls.Add(Me.txt_nrobultos_gt)
        Me.TP4.Controls.Add(Me.Label75)
        Me.TP4.Controls.Add(Me.txt_peso_gt)
        Me.TP4.Controls.Add(Me.Label74)
        Me.TP4.Controls.Add(Me.cbo_chofer_gt)
        Me.TP4.Controls.Add(Me.Label73)
        Me.TP4.Controls.Add(Me.lbl_patente_gt)
        Me.TP4.Controls.Add(Me.cbo_transp_gt)
        Me.TP4.Controls.Add(Me.Label72)
        Me.TP4.Controls.Add(Me.msk_fe_desp_gt)
        Me.TP4.Controls.Add(Me.msk_fe_gt)
        Me.TP4.Controls.Add(Me.txt_direccion_gt)
        Me.TP4.Controls.Add(Me.cbo_empresa_gt)
        Me.TP4.Controls.Add(Me.cbo_rut_emp_gt)
        Me.TP4.Controls.Add(Me.Label78)
        Me.TP4.Controls.Add(Me.Label79)
        Me.TP4.Controls.Add(Me.Label81)
        Me.TP4.Controls.Add(Me.Label82)
        Me.TP4.Controls.Add(Me.Label83)
        Me.TP4.Controls.Add(Me.Label53)
        Me.TP4.Controls.Add(Me.CheckBox2)
        Me.TP4.Location = New System.Drawing.Point(4, 24)
        Me.TP4.Name = "TP4"
        Me.TP4.Size = New System.Drawing.Size(1067, 607)
        Me.TP4.TabIndex = 3
        Me.TP4.Text = "Reing. Guias Trasp"
        '
        'lbl_usr_reing_gt
        '
        Me.lbl_usr_reing_gt.AutoSize = True
        Me.lbl_usr_reing_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_usr_reing_gt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_usr_reing_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usr_reing_gt.ForeColor = System.Drawing.Color.Maroon
        Me.lbl_usr_reing_gt.Location = New System.Drawing.Point(847, 474)
        Me.lbl_usr_reing_gt.Name = "lbl_usr_reing_gt"
        Me.lbl_usr_reing_gt.Size = New System.Drawing.Size(96, 17)
        Me.lbl_usr_reing_gt.TabIndex = 115
        Me.lbl_usr_reing_gt.Text = "lbl_usr_reing_gt"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.BackColor = System.Drawing.Color.Silver
        Me.Label105.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label105.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.Color.DarkRed
        Me.Label105.Location = New System.Drawing.Point(843, 451)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(111, 17)
        Me.Label105.TabIndex = 114
        Me.Label105.Text = "Usuario Reingreso:"
        '
        'lbl_nrodp_gt
        '
        Me.lbl_nrodp_gt.AutoSize = True
        Me.lbl_nrodp_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_nrodp_gt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_nrodp_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nrodp_gt.ForeColor = System.Drawing.Color.Navy
        Me.lbl_nrodp_gt.Location = New System.Drawing.Point(210, 76)
        Me.lbl_nrodp_gt.Name = "lbl_nrodp_gt"
        Me.lbl_nrodp_gt.Size = New System.Drawing.Size(78, 17)
        Me.lbl_nrodp_gt.TabIndex = 113
        Me.lbl_nrodp_gt.Text = "lbl_nrodp_gt"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label104.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label104.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.Color.Navy
        Me.Label104.Location = New System.Drawing.Point(214, 57)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(76, 17)
        Me.Label104.TabIndex = 112
        Me.Label104.Text = "NRO DP INT:"
        '
        'lbl_nrodpid
        '
        Me.lbl_nrodpid.AutoSize = True
        Me.lbl_nrodpid.Location = New System.Drawing.Point(889, 394)
        Me.lbl_nrodpid.Name = "lbl_nrodpid"
        Me.lbl_nrodpid.Size = New System.Drawing.Size(72, 15)
        Me.lbl_nrodpid.TabIndex = 111
        Me.lbl_nrodpid.Text = "lbl_nrodpid"
        Me.lbl_nrodpid.Visible = False
        '
        'txt_obs_reing_gt
        '
        Me.txt_obs_reing_gt.Location = New System.Drawing.Point(435, 472)
        Me.txt_obs_reing_gt.Name = "txt_obs_reing_gt"
        Me.txt_obs_reing_gt.Size = New System.Drawing.Size(370, 23)
        Me.txt_obs_reing_gt.TabIndex = 110
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.BackColor = System.Drawing.Color.Silver
        Me.Label103.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label103.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.ForeColor = System.Drawing.Color.DarkRed
        Me.Label103.Location = New System.Drawing.Point(495, 451)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(154, 17)
        Me.Label103.TabIndex = 109
        Me.Label103.Text = "Observación de Reingreso:"
        '
        'cbo_recep_gt
        '
        Me.cbo_recep_gt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_recep_gt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_recep_gt.FormattingEnabled = True
        Me.cbo_recep_gt.Location = New System.Drawing.Point(260, 474)
        Me.cbo_recep_gt.Name = "cbo_recep_gt"
        Me.cbo_recep_gt.Size = New System.Drawing.Size(73, 23)
        Me.cbo_recep_gt.TabIndex = 108
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.BackColor = System.Drawing.Color.Silver
        Me.Label101.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label101.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.ForeColor = System.Drawing.Color.DarkRed
        Me.Label101.Location = New System.Drawing.Point(214, 451)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(199, 17)
        Me.Label101.TabIndex = 107
        Me.Label101.Text = "Confirma Recepcion de Mercaderia"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.BackColor = System.Drawing.Color.Silver
        Me.Label102.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label102.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.ForeColor = System.Drawing.Color.DarkRed
        Me.Label102.Location = New System.Drawing.Point(65, 451)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(119, 17)
        Me.Label102.TabIndex = 106
        Me.Label102.Text = "Fecha de Recepcion:"
        '
        'msk_fe_recep_gt
        '
        Me.msk_fe_recep_gt.Location = New System.Drawing.Point(73, 472)
        Me.msk_fe_recep_gt.Mask = "0000-00-00"
        Me.msk_fe_recep_gt.Name = "msk_fe_recep_gt"
        Me.msk_fe_recep_gt.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_recep_gt.TabIndex = 105
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label89.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.Maroon
        Me.Label89.Location = New System.Drawing.Point(339, 418)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(260, 15)
        Me.Label89.TabIndex = 104
        Me.Label89.Text = "INGRESE LOS DATOS DE REINGRESO DE LA GUIA"
        '
        'cmd_cancelar_gt
        '
        Me.cmd_cancelar_gt.Image = Global.Despachos.My.Resources.Resources.cancel
        Me.cmd_cancelar_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_cancelar_gt.Location = New System.Drawing.Point(671, 514)
        Me.cmd_cancelar_gt.Name = "cmd_cancelar_gt"
        Me.cmd_cancelar_gt.Size = New System.Drawing.Size(105, 48)
        Me.cmd_cancelar_gt.TabIndex = 102
        Me.cmd_cancelar_gt.Text = "Cancelar"
        Me.cmd_cancelar_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancelar_gt.UseVisualStyleBackColor = True
        '
        'cmd_Limpiar_gt
        '
        Me.cmd_Limpiar_gt.Image = Global.Despachos.My.Resources.Resources.undo
        Me.cmd_Limpiar_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Limpiar_gt.Location = New System.Drawing.Point(518, 516)
        Me.cmd_Limpiar_gt.Name = "cmd_Limpiar_gt"
        Me.cmd_Limpiar_gt.Size = New System.Drawing.Size(105, 46)
        Me.cmd_Limpiar_gt.TabIndex = 101
        Me.cmd_Limpiar_gt.Text = "Limpiar"
        Me.cmd_Limpiar_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Limpiar_gt.UseVisualStyleBackColor = True
        '
        'cmd_modif_gt
        '
        Me.cmd_modif_gt.Image = Global.Despachos.My.Resources.Resources.update
        Me.cmd_modif_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_modif_gt.Location = New System.Drawing.Point(368, 515)
        Me.cmd_modif_gt.Name = "cmd_modif_gt"
        Me.cmd_modif_gt.Size = New System.Drawing.Size(105, 47)
        Me.cmd_modif_gt.TabIndex = 100
        Me.cmd_modif_gt.Text = "Modificar"
        Me.cmd_modif_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_modif_gt.UseVisualStyleBackColor = True
        '
        'cmd_actualizar_gt
        '
        Me.cmd_actualizar_gt.Image = Global.Despachos.My.Resources.Resources.refresh
        Me.cmd_actualizar_gt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_actualizar_gt.Location = New System.Drawing.Point(210, 514)
        Me.cmd_actualizar_gt.Name = "cmd_actualizar_gt"
        Me.cmd_actualizar_gt.Size = New System.Drawing.Size(105, 48)
        Me.cmd_actualizar_gt.TabIndex = 99
        Me.cmd_actualizar_gt.Text = "Actualizar Registro"
        Me.cmd_actualizar_gt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_actualizar_gt.UseVisualStyleBackColor = True
        '
        'lbl_usuario_gt
        '
        Me.lbl_usuario_gt.AutoSize = True
        Me.lbl_usuario_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_usuario_gt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_usuario_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario_gt.Location = New System.Drawing.Point(419, 386)
        Me.lbl_usuario_gt.Name = "lbl_usuario_gt"
        Me.lbl_usuario_gt.Size = New System.Drawing.Size(85, 17)
        Me.lbl_usuario_gt.TabIndex = 98
        Me.lbl_usuario_gt.Text = "lbl_usuario_gt"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.BackColor = System.Drawing.Color.Silver
        Me.Label87.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label87.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.DarkRed
        Me.Label87.Location = New System.Drawing.Point(415, 367)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(125, 17)
        Me.Label87.TabIndex = 97
        Me.Label87.Text = "Usuario que Registra:"
        '
        'txt_obs_ingreso
        '
        Me.txt_obs_ingreso.Location = New System.Drawing.Point(59, 383)
        Me.txt_obs_ingreso.Name = "txt_obs_ingreso"
        Me.txt_obs_ingreso.Size = New System.Drawing.Size(309, 23)
        Me.txt_obs_ingreso.TabIndex = 96
        '
        'txt_guia_gt
        '
        Me.txt_guia_gt.Location = New System.Drawing.Point(537, 58)
        Me.txt_guia_gt.Name = "txt_guia_gt"
        Me.txt_guia_gt.Size = New System.Drawing.Size(99, 23)
        Me.txt_guia_gt.TabIndex = 95
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label49.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label49.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Navy
        Me.Label49.Location = New System.Drawing.Point(443, 57)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(81, 17)
        Me.Label49.TabIndex = 94
        Me.Label49.Text = "NRO DE GUIA"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cbo_bod_destino_gt)
        Me.GroupBox8.Controls.Add(Me.Label80)
        Me.GroupBox8.Controls.Add(Me.cbo_bod_origen_gt)
        Me.GroupBox8.Controls.Add(Me.Label77)
        Me.GroupBox8.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(88, 255)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(817, 97)
        Me.GroupBox8.TabIndex = 93
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "TRASPASOS ENTRE:"
        '
        'cbo_bod_destino_gt
        '
        Me.cbo_bod_destino_gt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_bod_destino_gt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_bod_destino_gt.FormattingEnabled = True
        Me.cbo_bod_destino_gt.Location = New System.Drawing.Point(410, 53)
        Me.cbo_bod_destino_gt.Name = "cbo_bod_destino_gt"
        Me.cbo_bod_destino_gt.Size = New System.Drawing.Size(198, 23)
        Me.cbo_bod_destino_gt.TabIndex = 3
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label80.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label80.Location = New System.Drawing.Point(445, 35)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(105, 17)
        Me.Label80.TabIndex = 2
        Me.Label80.Text = "BODEGA DESTINO"
        '
        'cbo_bod_origen_gt
        '
        Me.cbo_bod_origen_gt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_bod_origen_gt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_bod_origen_gt.FormattingEnabled = True
        Me.cbo_bod_origen_gt.Location = New System.Drawing.Point(77, 53)
        Me.cbo_bod_origen_gt.Name = "cbo_bod_origen_gt"
        Me.cbo_bod_origen_gt.Size = New System.Drawing.Size(175, 23)
        Me.cbo_bod_origen_gt.TabIndex = 1
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label77.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label77.Location = New System.Drawing.Point(101, 35)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(100, 17)
        Me.Label77.TabIndex = 0
        Me.Label77.Text = "BODEGA ORIGEN"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.BackColor = System.Drawing.Color.Silver
        Me.Label76.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label76.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.DarkRed
        Me.Label76.Location = New System.Drawing.Point(56, 367)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(140, 17)
        Me.Label76.TabIndex = 92
        Me.Label76.Text = "Observación de Ingreso:"
        '
        'txt_nrobultos_gt
        '
        Me.txt_nrobultos_gt.Location = New System.Drawing.Point(869, 225)
        Me.txt_nrobultos_gt.Name = "txt_nrobultos_gt"
        Me.txt_nrobultos_gt.Size = New System.Drawing.Size(71, 23)
        Me.txt_nrobultos_gt.TabIndex = 91
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Silver
        Me.Label75.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label75.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.DarkRed
        Me.Label75.Location = New System.Drawing.Point(871, 197)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(71, 17)
        Me.Label75.TabIndex = 90
        Me.Label75.Text = "Nro Bultos:"
        '
        'txt_peso_gt
        '
        Me.txt_peso_gt.Location = New System.Drawing.Point(726, 226)
        Me.txt_peso_gt.Name = "txt_peso_gt"
        Me.txt_peso_gt.Size = New System.Drawing.Size(71, 23)
        Me.txt_peso_gt.TabIndex = 89
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Silver
        Me.Label74.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label74.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.DarkRed
        Me.Label74.Location = New System.Drawing.Point(723, 197)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(71, 17)
        Me.Label74.TabIndex = 88
        Me.Label74.Text = "Peso (GRS):"
        '
        'cbo_chofer_gt
        '
        Me.cbo_chofer_gt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_chofer_gt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_chofer_gt.FormattingEnabled = True
        Me.cbo_chofer_gt.Location = New System.Drawing.Point(515, 225)
        Me.cbo_chofer_gt.Name = "cbo_chofer_gt"
        Me.cbo_chofer_gt.Size = New System.Drawing.Size(192, 23)
        Me.cbo_chofer_gt.TabIndex = 87
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.BackColor = System.Drawing.Color.Silver
        Me.Label73.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label73.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.DarkRed
        Me.Label73.Location = New System.Drawing.Point(573, 197)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(50, 17)
        Me.Label73.TabIndex = 86
        Me.Label73.Text = "Chofer:"
        '
        'lbl_patente_gt
        '
        Me.lbl_patente_gt.AutoSize = True
        Me.lbl_patente_gt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_patente_gt.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_patente_gt.Location = New System.Drawing.Point(415, 197)
        Me.lbl_patente_gt.Name = "lbl_patente_gt"
        Me.lbl_patente_gt.Size = New System.Drawing.Size(87, 15)
        Me.lbl_patente_gt.TabIndex = 85
        Me.lbl_patente_gt.Text = "lbl_patente_gt"
        '
        'cbo_transp_gt
        '
        Me.cbo_transp_gt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_transp_gt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_transp_gt.FormattingEnabled = True
        Me.cbo_transp_gt.Location = New System.Drawing.Point(296, 226)
        Me.cbo_transp_gt.Name = "cbo_transp_gt"
        Me.cbo_transp_gt.Size = New System.Drawing.Size(206, 23)
        Me.cbo_transp_gt.TabIndex = 84
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Silver
        Me.Label72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label72.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.DarkRed
        Me.Label72.Location = New System.Drawing.Point(339, 197)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(72, 17)
        Me.Label72.TabIndex = 83
        Me.Label72.Text = "Transporte:"
        '
        'msk_fe_desp_gt
        '
        Me.msk_fe_desp_gt.Location = New System.Drawing.Point(192, 225)
        Me.msk_fe_desp_gt.Mask = "0000-00-00"
        Me.msk_fe_desp_gt.Name = "msk_fe_desp_gt"
        Me.msk_fe_desp_gt.Size = New System.Drawing.Size(71, 23)
        Me.msk_fe_desp_gt.TabIndex = 82
        '
        'msk_fe_gt
        '
        Me.msk_fe_gt.Location = New System.Drawing.Point(59, 225)
        Me.msk_fe_gt.Mask = "0000-00-00"
        Me.msk_fe_gt.Name = "msk_fe_gt"
        Me.msk_fe_gt.Size = New System.Drawing.Size(71, 23)
        Me.msk_fe_gt.TabIndex = 81
        '
        'txt_direccion_gt
        '
        Me.txt_direccion_gt.Location = New System.Drawing.Point(653, 142)
        Me.txt_direccion_gt.Name = "txt_direccion_gt"
        Me.txt_direccion_gt.Size = New System.Drawing.Size(351, 23)
        Me.txt_direccion_gt.TabIndex = 80
        '
        'cbo_empresa_gt
        '
        Me.cbo_empresa_gt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbo_empresa_gt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_empresa_gt.FormattingEnabled = True
        Me.cbo_empresa_gt.Location = New System.Drawing.Point(296, 142)
        Me.cbo_empresa_gt.Name = "cbo_empresa_gt"
        Me.cbo_empresa_gt.Size = New System.Drawing.Size(297, 23)
        Me.cbo_empresa_gt.TabIndex = 79
        '
        'cbo_rut_emp_gt
        '
        Me.cbo_rut_emp_gt.FormattingEnabled = True
        Me.cbo_rut_emp_gt.Location = New System.Drawing.Point(148, 142)
        Me.cbo_rut_emp_gt.Name = "cbo_rut_emp_gt"
        Me.cbo_rut_emp_gt.Size = New System.Drawing.Size(104, 23)
        Me.cbo_rut_emp_gt.TabIndex = 78
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Silver
        Me.Label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label78.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.DarkRed
        Me.Label78.Location = New System.Drawing.Point(189, 197)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(99, 17)
        Me.Label78.TabIndex = 71
        Me.Label78.Text = "Fecha Despacho:"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Silver
        Me.Label79.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label79.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.DarkRed
        Me.Label79.Location = New System.Drawing.Point(56, 197)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(93, 17)
        Me.Label79.TabIndex = 70
        Me.Label79.Text = "Fecha Traspaso:"
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.BackColor = System.Drawing.Color.Silver
        Me.Label81.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label81.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.DarkRed
        Me.Label81.Location = New System.Drawing.Point(691, 119)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(63, 17)
        Me.Label81.TabIndex = 68
        Me.Label81.Text = "Dirección:"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.BackColor = System.Drawing.Color.Silver
        Me.Label82.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label82.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.DarkRed
        Me.Label82.Location = New System.Drawing.Point(390, 119)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(60, 17)
        Me.Label82.TabIndex = 67
        Me.Label82.Text = "Empresa:"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.BackColor = System.Drawing.Color.Silver
        Me.Label83.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label83.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.DarkRed
        Me.Label83.Location = New System.Drawing.Point(162, 119)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(74, 17)
        Me.Label83.TabIndex = 66
        Me.Label83.Text = "Rut Cliente:"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label53.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label53.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Maroon
        Me.Label53.Location = New System.Drawing.Point(339, 26)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(185, 17)
        Me.Label53.TabIndex = 49
        Me.Label53.Text = "DATOS DE LA GUIA DE TRASPASO"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.BackColor = System.Drawing.Color.Silver
        Me.CheckBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.Maroon
        Me.CheckBox2.Location = New System.Drawing.Point(654, 58)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(98, 19)
        Me.CheckBox2.TabIndex = 48
        Me.CheckBox2.Text = "Año Anterior"
        Me.CheckBox2.UseVisualStyleBackColor = False
        '
        'frm_reingresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1114, 728)
        Me.Controls.Add(Me.Tab1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_reingresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_reingresos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Tab1.ResumeLayout(False)
        Me.TP1.ResumeLayout(False)
        Me.TP1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TP2.ResumeLayout(False)
        Me.TP2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TP3.ResumeLayout(False)
        Me.TP3.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TP4.ResumeLayout(False)
        Me.TP4.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_VolverAIngresosFact As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnu_VolverAIngresosGuias As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnu_VolverAIngresosBol As ToolStripMenuItem
    Friend WithEvents Tab1 As TabControl
    Friend WithEvents TP1 As TabPage
    Friend WithEvents TP2 As TabPage
    Friend WithEvents TP3 As TabPage
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolverAlMenúToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lbl_ciudad As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_vendedor As Label
    Friend WithEvents lbl_noc As Label
    Friend WithEvents lbl_fe_fact As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_mto_fact As Label
    Friend WithEvents lbl_rut As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_bus_fact As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lbl_idbd As Label
    Friend WithEvents ch_anio_ant As CheckBox
    Friend WithEvents msk_fe_reing As MaskedTextBox
    Friend WithEvents txt_recep_desp As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents msk_fe_recep_clte As MaskedTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_modificar As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_actualizar As Button
    Friend WithEvents txt_reing_obs As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbl_obs As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lbl_ampm As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbl_peso As Label
    Friend WithEvents lbl_fe_desp As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lbl_fe_reg As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lbl_cedible As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lbl_acomodador As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lbl_chofer As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_medio_tp As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbl_nrobultos As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbl_nroflete As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_nrodp As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbl_dirclie As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_patente As Label
    Friend WithEvents lbl_movil As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents lbl_mto_boe As Label
    Friend WithEvents lbl_vend_boe As Label
    Friend WithEvents lbl_fe_boe As Label
    Friend WithEvents lbl_ciudad_boe As Label
    Friend WithEvents lbl_clie_boe As Label
    Friend WithEvents lbl_rut_boe As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbl_patente_boe As Label
    Friend WithEvents lbl_movil_boe As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents lbl_obs_desp_boe As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents lbl_ampm_boe As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents lbl_peso_boe As Label
    Friend WithEvents lbl_fe_desp_boe As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents lbl_fe_crea_boe As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents lbl_cedi_boe As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents lbl_despachador_boe As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents lbl_chofer_boe As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents lbl_mediotp_boe As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents lbl_nrobulto_boe As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents lbl_nro_flete_boe As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents lbl_nrodp_boe As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents ch_anio_ant_boe As CheckBox
    Friend WithEvents txt_bus_boe As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cmd_cancelar_boe As Button
    Friend WithEvents cmd_modificar_boe As Button
    Friend WithEvents cmd_limpiar_boe As Button
    Friend WithEvents cmd_actualiza_boe As Button
    Friend WithEvents lbl_idbd_boe As Label
    Friend WithEvents txt_obs_reing_boe As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents txt_recep_desp_boe As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents msk_fe_recep_clie_boe As MaskedTextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents msk_fe_reing_boe As MaskedTextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label69 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txt_guia_reing_gc As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents TP4 As TabPage
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label81 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents lbl_nbulto_gc As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents lbl_nro_flete_gc As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents lbl_nguia_gc As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents lbl_fe_desp_gc As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents lbl_nrodp_gc As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents lbl_salida_gc As Label
    Friend WithEvents lbl_ciudad_gc As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lbl_noc_gc As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents lbl_fe_docto_gc As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents lbl_nrofact_gc As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents lbl_monto_gc As Label
    Friend WithEvents lbl_vend_gc As Label
    Friend WithEvents lbl_nombre_gc As Label
    Friend WithEvents lbl_rut_gc As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents lbl_obs_desp_gc As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents lbl_despach_gc As Label
    Friend WithEvents Label93 As Label
    Friend WithEvents lbl_chofer_gc As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents lbl_transporte_gc As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents lbl_peso_gc As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents lbl_ncedible_gc As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label95 As Label
    Friend WithEvents lbl_fe_reg_gc As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label51 As Label
    Friend WithEvents lbl_direc_gc As Label
    Friend WithEvents Label96 As Label
    Friend WithEvents cmd_actualiza_gc As Button
    Friend WithEvents txt_reing_obs_gc As TextBox
    Friend WithEvents Label100 As Label
    Friend WithEvents txt_recep_des_gc As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents msk_fe_recep_clte_gc As MaskedTextBox
    Friend WithEvents Label98 As Label
    Friend WithEvents Label97 As Label
    Friend WithEvents msk_fe_reing_gc As MaskedTextBox
    Friend WithEvents cmd_limpiar_gc As Button
    Friend WithEvents cmd_salir As Button
    Friend WithEvents lbl_patente_gc As Label
    Friend WithEvents lbl_movil_gc As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents lbl_idbd_gc As Label
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
    Friend WithEvents msk_fe_gt As MaskedTextBox
    Friend WithEvents txt_direccion_gt As TextBox
    Friend WithEvents cbo_empresa_gt As ComboBox
    Friend WithEvents cbo_rut_emp_gt As ComboBox
    Friend WithEvents cmd_cancelar_gt As Button
    Friend WithEvents cmd_Limpiar_gt As Button
    Friend WithEvents cmd_modif_gt As Button
    Friend WithEvents cmd_actualizar_gt As Button
    Friend WithEvents lbl_usuario_gt As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents txt_obs_ingreso As TextBox
    Friend WithEvents txt_guia_gt As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents cbo_bod_destino_gt As ComboBox
    Friend WithEvents Label80 As Label
    Friend WithEvents cbo_bod_origen_gt As ComboBox
    Friend WithEvents Label77 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents cbo_recep_gt As ComboBox
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents msk_fe_recep_gt As MaskedTextBox
    Friend WithEvents txt_obs_reing_gt As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents lbl_nrodpid As Label
    Friend WithEvents lbl_nrodp_gt As Label
    Friend WithEvents Label104 As Label
    Friend WithEvents lbl_usr_reing_gt As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents lbl_usr_reing_boe As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents Label106 As Label
    Friend WithEvents lbl_usr_ingreso_boe As Label
    Friend WithEvents mnu_guia_DeCliente As ToolStripMenuItem
    Friend WithEvents mnu_guia_SinAsignacionFactura As ToolStripMenuItem
    Friend WithEvents mnu_guia_DeTraspaso As ToolStripMenuItem
    Friend WithEvents lbl_tipo_guia_gc As Label
    Friend WithEvents Label108 As Label
    Friend WithEvents lbl_destino_guia_gc As Label
    Friend WithEvents Label109 As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
