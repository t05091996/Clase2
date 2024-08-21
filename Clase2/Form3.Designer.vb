<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        c1 = New ComboBox()
        T1 = New TextBox()
        T2 = New TextBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 112)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Número 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 1
        Label2.Text = "Número 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 2
        Label3.Text = "Selecciona"
        ' 
        ' c1
        ' 
        c1.FormattingEnabled = True
        c1.Items.AddRange(New Object() {"(Selecciona operación)", "+", "-", "*", "/"})
        c1.Location = New Point(103, 178)
        c1.Name = "c1"
        c1.Size = New Size(121, 23)
        c1.TabIndex = 3
        ' 
        ' T1
        ' 
        T1.ForeColor = SystemColors.Menu
        T1.Location = New Point(103, 112)
        T1.Name = "T1"
        T1.Size = New Size(100, 23)
        T1.TabIndex = 4
        ' 
        ' T2
        ' 
        T2.Location = New Point(103, 137)
        T2.Name = "T2"
        T2.Size = New Size(100, 23)
        T2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(113, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 6
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.rata
        PictureBox1.Location = New Point(12, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(293, 91)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDarkDark
        ClientSize = New Size(314, 353)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(T2)
        Controls.Add(T1)
        Controls.Add(c1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form3"
        Text = "Calculadorax"
        TransparencyKey = Color.White
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents c1 As ComboBox
    Friend WithEvents T1 As TextBox
    Friend WithEvents T2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
