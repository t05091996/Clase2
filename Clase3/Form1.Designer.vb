<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        T1 = New TextBox()
        T2 = New TextBox()
        Button1 = New Button()
        c1 = New ComboBox()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.R
        PictureBox1.Location = New Point(24, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(215, 124)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 1
        Label1.Text = "Número 1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 2
        Label2.Text = "Número 2"
        ' 
        ' T1
        ' 
        T1.Location = New Point(103, 174)
        T1.Name = "T1"
        T1.Size = New Size(100, 23)
        T1.TabIndex = 3
        ' 
        ' T2
        ' 
        T2.Location = New Point(103, 215)
        T2.Name = "T2"
        T2.Size = New Size(100, 23)
        T2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(103, 309)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' c1
        ' 
        c1.FormattingEnabled = True
        c1.Items.AddRange(New Object() {"(Selecciona una operación)", "+", "-", "*", "/"})
        c1.Location = New Point(103, 268)
        c1.Name = "c1"
        c1.Size = New Size(100, 23)
        c1.TabIndex = 6
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(37, 358)
        Button2.Name = "Button2"
        Button2.Size = New Size(202, 23)
        Button2.TabIndex = 7
        Button2.Text = "Ir a otra ventana"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(275, 418)
        Controls.Add(Button2)
        Controls.Add(c1)
        Controls.Add(Button1)
        Controls.Add(T2)
        Controls.Add(T1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Calculadora"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents T1 As TextBox
    Friend WithEvents T2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents c1 As ComboBox
    Friend WithEvents Button2 As Button

End Class
