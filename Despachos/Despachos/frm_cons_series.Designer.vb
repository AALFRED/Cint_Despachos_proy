<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cons_series
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_cartel = New System.Windows.Forms.Label()
        Me.op_despacho = New System.Windows.Forms.RadioButton()
        Me.op_salida = New System.Windows.Forms.RadioButton()
        Me.op_entrada = New System.Windows.Forms.RadioButton()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.lbl_buscar = New System.Windows.Forms.Label()
        Me.op_nro_fact = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.op_nro_fact)
        Me.GroupBox1.Controls.Add(Me.lbl_cartel)
        Me.GroupBox1.Controls.Add(Me.op_despacho)
        Me.GroupBox1.Controls.Add(Me.op_salida)
        Me.GroupBox1.Controls.Add(Me.op_entrada)
        Me.GroupBox1.Controls.Add(Me.txt_serie)
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar)
        Me.GroupBox1.Controls.Add(Me.grilla)
        Me.GroupBox1.Controls.Add(Me.lbl_buscar)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1185, 289)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado Despacho de Boletas"
        '
        'lbl_cartel
        '
        Me.lbl_cartel.AutoSize = True
        Me.lbl_cartel.Location = New System.Drawing.Point(563, 74)
        Me.lbl_cartel.Name = "lbl_cartel"
        Me.lbl_cartel.Size = New System.Drawing.Size(49, 13)
        Me.lbl_cartel.TabIndex = 69
        Me.lbl_cartel.Text = "lbl_cartel"
        '
        'op_despacho
        '
        Me.op_despacho.AutoSize = True
        Me.op_despacho.Location = New System.Drawing.Point(460, 26)
        Me.op_despacho.Name = "op_despacho"
        Me.op_despacho.Size = New System.Drawing.Size(119, 17)
        Me.op_despacho.TabIndex = 68
        Me.op_despacho.TabStop = True
        Me.op_despacho.Text = "Serie Despachada?"
        Me.op_despacho.UseVisualStyleBackColor = True
        '
        'op_salida
        '
        Me.op_salida.AutoSize = True
        Me.op_salida.Location = New System.Drawing.Point(353, 26)
        Me.op_salida.Name = "op_salida"
        Me.op_salida.Size = New System.Drawing.Size(84, 17)
        Me.op_salida.TabIndex = 67
        Me.op_salida.TabStop = True
        Me.op_salida.Text = "Serie Cliente"
        Me.op_salida.UseVisualStyleBackColor = True
        '
        'op_entrada
        '
        Me.op_entrada.AutoSize = True
        Me.op_entrada.Location = New System.Drawing.Point(246, 26)
        Me.op_entrada.Name = "op_entrada"
        Me.op_entrada.Size = New System.Drawing.Size(101, 17)
        Me.op_entrada.TabIndex = 66
        Me.op_entrada.TabStop = True
        Me.op_entrada.Text = "Serie Proveedor"
        Me.op_entrada.UseVisualStyleBackColor = True
        '
        'txt_serie
        '
        Me.txt_serie.Location = New System.Drawing.Point(143, 25)
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(86, 20)
        Me.txt_serie.TabIndex = 65
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.Location = New System.Drawing.Point(379, 65)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(105, 30)
        Me.cmd_exp_excel.TabIndex = 61
        Me.cmd_exp_excel.Text = "Exp. Excel"
        Me.cmd_exp_excel.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(246, 65)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(105, 30)
        Me.cmd_limpiar.TabIndex = 60
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(103, 65)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(105, 30)
        Me.cmd_buscar.TabIndex = 59
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.Location = New System.Drawing.Point(16, 124)
        Me.grilla.MultiSelect = False
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(1152, 145)
        Me.grilla.TabIndex = 53
        '
        'lbl_buscar
        '
        Me.lbl_buscar.AutoSize = True
        Me.lbl_buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_buscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_buscar.Location = New System.Drawing.Point(37, 30)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(74, 15)
        Me.lbl_buscar.TabIndex = 52
        Me.lbl_buscar.Text = "Ingrese Serie:"
        '
        'op_nro_fact
        '
        Me.op_nro_fact.AutoSize = True
        Me.op_nro_fact.Location = New System.Drawing.Point(585, 26)
        Me.op_nro_fact.Name = "op_nro_fact"
        Me.op_nro_fact.Size = New System.Drawing.Size(136, 17)
        Me.op_nro_fact.TabIndex = 70
        Me.op_nro_fact.TabStop = True
        Me.op_nro_fact.Text = "Tengo Nro Factura Clte"
        Me.op_nro_fact.UseVisualStyleBackColor = True
        '
        'frm_cons_series
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_cons_series"
        Me.Text = "frm_cons_series"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents op_salida As RadioButton
    Friend WithEvents op_entrada As RadioButton
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents grilla As DataGridView
    Friend WithEvents lbl_buscar As Label
    Friend WithEvents op_despacho As RadioButton
    Friend WithEvents lbl_cartel As Label
    Friend WithEvents op_nro_fact As RadioButton
End Class
