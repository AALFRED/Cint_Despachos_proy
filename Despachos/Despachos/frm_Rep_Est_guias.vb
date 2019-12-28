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
Public Class frm_Rep_Est_guias


    Private mifecha As Date
    Private mifecha2 As Date
    Dim tipo_estado As Integer ' 0 en transito 1 despachado y entregado
    Dim tipo_guia As Integer ' 0 cliente 1 sin factura 2 traspaso



    Sub Formato_grilla()

        'REVISAR viernes 28/03
        'dejar campos necesarios


        'nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso,
        'fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant


        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Nro DP"
        grilla.Columns(1).HeaderCell.Value = "Fe.Creacion"
        grilla.Columns(2).HeaderCell.Value = "Nro Factura"
        grilla.Columns(3).HeaderCell.Value = "Fe.Docto."
        grilla.Columns(4).HeaderCell.Value = "Nro.OC"
        grilla.Columns(5).HeaderCell.Value = "Rut"
        grilla.Columns(6).HeaderCell.Value = "Nombre"
        grilla.Columns(7).HeaderCell.Value = "Ciudad"
        grilla.Columns(8).HeaderCell.Value = "Nro Guia"
        grilla.Columns(9).HeaderCell.Value = "Fe Desp."
        grilla.Columns(10).HeaderCell.Value = "Transporte"
        grilla.Columns(11).HeaderCell.Value = "Nro Cedible"
        grilla.Columns(12).HeaderCell.Value = "Nro Flete"
        grilla.Columns(13).HeaderCell.Value = "Recibio"
        grilla.Columns(14).HeaderCell.Value = "Fe Reingreso"
        grilla.Columns(15).HeaderCell.Value = "Fe Cliente"
        grilla.Columns(16).HeaderCell.Value = "Vendedor"
        grilla.Columns(17).HeaderCell.Value = "Chofer"
        grilla.Columns(18).HeaderCell.Value = "Ordenador"
        grilla.Columns(19).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(20).HeaderCell.Value = "Hra Salida"
        grilla.Columns(21).HeaderCell.Value = "Peso"
        grilla.Columns(22).HeaderCell.Value = "obs Reingreso"
        grilla.Columns(23).HeaderCell.Value = "obs Despacho"
        grilla.Columns(24).HeaderCell.Value = "Usuario"
        grilla.Columns(25).HeaderCell.Value = "Usr Reing."
        grilla.Columns(26).HeaderCell.Value = "Es Garantia?"


        grilla.Columns(0).Width = 60
        grilla.Columns(1).Width = 70
        grilla.Columns(2).Width = 70
        grilla.Columns(3).Width = 70
        grilla.Columns(4).Width = 90
        grilla.Columns(5).Width = 80
        grilla.Columns(6).Width = 200
        grilla.Columns(7).Width = 90
        grilla.Columns(8).Width = 60
        grilla.Columns(9).Width = 70
        grilla.Columns(10).Width = 90
        grilla.Columns(11).Width = 80
        grilla.Columns(12).Width = 90
        grilla.Columns(13).Width = 120
        grilla.Columns(14).Width = 75
        grilla.Columns(15).Width = 70
        grilla.Columns(16).Width = 120
        grilla.Columns(17).Width = 75
        grilla.Columns(18).Width = 120
        grilla.Columns(19).Width = 60
        grilla.Columns(20).Width = 60
        grilla.Columns(21).Width = 70
        grilla.Columns(22).Width = 120
        grilla.Columns(23).Width = 220
        grilla.Columns(24).Width = 80
        grilla.Columns(25).Width = 80
        grilla.Columns(26).Width = 70

        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


        ' grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        ' grilla2.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        ' grilla2.RowsDefaultCellStyle.ForeColor = Color.White
        ' grilla2.GridColor = Color.Black
        ' grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        ' grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()


    End Sub

    Sub Formato_grilla3()

        'REVISAR viernes 28/03
        'dejar campos necesarios


        'nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso,
        'fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant


        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Nro DP"
        grilla.Columns(1).HeaderCell.Value = "Fe.Creacion"
        grilla.Columns(2).HeaderCell.Value = "Nro Factura"
        grilla.Columns(3).HeaderCell.Value = "Fe.Docto."
        grilla.Columns(4).HeaderCell.Value = "Nro.OC"
        grilla.Columns(5).HeaderCell.Value = "Rut"
        grilla.Columns(6).HeaderCell.Value = "Nombre"
        grilla.Columns(7).HeaderCell.Value = "Ciudad"
        grilla.Columns(8).HeaderCell.Value = "Nro Guia"
        grilla.Columns(9).HeaderCell.Value = "Fe Desp."
        grilla.Columns(10).HeaderCell.Value = "Transporte"
        grilla.Columns(11).HeaderCell.Value = "Nro Cedible"
        grilla.Columns(12).HeaderCell.Value = "Nro Flete"
        grilla.Columns(13).HeaderCell.Value = "Recibio"
        grilla.Columns(14).HeaderCell.Value = "Fe Reingreso"
        grilla.Columns(15).HeaderCell.Value = "Fe Cliente"
        grilla.Columns(16).HeaderCell.Value = "Vendedor"
        grilla.Columns(17).HeaderCell.Value = "Chofer"
        grilla.Columns(18).HeaderCell.Value = "Ordenador"
        grilla.Columns(19).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(20).HeaderCell.Value = "Hra Salida"
        grilla.Columns(21).HeaderCell.Value = "Peso"
        grilla.Columns(22).HeaderCell.Value = "obs Reingreso"
        grilla.Columns(23).HeaderCell.Value = "obs Despacho"
        grilla.Columns(24).HeaderCell.Value = "Usuario"
        grilla.Columns(25).HeaderCell.Value = "Usr Reing."
        grilla.Columns(26).HeaderCell.Value = "Es Garantia?"




        grilla.Columns(0).Width = 60
        grilla.Columns(1).Width = 70
        grilla.Columns(2).Width = 70
        grilla.Columns(3).Width = 70
        grilla.Columns(4).Width = 90
        grilla.Columns(5).Width = 80
        grilla.Columns(6).Width = 200
        grilla.Columns(7).Width = 90
        grilla.Columns(8).Width = 60
        grilla.Columns(9).Width = 70
        grilla.Columns(10).Width = 90
        grilla.Columns(11).Width = 80
        grilla.Columns(12).Width = 90
        grilla.Columns(13).Width = 120
        grilla.Columns(14).Width = 75
        grilla.Columns(15).Width = 70
        grilla.Columns(16).Width = 120
        grilla.Columns(17).Width = 75
        grilla.Columns(18).Width = 120
        grilla.Columns(19).Width = 60
        grilla.Columns(20).Width = 60
        grilla.Columns(21).Width = 70
        grilla.Columns(22).Width = 120
        grilla.Columns(23).Width = 220
        grilla.Columns(24).Width = 80
        grilla.Columns(25).Width = 80
        grilla.Columns(26).Width = 70



        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft




        ' grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        ' grilla2.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        ' grilla2.RowsDefaultCellStyle.ForeColor = Color.White
        ' grilla2.GridColor = Color.Black
        ' grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()


    End Sub

    Sub Formato_grilla2()

        'nrodp, nguia, bod_origen, bod_destino, fe_trasp, rut_trasp, nom_trasp, dir_trasp, fe_desp, transporte, patente, chofer, gramos, nrobultos, fe_recepcion, confirmacion, obs_ingreso, obs_reingreso, usr_registro, usr_reing


        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Nro DP"
        grilla.Columns(1).HeaderCell.Value = "Nro Guia"
        grilla.Columns(2).HeaderCell.Value = "Bod Origen"
        grilla.Columns(3).HeaderCell.Value = "Bod.Destino"
        grilla.Columns(4).HeaderCell.Value = "Fe.Trasp."
        grilla.Columns(5).HeaderCell.Value = "Rut"
        grilla.Columns(6).HeaderCell.Value = "Nombre"
        grilla.Columns(7).HeaderCell.Value = "direccion"
        grilla.Columns(8).HeaderCell.Value = "Fe.Desp."
        grilla.Columns(9).HeaderCell.Value = "Transporte"
        grilla.Columns(10).HeaderCell.Value = "Patente"
        grilla.Columns(11).HeaderCell.Value = "Chofer"
        grilla.Columns(12).HeaderCell.Value = "Peso (grs)"
        grilla.Columns(13).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(14).HeaderCell.Value = "Fe Recepcion"
        grilla.Columns(15).HeaderCell.Value = "Confirmacion"
        grilla.Columns(16).HeaderCell.Value = "Obs ingreso"
        grilla.Columns(17).HeaderCell.Value = "Obs.Reingreso"
        grilla.Columns(18).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(19).HeaderCell.Value = "Fe.Recepcion"
        grilla.Columns(20).HeaderCell.Value = "confirmacion"
        grilla.Columns(21).HeaderCell.Value = "obs Ingreso"
        grilla.Columns(22).HeaderCell.Value = "obs Reingreso"
        grilla.Columns(23).HeaderCell.Value = "Usuario"
        grilla.Columns(24).HeaderCell.Value = "Usr Reing."


        ' grilla.Columns(6).Visible = False 'id
        'grilla.Columns(16).Visible = False 'fe creacion

        grilla.Columns(0).Width = 60
        grilla.Columns(1).Width = 70
        grilla.Columns(2).Width = 70
        grilla.Columns(3).Width = 350
        grilla.Columns(4).Width = 100
        grilla.Columns(5).Width = 80
        grilla.Columns(7).Width = 70
        grilla.Columns(8).Width = 90
        grilla.Columns(9).Width = 80
        grilla.Columns(10).Width = 100
        grilla.Columns(11).Width = 60
        grilla.Columns(12).Width = 80
        grilla.Columns(13).Width = 60
        grilla.Columns(14).Width = 70
        grilla.Columns(15).Width = 60
        grilla.Columns(16).Width = 150 'obs
        grilla.Columns(17).Width = 120
        grilla.Columns(18).Width = 90
        grilla.Columns(19).Width = 120
        grilla.Columns(20).Width = 120
        grilla.Columns(21).Width = 120
        grilla.Columns(22).Width = 120
        grilla.Columns(23).Width = 120
        grilla.Columns(24).Width = 120


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


        ' grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        ' grilla2.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        ' grilla2.RowsDefaultCellStyle.ForeColor = Color.White
        ' grilla2.GridColor = Color.Black
        ' grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()


    End Sub



    Private Sub frm_Rep_Est_guias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Me.Text = v_emp & " / Reporte de Estado Facturas para Despacho **** AÑO " & miano & " **** Conectado como: " & retenUser


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
        BarraStatusTexto.Width = 350
        BarraStatusTexto.Text = "CONECTADO A BD " & v_database
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)

        'CONTROL DE CARGA
        cbo_estado.Items.Add("EN TRANSITO")
        cbo_estado.Items.Add("DESPACHADO Y ENTREGADO")

        cbo_tipo_guia.Items.Add("CLIENTE")
        cbo_tipo_guia.Items.Add("SIN FACTURA")
        cbo_tipo_guia.Items.Add("TRASPASOS")
    End Sub

    Private Sub msk_fe_ini_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_ini.MaskInputRejected

    End Sub

    Private Sub msk_fe_ini_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_ini.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_ini.Text <> "    -  -" Then
                msk_fe_fin.Select()

            Else
                msk_fe_ini.Select()
            End If

        End If
    End Sub

    Private Sub msk_fe_fin_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_fin.MaskInputRejected

    End Sub

    Private Sub msk_fe_fin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_fin.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_fin.Text <> "    -  -" Then
                cbo_estado.Select()

            Else
                msk_fe_fin.Select()
            End If


        End If
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim cmd28 As New MySqlCommand

        ' Try



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
            cmd28.Connection = conexion

            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text

            Select Case cbo_estado.Text
                Case "DESPACHADO Y ENTREGADO"
                    tipo_estado = 1

                Case "EN TRANSITO"
                    tipo_estado = 0

            End Select

            Select Case cbo_tipo_guia.Text
                Case "CLIENTE"
                    If tipo_estado = 1 Then
                    ' despachado y entregado con guia cliente

                    cmd28.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant From GUIAS_DP WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is not null ORDER BY fe_docto DESC"
                    Call Formato_grilla()
                Else
                    ' en transito con guia cliente
                    cmd28.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant From GUIAS_DP WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is null ORDER BY fe_docto DESC"
                    Call Formato_grilla()
                End If


            Case "SIN FACTURA"

                    If tipo_estado = 1 Then
                    ' despachado y entregado con guia sin fact
                    'cmd28.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant From guias_dp WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is not null and nfactura is not null ORDER BY fe_docto DESC"
                    cmd28.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant From GUIAS_DP WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is not null and nfactura is not null ORDER BY fe_docto DESC"
                    Call Formato_grilla3()
                Else
                    'cmd28.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant From guias_dp WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is not null and nfactura is null ORDER BY fe_docto DESC"
                    cmd28.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, noc, rutclie, nombre, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso_guia, obs_despacho_guia, usuario, usuario_reing, isgarant From GUIAS_DP WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is not null and nfactura is null ORDER BY fe_docto DESC"
                    Call Formato_grilla3()
                End If



            Case "TRASPASOS"

                    If tipo_estado = 1 Then
                        'despachado y entregado con guia traspaso

                        cmd28.CommandText = "SELECT nrodp, nguia, bod_origen, bod_destino, fe_trasp, rut_trasp, nom_trasp, dir_trasp, fe_desp, transporte, patente, chofer, gramos, nrobultos, fe_recepcion, confirmacion, obs_ingreso, obs_reingreso, usr_registro, usr_reing FROM guias_trasp_dp where fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' order by fe_trasp ASC ;"
                    Call Formato_grilla2()
                Else
                    'en transito con guia traspaso
                    cmd28.CommandText = "SELECT nrodp, nguia, bod_origen, bod_destino, fe_trasp, rut_trasp, nom_trasp, dir_trasp, fe_desp, transporte, patente, chofer, gramos, nrobultos, fe_recepcion, confirmacion, obs_ingreso, obs_reingreso, usr_registro, usr_reing FROM guias_trasp_dp where fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' order by fe_trasp ASC ;"
                    Call Formato_grilla2()
                End If

        End Select





            Dim dt As System.Data.DataTable = New System.Data.DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd28)

            da.Fill(dt)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            ' If dt.Rows.Count <> 0 Then
            grilla.DataSource = dt

            conexion.Close()
            da.Dispose()
            cmd28.Dispose()

            Cursor.Current = Cursors.Default
        Else
            Cursor.Current = Cursors.Default
                MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)

            End If


        'Catch ex As Exception
        ' MessageBox.Show(ex.Message)
        ' End Try
    End Sub

    Private Sub cbo_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_estado.SelectedIndexChanged
        If cbo_estado.Text <> "" Then

            cbo_tipo_guia.SelectAll()
            cbo_tipo_guia.Select()
        Else
            cbo_estado.Select()


        End If
    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_Rep_Est_guias_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub frm_Rep_Est_guias_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        MsgBox("En desarrollo")
    End Sub

    Private Sub cbo_tipo_guia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_guia.SelectedIndexChanged
        If cbo_tipo_guia.Text <> "" Then
            cmd_buscar.Enabled = True
            cmd_buscar.Select()
        Else
            cbo_tipo_guia.Select()

        End If
    End Sub
End Class