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
Imports MySql.Data
Imports MySql.Data.MySqlClient


Module Module1


    Public llave As Integer 'para identificar cuando se abren ventanas de submenu o de menu principal
    Public miano As Integer
    Public cadenadevuelta As String
    Public retenUser As String ' retiene el valor "Usuario" que se conecta
    Public retenPass As String ' retiene el valor "password" que se conecta

    Public nombre As String 'frm_selec_ejec
    Public paso As String 'frm_selec_ejec
    Public codigo As Integer 'frm_selec_ejec

    Public Sub elano()
        'saca el año a la fecha
        miano = Year(Date.Now).ToString

    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo letra
    Public Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If

    End Sub

    'Funcion para que solo permite el ingreso de caracteres tipo numerico
    Public Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub

    Public Function QuitarCaracteres(cadena As String, Optional chars As String = ".-,'") As String
        Dim i As Integer
        Dim nCadena As String
        'Try
        nCadena = cadena
        For i = 1 To Len(chars)
            nCadena = Replace(nCadena, Mid(chars, i, 1), "")
        Next i
        QuitarCaracteres = nCadena
        cadenadevuelta = nCadena


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally

        'End Try
        Return 0
    End Function



    Sub sub_limpiar_campos(ByVal c1 As Control)
        'Limpia todos los controles dentro del control principal (c1)
        'aunque esten dentro de otros controles
        For Each c As Control In c1.Controls
            If TypeOf c Is TextBox Then
                c.Text = "" ' eliminar el texto 
            Else
                sub_limpiar_campos(c)
            End If
            If TypeOf c Is ComboBox Then
                c.Text = "" ' eliminar el texto 
            Else
                sub_limpiar_campos(c)
            End If
            If TypeOf c Is DateTimePicker Then
                c.Text = Date.Today ' Pone la fecha actual 
            Else
                sub_limpiar_campos(c)
            End If
            If (TypeOf (c) Is CheckBox) Then
                CType(c, CheckBox).Checked = False 'Quita el check
            Else
                sub_limpiar_campos(c)
            End If
            If (TypeOf (c) Is RadioButton) Then
                CType(c, RadioButton).Checked = False 'Quita el check
            Else
                sub_limpiar_campos(c)
            End If
        Next
    End Sub


End Module
