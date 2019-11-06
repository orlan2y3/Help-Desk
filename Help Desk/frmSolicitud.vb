Public Class frmSolicitud

    Sub LlenaServicios()
        Try
            cmbIdServicio.Items.Clear()
            cmbServicios.Items.Clear()

            StrSql = "SELECT * FROM HELP_SERVICIOS ORDER BY ID ASC"
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            If objReader.HasRows Then
                While objReader.Read()
                    cmbIdServicio.Items.Add(objReader("id"))
                    cmbServicios.Items.Add(objReader("nombre"))
                End While
                objReader.Close()
            Else
                objReader.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Sub LlenaDepartamentos()
        Try
            cmbIdDpto.Items.Clear()
            cmbDpto.Items.Clear()

            StrSql = "SELECT * FROM HELP_DEPARTAMENTOS ORDER BY ID ASC"
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            If objReader.HasRows Then
                While objReader.Read()
                    cmbIdDpto.Items.Add(objReader("id"))
                    cmbDpto.Items.Add(objReader("nombre"))
                End While
                objReader.Close()
            Else
                objReader.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub frmSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            LlenaServicios()
            LlenaDepartamentos()
            cmbIdDpto.Text = IdDpto
            txtSolicita.Text = NombreUsuario
            txtFecha.Text = Format(Now, "dd/MM/yyyy")
            txtHora.Text = Format(Now, "hh:mm tt")

            Me.cmbServicios.Select()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub cmbDpto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbDpto.SelectedValueChanged
        cmbIdDpto.SelectedIndex = cmbDpto.SelectedIndex
    End Sub

    Private Sub cmbIdDpto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbIdDpto.SelectedValueChanged
        cmbDpto.SelectedIndex = cmbIdDpto.SelectedIndex
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If cmbServicios.Text = "" Then
            MsgBox("Debe seleccionar un servicio", vbInformation)
            cmbServicios.Focus()
            Return
        End If
        If Len(Trim(txtDetalle.Text)) = 0 Then
            MsgBox("Debe dar mas detalles sobre el servicio", vbInformation)
            txtDetalle.Focus()
            Return
        End If
        If cmbDpto.Text = "" Then
            MsgBox("Debe seleccionar el departamento que solicita el servicio", vbInformation)
            cmbDpto.Focus()
            Return
        End If

        Try
            Dim Ticket As String = ""
            Dim IdServicio As Integer = 0

            StrSql = "SELECT SIGLAS, SEC FROM HELP_DEPARTAMENTOS WHERE ID = " & cmbIdDpto.Text
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            If objReader.HasRows Then
                objReader.Read()
                Ticket = objReader("siglas") & (objReader("sec") + 1)
                objReader.Close()
            Else
                objReader.Close()
            End If

            If cmbServicios.Text = "" Then
                IdServicio = 0
            Else
                IdServicio = cmbIdServicio.Text
            End If

            StrSql = "INSERT INTO HELP_SOLICITUDES(NO_TICKET, ID_USUARIO, ID_DEPARTAMENTO," _
            & " FECHA_SOLICITUD, HORA_SOLICITUD, ID_SERVICIO, DETALLE, ID_ESTATUS) VALUES('" _
            & Ticket & "'," & IdUsuario & "," & cmbIdDpto.Text & ",'" & Format(Now, "yyyy/MM/dd") & "','" _
            & Format(Now, "HH:mm") & "'," & IdServicio & ",'" & Trim(txtDetalle.Text) & "'," & 1 & ")"
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            RA = objCmd.ExecuteNonQuery()
            If RA > 0 Then
                StrSql = "UPDATE HELP_DEPARTAMENTOS SET SEC = SEC + 1 WHERE ID = " & cmbIdDpto.Text
                objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
                RA = objCmd.ExecuteNonQuery()

                StrSql = "UPDATE HELP_ALERTAS SET ESTADO = 1"
                objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
                RA = objCmd.ExecuteNonQuery()

                LlenaServicios()
                txtDetalle.Text = ""
                txtFecha.Text = Format(Now, "dd/MM/yyyy")
                txtHora.Text = Format(Now, "hh:mm tt")

                MsgBox("Solicitud enviada", vbInformation)
                Me.Close()

            Else
                MsgBox("No fue posible enviar la solicitud a informática", vbCritical)
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub cmbServicios_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbServicios.SelectedValueChanged
        cmbIdServicio.SelectedIndex = cmbServicios.SelectedIndex
    End Sub

    Private Sub frmSolicitud_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmbServicios_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbServicios.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

End Class