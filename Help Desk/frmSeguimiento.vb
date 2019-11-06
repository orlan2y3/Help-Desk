Public Class frmSeguimiento

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
        styCabeceras.BackColor = Color.YellowGreen

        ' asignar estilo al grid
        DG.ColumnHeadersDefaultCellStyle = styCabeceras
    End Sub

    Sub ActualizaGrid()
        Try

            DG.Rows.Clear()
            FormatGrid()
            Dim Servicio As String = ""

            If cmbIdEstatus.Text = 0 Then
                StrSql = "SELECT HS.ID, HS.NO_TICKET, HD.NOMBRE AS NDEP, HS.FECHA_SOLICITUD, HS.HORA_SOLICITUD," _
                & "HS.ID_SERVICIO, HS.DETALLE, HE.NOMBRE AS NESTATUS" _
                & " FROM HELP_SOLICITUDES HS, HELP_DEPARTAMENTOS HD, HELP_ESTATUS HE" _
                & " WHERE HS.FECHA_SOLICITUD >='" & Efecha(txtInicial.Text) & "' AND HS.FECHA_SOLICITUD <='" & Efecha(txtFinal.Text) _
                & "'  AND HS.ID_USUARIO = " & IdUsuario & " AND HS.ID_DEPARTAMENTO = HD.ID AND HS.ID_ESTATUS = HE.ID"
            Else
                StrSql = "SELECT HS.ID, HS.NO_TICKET, HD.NOMBRE AS NDEP, HS.FECHA_SOLICITUD, HS.HORA_SOLICITUD," _
                & "HS.ID_SERVICIO, HS.DETALLE, HE.NOMBRE AS NESTATUS" _
                & " FROM HELP_SOLICITUDES HS, HELP_DEPARTAMENTOS HD, HELP_ESTATUS HE" _
                & " WHERE HS.FECHA_SOLICITUD >='" & Efecha(txtInicial.Text) & "' AND HS.FECHA_SOLICITUD <='" & Efecha(txtFinal.Text) _
                & "' AND HS.ID_ESTATUS =" & cmbIdEstatus.Text & " AND HS.ID_USUARIO = " & IdUsuario _
                & " AND HS.ID_DEPARTAMENTO =HD.ID  AND HS.ID_ESTATUS = HE.ID"
            End If
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
                    Servicio, Registro("detalle"), Registro("nestatus"))

                Next

            End If
            Ds.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Sub LlenaEstatus()
        Try
            cmbIdEstatus.Items.Clear()
            cmbEstatus.Items.Clear()

            cmbIdEstatus.Items.Add(0)
            cmbEstatus.Items.Add("TODAS")

            StrSql = "SELECT * FROM HELP_ESTATUS ORDER BY ID"
            objCmd = New SqlClient.SqlCommand(StrSql, Cnn)
            objReader = objCmd.ExecuteReader
            If objReader.HasRows Then
                While objReader.Read()
                    cmbIdEstatus.Items.Add(objReader("id"))
                    cmbEstatus.Items.Add(objReader("nombre"))
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
        txtHoraTrabajo.Clear()
        txtFechaCierre.Clear()
        txtDuracion.Clear()
        txtComentario1.Clear()
        'txtComentario2.Clear()
    End Sub

    Private Sub frmSeguimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim FechaInicial As String = Date.Now.AddMonths(-2)
        txtInicial.Text = Format(Date.Today.AddMonths(-2), "dd/MM/yyyy")
        txtFinal.Text = Format(Date.Today, "dd/MM/yyyy")
        LlenaEstatus()
        cmbEstatus.SelectedIndex = 0
        'btnBuscar.PerformClick()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If Not IsDate(txtInicial.Text) Then
            MsgBox("La fecha inicial no es valida", vbInformation)
            txtInicial.Focus()
            Return
        End If
        If Not IsDate(txtFinal.Text) Then
            MsgBox("La fecha final no es valida", vbInformation)
            txtFinal.Focus()
            Return
        End If

        If FechaValida(txtInicial.Text) = False Then
            MsgBox("La fecha inicial no es valida, verifique", vbInformation)
            txtInicial.Focus()
            Return
        End If
        If FechaValida(txtFinal.Text) = False Then
            MsgBox("La fecha Final no es valida, verifique", vbInformation)
            txtFinal.Focus()
            Return
        End If
        If CDate(txtInicial.Text) > CDate(txtFinal.Text) Then
            MsgBox("La fecha inicial no puede ser mayor que la fecha final", vbInformation)
            txtFinal.Focus()
            Return
        End If

        LimpiarCampos()
        ActualizaGrid()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub DG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG.CellClick
        If e.RowIndex = -1 Then
            Return
        End If

        Dim Id As Long
        Dim TA As Integer = 0
        Dim TT As Integer = 0
        Dim Dias As Integer = 0
        Dim TotalMinutos As Integer = 0
        Dim TotalHoras As Integer = 0

        LimpiarCampos()

        Try

            If Not DG.CurrentRow.IsNewRow Then
                Id = DG.Item(0, DG.CurrentRow.Index).Value
                txtTicket.Text = DG.Item(1, DG.CurrentRow.Index).Value
                txtDepartamento.Text = DG.Item(2, DG.CurrentRow.Index).Value
                txtFecha.Text = DG.Item(3, DG.CurrentRow.Index).Value
                txtHora.Text = DG.Item(4, DG.CurrentRow.Index).Value
                txtServicio.Text = DG.Item(5, DG.CurrentRow.Index).Value
                txtDetalle.Text = DG.Item(6, DG.CurrentRow.Index).Value
                txtEstatus.Text = DG.Item(7, DG.CurrentRow.Index).Value
                txtSolicita.Text = NombreUsuario

                StrSql = "SELECT TECNICO_ASIGNADO, TECNICO_SOLUCIONO, FECHA_SOLUCION, HORA_SOLUCION, FECHA_CIERRE," _
                & "COMENTARIO1_TECNICO  FROM HELP_SOLICITUDES WHERE ID =" & Id
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
                        If Len(objReader("fecha_solucion").ToString) > 0 Then
                            txtFechaTrabajo.Text = Lfecha(objReader("fecha_solucion").ToString)
                        Else
                            txtFechaTrabajo.Text = ""
                        End If
                    End If
                    If Not String.IsNullOrEmpty(objReader("hora_solucion").ToString) Then
                        If Len(objReader("hora_solucion").ToString) > 0 Then
                            txtHoraTrabajo.Text = objReader("hora_solucion").ToString
                        Else
                            txtHoraTrabajo.Text = ""
                        End If
                    End If
                    If Not String.IsNullOrEmpty(objReader("fecha_cierre").ToString) Then
                        If Len(objReader("fecha_cierre").ToString) > 0 Then
                            txtFechaCierre.Text = Lfecha(objReader("fecha_cierre").ToString)
                        Else
                            txtFechaCierre.Text = ""
                        End If
                    End If
                    If Not String.IsNullOrEmpty(objReader("comentario1_tecnico").ToString) Then
                        txtComentario1.Text = objReader("comentario1_tecnico").ToString
                    Else
                        txtComentario1.Text = ""
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

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try

    End Sub

    Private Sub rbTodas_Click(sender As Object, e As EventArgs)
        LimpiarCampos()
        btnBuscar.PerformClick()
    End Sub

    Private Sub rbPendientes_Click(sender As Object, e As EventArgs)
        LimpiarCampos()
        btnBuscar.PerformClick()
    End Sub

    Private Sub rbProceso_Click(sender As Object, e As EventArgs)
        LimpiarCampos()
        btnBuscar.PerformClick()
    End Sub

    Private Sub rbCerradas_Click(sender As Object, e As EventArgs)
        LimpiarCampos()
        btnBuscar.PerformClick()
    End Sub

    Private Sub frmSeguimiento_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormMenu.WindowState = FormWindowState.Normal
    End Sub

    Private Sub cmbEstatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbEstatus.SelectedValueChanged
        cmbIdEstatus.SelectedIndex = cmbEstatus.SelectedIndex
        btnBuscar.PerformClick()
    End Sub
End Class