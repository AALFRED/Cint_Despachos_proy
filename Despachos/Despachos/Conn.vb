Imports MySql.Data
Imports MySql.Data.MySqlClient
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
Imports Despachos


Module Conn

    'variables de conexion
    Public miserver As String
    Public myid As String
    Public mipass As String
    Public mipuerto As Integer
    Public mibd As String
    Public UserAdmin As String
    Public laemp As String
    Public tipobase As String

    'variable para el año
    Public miyear As Integer = Year(Date.Now).ToString


    'para controlar que empresa esta operando
    Public emp_entrada As Integer '1 Cintegral 2 Global

    Public conexion As New MySqlConnection

    'conectar
    Dim v_userad As String 'useradmin
    Public v_server As String 'ip servidor
    Dim v_port As String 'puerto
    Public v_database As String 'basede datos
    Dim v_userbd As String 'usuario de bd
    Private v_pass As String 'pass
    Public v_emp As String  'empresa
    Public v_sqlserv As String 'tipo de base datos

    'otras
    Public sql As String
    Public ds As New DataSet

    Public dr As MySql.Data.MySqlClient.MySqlDataReader
    Public da As MySql.Data.MySqlClient.MySqlDataAdapter
    Public dt As DataTable

    Declare Function GetAsyncKeyState Lib "user32" (ByVal vKey As Integer) As Short
    Public Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer


    Sub ConectaCint()
        Try

            '//////////////////////
            'CARGA DE PARAMETROS
            Const fichero As String = "C:\Proyectos Vb2017\DESPACHOS\paramcint.dat"
            Dim texto As String = ""



            Dim sr As New System.IO.StreamReader(fichero)
            texto = sr.ReadToEnd()
            sr.Close()
            ' We need to read into this List.
            Dim list As New List(Of String)

            ' Open file.txt with the Using statement.
            Using r As StreamReader = New StreamReader(fichero)
                ' Store contents in this String.
                Dim line As String

                ' Read first line.
                line = r.ReadLine

                ' Loop over each line in file, While list is Not Nothing.
                Do While (Not line Is Nothing)
                    ' Add this line to list.
                    list.Add(line)

                    'MsgBox(line.ToString)
                    'MsgBox(Mid(line.ToString, 1, 10))


                    If Mid(line.ToString, 1, 10) = "USERADMIN=" Then
                        v_userad = Mid(Trim(line), 11, 18) 'el usuario admin
                        'MsgBox(v_userad.ToString)
                        UserAdmin = v_userad.ToString

                    Else
                        If Mid(line.ToString, 1, 7) = "Server=" Then
                            v_server = Mid(Trim(line), 8, 20)  'la ip del server
                            'MsgBox(v_server.ToString)
                            miserver = v_server.ToString 'asigna el valor a la v de conexion
                        Else
                            If Mid(line.ToString, 1, 5) = "Port=" Then
                                v_port = Mid(Trim(line), 6, 9)  'el port
                                'MsgBox(v_port.ToString)
                                mipuerto = v_port.ToString
                            Else

                                If Mid(line.ToString, 1, 9) = "Database=" Then
                                    v_database = Mid(Trim(line), 10, 22) 'base de datos
                                    'MsgBox(v_database.ToString)
                                    mibd = v_database.ToString

                                Else
                                    If Mid(line.ToString, 1, 5) = "User=" Then
                                        v_userbd = Mid(Trim(line), 6, 14) 'usuario
                                        'MsgBox(v_userbd.ToString)
                                        myid = v_userbd.ToString 'asigna el valor a la v de conexion
                                    Else

                                        If Mid(line.ToString, 1, 9) = "password=" Then
                                            v_pass = Mid(Trim(line), 10, 18) 'password
                                            'MsgBox(v_pass.ToString)
                                            mipass = v_pass.ToString
                                        Else
                                            If Mid(line.ToString, 1, 8) = "EMPRESA=" Then
                                                v_emp = Mid(Trim(line), 9, 17) 'password
                                                'MsgBox(v_emp.ToString)
                                                laemp = v_emp.ToString
                                            Else

                                                If Mid(line.ToString, 1, 10) = "SQLServer=" Then
                                                    v_sqlserv = Mid(Trim(line), 11, 27) 'password
                                                    'MsgBox(v_sqlserv.ToString)
                                                    tipobase = v_sqlserv.ToString
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    ' Read in the next line.
                    line = r.ReadLine
                Loop
            End Using


            If conexion.State = 1 Then conexion.Close()
            conexion.ConnectionString = "server=" & miserver & ";Port=" & mipuerto & ";user id=" & myid & ";database=" & mibd & ";password=" & mipass & "; convert zero datetime=True"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Sub ConectaCint2()
        'CONECTA A CINTEGRAL AÑO ANTERIOR
        Dim miserver2 As String = "192.168.1.61"
        Dim myid2 As String
        Dim mipass2 As String
        Dim mipuerto2 As Integer

        Call elano()
        miano = miano - 1
        ' miyear = CInt(miyear - 1)
        myid2 = "cintegral"
        mipass2 = "Xtreme749"
        mibd = "cintegral" & miano
        mipuerto2 = "3306"
        Try
            If conexion.State = 1 Then conexion.Close()

            conexion.ConnectionString = "server=" & miserver2 & ";Port=" & mipuerto2 & ";user id=" & myid2 & "; database=" & mibd & ";password=" & mipass2 & "; convert zero datetime=True"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


    Sub ConectaGlo()

        'CONECTA A GLOBAL AÑO VIGENTE
        Try

            '//////////////////////
            'CARGA DE PARAMETROS
            Const fichero As String = "C:\Proyectos Vb2017\DESPACHOS\paramglo.dat"
            Dim texto As String = ""



            Dim sr As New System.IO.StreamReader(fichero)
            texto = sr.ReadToEnd()
            sr.Close()
            ' We need to read into this List.
            Dim list As New List(Of String)

            ' Open file.txt with the Using statement.
            Using r As StreamReader = New StreamReader(fichero)
                ' Store contents in this String.
                Dim line As String

                ' Read first line.
                line = r.ReadLine

                ' Loop over each line in file, While list is Not Nothing.
                Do While (Not line Is Nothing)
                    ' Add this line to list.
                    list.Add(line)

                    'MsgBox(line.ToString)
                    'MsgBox(Mid(line.ToString, 1, 10))


                    If Mid(line.ToString, 1, 10) = "USERADMIN=" Then
                        v_userad = Mid(Trim(line), 11, 18) 'el usuario admin
                        'MsgBox(v_userad.ToString)
                        UserAdmin = v_userad.ToString

                    Else
                        If Mid(line.ToString, 1, 7) = "Server=" Then
                            v_server = Mid(Trim(line), 8, 20)  'la ip del server
                            'MsgBox(v_server.ToString)
                            miserver = v_server.ToString 'asigna el valor a la v de conexion
                        Else
                            If Mid(line.ToString, 1, 5) = "Port=" Then
                                v_port = Mid(Trim(line), 6, 9)  'el port
                                'MsgBox(v_port.ToString)
                                mipuerto = v_port.ToString
                            Else

                                If Mid(line.ToString, 1, 9) = "Database=" Then
                                    v_database = Mid(Trim(line), 10, 22) 'base de datos
                                    'MsgBox(v_database.ToString)
                                    mibd = v_database.ToString

                                Else
                                    If Mid(line.ToString, 1, 5) = "User=" Then
                                        v_userbd = Mid(Trim(line), 6, 14) 'usuario
                                        'MsgBox(v_userbd.ToString)
                                        myid = v_userbd.ToString 'asigna el valor a la v de conexion
                                    Else

                                        If Mid(line.ToString, 1, 9) = "password=" Then
                                            v_pass = Mid(Trim(line), 10, 18) 'password
                                            'MsgBox(v_pass.ToString)
                                            mipass = v_pass.ToString
                                        Else
                                            If Mid(line.ToString, 1, 8) = "EMPRESA=" Then
                                                v_emp = Mid(Trim(line), 9, 17) 'password
                                                'MsgBox(v_emp.ToString)
                                                laemp = v_emp.ToString
                                            Else

                                                If Mid(line.ToString, 1, 10) = "SQLServer=" Then
                                                    v_sqlserv = Mid(Trim(line), 11, 27) 'password
                                                    'MsgBox(v_sqlserv.ToString)
                                                    tipobase = v_sqlserv.ToString
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                    ' Read in the next line.
                    line = r.ReadLine
                Loop
            End Using


            If conexion.State = 1 Then conexion.Close()
            conexion.ConnectionString = "server=" & miserver & ";Port=" & mipuerto & ";user id=" & myid & ";database=" & mibd & ";password=" & mipass & "; convert zero datetime=True"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Sub ConectaGlo2()
        'CONECTA A GLOBAL AÑO ANTERIOR
        Dim miserver2 As String = "192.168.1.61"
        Dim myid2 As String
        Dim mipass2 As String
        Dim mipuerto2 As Integer

        Call elano()
        miano = miano - 1
        ' miyear = CInt(miyear - 1)
        myid2 = "cintegral"
        mipass2 = "Xtreme749"
        mibd = "global" & miano
        mipuerto2 = "3306"
        Try


            conexion.ConnectionString = "server=" & miserver2 & ";Port=" & mipuerto2 & ";user id=" & myid2 & ";database=" & mibd & ";password=" & mipass2 & "; convert zero datetime=True"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


End Module
