<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FuncionesconString
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.txtcadena = New System.Windows.Forms.TextBox()
        Me.txtlongitud = New System.Windows.Forms.TextBox()
        Me.txtUltcarac = New System.Windows.Forms.TextBox()
        Me.txtPricarac = New System.Windows.Forms.TextBox()
        Me.txtmin = New System.Windows.Forms.TextBox()
        Me.txtmayus = New System.Windows.Forms.TextBox()
        Me.txtposB = New System.Windows.Forms.TextBox()
        Me.txt3ro = New System.Windows.Forms.TextBox()
        Me.txtespacios = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadena"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Logitud"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ultimo caracter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Primer caracter"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "3ro al 8vo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Pocision de la letra B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mayusculas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Minusculas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 300)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Borrar espacios"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(297, 140)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(77, 32)
        Me.btnMostrar.TabIndex = 9
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'txtcadena
        '
        Me.txtcadena.Location = New System.Drawing.Point(142, 39)
        Me.txtcadena.Name = "txtcadena"
        Me.txtcadena.Size = New System.Drawing.Size(133, 20)
        Me.txtcadena.TabIndex = 10
        '
        'txtlongitud
        '
        Me.txtlongitud.Location = New System.Drawing.Point(142, 73)
        Me.txtlongitud.Name = "txtlongitud"
        Me.txtlongitud.Size = New System.Drawing.Size(86, 20)
        Me.txtlongitud.TabIndex = 11
        '
        'txtUltcarac
        '
        Me.txtUltcarac.Location = New System.Drawing.Point(142, 104)
        Me.txtUltcarac.Name = "txtUltcarac"
        Me.txtUltcarac.Size = New System.Drawing.Size(86, 20)
        Me.txtUltcarac.TabIndex = 12
        '
        'txtPricarac
        '
        Me.txtPricarac.Location = New System.Drawing.Point(142, 140)
        Me.txtPricarac.Name = "txtPricarac"
        Me.txtPricarac.Size = New System.Drawing.Size(86, 20)
        Me.txtPricarac.TabIndex = 13
        '
        'txtmin
        '
        Me.txtmin.Location = New System.Drawing.Point(142, 274)
        Me.txtmin.Name = "txtmin"
        Me.txtmin.Size = New System.Drawing.Size(133, 20)
        Me.txtmin.TabIndex = 17
        '
        'txtmayus
        '
        Me.txtmayus.Location = New System.Drawing.Point(142, 241)
        Me.txtmayus.Name = "txtmayus"
        Me.txtmayus.Size = New System.Drawing.Size(133, 20)
        Me.txtmayus.TabIndex = 16
        '
        'txtposB
        '
        Me.txtposB.Location = New System.Drawing.Point(142, 203)
        Me.txtposB.Name = "txtposB"
        Me.txtposB.Size = New System.Drawing.Size(86, 20)
        Me.txtposB.TabIndex = 15
        '
        'txt3ro
        '
        Me.txt3ro.Location = New System.Drawing.Point(142, 169)
        Me.txt3ro.Name = "txt3ro"
        Me.txt3ro.Size = New System.Drawing.Size(86, 20)
        Me.txt3ro.TabIndex = 14
        '
        'txtespacios
        '
        Me.txtespacios.Location = New System.Drawing.Point(142, 300)
        Me.txtespacios.Name = "txtespacios"
        Me.txtespacios.Size = New System.Drawing.Size(133, 20)
        Me.txtespacios.TabIndex = 18
        '
        'FuncionesconString
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 361)
        Me.Controls.Add(Me.txtespacios)
        Me.Controls.Add(Me.txtmin)
        Me.Controls.Add(Me.txtmayus)
        Me.Controls.Add(Me.txtposB)
        Me.Controls.Add(Me.txt3ro)
        Me.Controls.Add(Me.txtPricarac)
        Me.Controls.Add(Me.txtUltcarac)
        Me.Controls.Add(Me.txtlongitud)
        Me.Controls.Add(Me.txtcadena)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FuncionesconString"
        Me.Text = "FuncionesconString"
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
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnMostrar As Button
    Friend WithEvents txtcadena As TextBox
    Friend WithEvents txtlongitud As TextBox
    Friend WithEvents txtUltcarac As TextBox
    Friend WithEvents txtPricarac As TextBox
    Friend WithEvents txtmin As TextBox
    Friend WithEvents txtmayus As TextBox
    Friend WithEvents txtposB As TextBox
    Friend WithEvents txt3ro As TextBox
    Friend WithEvents txtespacios As TextBox
End Class
