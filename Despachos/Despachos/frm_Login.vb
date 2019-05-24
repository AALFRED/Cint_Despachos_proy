Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Text
Imports System
Imports System.Diagnostics
Imports System.Object
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Web.Script.Serialization
Imports System.Net.Mail
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports Despachos


Public Class frm_Login

    Public level As Integer
    Dim sSql As String
    Dim sw As Boolean = False
    Dim perfil As Integer = 0
    Dim bloqueo As Integer
    Dim programa As String
    Dim Id_reg As Integer
    Public band_logo As Boolean = False

    Dim rs As MySqlDataReader

    Dim com As New MySqlCommand
    Dim rs1 As MySqlDataReader
    Dim cmd As MySqlCommand = New MySqlCommand
    Dim cmd2 As MySqlCommand = New MySqlCommand

    Public Sub registra_entrada(bandera)
        Dim mifecha As String
        mifecha = System.DateTime.Now.ToString((" yyyy-MM-dd HH:mm:ss"))

        Try

            If cboEmp.Text = "CINTEGRAL" Then
                Call ConectaCint()
            Else
                Call ConectaGlo()
            End If

            If conexion.State = 1 Then conexion.Close()

            conexion.Open()

            If bandera = False Then

                cmd = New MySqlCommand("INSERT INTO ctrl_acceso_dp (id, usuario, ingreso) Values (0, '" & txtusuario.Text & "', '" & (mifecha) & "')", conexion)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                conexion.Close()
                cmd_ingresar.Enabled = True
            Else
                cmd_ingresar.Enabled = True
            End If
            cmd.Dispose()
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Sub Lastaccess()

        Try
            If txtusuario.Text <> "" Then

                If cboEmp.Text = "CINTEGRAL" Then
                    Call ConectaCint()
                Else
                    Call ConectaGlo()
                End If

                conexion.Open()

                sql = "Select MAX(ingreso) FROM ctrl_acceso_dp where usuario ='" & txtusuario.Text & "'"
                com = New MySqlCommand(sql, conexion)
                rs1 = com.ExecuteReader()

                If rs1.HasRows() Then
                    rs1.Read()
                    lbl_acceso.Text = rs1.GetString(0)

                Else
                    MessageBox.Show("No hay Accesos Registrados", "Validacion Usuario")
                    lbl_acceso.Text = ""
                    txtusuario.Select()
                    Exit Sub
                End If

                rs1.Dispose()
                conexion.Close()
            Else
                txtusuario.Select()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Validación de acceso")
        End Try


    End Sub

    Function ExisteUsuario(ByVal usuario As String, ByVal password As String) As Boolean

        Try

            If cboEmp.Text = "CINTEGRAL" Then
                Call ConectaCint()
            Else
                Call ConectaGlo()
            End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            sSql = "Select * From cuentas_dp where usuario= '" & txtusuario.Text & "' and password= '" & txtpassword.Text & "' and sistema = 'D'"
            da = New MySqlDataAdapter(sSql, conexion)
            ds.Clear()
            da.Fill(ds, "cuentas_dp")

            If (ds.Tables("cuentas_dp").Rows.Count() <> 0) Then

                ' MessageBox.Show("Usuario Encontrado", "Validacion Usuario")
                sw = True
                cmd_ingresar.Enabled = True
            Else
                MessageBox.Show("Usuario o Password no Válido", "Validacion de Usuario")
                sw = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
        Return (sw)
        txtpassword.Select()
    End Function


    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        elano()
        programa = "D"

        Me.Text = "Sistema Despachos y Logística - versión Rev.2.0 - Año *** " & miano & " ****"

        lbl_version.Text = "VERSIÓN " & Application.ProductVersion.ToString & " - Desarrollado por :" & Application.CompanyName.ToString & " - Derechos Reservados"


        'Create a StatusBar
        Dim BarraStatus As New StatusBar
        BarraStatus.Name = "StatusBar"
        BarraStatus.ShowPanels = True

        'Create the panels
        Dim BarraStatusDate = New StatusBarPanel
        BarraStatusDate.Name = "StatusBarDate"
        BarraStatusDate.Text = FormatDateTime(Now(), DateFormat.ShortDate)
        BarraStatusDate.AutoSize = StatusBarPanelAutoSize.Contents
        BarraStatus.Panels.Add(BarraStatusDate)

        Dim BarraStatusTime = New StatusBarPanel
        BarraStatusTime.Name = "StatusBarTime"
        BarraStatusTime.Text = FormatDateTime(Now(), DateFormat.LongTime)
        BarraStatusTime.AutoSize = StatusBarPanelAutoSize.Contents
        BarraStatus.Panels.Add(BarraStatusTime)

        Me.Controls.Add(BarraStatus)
        cboEmp.Text = ""
        cboEmp.Items.Add("CINTEGRAL")
        cboEmp.Items.Add("GLOBAL")

        lbl_acceso.Text = ""
        lbl_perfil.Text = ""
        cmd_ingresar.Enabled = False
        emp_entrada = 0 'variable empresa


    End Sub

    Private Sub cmd_ingresar_Click(sender As Object, e As EventArgs) Handles cmd_ingresar.Click
        If ExisteUsuario(txtusuario.Text, txtpassword.Text) Then
            If cboEmp.Text = "GLOBAL" Then
                band_logo = True
                frm_Menu.PBox1.Visible = False  'cartel cintegral
            Else
                band_logo = False
                frm_Menu.PBox2.Visible = False 'cartel global
            End If
            Me.Hide()
            frm_Menu.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea Salir??",
                                 "Salir del Programa",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)
        If (opcion = DialogResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged

    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        Dim dr3 As MySqlDataReader
        Dim bandera As Boolean


        Try
            If e.KeyChar = Convert.ToChar(13) Then

                If sw = False Then
                    Exit Sub
                Else

                    If txtpassword.Text <> "" Then
                    End If


                    If cboEmp.Text = "CINTEGRAL" Then
                        Call ConectaCint()
                    Else
                        Call ConectaGlo()
                    End If

                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    cmd2.CommandText = ("SELECT * FROM cuentas_dp where usuario= '" & txtusuario.Text & "' and password = '" & txtpassword.Text & "' and sistema = 'D'")
                    cmd2.Connection = conexion
                    cmd2.CommandType = CommandType.Text
                    dr3 = cmd2.ExecuteReader

                    If dr3.Read = False Then
                        'cmd2.ExecuteNonQuery()
                        MessageBox.Show("La Clave o el Usuario no son válidos", "Validación de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        conexion.Close()

                        bandera = True
                        cmd_ingresar.Enabled = False
                        txtpassword.Select()
                        Exit Sub

                    Else
                        bandera = False
                    End If


                    Call registra_entrada(bandera)
                    dr3.Dispose()
                    conexion.Close()
                    cmd_ingresar.Select()


                End If

            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtusuario_TextChanged(sender As Object, e As EventArgs) Handles txtusuario.TextChanged

    End Sub

    Private Sub txtusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusuario.KeyPress
        Try
            'SoloLetras(e)
            If e.KeyChar = Convert.ToChar(13) Then
                txtusuario.CharacterCasing = CharacterCasing.Upper

                If cboEmp.Text = "CINTEGRAL" Then
                    Call ConectaCint()
                Else
                    Call ConectaGlo()
                End If


                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                If txtusuario.Text <> "" Then
                    txtusuario.Text.ToUpper() 'cambia a mayusculas

                    sql = "SELECT usuario, isAdmin, isBanned, id, sistema FROM cuentas_dp where usuario= '" & txtusuario.Text & "' and sistema = 'D'"
                    com = New MySqlCommand(sql, conexion)
                    rs = com.ExecuteReader()
                    If rs.HasRows() Then
                        rs.Read()

                        txtusuario.Text = rs.GetString(0)
                        perfil = rs.GetString(1)
                        bloqueo = rs.GetString(2)
                        Id_reg = rs.GetString(3)
                        programa = rs.GetString(4)
                        sw = True




                    Else
                        txtusuario.Text = ""
                        'MessageBox.Show("No Existen accesos Registrados", "Validacion de Acceso")
                        sw = False

                    End If


                    If programa <> "D" Then
                        MsgBox("El usuario no tiene Permiso para Utilizar este Sistema", MsgBoxStyle.Critical, "Validacion de Permisos")
                        Exit Sub
                    Else


                        If sw = True Then
                            Select Case perfil
                                Case 0
                                    lbl_perfil.Text = "Consultas"
                                Case 1
                                    lbl_perfil.Text = "Bodega"
                                Case 2
                                    lbl_perfil.Text = "Logística"
                                Case 3
                                    lbl_perfil.Text = "Administrador"
                                Case 4
                                    lbl_perfil.Text = "Master-Admin"
                            End Select

                            If bloqueo = 1 Then
                                MsgBox("Este Usuario se encuentra bloqueado, verifique!", MsgBoxStyle.Exclamation, "Usuario Bloqueado")
                                txtusuario.Select()
                                txtpassword.Enabled = False
                                cmd_ingresar.Enabled = False
                                Exit Sub
                            Else
                                conexion.Close()
                                Call Lastaccess()

                                level = perfil  'le pasa el valor del perfil que tiene el usuario
                                retenUser = txtusuario.Text 'le pasa el nombre de usuario
                                txtpassword.Enabled = True
                                txtpassword.Select()

                            End If

                        Else
                            conexion.Close()
                            txtusuario.Select()


                        End If
                    End If
                    rs.Dispose()
                    conexion.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            da = Nothing
            conexion.Close()
        End Try
    End Sub

    Private Sub cboEmp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmp.SelectedIndexChanged

    End Sub

    Private Sub cboEmp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboEmp.SelectedValueChanged
        Select Case cboEmp.Text
            Case "CINTEGRAL"
                emp_entrada = 1
            Case "GLOBAL"
                emp_entrada = 2

        End Select
    End Sub

    Private Sub cboEmp_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles cboEmp.PreviewKeyDown

        If cboEmp.Focused Then
            cboEmp.Text = "CINTEGRAL"
            emp_entrada = 1
        End If
    End Sub

    Private Sub cboEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboEmp.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If cboEmp.Text = "" Then
                MsgBox("DEBE SELECCIONAR UNA EMPRESA", MsgBoxStyle.Critical, "Selección de Empresa")
                cboEmp.Select()
            Else
                txtusuario.Select()
            End If

        End If
    End Sub
End Class
