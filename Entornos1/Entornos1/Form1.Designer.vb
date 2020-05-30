<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.v1 = New System.Windows.Forms.Label()
        Me.v2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.checkSuma = New System.Windows.Forms.CheckBox()
        Me.checkResta = New System.Windows.Forms.CheckBox()
        Me.checkDiv = New System.Windows.Forms.CheckBox()
        Me.checkMult = New System.Windows.Forms.CheckBox()
        Me.checkRaiz = New System.Windows.Forms.CheckBox()
        Me.checkPotencia = New System.Windows.Forms.CheckBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'v1
        '
        Me.v1.AutoSize = True
        Me.v1.Location = New System.Drawing.Point(51, 67)
        Me.v1.Name = "v1"
        Me.v1.Size = New System.Drawing.Size(43, 13)
        Me.v1.TabIndex = 0
        Me.v1.Text = "Valor 1:"
        '
        'v2
        '
        Me.v2.AutoSize = True
        Me.v2.Location = New System.Drawing.Point(287, 67)
        Me.v2.Name = "v2"
        Me.v2.Size = New System.Drawing.Size(43, 13)
        Me.v2.TabIndex = 2
        Me.v2.Text = "Valor 2:"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(111, 64)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 3
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(363, 64)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 354)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 354)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'checkSuma
        '
        Me.checkSuma.AutoSize = True
        Me.checkSuma.Location = New System.Drawing.Point(135, 124)
        Me.checkSuma.Name = "checkSuma"
        Me.checkSuma.Size = New System.Drawing.Size(53, 17)
        Me.checkSuma.TabIndex = 16
        Me.checkSuma.Text = "Suma"
        Me.checkSuma.UseVisualStyleBackColor = True
        '
        'checkResta
        '
        Me.checkResta.AutoSize = True
        Me.checkResta.Location = New System.Drawing.Point(135, 183)
        Me.checkResta.Name = "checkResta"
        Me.checkResta.Size = New System.Drawing.Size(54, 17)
        Me.checkResta.TabIndex = 17
        Me.checkResta.Text = "Resta"
        Me.checkResta.UseVisualStyleBackColor = True
        '
        'checkDiv
        '
        Me.checkDiv.AutoSize = True
        Me.checkDiv.Location = New System.Drawing.Point(135, 243)
        Me.checkDiv.Name = "checkDiv"
        Me.checkDiv.Size = New System.Drawing.Size(63, 17)
        Me.checkDiv.TabIndex = 18
        Me.checkDiv.Text = "División"
        Me.checkDiv.UseVisualStyleBackColor = True
        '
        'checkMult
        '
        Me.checkMult.AutoSize = True
        Me.checkMult.Location = New System.Drawing.Point(267, 124)
        Me.checkMult.Name = "checkMult"
        Me.checkMult.Size = New System.Drawing.Size(90, 17)
        Me.checkMult.TabIndex = 19
        Me.checkMult.Text = "Multiplicación"
        Me.checkMult.UseVisualStyleBackColor = True
        '
        'checkRaiz
        '
        Me.checkRaiz.AutoSize = True
        Me.checkRaiz.Location = New System.Drawing.Point(267, 183)
        Me.checkRaiz.Name = "checkRaiz"
        Me.checkRaiz.Size = New System.Drawing.Size(49, 17)
        Me.checkRaiz.TabIndex = 20
        Me.checkRaiz.Text = "Raíz"
        Me.checkRaiz.UseVisualStyleBackColor = True
        '
        'checkPotencia
        '
        Me.checkPotencia.AutoSize = True
        Me.checkPotencia.Location = New System.Drawing.Point(267, 243)
        Me.checkPotencia.Name = "checkPotencia"
        Me.checkPotencia.Size = New System.Drawing.Size(68, 17)
        Me.checkPotencia.TabIndex = 21
        Me.checkPotencia.Text = "Potencia"
        Me.checkPotencia.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(193, 314)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.ReadOnly = True
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(527, 410)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.checkPotencia)
        Me.Controls.Add(Me.checkRaiz)
        Me.Controls.Add(Me.checkMult)
        Me.Controls.Add(Me.checkDiv)
        Me.Controls.Add(Me.checkResta)
        Me.Controls.Add(Me.checkSuma)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.v2)
        Me.Controls.Add(Me.v1)
        Me.Name = "Form1"
        Me.Text = "Mi Primer App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents v1 As Label
    Friend WithEvents v2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents checkSuma As CheckBox
    Friend WithEvents checkResta As CheckBox
    Friend WithEvents checkDiv As CheckBox
    Friend WithEvents checkMult As CheckBox
    Friend WithEvents checkRaiz As CheckBox
    Friend WithEvents checkPotencia As CheckBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
End Class
