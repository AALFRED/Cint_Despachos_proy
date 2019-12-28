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


Public Class frm_ing_guia_trasp

    Dim reseña As Integer
    Dim bandera As Boolean
    Dim fecha_actual As String
    Dim resultado_origen As String
    Dim resultado_destino As String



    Sub bloqueo_campos()
        cbo_bod_origen_gt.Enabled = False
        cbo_bod_destino_gt.Enabled = False
        txt_obs_ing_gt.Enabled = False
        txt_nrobultos_gt.Enabled = False
        txt_peso_gt.Enabled = False
        cbo_chofer_gt.Enabled = False
        cbo_transp_gt.Enabled = False
        msk_fe_desp_gt.Enabled = False
        txt_direccion_gt.Enabled = False

        cbo_rut_emp_gt.Enabled = False
    End Sub

    Sub activo_campos()
        cbo_bod_origen_gt.Enabled = False
        cbo_bod_destino_gt.Enabled = False
        txt_obs_ing_gt.Enabled = True
        txt_nrobultos_gt.Enabled = True
        txt_peso_gt.Enabled = True
        cbo_chofer_gt.Enabled = True
        cbo_transp_gt.Enabled = True
        msk_fe_desp_gt.Enabled = True
        txt_direccion_gt.Enabled = True

        cbo_rut_emp_gt.Enabled = False
    End Sub

    Sub Ultimo_nrodp()
        Dim com16 As New MySqlCommand
        Dim rs16 As MySqlDataReader

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

        sql = "Select MAX(nrodp) FROM guias_trasp_dp ORDER BY nrodp ASC"
        com16 = New MySqlCommand(sql, conexion)
        rs16 = com16.ExecuteReader()

        If rs16.HasRows() Then
            rs16.Read()

            lbl_nrodp_gt.Text = rs16.GetString(0)
            lbl_nrodp_gt.Text = Val(lbl_nrodp_gt.Text) + 1

            lbl_idbd_gt.Text = rs16.GetString(0)
            lbl_idbd_gt.Text = Val(lbl_idbd_gt.Text) + 1

        Else
            MessageBox.Show("No hay Correlativo Disponible", "Validacion de Correlativo")


            lbl_nrodp_gt.Text = miano & "1"
            lbl_idbd_gt.Text = miano & "1"


            Exit Sub
        End If

        rs16.Dispose()
        conexion.Close()

        'Catch ex As Exception

        'End Try

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
            Case 2 'bodega origen
                cmd1 = New MySqlCommand("SELECT " & fldName & " FROM " & TABLENAME & " where num_bodega between 2 and 20 order by " & fldName, conexion)
            Case 3 'bodega destino
                cmd1 = New MySqlCommand("SELECT " & fldName & " FROM " & TABLENAME & " where num_bodega between 2 and 20 order by " & fldName, conexion)
            Case 4 'trasporte
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 5 'bodega origen nombre
                cmd1 = New MySqlCommand("Select " & fldName & " From " & TABLENAME & " Where num_bodega = '" & lbl_bod_origen.Text & "'")
            Case 6 'bodega destino nombre
                cmd1 = New MySqlCommand("Select " & fldName & " From " & TABLENAME & " Where num_bodega = '" & lbl_bod_destino.Text & "'")

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
    Function carga_bod_origen(nom_bod As String)
        Dim cmd21 As MySqlCommand
        Dim rs21 As MySqlDataReader


        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        'sql = "Select * FROM maebode where codbod = '" & nro_bod & "'"
        sql = "Select * FROM bodegas where nombre = '" & nom_bod & "'"
        cmd21 = New MySqlCommand(sql, conexion)
        rs21 = cmd21.ExecuteReader()

        If rs21.HasRows() Then
            rs21.Read()

            resultado_origen = CStr(rs21("num_bodega"))

        Else
            MsgBox("No hay datos de la bodega", "Validación de Bodega")
        End If

        rs21.Dispose()
        conexion.Close()

        Return resultado_origen

    End Function

    Function carga_bod_destino(nom_bod As String)
        Dim cmd21 As MySqlCommand
        Dim rs21 As MySqlDataReader


        If conexion.State = 1 Then conexion.Close()
        conexion.Open()

        'sql = "Select * FROM maebode where codbod = '" & nro_bod & "'"
        sql = "Select * FROM bodegas where nombre = '" & nom_bod & "'"
        cmd21 = New MySqlCommand(sql, conexion)
        rs21 = cmd21.ExecuteReader()

        If rs21.HasRows() Then
            rs21.Read()

            resultado_destino = CStr(rs21("num_bodega"))

        Else
            MsgBox("No hay datos de la bodega", "Validacion de bodega")
        End If

        rs21.Dispose()
        conexion.Close()

        Return resultado_destino

    End Function


    Private Sub frm_ing_guia_trasp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.Text = v_emp & " / Ingresos de Guias de Traspasos **** AÑO " & miano & " **** Conectado como: " & retenUser

        Call Ultimo_nrodp()


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
        BarraStatusTexto.Width = 450
        BarraStatusTexto.Text = "CONECTADO A BD " & v_database
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)


        cbo_rut_emp_gt.Items.Add("96689970-0") 'cintegral
        cbo_rut_emp_gt.Items.Add("96661420-K") 'global



        'carga los choferes
        reseña = 1
        Call cargacombo("chofer_dp", "nom_chof", cbo_chofer_gt)

        'carga bodega origen
        reseña = 2
        Call cargacombo("bodegas", "nombre", cbo_bod_origen_gt)

        'carga bodega destino
        reseña = 3
        Call cargacombo("bodegas", "nombre", cbo_bod_destino_gt)

        'carga medios
        reseña = 4
        Call cargacombo("medios_dp", "tipo", cbo_transp_gt)



        lbl_empresa_gt.Text = ""
        lbl_usuario_gt.Text = retenUser

        lbl_bod_origen.Text = ""
        lbl_bod_destino.Text = ""
        lbl_ciu_trasp.Text = ""
        lbl_patente_gt.Text = ""
        lbl_sol_tras.Text = ""
        lbl_usuario_gt.Text = ""
        lbl_idbd_gt.Text = ""
        lbl_fe_trasp.Text = ""
        lbl_empresa_gt.Text = ""
        lbl_sol_tras.Text = ""
        lbl_ciu_trasp.Text = ""


        Call bloqueo_campos()


        cmd_guardar_gt.Enabled = False
        cmd_modif_gt.Enabled = False
        cmd_guardar_datos_gt.Visible = False

    End Sub

    Private Sub cbo_rut_emp_gt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_rut_emp_gt.SelectedIndexChanged

    End Sub

    Private Sub cbo_rut_emp_gt_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_rut_emp_gt.SelectedValueChanged
        If cbo_rut_emp_gt.Text = "96689970-0" Then
            lbl_empresa_gt.Text = "Computacion Integral S.A. (Telemarketing)"
            txt_direccion_gt.Text = "Libertad # 749, Viña del Mar"


        Else
            cbo_rut_emp_gt.Text = "96661420-K"
            lbl_empresa_gt.Text = "Servicios Computacionales Global S.A."
            txt_direccion_gt.Text = "1 Poniente 1334 - Viña del Mar"

        End If
    End Sub


    Private Sub msk_fe_desp_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_desp_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_desp_gt.Text <> "    -  -" Then
                cbo_transp_gt.Select()
            Else
                msk_fe_desp_gt.Select()
            End If


        End If
    End Sub

    Private Sub cbo_transp_gt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_transp_gt.SelectedIndexChanged
        If cbo_transp_gt.Text <> "" Then

            Dim cmd18 As MySqlCommand
            Dim rs18 As MySqlDataReader

            If conexion.State = 1 Then conexion.Close()
            conexion.Open()

            sql = "Select patente FROM medios_dp where tipo = '" & cbo_transp_gt.Text & "'"
            cmd18 = New MySqlCommand(sql, conexion)
            rs18 = cmd18.ExecuteReader()

            If rs18.HasRows() Then
                rs18.Read()

                lbl_patente_gt.Text = rs18.GetString(0)

            Else
                MessageBox.Show("No hay datos del móvil", "Validacion de patente")


                Exit Sub
            End If

            rs18.Dispose()
            conexion.Close()


            cbo_chofer_gt.Select()
        Else
            cbo_transp_gt.Select()
        End If
    End Sub

    Private Sub cbo_transp_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_transp_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If cbo_transp_gt.Text <> "" Then

                Dim cmd18 As MySqlCommand
                Dim rs18 As MySqlDataReader

                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                sql = "Select patente FROM medios_dp where tipo = '" & cbo_transp_gt.Text & "'"
                cmd18 = New MySqlCommand(sql, conexion)
                rs18 = cmd18.ExecuteReader()

                If rs18.HasRows() Then
                    rs18.Read()

                    lbl_patente_gt.Text = rs18.GetString(0)

                Else
                    MessageBox.Show("No hay datos del móvil", "Validacion de patente")


                    Exit Sub
                End If

                rs18.Dispose()
                conexion.Close()


                cbo_chofer_gt.Select()
            Else
                cbo_transp_gt.Select()
            End If

        End If
    End Sub

    Private Sub cbo_chofer_gt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_chofer_gt.SelectedIndexChanged
        If cbo_chofer_gt.Text <> "" Then

            txt_peso_gt.Select()
        Else
            cbo_chofer_gt.Select()


        End If
    End Sub

    Private Sub cbo_chofer_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_chofer_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If cbo_chofer_gt.Text <> "" Then
                txt_peso_gt.Select()

            Else
                cbo_chofer_gt.Select()


            End If
        End If

    End Sub

    Private Sub cmd_guardar_gt_Click(sender As Object, e As EventArgs) Handles cmd_guardar_gt.Click
        Dim cmd15 As New MySqlCommand

        Try


            If bandera = False Then
                cmd_guardar_gt.Enabled = False
                Exit Sub
            Else
                If cbo_rut_emp_gt.Text = "" Or lbl_empresa_gt.Text = "" Then

                    MsgBox("DEBE SELECCIONAR UNA EMPRESA PARA CREAR LA GUIA", MsgBoxStyle.Critical, "Verificación de Campos")
                    cmd_guardar_gt.Enabled = False
                    Exit Sub
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

                    Call Ultimo_nrodp()

                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    cmd15 = New MySqlCommand("Insert Into guias_trasp_dp (nrodp, nguia, bod_origen, bod_destino, fe_trasp, rut_trasp, nom_trasp, dir_trasp, fe_desp, transporte, patente, chofer, gramos,  nrobultos, obs_ingreso, usr_registro, confirmacion) " &
                                            " Values ('" & lbl_nrodp_gt.Text & "', '" & txt_guia_gt.Text & "', '" & cbo_bod_origen_gt.Text & "', '" & cbo_bod_destino_gt.Text & "', '" & lbl_fe_trasp.Text & "', '" & cbo_rut_emp_gt.Text & "', '" & lbl_empresa_gt.Text & "', '" & txt_direccion_gt.Text & "', '" & msk_fe_desp_gt.Text & "', '" & cbo_transp_gt.Text & "', '" & lbl_patente_gt.Text & "', '" & cbo_chofer_gt.Text & "', '" & txt_peso_gt.Text & "', '" & txt_nrobultos_gt.Text & "', '" & txt_obs_ing_gt.Text & "', '" & lbl_usuario_gt.Text & "', '0')", conexion)
                    cmd15.ExecuteNonQuery()
                    conexion.Close()

                    MsgBox("Datos Almacenados", MsgBoxStyle.Information)
                    cmd_Limpiar_gt.PerformClick()



                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbo_bod_origen_gt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bod_origen_gt.SelectedIndexChanged

        If cbo_bod_origen_gt.Text <> "" Then
            bandera = True
            cbo_bod_destino_gt.Select()
        Else
            bandera = False
            cbo_bod_origen_gt.Select()


        End If
    End Sub

    Private Sub cbo_bod_origen_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_bod_origen_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If cbo_bod_origen_gt.Text <> "" Then
                bandera = True
                cbo_bod_destino_gt.Select()
            Else
                bandera = False
                cbo_bod_origen_gt.Select()
            End If


        End If
    End Sub

    Private Sub cbo_bod_destino_gt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_bod_destino_gt.SelectedIndexChanged

        If cbo_bod_destino_gt.Text <> "" Then
            bandera = True
            cmd_guardar_gt.Enabled = True
            txt_obs_ing_gt.Select()
        Else
            bandera = False
            cbo_bod_destino_gt.Select()

        End If
    End Sub

    Private Sub cbo_bod_destino_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_bod_destino_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If cbo_bod_destino_gt.Text <> "" Then
                bandera = True
                txt_obs_ing_gt.Select()
            Else
                bandera = False
                cbo_bod_destino_gt.Select()
            End If


        End If
    End Sub

    Private Sub cmd_Limpiar_gt_Click(sender As Object, e As EventArgs) Handles cmd_Limpiar_gt.Click
        Call Ultimo_nrodp()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_ing_guia_trasp_Load(e, e) 'Load everything in your form load event again

    End Sub

    Private Sub txt_guia_gt_TextChanged(sender As Object, e As EventArgs) Handles txt_guia_gt.TextChanged

    End Sub

    Private Sub txt_guia_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_guia_gt.KeyPress


        Dim com16 As MySqlCommand

        Dim rs16 As MySqlDataReader

        Dim valret4 As String
        Dim resul3 As String = ""

        Try


            'Reingreso de guias clte  TP GUIAS

            cbo_rut_emp_gt.Text = ""
            lbl_empresa_gt.Text = ""
            txt_direccion_gt.Text = ""
            lbl_fe_trasp.Text = ""
            msk_fe_desp_gt.Text = "    -  -"
            cbo_chofer_gt.Text = ""
            lbl_patente_gt.Text = ""
            cbo_chofer_gt.Text = ""
            txt_peso_gt.Text = ""
            txt_nrobultos_gt.Text = ""
            txt_obs_ing_gt.Text = ""
            Call activo_campos()


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

                valret4 = CStr(txt_guia_gt.Text)

                If conexion.State = 1 Then conexion.Close()
                'la abre 
                conexion.Open()

                'entrega el valor a la variable para buscar

                sql = "Select * From guias_trasp_dp Where nguia = '" & valret4.ToString() & "'"
                com16 = New MySqlCommand(sql, conexion)

                rs16 = com16.ExecuteReader()
                If rs16.HasRows = True Then
                    rs16.Read()

                    MsgBox("El Nro de Guia Ha sido Utilizado, debe buscar y editar! ", MsgBoxStyle.Exclamation)
                    txt_guia_gt.Select()

                    rs16.Close()
                    com16.Dispose()
                    conexion.Close()

                    Call bloqueo_campos()

                Else

                    If conexion.State = 1 Then conexion.Close()
                    'BUSCA LOS DATOS
                    Dim com20 As MySqlCommand
                    Dim rs20 As MySqlDataReader
                    Dim verif_guia As String   'verifica si la guia esta impresa o no

                    conexion.Open()
                    sql = ""
                    sql = "Select * From transferencias Where folio_interno = '" & valret4.ToString() & "'"
                    com20 = New MySqlCommand(sql, conexion)
                    rs20 = com20.ExecuteReader()

                    If rs20.HasRows = True Then
                        rs20.Read()

                        cbo_rut_emp_gt.Text = CStr(rs20("rut"))
                        lbl_empresa_gt.Text = CStr(rs20("razon_social"))
                        txt_direccion_gt.Text = CStr(rs20("direccion"))
                        lbl_sol_tras.Text = CStr(rs20("solicitante"))
                        cbo_bod_origen_gt.Text = CStr(rs20("bodega_origen"))
                        cbo_bod_destino_gt.Text = CStr(rs20("bodega_destino"))
                        lbl_fe_trasp.Text = CStr(rs20("timestamp_generacion"))
                        lbl_ciu_trasp.Text = CStr(rs20("ciudad"))
                        verif_guia = CStr(rs20("estado"))


                        rs20.Dispose()
                        com20.Dispose()

                        'Busca los nombres de las bodega
                        'Call carga_bod(lbl_bod_origen.Text)
                        Call carga_bod_origen(cbo_bod_origen_gt.Text)
                        lbl_bod_origen.Text = resultado_origen

                        'Call carga_bod(lbl_bod_destino.Text)
                        Call carga_bod_destino(cbo_bod_destino_gt.Text)
                        lbl_bod_destino.Text = resultado_destino


                        'carga la fecha actual
                        fecha_actual = System.DateTime.Now.ToString(("yyyy-MM-dd"))
                        msk_fe_desp_gt.Text = fecha_actual.ToString
                        txt_peso_gt.Text = "400"
                        txt_nrobultos_gt.Text = "1"


                        'verifica si la guia esta impresa
                        If verif_guia = "PENDIENTE" Then
                            MsgBox("Se ha detectado que la Guia no ha sido impresa, No puede despachar esta Guía, Verifique!", MsgBoxStyle.Exclamation)
                            cmd_guardar_gt.Enabled = False

                            cbo_bod_origen_gt.Enabled = False
                            cbo_bod_destino_gt.Enabled = False
                            cbo_rut_emp_gt.Enabled = False
                            txt_guia_gt.Enabled = False
                            txt_direccion_gt.Enabled = False
                            ch_anio_ant.Enabled = False
                            msk_fe_desp_gt.Enabled = False
                            txt_obs_ing_gt.Enabled = False
                            txt_peso_gt.Enabled = False
                            txt_nrobultos_gt.Enabled = False
                            cbo_chofer_gt.Enabled = False
                            cbo_transp_gt.Enabled = False
                            'lbl_patente_gt.Text = ""
                            'lbl_ciu_trasp.Text = ""
                            'lbl_usuario_gt.Text = ""
                            'lbl_sol_tras.Text = ""
                            'lbl_empresa_gt.Text = ""
                            lbl_usuario_gt.Text = retenUser

                        Else
                            cbo_bod_origen_gt.Enabled = False
                            cbo_bod_destino_gt.Enabled = False
                            cbo_rut_emp_gt.Enabled = False
                            txt_guia_gt.Enabled = False
                            cmd_guardar_gt.Enabled = True
                            lbl_usuario_gt.Text = retenUser
                        End If

                        cbo_transp_gt.Select()

                    Else

                        MsgBox("El Nro de Guía No es Válido o no Existe, verifique!", MsgBoxStyle.Critical)
                        txt_guia_gt.Select()


                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, "txt_guia_gt")
        End Try

    End Sub

    Private Sub cmd_buscar_gt_Click(sender As Object, e As EventArgs) Handles cmd_buscar_gt.Click
        Dim valret5 As String
        Dim com17 As MySqlCommand
        Dim rs17 As MySqlDataReader

        Dim ret0 As Integer
        Dim ret1 As String
        Dim ret2 As String
        Dim ret3 As String
        Dim ret4 As String
        Dim ret5 As String
        Dim ret6 As String
        Dim ret7 As String
        Dim ret8 As String
        Dim ret9 As String
        Dim ret10 As String
        Dim ret11 As String
        Dim ret12 As Integer
        Dim ret13 As Integer
        Dim ret14 As String
        Dim ret15 As String

        '  Try


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
            valret5 = ""

            valret5 = InputBox("INGRESE NRO DE GUIA A BUSCAR", "BUSCAR GUIA TRASPASO", "")
            If valret5 <> "" Then



                If conexion.State = 1 Then conexion.Close()
                'la abre 
                conexion.Open()

                'entrega el valor a la variable para buscar

                sql = "Select * From guias_trasp_dp Where nguia = '" & valret5 & "'"
                com17 = New MySqlCommand(sql, conexion)

                            rs17 = com17.ExecuteReader()
                            If rs17.HasRows = True Then
                                rs17.Read()

                                ret0 = (rs17.GetUInt32(0)) 'nrodp
                                ret1 = (rs17.GetUInt32(1)) 'nguia
                                ret2 = (rs17.GetString(2)) 'bod origen
                                ret3 = (rs17.GetString(3)) 'bod_destino
                                ret4 = (rs17.GetString(4)) 'fe_trasp
                                ret5 = (rs17.GetString(5)) 'rut_trasp
                                ret6 = (rs17.GetString(6)) 'nom_trasp
                                ret7 = (rs17.GetString(7)) 'dir_trasp
                                ret8 = (rs17.GetString(8)) 'fe_desp
                                ret9 = (rs17.GetString(9)) 'transporte
                                ret10 = (rs17.GetString(10)) 'patente
                                ret11 = (rs17.GetString(11)) 'chofer
                                ret12 = (rs17.GetString(12)) 'gramos
                                ret13 = (rs17.GetString(13)) 'nrobultos



                                If IsDBNull(rs17("obs_ingreso")) = True Then
                                    ret14 = ""
                                Else
                                    ret14 = CStr(rs17("obs_ingreso"))

                                End If

                                If IsDBNull(rs17("usr_registro")) = True Then
                                    ret15 = "sin registro"
                                Else
                                    ret15 = CStr(rs17("usr_registro"))
                                End If


                                lbl_idbd_gt.Text = ret0 'nrodp
                                lbl_nrodp_gt.Text = ret0

                                txt_guia_gt.Text = ret1
                                cbo_bod_origen_gt.Text = ret2 'bod origen
                                cbo_bod_destino_gt.Text = ret3 'bod destino
                                ret4 = Convert.ToDateTime(ret4).ToShortDateString
                                lbl_fe_trasp.Text = ret4 'fe trasp
                                cbo_rut_emp_gt.Text = ret5 'rut
                                lbl_empresa_gt.Text = ret6 'empresa
                                txt_direccion_gt.Text = ret7 'direccion
                                msk_fe_desp_gt.Text = ret8 'fe desp
                                cbo_transp_gt.Text = ret9 'transporte
                                lbl_patente_gt.Text = ret10 'patente
                                cbo_chofer_gt.Text = ret11 'chofer
                                txt_peso_gt.Text = ret12 'gramos
                                txt_nrobultos_gt.Text = ret13 ' nro bultos
                                txt_obs_ing_gt.Text = ret14 'observacion
                                lbl_usuario_gt.Text = ret15 'usuario

                                rs17.Close()
                                com17.Dispose()
                                conexion.Close()


                                If conexion.State = 1 Then conexion.Close()
                                conexion.Open()

                                Dim com22 As MySqlCommand
                                Dim rs22 As MySqlDataReader

                                sql = ""
                                sql = "Select * From transferencias Where folio_interno = '" & txt_guia_gt.Text & "' and tipo_traspaso = 'INTERNO'"
                                com22 = New MySqlCommand(sql, conexion)

                                rs22 = com22.ExecuteReader()
                                If rs22.HasRows = True Then
                                    rs22.Read()

                                    lbl_sol_tras.Text = CStr(rs22("solicitante"))
                                    lbl_ciu_trasp.Text = CStr(rs22("ciudad"))

                                Else
                                    MsgBox("No se pudieron cargar algunos Datos de la Guía", MsgBoxStyle.Exclamation)

                                End If


                                Call bloqueo_campos()
                                cmd_guardar_gt.Enabled = False
                                cmd_modif_gt.Enabled = True
                                txt_guia_gt.Enabled = False

                            Else
                                MsgBox("La Guía No fue encontrada, Verifíque!", MsgBoxStyle.Critical)
                                txt_guia_gt.Select()


                            End If
                        Else
                            MsgBox("Debe Ingresar un valor para buscar", MsgBoxStyle.Critical)

            End If

        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        'End Try

    End Sub

    Private Sub txt_peso_gt_TextChanged(sender As Object, e As EventArgs) Handles txt_peso_gt.TextChanged

    End Sub

    Private Sub txt_peso_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_peso_gt.KeyPress


        If e.KeyChar = Convert.ToChar(13) Then


            If txt_peso_gt.Text <> "" Or txt_peso_gt.Text > 399 Then

                txt_nrobultos_gt.Select()
            Else
                txt_peso_gt.Select()

            End If

        End If


    End Sub

    Private Sub txt_nrobultos_gt_TextChanged(sender As Object, e As EventArgs) Handles txt_nrobultos_gt.TextChanged

    End Sub

    Private Sub txt_nrobultos_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nrobultos_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If txt_nrobultos_gt.Text <> "" Then

                txt_obs_ing_gt.Select()

            Else
                txt_nrobultos_gt.Select()

            End If

        End If
    End Sub

    Private Sub cmd_modif_gt_Click(sender As Object, e As EventArgs) Handles cmd_modif_gt.Click
        Dim valret2 As String

        valret2 = MsgBox("¿Desea modificar parte de los campos ya registrados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Editar valores")

        If valret2 = 6 Then

            Call activo_campos()
            cmd_guardar_datos_gt.Visible = True
            cmd_modif_gt.Visible = False
        Else
            Call bloqueo_campos()
            cmd_guardar_datos_gt.Visible = False
            cmd_modif_gt.Visible = True

        End If



    End Sub

    Private Sub cmd_guardar_datos_Click(sender As Object, e As EventArgs) Handles cmd_guardar_datos_gt.Click
        Dim cmd19 As MySqlCommand = New MySqlCommand
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


            cmd19 = New MySqlCommand("Update guias_trasp_dp Set fe_trasp = '" & msk_fe_desp_gt.Text & "', dir_trasp= '" & txt_direccion_gt.Text & "', transporte ='" & cbo_transp_gt.Text & "', fe_desp ='" & msk_fe_desp_gt.Text & "', nrobultos ='" & txt_nrobultos_gt.Text & "', gramos ='" & txt_peso_gt.Text & "', bod_origen ='" & cbo_bod_origen_gt.Text & "', chofer ='" & cbo_chofer_gt.Text & "', patente = '" & lbl_patente_gt.Text & "', bod_destino = '" & cbo_bod_destino_gt.Text & "', obs_ingreso = '" & txt_obs_ing_gt.Text & "'  WHERE nrodp = '" & lbl_idbd_gt.Text & "'", conexion)

            cmd19.ExecuteNonQuery()
            conexion.Close()
            cmd19.Dispose()

            MsgBox("Modificación realizada.", MsgBoxStyle.Information)



            cmd_guardar_gt.Enabled = False
            cmd_modif_gt.Enabled = False
            cmd_guardar_datos_gt.Visible = False


            cmd_Limpiar_gt.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txt_obs_ing_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_obs_ing_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            cmd_guardar_gt.Enabled = True
            cmd_guardar_gt.Select()


        End If
    End Sub

    Private Sub txt_obs_ing_gt_TextChanged(sender As Object, e As EventArgs) Handles txt_obs_ing_gt.TextChanged

    End Sub

    Private Sub cmd_cancelar_gt_Click(sender As Object, e As EventArgs) Handles cmd_cancelar_gt.Click
        Me.Dispose()
        frm_Menu.Show()
    End Sub

    Private Sub frm_ing_guia_trasp_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()

    End Sub


End Class