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


Public Class frm_ing_fel

    Dim fecha_actual As String
    Private counter As Integer
    Dim mes As Integer
    Dim reseña As Integer
    Dim bandera As Boolean



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
                    If lbl_nro_fact.Text = "" Then
                        bandera = True
                        MsgBox("El campo Nro Factura se encuentra vacío, verifique!", MsgBoxStyle.Critical)
                    Else
                        If cbo_acomodador.Text = "" Then
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

        sql = "Select MAX(nrodp) FROM ENTREGAS_DP ORDER BY nrodp ASC"
        com2 = New MySqlCommand(sql, conexion)
        rs2 = com2.ExecuteReader()

        If rs2.HasRows() Then
            rs2.Read()

            lbl_nrodp.Text = rs2.GetString(0)
            lbl_nrodp.Text = Val(lbl_nrodp.Text) + 1

        Else
            MessageBox.Show("No hay Correlativo Disponible", "Validacion de Correlativo")


            lbl_nrodp.Text = miano & "1"

            Exit Sub
        End If

        rs2.Dispose()
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
            Case 2 'ciudades
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 3 'moviles
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 4 'medios tp
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)
            Case 5 'acomodadores
                cmd1 = New MySqlCommand("select " & fldName & " from " & TABLENAME & " order by " & fldName, conexion)

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


    Sub Saca_Contenido_factura(ByRef mygrilla As DataGridView)

        Dim contenido As String
        Dim resul As String = ""

        Try

            If Me.Tab1.SelectedIndex = 0 Then




                For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                    'saca texto en las facturas


                    If mygrilla.Rows(i).Cells(0).Value = "0" Then
                        mygrilla.Rows(i).Cells(0).Value = ""
                        mygrilla.Rows(i).Cells(0).Value = resul.ToString
                    Else
                        contenido = mygrilla.Rows(i).Cells(0).Value
                        If Strings.Left(contenido, 3) = "FEL" Then
                            resul = Mid(contenido, 7, 10)
                        End If
                        mygrilla.Rows(i).Cells(0).Value = resul.ToString
                    End If


                    resul = ""
                    contenido = ""
                    i = +i
                Next
            Else

                For i As Integer = 0 To grilla2.Rows.Count() - 1 Step +1

                    'saca texto en las facturas


                    If mygrilla.Rows(i).Cells(5).Value = "0" Then
                        mygrilla.Rows(i).Cells(5).Value = ""
                        mygrilla.Rows(i).Cells(5).Value = resul.ToString
                    Else
                        contenido = mygrilla.Rows(i).Cells(5).Value
                        If Strings.Left(contenido, 3) = "FEL" Then
                            resul = Mid(contenido, 7, 10)
                        End If
                        mygrilla.Rows(i).Cells(5).Value = resul.ToString
                    End If


                    resul = ""
                    contenido = ""
                    i = +i
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            MsgBox("Saca_Contenido_factura")
        End Try

    End Sub

    Sub formato_grilla()
        'FORMATO DE GRILLA CM
        'VENTA.tipocon, VENTA.fechacon, VENTA.rutcon, Cliente.nomclie, VENTA.vencon, VENTA.netocon, VENTA.ordcon


        'FORMATO DE GRILLA
        grilla.Columns(0).HeaderCell.Value = "Nro Fact."
        grilla.Columns(1).HeaderCell.Value = "Fe.Fact"
        grilla.Columns(2).HeaderCell.Value = "Rut"
        grilla.Columns(3).HeaderCell.Value = "Cliente"
        grilla.Columns(4).HeaderCell.Value = "Ciudad"
        grilla.Columns(5).HeaderCell.Value = "Vendedor"
        grilla.Columns(6).HeaderCell.Value = "Neto Fact."
        grilla.Columns(7).HeaderCell.Value = "Ord.Compra"



        grilla.Columns(0).Width = 90
        grilla.Columns(1).Width = 70
        grilla.Columns(2).Width = 70
        grilla.Columns(3).Width = 390
        grilla.Columns(4).Width = 90
        grilla.Columns(5).Width = 100
        grilla.Columns(6).Width = 100
        grilla.Columns(7).Width = 160



        grilla.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        ' grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        ' grilla.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        ' grilla.RowsDefaultCellStyle.ForeColor = Color.White
        grilla.GridColor = Color.Black
        grilla.BorderStyle = BorderStyle.Fixed3D

        ' grilla.CellBorderStyle = DataGridViewCellBorderStyle.Single
        ' grilla.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        ' grilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla.Sort(grilla.Columns(1), System.ComponentModel.ListSortDirection.Descending)
        grilla.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla.Refresh()

    End Sub

    Sub Formato_grilla2()

        'nrodp, fe_creacion, rutclie, nomclie, comuna, nfactura, monto_fact, fe_docto,  noc, fe_desp, transporte, patente, nflete, nrobultos, gramos, h_salida, obs_despacho, vendedor, chofer, despachador

        'FORMATO DE GRILLA
        grilla2.Columns(0).HeaderCell.Value = "Nro DP"
        grilla2.Columns(1).HeaderCell.Value = "Fe.Creacion"
        grilla2.Columns(2).HeaderCell.Value = "Rut"
        grilla2.Columns(3).HeaderCell.Value = "Cliente"
        grilla2.Columns(4).HeaderCell.Value = "Ciudad"
        grilla2.Columns(5).HeaderCell.Value = "Nro Factura"
        grilla2.Columns(6).HeaderCell.Value = "Monto $"
        grilla2.Columns(7).HeaderCell.Value = "Fe.Docto."
        grilla2.Columns(8).HeaderCell.Value = "Nro.OC"
        grilla2.Columns(9).HeaderCell.Value = "Fe.Desp"
        grilla2.Columns(10).HeaderCell.Value = "Transporte"
        grilla2.Columns(11).HeaderCell.Value = "Patente"
        grilla2.Columns(12).HeaderCell.Value = "Nro Flete"
        grilla2.Columns(13).HeaderCell.Value = "Nro Bultos"
        grilla2.Columns(14).HeaderCell.Value = "Peso"
        grilla2.Columns(15).HeaderCell.Value = "Hr Salida"
        grilla2.Columns(16).HeaderCell.Value = "Obs.Despacho"
        grilla2.Columns(17).HeaderCell.Value = "Vendedor"
        grilla2.Columns(18).HeaderCell.Value = "Chofer"
        grilla2.Columns(19).HeaderCell.Value = "Ordenador"

        grilla2.Columns(6).Visible = False 'id
        grilla2.Columns(16).Visible = False 'fe creacion

        grilla2.Columns(0).Width = 60
        grilla2.Columns(1).Width = 70
        grilla2.Columns(2).Width = 70
        grilla2.Columns(3).Width = 350
        grilla2.Columns(4).Width = 100
        grilla2.Columns(5).Width = 80
        grilla2.Columns(7).Width = 70
        grilla2.Columns(8).Width = 90
        grilla2.Columns(9).Width = 80
        grilla2.Columns(10).Width = 100
        grilla2.Columns(11).Width = 60
        grilla2.Columns(12).Width = 80
        grilla2.Columns(13).Width = 60
        grilla2.Columns(14).Width = 70
        grilla2.Columns(15).Width = 60
        grilla2.Columns(16).Width = 150 'obs
        grilla2.Columns(17).Width = 120
        grilla2.Columns(18).Width = 90
        grilla2.Columns(19).Width = 120

        grilla2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(13).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(14).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(15).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(16).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(17).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        grilla2.Columns(18).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        grilla2.Columns(19).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        ' grilla.Font = New System.Drawing.Font("Calibri", 7.75, FontStyle.Regular)


        grilla2.RowsDefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.75, FontStyle.Bold)
        ' grilla2.RowsDefaultCellStyle.BackColor = Color.FromArgb(128, 128, 255)
        ' grilla2.RowsDefaultCellStyle.ForeColor = Color.White
        ' grilla2.GridColor = Color.Black
        ' grilla2.BorderStyle = BorderStyle.Fixed3D

        grilla2.CellBorderStyle = DataGridViewCellBorderStyle.Single
        grilla2.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grilla2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single

        grilla2.Sort(grilla2.Columns(0), System.ComponentModel.ListSortDirection.Descending)
        grilla2.RowHeadersVisible = False 'oculta la primera columna

        'grilla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 128)
        'grilla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White


        grilla2.Refresh()


    End Sub

    Sub Carga_grilla_cint()

        Dim cmd1 As New MySqlCommand

        Try
            'SACA EL MES
            mes = DateAndTime.Month(Date.Now.Date)

            Cursor.Current = Cursors.WaitCursor

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
            cmd1.Connection = conexion


            cmd1.CommandText = "SELECT Substring(VENTA.tipocon,8,10)tipocon, VENTA.fechacon, VENTA.rutcon, Cliente.nomclie, Cliente.ciuclie, VENTA.vencon, VENTA.netocon, VENTA.ordcon FROM VENTA INNER JOIN CLIENTE ON VENTA.rutcon = CLIENTE.rutclie WHERE VENTA.tipocon LIKE '%FEL%' AND year(VENTA.fechacon) = '" & miano & "' AND month(VENTA.fechacon) > '0' GROUP BY VENTA.tipocon, VENTA.fechacon, VENTA.rutcon, CLIENTE.nomclie, VENTA.vencon, VENTA.netocon, VENTA.ordcon ORDER BY fechacon DESC"


            Dim dt As System.Data.DataTable = New System.Data.DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd1)
            da.Fill(dt)
            ' If dt.Rows.Count <> 0 Then
            grilla.DataSource = dt

            conexion.Close()
            da.Dispose()
            cmd1.Dispose()



            Call formato_grilla()
            'Call Saca_Contenido_factura(grilla)


            Cursor.Current = Cursors.Default


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub frm_ing_fel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Me.Text = v_emp & " / Ingreso de Facturas para Despacho **** AÑO " & miano & " **** Conectado como: " & retenUser


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

        'CONTROL DE CARGA
        lbl_rut.Text = ""
        lbl_nombre.Text = ""
        lbl_nro_fact.Text = ""
        lbl_fe_fact.Text = ""
        lbl_mto_fact.Text = ""
        lbl_noc.Text = ""
        lbl_patente.Text = ""
        lbl_vendedor.Text = ""
        lbl_nrodp.Text = ""
        lbl_reg.Text = ""
        lbl_idbd.Text = ""
        lbl_codejec.Text = ""

        'cajas consulta despachos
        txt_bus_fact_desp.Visible = False
        txt_bus_oc_desp.Visible = False

        'oculta el cedible
        Label13.Visible = False
        txt_cedible.Visible = False


        cmd_modificar.Enabled = False
        cmd_modifica2.Visible = False
        cmd_guardar.Enabled = False

        Timer1.Enabled = True
        Timer1.Interval = 1000
        Timer1.Start()

        cbo_ampm.Items.Add("AM")
        cbo_ampm.Items.Add("PM")

        'carga la fecha actual
        fecha_actual = System.DateTime.Now.ToString(("yyyy-MM-dd"))
        lbl_fe_actual.Text = fecha_actual.ToString
        msk_fe_desp.Text = fecha_actual.ToString

        'carga los choferes
        reseña = 1
        Call cargacombo("chofer_dp", "nom_chof", cbo_chofer)

        'carga ciudades
        reseña = 2
        Call cargacombo("ciudad_dp", "comuna", cbo_ciudad)

        'carga moviles
        reseña = 3
        Call cargacombo("medios_dp", "tipo", cbo_medio_tp)

        'carga medios
        reseña = 4
        Call cargacombo("transporte_dp", "transporte", cbo_tp)

        'carga acomodadores
        reseña = 5
        Call cargacombo("ordenador_dp", "nom_orden", cbo_acomodador)


        grilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Timer1.Enabled = False
        ch_stop_timer.Checked = True  'stop timer activado

        'carga la grilla
        Call Carga_grilla_cint()
        Call Ultimo_nrodp()

        lbl_reg.Text = ""
        For fila = 1 To grilla.Rows.Count - 1

            lbl_reg.Text = Val(lbl_reg.Text) + 1

        Next

    End Sub

    Private Sub frm_ing_fel_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        frm_Menu.Show()

    End Sub

    Private Sub txt_bus_oc_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_oc.TextChanged

    End Sub

    Private Sub txt_bus_oc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_oc.KeyPress
        Dim target_name As String = ""
        Try
            ch_stop_timer.Checked = True
            'BUSCA OC

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_oc.Text))
                If Len(target_name) = 0 Then Exit Sub
                target_name = UCase(target_name)
                txt_bus_oc.CharacterCasing = CharacterCasing.Upper


                For r As Integer = 0 To Me.grilla.Rows.Count - 2

                    For x As Integer = 0 To grilla.ColumnCount - 1

                        If grilla.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla.CurrentCell = grilla.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue
                            grilla.CurrentRow.DefaultCellStyle.ForeColor = Color.Yellow
                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ch_stop_timer_CheckedChanged(sender As Object, e As EventArgs) Handles ch_stop_timer.CheckedChanged
        If ch_stop_timer.Checked = True Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If counter >= 3 Then
            ' Exit loop code.  
            Timer1.Enabled = True
            counter = 0

            Call Carga_grilla_cint()
            Ultimo_nrodp()
            lbl_reg.Text = ""
            For fila = 1 To grilla.Rows.Count - 1

                lbl_reg.Text = Val(lbl_reg.Text) + 1

            Next

        Else
            ' Run your procedure here.  
            ' Increment counter.  

            counter = counter + 1
            lbl_hora.Text = "Refresco Grilla en 3 seg: " & counter.ToString
        End If
    End Sub

    Private Sub grilla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grilla.CellContentClick

    End Sub

    Private Sub grilla_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grilla.CellMouseDoubleClick

        Dim com2 As New MySqlCommand
        Dim rs2 As MySqlDataReader



        'VERIFICA SI LA FACTURA YA SE REGISTRO
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
        sql = ""
        sql = "select * from entregas_dp where nfactura  = 'FEL0000" & grilla.Item(0, e.RowIndex).Value & "'"
        com2 = New MySqlCommand(sql, conexion)

        rs2 = com2.ExecuteReader()
        If rs2.HasRows() = True Then
            rs2.Read()
            MsgBox("Se ha detectado que esta Factura tiene Despacho Nro " & CStr(rs2("nrodp").ToString) & " Asociado, debe editar el despacho", MsgBoxStyle.Critical)
            com2.Dispose()
            rs2.Dispose()
            conexion.Close()
            Exit Sub
        Else


            'PASAR DATOS DE GRILLA A TEXTBOX
            'SEGUI_CM.id, SEGUI_CM.id_cm, SEGUI_CM.ordencomp, SEGUI_CM.fecha_emi_por, SEGUI_CM.razon_social, SEGUI_CM.und_compra, SEGUI_CM.rut_clie, SEGUI_CM.ventas_us, SEGUI_CM.tot_venta_cpl, SEGUI_CM.n_solic_vta, SEGUI_CM.fe_solic_vta, SEGUI_CM.nfactura, SEGUI_CM.fe_fact, SEGUI_CM.montofac, SEGUI_CM.estado_oc, SEGUI_CM.categoria, SEGUI_CM.obs1, SEGUI_CM.area_negocio

            If e.RowIndex < 0 Then Exit Sub
            Dim row As DataGridViewRow = CType(sender, DataGridView).CurrentRow

            ch_stop_timer.Checked = True 'detiene el timer

            lbl_rut.Text = grilla.Item(2, e.RowIndex).Value 'rut
            lbl_nombre.Text = grilla.Item(3, e.RowIndex).Value 'cliente
            cbo_ciudad.Text = grilla.Item(4, e.RowIndex).Value 'ciudad
            lbl_nro_fact.Text = grilla.Item(0, e.RowIndex).Value 'nro fact
            lbl_fe_fact.Text = grilla.Item(1, e.RowIndex).Value 'fecha fact
            lbl_mto_fact.Text = grilla.Item(6, e.RowIndex).Value 'mto_fact
            lbl_codejec.Text = grilla.Item(5, e.RowIndex).Value 'vendedor
            lbl_noc.Text = grilla.Item(7, e.RowIndex).Value 'NOC

            'busca al vendedor
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
            sql = ""
            sql = "select nomven from maemozo where codven = '" & lbl_codejec.Text & "'"
            com2 = New MySqlCommand(sql, conexion)

            rs2 = com2.ExecuteReader()
            If rs2.HasRows() = False Then
                MsgBox("No se encontró el nombre del vendedor", MsgBoxStyle.Critical)
                lbl_vendedor.Text = ""
            Else
                rs2.Read()
                lbl_vendedor.Text = CStr(rs2("nomven").ToString)
            End If
            com2.Dispose()
            conexion.Close()


            'busca la direccion de facturacion
            conexion.Open()

            sql = ""
            sql = "select dirclie from cliente where rutclie = '" & lbl_rut.Text & "'"

            com2 = New MySqlCommand(sql, conexion)

            rs2 = com2.ExecuteReader()
            If rs2.HasRows() = False Then
                MsgBox("No se encontró direccion", MsgBoxStyle.Critical)
                txt_dirclie.Text = ""
            Else
                rs2.Read()
                txt_dirclie.Text = CStr(rs2("dirclie").ToString)
            End If
            com2.Dispose()
            conexion.Close()

            txt_dirclie.Enabled = True
            txt_cedible.Enabled = True
            cbo_tp.Enabled = True
            cbo_ciudad.Enabled = False
            cbo_chofer.Enabled = True
            cbo_acomodador.Enabled = True
            txt_nrobulto.Enabled = True
            txt_nroflete.Enabled = True
            txt_peso.Enabled = True
            msk_fe_desp.Enabled = True
            txt_obs.Enabled = True
            cbo_ampm.Enabled = True
            cbo_ciudad.Enabled = False
            cbo_medio_tp.Enabled = True
            cmd_modificar.Enabled = False
            cmd_guardar.Enabled = False
            cbo_tp.Select()


        End If



    End Sub

    Private Sub cmd_limpíar_Click(sender As Object, e As EventArgs) Handles cmd_limpíar.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_ing_fel_Load(e, e) 'Load everything in your form load event again
        txt_bus_fact.Select()
        Timer2.Enabled = True
        MsgBox(Me.ActiveControl.Name)


    End Sub

    Private Sub cbo_tp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tp.SelectedIndexChanged
        Select Case cbo_tp.Text
            Case "URBANO"
                cbo_medio_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                lbl_patente.Text = "0"
                Label13.Visible = False
                txt_cedible.Visible = False
                cbo_medio_tp.Enabled = False
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_nroflete.Select()

            Case "STARKEN CTA CTE"
                cbo_medio_tp.Text = "EXTERNO"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False

                lbl_patente.Text = "0"
                Label13.Visible = False
                txt_cedible.Visible = False
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_nroflete.Select()

            Case "STARKEN POR PAGAR"
                cbo_medio_tp.Text = "EXTERNO"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                lbl_patente.Text = "0"
                Label13.Visible = False
                txt_cedible.Visible = False
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_nroflete.Select()

            Case "TRANSCOM"
                txt_nroflete.Enabled = False
                cbo_medio_tp.Enabled = True
                cbo_chofer.Enabled = True
                txt_nroflete.Text = "0"
                txt_nroflete.Enabled = False
                txt_peso.Text = "400"
                Label13.Visible = False
                txt_cedible.Visible = False
                cmd_guardar.Enabled = False
                txt_nrobulto.Select()

            Case "CHILEXPRESS"
                cbo_medio_tp.Text = "EXTERNO"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_cedible.Select()


            Case "CHILEXPRESS POR PAGAR"
                cbo_medio_tp.Text = "EXTERNO"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_cedible.Select()

            Case "CORREOS DE CHILE"
                cbo_medio_tp.Text = "EXTERNO"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False

                lbl_patente.Text = "0"
                Label13.Visible = False
                txt_cedible.Visible = False
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_nroflete.Select()


            Case "RETIRA CLIENTE"
                cbo_medio_tp.Text = "RETIRA CLIENTE"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "NO DEFINIDO"
                cbo_chofer.Enabled = False

                txt_nroflete.Text = "0"
                txt_nroflete.Enabled = False
                txt_peso.Text = "400"
                txt_peso.Enabled = False

                Label13.Visible = False
                txt_cedible.Visible = False
                lbl_patente.Text = "0"
                cmd_guardar.Enabled = False
                txt_nrobulto.Select()

            Case "OTROS"

                Label13.Visible = True
                txt_cedible.Visible = True
                cbo_medio_tp.Text = "EXTERNO"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False

                lbl_patente.Text = "0"
                Label13.Visible = True
                txt_cedible.Visible = True
                cmd_guardar.Enabled = False
                txt_nroflete.Select()

            Case "BLUE EXPRESS"
                cbo_medio_tp.Text = "EXTERNO"
                cbo_medio_tp.Enabled = False
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False

                lbl_patente.Text = "0"
                Label13.Visible = False
                txt_cedible.Visible = False
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_nroflete.Select()

            Case "T.L.N"

                cbo_medio_tp.Text = "EXTERNO"
                cbo_chofer.Text = "EXTERNO"
                cbo_chofer.Enabled = False
                lbl_patente.Text = "0"
                Label13.Visible = False
                txt_cedible.Visible = False
                cbo_medio_tp.Enabled = False
                cbo_ampm.Text = "PM"
                cbo_ampm.Enabled = False
                cmd_guardar.Enabled = False
                txt_nroflete.Select()


        End Select
    End Sub

    Private Sub txt_nroflete_TextChanged(sender As Object, e As EventArgs) Handles txt_nroflete.TextChanged

    End Sub

    Private Sub txt_nroflete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nroflete.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then

                If txt_nroflete.Text <> "" Then
                    txt_nrobulto.Select()

                Else
                    txt_nroflete.Select()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_nrobulto_TextChanged(sender As Object, e As EventArgs) Handles txt_nrobulto.TextChanged

    End Sub

    Private Sub txt_nrobulto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nrobulto.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then

                Select Case cbo_tp.Text

                    Case "BLUE EXPRESS"
                        cbo_chofer.Enabled = False
                        cbo_ciudad.Enabled = False
                        cbo_medio_tp.Enabled = False
                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()



                    Case "CHILEXPRESS"
                        cbo_chofer.Enabled = False
                        cbo_ciudad.Enabled = False
                        cbo_medio_tp.Enabled = False

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()

                    Case "CHILEXPRESS POR PAGAR"
                        cbo_chofer.Enabled = False
                        cbo_ciudad.Enabled = False
                        cbo_medio_tp.Enabled = False

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()

                    Case "RETIRA CLIENTE"
                        cbo_ciudad.Enabled = False
                        cbo_chofer.Enabled = False
                        cbo_medio_tp.Enabled = False
                        txt_peso.Enabled = False
                        txt_peso.Text = "400"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()




                    Case "TRANSCOM"
                        txt_nroflete.Text = "0"
                        cbo_chofer.Enabled = True
                        cbo_ciudad.Enabled = False
                        cbo_medio_tp.Enabled = True

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()

                    Case "URBANO"
                        cbo_ciudad.Enabled = False
                        cbo_chofer.Enabled = False
                        cbo_medio_tp.Enabled = False

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()

                    Case "STARKEN CTA CTE"
                        cbo_chofer.Enabled = False
                        cbo_ciudad.Enabled = False
                        cbo_medio_tp.Enabled = False

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()

                    Case "STARKEN POR PAGAR"
                        cbo_chofer.Enabled = False
                        cbo_ciudad.Enabled = False
                        cbo_medio_tp.Enabled = False

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()


                    Case "CORREOS DE CHILE"
                        cbo_chofer.Enabled = False
                        cbo_ciudad.Enabled = False
                        cbo_medio_tp.Enabled = False

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()

                    Case "T.L.N"
                        cbo_ciudad.Enabled = False
                        cbo_chofer.Enabled = False
                        cbo_medio_tp.Enabled = False

                        txt_peso.Text = " "
                        txt_peso.SelectAll()
                        txt_peso.Select()

                End Select



            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_peso_TextChanged(sender As Object, e As EventArgs) Handles txt_peso.TextChanged

    End Sub

    Private Sub txt_peso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_peso.KeyPress
        Try

            If e.KeyChar = Convert.ToChar(13) Then


                Select Case cbo_tp.Text
                    Case "BLUE EXPRESS"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()


                    Case "CHILEXPRESS"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()



                    Case "CHILEXPRESS POR PAGAR"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()


                    Case "CORREOS DE CHILE"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()


                    Case "OTROS"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()



                    Case "RETIRA CLIENTE"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()


                    Case "STARKEN CTA CTE"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()



                    Case "STARKEN POR PAGAR"
                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()


                    Case "TRANSCOM"
                        ' cbo_chofer.Enabled = True

                        cbo_chofer.Text = " "
                        cbo_chofer.SelectAll()
                        cbo_chofer.Select()

                    Case "URBANO"

                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()

                    Case "T.L.N"
                        cbo_acomodador.Enabled = True
                        cbo_acomodador.Text = "ASISTENTE"
                        cbo_acomodador.SelectAll()
                        cbo_acomodador.Select()


                End Select
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbo_ciudad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ciudad.SelectedIndexChanged

    End Sub

    Private Sub cbo_ciudad_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_ciudad.SelectedValueChanged
        'If cbo_ciudad.Text <> "" Then
        '    cbo_chofer.Select()
        'Else
        '    cbo_ciudad.Select()
        'End If

    End Sub

    Private Sub cbo_chofer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_chofer.SelectedIndexChanged

    End Sub

    Private Sub cbo_chofer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_chofer.SelectedValueChanged

        If cbo_chofer.Text <> "" Then
            cbo_medio_tp.Select()
        Else
            cbo_chofer.Select()
        End If
    End Sub

    Private Sub cbo_medio_tp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_medio_tp.SelectedIndexChanged
        If cbo_medio_tp.Text <> "" Then
            cbo_acomodador.Select()
        Else
            cbo_medio_tp.Select()

        End If
    End Sub

    Private Sub cbo_medio_tp_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_medio_tp.SelectedValueChanged
        Dim valor As String
        Dim com3 As New MySqlCommand
        Dim rs3 As MySqlDataReader


        Try
            If cbo_medio_tp.Text <> "" Then

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
                valor = CStr(cbo_medio_tp.Text)
                sql = "Select patente From medios_dp Where tipo = '" & LTrim(RTrim(valor)) & "'"
                com3 = New MySqlCommand(sql, conexion)

                rs3 = com3.ExecuteReader()
                rs3.Read()


                lbl_patente.Text = CStr(rs3("patente"))

                rs3.Close()
                conexion.Close()
                sql = ""

                msk_fe_desp.Select()
            Else
                cbo_medio_tp.Select()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbo_acomodador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_acomodador.SelectedIndexChanged

    End Sub

    Private Sub txt_peso_Leave(sender As Object, e As EventArgs) Handles txt_peso.Leave
        Try


            If txt_peso.Text < 400 Then
                MsgBox("El valor para peso como minimo es de 400 gramos, verifique!", MsgBoxStyle.Critical, "Control de Peso")
                txt_peso.Enabled = True
                txt_peso.Select()
            Else
                cbo_ciudad.Select()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "txt_peso_leave")
        End Try
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        Dim cmd4 As New MySqlCommand

        Try

            Call Valida_Campos()
            If bandera = True Then
                cmd_guardar.Enabled = False
                Exit Sub
            Else
                If lbl_rut.Text = "" Or lbl_nro_fact.Text = "" Then

                    MsgBox("DEBE SELECCIONAR UNA FACTURA PARA DESPACHO", MsgBoxStyle.Critical, "Verificación de Campos")
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

                    Dim value1 As String = cbo_ciudad.Text
                    Dim value2 As String = value1.Replace("'", "")
                    cbo_ciudad.Text = value2

                    If conexion.State = 1 Then conexion.Close()
                    conexion.Open()

                    cmd4 = New MySqlCommand("Insert Into entregas_dp (nrodp, rutclie, nomclie, dirdesp, nfactura, monto_fact, nboleta, nguia, fe_docto, fe_desp, patente, transporte, nflete, recibio, fe_reingreso, nro_rece, fe_cliente, vendedor, chofer, despachador, nrobultos, h_salida, noc, gramos, fe_creacion, comuna, obs_despacho, usuario) " &
                                            " Values ('" & lbl_nrodp.Text & "', '" & lbl_rut.Text & "', '" & lbl_nombre.Text & "', '" & txt_dirclie.Text & "', 'FEL0000" & lbl_nro_fact.Text & "', '" & lbl_mto_fact.Text & "', '0', '0', '" & lbl_fe_fact.Text & "', '" & msk_fe_desp.Text & "', '" & lbl_patente.Text & "', '" & cbo_tp.Text & "', '" & txt_nroflete.Text & "', '', null, '" & txt_cedible.Text & "', null, '" & lbl_vendedor.Text & "', '" & cbo_chofer.Text & "', '" & cbo_acomodador.Text & "', '" & txt_nrobulto.Text & "', '" & cbo_ampm.Text & "', '" & lbl_noc.Text & "', '" & txt_peso.Text & "', '" & lbl_fe_actual.Text & "', '" & cbo_ciudad.Text & "', '" & txt_obs.Text & "', '" & retenUser & "' )", conexion)
                    cmd4.ExecuteNonQuery()
                    conexion.Close()

                    MsgBox("Datos Almacenados Nro de Despacho Asignado ---> " & lbl_nrodp.Text, MsgBoxStyle.Information)
                    cmd_limpíar.PerformClick()
                    Ultimo_nrodp()


                End If

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txt_bus_fact_TextChanged(sender As Object, e As EventArgs) Handles txt_bus_fact.TextChanged

    End Sub

    Private Sub txt_bus_fact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_fact.KeyPress
        Dim target_name As String = ""
        Try
            ch_stop_timer.Checked = True
            'BUSCA LA FACTURA

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_fact.Text))
                If Len(target_name) = 0 Then Exit Sub

                For r As Integer = 0 To Me.grilla.Rows.Count - 2

                    For x As Integer = 0 To grilla.ColumnCount - 1

                        If grilla.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla.CurrentCell = grilla.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue
                            grilla.CurrentRow.DefaultCellStyle.ForeColor = Color.Yellow

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TP2_Click(sender As Object, e As EventArgs) Handles TP2.Click

    End Sub

    Private Sub TP1_Click(sender As Object, e As EventArgs) Handles TP1.Click


    End Sub

    Private Sub Tab1_MouseClick(sender As Object, e As MouseEventArgs) Handles Tab1.MouseClick
        'Try


        If Me.Tab1.SelectedIndex = 1 Then
            lbl_reg.Text = ""
            ch_stop_timer.Checked = True

            ' MsgBox("este es el tab2")
            '//////////////////////////////
            '///// PESTAÑA DESPACHOS Registrados
            '//////////////////////////////

            'cajas consulta despachos
            txt_bus_fact.Visible = False
            txt_bus_oc.Visible = False

            txt_bus_fact_desp.Visible = True
            txt_bus_oc_desp.Visible = True

            Dim com4 As New MySqlCommand
            'grilla.Columns.Clear()

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

            com4.Connection = conexion
            com4.CommandText = "SELECT nrodp, fe_creacion, rutclie, nomclie, comuna, nfactura, monto_fact, fe_docto,  noc, fe_desp, transporte, patente, nflete, nrobultos, gramos, h_salida, obs_despacho, vendedor, chofer, despachador From ENTREGAS_DP Where year(fe_docto) = '" & miano & "' order by nrodp DESC"
                ' com4.CommandText = "SELECT  Substring(VENTA.tipocon,8,10)tipocon, VENTA.fechacon, VENTA.rutcon, Cliente.nomclie, VENTA.vencon, VENTA.netocon, VENTA.ordcon FROM VENTA INNER JOIN CLIENTE ON VENTA.rutcon = CLIENTE.rutclie WHERE VENTA.tipocon LIKE '%FEL'  AND year(VENTA.fechacon) = '" & miano & "' GROUP BY VENTA.tipocon, VENTA.fechacon, VENTA.rutcon, CLIENTE.nomclie, VENTA.vencon, VENTA.netocon, VENTA.ordcon ORDER BY fechacon DESC"

                Dim dt As System.Data.DataTable = New System.Data.DataTable
            Dim da As MySqlDataAdapter = New MySqlDataAdapter(com4)
            da.Fill(dt)
            grilla2.DataSource = dt

            conexion.Close()
            da.Dispose()
            com4.Dispose()


            Call Formato_grilla2()
            Call Saca_Contenido_factura(grilla2)

            For i As Integer = 0 To grilla2.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next

        Else
            '//////////////////////////////
            '///// PESTAÑA Facturas para Registrar
            '//////////////////////////////
            ' MsgBox("este es el tab1")
            ch_stop_timer.Checked = True
            'cajas consulta despachos
            txt_bus_fact.Visible = True
            txt_bus_oc.Visible = True

            txt_bus_fact_desp.Visible = False
            txt_bus_oc_desp.Visible = False

            For i As Integer = 0 To grilla.Rows.Count() - 1 Step +1

                i = +i
                lbl_reg.Text = i

            Next

        End If




        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub txt_obs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_obs.KeyPress

        If e.KeyChar = Convert.ToChar(13) Then

            If cmd_modificar.Enabled = False Then

                cmd_guardar.Enabled = True
                cmd_guardar.Select()
            Else
                cmd_guardar.Enabled = False
            End If



        End If
    End Sub

    Private Sub IngreseNroFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngreseNroFacturaToolStripMenuItem.Click

        Dim com5 As New MySqlCommand
        Dim rs4 As MySqlDataReader
        Dim rs5 As MySqlDataReader
        Dim contenido2 As String
        Dim resul As String = ""

        ch_stop_timer.Checked = True

        Dim valret As String

        valret = InputBox("Ingrese Nro de Factura", "Buscar Despacho", "0")

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


        valret = "FEL0000" + valret 'le agrega el 0 para igualar el campo
        If conexion.State = 1 Then conexion.Close()
        'la abre 
        conexion.Open()

        'entrega el valor a la variable para buscar

        sql = "Select * From entregas_dp Where nfactura = '" & LTrim(RTrim(valret)) & "'"
        com5 = New MySqlCommand(sql, conexion)

        rs4 = com5.ExecuteReader()
        If rs4.HasRows = True Then
            rs4.Read()


            lbl_idbd.Text = CStr(rs4("id"))
            lbl_rut.Text = CStr(rs4("rutclie"))
            lbl_nombre.Text = CStr(rs4("nomclie"))


            contenido2 = CStr(rs4("nfactura")).ToString
            If Strings.Left(contenido2, 3) = "FEL" Then
                resul = Mid(contenido2, 7, 10)
            End If
            lbl_nro_fact.Text = resul.ToString


            lbl_mto_fact.Text = CStr(rs4("monto_fact"))
            lbl_fe_fact.Text = CStr(rs4("fe_docto"))
            lbl_vendedor.Text = CStr(rs4("vendedor"))
            txt_dirclie.Text = CStr(rs4("dirdesp"))
            lbl_noc.Text = CStr(rs4("noc"))
            lbl_nrodp.Text = CStr(rs4("nrodp"))

            txt_cedible.Text = CStr(rs4("nro_rece"))
            cbo_tp.Text = CStr(rs4("transporte"))
            txt_nroflete.Text = CStr(rs4("nflete"))
            txt_nrobulto.Text = CStr(rs4("nrobultos"))
            txt_peso.Text = CStr(rs4("gramos"))
            cbo_ciudad.Text = CStr(rs4("comuna"))
            cbo_chofer.Text = CStr(rs4("chofer"))
            lbl_patente.Text = CStr(rs4("patente"))
            cbo_acomodador.Text = CStr(rs4("despachador"))
            msk_fe_desp.Text = CStr(rs4("fe_desp"))
            txt_obs.Text = CStr(rs4("obs_despacho"))
            cbo_ampm.Text = CStr(rs4("h_salida"))

            rs4.Close()
            conexion.Close()


            txt_dirclie.Enabled = False
            txt_cedible.Enabled = False
            cbo_tp.Enabled = False
            cbo_ciudad.Enabled = False
            cbo_chofer.Enabled = False
            cbo_acomodador.Enabled = False
            txt_nrobulto.Enabled = False
            txt_nroflete.Enabled = False
            txt_peso.Enabled = False
            msk_fe_desp.Enabled = False
            txt_obs.Enabled = False
            cbo_ampm.Enabled = False
            cbo_medio_tp.Enabled = False
            cmd_modificar.Enabled = True
            cmd_guardar.Enabled = False



        Else
            MsgBox("El Nro de Factura no fue encontrado, verifique!", MsgBoxStyle.Critical, "Buscar Factura Registrada")
            Exit Sub

        End If

        'BUSCA MEDIO TP
        If conexion.State = 1 Then conexion.Close()
        conexion.Open()
        sql = "Select tipo from medios_dp where patente = '" & lbl_patente.Text & "'"
        com5 = New MySqlCommand(sql, conexion)

        rs5 = com5.ExecuteReader()

        If rs4.HasRows = True Then
            rs5.Read()
            cbo_medio_tp.Text = CStr(rs5("tipo"))

            rs5.Dispose()
            conexion.Close()

        Else

        End If


    End Sub




    Private Sub cbo_ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_ciudad.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If cbo_ciudad.Text <> "" Then
                cbo_chofer.Select()
            Else
                cbo_ciudad.Select()

            End If

        End If
    End Sub

    Private Sub cbo_chofer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_chofer.KeyPress


        If e.KeyChar = Convert.ToChar(13) Then

                cbo_medio_tp.Enabled = True
                cbo_medio_tp.Select()




        End If
    End Sub

    Private Sub cbo_medio_tp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_medio_tp.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If cbo_medio_tp.Text <> "" Then
                cbo_acomodador.Select()
            Else
                cbo_medio_tp.Select()

            End If

        End If
    End Sub

    Private Sub cbo_acomodador_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_acomodador.SelectedValueChanged
        If cbo_acomodador.Text <> "" Then
            msk_fe_desp.SelectAll()
            msk_fe_desp.Select()
        Else
            cbo_acomodador.Select()

        End If
    End Sub

    Private Sub cbo_acomodador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_acomodador.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            If cbo_acomodador.Text <> "" Then
                msk_fe_desp.SelectAll()
                msk_fe_desp.Select()
            Else
                cbo_acomodador.Select()

            End If
        End If

    End Sub

    Private Sub msk_fe_desp_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles msk_fe_desp.MaskInputRejected

    End Sub

    Private Sub msk_fe_desp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles msk_fe_desp.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If msk_fe_desp.Text <> "    -  -" Then
                If cbo_ampm.Enabled = False Then
                    txt_obs.Select()
                Else
                    cbo_ampm.Select()
                End If
            Else
                msk_fe_desp.Select()
            End If


        End If
    End Sub



    Private Sub txt_bus_fact_desp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_fact_desp.KeyPress
        Dim target_name As String = ""
        Try
            ch_stop_timer.Checked = True
            'BUSCA LA FACTURA

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_fact_desp.Text))
                If Len(target_name) = 0 Then Exit Sub

                For r As Integer = 0 To Me.grilla2.Rows.Count - 2

                    For x As Integer = 0 To grilla2.ColumnCount - 1

                        If grilla2.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla2.CurrentCell = grilla2.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla2.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue
                            grilla2.CurrentRow.DefaultCellStyle.ForeColor = Color.Yellow

                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub txt_bus_oc_desp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bus_oc_desp.KeyPress
        Dim target_name As String = ""
        Try
            ch_stop_timer.Checked = True
            'BUSCA OC

            If e.KeyChar = Convert.ToChar(13) Then
                target_name = LTrim(RTrim(txt_bus_oc_desp.Text))
                If Len(target_name) = 0 Then Exit Sub
                target_name = UCase(target_name)
                txt_bus_oc_desp.CharacterCasing = CharacterCasing.Upper


                For r As Integer = 0 To Me.grilla2.Rows.Count - 2

                    For x As Integer = 0 To grilla2.ColumnCount - 1

                        If grilla2.Rows(r).Cells(x).Value.ToString.Contains(target_name) Then

                            Me.grilla2.CurrentCell = grilla2.Rows(r).Cells(x)
                            'grilla.CurrentCell.Style.BackColor = Color.Blue
                            'grilla.CurrentCell.Style.ForeColor = Color.Yellow
                            grilla2.CurrentRow.DefaultCellStyle.BackColor = Color.DarkBlue
                            grilla2.CurrentRow.DefaultCellStyle.ForeColor = Color.Yellow
                            Exit Sub

                        End If

                    Next x

                Next r

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click
        Dim valret2 As String

        valret2 = MsgBox("¿Desea modificar parte de los campos ya registrados?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Editar valores")

        If valret2 = 6 Then

            txt_dirclie.Enabled = True
            txt_cedible.Enabled = True
            cbo_tp.Enabled = True
            cbo_ciudad.Enabled = True
            cbo_chofer.Enabled = True
            cbo_acomodador.Enabled = True
            txt_nrobulto.Enabled = True
            txt_nroflete.Enabled = True
            txt_peso.Enabled = True
            msk_fe_desp.Enabled = True
            txt_obs.Enabled = True
            cbo_ampm.Enabled = True
            cbo_medio_tp.Enabled = True
            cmd_modificar.Visible = False
            cmd_modifica2.Visible = True
            cmd_modifica2.Enabled = True
            cmd_guardar.Enabled = False

        Else
            txt_dirclie.Enabled = False
            txt_cedible.Enabled = False
            cbo_tp.Enabled = False
            cbo_ciudad.Enabled = False
            cbo_chofer.Enabled = False
            cbo_acomodador.Enabled = False
            txt_nrobulto.Enabled = False
            txt_nroflete.Enabled = False
            txt_peso.Enabled = False
            msk_fe_desp.Enabled = False
            txt_obs.Enabled = False
            cbo_ampm.Enabled = False
            cbo_medio_tp.Enabled = False
            cmd_modificar.Visible = True
            cmd_modifica2.Visible = False
            cmd_guardar.Enabled = False

        End If

    End Sub

    Private Sub cmd_modifica2_Click(sender As Object, e As EventArgs) Handles cmd_modifica2.Click
        Dim cmd2 As MySqlCommand = New MySqlCommand
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

            cmd2 = New MySqlCommand("Update entregas_dp Set dirdesp = '" & txt_dirclie.Text & "',  nro_rece= '" & txt_cedible.Text & "', transporte ='" & cbo_tp.Text & "', nflete ='" & txt_nroflete.Text & "', nrobultos ='" & txt_nrobulto.Text & "', gramos ='" & txt_peso.Text & "', comuna ='" & cbo_ciudad.Text & "', chofer ='" & cbo_chofer.Text & "', patente = '" & lbl_patente.Text & "', despachador = '" & cbo_acomodador.Text & "', fe_desp = '" & msk_fe_desp.Text & "'  WHERE id = '" & lbl_idbd.Text & "'", conexion)

            cmd2.ExecuteNonQuery()
            conexion.Close()
            cmd2.Dispose()

            MsgBox("Modificación realizada.", MsgBoxStyle.Information)

            txt_dirclie.Enabled = True
            txt_cedible.Enabled = True
            cbo_tp.Enabled = True
            cbo_ciudad.Enabled = True
            cbo_chofer.Enabled = True
            cbo_acomodador.Enabled = True
            txt_nrobulto.Enabled = True
            txt_nroflete.Enabled = True
            txt_peso.Enabled = True
            msk_fe_desp.Enabled = True
            txt_obs.Enabled = True
            cbo_ampm.Enabled = True
            cbo_medio_tp.Enabled = True
            cmd_modificar.Visible = False
            cmd_modificar.Visible = True
            cmd_modifica2.Enabled = True
            cmd_guardar.Enabled = False

            cmd2.Dispose()
            conexion.Close()
            cmd_limpíar.PerformClick()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub


    Private Sub txt_cedible_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedible.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then

            If txt_cedible.Text <> "" Then
                txt_nroflete.Select()
            Else
                txt_cedible.Select()

            End If

        End If
    End Sub

    Private Sub txt_obs_TextChanged(sender As Object, e As EventArgs) Handles txt_obs.TextChanged

    End Sub

    Private Sub cbo_ampm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbo_ampm.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            'If cbo_ampm.Text <> "" Then
            '    If cmd_modificar.Enabled = False Then
            '        cmd_guardar.Enabled = True
            '    Else
            '        cmd_guardar.Enabled = False
            '    End If

            'End If
            txt_obs.Select()


        End If

    End Sub

    Private Sub cbo_ampm_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbo_ampm.SelectedValueChanged
        'If cbo_ampm.Text <> "" Then
        '    If cmd_modificar.Enabled = False Then
        '        cmd_guardar.Enabled = True
        '    Else
        '        cmd_guardar.Enabled = False
        '    End If

        'End If
        txt_obs.Select()
    End Sub

    Private Sub cbo_ampm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_ampm.SelectedIndexChanged
        'If cbo_ampm.Text <> "" Then
        '    If cmd_modificar.Enabled = False Then
        '        cmd_guardar.Enabled = True
        '    Else
        '        cmd_guardar.Enabled = False
        '    End If

        'End If
        txt_obs.Select()
    End Sub

    Private Sub cbo_ampm_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_ampm.SelectionChangeCommitted
        'If cbo_ampm.Text <> "" Then
        '    If cmd_modificar.Enabled = False Then
        '        cmd_guardar.Enabled = True
        '    Else
        '        cmd_guardar.Enabled = False
        '    End If

        'End If
        txt_obs.Select()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SendKeys.Send("{ENTER}")
        Timer2.Enabled = False
    End Sub
End Class