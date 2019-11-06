Imports System.Data.SqlClient
Imports System.IO

Module Module1
    Public Cnn As New SqlConnection
    Public Trans As SqlClient.SqlTransaction
    Public objCmd As SqlCommand
    Public objReader As SqlDataReader

    Public Ds As New DataSet
    Public Da As SqlDataAdapter

    Public RA As Long
    Public Ta As Boolean
    Public StrSql As String

    Public IdUsuario As Long
    Public Usuario As String
    Public NombreUsuario As String
    Public NivelUsuario As Integer
    Public IdDpto As Long

    Public Server As String
    Public DataBase As String
    Public User As String
    Public Password As String
    Public CadenaConeccion As String

    Public ConAbierta As Boolean
    Public Ruta As String
    Public Conectar As String

    Public FormMenu As New frmMenu

    Sub LeerConfig()

        Try

            Server = My.Settings.Servidor
            DataBase = My.Settings.DataBase
            User = My.Settings.Usuario
            Password = My.Settings.clave

            CadenaConeccion = "server=" & Server & ";database=" & DataBase & ";uid=" & User & ";pwd=" & Password

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        End Try

    End Sub

    Sub ConectarDB()
        Cnn.ConnectionString = CadenaConeccion
        Cnn.Open()

    End Sub

    Sub DesconectarDB()
        Cnn.Close()
    End Sub

    Function Cambiar(Valor As String) As String
        Dim Cadena As String
        Cadena = Replace(Valor, "'", "´", 1)
        Return Cadena
    End Function

    Function FechaValida(fecha As String) As Boolean
        Dim Dia As String
        Dim Mes As String
        Dim Anio As String

        Try

            Dia = Mid(fecha, 1, 2) : Mes = Mid(fecha, 4, 2) : Anio = Mid(fecha, 7, 4)

            If IsNumeric(Dia) Then
                If CLng(Dia) > 31 Or CLng(Dia) < 1 Then
                    Return False
                End If
            Else
                Return False
            End If

            If IsNumeric(Mes) Then
                If CLng(Mes) > 12 Or CLng(Mes) < 1 Then
                    Return False
                End If
            Else
                Return False
            End If

            If Not IsNumeric(Anio) Then
                Return False
            End If

            If Len(Trim(Dia)) <> 2 Then
                Return False
            End If

            If Len(Trim(Mes)) <> 2 Then
                Return False
            End If

            If Len(Trim(Anio)) <> 4 Then
                Return False
            End If

            Return True

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
            Return Nothing
        End Try

    End Function

    Function Efecha(Fecha As String) As String
        Dim Resul As String

        Resul = Mid(Fecha, 7, 4) & "/" & Mid(Fecha, 4, 2) & "/" & Mid(Fecha, 1, 2)
        Return Resul

    End Function

    Function Lfecha(Fecha As String) As String
        Dim Resul As String

        Resul = Mid(Fecha, 9, 2) & "/" & Mid(Fecha, 6, 2) & "/" & Mid(Fecha, 1, 4)
        Return Resul

    End Function

    Public Function EstaAbierto(ByVal Myform As Form) As Boolean
        Dim objForm As Form

        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                Return True
            End If
        Next

        Return False

    End Function

End Module
