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

Public Class frm_Rep_Est_Boletas

    Private mifecha As Date
    Private mifecha2 As Date
    Dim tipo_estado As Integer ' 0 en transito 1 despachado y entregado
    Dim tipo_guia As Integer ' 0 cliente 1 sin factura 2 traspaso


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

        'REVISAR viernes 28/03
        'dejar campos necesarios

        'nrodp, nfactura, rutclie, nomclie, comuna, monto_fact, nboleta, nguia, fe_docto, fe_desp, transporte, patente, nflete, 
        'recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos, 
        'fe_creacion, obs_reingreso, obs_despacho, usuario, usuario_reing

        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Nro DP"
        grilla.Columns(1).HeaderCell.Value = "Nro Factura"
        grilla.Columns(2).HeaderCell.Value = "Rut Clte"
        grilla.Columns(3).HeaderCell.Value = "Nombre"
        grilla.Columns(4).HeaderCell.Value = "Ciudad"
        grilla.Columns(5).HeaderCell.Value = "Monto Fact"
        grilla.Columns(6).HeaderCell.Value = "Nro Boleta"
        grilla.Columns(7).HeaderCell.Value = "Nro Guia"
        grilla.Columns(8).HeaderCell.Value = "Fe Docto"
        grilla.Columns(9).HeaderCell.Value = "Fe Desp"
        grilla.Columns(10).HeaderCell.Value = "Transporte"
        grilla.Columns(11).HeaderCell.Value = "patente"
        grilla.Columns(12).HeaderCell.Value = "Nro Flete"
        grilla.Columns(13).HeaderCell.Value = "Recibio"
        grilla.Columns(14).HeaderCell.Value = "Fe Reingreso"
        grilla.Columns(15).HeaderCell.Value = "Nro Cedible"
        grilla.Columns(16).HeaderCell.Value = "Fe.Cliente"
        grilla.Columns(17).HeaderCell.Value = "Vendedor"
        grilla.Columns(18).HeaderCell.Value = "Chofer"
        grilla.Columns(19).HeaderCell.Value = "Despachador"
        grilla.Columns(20).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(21).HeaderCell.Value = "Hr Salida"
        grilla.Columns(22).HeaderCell.Value = "NOC"
        grilla.Columns(23).HeaderCell.Value = "gramos"
        grilla.Columns(24).HeaderCell.Value = "Fe Creacion"
        grilla.Columns(25).HeaderCell.Value = "Obs Reingreso"
        grilla.Columns(26).HeaderCell.Value = "Obs Despacho"
        grilla.Columns(27).HeaderCell.Value = "Usuario"
        grilla.Columns(28).HeaderCell.Value = "Usuario Reingreso"


        grilla.Columns(0).Width = 60
        grilla.Columns(1).Width = 0
        grilla.Columns(2).Width = 80
        grilla.Columns(3).Width = 120
        grilla.Columns(4).Width = 100
        grilla.Columns(5).Width = 80
        grilla.Columns(6).Width = 80
        grilla.Columns(7).Width = 0
        grilla.Columns(8).Width = 70
        grilla.Columns(9).Width = 70
        grilla.Columns(10).Width = 120
        grilla.Columns(11).Width = 70
        grilla.Columns(12).Width = 100
        grilla.Columns(13).Width = 120
        grilla.Columns(14).Width = 75
        grilla.Columns(15).Width = 100
        grilla.Columns(16).Width = 70
        grilla.Columns(17).Width = 90
        grilla.Columns(18).Width = 120
        grilla.Columns(19).Width = 120
        grilla.Columns(20).Width = 60
        grilla.Columns(21).Width = 70
        grilla.Columns(22).Width = 0
        grilla.Columns(23).Width = 60
        grilla.Columns(24).Width = 80
        grilla.Columns(25).Width = 0
        grilla.Columns(26).Width = 0
        grilla.Columns(27).Width = 70
        grilla.Columns(28).Width = 70



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
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
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
        grilla.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft


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


    Private Sub frm_Rep_Est_Boletas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        lbl_cartel.Text = ""


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


        If tipo_estado = 1 Then
            ' despachado y entregado con guia cliente

            cmd28.CommandText = "SELECT nrodp, nfactura, rutclie, nomclie, comuna, monto_fact, nboleta, nguia, fe_docto, fe_desp, transporte, patente, nflete, recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos, fe_creacion, obs_reingreso, obs_despacho, usuario, usuario_reing From boletas_dp WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and fe_reingreso is not null ORDER BY fe_docto, nrodp DESC"

        Else
            ' en transito con guia cliente
            cmd28.CommandText = "SELECT nrodp, nfactura, rutclie, nomclie, comuna, monto_fact, nboleta, nguia, fe_docto, fe_desp, transporte, patente, nflete, recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos, fe_creacion, obs_reingreso, obs_despacho, usuario, usuario_reing From boletas_dp WHERE fe_desp between '" & mifecha.ToString("yyyy-MM-dd") & "' and '" & mifecha2.ToString("yyyy-MM-dd") & "' and fe_reingreso is null ORDER BY fe_docto, nrodp DESC"

        End If


        Dim dt As System.Data.DataTable = New System.Data.DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd28)

        da.Fill(dt)
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

            ' If dt.Rows.Count <> 0 Then
            grilla.DataSource = dt


            Call Formato_grilla()


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

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_Rep_Est_Boletas_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        Call Exp_Excel2(grilla)
    End Sub

    Private Sub cbo_estado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_estado.SelectedIndexChanged

    End Sub
End Class