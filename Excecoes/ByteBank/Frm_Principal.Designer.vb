<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Aula01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Video01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Video02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Video03ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Lbl_Denominador = New System.Windows.Forms.Label()
        Me.AulaO2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Video04ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 24)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Aula01ToolStripMenuItem, Me.AulaO2ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(428, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Aula01ToolStripMenuItem
        '
        Me.Aula01ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Video01ToolStripMenuItem, Me.Video02ToolStripMenuItem, Me.Video03ToolStripMenuItem})
        Me.Aula01ToolStripMenuItem.Name = "Aula01ToolStripMenuItem"
        Me.Aula01ToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.Aula01ToolStripMenuItem.Text = "Aula 01"
        '
        'Video01ToolStripMenuItem
        '
        Me.Video01ToolStripMenuItem.Name = "Video01ToolStripMenuItem"
        Me.Video01ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Video01ToolStripMenuItem.Text = "Video 01"
        '
        'Video02ToolStripMenuItem
        '
        Me.Video02ToolStripMenuItem.Name = "Video02ToolStripMenuItem"
        Me.Video02ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Video02ToolStripMenuItem.Text = "Video 02"
        '
        'Video03ToolStripMenuItem
        '
        Me.Video03ToolStripMenuItem.Name = "Video03ToolStripMenuItem"
        Me.Video03ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Video03ToolStripMenuItem.Text = "Video 03"
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(15, 73)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Denominador.TabIndex = 2
        '
        'Lbl_Denominador
        '
        Me.Lbl_Denominador.AutoSize = True
        Me.Lbl_Denominador.Location = New System.Drawing.Point(12, 57)
        Me.Lbl_Denominador.Name = "Lbl_Denominador"
        Me.Lbl_Denominador.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Denominador.TabIndex = 3
        Me.Lbl_Denominador.Text = "Label1"
        '
        'AulaO2ToolStripMenuItem
        '
        Me.AulaO2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Video04ToolStripMenuItem})
        Me.AulaO2ToolStripMenuItem.Name = "AulaO2ToolStripMenuItem"
        Me.AulaO2ToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AulaO2ToolStripMenuItem.Text = "Aula o2"
        '
        'Video04ToolStripMenuItem
        '
        Me.Video04ToolStripMenuItem.Name = "Video04ToolStripMenuItem"
        Me.Video04ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.Video04ToolStripMenuItem.Text = "Video 04"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 268)
        Me.Controls.Add(Me.Lbl_Denominador)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Aula01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Video01ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Video02ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Lbl_Denominador As Label
    Friend WithEvents Video03ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AulaO2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Video04ToolStripMenuItem As ToolStripMenuItem
End Class
