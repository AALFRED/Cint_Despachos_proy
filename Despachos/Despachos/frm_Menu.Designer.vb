<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_valor_emp_entrada = New System.Windows.Forms.Label()
        Me.cmd_cons_serie = New System.Windows.Forms.Button()
        Me.cmd_cons_despacho = New System.Windows.Forms.Button()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.PBox1 = New System.Windows.Forms.PictureBox()
        Me.PBox2 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Tool1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tool4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.IngresarDespachoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ing_Fact = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_ing_Guias = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_ing_guia_Clie = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_ing_guia_Sin_Fact = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeTraspasosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_ing_Bol = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReingresosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_reingresos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_rep_Est_Fact_Desp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_rep_Est_Guias_Desp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_rep_Est_Bol_desp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_rep_Fact_NoIngresadas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_rep_Estad_DespISO = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogisticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Chofer_Bultos_Gramos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Control_Cobro = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripSeparator()
        Me.MantenedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu_Acomodadores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Ciudades = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Choferes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Moviles = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Transportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_TarifasTranscom = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnu_EliminarRegistros = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_valor_emp_entrada)
        Me.GroupBox1.Controls.Add(Me.cmd_cons_serie)
        Me.GroupBox1.Controls.Add(Me.cmd_cons_despacho)
        Me.GroupBox1.Controls.Add(Me.lbl_version)
        Me.GroupBox1.Controls.Add(Me.PBox1)
        Me.GroupBox1.Controls.Add(Me.PBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(26, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(772, 445)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SISTEMA DE DESPACHOS"
        '
        'lbl_valor_emp_entrada
        '
        Me.lbl_valor_emp_entrada.AutoSize = True
        Me.lbl_valor_emp_entrada.Location = New System.Drawing.Point(15, 427)
        Me.lbl_valor_emp_entrada.Name = "lbl_valor_emp_entrada"
        Me.lbl_valor_emp_entrada.Size = New System.Drawing.Size(135, 15)
        Me.lbl_valor_emp_entrada.TabIndex = 6
        Me.lbl_valor_emp_entrada.Text = "lbl_valor_emp_entrada"
        '
        'cmd_cons_serie
        '
        Me.cmd_cons_serie.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmd_cons_serie.ForeColor = System.Drawing.Color.Maroon
        Me.cmd_cons_serie.Image = Global.Despachos.My.Resources.Resources.list
        Me.cmd_cons_serie.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_cons_serie.Location = New System.Drawing.Point(531, 364)
        Me.cmd_cons_serie.Name = "cmd_cons_serie"
        Me.cmd_cons_serie.Size = New System.Drawing.Size(135, 63)
        Me.cmd_cons_serie.TabIndex = 4
        Me.cmd_cons_serie.Text = "Consultar Serie"
        Me.cmd_cons_serie.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_cons_serie.UseVisualStyleBackColor = False
        '
        'cmd_cons_despacho
        '
        Me.cmd_cons_despacho.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.cmd_cons_despacho.ForeColor = System.Drawing.Color.Maroon
        Me.cmd_cons_despacho.Image = Global.Despachos.My.Resources.Resources.conference
        Me.cmd_cons_despacho.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_cons_despacho.Location = New System.Drawing.Point(90, 364)
        Me.cmd_cons_despacho.Name = "cmd_cons_despacho"
        Me.cmd_cons_despacho.Size = New System.Drawing.Size(135, 63)
        Me.cmd_cons_despacho.TabIndex = 3
        Me.cmd_cons_despacho.Text = "Consultar Despacho"
        Me.cmd_cons_despacho.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_cons_despacho.UseVisualStyleBackColor = False
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(255, 345)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(69, 15)
        Me.lbl_version.TabIndex = 2
        Me.lbl_version.Text = "lbl_version"
        '
        'PBox1
        '
        Me.PBox1.Image = Global.Despachos.My.Resources.Resources.banner_despacho
        Me.PBox1.Location = New System.Drawing.Point(18, 36)
        Me.PBox1.Name = "PBox1"
        Me.PBox1.Size = New System.Drawing.Size(722, 292)
        Me.PBox1.TabIndex = 0
        Me.PBox1.TabStop = False
        '
        'PBox2
        '
        Me.PBox2.Image = Global.Despachos.My.Resources.Resources.banner_despacho_global
        Me.PBox2.Location = New System.Drawing.Point(18, 36)
        Me.PBox2.Name = "PBox2"
        Me.PBox2.Size = New System.Drawing.Size(722, 292)
        Me.PBox2.TabIndex = 5
        Me.PBox2.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tool1, Me.Tool2, Me.Tool3, Me.Tool4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 533)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(841, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Tool1
        '
        Me.Tool1.Name = "Tool1"
        Me.Tool1.Size = New System.Drawing.Size(121, 17)
        Me.Tool1.Text = "ToolStripStatusLabel1"
        '
        'Tool2
        '
        Me.Tool2.Name = "Tool2"
        Me.Tool2.Size = New System.Drawing.Size(121, 17)
        Me.Tool2.Text = "ToolStripStatusLabel2"
        '
        'Tool3
        '
        Me.Tool3.Name = "Tool3"
        Me.Tool3.Size = New System.Drawing.Size(121, 17)
        Me.Tool3.Text = "ToolStripStatusLabel3"
        '
        'Tool4
        '
        Me.Tool4.Name = "Tool4"
        Me.Tool4.Size = New System.Drawing.Size(121, 17)
        Me.Tool4.Text = "ToolStripStatusLabel4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarDespachoToolStripMenuItem, Me.ReingresosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.LogisticaToolStripMenuItem, Me.MantenedoresToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(841, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'IngresarDespachoToolStripMenuItem
        '
        Me.IngresarDespachoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ing_Fact, Me.ToolStripMenuItem1, Me.mnu_ing_Guias, Me.ToolStripMenuItem3, Me.mnu_ing_Bol})
        Me.IngresarDespachoToolStripMenuItem.Name = "IngresarDespachoToolStripMenuItem"
        Me.IngresarDespachoToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.IngresarDespachoToolStripMenuItem.Text = "Ingresar Despacho"
        '
        'mnu_ing_Fact
        '
        Me.mnu_ing_Fact.Name = "mnu_ing_Fact"
        Me.mnu_ing_Fact.Size = New System.Drawing.Size(118, 22)
        Me.mnu_ing_Fact.Text = "Facturas"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(115, 6)
        '
        'mnu_ing_Guias
        '
        Me.mnu_ing_Guias.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ing_guia_Clie, Me.ToolStripMenuItem2, Me.mnu_ing_guia_Sin_Fact, Me.ToolStripMenuItem5, Me.DeTraspasosToolStripMenuItem})
        Me.mnu_ing_Guias.Name = "mnu_ing_Guias"
        Me.mnu_ing_Guias.Size = New System.Drawing.Size(118, 22)
        Me.mnu_ing_Guias.Text = "Guias"
        '
        'mnu_ing_guia_Clie
        '
        Me.mnu_ing_guia_Clie.Name = "mnu_ing_guia_Clie"
        Me.mnu_ing_guia_Clie.Size = New System.Drawing.Size(189, 22)
        Me.mnu_ing_guia_Clie.Text = "A Clientes Finales"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(186, 6)
        '
        'mnu_ing_guia_Sin_Fact
        '
        Me.mnu_ing_guia_Sin_Fact.Name = "mnu_ing_guia_Sin_Fact"
        Me.mnu_ing_guia_Sin_Fact.Size = New System.Drawing.Size(189, 22)
        Me.mnu_ing_guia_Sin_Fact.Text = "Sin Asig. de Factura"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(186, 6)
        '
        'DeTraspasosToolStripMenuItem
        '
        Me.DeTraspasosToolStripMenuItem.Name = "DeTraspasosToolStripMenuItem"
        Me.DeTraspasosToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.DeTraspasosToolStripMenuItem.Text = "De Traspasos Internos"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(115, 6)
        '
        'mnu_ing_Bol
        '
        Me.mnu_ing_Bol.Name = "mnu_ing_Bol"
        Me.mnu_ing_Bol.Size = New System.Drawing.Size(118, 22)
        Me.mnu_ing_Bol.Text = "Boletas"
        '
        'ReingresosToolStripMenuItem
        '
        Me.ReingresosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_reingresos})
        Me.ReingresosToolStripMenuItem.Name = "ReingresosToolStripMenuItem"
        Me.ReingresosToolStripMenuItem.Size = New System.Drawing.Size(131, 20)
        Me.ReingresosToolStripMenuItem.Text = "Reingreso Despachos"
        '
        'mnu_reingresos
        '
        Me.mnu_reingresos.Name = "mnu_reingresos"
        Me.mnu_reingresos.Size = New System.Drawing.Size(162, 22)
        Me.mnu_reingresos.Text = "Ir a Reingresos...."
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_rep_Est_Fact_Desp, Me.ToolStripMenuItem12, Me.mnu_rep_Est_Guias_Desp, Me.ToolStripMenuItem13, Me.mnu_rep_Est_Bol_desp, Me.ToolStripMenuItem14, Me.mnu_rep_Fact_NoIngresadas, Me.ToolStripMenuItem15, Me.mnu_rep_Estad_DespISO})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'mnu_rep_Est_Fact_Desp
        '
        Me.mnu_rep_Est_Fact_Desp.Name = "mnu_rep_Est_Fact_Desp"
        Me.mnu_rep_Est_Fact_Desp.Size = New System.Drawing.Size(252, 22)
        Me.mnu_rep_Est_Fact_Desp.Text = "Estado Facturas Despachadas"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(249, 6)
        '
        'mnu_rep_Est_Guias_Desp
        '
        Me.mnu_rep_Est_Guias_Desp.Name = "mnu_rep_Est_Guias_Desp"
        Me.mnu_rep_Est_Guias_Desp.Size = New System.Drawing.Size(252, 22)
        Me.mnu_rep_Est_Guias_Desp.Text = "Estado Guias Despachadas"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(249, 6)
        '
        'mnu_rep_Est_Bol_desp
        '
        Me.mnu_rep_Est_Bol_desp.Name = "mnu_rep_Est_Bol_desp"
        Me.mnu_rep_Est_Bol_desp.Size = New System.Drawing.Size(252, 22)
        Me.mnu_rep_Est_Bol_desp.Text = "Estado Boletas Despachadas"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(249, 6)
        '
        'mnu_rep_Fact_NoIngresadas
        '
        Me.mnu_rep_Fact_NoIngresadas.Name = "mnu_rep_Fact_NoIngresadas"
        Me.mnu_rep_Fact_NoIngresadas.Size = New System.Drawing.Size(252, 22)
        Me.mnu_rep_Fact_NoIngresadas.Text = "Facturas No Ingresadas al Sistema"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(249, 6)
        '
        'mnu_rep_Estad_DespISO
        '
        Me.mnu_rep_Estad_DespISO.Name = "mnu_rep_Estad_DespISO"
        Me.mnu_rep_Estad_DespISO.Size = New System.Drawing.Size(252, 22)
        Me.mnu_rep_Estad_DespISO.Text = "Estadistica de Despacho (ISO)"
        '
        'LogisticaToolStripMenuItem
        '
        Me.LogisticaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Chofer_Bultos_Gramos, Me.ToolStripMenuItem17, Me.mnu_Control_Cobro, Me.ToolStripMenuItem18})
        Me.LogisticaToolStripMenuItem.Name = "LogisticaToolStripMenuItem"
        Me.LogisticaToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.LogisticaToolStripMenuItem.Text = "Logistica"
        '
        'mnu_Chofer_Bultos_Gramos
        '
        Me.mnu_Chofer_Bultos_Gramos.Name = "mnu_Chofer_Bultos_Gramos"
        Me.mnu_Chofer_Bultos_Gramos.Size = New System.Drawing.Size(210, 22)
        Me.mnu_Chofer_Bultos_Gramos.Text = "Chofer/Bultos/Gramos"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(207, 6)
        '
        'mnu_Control_Cobro
        '
        Me.mnu_Control_Cobro.Name = "mnu_Control_Cobro"
        Me.mnu_Control_Cobro.Size = New System.Drawing.Size(210, 22)
        Me.mnu_Control_Cobro.Text = "Control Cobro Transporte"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(207, 6)
        '
        'MantenedoresToolStripMenuItem
        '
        Me.MantenedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_Acomodadores, Me.ToolStripMenuItem11, Me.mnu_Ciudades, Me.ToolStripMenuItem21, Me.mnu_Choferes, Me.ToolStripMenuItem22, Me.mnu_Moviles, Me.ToolStripMenuItem23, Me.mnu_Transportes, Me.ToolStripMenuItem24, Me.mnu_TarifasTranscom, Me.ToolStripMenuItem25, Me.mnu_Usuarios, Me.ToolStripMenuItem26, Me.mnu_EliminarRegistros})
        Me.MantenedoresToolStripMenuItem.Name = "MantenedoresToolStripMenuItem"
        Me.MantenedoresToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.MantenedoresToolStripMenuItem.Text = "Mantenedores"
        '
        'mnu_Acomodadores
        '
        Me.mnu_Acomodadores.Name = "mnu_Acomodadores"
        Me.mnu_Acomodadores.Size = New System.Drawing.Size(180, 22)
        Me.mnu_Acomodadores.Text = "Acomodadores"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(177, 6)
        '
        'mnu_Ciudades
        '
        Me.mnu_Ciudades.Name = "mnu_Ciudades"
        Me.mnu_Ciudades.Size = New System.Drawing.Size(180, 22)
        Me.mnu_Ciudades.Text = "Ciudades"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(177, 6)
        '
        'mnu_Choferes
        '
        Me.mnu_Choferes.Name = "mnu_Choferes"
        Me.mnu_Choferes.Size = New System.Drawing.Size(180, 22)
        Me.mnu_Choferes.Text = "Choferes"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(177, 6)
        '
        'mnu_Moviles
        '
        Me.mnu_Moviles.Name = "mnu_Moviles"
        Me.mnu_Moviles.Size = New System.Drawing.Size(180, 22)
        Me.mnu_Moviles.Text = "Móviles"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(177, 6)
        '
        'mnu_Transportes
        '
        Me.mnu_Transportes.Name = "mnu_Transportes"
        Me.mnu_Transportes.Size = New System.Drawing.Size(180, 22)
        Me.mnu_Transportes.Text = "Transportes"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(177, 6)
        '
        'mnu_TarifasTranscom
        '
        Me.mnu_TarifasTranscom.Name = "mnu_TarifasTranscom"
        Me.mnu_TarifasTranscom.Size = New System.Drawing.Size(180, 22)
        Me.mnu_TarifasTranscom.Text = "Tarifas Transcom"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(177, 6)
        '
        'mnu_Usuarios
        '
        Me.mnu_Usuarios.Name = "mnu_Usuarios"
        Me.mnu_Usuarios.Size = New System.Drawing.Size(180, 22)
        Me.mnu_Usuarios.Text = "Usuarios"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(177, 6)
        '
        'mnu_EliminarRegistros
        '
        Me.mnu_EliminarRegistros.Name = "mnu_EliminarRegistros"
        Me.mnu_EliminarRegistros.Size = New System.Drawing.Size(180, 22)
        Me.mnu_EliminarRegistros.Text = "Eliminar Registros"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirDelSistemaToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(841, 555)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frm_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PBox1 As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Tool1 As ToolStripStatusLabel
    Friend WithEvents Tool2 As ToolStripStatusLabel
    Friend WithEvents Tool3 As ToolStripStatusLabel
    Friend WithEvents Tool4 As ToolStripStatusLabel
    Friend WithEvents lbl_version As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents IngresarDespachoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_ing_Fact As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents mnu_ing_Guias As ToolStripMenuItem
    Friend WithEvents mnu_ing_guia_Clie As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents mnu_ing_guia_Sin_Fact As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents mnu_ing_Bol As ToolStripMenuItem
    Friend WithEvents ReingresosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_reingresos As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_rep_Est_Fact_Desp As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripSeparator
    Friend WithEvents mnu_rep_Est_Guias_Desp As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripSeparator
    Friend WithEvents mnu_rep_Est_Bol_desp As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripSeparator
    Friend WithEvents mnu_rep_Fact_NoIngresadas As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As ToolStripSeparator
    Friend WithEvents mnu_rep_Estad_DespISO As ToolStripMenuItem
    Friend WithEvents LogisticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_Chofer_Bultos_Gramos As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As ToolStripSeparator
    Friend WithEvents mnu_Control_Cobro As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmd_cons_despacho As Button
    Friend WithEvents cmd_cons_serie As Button
    Friend WithEvents PBox2 As PictureBox
    Friend WithEvents MantenedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnu_Acomodadores As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
    Friend WithEvents mnu_Ciudades As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As ToolStripSeparator
    Friend WithEvents mnu_Choferes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As ToolStripSeparator
    Friend WithEvents mnu_Moviles As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As ToolStripSeparator
    Friend WithEvents mnu_Transportes As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As ToolStripSeparator
    Friend WithEvents mnu_TarifasTranscom As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As ToolStripSeparator
    Friend WithEvents mnu_Usuarios As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As ToolStripSeparator
    Friend WithEvents mnu_EliminarRegistros As ToolStripMenuItem
    Friend WithEvents lbl_valor_emp_entrada As Label
    Friend WithEvents DeTraspasosToolStripMenuItem As ToolStripMenuItem
End Class
