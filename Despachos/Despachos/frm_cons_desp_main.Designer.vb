<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cons_desp_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cons_desp_main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.txt_nrodocto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.ch_anio_ant = New System.Windows.Forms.CheckBox()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.txt_nrodocto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.ch_anio_ant)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar)
        Me.GroupBox1.Location = New System.Drawing.Point(86, 37)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(788, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros de Búsqueda"
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.Image = Global.Despachos.My.Resources.Resources.export_excel
        Me.cmd_exp_excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_exp_excel.Location = New System.Drawing.Point(677, 31)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(105, 42)
        Me.cmd_exp_excel.TabIndex = 8
        Me.cmd_exp_excel.Text = "Exp.Excel"
        Me.cmd_exp_excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_exp_excel.UseVisualStyleBackColor = True
        '
        'txt_nrodocto
        '
        Me.txt_nrodocto.Location = New System.Drawing.Point(208, 40)
        Me.txt_nrodocto.Name = "txt_nrodocto"
        Me.txt_nrodocto.Size = New System.Drawing.Size(103, 23)
        Me.txt_nrodocto.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ingrese Nro Documento"
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Location = New System.Drawing.Point(45, 40)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(124, 23)
        Me.cbo_tipo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione Tipo de Documento"
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.Image = Global.Despachos.My.Resources.Resources.cancel
        Me.cmd_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_cancelar.Location = New System.Drawing.Point(570, 31)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(92, 42)
        Me.cmd_cancelar.TabIndex = 3
        Me.cmd_cancelar.Text = "Cancelar"
        Me.cmd_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_cancelar.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Image = Global.Despachos.My.Resources.Resources.undo
        Me.cmd_limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_limpiar.Location = New System.Drawing.Point(460, 31)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(92, 42)
        Me.cmd_limpiar.TabIndex = 2
        Me.cmd_limpiar.Text = "Limpíar"
        Me.cmd_limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'ch_anio_ant
        '
        Me.ch_anio_ant.AutoSize = True
        Me.ch_anio_ant.Location = New System.Drawing.Point(17, 71)
        Me.ch_anio_ant.Name = "ch_anio_ant"
        Me.ch_anio_ant.Size = New System.Drawing.Size(98, 19)
        Me.ch_anio_ant.TabIndex = 1
        Me.ch_anio_ant.Text = "Año Anterior"
        Me.ch_anio_ant.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Image = Global.Despachos.My.Resources.Resources.search_minus
        Me.cmd_buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_buscar.Location = New System.Drawing.Point(343, 31)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(92, 42)
        Me.cmd_buscar.TabIndex = 0
        Me.cmd_buscar.Text = "BUSCAR"
        Me.cmd_buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.grilla)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(882, 253)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultado de la Búsqueda"
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(16, 30)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(845, 180)
        Me.grilla.TabIndex = 0
        '
        'frm_cons_desp_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 472)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_cons_desp_main"
        Me.Text = "frm_cons_desp_main"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents ch_anio_ant As CheckBox
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents txt_nrodocto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmd_exp_excel As Button
End Class
