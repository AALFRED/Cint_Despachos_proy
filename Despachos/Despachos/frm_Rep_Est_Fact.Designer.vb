<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Rep_Est_Fact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Rep_Est_Fact))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ch_anio_ant = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_estado = New System.Windows.Forms.ComboBox()
        Me.cmd_exp_excel = New System.Windows.Forms.Button()
        Me.cmd_limpiar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.cmd_buscar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.msk_fe_fin = New System.Windows.Forms.MaskedTextBox()
        Me.msk_fe_ini = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ch_anio_ant)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbo_estado)
        Me.GroupBox1.Controls.Add(Me.cmd_exp_excel)
        Me.GroupBox1.Controls.Add(Me.cmd_limpiar)
        Me.GroupBox1.Controls.Add(Me.grilla)
        Me.GroupBox1.Controls.Add(Me.cmd_buscar)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.msk_fe_fin)
        Me.GroupBox1.Controls.Add(Me.msk_fe_ini)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 414)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado Despacho de Facturas"
        '
        'ch_anio_ant
        '
        Me.ch_anio_ant.AutoSize = True
        Me.ch_anio_ant.BackColor = System.Drawing.SystemColors.Info
        Me.ch_anio_ant.Font = New System.Drawing.Font("Calibri", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ch_anio_ant.Location = New System.Drawing.Point(425, 22)
        Me.ch_anio_ant.Name = "ch_anio_ant"
        Me.ch_anio_ant.Size = New System.Drawing.Size(86, 17)
        Me.ch_anio_ant.TabIndex = 55
        Me.ch_anio_ant.Text = "Año Anterior"
        Me.ch_anio_ant.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(258, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Estado"
        '
        'cbo_estado
        '
        Me.cbo_estado.FormattingEnabled = True
        Me.cbo_estado.Location = New System.Drawing.Point(231, 48)
        Me.cbo_estado.Name = "cbo_estado"
        Me.cbo_estado.Size = New System.Drawing.Size(121, 23)
        Me.cbo_estado.TabIndex = 53
        '
        'cmd_exp_excel
        '
        Me.cmd_exp_excel.Location = New System.Drawing.Point(747, 43)
        Me.cmd_exp_excel.Name = "cmd_exp_excel"
        Me.cmd_exp_excel.Size = New System.Drawing.Size(105, 30)
        Me.cmd_exp_excel.TabIndex = 52
        Me.cmd_exp_excel.Text = "Exp. Excel"
        Me.cmd_exp_excel.UseVisualStyleBackColor = True
        '
        'cmd_limpiar
        '
        Me.cmd_limpiar.Location = New System.Drawing.Point(536, 43)
        Me.cmd_limpiar.Name = "cmd_limpiar"
        Me.cmd_limpiar.Size = New System.Drawing.Size(105, 30)
        Me.cmd_limpiar.TabIndex = 51
        Me.cmd_limpiar.Text = "Limpiar"
        Me.cmd_limpiar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Location = New System.Drawing.Point(15, 96)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(869, 296)
        Me.grilla.TabIndex = 50
        '
        'cmd_buscar
        '
        Me.cmd_buscar.Location = New System.Drawing.Point(393, 43)
        Me.cmd_buscar.Name = "cmd_buscar"
        Me.cmd_buscar.Size = New System.Drawing.Size(105, 30)
        Me.cmd_buscar.TabIndex = 49
        Me.cmd_buscar.Text = "Buscar"
        Me.cmd_buscar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Info
        Me.Label6.Location = New System.Drawing.Point(133, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 15)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Fecha Final:"
        '
        'msk_fe_fin
        '
        Me.msk_fe_fin.Location = New System.Drawing.Point(126, 48)
        Me.msk_fe_fin.Mask = "0000-00-00"
        Me.msk_fe_fin.Name = "msk_fe_fin"
        Me.msk_fe_fin.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_fin.TabIndex = 47
        '
        'msk_fe_ini
        '
        Me.msk_fe_ini.Location = New System.Drawing.Point(15, 48)
        Me.msk_fe_ini.Mask = "0000-00-00"
        Me.msk_fe_ini.Name = "msk_fe_ini"
        Me.msk_fe_ini.Size = New System.Drawing.Size(89, 23)
        Me.msk_fe_ini.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Info
        Me.Label5.Location = New System.Drawing.Point(24, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Fecha Inicial:"
        '
        'frm_Rep_Est_Fact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(926, 554)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Rep_Est_Fact"
        Me.Text = "frm_Rep_Est_Fact"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grilla As DataGridView
    Friend WithEvents cmd_buscar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents msk_fe_fin As MaskedTextBox
    Friend WithEvents msk_fe_ini As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmd_exp_excel As Button
    Friend WithEvents cmd_limpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_estado As ComboBox
    Friend WithEvents ch_anio_ant As CheckBox
End Class
