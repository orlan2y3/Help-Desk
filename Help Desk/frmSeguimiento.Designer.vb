<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeguimiento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DG = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbIdEstatus = New System.Windows.Forms.ComboBox()
        Me.cmbEstatus = New System.Windows.Forms.ComboBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFinal = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtInicial = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtHoraTrabajo = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtFechaCierre = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtComentario1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFechaTrabajo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTrabajo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAsignado = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtServicio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTicket = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDepartamento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSolicita = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        CType(Me.DG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(110, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SEGUIMIENTO A SOLICITUDES"
        '
        'DG
        '
        Me.DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG.Location = New System.Drawing.Point(9, 93)
        Me.DG.Name = "DG"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DG.Size = New System.Drawing.Size(1075, 225)
        Me.DG.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(335, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dele clic a la solicitud que desea verificar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Help_Desk.My.Resources.Resources.Documentos1
        Me.PictureBox1.Location = New System.Drawing.Point(56, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Linen
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Help_Desk.My.Resources.Resources.Salir1
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(503, 501)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(88, 33)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.cmbIdEstatus)
        Me.GroupBox1.Controls.Add(Me.cmbEstatus)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtFinal)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtInicial)
        Me.GroupBox1.Location = New System.Drawing.Point(594, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 60)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(186, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(137, 16)
        Me.Label20.TabIndex = 113
        Me.Label20.Text = "Seleccione el Estatus"
        '
        'cmbIdEstatus
        '
        Me.cmbIdEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdEstatus.FormattingEnabled = True
        Me.cmbIdEstatus.Location = New System.Drawing.Point(238, 31)
        Me.cmbIdEstatus.Name = "cmbIdEstatus"
        Me.cmbIdEstatus.Size = New System.Drawing.Size(56, 21)
        Me.cmbIdEstatus.TabIndex = 112
        Me.cmbIdEstatus.Visible = False
        '
        'cmbEstatus
        '
        Me.cmbEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbEstatus.FormattingEnabled = True
        Me.cmbEstatus.Location = New System.Drawing.Point(188, 30)
        Me.cmbEstatus.Name = "cmbEstatus"
        Me.cmbEstatus.Size = New System.Drawing.Size(144, 21)
        Me.cmbEstatus.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.Help_Desk.My.Resources.Resources.Buscar8
        Me.btnBuscar.Location = New System.Drawing.Point(360, 13)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(44, 40)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(97, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 16)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Hasta"
        '
        'txtFinal
        '
        Me.txtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinal.Location = New System.Drawing.Point(100, 29)
        Me.txtFinal.Mask = "00/00/0000"
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(70, 22)
        Me.txtFinal.TabIndex = 1
        Me.txtFinal.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Desde"
        '
        'txtInicial
        '
        Me.txtInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInicial.Location = New System.Drawing.Point(13, 29)
        Me.txtInicial.Mask = "00/00/0000"
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Size = New System.Drawing.Size(70, 22)
        Me.txtInicial.TabIndex = 0
        Me.txtInicial.ValidatingType = GetType(Date)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtDuracion)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtHoraTrabajo)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtFechaCierre)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtComentario1)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtFechaTrabajo)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTrabajo)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtAsignado)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtEstatus)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtDetalle)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtServicio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTicket)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtDepartamento)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtSolicita)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtHora)
        Me.GroupBox2.Controls.Add(Me.txtFecha)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 322)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1074, 166)
        Me.GroupBox2.TabIndex = 106
        Me.GroupBox2.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(490, 117)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(157, 16)
        Me.Label22.TabIndex = 74
        Me.Label22.Text = "Duración del Servicio"
        '
        'txtDuracion
        '
        Me.txtDuracion.BackColor = System.Drawing.Color.Honeydew
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDuracion.Location = New System.Drawing.Point(492, 134)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.ReadOnly = True
        Me.txtDuracion.Size = New System.Drawing.Size(234, 22)
        Me.txtDuracion.TabIndex = 14
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(312, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 16)
        Me.Label21.TabIndex = 72
        Me.Label21.Text = "Hora trabajo"
        '
        'txtHoraTrabajo
        '
        Me.txtHoraTrabajo.BackColor = System.Drawing.Color.Honeydew
        Me.txtHoraTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoraTrabajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHoraTrabajo.Location = New System.Drawing.Point(315, 134)
        Me.txtHoraTrabajo.Name = "txtHoraTrabajo"
        Me.txtHoraTrabajo.ReadOnly = True
        Me.txtHoraTrabajo.Size = New System.Drawing.Size(72, 22)
        Me.txtHoraTrabajo.TabIndex = 12
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(398, 117)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 16)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Fecha Cierre"
        '
        'txtFechaCierre
        '
        Me.txtFechaCierre.BackColor = System.Drawing.Color.Honeydew
        Me.txtFechaCierre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaCierre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaCierre.Location = New System.Drawing.Point(401, 134)
        Me.txtFechaCierre.Name = "txtFechaCierre"
        Me.txtFechaCierre.ReadOnly = True
        Me.txtFechaCierre.Size = New System.Drawing.Size(77, 22)
        Me.txtFechaCierre.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(769, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(0, 16)
        Me.Label18.TabIndex = 67
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(738, 118)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(151, 16)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Comentario del Técnico"
        '
        'txtComentario1
        '
        Me.txtComentario1.BackColor = System.Drawing.Color.Honeydew
        Me.txtComentario1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentario1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtComentario1.Location = New System.Drawing.Point(740, 135)
        Me.txtComentario1.Name = "txtComentario1"
        Me.txtComentario1.ReadOnly = True
        Me.txtComentario1.Size = New System.Drawing.Size(320, 21)
        Me.txtComentario1.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(218, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 16)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "Fecha trabajo"
        '
        'txtFechaTrabajo
        '
        Me.txtFechaTrabajo.BackColor = System.Drawing.Color.Honeydew
        Me.txtFechaTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaTrabajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFechaTrabajo.Location = New System.Drawing.Point(224, 134)
        Me.txtFechaTrabajo.Name = "txtFechaTrabajo"
        Me.txtFechaTrabajo.ReadOnly = True
        Me.txtFechaTrabajo.Size = New System.Drawing.Size(77, 22)
        Me.txtFechaTrabajo.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(13, 117)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(196, 16)
        Me.Label15.TabIndex = 61
        Me.Label15.Text = "Técnico que hizo el trabajo"
        '
        'txtTrabajo
        '
        Me.txtTrabajo.BackColor = System.Drawing.Color.Honeydew
        Me.txtTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrabajo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTrabajo.Location = New System.Drawing.Point(12, 135)
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.ReadOnly = True
        Me.txtTrabajo.Size = New System.Drawing.Size(198, 21)
        Me.txtTrabajo.TabIndex = 10
        Me.txtTrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(895, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(134, 16)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "Técnico Asignado"
        '
        'txtAsignado
        '
        Me.txtAsignado.BackColor = System.Drawing.Color.Honeydew
        Me.txtAsignado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsignado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAsignado.Location = New System.Drawing.Point(871, 80)
        Me.txtAsignado.Name = "txtAsignado"
        Me.txtAsignado.ReadOnly = True
        Me.txtAsignado.Size = New System.Drawing.Size(191, 21)
        Me.txtAsignado.TabIndex = 9
        Me.txtAsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(739, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 16)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Estatus Servicio"
        '
        'txtEstatus
        '
        Me.txtEstatus.BackColor = System.Drawing.Color.Honeydew
        Me.txtEstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEstatus.Location = New System.Drawing.Point(740, 80)
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.ReadOnly = True
        Me.txtEstatus.Size = New System.Drawing.Size(118, 21)
        Me.txtEstatus.TabIndex = 8
        Me.txtEstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 16)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Detalle"
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.Color.Honeydew
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDetalle.Location = New System.Drawing.Point(12, 80)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.ReadOnly = True
        Me.txtDetalle.Size = New System.Drawing.Size(714, 21)
        Me.txtDetalle.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(737, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Servicio Solicitado"
        '
        'txtServicio
        '
        Me.txtServicio.BackColor = System.Drawing.Color.Honeydew
        Me.txtServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtServicio.Location = New System.Drawing.Point(740, 30)
        Me.txtServicio.Name = "txtServicio"
        Me.txtServicio.ReadOnly = True
        Me.txtServicio.Size = New System.Drawing.Size(322, 21)
        Me.txtServicio.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(20, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "No. Ticket"
        '
        'txtTicket
        '
        Me.txtTicket.BackColor = System.Drawing.Color.Honeydew
        Me.txtTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTicket.Location = New System.Drawing.Point(12, 30)
        Me.txtTicket.Name = "txtTicket"
        Me.txtTicket.ReadOnly = True
        Me.txtTicket.Size = New System.Drawing.Size(96, 22)
        Me.txtTicket.TabIndex = 0
        Me.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Departamento"
        '
        'txtDepartamento
        '
        Me.txtDepartamento.BackColor = System.Drawing.Color.Honeydew
        Me.txtDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartamento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDepartamento.Location = New System.Drawing.Point(316, 30)
        Me.txtDepartamento.Name = "txtDepartamento"
        Me.txtDepartamento.ReadOnly = True
        Me.txtDepartamento.Size = New System.Drawing.Size(238, 22)
        Me.txtDepartamento.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(119, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Solicitado por:"
        '
        'txtSolicita
        '
        Me.txtSolicita.BackColor = System.Drawing.Color.Honeydew
        Me.txtSolicita.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicita.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSolicita.Location = New System.Drawing.Point(121, 30)
        Me.txtSolicita.Name = "txtSolicita"
        Me.txtSolicita.ReadOnly = True
        Me.txtSolicita.Size = New System.Drawing.Size(181, 22)
        Me.txtSolicita.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(652, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Hora"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(564, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Fecha"
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.Honeydew
        Me.txtHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtHora.Location = New System.Drawing.Point(654, 30)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(72, 22)
        Me.txtHora.TabIndex = 4
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.Honeydew
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(566, 30)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(77, 22)
        Me.txtFecha.TabIndex = 3
        '
        'frmSeguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(1094, 540)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DG)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmSeguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HELP DESK - Darle Seguimiento a Solicitud"
        CType(Me.DG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DG As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFinal As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtInicial As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSolicita As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHora As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTicket As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDepartamento As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtServicio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAsignado As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtEstatus As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtComentario1 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFechaTrabajo As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtTrabajo As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmbIdEstatus As ComboBox
    Friend WithEvents cmbEstatus As ComboBox
    Friend WithEvents txtFechaCierre As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtHoraTrabajo As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtDuracion As TextBox
End Class
