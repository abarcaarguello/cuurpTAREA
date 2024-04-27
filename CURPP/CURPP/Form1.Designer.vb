<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtApaterno = New System.Windows.Forms.TextBox()
        Me.TxtAmaterno = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtAño = New System.Windows.Forms.TextBox()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.ComboBoxDia = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMes = New System.Windows.Forms.ComboBox()
        Me.ComboBoxEstado = New System.Windows.Forms.ComboBox()
        Me.RdioBtnHombre = New System.Windows.Forms.RadioButton()
        Me.RdioBtnMujer = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apellido Paterno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido Materno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre(s):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha de Nacimiento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Entidad Federativa:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Tu Curp:"
        '
        'TxtApaterno
        '
        Me.TxtApaterno.Location = New System.Drawing.Point(120, 39)
        Me.TxtApaterno.Name = "TxtApaterno"
        Me.TxtApaterno.Size = New System.Drawing.Size(168, 20)
        Me.TxtApaterno.TabIndex = 7
        '
        'TxtAmaterno
        '
        Me.TxtAmaterno.Location = New System.Drawing.Point(120, 78)
        Me.TxtAmaterno.Name = "TxtAmaterno"
        Me.TxtAmaterno.Size = New System.Drawing.Size(168, 20)
        Me.TxtAmaterno.TabIndex = 8
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(120, 112)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(168, 20)
        Me.TxtNombre.TabIndex = 9
        '
        'TxtAño
        '
        Me.TxtAño.Location = New System.Drawing.Point(282, 177)
        Me.TxtAño.Name = "TxtAño"
        Me.TxtAño.Size = New System.Drawing.Size(49, 20)
        Me.TxtAño.TabIndex = 10
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(82, 237)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.Size = New System.Drawing.Size(100, 20)
        Me.TxtCurp.TabIndex = 11
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(189, 235)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 12
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(270, 235)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBorrar.TabIndex = 13
        Me.BtnBorrar.Text = "Borrar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'ComboBoxDia
        '
        Me.ComboBoxDia.FormattingEnabled = True
        Me.ComboBoxDia.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBoxDia.Location = New System.Drawing.Point(156, 176)
        Me.ComboBoxDia.Name = "ComboBoxDia"
        Me.ComboBoxDia.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxDia.TabIndex = 14
        '
        'ComboBoxMes
        '
        Me.ComboBoxMes.FormattingEnabled = True
        Me.ComboBoxMes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ComboBoxMes.Location = New System.Drawing.Point(219, 176)
        Me.ComboBoxMes.Name = "ComboBoxMes"
        Me.ComboBoxMes.Size = New System.Drawing.Size(57, 21)
        Me.ComboBoxMes.TabIndex = 15
        '
        'ComboBoxEstado
        '
        Me.ComboBoxEstado.FormattingEnabled = True
        Me.ComboBoxEstado.Items.AddRange(New Object() {"Aguascalientes(AG) ", "Baja California(BC)", "Baja California Sur(BS)", "Campeche(CM)", "Chiapas(CS) ", "Chihuahua(CH) ", "Coahuila (CO) ", "Colima (CL) ", "Ciudad de México(CX) ", "Durango(DG) ", "Guanajuato(GT) ", "Guerrero (GR) ", "Hidalgo(HG) ", "Jalisco(JC ", "Estado de México(ME)", "Michoacán(MN) ", "Morelos(MS)", "Nayarit(NT) ", "Nuevo León(NL) ", "Oaxaca(OC) ", "Puebla(PL) ", "Querétaro(QO) ", "Quintana Roo(QR) ", "San Luis Potosí(SP) ", "Sinaloa(SL) ", "Sonora(SR) ", "Tabasco (TC) ", "Tamaulipas(TS)", "Tlaxcala (TL) ", "Veracruz (VZ) ", "Yucatán (YN)", "Zacatecas(ZS)"})
        Me.ComboBoxEstado.Location = New System.Drawing.Point(134, 205)
        Me.ComboBoxEstado.Name = "ComboBoxEstado"
        Me.ComboBoxEstado.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxEstado.TabIndex = 16
        '
        'RdioBtnHombre
        '
        Me.RdioBtnHombre.AutoSize = True
        Me.RdioBtnHombre.Checked = True
        Me.RdioBtnHombre.Location = New System.Drawing.Point(120, 149)
        Me.RdioBtnHombre.Name = "RdioBtnHombre"
        Me.RdioBtnHombre.Size = New System.Drawing.Size(62, 17)
        Me.RdioBtnHombre.TabIndex = 17
        Me.RdioBtnHombre.TabStop = True
        Me.RdioBtnHombre.Text = "Hombre"
        Me.RdioBtnHombre.UseVisualStyleBackColor = True
        '
        'RdioBtnMujer
        '
        Me.RdioBtnMujer.AutoSize = True
        Me.RdioBtnMujer.Location = New System.Drawing.Point(204, 149)
        Me.RdioBtnMujer.Name = "RdioBtnMujer"
        Me.RdioBtnMujer.Size = New System.Drawing.Size(51, 17)
        Me.RdioBtnMujer.TabIndex = 18
        Me.RdioBtnMujer.Text = "Mujer"
        Me.RdioBtnMujer.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.CURPP.My.Resources.Resources.abstract_computer_technology_background_with_circuit_board_and_circle_tech_illustration_vector
        Me.ClientSize = New System.Drawing.Size(466, 290)
        Me.Controls.Add(Me.RdioBtnMujer)
        Me.Controls.Add(Me.RdioBtnHombre)
        Me.Controls.Add(Me.ComboBoxEstado)
        Me.Controls.Add(Me.ComboBoxMes)
        Me.Controls.Add(Me.ComboBoxDia)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.TxtCurp)
        Me.Controls.Add(Me.TxtAño)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtAmaterno)
        Me.Controls.Add(Me.TxtApaterno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtApaterno As TextBox
    Friend WithEvents TxtAmaterno As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtAño As TextBox
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents ComboBoxDia As ComboBox
    Friend WithEvents ComboBoxMes As ComboBox
    Friend WithEvents ComboBoxEstado As ComboBox
    Friend WithEvents RdioBtnHombre As RadioButton
    Friend WithEvents RdioBtnMujer As RadioButton
End Class
