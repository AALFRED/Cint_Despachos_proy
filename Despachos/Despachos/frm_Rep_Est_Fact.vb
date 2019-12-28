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

Public Class frm_Rep_Est_Fact

    Private mifecha As Date
    Private mifecha2 As Date

    Sub Exp_Excel2(grilla As DataGridView)

        System.Windows.Forms.Application.DoEvents()


        lbl_cartel.Visible = True

        If ((grilla.Columns.Count = 0) Or (grilla.Rows.Count = 0)) Then
            MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
            'Exit Sub
        Else
            'Creando Dataset para Exportar
            Dim dset As New DataSet
            'Agregar tabla al Dataset
            dset.Tables.Add()
            'AGregar Columna a la tabla
            For i As Integer = 0 To grilla.ColumnCount - 1
                dset.Tables(0).Columns.Add(grilla.Columns(i).HeaderText)
            Next

            'Agregar filas a la tabla
            Dim dr1 As DataRow
            For i As Integer = 0 To grilla.RowCount - 1
                dr1 = dset.Tables(0).NewRow
                For j As Integer = 0 To grilla.Columns.Count - 1
                    dr1(j) = grilla.Rows(i).Cells(j).Value
                Next
                dset.Tables(0).Rows.Add(dr1)
            Next

            Dim aplicacion As New Microsoft.Office.Interop.Excel.Application
            Dim wBook As Microsoft.Office.Interop.Excel.Workbook
            Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

            wBook = aplicacion.Workbooks.Add()
            wSheet = wBook.ActiveSheet()

            Dim dt As System.Data.DataTable = dset.Tables(0)
            Dim dc As System.Data.DataColumn
            Dim dr As System.Data.DataRow
            Dim colIndex As Integer = 0
            Dim rowIndex As Integer = 0

            For Each dc In dt.Columns
                colIndex = colIndex + 1
                aplicacion.Cells(1, colIndex) = dc.ColumnName
            Next
            Cursor.Current = Cursors.WaitCursor
            For Each dr In dt.Rows
                rowIndex = rowIndex + 1
                colIndex = 0
                For Each dc In dt.Columns
                    colIndex = colIndex + 1
                    aplicacion.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

                Next

                lbl_cartel.Text = "Procesando la Fila....." & rowIndex
            Next

            'Configurar la orientacion de la  hoja y el tamaño
            ' wSheet.PageSetup.Orientation = XlPageOrientation.xlLandscape
            ' wSheet.PageSetup.PaperSize = XlPaperSize.xlPaperLegal
            'Configurar con negrilla la cabecera y tenga autofit
            wSheet.Rows.Item(1).Font.Bold = 1
            wSheet.Columns.AutoFit()

            '  Dim strFileName As String = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory) & "Temp\Rep_Estado_Facturas.xlsx"
            'Dim strFilename As String = System.IO.Path.GetDirectoryName(path:="Temp\exp_Cuadro_Anual.xlsx")
            'Dim strfilename As String = "C:\Proyectos Vb2017\DESPACHOS\Despachos\Temp\Rep_Estado_Facturas.xlsx"
            Dim strfilename As String = "C:\Proyectos Vb2017\Redireccionamiento\DESPACHOS_PROY\Temp\Rep_Estado_Facturas.xlsx"
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strfilename)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strfilename) Then
                System.IO.File.Delete(strfilename)
            End If
            MessageBox.Show("El documento fue exportado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            wBook.SaveAs(strfilename)
            aplicacion.Workbooks.Open(strfilename)
            aplicacion.Visible = True
            Cursor.Current = Cursors.Default

        End If


    End Sub




    Sub Formato_grilla()

        'REVISAR viernes 28/03
        'dejar campos necesarios

        'nrodp, fe_creacion, nfactura, fe_docto, monto_fact, noc, rutclie, nomclie, comuna, nguia, fe_desp, transporte, nro_rece, nflete,
        'recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso, obs_despacho, usuario, usuario_reing
        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Nro DP"
        grilla.Columns(1).HeaderCell.Value = "Fe.Creacion"
        grilla.Columns(2).HeaderCell.Value = "Nro Factura"
        grilla.Columns(3).HeaderCell.Value = "Fe.Docto."
        grilla.Columns(4).HeaderCell.Value = "Monto $"
        grilla.Columns(5).HeaderCell.Value = "Nro.OC"
        grilla.Columns(6).HeaderCell.Value = "Rut"
        grilla.Columns(7).HeaderCell.Value = "Nombre"
        grilla.Columns(8).HeaderCell.Value = "Ciudad"
        grilla.Columns(9).HeaderCell.Value = "Nro Guia"
        grilla.Columns(10).HeaderCell.Value = "Fe Desp."
        grilla.Columns(11).HeaderCell.Value = "Transporte"
        grilla.Columns(12).HeaderCell.Value = "Nro Cedible"
        grilla.Columns(13).HeaderCell.Value = "Nro Flete"
        grilla.Columns(14).HeaderCell.Value = "Recibio"
        grilla.Columns(15).HeaderCell.Value = "Fe Reingreso"
        grilla.Columns(16).HeaderCell.Value = "Fe Cliente"
        grilla.Columns(17).HeaderCell.Value = "Vendedor"
        grilla.Columns(18).HeaderCell.Value = "Chofer"
        grilla.Columns(19).HeaderCell.Value = "Ordenador"
        grilla.Columns(20).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(21).HeaderCell.Value = "Hra Salida"
        grilla.Columns(22).HeaderCell.Value = "Peso Grs"
        grilla.Columns(23).HeaderCell.Value = "obs Reingreso"
        grilla.Columns(24).HeaderCell.Value = "obs Despacho"
        grilla.Columns(25).HeaderCell.Value = "Usuario"
        grilla.Columns(26).HeaderCell.Value = "Usr Reing."

        ' grilla.Columns(6).Visible = False 'id
        'grilla.Columns(16).Visible = False 'fe creacion

        grilla.Columns(0).Width = 60
        grilla.Columns(1).Width = 70
        grilla.Columns(2).Width = 70
        grilla.Columns(3).Width = 70
        grilla.Columns(4).Width = 80
        grilla.Columns(5).Width = 95
        grilla.Columns(6).Width = 80
        grilla.Columns(7).Width = 210
        grilla.Columns(8).Width = 120
        grilla.Columns(9).Width = 80
        grilla.Columns(10).Width = 90
        grilla.Columns(11).Width = 100
        grilla.Columns(12).Width = 80
        grilla.Columns(13).Width = 150
        grilla.Columns(14).Width = 100
        grilla.Columns(15).Width = 60
        grilla.Columns(16).Width = 150 'obs
        grilla.Columns(17).Width = 110
        grilla.Columns(18).Width = 90
        grilla.Columns(19).Width = 120
        grilla.Columns(20).Width = 60
        grilla.Columns(21).Width = 60
        grilla.Columns(22).Width = 60
        grilla.Columns(23).Width = 120
        grilla.Columns(24).Width = 120
        grilla.Columns(25).Width = 90
        grilla.Columns(26).Width = 90

        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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

        With grilla
            For fila = 1 To .Rows.Count

                .Columns(4).DefaultCellStyle.Format = "$###,##0"


            Next
        End With


    End Sub



    Private Sub frm_Rep_Est_Fact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        BarraStatusTexto.Width = 450
        BarraStatusTexto.Text = "CONECTADO A BD " & v_database
        BarraStatus.Panels.Add(BarraStatusTexto)

        'Add all teh controls to the form
        Me.Controls.Add(BarraStatus)

        'CONTROL DE CARGA

        cmd_buscar.Enabled = False
        msk_fe_ini.Text = "    -  -"
        msk_fe_fin.Text = "    -  -"
        cmd_exp_excel.Enabled = False
        lbl_cartel.Text = ""

        lbl_cartel.Visible = False

        'carga de tipo de bd

        cbo_estado.Items.Add("DESPACHADO Y ENTREGADO")  'ciclo completo
        cbo_estado.Items.Add("EN TRANSITO")  'solo despachado
        cbo_estado.Text = ""




    End Sub

    Private Sub frm_Rep_Est_Fact_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()

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
        Dim cmd27 As New MySqlCommand

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
            cmd27.Connection = conexion

            mifecha = msk_fe_ini.Text
            mifecha2 = msk_fe_fin.Text

            Select Case cbo_estado.Text
                Case "DESPACHADO Y ENTREGADO"
                    cmd27.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, monto_fact, noc, rutclie, nomclie, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso, obs_despacho, usuario, usuario_reing  From entregas_dp WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is not null ORDER BY fe_docto DESC"

                Case "EN TRANSITO"
                    cmd27.CommandText = "SELECT nrodp, fe_creacion, nfactura, fe_docto, monto_fact, noc, rutclie, nomclie, comuna, nguia, fe_desp, transporte, nro_rece, nflete, recibio, fe_reingreso, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, gramos, obs_reingreso, obs_despacho, usuario, usuario_reing  From entregas_dp WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and  fe_reingreso is null ORDER BY fe_docto DESC"

            End Select


            Dim dt As System.Data.DataTable = New System.Data.DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd27)
            da.Fill(dt)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                grilla.DataSource = dt

                conexion.Close()
                da.Dispose()
                cmd27.Dispose()


                Call Formato_grilla()
                Cursor.Current = Cursors.Default
                cmd_exp_excel.Enabled = True
            Else
                Cursor.Current = Cursors.Default
                MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_Rep_Est_Fact_Load(e, e) 'Load everything in your form load event again



    End Sub

    Private Sub cbo_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_estado.SelectedIndexChanged

        If cbo_estado.Text <> "" Then
            cmd_buscar.Enabled = True
            cmd_buscar.Select()
        Else
            cbo_estado.Select()
        End If

    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        Call Exp_Excel2(grilla)
    End Sub
End Class