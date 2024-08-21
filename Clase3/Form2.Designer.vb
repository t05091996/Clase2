<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtcarga = New TextBox()
        C1 = New Button()
        lblestado = New Label()
        SuspendLayout()
        ' 
        ' txtcarga
        ' 
        txtcarga.Location = New Point(56, 44)
        txtcarga.Name = "txtcarga"
        txtcarga.Size = New Size(100, 23)
        txtcarga.TabIndex = 0
        ' 
        ' C1
        ' 
        C1.Location = New Point(56, 83)
        C1.Name = "C1"
        C1.Size = New Size(75, 23)
        C1.TabIndex = 1
        C1.Text = "Cargar"
        C1.UseVisualStyleBackColor = True
        ' 
        ' lblestado
        ' 
        lblestado.AutoSize = True
        lblestado.Location = New Point(9, 47)
        lblestado.Name = "lblestado"
        lblestado.Size = New Size(0, 15)
        lblestado.TabIndex = 2
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(186, 162)
        Controls.Add(lblestado)
        Controls.Add(C1)
        Controls.Add(txtcarga)
        Name = "Form2"
        Text = "Actividad 3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtcarga As TextBox
    Friend WithEvents C1 As Button
    Friend WithEvents lblestado As Label
End Class
