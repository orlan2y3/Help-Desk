Public Class frmSeguridad
    Private Sub FrmSeguridad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            LeerConfig()
            ConectarDB()

            txtUsuario.Focus()

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        End Try

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If Len(Trim(txtUsuario.Text)) = 0 Then
            MsgBox("Debe digitar el usuario", vbInformation)
            txtUsuario.Focus()
            Return
        End If
        If Len(Trim(txtClave.Text)) = 0 Then
            MsgBox("Debe digitar el password", vbInformation)
            txtClave.Focus()
            Return
        End If

        Try
            IdUsuario = 0
            Usuario = ""
            NombreUsuario = ""
            NivelUsuario = 0

            StrSql = "SELECT * FROM HELP_USUARIOS WHERE USUARIO ='" & Trim(txtUsuario.Text) _
            & "' AND CLAVE ='" & Trim(txtClave.Text) & "'"
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            objReader.Read()
            If objReader.HasRows Then
                IdUsuario = objReader("id_usuario")
                Usuario = objReader("usuario")
                NombreUsuario = objReader("nombre")
                NivelUsuario = objReader("nivel")
                IdDpto = objReader("id_departamento")
                objReader.Close()

                FormMenu.Show()
                Me.Close()

            Else
                objReader.Close()
                MsgBox("Acceso Negado", vbCritical)
                txtClave.Focus()
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbInformation)
        End Try
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        DesconectarDB()
        End
    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtClave.Focus()
        End If
    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            btnOk.PerformClick()
        End If
    End Sub
End Class
