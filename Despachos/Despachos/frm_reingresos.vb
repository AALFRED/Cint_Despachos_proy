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



Public Class frm_reingresos
    Dim valmarca As Integer = 0

    Private Sub frm_reingresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Me.Text = v_emp & " / Re-Ingresos de Documentos Despachados **** AÑO " & miano & " **** Conectado como: " & retenUser


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


        'control de carga  TP FACTURAS
        'datos de la factura
        lbl_idbd.Text = ""
        lbl_rut.Text = ""
        lbl_cliente.Text = ""
        lbl_noc.Text = ""
        lbl_vendedor.Text = ""
        lbl_mto_fact.Text = ""
        lbl_fe_fact.Text = ""
        lbl_dirclie.Text = ""

        'datos del despacho
        lbl_nrodp.Text = ""
        lbl_nroflete.Text = ""
        lbl_medio_tp.Text = ""
        lbl_fe_reg.Text = ""
        lbl_fe_desp.Text = ""
        lbl_peso.Text = ""
        lbl_ciudad.Text = ""
        lbl_nrobultos.Text = ""
        lbl_acomodador.Text = ""
        lbl_ampm.Text = ""
        lbl_cedible.Text = ""
        lbl_chofer.Text = ""
        lbl_obs.Text = ""
        lbl_patente.Text = ""
        lbl_movil.Text = ""

        cmd_actualizar.Enabled = False
        cmd_modificar.Enabled = False

        'control de carga  TP BOLETAS
        lbl_idbd_boe.Text = ""
        lbl_rut_boe.Text = ""
        lbl_ciudad_boe.Text = ""
        lbl_ciudad_boe.Text = ""
        lbl_mto_boe.Text = ""
        lbl_fe_boe.Text = ""
        lbl_vend_boe.Text = ""
        lbl_clie_boe.Text = ""


        lbl_nrodp_boe.Text = ""
        lbl_nro_flete_boe.Text = ""
        lbl_ampm_boe.Text = ""
        lbl_cedi_boe.Text = ""
        lbl_chofer_boe.Text = ""
        lbl_ciudad_boe.Text = ""
        lbl_despachador_boe.Text = ""
        lbl_fe_crea_boe.Text = ""
        lbl_mediotp_boe.Text = ""
        lbl_fe_desp_boe.Text = ""

        lbl_nrobulto_boe.Text = ""
        lbl_nro_flete_boe.Text = ""
        lbl_patente_boe.Text = ""
        lbl_obs_desp_boe.Text = ""
        lbl_peso_boe.Text = ""
        lbl_movil_boe.Text = ""
        lbl_usr_ingreso_boe.Text = ""
        lbl_usr_reing_boe.Text = ""


        cmd_actualiza_boe.Enabled = False
        cmd_modificar_boe.Enabled = False

        'Reingreso de guias clte  TP GUIAS
        lbl_idbd_gc.Text = ""
        lbl_rut_gc.Text = ""
        lbl_nombre_gc.Text = ""
        lbl_nrofact_gc.Text = ""
        lbl_fe_docto_gc.Text = ""
        lbl_monto_gc.Text = ""
        lbl_noc_gc.Text = ""
        lbl_vend_gc.Text = ""
        lbl_direc_gc.Text = ""

        lbl_nrodp_gc.Text = ""
        lbl_nguia_gc.Text = ""
        lbl_fe_desp_gc.Text = ""
        lbl_nro_flete_gc.Text = ""
        lbl_ncedible_gc.Text = ""
        lbl_nbulto_gc.Text = ""
        lbl_peso_gc.Text = ""
        lbl_transporte_gc.Text = ""
        lbl_ciudad_gc.Text = ""
        lbl_chofer_gc.Text = ""
        lbl_despach_gc.Text = ""
        lbl_patente_gc.Text = ""
        lbl_movil_gc.Text = ""
        lbl_obs_desp_gc.Text = ""
        lbl_fe_reg_gc.Text = ""
        lbl_salida_gc.Text = ""
        lbl_tipo_guia_gc.Text = ""
        lbl_destino_guia_gc.Text = ""

        Me.ToolTip1.IsBalloon = True




        cmd_actualiza_gc.Enabled = False

        'reingreso de guias trasp

        cbo_recep_gt.Items.Add("SI")
        cbo_recep_gt.Items.Add("NO")
        cbo_recep_gt.Text = ""
        lbl_nrodpid.Text = ""
        cbo_rut_emp_gt.Text = ""
        cbo_empresa_gt.Text = ""
        txt_direccion_gt.Text = ""
        cbo_transp_gt.Text = ""
        lbl_patente_gt.Text = ""
        cbo_chofer_gt.Text = ""
        txt_peso_gt.Text = ""
        txt_nrobultos_gt.Text = ""

        cbo_bod_origen_gt.Text = ""
        cbo_bod_destino_gt.Text = ""
        txt_obs_ingreso.Text = ""
        lbl_usuario_gt.Text = ""
        msk_fe_recep_gt.Text = ""
        cbo_recep_gt.Text = ""
        txt_obs_reing_gt.Text = ""
        lbl_nrodp_gt.Text = ""
        lbl_usr_reing_gt.Text = ""
        cmd_modif_gt.Enabled = False
        cmd_actualizar_gt.Enabled = False

        msk_fe_reing.Text = FormatDateTime(Now(), DateFormat.ShortDate)
        msk_fe_reing_boe.Text = FormatDateTime(Now(), DateFormat.ShortDate)

        txt_bus_fact.Select()


    End Sub

    Private Sub VolverAlMenúToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VolverAlMenúToolStripMenuItem.Click
        Me.Dispose()
        frm_Menu.Show()
    End Sub

    Private Sub frm_reingresos_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()
    End Sub

    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Dispose()
        frm_Menu.Show()
    End Sub

    Private Sub txt_bus_fact_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_fact.TextChanged

    End Sub

    Private Sub txt_bus_fact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_fact.KeyPress
        Dim com6 As MySqlCommand
        Dim com7 As MySqlCommand
        Dim rs5 As MySqlDataReader
        Dim rs6 As MySqlDataReader
        Dim valret1 As String
        ' Dim contenido3 As String
        'Dim resul1 As String

        Try


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


                msk_fe_recep_clte.Text = ""
                txt_recep_desp.Text = ""
                txt_reing_obs.Text = ""

                'valret1 = "FEL0000" + txt_bus_fact.Text 'le agrega el 0 para igualar el campo
                valret1 = txt_bus_fact.Text 'le agrega el 0 para igualar el campo

                If conexion.State = 1 Then conexion.Close()
                'la abre 
                conexion.Open()

                'entrega el valor a la variable para buscar

                sql = "Select * From entregas_dp Where nfactura = '" & LTrim(RTrim(valret1)) & "'"
                com6 = New MySqlCommand(sql, conexion)

                rs5 = com6.ExecuteReader()
                If rs5.HasRows = True Then
                    rs5.Read()

                    lbl_idbd.Text = rs5("id")
                    lbl_rut.Text = CStr(rs5("rutclie"))
                    lbl_cliente.Text = CStr(rs5("nomclie"))

                    ' contenido3 = CStr(rs5("nfactura")).ToString
                    ' If Strings.Left(contenido3, 3) = "FEL" Then
                    ' resul1 = Mid(contenido3, 7, 10)
                    ' End If
                    '  txt_bus_fact.Text = resul1.ToString
                    txt_bus_fact.Text = CStr(rs5("nfactura")).ToString
                    lbl_mto_fact.Text = CStr(rs5("monto_fact"))
                    lbl_vendedor.Text = CStr(rs5("vendedor"))
                    lbl_dirclie.Text = CStr(rs5("dirdesp"))
                    lbl_noc.Text = CStr(rs5("noc"))
                    lbl_nrodp.Text = CStr(rs5("nrodp"))
                    lbl_cedible.Text = CStr(rs5("nro_rece"))
                    lbl_medio_tp.Text = CStr(rs5("transporte"))
                    lbl_nroflete.Text = CStr(rs5("nflete"))
                    lbl_nrobultos.Text = CStr(rs5("nrobultos"))
                    lbl_peso.Text = CStr(rs5("gramos"))
                    lbl_ciudad.Text = CStr(rs5("comuna"))
                    lbl_chofer.Text = CStr(rs5("chofer"))
                    If (IsDBNull(rs5("patente")) = True) Then
                        lbl_patente.Text = 0
                    Else
                        lbl_patente.Text = CStr(rs5("patente"))
                    End If

                    lbl_acomodador.Text = CStr(rs5("despachador"))
                    lbl_fe_fact.Text = CStr(rs5("fe_docto"))
                    lbl_fe_desp.Text = CStr(rs5("fe_desp"))
                    lbl_fe_reg.Text = CStr(rs5("fe_creacion"))
                    lbl_obs.Text = CStr(rs5("obs_despacho"))
                    lbl_ampm.Text = CStr(rs5("h_salida"))



                    If (IsDBNull(rs5("fe_reingreso")) = False) Then

                        MsgBox("Se ha detectado que esta Factura ya contiene un Re-Ingreso incorporado,  puede Editar. ", MsgBoxStyle.Exclamation, "Reingreso Detectado")
                        txt_recep_desp.Text = CStr(rs5("recibio"))
                        txt_reing_obs.Text = CStr(rs5("obs_reingreso"))
                        msk_fe_recep_clte.Text = CStr(rs5("fe_cliente"))
                        msk_fe_reing.Text = CStr(rs5("fe_reingreso"))

                        txt_recep_desp.Enabled = False
                        txt_reing_obs.Enabled = False
                        msk_fe_recep_clte.Enabled = False
                        msk_fe_reing.Enabled = False
                        cmd_modificar.Enabled = True
                        cmd_actualizar.Enabled = False
                        txt_bus_fact.SelectAll()
                        txt_bus_fact.Select()
                    Else
                        ' MsgBox("No se ha detectado el Re-ingreso de la Factura, incorpore!", MsgBoxStyle.Exclamation, "Sin Datos")

                        txt_recep_desp.Enabled = True
                        txt_reing_obs.Enabled = True
                        msk_fe_recep_clte.Enabled = True
                        msk_fe_reing.Enabled = True
                        cmd_modificar.Enabled = False
                        cmd_actualizar.Enabled = False
                        msk_fe_reing.SelectAll()
                        msk_fe_reing.Select()

                    End If

                    rs5.Close()
                    com6.Dispose()
                    conexion.Close()


                    'BUSCA EL MOVIL
                    If conexion.State = 1 Then conexion.Close()
                    'la abre 
                    conexion.Open()
                    sql = "Select * From medios_dp Where patente = '" & lbl_patente.Text & "'"
                    com7 = New MySqlCommand(sql, conexion)

                    rs6 = com7.ExecuteReader()
                    If rs6.HasRows = True Then
                        rs6.Read()
                        lbl_movil.Text = CStr(rs6("tipo"))

                        rs5.Close()
                        com6.Dispose()
                        conexion.Close()
                    Else
                        lbl_movil.Text = "No encontrado"

                    End If
                    msk_fe_reing.SelectAll()
                    msk_fe_reing.Select()

                Else
                    MsgBox("No se ha detectado el Nro de Factura, Verifique!", MsgBoxStyle.Exclamation)
                    txt_bus_fact.SelectAll()
                    txt_bus_fact.Select()

                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        'FACTURAS
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_reingresos_Load(e, e) 'Load everything in your form load event again
        Tab1.SelectedTab = TP1
        Tab1.SelectedIndex = 0
        txt_bus_fact.Text = " "
        txt_bus_fact.SelectionStart = 0
        txt_bus_fact.SelectionLength = txt_bus_fact.Text.Length
        txt_bus_fact.Select()

    End Sub

    Private Sub cmd_limpiar_boe_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_boe.Click
        'BOLETAS
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_reingresos_Load(e, e) 'Load everything in your form load event again
        Tab1.SelectedTab = TP2
        txt_bus_boe.Text = ""
        txt_bus_boe.SelectionStart = 0
        txt_bus_boe.SelectionLength = txt_bus_boe.Text.Length
        txt_bus_boe.Select()
    End Sub

    Private Sub cmd_limpiar_gc_Click(sender As Object, e As EventArgs) Handles cmd_limpiar_gc.Click
        'GUIAS
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_reingresos_Load(e, e) 'Load everything in your form load event again
        Tab1.SelectedTab = TP3
        txt_guia_reing_gc.Text = ""
        txt_guia_reing_gc.SelectionStart = 0
        txt_guia_reing_gc.SelectionLength = txt_guia_reing_gc.Text.Length
        txt_guia_reing_gc.Select()

    End Sub

    Private Sub cmd_Limpiar_gt_Click(sender As Object, e As EventArgs) Handles cmd_Limpiar_gt.Click
        'GUIA TRASPASO
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_reingresos_Load(e, e) 'Load everything in your form load event again
        Tab1.SelectedTab = TP4
        txt_guia_gt.Text = ""
        txt_guia_gt.SelectionStart = 0
        txt_guia_gt.SelectionLength = txt_guia_gt.Text.Length
        txt_guia_gt.Select()

    End Sub


    Private Sub cmd_actualizar_Click(sender As Object, e As EventArgs) Handles cmd_actualizar.Click

        Dim myCommand As New MySqlCommand
        Dim SQL As String
        Dim val1 As Integer 'guarda el id de bd
        Dim val2 As String 'guarda el usuario que registra

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


            conexion.Open()

            'asigna el id de la bd para actualizar
            val1 = lbl_idbd.Text

            'asigna el usuario que registra
            val2 = retenUser


            myCommand.Connection = conexion
            SQL = "UPDATE entregas_dp SET fe_reingreso = '" & msk_fe_reing.Text & "', fe_cliente = '" & msk_fe_recep_clte.Text & "', recibio = '" & txt_recep_desp.Text & "', obs_reingreso = '" & txt_reing_obs.Text & "', usuario_reing = '" & val2 & "' WHERE id = '" & val1 & "'"

            myCommand.CommandText = SQL
            myCommand.ExecuteNonQuery()

            If valmarca = 0 Then
                MsgBox("El reingreso se ha realizado con Éxito.", MsgBoxStyle.Information)
            Else
                MsgBox("La Modificación al Reingreso se ha efectuado con Éxito", MsgBoxStyle.Information)
            End If

            SQL = ""
            cmd_modificar.Visible = True
            myCommand.Dispose()
            conexion.Close()
            ' cmd_limpiar.PerformClick()
            lbl_rut.Text = ""
            lbl_cliente.Text = ""
            lbl_ciudad.Text = ""
            lbl_dirclie.Text = ""
            lbl_mto_fact.Text = ""
            lbl_fe_fact.Text = ""
            lbl_noc.Text = ""
            lbl_vendedor.Text = ""

            lbl_nrodp.Text = ""
            lbl_nroflete.Text = ""
            lbl_cedible.Text = ""
            lbl_fe_desp.Text = ""
            lbl_nrobultos.Text = ""
            lbl_peso.Text = ""
            lbl_obs.Text = ""
            lbl_medio_tp.Text = ""
            lbl_movil.Text = ""
            lbl_patente.Text = ""
            lbl_chofer.Text = ""
            lbl_ampm.Text = ""
            lbl_acomodador.Text = ""
            lbl_fe_reg.Text = ""

            msk_fe_recep_clte.Text = "    -  -"

            txt_recep_desp.Text = ""
            txt_reing_obs.Text = ""
            cmd_actualizar.Enabled = False
            txt_bus_fact.Text = ""
            txt_bus_fact.Select()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click
        Dim valret As String



        valret = MsgBox("¿Desea Modificar los datos de Reingeso?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar Datos")

        If valret = 6 Then
            txt_recep_desp.Enabled = True
            txt_reing_obs.Enabled = True
            msk_fe_recep_clte.Enabled = True
            msk_fe_reing.Enabled = True
            cmd_actualizar.Enabled = True
            valmarca = 1
        Else
            txt_recep_desp.Enabled = False
            txt_reing_obs.Enabled = False
            msk_fe_recep_clte.Enabled = False
            msk_fe_reing.Enabled = False
            cmd_actualizar.Enabled = False
            valmarca = 0
        End If

    End Sub

    Private Sub msk_fe_reing_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_reing.MaskInputRejected

    End Sub

    Private Sub msk_fe_reing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_reing.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_reing.Text <> "    -  -" Then
                msk_fe_recep_clte.Select()
            Else
                msk_fe_reing.Select()
            End If


        End If
    End Sub

    Private Sub msk_fe_recep_clte_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_recep_clte.MaskInputRejected

    End Sub

    Private Sub msk_fe_recep_clte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_recep_clte.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_recep_clte.Text <> "    -  -" Then
                txt_recep_desp.Select()
            Else
                msk_fe_recep_clte.Select()
            End If


        End If
    End Sub

    Private Sub mnu_VolverAIngresosFact_Click(sender As Object, e As EventArgs) Handles mnu_VolverAIngresosFact.Click
        Me.Dispose()
        frm_Menu.Hide()
        frm_ing_fel.Show()
    End Sub

    Private Sub txt_recep_desp_TextChanged(sender As Object, e As EventArgs) Handles txt_recep_desp.TextChanged

    End Sub

    Private Sub txt_recep_desp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_recep_desp.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                txt_recep_desp.CharacterCasing = CharacterCasing.Upper
                If txt_recep_desp.Text <> "" Then
                    txt_recep_desp.Text.ToUpper() 'cambia a mayusculas
                    txt_reing_obs.Select()

                Else
                    txt_recep_desp.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_reing_obs_TextChanged(sender As Object, e As EventArgs) Handles txt_reing_obs.TextChanged

    End Sub

    Private Sub txt_reing_obs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_reing_obs.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                txt_reing_obs.CharacterCasing = CharacterCasing.Upper
                txt_reing_obs.Text.ToUpper() 'cambia a mayusculas

                If cmd_modificar.Enabled = True Then
                    cmd_modificar.Select()
                Else
                    cmd_actualizar.Enabled = True
                    cmd_actualizar.Select()
                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmd_cancelar_boe_Click(sender As Object, e As EventArgs) Handles cmd_cancelar_boe.Click
        Me.Dispose()
        frm_Menu.Show()
    End Sub

    Private Sub txt_bus_boe_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_boe.TextChanged

    End Sub

    Private Sub txt_bus_boe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_boe.KeyPress
        Dim com8 As MySqlCommand
        Dim com9 As MySqlCommand
        Dim rs7 As MySqlDataReader
        Dim rs8 As MySqlDataReader
        Dim valret2 As String

        Try


            If e.KeyChar = Convert.ToChar(13) Then

                If conexion.State = 1 Then conexion.Close()

                If ch_anio_ant_boe.Checked = True Then
                    If emp_entrada = 1 Then   'cintegral
                        Call ConectaCint2()

                    Else                       'global
                        Call ConectaGlo2()

                    End If
                Else
                    If emp_entrada = 1 Then  'cintegral
                        Call ConectaCint()

                    Else                     'global
                        Call ConectaGlo()

                    End If
                End If


                msk_fe_recep_clie_boe.Text = ""
                txt_recep_desp_boe.Text = ""
                txt_obs_reing_boe.Text = ""

                'valret2 = "0" + txt_bus_boe.Text 'le agrega el 0 para igualar el campo
                valret2 = txt_bus_boe.Text

                If conexion.State = 1 Then conexion.Close()
                'la abre 
                conexion.Open()

                'entrega el valor a la variable para buscar

                sql = "Select * From boletas_dp Where nboleta = '" & LTrim(RTrim(valret2)) & "'"
                com8 = New MySqlCommand(sql, conexion)

                rs7 = com8.ExecuteReader()
                If rs7.HasRows = True Then
                    rs7.Read()


                    lbl_idbd_boe.Text = CStr(rs7("id"))

                    lbl_rut_boe.Text = CStr(rs7("rutclie"))
                    lbl_clie_boe.Text = CStr(rs7("nomclie"))
                    lbl_mto_boe.Text = CStr(rs7("monto_fact"))
                    lbl_ciudad_boe.Text = CStr(rs7("comuna"))
                    lbl_vend_boe.Text = CStr(rs7("vendedor"))
                    lbl_fe_boe.Text = CStr(rs7("fe_docto"))

                    lbl_nrodp_boe.Text = CStr(rs7("nrodp"))
                    lbl_cedi_boe.Text = CStr(rs7("nro_rece"))
                    lbl_mediotp_boe.Text = CStr(rs7("transporte"))
                    lbl_nro_flete_boe.Text = CStr(rs7("nflete"))
                    lbl_nrobulto_boe.Text = CStr(rs7("nrobultos"))
                    lbl_peso_boe.Text = CStr(rs7("gramos"))
                    lbl_chofer_boe.Text = CStr(rs7("chofer"))
                    If (IsDBNull(rs7("patente")) = True) Then
                        lbl_patente_boe.Text = "0"
                    Else
                        lbl_patente_boe.Text = CStr(rs7("patente"))
                    End If

                    lbl_despachador_boe.Text = CStr(rs7("despachador"))
                    lbl_fe_desp_boe.Text = CStr(rs7("fe_desp"))
                    lbl_fe_crea_boe.Text = CStr(rs7("fe_creacion"))

                    lbl_obs_desp_boe.Text = CStr(rs7("obs_despacho"))
                    lbl_ampm_boe.Text = CStr(rs7("h_salida"))
                    lbl_usr_ingreso_boe.Text = CStr(rs7("usuario"))


                    If (IsDBNull(rs7("fe_reingreso")) = False) Then

                        MsgBox("Se ha detectado que esta Boleta ya contiene un Re-Ingreso incorporado,  puede Editar. ", MsgBoxStyle.Exclamation, "Reingreso Detectado")

                        txt_recep_desp_boe.Text = CStr(rs7("recibio"))
                        txt_obs_reing_boe.Text = CStr(rs7("obs_reingreso"))
                        msk_fe_recep_clie_boe.Text = CStr(rs7("fe_cliente"))
                        msk_fe_reing_boe.Text = CStr(rs7("fe_reingreso"))
                        lbl_usr_reing_boe.Text = CStr(rs7("usuario_reing"))

                        txt_recep_desp_boe.Enabled = False
                        txt_obs_reing_boe.Enabled = False
                        msk_fe_recep_clie_boe.Enabled = False
                        msk_fe_reing_boe.Enabled = False

                        cmd_modificar_boe.Enabled = True
                        cmd_actualiza_boe.Enabled = False
                        txt_bus_boe.SelectAll()
                        txt_bus_boe.Select()
                    Else
                        ' MsgBox("No se ha detectado el Re-ingreso de la Boleta, incorpore!", MsgBoxStyle.Exclamation, "Sin Datos")

                        txt_recep_desp_boe.Enabled = True
                        txt_obs_reing_boe.Enabled = True
                        msk_fe_recep_clie_boe.Enabled = True
                        msk_fe_reing_boe.Enabled = True

                        cmd_modificar_boe.Enabled = False
                        cmd_actualiza_boe.Enabled = True
                        msk_fe_reing_boe.Select()

                    End If

                    rs7.Close()
                    com8.Dispose()
                    conexion.Close()


                    'BUSCA EL MOVIL
                    If conexion.State = 1 Then conexion.Close()
                    'la abre 
                    conexion.Open()
                    sql = "Select * From medios_dp Where patente = '" & lbl_patente_boe.Text & "'"
                    com9 = New MySqlCommand(sql, conexion)

                    rs8 = com9.ExecuteReader()
                    If rs8.HasRows = True Then
                        rs8.Read()
                        lbl_movil_boe.Text = CStr(rs8("tipo"))

                        rs8.Close()
                        com9.Dispose()
                        conexion.Close()
                    Else
                        lbl_movil_boe.Text = "No encontrado"

                    End If

                Else
                    MsgBox("La Boleta No existe en los Registros, Verifique!", MsgBoxStyle.Critical)
                    txt_bus_boe.Select()


                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub txt_recep_desp_boe_TextChanged(sender As Object, e As EventArgs) Handles txt_recep_desp_boe.TextChanged

    End Sub


    Private Sub msk_fe_reing_boe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_reing_boe.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then



            If msk_fe_reing_boe.Text <> "    -  -" Then

                msk_fe_recep_clie_boe.Select()
            Else
                msk_fe_reing_boe.Select()
            End If


        End If


    End Sub

    Private Sub txt_recep_desp_boe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_recep_desp_boe.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            txt_recep_desp_boe.CharacterCasing = CharacterCasing.Upper

            If txt_recep_desp_boe.Text <> "" Then
                txt_recep_desp_boe.Text.ToUpper() 'cambia a mayusculas
                txt_obs_reing_boe.Select()
            Else
                txt_recep_desp_boe.Select()
            End If

        End If
    End Sub

    Private Sub txt_guia_reing_TextChanged(sender As Object, e As EventArgs) Handles txt_guia_reing_gc.TextChanged

    End Sub

    Private Sub txt_guia_reing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_guia_reing_gc.KeyPress
        Dim com10 As MySqlCommand
        Dim com11 As MySqlCommand
        Dim rs9 As MySqlDataReader
        Dim rs10 As MySqlDataReader
        Dim valret3 As String
        'Dim contenido4 As String
        Dim resul2 As String = ""

        Try


            'Reingreso de guias clte  TP GUIAS
            lbl_rut_gc.Text = ""
            lbl_nombre_gc.Text = ""
            lbl_nrofact_gc.Text = ""
            lbl_fe_docto_gc.Text = ""
            lbl_monto_gc.Text = ""
            lbl_noc_gc.Text = ""
            lbl_vend_gc.Text = ""
            lbl_direc_gc.Text = ""
            lbl_nrodp_gc.Text = ""
            lbl_nguia_gc.Text = ""
            lbl_fe_desp_gc.Text = ""
            lbl_nro_flete_gc.Text = ""
            lbl_ncedible_gc.Text = ""
            lbl_nbulto_gc.Text = ""
            lbl_peso_gc.Text = ""
            lbl_transporte_gc.Text = ""

            lbl_ciudad_gc.Text = ""
            lbl_chofer_gc.Text = ""
            lbl_despach_gc.Text = ""
            lbl_patente_gc.Text = ""
            lbl_movil_gc.Text = ""
            lbl_obs_desp_gc.Text = ""
            lbl_fe_reg_gc.Text = ""
            lbl_salida_gc.Text = ""


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

                valret3 = txt_guia_reing_gc.Text

                ' If conexion.State = 1 Then conexion.Close()
                'la abre 
                conexion.Open()

                'entrega el valor a la variable para buscar

                sql = "Select * From guias_dp Where nguia = '" & valret3 & "'"
                com10 = New MySqlCommand(sql, conexion)

                rs9 = com10.ExecuteReader()
                If rs9.HasRows = True Then
                    rs9.Read()


                    lbl_idbd_gc.Text = CStr(rs9("id"))
                    lbl_rut_gc.Text = CStr(rs9("rutclie"))
                    lbl_nombre_gc.Text = CStr(rs9("nombre"))

                    If (IsDBNull(rs9("nfactura")) = True) Then
                        resul2 = 0
                    Else
                        ' contenido4 = CStr(rs9("nfactura")).ToString
                        ' If Strings.Left(contenido4, 3) = "FEL" Then
                        ' resul2 = Mid(contenido4, 7, 10)
                        ' End If
                        '    lbl_nrofact_gc.Text = resul2.ToString
                        lbl_nrofact_gc.Text = CStr(rs9("nfactura")).ToString
                    End If


                    'lbl_monto_gc.Text = CStr(rs9("monto_fact"))
                    If (IsDBNull(rs9("noc")) = True) Then
                        lbl_noc_gc.Text = 0
                    Else
                        lbl_noc_gc.Text = CStr(rs9("noc"))
                    End If

                    lbl_vend_gc.Text = CStr(rs9("vendedor"))
                    lbl_direc_gc.Text = CStr(rs9("direccion"))
                    lbl_nrodp_gc.Text = CStr(rs9("nrodp"))
                    lbl_nguia_gc.Text = CStr(rs9("nguia"))
                    lbl_fe_desp_gc.Text = CStr(rs9("fe_desp"))
                    lbl_nro_flete_gc.Text = CStr(rs9("nflete"))
                    lbl_ncedible_gc.Text = CStr(rs9("nro_rece"))
                    lbl_nbulto_gc.Text = CStr(rs9("nrobultos"))
                    lbl_peso_gc.Text = CStr(rs9("gramos"))
                    lbl_transporte_gc.Text = CStr(rs9("transporte"))
                    lbl_ciudad_gc.Text = CStr(rs9("comuna"))
                    lbl_chofer_gc.Text = CStr(rs9("chofer"))
                    lbl_patente_gc.Text = CStr(rs9("patente"))
                    lbl_despach_gc.Text = CStr(rs9("despachador"))


                    If CStr(rs9("isgarant")) = "SI" Then
                        lbl_tipo_guia_gc.Text = "GARANTIA"
                    Else
                        lbl_tipo_guia_gc.Text = "NORMAL"
                    End If

                    If CStr(rs9("destino")) = 0 Then
                        lbl_destino_guia_gc.Text = "CLIENTE"
                    Else
                        lbl_destino_guia_gc.Text = "PROVEEDOR"
                    End If

                    If IsDBNull(rs9("fe_docto")) = True Then
                        lbl_fe_docto_gc.Text = ""
                    Else
                        lbl_fe_docto_gc.Text = CStr(rs9("fe_docto"))
                    End If

                    lbl_fe_reg_gc.Text = CStr(rs9("fe_creacion"))
                    lbl_obs_desp_gc.Text = CStr(rs9("obs_despacho_guia"))
                    lbl_salida_gc.Text = CStr(rs9("h_salida"))

                    Dim band_valid As Boolean
                    Dim lafecha As String
                    band_valid = False

                    If (IsDBNull(rs9("fe_reingreso")) = True) Then
                        lafecha = "2000-01-01"
                    Else

                        lafecha = CStr(rs9("fe_reingreso"))
                    End If

                    Select Case lafecha
                        Case IsDBNull(lafecha)
                            band_valid = True
                        Case "2000-01-01"
                            band_valid = True
                    End Select

                    ' If (IsDBNull(rs9("fe_reingreso")) = False) Or rs9("Fe_reingreso") <> "2000-01-01" Then
                    If band_valid = False Then

                        'MsgBox("Se ha detectado que esta Guia ya contiene un Re-Ingreso incorporado, puede Editar. ", MsgBoxStyle.Exclamation, "Reingreso Detectado")
                        txt_recep_des_gc.Text = CStr(rs9("recibio"))
                        If IsDBNull(rs9("obs_reingreso_guia")) = True Then
                            txt_reing_obs_gc.Text = ""
                        Else
                            txt_reing_obs_gc.Text = CStr(rs9("obs_reingreso_guia"))
                        End If



                        msk_fe_recep_clte_gc.Text = CStr(rs9("fe_cliente"))
                        msk_fe_reing_gc.Text = CStr(rs9("fe_reingreso"))

                        cmd_actualiza_gc.Enabled = True

                        txt_guia_reing_gc.Select()
                    Else
                        MsgBox("No se ha detectado el Re-ingreso de la Factura, incorpore!", MsgBoxStyle.Exclamation, "Sin Datos")

                        txt_recep_des_gc.Enabled = True
                        txt_reing_obs_gc.Enabled = True
                        msk_fe_recep_clte_gc.Enabled = True
                        msk_fe_reing_gc.Enabled = True
                        cmd_actualiza_gc.Enabled = True

                        msk_fe_reing_gc.Select()

                    End If

                    rs9.Close()
                    com10.Dispose()
                    conexion.Close()

                Else
                    MsgBox("No se ha detectado el Nro de Guia, Verifique!", MsgBoxStyle.Exclamation)
                    txt_guia_reing_gc.Select()

                End If


                If lbl_patente_gc.Text <> "" Then

                    'BUSCA EL MOVIL
                    If conexion.State = 1 Then conexion.Close()
                    'la abre 
                    conexion.Open()
                    sql = "Select * From medios_dp Where patente = '" & lbl_patente_gc.Text & "'"
                    com11 = New MySqlCommand(sql, conexion)

                    rs10 = com11.ExecuteReader()
                    If rs10.HasRows = True Then
                        rs10.Read()
                        lbl_movil_gc.Text = CStr(rs10("tipo"))

                        rs10.Close()
                        com11.Dispose()
                        conexion.Close()
                    Else
                        lbl_movil_gc.Text = "No encontrado"

                    End If
                Else
                    lbl_patente_gc.Text = "No Definido"

                End If



            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Dispose()
        frm_Menu.Show()
    End Sub



    Private Sub cmd_actualiza_boe_Click(sender As Object, e As EventArgs) Handles cmd_actualiza_boe.Click

        Dim myCommand1 As New MySqlCommand
        Dim SQL2 As String
        Dim val3 As Integer 'guarda el id de bd
        Dim val4 As String 'guarda el usuario que registra

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


            conexion.Open()

            'asigna el id de la bd para actualizar
            val3 = lbl_idbd_boe.Text

            'asigna el usuario que registra
            val4 = retenUser

            myCommand1.Connection = conexion
            SQL2 = "UPDATE boletas_dp SET fe_reingreso = '" & msk_fe_reing_boe.Text & "', fe_cliente = '" & msk_fe_recep_clie_boe.Text & "', recibio = '" & txt_recep_desp_boe.Text & "', obs_reingreso = '" & txt_obs_reing_boe.Text & "', usuario_reing = '" & val4 & "' WHERE id = '" & val3 & "'"

            myCommand1.CommandText = SQL2
            myCommand1.ExecuteNonQuery()

            If valmarca = 0 Then
                MsgBox("El reingreso se ha realizado con Éxito.", MsgBoxStyle.Information)
            Else
                MsgBox("La Modificación al Reingreso se ha efectuado con Éxito", MsgBoxStyle.Information)
            End If


            SQL2 = ""
            cmd_actualiza_boe.Visible = True
            myCommand1.Dispose()
            conexion.Close()
            cmd_limpiar_boe.PerformClick()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmd_actualiza_gc_Click(sender As Object, e As EventArgs) Handles cmd_actualiza_gc.Click
        'REINGRESO GUIAS CLIENTE
        Dim myCommand2 As New MySqlCommand
        Dim SQL3 As String
        Dim val5 As Integer 'guarda el id de bd
        Dim val6 As String 'guarda el usuario que registra

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


            conexion.Open()

            'asigna el id de la bd para actualizar
            val5 = lbl_idbd_gc.Text

            'asigna el usuario que registra
            val6 = retenUser

            myCommand2.Connection = conexion
            SQL3 = "UPDATE guias_dp SET fe_reingreso = '" & msk_fe_reing_gc.Text & "', fe_cliente = '" & msk_fe_recep_clte_gc.Text & "', recibio = '" & txt_recep_des_gc.Text & "', obs_reingreso_guia = '" & txt_reing_obs_gc.Text & "', usuario_reing = '" & val6 & "' WHERE id = '" & val5 & "'"

            myCommand2.CommandText = SQL3
            myCommand2.ExecuteNonQuery()
            MsgBox("Modificación realizada con el NroDP " & lbl_nrodp_gc.Text, MsgBoxStyle.Information)
            SQL3 = ""
            cmd_actualiza_gc.Enabled = False


            conexion.Close()
            cmd_limpiar_gc.PerformClick()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub



    Private Sub msk_fe_recep_clie_boe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_recep_clie_boe.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_recep_clie_boe.Text <> "    -  -" Then
                txt_recep_desp_boe.Select()
            Else
                msk_fe_recep_clie_boe.Select()
            End If


        End If
    End Sub

    Private Sub cmd_cancelar_gt_Click(sender As Object, e As EventArgs) Handles cmd_cancelar_gt.Click
        Me.Dispose()
        frm_Menu.Show()

    End Sub

    Private Sub msk_fe_reing_gc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_reing_gc.MaskInputRejected

    End Sub

    Private Sub msk_fe_reing_gc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_reing_gc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_reing_gc.Text <> "    -  -" Then
                msk_fe_recep_clte_gc.Select()
            Else
                msk_fe_reing_gc.Select()
            End If


        End If
    End Sub

    Private Sub msk_fe_recep_clte_gc_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_recep_clte_gc.MaskInputRejected

    End Sub

    Private Sub msk_fe_recep_clte_gc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_recep_clte_gc.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_recep_clte_gc.Text <> "    -  -" Then
                txt_recep_des_gc.Select()
            Else
                msk_fe_recep_clte_gc.Select()
            End If


        End If
    End Sub

    Private Sub txt_recep_des_gc_TextChanged(sender As Object, e As EventArgs) Handles txt_recep_des_gc.TextChanged

    End Sub

    Private Sub txt_recep_des_gc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_recep_des_gc.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then
                txt_recep_des_gc.CharacterCasing = CharacterCasing.Upper
                If txt_recep_des_gc.Text <> "" Then
                    txt_recep_des_gc.Text.ToUpper() 'cambia a mayusculas
                    txt_reing_obs_gc.Select()

                Else
                    txt_recep_des_gc.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub txt_guia_gt_TextChanged(sender As Object, e As EventArgs) Handles txt_guia_gt.TextChanged

    End Sub

    Private Sub txt_guia_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_guia_gt.KeyPress
        'GUIAS TRASPASO

        Dim com12 As MySqlCommand
        Dim rs12 As MySqlDataReader
        Dim valret6 As String
        Dim resul3 As String = ""

        'Try


        'Reingreso de guias TRASPASO 


        cbo_rut_emp_gt.Text = ""
        cbo_empresa_gt.Text = ""
        txt_direccion_gt.Text = ""
        cbo_transp_gt.Text = ""
        lbl_patente_gt.Text = ""
        cbo_chofer_gt.Text = ""
        txt_peso_gt.Text = ""
        txt_nrobultos_gt.Text = ""

        cbo_bod_origen_gt.Text = ""
        cbo_bod_destino_gt.Text = ""
        txt_obs_ingreso.Text = ""
        lbl_usuario_gt.Text = ""
        msk_fe_recep_gt.Text = ""
        cbo_recep_gt.Text = ""
        txt_obs_reing_gt.Text = ""



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

            valret6 = txt_guia_gt.Text

            If conexion.State = 1 Then conexion.Close()
            'la abre 
            conexion.Open()

            'entrega el valor a la variable para buscar

            sql = "Select * From guias_trasp_dp Where nguia = '" & valret6 & "'"
            com12 = New MySqlCommand(sql, conexion)

            rs12 = com12.ExecuteReader()
            If rs12.HasRows = True Then
                rs12.Read()

                lbl_nrodpid.Text = CStr(rs12("nrodp"))
                lbl_nrodp_gt.Text = CStr(rs12("nrodp"))
                txt_guia_gt.Text = CStr(rs12("nguia"))
                cbo_bod_origen_gt.Text = CStr(rs12("bod_origen"))
                cbo_bod_destino_gt.Text = CStr(rs12("bod_destino"))
                msk_fe_gt.Text = CStr(rs12("fe_trasp"))
                cbo_rut_emp_gt.Text = CStr(rs12("rut_trasp"))
                cbo_empresa_gt.Text = CStr(rs12("nom_trasp"))
                txt_direccion_gt.Text = CStr(rs12("dir_trasp"))
                msk_fe_desp_gt.Text = CStr(rs12("fe_desp"))
                cbo_transp_gt.Text = CStr(rs12("transporte"))
                lbl_patente_gt.Text = CStr(rs12("patente"))
                cbo_chofer_gt.Text = CStr(rs12("chofer"))
                txt_peso_gt.Text = CStr(rs12("gramos"))
                txt_nrobultos_gt.Text = CStr(rs12("nrobultos"))
                txt_obs_ingreso.Text = CStr(rs12("obs_ingreso"))
                lbl_usuario_gt.Text = CStr(rs12("usr_registro"))

                If IsDBNull((rs12("fe_recepcion"))) = True Then
                    MsgBox("Se ha detectado que esta Guia NO contiene un Re-Ingreso incorporado, puede Editar. ", MsgBoxStyle.Exclamation, "Reingreso Detectado")
                    msk_fe_recep_gt.Text = "1800-01-01"
                    cmd_actualizar_gt.Enabled = False
                    cmd_modif_gt.Enabled = True

                Else
                    msk_fe_recep_gt.Text = CStr(rs12("fe_recepcion"))
                    MsgBox("Se ha detectado que esta Guia ya contiene un Re-Ingreso incorporado, puede Editar. ", MsgBoxStyle.Exclamation, "Reingreso Detectado")
                    cmd_modif_gt.Enabled = True
                    cmd_actualizar_gt.Enabled = False
                    cmd_modif_gt.Enabled = True

                End If

                ' If IsDBNull((rs12("confirmacion"))) = True Then
                ' lbl_nombre_gc.Text = ""

                'Else
                If CStr(rs12("confirmacion")).ToString = 1 Then
                    cbo_recep_gt.Text = "SI"
                Else
                    cbo_recep_gt.Text = "NO"
                End If

                'End If

                If IsDBNull((rs12("obs_reingreso"))) = True Then
                    txt_obs_reing_gt.Text = ""
                Else

                    txt_obs_reing_gt.Text = CStr(rs12("obs_reingreso"))
                End If

                If IsDBNull((rs12("usr_reing"))) = True Then
                    lbl_usr_reing_gt.Text = ""

                Else
                    lbl_usr_reing_gt.Text = CStr(rs12("usr_reing"))

                End If




                rs12.Close()
                com12.Dispose()
                conexion.Close()


                cbo_rut_emp_gt.Enabled = False
                cbo_empresa_gt.Enabled = False
                txt_direccion_gt.Enabled = False
                cbo_transp_gt.Enabled = False
                lbl_patente_gt.Enabled = False
                cbo_chofer_gt.Enabled = False
                txt_peso_gt.Enabled = False
                txt_nrobultos_gt.Enabled = False

                cbo_bod_origen_gt.Enabled = False
                cbo_bod_destino_gt.Enabled = False
                txt_obs_ingreso.Enabled = False
                lbl_usuario_gt.Enabled = False
                msk_fe_recep_gt.Enabled = False
                cbo_recep_gt.Enabled = False
                txt_obs_reing_gt.Enabled = False


            End If
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.ToString)
        'End Try

    End Sub

    Private Sub cmd_guardar_gt_Click(sender As Object, e As EventArgs) Handles cmd_actualizar_gt.Click
        'REINGRESO GUIAS TRASPASO
        Dim myCommand2 As New MySqlCommand
        Dim SQL4 As String
        Dim val7 As Integer 'guarda el id de bd
        Dim val8 As String 'guarda el usuario que registra

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

            Dim valconf As Integer

            If cbo_recep_gt.Text = "SI" Then
                valconf = 1
            Else
                valconf = 0  'NO
            End If


            conexion.Open()

            'asigna el id de la bd para actualizar
            val7 = lbl_nrodpid.Text

            'asigna el usuario que registra
            val8 = retenUser

            myCommand2.Connection = conexion
            SQL4 = "UPDATE guias_trasp_dp SET fe_recepcion = '" & msk_fe_recep_gt.Text & "', confirmacion = '" & valconf & "', obs_reingreso = '" & txt_obs_reing_gt.Text & "', usr_reing = '" & val8 & "' WHERE nrodp = '" & val7 & "'"

            myCommand2.CommandText = SQL4
            myCommand2.ExecuteNonQuery()
            MsgBox("Modificación realizada con el NroDP ---> " & lbl_nrodp_gt.Text, MsgBoxStyle.Information)
            SQL4 = ""
            cmd_actualizar_gt.Enabled = False


            conexion.Close()
            cmd_Limpiar_gt.PerformClick()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cmd_modificar_boe_Click(sender As Object, e As EventArgs) Handles cmd_modificar_boe.Click
        Dim valret8 As String
        Dim val_usr_reing As String
        val_usr_reing = retenUser
        valret8 = MsgBox("¿Desea Modificar los datos de Reingeso para la Boleta Registrada?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar Datos")

        If valret8 = 6 Then

            msk_fe_reing_boe.Enabled = True
            msk_fe_recep_clie_boe.Enabled = True
            txt_recep_desp_boe.Enabled = True
            txt_obs_reing_boe.Enabled = True
            cmd_actualiza_boe.Enabled = True
            lbl_usr_reing_boe.Text = val_usr_reing
            valmarca = 1
            msk_fe_reing_boe.Select()

        Else
            msk_fe_reing_boe.Enabled = False
            msk_fe_recep_clie_boe.Enabled = False
            txt_recep_desp_boe.Enabled = False
            txt_obs_reing_boe.Enabled = False
            cmd_actualiza_boe.Enabled = False
            lbl_usr_reing_boe.Text = ""
            cmd_modificar_boe.Enabled = True
            valmarca = 0

        End If
    End Sub

    Private Sub cmd_modif_gt_Click(sender As Object, e As EventArgs) Handles cmd_modif_gt.Click
        Dim valret7 As String
        Dim val_usr_reing As String
        val_usr_reing = retenUser
        valret7 = MsgBox("¿Desea Modificar los datos de Reingeso para la Guia de Traspaso?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Modificar Datos")

        If valret7 = 6 Then
            msk_fe_recep_gt.Enabled = True
            cbo_recep_gt.Enabled = True
            txt_obs_reing_gt.Enabled = True
            lbl_usr_reing_gt.Text = val_usr_reing
            cmd_actualizar_gt.Enabled = True
        Else
            msk_fe_recep_gt.Enabled = False
            cbo_recep_gt.Enabled = False
            txt_obs_reing_gt.Enabled = False
            lbl_usr_reing_gt.Text = ""
            cmd_actualizar_gt.Enabled = False


        End If

    End Sub


    Private Sub msk_fe_recep_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_recep_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If msk_fe_recep_gt.Text <> "    -  -" Then
                cbo_recep_gt.Select()
            Else
                msk_fe_recep_gt.Select()
            End If
        End If
    End Sub

    Private Sub msk_fe_recep_gt_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_recep_gt.MaskInputRejected

    End Sub

    Private Sub cbo_recep_gt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_recep_gt.SelectedIndexChanged
        If cbo_recep_gt.Text <> "" Then

            txt_obs_reing_gt.Select()
        Else
            cbo_recep_gt.Select()

        End If
    End Sub

    Private Sub cbo_recep_gt_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_recep_gt.SelectedValueChanged
        If cbo_recep_gt.Text <> "" Then

            txt_obs_reing_gt.Select()
        Else
            cbo_recep_gt.Select()

        End If
    End Sub

    Private Sub cbo_recep_gt_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_recep_gt.SelectionChangeCommitted
        If cbo_recep_gt.Text <> "" Then

            txt_obs_reing_gt.Select()
        Else
            cbo_recep_gt.Select()

        End If
    End Sub

    Private Sub txt_obs_reing_gt_TextChanged(sender As Object, e As EventArgs) Handles txt_obs_reing_gt.TextChanged

    End Sub

    Private Sub txt_obs_reing_gt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_obs_reing_gt.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If cmd_modif_gt.Enabled = True Then

                cmd_actualizar_gt.Enabled = False
            Else
                cmd_actualizar_gt.Enabled = True

            End If

        End If
    End Sub

    Private Sub msk_fe_reing_boe_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_reing_boe.MaskInputRejected

    End Sub

    Private Sub msk_fe_recep_clie_boe_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_recep_clie_boe.MaskInputRejected

    End Sub

    Private Sub txt_obs_reing_boe_TextChanged(sender As Object, e As EventArgs) Handles txt_obs_reing_boe.TextChanged

    End Sub

    Private Sub txt_obs_reing_boe_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_obs_reing_boe.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then


            cmd_actualiza_boe.Enabled = True
            cmd_actualiza_boe.Select()


        End If
    End Sub

    Private Sub mnu_guia_DeCliente_Click(sender As Object, e As EventArgs) Handles mnu_guia_DeCliente.Click
        Me.Dispose()
        frm_Menu.Hide()
        frm_ing_guia_clte.Show()

    End Sub

    Private Sub mnu_guia_SinAsignacionFactura_Click(sender As Object, e As EventArgs) Handles mnu_guia_SinAsignacionFactura.Click
        Me.Dispose()
        frm_Menu.Hide()
        frm_ing_guia_sinfact.Show()
    End Sub

    Private Sub mnu_guia_DeTraspaso_Click(sender As Object, e As EventArgs) Handles mnu_guia_DeTraspaso.Click
        Me.Dispose()
        frm_Menu.Hide()
        frm_ing_guia_trasp.Show()
    End Sub

    Private Sub lbl_obs_desp_gc_Click(sender As Object, e As EventArgs) Handles lbl_obs_desp_gc.Click

    End Sub

    Private Sub lbl_obs_desp_gc_MouseMove(sender As Object, e As MouseEventArgs) Handles lbl_obs_desp_gc.MouseMove
        Me.ToolTip1.SetToolTip(lbl_obs_desp_gc, lbl_obs_desp_gc.Text)
    End Sub

    Private Sub lbl_obs_desp_gc_MouseClick(sender As Object, e As MouseEventArgs) Handles lbl_obs_desp_gc.MouseClick
        MsgBox(lbl_obs_desp_gc.Text)
    End Sub

    Private Sub Tab1_MouseClick(sender As Object, e As MouseEventArgs) Handles Tab1.MouseClick
        Select Case Tab1.SelectedIndex
            Case 0
                txt_bus_fact.Select()

            Case 1
                txt_bus_boe.Select()

            Case 2
                txt_guia_reing_gc.Select()

            Case 3
                txt_guia_gt.Select()
        End Select
    End Sub

    Private Sub frm_reingresos_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txt_bus_fact.Select()

    End Sub

    Private Sub txt_obs_ingreso_TextChanged(sender As Object, e As EventArgs) Handles txt_obs_ingreso.TextChanged

    End Sub

    Private Sub txt_obs_ingreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_obs_ingreso.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then
            msk_fe_desp_gt.Enabled = True
            msk_fe_recep_gt.SelectAll()
            msk_fe_recep_gt.Select()

        End If

    End Sub
End Class