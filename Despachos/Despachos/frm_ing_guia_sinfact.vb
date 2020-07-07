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



Public Class frm_ing_guia_sinfact

    Dim reseña As Integer
    Dim bandera As Boolean
    Dim tipogarant As Integer  '0 guia normal  1 guia garantia
    Dim fecha_actual As String
    Private counter As Integer
    Dim valdestino As Integer ' 0 - cliente  1 - proveedor
    Dim nombrev As String 'guarda valor nombre vendedor
    Public valret22 As String

    Sub Valida_Campos()
        bandera = False

        If txt_nrobulto.Text = "" Then  'bulto
            bandera = True
            MsgBox("El Campo Bultos se encuentra vacío, verifique!", MsgBoxStyle.Critical)
        Else
            If txt_peso.Text = "" Then 'gramos
                bandera = True
                MsgBox("El campo gramos se encuentra vacío, verifique!", MsgBoxStyle.Critical)
            Else

                If cbo_chofer.Text = "" Then
                    bandera = True
                    MsgBox("El campo Chofer se encuentra vacío, verifique!", MsgBoxStyle.Critical)
                Else
                    If txt_nroguia.Text = "" Then
                        bandera = True
                        MsgBox("El campo Nro Factura se encuentra vacío, verifique!", MsgBoxStyle.Critical)
                    Else
                        If cbo_despachador.Text = "" Then
                            bandera = True
                            MsgBox("El campo Acomodador se encuentra vacío, verifique!", MsgBoxStyle.Critical)

                        Else
                            If msk_fe_desp.Text = "" Then
                                bandera = True
                                MsgBox("El campo Fecha Despacho se encuentra vacío, verifique!", MsgBoxStyle.Critical)

                            End If

                        End If
                    End If
                End If
            End If
        End If

    End Sub


    Sub Busca_guia(valret As String)

        'Dim rs21 As MySqlDataReader
        ' Dim rs13 As MySqlDataReader

        If ch_anio_ant.Checked = True Then
            If emp_entrada = 1 Then   'cintegral
                Call ConectaCint2()
                Call elano()
                miano = miano - 1
            Else                       'global
                Call ConectaGlo2()
                Call elano()
                miano = miano - 1
            End If
        Else
            If emp_entrada = 1 Then  'cintegral
                Call ConectaCint()
                Call elano()
            Else                     'global
                Call ConectaGlo()
                Call elano()
            End If
        End If

        If conexion.State = 1 Then conexion.Close()
        'la abre 
        conexion.Open()

        Dim command22 As MySqlCommand = New MySqlCommand(
          "Select id, nrodp, nfactura, nguia, direccion, comuna, rutclie, nombre, fe_docto, fe_desp, transporte, patente, nflete, recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos, fe_creacion, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant, destino From guias_dp Where nguia = '" & valret & "';", conexion)


        Dim reader As MySqlDataReader = command22.ExecuteReader()

        If reader.HasRows Then
            Do While reader.Read()
                txt_nroguia.Text = valret
                txt_nroguia.Enabled = False
                lbl_idbd.Text = reader.GetInt32(0).ToString
                txt_rut.Text = reader.GetString(6).ToString
                txt_nombre.Text = reader.GetString(7).ToString
                If IsDBNull(reader.GetString(12)) = True Then
                    txt_nroflete.Text = ""
                Else
                    txt_nroflete.Text = reader.GetString(12).ToString   'nflete
                End If
                If IsDBNull(reader.GetString(10)) = True Then
                    cbo_tp.Text = ""
                Else
                    cbo_tp.Text = reader.GetString(10).ToString   'transporte
                End If
                txt_nrofact.Text = Convert.ToString(reader.GetString(2))  'nfactura
                txt_nrofact.Enabled = False
                'SendKeys.Send("~")
                txt_nrofact.Select()



                If IsDBNull(reader.GetString(17)) = True Then   'vendedor
                    cbo_vend.Text = ""
                Else
                    cbo_vend.Text = CStr(reader.GetString(17)).ToString()
                End If
                If IsDBNull(reader.GetString(4)) = True Then
                    txt_direccion.Text = ""
                Else
                    txt_direccion.Text = CStr(reader.GetString(4)).ToString()   'direccion  
                End If
                If IsDBNull(reader.GetString(15)) = True Then
                    txt_cedible.Text = "0"
                Else
                    txt_cedible.Text = CStr(reader.GetString(15)).ToString()  'nro rece
                End If
                If IsDBNull(reader.GetString(20)) = True Then
                    txt_nrobulto.Text = ""
                Else
                    txt_nrobulto.Text = CStr(reader.GetString(20)).ToString()
                End If




            Loop
        Else
            Console.WriteLine("No hay datos")
        End If

        reader.Close()

    End Sub

    Sub Ultimo_nrodp()
        Dim com2 As New MySqlCommand
        Dim rs2 As MySqlDataReader

        'try


        If ch_anio_ant.Checked = True Then
            If emp_entrada = 1 Then   'cintegral
                Call ConectaCint2()
                Call elano()
                miano = miano - 1
            Else                       'global
                Call ConectaGlo2()
                Call elano()
                miano = miano - 1
            End If
        Else
            If emp_entrada = 1 Then  'cintegral
                Call ConectaCint()
                Call elano()
            Else                     'global
                Call ConectaGlo()
                Call elano()
            End If
        End If

        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        sql = "Select MAX(nrodp) FROM guias_dp ORDER BY nrodp ASC"
        com2 = New MySqlCommand(sql, conexion)
        rs2 = com2.ExecuteReader()

        If rs2.HasRows() Then
            rs2.Read()

            lbl_nroreg.Text = rs2.GetString(0)
            lbl_nroreg.Text = Val(lbl_nroreg.Text) + 1

        Else
            MessageBox.Show("No hay Correlativo Disponible", "Validacion de Correlativo")


            lbl_nroreg.Text = miano & "1"

            Exit Sub
        End If

        rs2.Dispose()
        conexion.Close()

        'Catch ex As Exception

        'End Try

    End Sub

    Sub busca_fact()


        'BUSCA DATOS DE LA FACTURA SI HAY
        Dim com12 As New MySqlCommand
        Dim rs12 As MySqlDataReader


        If conexion.State = 1 Then conexion.Close()
        conexion.Open()
        'sql = "Select fechacon, totalcon, ordcon, vencon from venta where tipocon = 'FEL000" & txt_nrofact.Text & "'"
        sql = "Select fecha_emision, monto_total, referencias.folio_ref, vendedor from ventas left join referencias on ventas.id = referencias.id_doc where folio = '" & txt_nrofact.Text & "'"
        com12 = New MySqlCommand(sql, conexion)

        rs12 = com12.ExecuteReader()

        If rs12.HasRows = True Then
            rs12.Read()
            lbl_fe_docto.Text = CStr(rs12("fecha_emision"))
            lbl_monto.Text = CStr(rs12("monto_total"))
            lbl_noc.Text = CStr(rs12("folio_ref"))
            lbl_vend.Text = CStr(rs12("vendedor"))


            rs12.Dispose()


        Else

        End If

        rs12.Close()
        conexion.Close()


    End Sub

    Sub Valida_Fact_dp()

        Dim cmd24 As MySqlCommand
        Dim rs24 As MySqlDataReader
        Dim valfact As String

        If ch_anio_ant.Checked = True Then
            If emp_entrada = 1 Then   'cintegral
                Call ConectaCint2()
                Call elano()
                miano = miano - 1
            Else                       'global
                Call ConectaGlo2()
                Call elano()
                miano = miano - 1
            End If
        Else
            If emp_entrada = 1 Then  'cintegral
                Call ConectaCint()
                Call elano()
            Else                     'global
                Call ConectaGlo()
                Call elano()
            End If
        End If

        If conexion.State = 1 Then conexion.Close()
        conexion.Open()
        valfact = txt_nrofact.Text
        sql = "Select * From guias_dp Where nfactura = '" & LTrim(RTrim(valfact)) & "'"
        cmd24 = New MySqlCommand(sql, conexion)

        rs24 = cmd24.ExecuteReader()
        If rs24.HasRows = True Then
            rs24.Read()
            bandera = True
        Else
            bandera = False


        End If

    End Sub


    Public Function cargacombo(ByVal TABLENAME As String, ByVal fldName As String, ByVal cmbname As ComboBox)
        Dim cmd1 As New MySqlCommand

        If ch_anio_ant.Checked = True Then
            If emp_entrada = 1 Then   'cintegral
                Call ConectaCint2()
                Call elano()
                miano = miano - 1
            Else                       'global
                Call ConectaGlo2()
                Call elano()
                miano = miano - 1
            End If
        Else
            If emp_entrada = 1 Then  'cintegral
                Call ConectaCint()
                Call elano()
            Else                     'global
                Call ConectaGlo()
                Call elano()
            End If
        End If

        If conexion.State = 1 Then conexion.Close()
        conexion.Open()
        Select Case reseña
            Case 1 'Choferes
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 2 'ciudades
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 3 'moviles
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 4 'medios tp
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 5 'acomodadores
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 6 'vendedores
                cmd1 = New MySqlCommand("Select " & fldName & " from " & TABLENAME & " where es_vendedor = 1 order by " & fldName, conexion)

        End Select


        dr = cmd1.ExecuteReader
        cmbname.Items.Clear()
        Do While dr.Read()
            cmbname.Items.Add(dr(fldName))
        Loop
        dr.Close()
        conexion.Close()
        cmd1.Dispose()

        Return 0
    End Function

    Private Sub frm_ing_guia_sinfact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '///////////////////////////////////////
        '///// CONFIGURACION REGIONAL
        '////////////////////////////////////

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-CL")
        System.Threading.Thread.CurrentThread.CurrentCulture.DateTimeFormat.ShortDatePattern = "yyyy/MM/dd"
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyGroupSeparator = ","
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator = "."
        System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberGroupSeparator = ","

        '//////////////////////////////////////////////////////////////////////////////////////////////////////


        Call elano() 'saca el año
        Me.CenterToScreen()
        v_emp = laemp.ToString()
        Me.Text = v_emp & " / Ingreso de Guias para Despacho Sin Asignación de Factura **** AÑO " & miano & " **** Conectado como: " & retenUser


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
        BarraStatusTime.Text = Now.ToShortTimeString  'FormatDateTime(Now(), DateFormat.LongTime)
        BarraStatusTime.AutoSize = StatusBarPanelAutoSize.Contents
        BarraStatus.Panels.Add(BarraStatusTime)

        Dim BarraStatusTexto = New StatusBarPanel
        BarraStatusTexto.Name = "StatusBartexto"
        BarraStatusTexto.Width = 200
        BarraStatusTexto.Text = "CONECTADO A BD " & v_database
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)



        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()

        'CONTROL DE CARGA
        txt_rut.Enabled = False
        txt_nombre.Enabled = False
        txt_direccion.Enabled = False
        txt_cedible.Enabled = False
        txt_nrobulto.Enabled = False
        txt_nroflete.Enabled = False
        txt_obs.Enabled = False
        txt_peso.Enabled = False
        txt_nrofact.Enabled = False
        cbo_movil.Enabled = False
        cbo_chofer.Enabled = False
        cbo_ampm.Enabled = False
        cbo_ciudad.Enabled = False
        cbo_despachador.Enabled = False
        cbo_tp.Enabled = False
        cbo_vend.Enabled = False
        msk_fe_desp.Enabled = False
        txt_nroguia.Enabled = False
        lbl_nroreg2.Text = ""
        lbl_nroreg2.Visible = False

        lbl_fe_docto.Text = ""
        lbl_monto.Text = ""
        lbl_noc.Text = ""
        lbl_vend.Text = ""

        lbl_recepciono.Text = ""
        lbl_fe_recep.Text = ""
        lbl_fe_reing.Text = ""
        lbl_obs_reing.Text = ""
        lbl_usr_reing.Text = ""

        ch_asigna_fact.Enabled = False
        ch_guia_garant.Enabled = False
        ch_guia_normal.Enabled = False

        op_prov.Checked = False
        op_cliente.Checked = False


        cmd_asigna_fact.Enabled = False
        cmd_modif_guia.Enabled = False
        cmd_modif_guia2.Enabled = False
        cmd_guardar.Enabled = False


        cbo_ampm.Items.Add("AM")
        cbo_ampm.Items.Add("PM")

        'carga la fecha actual
        fecha_actual = System.DateTime.Now.ToString((" yyyy-MM-dd"))
        lbl_fe_actual.Text = fecha_actual.ToString

        'carga los choferes
        reseña = 1
        Call cargacombo("chofer_dp", "nom_chof", cbo_chofer)

        'carga ciudades
        reseña = 2
        Call cargacombo("ciudad_dp", "comuna", cbo_ciudad)

        'carga moviles
        reseña = 3
        Call cargacombo("medios_dp", "tipo", cbo_movil)

        'carga medios
        reseña = 4
        Call cargacombo("transporte_dp", "transporte", cbo_tp)

        'carga acomodadores
        reseña = 5
        Call cargacombo("ordenador_dp", "nom_orden", cbo_despachador)

        reseña = 6
        Call cargacombo("usuarios", "nombre_usuario", cbo_vend)

    End Sub

    Private Sub ch_guia_garant_CheckedChanged(sender As Object, e As EventArgs) Handles ch_guia_garant.CheckedChanged
        If ch_guia_garant.Checked = True Then
            ch_guia_normal.Checked = False
            txt_nroguia.Enabled = True

        End If
    End Sub

    Private Sub ch_guia_normal_CheckedChanged(sender As Object, e As EventArgs) Handles ch_guia_normal.CheckedChanged
        If ch_guia_normal.Checked = True Then
            ch_guia_garant.Checked = False
            txt_nroguia.Enabled = True
        End If
    End Sub

    Private Sub txt_rut_TextChanged(sender As Object, e As EventArgs) Handles txt_rut.TextChanged

    End Sub

    Private Sub txt_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rut.KeyPress
        Dim valrut As String
        Dim com13 As New MySqlCommand
        Dim rs13 As MySqlDataReader
        Dim com14 As New MySqlCommand
        Dim rs14 As MySqlDataReader
        Dim texto As String = txt_rut.Text
        'Try

        If e.KeyChar = Convert.ToChar(13) Then


            If op_cliente.Checked = True Then

                If txt_rut.Text <> "" Then

                    '  txt_rut.Text = QuitarCaracteres(texto)
                    ' texto = cadenadevuelta

                    'agrega 0 a la izquierda del rut
                    'txt_rut.Text = texto.PadLeft(10, "0")

                    If ch_anio_ant.Checked = True Then
                        If emp_entrada = 1 Then   'cintegral
                            Call ConectaCint2()
                            Call elano()
                            miano = miano - 1
                        Else                       'global
                            Call ConectaGlo2()
                            Call elano()
                            miano = miano - 1
                        End If
                    Else
                        If emp_entrada = 1 Then  'cintegral
                            Call ConectaCint()
                            Call elano()
                        Else                     'global
                            Call ConectaGlo()
                            Call elano()
                        End If
                    End If

                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    'entrega el valor a la variable para buscar
                    valrut = CStr(txt_rut.Text)
                    'sql = "Select nomclie, dirclie, ciuclie From cliente Where rutclie = '" & LTrim(RTrim(valrut)) & "'"
                    sql = "Select razon_social, direccion, ciudad From clientes Where rut = '" & LTrim(RTrim(valrut)) & "'"
                    com13 = New MySqlCommand(sql, conexion)

                    rs13 = com13.ExecuteReader()
                    If rs13.HasRows = True Then
                        rs13.Read()

                        txt_nombre.Text = CStr(rs13("razon_social"))
                        txt_direccion.Text = CStr(rs13("direccion"))
                        cbo_ciudad.Text = CStr(rs13("ciudad"))

                        rs13.Close()
                        conexion.Close()

                        txt_nombre.Select()
                    Else
                        MsgBox("El rut no fue encontrado en la base de clientes, verifique o incorpore los datos faltantes.", MsgBoxStyle.Exclamation)
                        txt_nombre.Select()
                    End If

                Else
                    MsgBox("Debe incorporar un rut válido", MsgBoxStyle.Exclamation)
                    txt_rut.Select()

                End If



            Else

                If txt_rut.Text <> "" Then


                    If ch_anio_ant.Checked = True Then
                        If emp_entrada = 1 Then   'cintegral
                            Call ConectaCint2()
                            Call elano()
                            miano = miano - 1
                        Else                       'global
                            Call ConectaGlo2()
                            Call elano()
                            miano = miano - 1
                        End If
                    Else
                        If emp_entrada = 1 Then  'cintegral
                            Call ConectaCint()
                            Call elano()
                        Else                     'global
                            Call ConectaGlo()
                            Call elano()
                        End If
                    End If

                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    'entrega el valor a la variable para buscar
                    valrut = CStr(txt_rut.Text)
                    sql = "Select * From proveedores Where rut = '" & valrut & "'"
                    com14 = New MySqlCommand(sql, conexion)

                    rs14 = com14.ExecuteReader()
                    If rs14.HasRows() Then
                        rs14.Read()

                        txt_nombre.Text = CStr(rs14("razon_social"))
                        txt_direccion.Text = CStr(rs14("direccion"))
                        cbo_ciudad.Text = CStr(rs14("ciudad"))

                        rs14.Close()
                        conexion.Close()
                        txt_nombre.Select()
                    Else
                        MsgBox("El rut no fue encontrado en la base de proveedores, verifique o incorpore los datos faltantes.", MsgBoxStyle.Exclamation)
                        txt_nombre.Select()

                    End If

                Else
                    MsgBox("Debe incorporar un rut válido", MsgBoxStyle.Exclamation)
                    txt_rut.Select()

                End If


            End If

        End If

        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub



    Private Sub txt_nrobulto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nrobulto.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                If txt_nrobulto.Text <> "" Then
                    If cbo_tp.Text = "TRANSCOM" Then
                        txt_peso.Text = Val(txt_nrobulto.Text) * 400
                        txt_peso.Select()
                    Else
                        txt_peso.Select()
                    End If
                Else
                    txt_nrobulto.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub txt_peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_peso.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then

                If txt_peso.Text = "" Then
                    txt_peso.Text = "400"
                    cbo_ciudad.Select()

                Else
                    If txt_peso.Text > 0 Then
                        cbo_ampm.Select()
                    Else
                        MsgBox("El Valor Peso debe ser mayor a 0 (cero) y distinto de Vacío, verifique!", MsgBoxStyle.Critical, "Validación de Campo")
                        txt_peso.Select()
                    End If

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbo_ciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ciudad.SelectedIndexChanged
        If cbo_ciudad.Text <> "" Then
            cbo_tp.Select()
        Else
            cbo_ciudad.Select()
        End If
    End Sub

    Private Sub cbo_movil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_movil.SelectedIndexChanged
        Dim valor As String
        Dim com3 As New MySqlCommand
        Dim rs3 As MySqlDataReader

        ' Try
        If cbo_movil.Text <> "" Then

            'verifica si esta activa
            If conexion.State = 1 Then conexion.Close()

            'llama la conexion
            If ch_anio_ant.Checked = True Then
                If emp_entrada = 1 Then   'cintegral
                    Call ConectaCint2()
                    Call elano()
                    miano = miano - 1
                Else                       'global
                    Call ConectaGlo2()
                    Call elano()
                    miano = miano - 1
                End If
            Else
                If emp_entrada = 1 Then  'cintegral
                    Call ConectaCint()
                    Call elano()
                Else                     'global
                    Call ConectaGlo()
                    Call elano()
                End If
            End If

            'la abre 
            conexion.Open()

            'entrega el valor a la variable para buscar
            valor = CStr(cbo_movil.Text)
            sql = "Select patente From medios_dp Where tipo = '" & LTrim(RTrim(valor)) & "'"
            com3 = New MySqlCommand(sql, conexion)

            rs3 = com3.ExecuteReader()
            If rs3.HasRows() Then
                rs3.Read()


                lbl_patente.Text = CStr(rs3("patente"))

                rs3.Close()
                conexion.Close()
                sql = ""

                cbo_despachador.Select()
            Else
                cbo_movil.Select()
            End If

        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txt_nroguia_TextChanged(sender As Object, e As EventArgs) Handles txt_nroguia.TextChanged

    End Sub

    Private Sub txt_nroguia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nroguia.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then

                Dim com7 As New MySqlCommand
                Dim rs7 As MySqlDataReader

                If txt_nroguia.Text <> "" Then


                    'SE VALIDA LA GUIA ELECTRONICA

                    If ch_guia_garant.Checked = False And op_cliente.Checked = True Then

                        If conexion.State = 1 Then conexion.Close()
                        'la abre 
                        conexion.Open()
                        sql = "Select * From ventas Where tipo_documento = '52' and folio = '" & txt_nroguia.Text & "'"
                        com7 = New MySqlCommand(sql, conexion)
                        rs7 = com7.ExecuteReader()
                        If rs7.HasRows = True Then


                            If ch_anio_ant.Checked = True Then
                                If emp_entrada = 1 Then   'cintegral
                                    Call ConectaCint2()
                                    Call elano()
                                    miano = miano - 1
                                Else                       'global
                                    Call ConectaGlo2()
                                    Call elano()
                                    miano = miano - 1
                                End If
                            Else
                                If emp_entrada = 1 Then  'cintegral
                                    Call ConectaCint()
                                    Call elano()
                                Else                     'global
                                    Call ConectaGlo()
                                    Call elano()
                                End If
                            End If


                            If conexion.State = 1 Then conexion.Close()
                            'la abre 
                            conexion.Open()

                            'entrega el valor a la variable para buscar

                            sql = "Select * From guias_dp Where nguia = '" & txt_nroguia.Text & "'"
                            com7 = New MySqlCommand(sql, conexion)

                            rs7 = com7.ExecuteReader()
                            If rs7.HasRows = True Then

                                MsgBox("A VER!!! LA GUIA YA EXISTE Y NO PUEDE REGISTRARLA.", MsgBoxStyle.Critical, "Validación de Guía.")


                                txt_rut.Enabled = False
                                txt_nombre.Enabled = False
                                txt_direccion.Enabled = False
                                txt_cedible.Enabled = False
                                cbo_tp.Enabled = False
                                cbo_ciudad.Enabled = False
                                cbo_chofer.Enabled = False
                                cbo_despachador.Enabled = False
                                txt_nrobulto.Enabled = False
                                txt_nroflete.Enabled = False
                                txt_peso.Enabled = False
                                msk_fe_desp.Enabled = False
                                txt_obs.Enabled = False
                                cbo_ampm.Enabled = False
                                cbo_movil.Enabled = False
                                cmd_modif_guia.Enabled = False
                                cmd_guardar.Enabled = False
                                txt_nroguia.Select()

                            Else


                                ' MsgBox("LA GUIA NO EXISTE, RELLENE LOS DATOS FALTANTES.", MsgBoxStyle.Information, "Validación de Guía.")

                                txt_rut.Enabled = True
                                txt_nombre.Enabled = True
                                txt_direccion.Enabled = True
                                txt_cedible.Enabled = True
                                cbo_tp.Enabled = True
                                cbo_ciudad.Enabled = True
                                cbo_chofer.Enabled = True
                                cbo_despachador.Enabled = True
                                txt_nrobulto.Enabled = True
                                txt_nroflete.Enabled = True
                                txt_peso.Enabled = True
                                msk_fe_desp.Enabled = True
                                txt_obs.Enabled = True
                                cbo_ampm.Enabled = True
                                cbo_vend.Enabled = True
                                cbo_movil.Enabled = True
                                cmd_modif_guia.Enabled = False
                                cmd_guardar.Enabled = True
                                txt_rut.Select()
                            End If



                        Else
                            MsgBox("DEBE INGRESAR UN NUMERO VÁLIDO DE GUIA PARA CONTROLAR", MsgBoxStyle.Critical)
                            txt_nroguia.Select()

                        End If
                    Else

                        If ch_anio_ant.Checked = True Then
                            If emp_entrada = 1 Then   'cintegral
                                Call ConectaCint2()
                                Call elano()
                                miano = miano - 1
                            Else                       'global
                                Call ConectaGlo2()
                                Call elano()
                                miano = miano - 1
                            End If
                        Else
                            If emp_entrada = 1 Then  'cintegral
                                Call ConectaCint()
                                Call elano()
                            Else                     'global
                                Call ConectaGlo()
                                Call elano()
                            End If
                        End If


                        If conexion.State = 1 Then conexion.Close()
                        'la abre 
                        conexion.Open()

                        'entrega el valor a la variable para buscar

                        sql = "Select * From guias_dp Where nguia = '" & txt_nroguia.Text & "'"
                        com7 = New MySqlCommand(sql, conexion)

                        rs7 = com7.ExecuteReader()
                        If rs7.HasRows = True Then

                            MsgBox("A VER!!! LA GUIA YA EXISTE Y NO PUEDE REGISTRARLA.", MsgBoxStyle.Critical, "Validación de Guía.")


                            txt_rut.Enabled = False
                            txt_nombre.Enabled = False
                            txt_direccion.Enabled = False
                            txt_cedible.Enabled = False
                            cbo_tp.Enabled = False
                            cbo_ciudad.Enabled = False
                            cbo_chofer.Enabled = False
                            cbo_despachador.Enabled = False
                            txt_nrobulto.Enabled = False
                            txt_nroflete.Enabled = False
                            txt_peso.Enabled = False
                            msk_fe_desp.Enabled = False
                            txt_obs.Enabled = False
                            cbo_ampm.Enabled = False
                            cbo_movil.Enabled = False
                            cmd_modif_guia.Enabled = False
                            cmd_guardar.Enabled = False
                            txt_nroguia.Select()

                        Else


                            ' MsgBox("LA GUIA NO EXISTE, RELLENE LOS DATOS FALTANTES.", MsgBoxStyle.Information, "Validación de Guía.")

                            txt_rut.Enabled = True
                            txt_nombre.Enabled = True
                            txt_direccion.Enabled = True
                            txt_cedible.Enabled = True
                            cbo_tp.Enabled = True
                            cbo_ciudad.Enabled = True
                            cbo_chofer.Enabled = True
                            cbo_despachador.Enabled = True
                            txt_nrobulto.Enabled = True
                            txt_nroflete.Enabled = True
                            txt_peso.Enabled = True
                            msk_fe_desp.Enabled = True
                            txt_obs.Enabled = True
                            cbo_ampm.Enabled = True
                            cbo_vend.Enabled = True
                            cbo_movil.Enabled = True
                            cmd_modif_guia.Enabled = False
                            cmd_guardar.Enabled = True
                            txt_rut.Select()
                        End If



                    End If

                End If

            End If



        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub



    Private Sub txt_nrofact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nrofact.KeyPress


        Dim com11 As New MySqlCommand
        Dim rs11 As MySqlDataReader
        Dim valorfact As String
        Dim cmd23 As MySqlCommand
        Dim rs23 As MySqlDataReader

        'Try
        If e.KeyChar = Convert.ToChar(13) Then

            If ch_anio_ant.Checked = True Then
                If emp_entrada = 1 Then   'cintegral
                    Call ConectaCint2()
                    Call elano()
                    miano = miano - 1
                Else                       'global
                    Call ConectaGlo2()
                    Call elano()
                    miano = miano - 1
                End If
            Else
                If emp_entrada = 1 Then  'cintegral
                    Call ConectaCint()
                    Call elano()
                Else                     'global
                    Call ConectaGlo()
                    Call elano()
                End If
            End If


            'valorfact = "FEL0000" & txt_nrofact.Text
            valorfact = txt_nrofact.Text

            Call Valida_Fact_dp()
            If bandera = True Then
                MsgBox("La Factura ya se encuentra Utilizada en un Despacho, no puede volver a utilizar", MsgBoxStyle.Critical)
                cmd_asigna_fact.Enabled = False

                Exit Sub
            Else

                If conexion.State = 1 Then conexion.Close()
                'la abre 
                conexion.Open()

                'entrega el valor a la variable para buscar

                'sql = "Select * From venta Where tipocon = '" & valorfact & "'"
                sql = "Select * From ventas left join referencias on ventas.id = referencias.id_doc Where folio = '" & valorfact & "'"
                com11 = New MySqlCommand(sql, conexion)

                rs11 = com11.ExecuteReader()
                If rs11.HasRows = True Then

                    rs11.Read()
                    lbl_fe_docto.Text = CStr(rs11("fecha_emision"))
                    lbl_monto.Text = CStr(rs11("monto_neto"))
                    lbl_noc.Text = CStr(rs11("folio_ref"))
                    lbl_vend.Text = CStr(rs11("vendedor"))

                    cmd_asigna_fact.Enabled = True
                Else
                    MsgBox("La Factura No Existe, verifique!", MsgBoxStyle.Critical)
                    Exit Sub
                End If




                If conexion.State = 1 Then conexion.Close()
                'la abre 
                conexion.Open()
                sql = ""
                sql = "Select nombre_usuario from usuarios where num_vendedor = '" & lbl_vend.Text & "'"
                cmd23 = New MySqlCommand(sql, conexion)
                rs23 = cmd23.ExecuteReader()
                If rs23.HasRows = True Then

                    rs23.Read()
                    nombrev = CStr(rs23("nombre_usuario"))

                Else
                    MsgBox("El codigo del vendedor no fue encontrado", MsgBoxStyle.Exclamation)


                End If
            End If
        End If

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub op_cliente_CheckedChanged(sender As Object, e As EventArgs) Handles op_cliente.CheckedChanged
        If op_cliente.Checked = True Then
            valdestino = 0
            op_prov.Checked = False

            ch_guia_normal.Enabled = True
            ch_guia_garant.Enabled = True

        End If
    End Sub

    Private Sub op_prov_CheckedChanged(sender As Object, e As EventArgs) Handles op_prov.CheckedChanged
        If op_prov.Checked = True Then
            valdestino = 1
            op_cliente.Checked = False

            ch_guia_normal.Enabled = True
            ch_guia_garant.Enabled = True

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If counter >= 2 Then
            ' Exit loop code.  
            Timer1.Enabled = True
            counter = 0

            Ultimo_nrodp()

        Else
            ' Run your procedure here.  
            ' Increment counter.  

            counter = counter + 1
            lbl_hora.Text = "Refresco Nro Dp Interno en 2 seg: " & counter.ToString
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If txt_nombre.Text <> "" Then
                txt_nombre.CharacterCasing = CharacterCasing.Upper
                txt_direccion.Select()
            Else
                txt_nombre.Select()
            End If

        End If
    End Sub


    Private Sub txt_direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_direccion.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If txt_direccion.Text <> "" Then
                txt_direccion.CharacterCasing = CharacterCasing.Upper
                cbo_vend.Select()
            Else
                txt_direccion.Select()
            End If

        End If
    End Sub


    Private Sub cbo_vend_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_vend.SelectedValueChanged
        If cbo_vend.Text <> "" Then
            cbo_ciudad.Select()
        Else
            cbo_vend.Select()
        End If
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Dim cmd10 As New MySqlCommand
        Dim valgarant As String


        Try

            Call Valida_Campos()
            If bandera = True Then
                cmd_guardar.Enabled = False
                Exit Sub
            Else
                If txt_rut.Text = "" Or txt_nroguia.Text = "" Then

                    MsgBox("DEBE INGRESAR UN RUT E INGRESAR UN NRO DE GUIA PARA REGISTRAR", MsgBoxStyle.Critical, "Verificación de Campos")
                    cmd_guardar.Enabled = False
                    Exit Sub
                Else

                    Ultimo_nrodp()

                    If ch_anio_ant.Checked = True Then
                        If emp_entrada = 1 Then   'cintegral
                            Call ConectaCint2()
                            Call elano()
                            miano = miano - 1
                        Else                       'global
                            Call ConectaGlo2()
                            Call elano()
                            miano = miano - 1
                        End If
                    Else
                        If emp_entrada = 1 Then  'cintegral
                            Call ConectaCint()
                            Call elano()
                        Else                     'global
                            Call ConectaGlo()
                            Call elano()
                        End If
                    End If

                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    If ch_guia_garant.Checked = True Then
                        valgarant = "SI"
                    Else
                        valgarant = "NO"
                    End If

                    If op_cliente.Checked = True Then
                        valdestino = 0 'cliente
                    Else
                        valdestino = 1 'proveedor
                    End If

                    cmd10 = New MySqlCommand("Insert Into guias_dp (nguia, nrodp, rutclie, nombre, direccion, fe_desp, patente, transporte, nflete, nro_rece, vendedor, chofer, despachador, nrobultos, h_salida, gramos, fe_creacion, comuna, obs_despacho_guia, usuario, destino, isgarant) " &
                                            " Values ('" & txt_nroguia.Text & "', '" & lbl_nroreg.Text & "', '" & txt_rut.Text & "', '" & txt_nombre.Text & "', '" & txt_direccion.Text & "', '" & msk_fe_desp.Text & "', '" & lbl_patente.Text & "', '" & cbo_tp.Text & "', '" & txt_nroflete.Text & "', '" & txt_cedible.Text & "', '" & cbo_vend.Text & "', '" & cbo_chofer.Text & "', '" & cbo_despachador.Text & "', '" & txt_nrobulto.Text & "', '" & cbo_ampm.Text & "', '" & txt_peso.Text & "', '" & lbl_fe_actual.Text & "', '" & cbo_ciudad.Text & "', '" & txt_obs.Text & "', '" & retenUser & "', '" & valdestino & "', '" & valgarant & "')", conexion)
                    cmd10.ExecuteNonQuery()
                    conexion.Close()

                    MsgBox("Datos Almacenados", MsgBoxStyle.Information)
                    Mnu_LimpiarVentana.PerformClick()
                    Ultimo_nrodp()


                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub msk_fe_desp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_desp.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_desp.Text <> "    -  -" Then
                cbo_ampm.Select()
            Else
                msk_fe_desp.Select()
            End If


        End If
    End Sub

    Private Sub Mnu_Salir_Click(sender As Object, e As EventArgs) Handles Mnu_Salir.Click
        Me.Dispose()
        frm_Menu.Show()

    End Sub

    Private Sub Mnu_LimpiarVentana_Click(sender As Object, e As EventArgs) Handles Mnu_LimpiarVentana.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_ing_guia_sinfact_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub frm_ing_guia_sinfact_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()

    End Sub

    Private Sub txt_nroflete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nroflete.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If txt_nroflete.Text <> "" Then
                txt_cedible.Select()
            Else
                txt_nroflete.Select()

            End If

        End If
    End Sub

    Private Sub txt_nrofact_TextChanged(sender As Object, e As EventArgs) Handles txt_nrofact.TextChanged

    End Sub

    Private Sub Mnu_BuscarNroGuia_Click(sender As Object, e As EventArgs) Handles Mnu_BuscarNroGuia.Click

        Dim com As New MySqlCommand
        Dim com4 As New MySqlCommand
        Dim cmd4 As New MySqlCommand
        Dim rs4 As MySqlDataReader

        'id, nrodp, nfactura, nguia, direccion, comuna, rutclie, nombre, fe_docto, fe_desp, transporte, patente, nflete, 
        'recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos,
        'fe_creacion, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant, destino
        Dim sql As String
        Dim garantia As String
        Dim eldestino As Integer

        Dim ret0 As Integer 'id
        Dim ret1 As Integer 'nrodp
        Dim ret2 As String 'nfactura
        Dim ret3 As Integer 'nguia
        Dim ret4 As String 'direccion
        Dim ret5 As String 'comuna
        Dim ret6 As String 'rutclie
        Dim ret7 As String 'nombre
        Dim ret8 As String 'fe_docto
        Dim ret9 As String 'fe_desp
        Dim ret10 As String 'transporte
        Dim ret11 As String 'patente
        Dim ret12 As String 'nflete
        Dim ret13 As String 'recibio
        Dim ret14 As String 'fe_reingreso
        Dim ret15 As String 'nro_rece
        Dim ret16 As String 'fe_cliente
        Dim ret17 As String 'vendedor
        Dim ret18 As String 'chofer
        Dim ret19 As String 'despachador
        Dim ret20 As Integer 'nrobultos
        Dim ret21 As String 'h_salida
        Dim ret22 As String 'noc
        Dim ret23 As Integer 'gramos
        Dim ret24 As String 'fe_creacion
        Dim ret25 As String 'obs_reingreso_guia
        Dim ret26 As String 'obs_despacho_guia
        Dim ret27 As String 'usuario
        Dim ret28 As String 'usuario_reing
        Dim ret29 As String  'isgarant
        Dim ret30 As Integer 'destino


        'Try

        Dim valret As String

            valret = InputBox("Ingrese Nro de Guía", "Buscar Despacho con Guía", "0")


            If ch_anio_ant.Checked = True Then
                If emp_entrada = 1 Then   'cintegral
                    Call ConectaCint2()
                    Call elano()
                    miano = miano - 1
                Else                       'global
                    Call ConectaGlo2()
                    Call elano()
                    miano = miano - 1
                End If
            Else
                If emp_entrada = 1 Then  'cintegral
                    Call ConectaCint()
                    Call elano()
                Else                     'global
                    Call ConectaGlo()
                    Call elano()
                End If
            End If

            lbl_nroreg.Visible = False
            lbl_nroreg2.Visible = True


            If conexion.State = 1 Then conexion.Close()
            'la abre 
            conexion.Open()

            'entrega el valor a la variable para buscar

            sql = "Select id, nrodp, nfactura, nguia, direccion, comuna, rutclie, nombre, fe_docto, fe_desp, transporte, patente, nflete, recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos, fe_creacion, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant, destino From guias_dp Where nguia = '" & valret & "'"
            com = New MySqlCommand(sql, conexion)

            rs4 = com.ExecuteReader()
            If rs4.HasRows() Then
                rs4.Read()

            ret0 = (rs4.GetUInt32(0)) 'id
            ret1 = (rs4.GetUInt32(1)) 'nrodp
            If Not IsDBNull(rs4(2)) Then 'nfactura
                ret2 = rs4.GetUInt32(2)

            Else
                ret2 = "0"
            End If

            If Not IsDBNull(rs4(3)) Then 'nguia
                ret3 = rs4.GetUInt32(3)

            Else
                ret3 = "0"
            End If
            If Not IsDBNull(rs4(4)) Then 'direccion
                ret4 = rs4.GetString(4)

            Else
                ret4 = ""
            End If
            If Not IsDBNull(rs4(5)) Then 'comuna
                ret5 = rs4.GetString(5)

            Else
                ret5 = ""
            End If
            If Not IsDBNull(rs4(6)) Then 'rutclie
                ret6 = rs4.GetString(6)

            Else
                ret6 = ""
            End If
            If Not IsDBNull(rs4(7)) Then 'nombre
                ret7 = rs4.GetString(7)

            Else
                ret7 = ""
            End If

            If Not IsDBNull(rs4(8)) Then 'fe_docto
                ret8 = rs4.GetString(8)

            Else
                ret8 = ""
            End If
            If Not IsDBNull(rs4(9)) Then 'fe_desp
                ret9 = rs4.GetString(9)

            Else
                ret9 = ""
            End If
            If Not IsDBNull(rs4(10)) Then 'transporte
                ret10 = rs4.GetString(10)

            Else
                ret10 = ""
            End If
            If Not IsDBNull(rs4(11)) Then 'patente
                ret11 = rs4.GetString(11)

            Else
                ret11 = ""
            End If
            If Not IsDBNull(rs4(12)) Then 'nflete
                ret12 = rs4.GetString(12)

            Else
                ret12 = ""
            End If
            If Not IsDBNull(rs4(13)) Then 'recibio
                ret13 = rs4.GetString(13)

            Else
                ret13 = ""
            End If
            If Not IsDBNull(rs4(14)) Then 'fe_reingreso
                ret14 = rs4.GetString(14)

            Else
                ret14 = ""
            End If
            If Not IsDBNull(rs4(15)) Then 'nro_rece
                ret15 = rs4.GetString(15)

            Else
                ret15 = ""
            End If
            If Not IsDBNull(rs4(16)) Then 'fe_cliente
                ret16 = rs4.GetString(16)

            Else
                ret16 = ""
            End If
            If Not IsDBNull(rs4(17)) Then 'vendedor
                ret17 = rs4.GetString(17)

            Else
                ret17 = ""
            End If
            If Not IsDBNull(rs4(18)) Then 'chofer
                ret18 = rs4.GetString(18)

            Else
                ret18 = ""
            End If
            If Not IsDBNull(rs4(19)) Then 'despachador
                ret19 = rs4.GetString(19)

            Else
                ret19 = ""
            End If
            If Not IsDBNull(rs4(20)) Then 'nrobultos
                ret20 = rs4.GetString(20)

            Else
                ret20 = ""
            End If
            If Not IsDBNull(rs4(21)) Then 'h_salida
                ret21 = rs4.GetString(21)

            Else
                ret21 = ""
            End If
            If Not IsDBNull(rs4(22)) Then 'noc
                ret22 = rs4.GetString(22)

            Else
                ret22 = ""
            End If
            If Not IsDBNull(rs4(23)) Then 'gramos
                ret23 = rs4.GetString(23)

            Else
                ret23 = ""
            End If
            If Not IsDBNull(rs4(24)) Then 'fe_creacion
                ret24 = rs4.GetString(24)

            Else
                ret24 = ""
            End If
            If Not IsDBNull(rs4(25)) Then 'obs_reingreso_guia
                ret25 = rs4.GetString(25)

            Else
                ret25 = ""
            End If
            If Not IsDBNull(rs4(26)) Then 'obs_despacho_guia
                ret26 = rs4.GetString(26)

            Else
                ret26 = ""
            End If
            If Not IsDBNull(rs4(27)) Then 'usuario
                ret27 = rs4.GetString(27)

            Else
                ret27 = ""
            End If
            If Not IsDBNull(rs4(28)) Then 'usuario_reing
                ret28 = rs4.GetString(28)

            Else
                ret28 = ""
            End If
            If Not IsDBNull(rs4(29)) Then 'is_garant
                ret29 = rs4.GetString(29)

            Else
                ret29 = ""
            End If
            If Not IsDBNull(rs4(30)) Then 'destino
                ret30 = rs4.GetString(30)

            Else
                ret30 = ""
            End If



            txt_nroguia.Text = valret
                txt_nroguia.Enabled = False
                lbl_idbd.Text = ret0
                txt_rut.Text = ret6
                txt_nombre.Text = ret7
                txt_nroflete.Text = ret12
                cbo_tp.Text = ret10
                txt_nrofact.Text = ret2
                cbo_vend.Text = ret17
                txt_direccion.Text = ret4
                lbl_nroreg2.Text = ret0
                txt_cedible.Text = ret15
                txt_nrobulto.Text = ret20
                txt_peso.Text = ret23
                cbo_ciudad.Text = ret5
                cbo_chofer.Text = ret18
                lbl_patente.Text = ret11
                cbo_despachador.Text = ret19
                msk_fe_desp.Text = ret9
                txt_obs.Text = ret26
                cbo_ampm.Text = ret21
                lbl_usr_reing.Text = ret28
                garantia = ret29

                'marca si es guia garantia o normal 
                If garantia = "NO" Then
                    ch_guia_normal.Checked = True
                    ch_guia_normal.Enabled = False
                    ch_guia_garant.Enabled = False
                Else
                    ch_guia_garant.Checked = True
                    ch_guia_garant.Enabled = False
                    ch_guia_normal.Checked = False
                End If
                eldestino = ret30
                If eldestino = 0 Then
                    op_cliente.Checked = True
                    op_prov.Checked = False
                Else
                    op_cliente.Checked = False
                    op_prov.Checked = True
                End If
                'RECIBE
                lbl_recepciono.Text = ret13 'recibio
                'FECHA RECEPCION CLIENTE
                lbl_fe_recep.Text = ret16  'fecha recepcion
                'FECHA REINGRESO
                lbl_fe_reing.Text = ret14
                'USUARIO REINGRESO
                lbl_usr_reing.Text = ret28
                'Observacion Reingreso
                lbl_obs_reing.Text = ret25

                rs4.Dispose()
                conexion.Close()
                com.Dispose()

            Else
                bandera = False
                MsgBox("No se pudo detectar el ID de Compra", MsgBoxStyle.Exclamation)

                Exit Sub
            End If




        'Catch ex As Exception
        ' MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        'End Try


    End Sub

    Private Sub C_CheckedChanged(sender As Object, e As EventArgs) Handles ch_asigna_fact.CheckedChanged
        If ch_asigna_fact.Checked = True Then
            txt_nrofact.Enabled = True
            txt_nrofact.Select()
        Else
            txt_nrofact.Enabled = False
        End If
    End Sub

    Private Sub cmd_modif_guia_Click(sender As Object, e As EventArgs) Handles cmd_modif_guia.Click
        Dim valret2 As String

        valret2 = MsgBox("¿Desea modificar parte de los campos ya registrados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Editar valores")

        If valret2 = 6 Then

            txt_nroguia.Enabled = False
            txt_direccion.Enabled = True
            txt_cedible.Enabled = True
            cbo_tp.Enabled = True
            cbo_ciudad.Enabled = True
            cbo_chofer.Enabled = True
            cbo_despachador.Enabled = True
            txt_nrobulto.Enabled = True
            txt_nroflete.Enabled = True
            txt_peso.Enabled = True
            msk_fe_desp.Enabled = True
            txt_obs.Enabled = True
            cbo_ampm.Enabled = True
            cbo_tp.Enabled = True
            cbo_movil.Enabled = True

            txt_nrofact.Enabled = True
            cmd_asigna_fact.Enabled = False
            ch_asigna_fact.Enabled = True
            cmd_modif_guia.Visible = False
            cmd_modif_guia2.Visible = True
            cmd_modif_guia2.Enabled = True
            cmd_guardar.Enabled = False
            txt_nrofact.Enabled = False

            op_cliente.Enabled = False
            op_prov.Enabled = False
            ch_asigna_fact.Checked = False


        Else
            txt_direccion.Enabled = False
            txt_cedible.Enabled = False
            cbo_tp.Enabled = False
            cbo_ciudad.Enabled = False
            cbo_chofer.Enabled = False
            cbo_despachador.Enabled = False
            txt_nrobulto.Enabled = False
            txt_nroflete.Enabled = False
            txt_peso.Enabled = False
            msk_fe_desp.Enabled = False
            txt_obs.Enabled = False
            cbo_ampm.Enabled = False
            cbo_tp.Enabled = False
            ch_asigna_fact.Enabled = False

            cmd_modif_guia.Visible = True
            cmd_modif_guia2.Visible = False
            cmd_guardar.Enabled = False
            cmd_asigna_fact.Enabled = False
            txt_nrofact.Enabled = False
            op_cliente.Enabled = True
            op_prov.Enabled = True
        End If
    End Sub

    Private Sub cmd_modif_guia2_Click(sender As Object, e As EventArgs) Handles cmd_modif_guia2.Click
        Dim cmd14 As MySqlCommand = New MySqlCommand
        Dim conf As Integer = 0

        Try

            If ch_anio_ant.Checked = True Then
                If emp_entrada = 1 Then   'cintegral
                    Call ConectaCint2()
                    Call elano()
                    miano = miano - 1
                Else                       'global
                    Call ConectaGlo2()
                    Call elano()
                    miano = miano - 1
                End If
            Else
                If emp_entrada = 1 Then  'cintegral
                    Call ConectaCint()
                    Call elano()
                Else                     'global
                    Call ConectaGlo()
                    Call elano()
                End If
            End If

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            cmd14 = New MySqlCommand("Update guias_dp Set direccion = '" & txt_direccion.Text & "',  nro_rece= '" & txt_cedible.Text & "', transporte ='" & cbo_tp.Text & "', nflete ='" & txt_nroflete.Text & "', nrobultos ='" & txt_nrobulto.Text & "', gramos ='" & txt_peso.Text & "', comuna ='" & cbo_ciudad.Text & "', chofer ='" & cbo_chofer.Text & "', patente = '" & lbl_patente.Text & "', obs_despacho_guia = '" & txt_obs.Text & "', despachador = '" & cbo_despachador.Text & "', fe_desp = '" & msk_fe_desp.Text & "', usuario = '" & retenUser & "'  WHERE id = '" & lbl_idbd.Text & "'", conexion)

            cmd14.ExecuteNonQuery()
            conexion.Close()
            cmd14.Dispose()

            MsgBox("Modificación realizada.", MsgBoxStyle.Information)

            txt_direccion.Enabled = True
            txt_cedible.Enabled = True
            cbo_tp.Enabled = True
            cbo_ciudad.Enabled = True
            cbo_chofer.Enabled = True
            cbo_despachador.Enabled = True
            txt_nrobulto.Enabled = True
            txt_nroflete.Enabled = True
            txt_peso.Enabled = True
            msk_fe_desp.Enabled = True
            txt_obs.Enabled = True
            cbo_ampm.Enabled = True
            cbo_tp.Enabled = True

            cmd_modif_guia.Visible = False
            cmd_modif_guia2.Visible = True
            cmd_modif_guia2.Enabled = True
            cmd_guardar.Enabled = False
            cmd_asigna_fact.Enabled = False

            cmd14.Dispose()
            conexion.Close()

            Mnu_LimpiarVentana_Click(Mnu_LimpiarVentana, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub txt_cedible_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedible.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If txt_cedible.Text <> "" Then
                txt_nrobulto.Select()
            Else
                txt_cedible.Select()

            End If

        End If
    End Sub

    Private Sub cbo_tp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tp.SelectedIndexChanged
        Select Case cbo_tp.Text
            Case "URBANO"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"
                cbo_movil.Enabled = False

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                txt_nroflete.Select()

            Case "T.L.N"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"
                cbo_movil.Enabled = False
                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                txt_nroflete.Select()

            Case "STARKEN CTA CTE"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"
                cbo_movil.Enabled = False
                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                txt_nroflete.Select()

            Case "STARKEN POR PAGAR"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                txt_nroflete.Select()

            Case "TRANSCOM"
                txt_nroflete.Text = "0"
                txt_cedible.Text = "0"
                txt_nroflete.Enabled = False
                txt_cedible.Enabled = False
                cbo_tp.Enabled = True
                cbo_chofer.Enabled = True
                cbo_chofer.Text = ""
                txt_peso.Text = "400"
                txt_nrobulto.Select()

            Case "CHILEXPRESS"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True

            Case "CHILEXPRESS POR PAGAR"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                txt_nroflete.Select()

            Case "CORREOS DE CHILE"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True

            Case "TUR BUS"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True

            Case "RETIRA CLIENTE"
                cbo_movil.Text = "RETIRA CLIENTE"
                cbo_chofer.Text = "NO DEFINIDO"
                cbo_chofer.Enabled = False
                cbo_movil.Enabled = False
                lbl_patente.Text = "0"

            Case "OTROS"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                txt_nroflete.Select()

            Case "BLUE EXPRESS"
                cbo_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                cbo_movil.Text = "TRASPORTE EXTERNO"

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                txt_nroflete.Select()
        End Select
    End Sub

    Private Sub cbo_chofer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_chofer.SelectedValueChanged
        If cbo_chofer.Text <> "" Then
            cbo_movil.Select()
        Else
            cbo_chofer.Select()
        End If
    End Sub

    Private Sub cbo_despachador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_despachador.SelectedIndexChanged

    End Sub

    Private Sub cbo_despachador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_despachador.SelectedValueChanged
        If cbo_despachador.Text <> "" Then
            txt_obs.Select()
        Else
            cbo_despachador.Select()
        End If
    End Sub

    Private Sub txt_rut_Leave(sender As Object, e As EventArgs) Handles txt_rut.Leave
        'Dim texto1 As String = txt_rut.Text
        'txt_rut.Text = QuitarCaracteres(texto1)
        'texto1 = cadenadevuelta

        'agrega 0 a la izquierda del rut
        'txt_rut.Text = texto1.PadLeft(10, "0")
    End Sub

    Private Sub cmd_asigna_fact_Click(sender As Object, e As EventArgs) Handles cmd_asigna_fact.Click
        Dim myCommand As New MySqlCommand
        Dim SQL As String
        Dim val1 As Integer 'guarda el id de bd
        Dim val2 As String 'guarda el usuario que registra

        'Try


        If ch_anio_ant.Checked = True Then
            If emp_entrada = 1 Then   'cintegral
                Call ConectaCint2()
                Call elano()
                miano = miano - 1
            Else                       'global
                Call ConectaGlo2()
                Call elano()
                miano = miano - 1
            End If
        Else
            If emp_entrada = 1 Then  'cintegral
                Call ConectaCint()
                Call elano()
            Else                     'global
                Call ConectaGlo()
                Call elano()
            End If
        End If


        conexion.Open()

        'asigna el id de la bd para actualizar
        val1 = lbl_idbd.Text

        'asigna el usuario que registra
        val2 = retenUser


        myCommand.Connection = conexion
        SQL = "UPDATE guias_dp SET nfactura = '" & txt_nrofact.Text & "', fe_docto = '" & lbl_fe_docto.Text & "', noc = '" & lbl_noc.Text & "', vendedor = '" & nombrev & "', usuario_reing = '" & val2 & "' WHERE id = '" & val1 & "'"

        myCommand.CommandText = SQL
        myCommand.ExecuteNonQuery()
        MsgBox("Modificacion realizada con el Nrodp ---->" & lbl_nroreg.Text, MsgBoxStyle.Information)
        SQL = ""
        myCommand.Dispose()
        conexion.Close()
        Mnu_LimpiarVentana.PerformClick()



        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub mnu_eliminar_reg_Click(sender As Object, e As EventArgs) Handles mnu_eliminar_reg.Click
        Dim myCommand As New MySqlCommand
        Dim SQL As String
        Dim val1 As Integer 'pregunta


        'Try


        If ch_anio_ant.Checked = True Then
            If emp_entrada = 1 Then   'cintegral
                Call ConectaCint2()
                Call elano()
                miano = miano - 1
            Else                       'global
                Call ConectaGlo2()
                Call elano()
                miano = miano - 1
            End If
        Else
            If emp_entrada = 1 Then  'cintegral
                Call ConectaCint()
                Call elano()
            Else                     'global
                Call ConectaGlo()
                Call elano()
            End If
        End If


        conexion.Open()


        val1 = MsgBox("¿Desea Eliminar la guia de despacho?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Eliminar Guia")

        If val1 = 6 Then
            myCommand.Connection = conexion
            conexion.Open()
            SQL = "DELETE From guias_dp Where id ='" & lbl_nroreg2.Text & "'"

            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()
            MsgBox("Eliminación Existosa", MsgBoxStyle.Information)
            SQL = ""
            myCommand.Dispose()
            conexion.Close()
            Mnu_LimpiarVentana.PerformClick()
        Else
            MsgBox("No se eliminó ningun documento", MsgBoxStyle.Information)
        End If


        'Catch ex As Exception

        'End Try
    End Sub
End Class
