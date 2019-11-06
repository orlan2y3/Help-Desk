Public Class frmQuejas
    Private Sub frmQuejas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSolicita.Text = NombreUsuario
        cmbTipo.Items.Add("Queja")
        cmbTipo.Items.Add("Sugerencia")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If cmbTipo.Text = "" Then
            MsgBox("Debe seleccionar el tipo de información que enviará", vbInformation)
            cmbTipo.Focus()
            Return
        End If

        Try
            StrSql = "INSERT INTO HELP_QUEJAS(ID_USUARIO, ID_DEPARTAMENTO, TIPO, COMENTARIO, FECHA) VALUES(" _
            & IdUsuario & "," & IdDpto & ",'" & cmbTipo.Text & "','" & txtComentario.Text & "','" & Format(Now, "yyyy/MM/dd") & "')"
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            RA = objCmd.ExecuteNonQuery()
            If RA > 0 Then
                MsgBox("Mensaje enviado", vbInformation)
                cmbTipo.Items.Clear()
                cmbTipo.Items.Add("Queja")
                cmbTipo.Items.Add("Sugerencia")
                txtComentario.Clear()
                txtComentario.Focus()
            Else
                MsgBox("No fue posible enviar el mensaje", vbCritical)
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub cmbTipo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedValueChanged
        If cmbTipo.Text <> "" Then
            Label2.Text = "Digite su " & cmbTipo.Text
            txtComentario.Focus()
        End If

    End Sub

    Private Sub frmQuejas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenu.WindowState = FormWindowState.Normal
    End Sub

End Class