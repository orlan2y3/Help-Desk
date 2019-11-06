Public Class frmEvaluar

    Sub FormatGrid()
        DG.Rows.Clear()
        DG.ColumnCount = 8

        DG.Columns(0).HeaderText = "ID"
        DG.Columns(1).HeaderText = "NO. TICKET"
        DG.Columns(2).HeaderText = "DEPARTAMENTO"
        DG.Columns(3).HeaderText = "FECHA"
        DG.Columns(4).HeaderText = "HORA"
        DG.Columns(5).HeaderText = "SERVICIO SOLICITADO"
        DG.Columns(6).HeaderText = "DETALLE"
        DG.Columns(7).HeaderText = "ESTATUS"

        DG.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        DG.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        DG.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        DG.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        DG.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
        DG.Columns(6).SortMode = DataGridViewColumnSortMode.NotSortable
        DG.Columns(7).SortMode = DataGridViewColumnSortMode.NotSortable

        'DG.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DG.Columns(0).Visible = False

        DG.Columns(0).Visible = False
        DG.Columns(1).Width = 80
        DG.Columns(2).Width = 125
        DG.Columns(3).Width = 80
        DG.Columns(4).Width = 70
        DG.Columns(5).Width = 200
        DG.Columns(6).Width = 350
        DG.Columns(7).Width = 105

        ' desactivar los estilos visuales del sistema
        DG.EnableHeadersVisualStyles = False

        ' estilo para la cabecera del grid
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.Aqua

        ' asignar estilo al grid
        DG.ColumnHeadersDefaultCellStyle = styCabeceras
    End Sub

    Sub ActualizaGrid()
        Try

            DG.Rows.Clear()
            FormatGrid()
            Dim Servicio As String = ""

            StrSql = "SELECT HS.ID, HS.NO_TICKET, HD.NOMBRE AS NDEP, HS.FECHA_SOLICITUD, HS.HORA_SOLICITUD," _
            & "HS.ID_SERVICIO, HS.DETALLE FROM HELP_SOLICITUDES HS, HELP_DEPARTAMENTOS HD" _
            & " WHERE HS.ID_ESTATUS =4 AND HS.EVALUADO ='N' AND HS.ID_USUARIO = " & IdUsuario _
            & " AND HS.ID_DEPARTAMENTO =HD.ID"
            Da = New SqlClient.SqlDataAdapter(StrSql, Cnn)
            Da.Fill(Ds, "help_solicitudes")
            If Ds.Tables("help_solicitudes").Rows.Count > 0 Then
                For Each Registro In Ds.Tables("help_solicitudes").Rows
                    Servicio = ""
                    If Registro("id_servicio") > 0 Then
                        StrSql = "SELECT NOMBRE FROM HELP_SERVICIOS WHERE ID =" & Registro("id_servicio")
                        objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
                        objReader = objCmd.ExecuteReader
                        If objReader.HasRows Then
                            objReader.Read()
                            Servicio = objReader("nombre")
                        End If
                        objReader.Close()
                    End If

                    DG.Rows.Add(Registro("id"), Registro("no_ticket"), Registro("ndep"), Lfecha(Registro("fecha_solicitud")), Registro("hora_solicitud"),
                    Servicio, Registro("detalle"), "RESUELTO")

                Next

            End If
            Ds.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Sub LimpiarCampos()
        txtTicket.Clear()
        txtSolicita.Clear()
        txtDepartamento.Clear()
        txtFecha.Clear()
        txtHora.Clear()
        txtServicio.Clear()
        txtDetalle.Clear()
        txtEstatus.Clear()
        txtAsignado.Clear()
        txtTrabajo.Clear()
        txtFechaTrabajo.Clear()
        txtComentario1.Clear()
        txtComentario2.Clear()
        txtComentario.Clear()
        txtDuracion.Clear()
    End Sub

    Sub LlenarValoracion()
        Try

            cmbIdValoracion.Items.Clear()
            cmbValoracion.Items.Clear()

            StrSql = "SELECT * FROM HELP_VALORACION"
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            If objReader.HasRows Then
                While objReader.Read
                    cmbIdValoracion.Items.Add(objReader("id"))
                    cmbValoracion.Items.Add(objReader("valoracion"))
                End While
            End If
            objReader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Function CalculaMinutos(HoraSolicitud As String, HoraSolucion As String) As Integer
        Dim Hora, minutos As Integer
        Dim Hora2, minutos2 As Integer
        Dim CantHoras As Integer = 0
        Dim CantMinutos As Integer = 0
        Dim Pos As Integer = 0

        Pos = InStr(HoraSolicitud, ":")
        Hora = Mid(HoraSolicitud, 1, Pos - 1)
        minutos = Mid(HoraSolicitud, Pos + 1, 2)

        Pos = InStr(HoraSolucion, ":")
        Hora2 = Mid(HoraSolucion, 1, Pos - 1)
        minutos2 = Mid(HoraSolucion, Pos + 1, 2)

        CantHoras = Hora2 - Hora
        If CantHoras = 0 Then
            CantMinutos = minutos2 - minutos
        ElseIf CantHoras = 1 Then
            If minutos2 < minutos Then
                CantMinutos = (60 - minutos) + minutos2
            ElseIf minutos2 = minutos Then
                CantMinutos = CantHoras * 60
            Else
                CantMinutos = (CantHoras * 60) + (minutos2 - minutos)
            End If
        ElseIf CantHoras > 1 Then
            If minutos2 < minutos Then
                CantHoras = CantHoras - 1
                CantMinutos = (CantHoras * 60) + ((60 - minutos) + minutos2)
            ElseIf minutos2 = minutos Then
                CantMinutos = CantHoras * 60
            Else
                CantMinutos = (CantHoras * 60) + (minutos2 - minutos)
            End If
        End If

        Return CantMinutos

    End Function

    Private Sub frmEvaluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualizaGrid()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        Dim Id As Long
        Dim TA As Integer = 0
        Dim TT As Integer = 0
        Dim Dias As Integer = 0
        Dim TotalMinutos As Integer = 0
        Dim TotalHoras As Integer = 0

        txtAsignado.Text = "" : txtTrabajo.Text = ""

        Try

            If Not DG.CurrentRow.IsNewRow Then
                txtSolicita.Text = NombreUsuario

                Id = DG.Item(0, DG.CurrentRow.Index).Value
                txtId.Text = DG.Item(0, DG.CurrentRow.Index).Value

                txtTicket.Text = DG.Item(1, DG.CurrentRow.Index).Value
                txtDepartamento.Text = DG.Item(2, DG.CurrentRow.Index).Value
                txtFecha.Text = DG.Item(3, DG.CurrentRow.Index).Value
                txtHora.Text = DG.Item(4, DG.CurrentRow.Index).Value
                txtServicio.Text = DG.Item(5, DG.CurrentRow.Index).Value
                txtDetalle.Text = DG.Item(6, DG.CurrentRow.Index).Value
                txtEstatus.Text = DG.Item(7, DG.CurrentRow.Index).Value

                StrSql = "SELECT TECNICO_ASIGNADO, TECNICO_SOLUCIONO, FECHA_SOLUCION, HORA_SOLUCION," _
                & "COMENTARIO1_TECNICO, COMENTARIO2_TECNICO  FROM HELP_SOLICITUDES WHERE ID =" & Id
                objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
                objReader = objCmd.ExecuteReader
                If objReader.HasRows Then
                    objReader.Read()
                    If Not IsDBNull(objReader("tecnico_asignado")) Then
                        TA = objReader("tecnico_asignado")
                    End If
                    If Not IsDBNull(objReader("tecnico_soluciono")) Then
                        TT = objReader("tecnico_soluciono")
                    Else
                        txtTrabajo.Text = ""
                    End If
                    If Not String.IsNullOrEmpty(objReader("fecha_solucion").ToString) Then
                        txtFechaTrabajo.Text = objReader("fecha_solucion").ToString
                    Else
                        txtFechaTrabajo.Text = ""
                    End If
                    If Not String.IsNullOrEmpty(objReader("hora_solucion").ToString) Then
                        txtHoraTrabajo.Text = objReader("hora_solucion").ToString
                    Else
                        txtHoraTrabajo.Text = ""
                    End If
                    If Not String.IsNullOrEmpty(objReader("comentario1_tecnico").ToString) Then
                        txtComentario1.Text = objReader("comentario1_tecnico").ToString
                    Else
                        txtComentario1.Text = ""
                    End If
                    If Not String.IsNullOrEmpty(objReader("comentario2_tecnico").ToString) Then
                        txtComentario2.Text = objReader("comentario2_tecnico").ToString
                    Else
                        txtComentario2.Text = ""
                    End If
                End If

                objReader.Close()

                If TA > 0 Then
                    StrSql = "SELECT NOMBRE FROM HELP_TECNICOS WHERE ID_TECNICO =" & TA
                    objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
                    objReader = objCmd.ExecuteReader
                    If objReader.HasRows Then
                        objReader.Read()
                        txtAsignado.Text = objReader("nombre").ToString
                    End If
                    objReader.Close()
                End If

                If TT > 0 Then
                    StrSql = "SELECT NOMBRE FROM HELP_TECNICOS WHERE ID_TECNICO =" & TT
                    objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
                    objReader = objCmd.ExecuteReader
                    If objReader.HasRows Then
                        objReader.Read()
                        txtTrabajo.Text = objReader("nombre").ToString
                    End If
                    objReader.Close()
                End If

                If IsDate(txtFecha.Text) And IsDate(txtFechaTrabajo.Text) Then
                    Dias = DateDiff("d", txtFecha.Text, txtFechaTrabajo.Text, FirstDayOfWeek.Sunday)
                    If Dias = 0 Then
                        TotalMinutos = CalculaMinutos(txtHora.Text, txtHoraTrabajo.Text)
                        If TotalMinutos < 60 Then
                            txtDuracion.Text = TotalMinutos & " Minutos"
                        Else
                            TotalHoras = TotalMinutos / 60
                            TotalMinutos = TotalMinutos Mod 60
                            If TotalMinutos > 0 Then
                                txtDuracion.Text = TotalHoras & " Hora(s) y " & TotalMinutos & " Minuto(s)"
                            Else
                                txtDuracion.Text = TotalHoras & " Hora(s)"
                            End If
                        End If

                    ElseIf Dias = 1 Then
                        txtDuracion.Text = "1 Dia"
                    ElseIf Dias > 1 Then
                        Dim F As Date
                        Dim D As Integer
                        Dim CantDias As Integer

                        CantDias = Dias

                        For X = 1 To Dias
                            F = CDate(txtFecha.Text).AddDays(X)
                            D = F.DayOfWeek
                            If D = 0 Or D = 6 Then
                                CantDias = CantDias - 1
                            End If
                        Next

                        If CantDias <= 0 Then
                            CantDias = 1
                        End If

                        Dias = CantDias
                        txtDuracion.Text = Dias & " Dias"
                    End If
                End If

                txtComentario.Clear()
                LlenarValoracion()
                txtComentario.Focus()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub cmbValoracion_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbValoracion.SelectedValueChanged
        cmbIdValoracion.SelectedIndex = cmbValoracion.SelectedIndex
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        If cmbValoracion.Text = "" Then
            MsgBox("Debe seleccionar una opción para evaluar el servicio", vbInformation)
            cmbValoracion.Focus()
            Return
        End If

        Try

            StrSql = "UPDATE HELP_SOLICITUDES SET COMENTARIO_USUARIO ='" & txtComentario.Text _
            & "', VALORACION_SERVICIO =" & cmbIdValoracion.Text & ", EVALUADO ='S'" & " WHERE ID =" & txtId.Text
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            RA = objCmd.ExecuteNonQuery()
            If RA > 0 Then
                ActualizaGrid()
                MsgBox("Evaluación enviada", vbInformation)
                LimpiarCampos()
                LlenarValoracion()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub frmEvaluar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub txtComentario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtComentario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbValoracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbValoracion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SendKeys.Send("{TAB}")
        End If
    End Sub
End Class