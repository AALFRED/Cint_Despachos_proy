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
Public Class frm_cons_series


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
            Dim strfilename As String = "C:\Proyectos Vb2017\Redireccionamiento\DESPACHOS_PROY\Temp\Rep_Estado_Boletas.xlsx"
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


        'tipo_documento, folio, fecha, rut, codigo_producto, productos.nombre, serie, tipo_movimiento, n_guia_prov, parcelado

        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Tipo Docto"
        grilla.Columns(1).HeaderCell.Value = "Folio"
        grilla.Columns(2).HeaderCell.Value = "Fecha"
        grilla.Columns(3).HeaderCell.Value = "Rut"
        grilla.Columns(4).HeaderCell.Value = "Codigo Prod"
        grilla.Columns(5).HeaderCell.Value = "Descripcion"
        grilla.Columns(6).HeaderCell.Value = "Serie"
        grilla.Columns(7).HeaderCell.Value = "Tipo Mov"
        grilla.Columns(8).HeaderCell.Value = "Nro Guia Prov"
        grilla.Columns(9).HeaderCell.Value = "Parcelado"

        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 90
        grilla.Columns(2).Width = 70
        grilla.Columns(3).Width = 90
        grilla.Columns(4).Width = 120
        grilla.Columns(5).Width = 220
        grilla.Columns(6).Width = 120
        grilla.Columns(7).Width = 80
        grilla.Columns(8).Width = 90
        grilla.Columns(9).Width = 90


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



    Sub Formato_grilla2()


        'cod_prod, descrip, serie, nro_docto_salida FROM series_salida_dp

        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Cod.Prod."
        grilla.Columns(1).HeaderCell.Value = "Descripcion"
        grilla.Columns(2).HeaderCell.Value = "Serie"
        grilla.Columns(3).HeaderCell.Value = "Nro Docto"

        grilla.Columns(0).Width = 100
        grilla.Columns(1).Width = 340
        grilla.Columns(2).Width = 200
        grilla.Columns(3).Width = 150


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



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

    Sub formato_grilla3()

        'series_salida_dp.nro_comprobante, fe_reg, nro_docto_salida, fe_docto, tipo_docto, rutclie, despachador, parcelado, nguia, cod_prod, descrip, serie, cantidad
        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Nro Comprobante"
        grilla.Columns(1).HeaderCell.Value = "Fecha Reg"
        grilla.Columns(2).HeaderCell.Value = "Nro Docto Salida"
        grilla.Columns(3).HeaderCell.Value = "Fecha Docto"
        grilla.Columns(4).HeaderCell.Value = "Tipo Docto"
        grilla.Columns(5).HeaderCell.Value = "Rut Clte"
        grilla.Columns(6).HeaderCell.Value = "Despachador"
        grilla.Columns(7).HeaderCell.Value = "Parcelado"
        grilla.Columns(8).HeaderCell.Value = "Nro Guia"
        grilla.Columns(9).HeaderCell.Value = "Cod Prod"
        grilla.Columns(10).HeaderCell.Value = "Descripcion"
        grilla.Columns(11).HeaderCell.Value = "Serie"
        grilla.Columns(12).HeaderCell.Value = "Cantidad"

        grilla.Columns(0).Width = 100
        grilla.Columns(1).Width = 70
        grilla.Columns(2).Width = 90
        grilla.Columns(3).Width = 70
        grilla.Columns(4).Width = 70
        grilla.Columns(5).Width = 100
        grilla.Columns(6).Width = 100
        grilla.Columns(7).Width = 70
        grilla.Columns(8).Width = 90
        grilla.Columns(9).Width = 100
        grilla.Columns(10).Width = 200
        grilla.Columns(11).Width = 80
        grilla.Columns(12).Width = 70


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

    Private Sub frm_cons_series_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        op_entrada.Checked = False
        op_salida.Checked = False
        op_despacho.Checked = False
        lbl_cartel.Text = ""

        txt_serie.Text = ""
        txt_serie.Enabled = False
        cmd_exp_excel.Enabled = False
        cmd_buscar.Enabled = False

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
        Me.Text = v_emp & " / Reporte de Estado Boletas para Despacho **** AÑO " & miano & " **** Conectado como: " & retenUser



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



    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Dim cmd38 As New MySqlCommand
        Dim marca As Integer = 0

        'Try


        If emp_entrada = 1 Then  'cintegral
                Call ConectaCint()
                Call elano()
            Else                     'global
                Call ConectaGlo()
                Call elano()
            End If


            If conexion.State = 1 Then conexion.Close()
            conexion.Open()
            cmd38.Connection = conexion


            If op_entrada.Checked = True Then  'serie de proveedor
                marca = 1

            cmd38.CommandText = "SELECT tipo_documento, folio, fecha, rut, codigo_producto, productos.nombre, serie, tipo_movimiento, n_guia_prov, parcelado From series inner join productos on series.codigo_producto = productos.codigo WHERE tipo_movimiento = 'C' and serie like '%" & txt_serie.Text & "%' ORDER BY folio DESC"

        End If

            If op_salida.Checked = True Then
                marca = 1
                ' serie de cliente
                cmd38.CommandText = "SELECT tipo_documento, folio, fecha, rut, codigo_producto, productos.nombre, serie, tipo_movimiento, n_guia_prov, parcelado From series inner join productos on series.codigo_producto = productos.codigo WHERE tipo_movimiento = 'V' and serie = '" & txt_serie.Text & "' ORDER BY folio DESC"

            End If

            If op_despacho.Checked = True Then
            marca = 3
            ' serie de cliente despachada
            cmd38.CommandText = "SELECT series_salida_dp.nro_comprobante, fe_reg, nro_docto_salida, fe_docto, tipo_docto, rutclie, despachador, parcelado, nguia, cod_prod, descrip, serie, cantidad From series_salida_dp inner join det_series_salida_dp on series_salida_dp.nro_comprobante = det_series_salida_dp.nro_comprobante WHERE serie = '" & txt_serie.Text & "' ORDER BY nro_docto_salida DESC"

            End If

            If op_nro_fact.Checked = True Then
                marca = 2
                ' serie de cliente por nro de factura
                'cmd38.CommandText = "SELECT tipo_documento, folio, fecha, rut, codigo_producto, productos.nombre, serie, tipo_movimiento, n_guia_prov, parcelado From series inner join productos on series.codigo_producto = productos.codigo WHERE tipo_movimiento = 'V' and serie = '" & txt_serie.Text & "' ORDER BY folio DESC"
                cmd38.CommandText = "SELECT cod_prod, descrip, serie, nro_docto_salida FROM series_salida_dp inner join det_series_salida_dp on series_salida_dp.nro_comprobante = det_series_salida_dp.nro_comprobante where nro_docto_salida = '" & txt_serie.Text & "';"

            End If

            Dim dt As System.Data.DataTable = New System.Data.DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd38)

            da.Fill(dt)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                ' If dt.Rows.Count <> 0 Then
                grilla.DataSource = dt



                conexion.Close()
                da.Dispose()
                cmd38.Dispose()

            Cursor.Current = Cursors.Default

            Select Case marca
                Case = 1
                    Call Formato_grilla()
                Case = 2
                    Call Formato_grilla2()
                Case = 3
                    Call formato_grilla3()

            End Select



        Else
                Cursor.Current = Cursors.Default
                MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)

            End If


        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub op_entrada_CheckedChanged(sender As Object, e As EventArgs) Handles op_entrada.CheckedChanged
        If op_entrada.Checked = True Then
            op_salida.Checked = False
            op_despacho.Checked = False
            op_nro_fact.Checked = False
            lbl_buscar.Text = "Ingrese Serie"
            txt_serie.Enabled = True

        End If
    End Sub

    Private Sub op_salida_CheckedChanged(sender As Object, e As EventArgs) Handles op_salida.CheckedChanged
        If op_salida.Checked = True Then
            op_entrada.Checked = False
            op_despacho.Checked = False
            op_nro_fact.Checked = False
            lbl_buscar.Text = "Ingrese Serie"
            txt_serie.Enabled = True

        End If
    End Sub

    Private Sub op_despacho_CheckedChanged(sender As Object, e As EventArgs) Handles op_despacho.CheckedChanged
        If op_despacho.Checked = True Then
            op_salida.Checked = False
            op_entrada.Checked = False
            op_nro_fact.Checked = False
            lbl_buscar.Text = "Ingrese Serie"
            txt_serie.Enabled = True

        End If
    End Sub

    Private Sub txt_serie_TextChanged(sender As Object, e As EventArgs) Handles txt_serie.TextChanged

    End Sub

    Private Sub txt_serie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_serie.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If txt_serie.Text <> "" Then
                cmd_buscar.Enabled = True
                cmd_exp_excel.Enabled = True
                cmd_buscar.Focus()
            Else
                cmd_buscar.Enabled = False
                cmd_exp_excel.Enabled = False
            End If

        End If
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        Call Exp_Excel2(grilla)
    End Sub

    Private Sub frm_cons_series_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()

    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_cons_series_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub op_nro_fact_CheckedChanged(sender As Object, e As EventArgs) Handles op_nro_fact.CheckedChanged
        If op_nro_fact.Checked = True Then
            op_salida.Checked = False
            op_entrada.Checked = False
            op_despacho.Checked = False
            lbl_buscar.Text = "Ingrese Nro Factura"
            txt_serie.Enabled = True

        End If
    End Sub
End Class