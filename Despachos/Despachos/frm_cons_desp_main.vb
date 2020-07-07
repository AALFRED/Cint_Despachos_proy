Imports System.Data
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
Imports Microsoft.Office.Interop.Excel
Imports Despachos
Imports System.Globalization


Public Class frm_cons_desp_main


    Dim cmd10 As MySqlCommand = New MySqlCommand



    Sub Exp_Excel(migrilla2 As DataGridView)  'MYSQL


        If ((migrilla2.Columns.Count = 0) Or (migrilla2.Rows.Count = 0)) Then
            MsgBox("No hay datos para procesar", MsgBoxStyle.Critical, "Sin Datos")
            'Exit Sub
        Else

            Dim dt As New System.Data.DataTable
            dt = TryCast(migrilla2.DataSource, System.Data.DataTable)

            ' My.Computer.FileSystem.DeleteFile("C:\Proyectos Vb2017\DESPACHOS\Despachos\Temp\Rep_desp.xlsx")
            My.Computer.FileSystem.DeleteFile("C:\Proyectos Vb2017\Redireccionamiento\DESPACHOS_PROY\Temp\Rep_desp.xlsx")

            Dim fileg As New FileInfo("C:\Proyectos Vb2017\Redireccionamiento\DESPACHOS\Temp\Rep_desp.xlsx")
            Using package As New OfficeOpenXml.ExcelPackage(fileg)
                Dim ws As OfficeOpenXml.ExcelWorksheet = package.Workbook.Worksheets.Add("Hoja1")
                ws.Cells("A1").LoadFromDataTable(dt, True)
                package.Save()
            End Using


            MessageBox.Show("El documento fue exportado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)



            'wBook.SaveAs(strFileName)
            'aplicacion.Workbooks.Open(strFileName)
            'aplicacion.Visible = True


        End If


    End Sub


    Sub formato_grilla_fact()

        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "id"
        grilla.Columns(1).HeaderCell.Value = "NroDP"
        grilla.Columns(2).HeaderCell.Value = "Nro Fact."
        grilla.Columns(3).HeaderCell.Value = "Rut"
        grilla.Columns(4).HeaderCell.Value = "Nombre"
        grilla.Columns(5).HeaderCell.Value = "Direccion Desp"
        grilla.Columns(6).HeaderCell.Value = "Comuna"
        grilla.Columns(7).HeaderCell.Value = "Monto Fact"
        grilla.Columns(8).HeaderCell.Value = "Nro Boleta"
        grilla.Columns(9).HeaderCell.Value = "Nro Guia"
        grilla.Columns(10).HeaderCell.Value = "Fe. Docto."
        grilla.Columns(11).HeaderCell.Value = "Fe. Desp."
        grilla.Columns(12).HeaderCell.Value = "Transporte"
        grilla.Columns(13).HeaderCell.Value = "Patente"
        grilla.Columns(14).HeaderCell.Value = "Nro Flete"
        grilla.Columns(15).HeaderCell.Value = "Recibió"
        grilla.Columns(16).HeaderCell.Value = "Fe. Reingreso"
        grilla.Columns(17).HeaderCell.Value = "Nro Cedible"
        grilla.Columns(18).HeaderCell.Value = "Fe. Cliente"
        grilla.Columns(19).HeaderCell.Value = "Vendedor"
        grilla.Columns(20).HeaderCell.Value = "Chofer"
        grilla.Columns(21).HeaderCell.Value = "Despachador"
        grilla.Columns(22).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(23).HeaderCell.Value = "Hora Salida"
        grilla.Columns(24).HeaderCell.Value = "Nro NOC"
        grilla.Columns(25).HeaderCell.Value = "Peso (grs)"
        grilla.Columns(26).HeaderCell.Value = "Fe. Creación"
        grilla.Columns(27).HeaderCell.Value = "Obs.Reingreso"
        grilla.Columns(28).HeaderCell.Value = "Obs.Despacho"
        grilla.Columns(29).HeaderCell.Value = "Usr.Registro"
        grilla.Columns(30).HeaderCell.Value = "Usr.Reingreso"


        grilla.Columns(0).Visible = False 'idbd
        grilla.Columns(5).Visible = False 'direccion
        grilla.Columns(8).Visible = False 'nro boleta
        grilla.Columns(9).Visible = False 'nro guia
        grilla.Columns(23).Visible = False 'hora salida
        grilla.Columns(24).Visible = False 'NOC
        grilla.Columns(27).Visible = False 'obs reing

        grilla.Columns(1).Width = 70
        grilla.Columns(2).Width = 60
        grilla.Columns(3).Width = 70
        grilla.Columns(4).Width = 200

        grilla.Columns(6).Width = 100
        grilla.Columns(7).Width = 70

        grilla.Columns(10).Width = 70
        grilla.Columns(11).Width = 70
        grilla.Columns(12).Width = 75
        grilla.Columns(13).Width = 70
        grilla.Columns(14).Width = 70
        grilla.Columns(15).Width = 120
        grilla.Columns(16).Width = 70
        grilla.Columns(17).Width = 70
        grilla.Columns(18).Width = 70
        grilla.Columns(19).Width = 100
        grilla.Columns(20).Width = 80
        grilla.Columns(21).Width = 80
        grilla.Columns(22).Width = 50


        grilla.Columns(25).Width = 50
        grilla.Columns(26).Width = 70

        grilla.Columns(28).Width = 150
        grilla.Columns(29).Width = 80
        grilla.Columns(30).Width = 80



        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        grilla.RowsDefaultCellStyle.ForeColor = Color.White
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()

    End Sub

    Sub formato_grilla_Boe()

        'Select id, nrodp, rutclie, nomclie, comuna, nboleta, monto_fact, fe_docto, fe_desp, transporte, 
        'patente, nflete, recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, 
        'nrobultos, h_salida, noc, gramos, fe_creacion, obs_despacho, obs_reingreso, usuario, usuario_reing

        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "id"
        grilla.Columns(1).HeaderCell.Value = "NroDP"
        grilla.Columns(2).HeaderCell.Value = "Rut"
        grilla.Columns(3).HeaderCell.Value = "Nombre"
        grilla.Columns(4).HeaderCell.Value = "Comuna"
        grilla.Columns(5).HeaderCell.Value = "Nro Boleta"
        grilla.Columns(6).HeaderCell.Value = "Monto Fact"
        grilla.Columns(7).HeaderCell.Value = "Fe. Docto."
        grilla.Columns(8).HeaderCell.Value = "Fe. Desp."
        grilla.Columns(9).HeaderCell.Value = "Transporte"
        grilla.Columns(10).HeaderCell.Value = "Patente"
        grilla.Columns(11).HeaderCell.Value = "Nro Flete"
        grilla.Columns(12).HeaderCell.Value = "Recibió"
        grilla.Columns(13).HeaderCell.Value = "Fe. Reingreso"
        grilla.Columns(14).HeaderCell.Value = "Nro Cedible"
        grilla.Columns(15).HeaderCell.Value = "Fe. Cliente"
        grilla.Columns(16).HeaderCell.Value = "Vendedor"
        grilla.Columns(17).HeaderCell.Value = "Chofer"
        grilla.Columns(18).HeaderCell.Value = "Despachador"
        grilla.Columns(19).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(20).HeaderCell.Value = "Hora Salida"
        grilla.Columns(21).HeaderCell.Value = "Nro NOC"
        grilla.Columns(22).HeaderCell.Value = "Peso (grs)"
        grilla.Columns(23).HeaderCell.Value = "Fe. Creación"
        grilla.Columns(24).HeaderCell.Value = "Obs.Despacho"
        grilla.Columns(25).HeaderCell.Value = "Obs.Reingreso"
        grilla.Columns(26).HeaderCell.Value = "Usr.Registro"
        grilla.Columns(27).HeaderCell.Value = "Usr.Reingreso"


        grilla.Columns(0).Visible = False 'idbd

        grilla.Columns(20).Visible = False 'hora salida
        grilla.Columns(21).Visible = False 'NOC
        grilla.Columns(25).Visible = False 'obs reing

        grilla.Columns(1).Width = 70 'nro dp
        grilla.Columns(2).Width = 60 'rut
        grilla.Columns(3).Width = 70 'nombre
        grilla.Columns(4).Width = 120 'comuna

        grilla.Columns(5).Width = 100 'nro boleta
        grilla.Columns(6).Width = 80 'monto 
        grilla.Columns(7).Width = 70 'fe docto
        grilla.Columns(8).Width = 70 'fe desp
        grilla.Columns(9).Width = 90 'transporte
        grilla.Columns(10).Width = 70 'patente
        grilla.Columns(11).Width = 75 'nro flete
        grilla.Columns(12).Width = 90 'recibio
        grilla.Columns(13).Width = 70 'fe reingreso
        grilla.Columns(14).Width = 70 'nro cedible
        grilla.Columns(15).Width = 70 ' fe cliente
        grilla.Columns(16).Width = 70 'vend
        grilla.Columns(17).Width = 80 'chofer
        grilla.Columns(18).Width = 100 'despachador
        grilla.Columns(19).Width = 80 'nro bultos
        grilla.Columns(22).Width = 55 'peso
        grilla.Columns(23).Width = 70 'fe creacion
        grilla.Columns(24).Width = 150 'obs despacho

        grilla.Columns(26).Width = 80 'usr resgistro
        grilla.Columns(27).Width = 80 'usr reing




        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter





        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        grilla.RowsDefaultCellStyle.ForeColor = Color.White
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()

    End Sub

    Sub formato_grilla_guia()

        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "id"
        grilla.Columns(1).HeaderCell.Value = "NroDP"
        grilla.Columns(2).HeaderCell.Value = "Nro Fact"
        grilla.Columns(3).HeaderCell.Value = "Nro Guia"
        grilla.Columns(4).HeaderCell.Value = "Direccion"
        grilla.Columns(5).HeaderCell.Value = "Comuna"
        grilla.Columns(6).HeaderCell.Value = "Rut Clte"
        grilla.Columns(7).HeaderCell.Value = "Nombre"
        grilla.Columns(8).HeaderCell.Value = "Fe.Docto."
        grilla.Columns(9).HeaderCell.Value = "Fe.Desp."
        grilla.Columns(10).HeaderCell.Value = "Transporte"
        grilla.Columns(11).HeaderCell.Value = "Patente"
        grilla.Columns(12).HeaderCell.Value = "Nro Flete"
        grilla.Columns(13).HeaderCell.Value = "Recibió"
        grilla.Columns(14).HeaderCell.Value = "Fe.Reingreso"
        grilla.Columns(15).HeaderCell.Value = "Nro Cedible"
        grilla.Columns(16).HeaderCell.Value = "Fech.Clte"
        grilla.Columns(17).HeaderCell.Value = "Vendedor"
        grilla.Columns(18).HeaderCell.Value = "Chofer"
        grilla.Columns(19).HeaderCell.Value = "Despachador"
        grilla.Columns(20).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(21).HeaderCell.Value = "Hr Salida"
        grilla.Columns(22).HeaderCell.Value = "N.O.C"
        grilla.Columns(23).HeaderCell.Value = "Peso (grs)"
        grilla.Columns(24).HeaderCell.Value = "Fech.Creacion"
        grilla.Columns(25).HeaderCell.Value = "Obs.Reingreso"
        grilla.Columns(26).HeaderCell.Value = "Obs.Despacho"
        grilla.Columns(27).HeaderCell.Value = "Usuario"
        grilla.Columns(28).HeaderCell.Value = "Usuario Reing."
        grilla.Columns(29).HeaderCell.Value = "Es Garantía"
        grilla.Columns(30).HeaderCell.Value = "Destino"

        grilla.Columns(0).Visible = False 'idbd

        grilla.Columns(1).Width = 70 'nro dp
        grilla.Columns(2).Width = 60 'nro fact
        grilla.Columns(3).Width = 70 'nro guia
        grilla.Columns(4).Width = 120 'direccion
        grilla.Columns(5).Width = 100 'comuna
        grilla.Columns(6).Width = 80 'rut
        grilla.Columns(7).Width = 70 'nombre
        grilla.Columns(8).Width = 70 'fe docto
        grilla.Columns(9).Width = 90 'fe desp
        grilla.Columns(10).Width = 70 'transporte
        grilla.Columns(11).Width = 75 'patente
        grilla.Columns(12).Width = 90 'nro flete
        grilla.Columns(13).Width = 70 'recibio
        grilla.Columns(14).Width = 70 'fe reing
        grilla.Columns(15).Width = 70 ' cedible
        grilla.Columns(16).Width = 70 'fe cliente
        grilla.Columns(17).Width = 80 'vendedor
        grilla.Columns(18).Width = 100 'chofer
        grilla.Columns(19).Width = 80 'despachador
        grilla.Columns(22).Width = 55 'nro bultos
        grilla.Columns(23).Width = 70 'peso
        grilla.Columns(24).Width = 70 'fe creacion
        grilla.Columns(25).Width = 70 'obs reing
        grilla.Columns(26).Width = 80 'obs desp
        grilla.Columns(27).Width = 80 'usuario 
        grilla.Columns(28).Width = 80 'usr reing
        grilla.Columns(29).Width = 80 'es garantia
        grilla.Columns(30).Width = 80 'destino


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(20).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(24).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(25).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(26).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(27).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(28).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(29).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(30).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter



        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        grilla.RowsDefaultCellStyle.ForeColor = Color.White
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()

    End Sub


    Sub formato_grilla_guia_trasp()

        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "NroDP"
        grilla.Columns(1).HeaderCell.Value = "Nro Guia"
        grilla.Columns(2).HeaderCell.Value = "Bod Origen"
        grilla.Columns(3).HeaderCell.Value = "Bod Destino"
        grilla.Columns(4).HeaderCell.Value = "Fe.Trasp."
        grilla.Columns(5).HeaderCell.Value = "Rut"
        grilla.Columns(6).HeaderCell.Value = "Nombre"
        grilla.Columns(7).HeaderCell.Value = "Direccion"
        grilla.Columns(8).HeaderCell.Value = "Fe.Desp."
        grilla.Columns(9).HeaderCell.Value = "Transporte"
        grilla.Columns(10).HeaderCell.Value = "Patente"
        grilla.Columns(11).HeaderCell.Value = "Chofer"
        grilla.Columns(12).HeaderCell.Value = "Peso (grs)"
        grilla.Columns(13).HeaderCell.Value = "Nro Bultos"
        grilla.Columns(14).HeaderCell.Value = "Fe.Recep."
        grilla.Columns(15).HeaderCell.Value = "Confirmacion"
        grilla.Columns(16).HeaderCell.Value = "Observacion"
        grilla.Columns(17).HeaderCell.Value = "Obs.Reingreso"
        grilla.Columns(18).HeaderCell.Value = "Usuario"
        grilla.Columns(19).HeaderCell.Value = "Usuario Reing."

        grilla.Columns(7).Visible = False 'idbd
        grilla.Columns(17).Visible = False 'idbd
        grilla.Columns(15).Visible = False 'idbd

        grilla.Columns(0).Width = 70 'nro dp
        grilla.Columns(1).Width = 60 'nro guia
        grilla.Columns(2).Width = 70 'bod origen
        grilla.Columns(3).Width = 120 'bod destino
        grilla.Columns(4).Width = 100 'fe trasp
        grilla.Columns(5).Width = 80 'rut
        grilla.Columns(6).Width = 70 'nombre
        grilla.Columns(7).Width = 70 'direccion
        grilla.Columns(8).Width = 90 'fe desp
        grilla.Columns(9).Width = 70 'transporte
        grilla.Columns(10).Width = 75 'patente
        grilla.Columns(11).Width = 90 'chofer
        grilla.Columns(12).Width = 70 'peso
        grilla.Columns(13).Width = 70 'nro bultos
        grilla.Columns(14).Width = 70 ' fe recep
        grilla.Columns(15).Width = 70 'confirmacion
        grilla.Columns(16).Width = 80 'observacion
        grilla.Columns(17).Width = 100 'obs reingreso
        grilla.Columns(18).Width = 80 'usuario
        grilla.Columns(19).Width = 80 'usuario reing


        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter




        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        grilla.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        grilla.RowsDefaultCellStyle.ForeColor = Color.White
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(2), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()

    End Sub



    Private Sub cmd_cancelar_Click(sender As Object, e As EventArgs) Handles cmd_cancelar.Click
        Me.Dispose()
        frm_Menu.Show()

    End Sub

    Private Sub frm_cons_desp_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Me.Text = v_emp & " / Consulta de Despachas **** AÑO " & miano & " **** Conectado como: " & retenUser


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

        'control carga
        cbo_tipo.Items.Add("FACTURA")
        cbo_tipo.Items.Add("BOLETA")
        cbo_tipo.Items.Add("GUIA")
        cbo_tipo.Items.Add("GUIA TRASP")
        cbo_tipo.Items.Add("GUIA ELECTRONICA")
        cbo_tipo.Items.Add("NRO DPI")

        cmd_buscar.Enabled = False
        cmd_exp_excel.Enabled = False

    End Sub

    Private Sub cmd_limpiar_Click(sender As Object, e As EventArgs) Handles cmd_limpiar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_cons_desp_main_Load(e, e) 'Load everything in your form load event again
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click


        Dim valor As String


        Select Case cbo_tipo.Text
            Case "FACTURA"

                'Carga los datos en la grilla
                If ch_anio_ant.Checked = True Then
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

                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                'valor = "FEL0000" + txt_nrodocto.Text
                valor = txt_nrodocto.Text
                cmd10.Connection = conexion
                cmd10.CommandText = "Select * From entregas_dp Where nfactura = '" & valor & "'"
                Dim dt As System.Data.DataTable = New System.Data.DataTable
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd10)

                da.Fill(dt)
                'If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                grilla.DataSource = dt
                    Call formato_grilla_fact()


                    'Dim contenido As String
                    'Dim resul As String

                    ' For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                    'saca texto en las facturas
                    'contenido = grilla.Rows(i).Cells(2).Value
                    'If Strings.Left(contenido, 3) = "FEL" Then
                    'resul = Mid(contenido, 7, 10)

                    'grilla.Rows(i).Cells(2).Value = resul.ToString
                    'End If
                    ' resul = ""
                    '      contenido = ""
                    '       i = +i
                    'Next
                    cmd_exp_excel.Enabled = True
                    'Else
                    '    MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)
                    'End If
                    conexion.Close()
                da.Dispose()
                cmd10.Dispose()

            Case "BOLETA"

                'Carga los datos en la grilla
                If ch_anio_ant.Checked = True Then
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


                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                valor = txt_nrodocto.Text

                cmd10.Connection = conexion
                cmd10.CommandText = "Select id, nrodp, rutclie, nomclie, comuna, nboleta, monto_fact, fe_docto, fe_desp, transporte, patente, nflete, recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos, fe_creacion, obs_despacho, obs_reingreso, usuario, usuario_reing From boletas_dp Where nboleta = '" & valor & "'"
                Dim dt1 As System.Data.DataTable = New System.Data.DataTable
                Dim da1 As MySqlDataAdapter = New MySqlDataAdapter(cmd10)

                da1.Fill(dt1)
                'If dt1 IsNot Nothing AndAlso dt1.Rows.Count > 0 Then



                grilla.DataSource = dt1
                    Call formato_grilla_Boe()
                    cmd_exp_excel.Enabled = True
                ' Else
                'MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)
                ' End If

                conexion.Close()
                da1.Dispose()
                cmd10.Dispose()




            Case "GUIA"

                'Carga los datos en la grilla
                If ch_anio_ant.Checked = True Then
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

                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                valor = txt_nrodocto.Text
                cmd10.Connection = conexion
                cmd10.CommandText = "Select * From guias_dp Where nguia = '" & valor & "'"
                Dim dt As System.Data.DataTable = New System.Data.DataTable
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd10)

                da.Fill(dt)
                ' If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                grilla.DataSource = dt
                    Call formato_grilla_guia()
                    cmd_exp_excel.Enabled = True

                'Else
                'MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)

                'End If

                conexion.Close()
                da.Dispose()
                cmd10.Dispose()

            Case "GUIA TRASP"

                'Carga los datos en la grilla
                If ch_anio_ant.Checked = True Then
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


                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                valor = txt_nrodocto.Text
                cmd10.Connection = conexion
                cmd10.CommandText = "Select * From guias_trasp_dp Where nguia = '" & valor & "'"
                Dim dt As System.Data.DataTable = New System.Data.DataTable
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd10)

                da.Fill(dt)
                'If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                grilla.DataSource = dt
                    Call formato_grilla_guia_trasp()
                    cmd_exp_excel.Enabled = True
                'Else
                'MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)

                'End If

                conexion.Close()
                da.Dispose()
                cmd10.Dispose()

            Case "NRO DPI"

                'Carga los datos en la grilla
                If ch_anio_ant.Checked = True Then
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

                If conexion.State = 1 Then conexion.Close()
                conexion.Open()

                valor = txt_nrodocto.Text
                cmd10.Connection = conexion
                cmd10.CommandText = "Select * From entregas_dp Where nrodp = '" & valor & "'"
                Dim dt As System.Data.DataTable = New System.Data.DataTable
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd10)

                da.Fill(dt)
                ' If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                grilla.DataSource = dt
                    Call formato_grilla_fact()


                    ' Dim contenido As String
                    ' Dim resul As String

                    'For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                    'saca texto en las facturas
                    'contenido = grilla.Rows(i).Cells(2).Value
                    ' If Strings.Left(contenido, 3) = "FEL" Then
                    'resul = Mid(contenido, 7, 10)

                    'grilla.Rows(i).Cells(2).Value = resul.ToString
                    'End If
                    '   resul = ""
                    '  contenido = ""
                    ' i = +i
                    'Next
                    cmd_exp_excel.Enabled = True
                    ' Else
                    '     MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)
                    ' End If
                    conexion.Close()
                da.Dispose()
                cmd10.Dispose()

            Case "GUIA ELECTRONICA"


                'Carga los datos en la grilla
                If ch_anio_ant.Checked = True Then
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

                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    valor = txt_nrodocto.Text
                    cmd10.Connection = conexion
                cmd10.CommandText = "Select rut_receptor, razon_social_receptor, ciudad_receptor, folio, fecha_emision, tipo_cliente, nombre_bodega, transportista, direccion_entrega, comuna_entrega From ventas Where tipo_documento = 52 and folio = '" & valor & "'"
                Dim dt As System.Data.DataTable = New System.Data.DataTable
                    Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd10)

                    da.Fill(dt)
                    ' If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then

                    grilla.DataSource = dt



                cmd_exp_excel.Enabled = True
                    ' Else
                    '     MsgBox("No hay Datos para Cargar", MsgBoxStyle.Exclamation)
                    ' End If
                    conexion.Close()
                    da.Dispose()
                    cmd10.Dispose()

                End Select


    End Sub

    Private Sub txt_nrodocto_TextChanged(sender As Object, e As EventArgs) Handles txt_nrodocto.TextChanged

    End Sub

    Private Sub txt_nrodocto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nrodocto.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If txt_nrodocto.Text <> "" Then
                cmd_buscar.Enabled = True
                cmd_buscar.Select()
            Else
                txt_nrodocto.Select()

            End If

        End If

    End Sub

    Private Sub cmd_exp_excel_Click(sender As Object, e As EventArgs) Handles cmd_exp_excel.Click
        Dim valret As String = MsgBox("¿Desea Exportar los datos?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Exportar")
        If valret = 6 Then
            Call Exp_Excel(grilla)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub frm_cons_desp_main_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()

    End Sub
End Class