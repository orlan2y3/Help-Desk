<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnEvaluar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnSeguimiento = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMensaje2 = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.btnEvaluarTransp = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btnSeguimientoTransp = New System.Windows.Forms.Button()
        Me.btnTransportacion = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnQuejas = New System.Windows.Forms.Button()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtMensaje)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.btnEvaluar)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.btnSeguimiento)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 319)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DEPARTAMENTO DE INFORMATICA"
        '
        'txtMensaje
        '
        Me.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje.Enabled = False
        Me.txtMensaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.ForeColor = System.Drawing.Color.Gray
        Me.txtMensaje.Location = New System.Drawing.Point(108, 292)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(276, 15)
        Me.txtMensaje.TabIndex = 6
        Me.txtMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMensaje.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Help_Desk.My.Resources.Resources.Evaluar_2
        Me.PictureBox3.Location = New System.Drawing.Point(12, 225)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'btnEvaluar
        '
        Me.btnEvaluar.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEvaluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluar.ForeColor = System.Drawing.Color.Navy
        Me.btnEvaluar.Location = New System.Drawing.Point(114, 242)
        Me.btnEvaluar.Name = "btnEvaluar"
        Me.btnEvaluar.Size = New System.Drawing.Size(261, 47)
        Me.btnEvaluar.TabIndex = 2
        Me.btnEvaluar.Text = "Evaluar el Servicio"
        Me.btnEvaluar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Help_Desk.My.Resources.Resources.Documentos1
        Me.PictureBox2.Location = New System.Drawing.Point(11, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'btnSeguimiento
        '
        Me.btnSeguimiento.BackColor = System.Drawing.Color.PaleGreen
        Me.btnSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguimiento.ForeColor = System.Drawing.Color.Black
        Me.btnSeguimiento.Location = New System.Drawing.Point(112, 143)
        Me.btnSeguimiento.Name = "btnSeguimiento"
        Me.btnSeguimiento.Size = New System.Drawing.Size(261, 52)
        Me.btnSeguimiento.TabIndex = 1
        Me.btnSeguimiento.Text = "Darle Seguimiento a Solicitud"
        Me.btnSeguimiento.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Help_Desk.My.Resources.Resources.HelpDesk1
        Me.PictureBox1.Location = New System.Drawing.Point(11, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.Color.Khaki
        Me.btnSolicitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitar.Location = New System.Drawing.Point(112, 43)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(261, 55)
        Me.btnSolicitar.TabIndex = 0
        Me.btnSolicitar.Text = "Solicitar Soporte Técnico al Dpto. de Informática"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.GhostWhite
        Me.GroupBox2.Controls.Add(Me.txtMensaje2)
        Me.GroupBox2.Controls.Add(Me.PictureBox6)
        Me.GroupBox2.Controls.Add(Me.btnEvaluarTransp)
        Me.GroupBox2.Controls.Add(Me.PictureBox7)
        Me.GroupBox2.Controls.Add(Me.btnSeguimientoTransp)
        Me.GroupBox2.Controls.Add(Me.btnTransportacion)
        Me.GroupBox2.Controls.Add(Me.PictureBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(458, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(386, 319)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DEPARTAMENTO DE TRANSPORTACION"
        '
        'txtMensaje2
        '
        Me.txtMensaje2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensaje2.Enabled = False
        Me.txtMensaje2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje2.ForeColor = System.Drawing.Color.Gray
        Me.txtMensaje2.Location = New System.Drawing.Point(108, 299)
        Me.txtMensaje2.Name = "txtMensaje2"
        Me.txtMensaje2.Size = New System.Drawing.Size(276, 15)
        Me.txtMensaje2.TabIndex = 15
        Me.txtMensaje2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtMensaje2.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Help_Desk.My.Resources.Resources.Doc2
        Me.PictureBox6.Location = New System.Drawing.Point(13, 224)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 14
        Me.PictureBox6.TabStop = False
        '
        'btnEvaluarTransp
        '
        Me.btnEvaluarTransp.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnEvaluarTransp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluarTransp.ForeColor = System.Drawing.Color.Green
        Me.btnEvaluarTransp.Location = New System.Drawing.Point(115, 241)
        Me.btnEvaluarTransp.Name = "btnEvaluarTransp"
        Me.btnEvaluarTransp.Size = New System.Drawing.Size(261, 55)
        Me.btnEvaluarTransp.TabIndex = 12
        Me.btnEvaluarTransp.Text = "Evaluar Servicios de Transportación"
        Me.btnEvaluarTransp.UseVisualStyleBackColor = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Help_Desk.My.Resources.Resources.Documentos3
        Me.PictureBox7.Location = New System.Drawing.Point(12, 126)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'btnSeguimientoTransp
        '
        Me.btnSeguimientoTransp.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnSeguimientoTransp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeguimientoTransp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSeguimientoTransp.Location = New System.Drawing.Point(113, 143)
        Me.btnSeguimientoTransp.Name = "btnSeguimientoTransp"
        Me.btnSeguimientoTransp.Size = New System.Drawing.Size(261, 55)
        Me.btnSeguimientoTransp.TabIndex = 11
        Me.btnSeguimientoTransp.Text = "Seguimiento a Solicitudes de Transportación"
        Me.btnSeguimientoTransp.UseVisualStyleBackColor = False
        '
        'btnTransportacion
        '
        Me.btnTransportacion.BackColor = System.Drawing.Color.PapayaWhip
        Me.btnTransportacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransportacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnTransportacion.Location = New System.Drawing.Point(112, 44)
        Me.btnTransportacion.Name = "btnTransportacion"
        Me.btnTransportacion.Size = New System.Drawing.Size(262, 57)
        Me.btnTransportacion.TabIndex = 9
        Me.btnTransportacion.Text = "Solicitar Servicios de Transportación"
        Me.btnTransportacion.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Help_Desk.My.Resources.Resources.Transporte
        Me.PictureBox4.Location = New System.Drawing.Point(12, 24)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(123, 98)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 10
        Me.PictureBox4.TabStop = False
        '
        'btnQuejas
        '
        Me.btnQuejas.BackColor = System.Drawing.Color.MistyRose
        Me.btnQuejas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuejas.ForeColor = System.Drawing.Color.Red
        Me.btnQuejas.Location = New System.Drawing.Point(124, 372)
        Me.btnQuejas.Name = "btnQuejas"
        Me.btnQuejas.Size = New System.Drawing.Size(260, 50)
        Me.btnQuejas.TabIndex = 10
        Me.btnQuejas.Text = "Reportar Quejas o Sugerencias"
        Me.btnQuejas.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Help_Desk.My.Resources.Resources.Quejas_y_Sugerencias_2
        Me.PictureBox5.Location = New System.Drawing.Point(21, 354)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(93, 88)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Image = Global.Help_Desk.My.Resources.Resources.Salir1
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(615, 372)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(92, 50)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(854, 454)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.btnQuejas)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HELP DESK - M E S A  D E  A Y U D A  -  Menu Principal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSeguimiento As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnEvaluar As Button
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnTransportacion As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnQuejas As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents btnEvaluarTransp As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnSeguimientoTransp As Button
    Friend WithEvents txtMensaje2 As TextBox
End Class
