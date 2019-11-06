Public Class frmMenu
    Sub VerificarEvaluaciones()
        Try

            StrSql = "SELECT COUNT(ID) AS CANT FROM HELP_SOLICITUDES WHERE ID_ESTATUS =4 AND EVALUADO ='N' AND ID_USUARIO = " & IdUsuario
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            objReader.Read()
            If objReader("cant") > 0 Then
                If objReader("cant") = 1 Then
                    txtMensaje.Text = "** Tiene " & objReader("cant") & " evaluacion pendiente **"
                Else
                    txtMensaje.Text = "Tiene " & objReader("cant") & " evaluaciones pendientes"
                End If

                txtMensaje.Visible = True
                objReader.Close()
            Else
                objReader.Close()
                txtMensaje.Text = ""
                txtMensaje.Visible = False
            End If


            StrSql = "SELECT COUNT(ID) AS CANT FROM TRANSP_SOLICITUDES WHERE ID_ESTATUS =4 AND EVALUADO ='N' AND ID_USUARIO = " & IdUsuario
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            objReader.Read()
            If objReader("cant") > 0 Then
                If objReader("cant") = 1 Then
                    txtMensaje2.Text = "** Tiene " & objReader("cant") & " evaluacion pendiente **"
                Else
                    txtMensaje2.Text = "Tiene " & objReader("cant") & " evaluaciones pendientes"
                End If

                txtMensaje2.Visible = True
                objReader.Close()
            Else
                objReader.Close()
                txtMensaje2.Text = ""
                txtMensaje2.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmSolicitud
        Form.Show()
    End Sub

    Private Sub btnSeguimiento_Click(sender As Object, e As EventArgs) Handles btnSeguimiento.Click
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmSeguimiento
        Form.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEvaluar.Click
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmEvaluar
        Form.Show()
    End Sub

    Private Sub btnQuejas_Click(sender As Object, e As EventArgs) Handles btnQuejas.Click
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmQuejas
        Form.Show()
    End Sub

    Private Sub frmMenu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        VerificarEvaluaciones()
    End Sub

    Private Sub btnTransportacion_Click(sender As Object, e As EventArgs)
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmSolicitudTransporte
        Form.Show()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnSeguimientoTransp_Click(sender As Object, e As EventArgs) Handles btnSeguimientoTransp.Click
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmSeguimientoTransp
        Form.Show()
    End Sub

    Private Sub btnTransportacion_Click_1(sender As Object, e As EventArgs) Handles btnTransportacion.Click
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmSolicitudTransporte
        Form.Show()
    End Sub

    Private Sub btnEvaluarTransp_Click(sender As Object, e As EventArgs) Handles btnEvaluarTransp.Click
        FormMenu.WindowState = FormWindowState.Minimized
        Dim Form As New frmEvaluarTransp
        Form.Show()
    End Sub

End Class