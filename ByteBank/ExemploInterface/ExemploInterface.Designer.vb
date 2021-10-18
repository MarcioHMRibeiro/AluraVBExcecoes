<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExemploInterface
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Lbl_ExemploInterface = New System.Windows.Forms.Label()
        Me.Btm_ExemploInterface = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_ExemploInterface
        '
        Me.Lbl_ExemploInterface.AutoSize = True
        Me.Lbl_ExemploInterface.Location = New System.Drawing.Point(12, 18)
        Me.Lbl_ExemploInterface.Name = "Lbl_ExemploInterface"
        Me.Lbl_ExemploInterface.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ExemploInterface.TabIndex = 0
        Me.Lbl_ExemploInterface.Text = "Label1"
        '
        'Btm_ExemploInterface
        '
        Me.Btm_ExemploInterface.Location = New System.Drawing.Point(12, 54)
        Me.Btm_ExemploInterface.Name = "Btm_ExemploInterface"
        Me.Btm_ExemploInterface.Size = New System.Drawing.Size(152, 52)
        Me.Btm_ExemploInterface.TabIndex = 1
        Me.Btm_ExemploInterface.Text = "Button1"
        Me.Btm_ExemploInterface.UseVisualStyleBackColor = True
        '
        'ExemploInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 214)
        Me.Controls.Add(Me.Btm_ExemploInterface)
        Me.Controls.Add(Me.Lbl_ExemploInterface)
        Me.Name = "ExemploInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ExemploInterface As Label
    Friend WithEvents Btm_ExemploInterface As Button
End Class
