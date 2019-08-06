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


Public Class frm_Menu

    Dim el_nivel As String


    Private Sub frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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


        Call elano()
        Me.Text = "Menú Principal/ Sistema de Despachos *** AÑO " & miano & " *** - EMPRESA: " & v_emp & " - Conectado como : " & retenUser

        lbl_version.Text = "VERSIÓN " & Application.ProductVersion.ToString & " - " & Application.CompanyName.ToString



        Tool1.Text = " // Despachos - " & DateTime.Now.ToString((" dd-MM-yyyy")) '& DateTime.Now
        Tool2.Text = "// Ip del Servidor " & miserver.ToString
        Tool3.Text = "// Base de Datos: " & mibd.ToString
        Tool4.Text = "// TIPO SERVIDOR: " & tipobase.ToString

        el_nivel = frm_Login.level

        Select Case el_nivel
            Case 0
                'PERFIL CONSULTAS
                '//MENU INGRESOS

                mnu_ing_Fact.Enabled = False
                mnu_ing_Guias.Enabled = False 'Menu
                mnu_ing_guia_Clie.Enabled = False
                mnu_ing_guia_Sin_Fact.Enabled = False
                mnu_ing_Bol.Enabled = False


                '//MENU REINGRESOS 
                mnu_reingresos.Enabled = False
                'mnu_reing_guias.Enabled = False
                'mnu_reing_guia_Clientes.Enabled = False
                'mnu_reing_guia_Sin_Fact.Enabled = False
                'mnu_reing_Bol_clie.Enabled = False

                '//MENU REPORTES
                mnu_rep_Est_Fact_Desp.Enabled = False
                mnu_rep_Est_Guias_Desp.Enabled = False
                mnu_rep_Est_Bol_desp.Enabled = False
                mnu_rep_Fact_NoIngresadas.Enabled = False
                mnu_rep_Estad_DespISO.Enabled = False

                '//LOGISTICA

                mnu_Chofer_Bultos_Gramos.Enabled = False
                mnu_Control_Cobro.Enabled = False

                '//MANTENEDORES
                mnu_Acomodadores.Enabled = False
                mnu_Ciudades.Enabled = False
                mnu_Choferes.Enabled = False
                mnu_Moviles.Enabled = False
                mnu_Transportes.Enabled = False
                mnu_TarifasTranscom.Enabled = False
                mnu_Usuarios.Enabled = False
                mnu_EliminarRegistros.Enabled = False

                cmd_cons_despacho.Enabled = True
                cmd_cons_serie.Enabled = True

            Case 1
                'PERFIL BODEGA
                '//MENU INGRESOS

                mnu_ing_Fact.Enabled = False
                mnu_ing_Guias.Enabled = False 'Menu
                mnu_ing_guia_Clie.Enabled = False
                mnu_ing_guia_Sin_Fact.Enabled = False
                mnu_ing_Bol.Enabled = False


                '//MENU REINGRESOS 
                mnu_reingresos.Enabled = False
                'mnu_reing_guias.Enabled = False
                'mnu_reing_guia_Clientes.Enabled = False
                'mnu_reing_guia_Sin_Fact.Enabled = False
                'mnu_reing_Bol_clie.Enabled = False

                '//MENU REPORTES
                mnu_rep_Est_Fact_Desp.Enabled = False
                mnu_rep_Est_Guias_Desp.Enabled = False
                mnu_rep_Est_Bol_desp.Enabled = False
                mnu_rep_Fact_NoIngresadas.Enabled = True
                mnu_rep_Estad_DespISO.Enabled = False

                '//LOGISTICA

                mnu_Chofer_Bultos_Gramos.Enabled = False
                mnu_Control_Cobro.Enabled = False

                '//MANTENEDORES
                mnu_Acomodadores.Enabled = False
                mnu_Ciudades.Enabled = False
                mnu_Choferes.Enabled = False
                mnu_Moviles.Enabled = False
                mnu_Transportes.Enabled = False
                mnu_TarifasTranscom.Enabled = False
                mnu_Usuarios.Enabled = False
                mnu_EliminarRegistros.Enabled = False

                cmd_cons_despacho.Enabled = False
                cmd_cons_serie.Enabled = False

            Case 2
                'PERFIL LOGISTICA
                '//MENU INGRESOS

                mnu_ing_Fact.Enabled = True
                mnu_ing_Guias.Enabled = True 'Menu
                mnu_ing_guia_Clie.Enabled = True
                mnu_ing_guia_Sin_Fact.Enabled = True
                mnu_ing_Bol.Enabled = True


                '//MENU REINGRESOS 
                mnu_reingresos.Enabled = True
                'mnu_reing_guias.Enabled = True
                'mnu_reing_guia_Clientes.Enabled = True
                'mnu_reing_guia_Sin_Fact.Enabled = True
                'mnu_reing_Bol_clie.Enabled = True

                '//MENU REPORTES
                mnu_rep_Est_Fact_Desp.Enabled = True
                mnu_rep_Est_Guias_Desp.Enabled = True
                mnu_rep_Est_Bol_desp.Enabled = True
                mnu_rep_Fact_NoIngresadas.Enabled = True
                mnu_rep_Estad_DespISO.Enabled = True

                '//LOGISTICA

                mnu_Chofer_Bultos_Gramos.Enabled = False
                mnu_Control_Cobro.Enabled = False

                '//MANTENEDORES
                mnu_Acomodadores.Enabled = False
                mnu_Ciudades.Enabled = False
                mnu_Choferes.Enabled = False
                mnu_Moviles.Enabled = False
                mnu_Transportes.Enabled = False
                mnu_TarifasTranscom.Enabled = False
                mnu_Usuarios.Enabled = False
                mnu_EliminarRegistros.Enabled = False

                cmd_cons_despacho.Enabled = True
                cmd_cons_serie.Enabled = True

            Case 3
                'PERFIL ADMINISTRADOR
                '//MENU INGRESOS

                mnu_ing_Fact.Enabled = True
                mnu_ing_Guias.Enabled = True 'Menu
                mnu_ing_guia_Clie.Enabled = True
                mnu_ing_guia_Sin_Fact.Enabled = True
                mnu_ing_Bol.Enabled = True


                '//MENU REINGRESOS 
                mnu_reingresos.Enabled = True
                'mnu_reing_guias.Enabled = True
                'mnu_reing_guia_Clientes.Enabled = True
                'mnu_reing_guia_Sin_Fact.Enabled = True
                'mnu_reing_Bol_clie.Enabled = True

                '//MENU REPORTES
                mnu_rep_Est_Fact_Desp.Enabled = True
                mnu_rep_Est_Guias_Desp.Enabled = True
                mnu_rep_Est_Bol_desp.Enabled = True
                mnu_rep_Fact_NoIngresadas.Enabled = True
                mnu_rep_Estad_DespISO.Enabled = True

                '//LOGISTICA

                mnu_Chofer_Bultos_Gramos.Enabled = True
                mnu_Control_Cobro.Enabled = True

                '//MANTENEDORES
                mnu_Acomodadores.Enabled = True
                mnu_Ciudades.Enabled = True
                mnu_Choferes.Enabled = True
                mnu_Moviles.Enabled = True
                mnu_Transportes.Enabled = True
                mnu_TarifasTranscom.Enabled = True
                mnu_Usuarios.Enabled = True
                mnu_EliminarRegistros.Enabled = False

                cmd_cons_despacho.Enabled = True
                cmd_cons_serie.Enabled = True

            Case 4
                'PERFIL MASTER
                '//MENU INGRESOS

                mnu_ing_Fact.Enabled = True
                mnu_ing_Guias.Enabled = True 'Menu
                mnu_ing_guia_Clie.Enabled = True
                mnu_ing_guia_Sin_Fact.Enabled = True
                mnu_ing_Bol.Enabled = True


                '//MENU REINGRESOS 
                mnu_reingresos.Enabled = True
                'mnu_reing_guias.Enabled = True
                'mnu_reing_guia_Clientes.Enabled = True
                'mnu_reing_guia_Sin_Fact.Enabled = True
                'mnu_reing_Bol_clie.Enabled = True

                '//MENU REPORTES
                mnu_rep_Est_Fact_Desp.Enabled = True
                mnu_rep_Est_Guias_Desp.Enabled = True
                mnu_rep_Est_Bol_desp.Enabled = True
                mnu_rep_Fact_NoIngresadas.Enabled = True
                mnu_rep_Estad_DespISO.Enabled = True

                '//LOGISTICA

                mnu_Chofer_Bultos_Gramos.Enabled = True
                mnu_Control_Cobro.Enabled = True

                '//MANTENEDORES
                mnu_Acomodadores.Enabled = True
                mnu_Ciudades.Enabled = True
                mnu_Choferes.Enabled = True
                mnu_Moviles.Enabled = True
                mnu_Transportes.Enabled = True
                mnu_TarifasTranscom.Enabled = True
                mnu_Usuarios.Enabled = True
                mnu_EliminarRegistros.Enabled = True

                cmd_cons_despacho.Enabled = True
                cmd_cons_serie.Enabled = True

        End Select


        lbl_valor_emp_entrada.Text = emp_entrada




    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        If conexion.State = 1 Then conexion.Close()

        End
    End Sub

    Private Sub frm_Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub mnu_ing_Fact_Click(sender As Object, e As EventArgs) Handles mnu_ing_Fact.Click
        Me.Hide()
        frm_ing_fel.Show()

    End Sub

    Private Sub mnu_reingresos_Click(sender As Object, e As EventArgs) Handles mnu_reingresos.Click
        Me.Hide()
        frm_reingresos.Show()

    End Sub

    Private Sub cmd_cons_despacho_Click(sender As Object, e As EventArgs) Handles cmd_cons_despacho.Click
        Me.Hide()
        frm_cons_desp_main.Show()
    End Sub

    Private Sub mnu_ing_Bol_Click(sender As Object, e As EventArgs) Handles mnu_ing_Bol.Click
        Me.Hide()
        frm_ing_bol.Show()
    End Sub

    Private Sub mnu_ing_guia_Clie_Click(sender As Object, e As EventArgs) Handles mnu_ing_guia_Clie.Click
        Me.Hide()
        frm_ing_guia_clte.Show()

    End Sub

    Private Sub mnu_ing_guia_Sin_Fact_Click(sender As Object, e As EventArgs) Handles mnu_ing_guia_Sin_Fact.Click
        Me.Hide()
        frm_ing_guia_sinfact.Show()

    End Sub

    Private Sub DeTraspasosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeTraspasosToolStripMenuItem.Click
        Me.Hide()
        frm_ing_guia_trasp.Show()

    End Sub

    Private Sub mnu_rep_Est_Fact_Desp_Click(sender As Object, e As EventArgs) Handles mnu_rep_Est_Fact_Desp.Click
        Me.Hide()
        frm_Rep_Est_Fact.Show()

    End Sub

    Private Sub mnu_rep_Est_Guias_Desp_Click(sender As Object, e As EventArgs) Handles mnu_rep_Est_Guias_Desp.Click
        Me.Hide()
        frm_Rep_Est_guias.Show()
    End Sub

    Private Sub mnu_rep_Est_Bol_desp_Click(sender As Object, e As EventArgs) Handles mnu_rep_Est_Bol_desp.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_rep_Fact_NoIngresadas_Click(sender As Object, e As EventArgs) Handles mnu_rep_Fact_NoIngresadas.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_rep_Estad_DespISO_Click(sender As Object, e As EventArgs) Handles mnu_rep_Estad_DespISO.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_Chofer_Bultos_Gramos_Click(sender As Object, e As EventArgs) Handles mnu_Chofer_Bultos_Gramos.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_Control_Cobro_Click(sender As Object, e As EventArgs) Handles mnu_Control_Cobro.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub cmd_cons_serie_Click(sender As Object, e As EventArgs) Handles cmd_cons_serie.Click
        MsgBox("Opción No Disponible aún", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_Acomodadores_Click(sender As Object, e As EventArgs) Handles mnu_Acomodadores.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_Ciudades_Click(sender As Object, e As EventArgs) Handles mnu_Ciudades.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_Choferes_Click(sender As Object, e As EventArgs) Handles mnu_Choferes.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_Usuarios_Click(sender As Object, e As EventArgs) Handles mnu_Usuarios.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_EliminarRegistros_Click(sender As Object, e As EventArgs) Handles mnu_EliminarRegistros.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_Moviles_Click(sender As Object, e As EventArgs) Handles mnu_Moviles.Click
        MsgBox("Reporte No Disponible", MsgBoxStyle.Exclamation)
    End Sub

    Private Sub mnu_ExtracDatosCobroTp_Click(sender As Object, e As EventArgs) Handles mnu_ExtracDatosCobroTp.Click
        Me.Hide()
        frm_Extract_datos_cobro.Show()

    End Sub
End Class
