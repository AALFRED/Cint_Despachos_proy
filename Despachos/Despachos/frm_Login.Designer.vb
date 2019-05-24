<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Login))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_perfil = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_acceso = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEmp = New System.Windows.Forms.ComboBox()
        Me.cmd_cancelar = New System.Windows.Forms.Button()
        Me.cmd_ingresar = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.lbl_perfil)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lbl_acceso)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lbl_version)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboEmp)
        Me.GroupBox1.Controls.Add(Me.cmd_cancelar)
        Me.GroupBox1.Controls.Add(Me.cmd_ingresar)
        Me.GroupBox1.Controls.Add(Me.txtpassword)
        Me.GroupBox1.Controls.Add(Me.txtusuario)
        Me.GroupBox1.Controls.Add(Me.PasswordLabel)
        Me.GroupBox1.Controls.Add(Me.UsernameLabel)
        Me.GroupBox1.Controls.Add(Me.LogoPictureBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(21, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 412)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso al Sistema"
        '
        'lbl_perfil
        '
        Me.lbl_perfil.AutoSize = True
        Me.lbl_perfil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_perfil.Location = New System.Drawing.Point(428, 258)
        Me.lbl_perfil.Name = "lbl_perfil"
        Me.lbl_perfil.Size = New System.Drawing.Size(57, 17)
        Me.lbl_perfil.TabIndex = 21
        Me.lbl_perfil.Text = "lbl_perfil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(391, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 15)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Perfil:"
        '
        'lbl_acceso
        '
        Me.lbl_acceso.AutoSize = True
        Me.lbl_acceso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_acceso.Location = New System.Drawing.Point(269, 258)
        Me.lbl_acceso.Name = "lbl_acceso"
        Me.lbl_acceso.Size = New System.Drawing.Size(63, 17)
        Me.lbl_acceso.TabIndex = 19
        Me.lbl_acceso.Text = "lbl_acceso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(183, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Último Acceso:"
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.Location = New System.Drawing.Point(90, 294)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(66, 15)
        Me.lbl_version.TabIndex = 17
        Me.lbl_version.Text = "lbl_version"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 26)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "SISTEMA DE DESPACHO  Y LOGÍSTICA"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Despachos.My.Resources.Resources.global_dpnew
        Me.PictureBox2.Location = New System.Drawing.Point(399, 322)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(159, 73)
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Despachos.My.Resources.Resources.cintegral
        Me.PictureBox1.Location = New System.Drawing.Point(26, 323)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 72)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(280, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Seleccione Empresa"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEmp
        '
        Me.cboEmp.FormattingEnabled = True
        Me.cboEmp.Location = New System.Drawing.Point(281, 105)
        Me.cboEmp.Name = "cboEmp"
        Me.cboEmp.Size = New System.Drawing.Size(136, 23)
        Me.cboEmp.TabIndex = 1
        '
        'cmd_cancelar
        '
        Me.cmd_cancelar.BackColor = System.Drawing.Color.Gray
        Me.cmd_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_cancelar.Image = Global.Despachos.My.Resources.Resources.cancel
        Me.cmd_cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_cancelar.Location = New System.Drawing.Point(448, 187)
        Me.cmd_cancelar.Name = "cmd_cancelar"
        Me.cmd_cancelar.Size = New System.Drawing.Size(110, 53)
        Me.cmd_cancelar.TabIndex = 5
        Me.cmd_cancelar.Text = "&Cancelar"
        Me.cmd_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_cancelar.UseVisualStyleBackColor = False
        '
        'cmd_ingresar
        '
        Me.cmd_ingresar.BackColor = System.Drawing.Color.Gray
        Me.cmd_ingresar.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.cmd_ingresar.Image = Global.Despachos.My.Resources.Resources.users
        Me.cmd_ingresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_ingresar.Location = New System.Drawing.Point(448, 128)
        Me.cmd_ingresar.Name = "cmd_ingresar"
        Me.cmd_ingresar.Size = New System.Drawing.Size(110, 53)
        Me.cmd_ingresar.TabIndex = 4
        Me.cmd_ingresar.Text = "&Ingresar"
        Me.cmd_ingresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_ingresar.UseVisualStyleBackColor = False
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(283, 217)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(148, 23)
        Me.txtpassword.TabIndex = 3
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(283, 161)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(148, 23)
        Me.txtusuario.TabIndex = 2
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(280, 187)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(75, 27)
        Me.PasswordLabel.TabIndex = 8
        Me.PasswordLabel.Text = "&Contraseña"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(278, 131)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(118, 27)
        Me.UsernameLabel.TabIndex = 6
        Me.UsernameLabel.Text = "&Nombre de usuario"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(17, 68)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(229, 179)
        Me.LogoPictureBox.TabIndex = 1
        Me.LogoPictureBox.TabStop = False
        '
        'frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(628, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboEmp As ComboBox
    Friend WithEvents cmd_cancelar As Button
    Friend WithEvents cmd_ingresar As Button
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents lbl_version As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lbl_acceso As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_perfil As Label
    Friend WithEvents Label4 As Label
End Class
