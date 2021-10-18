Imports AutenticacaoByteBank.Classes.Bibliotecas
Imports AutenticacaoByteBank.Classes.Externos
Imports AutenticacaoByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Autenticação ByteBank"
        Lbl_Principal.Text = "Autenticação ByteBank"
        Btm_Autentica.Text = "Autentica"
        Btm_Autentica2.Text = "Autentica com Representante"

    End Sub

    Private Sub Btm_Autentica_Click(sender As Object, e As EventArgs) Handles Btm_Autentica.Click

        Dim Pedro As New Diretor("123.123.123-00", 2000)
        Pedro.senha = "abc"

        Dim Alberto As New Gerente("123.123.123-00", 2000)
        Alberto.senha = "999"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno

        vLoga = SistemaInterno.Logar(Pedro, "abc")
        MsgBox("A tentativa de logar no sistema resultou em " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(Alberto, "999")
        MsgBox("A tentativa de logar no sistema resultou em " + vLoga.ToString)


    End Sub

    Private Sub Btm_Autentica2_Click(sender As Object, e As EventArgs) Handles Btm_Autentica2.Click

        Dim Pedro As New Diretor("123.123.123-00", 2000)
        Pedro.senha = "abcefgjh"

        Dim Alberto As New Representante()
        Alberto.senha = "abcefgjhijklmnopq"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno

        vLoga = SistemaInterno.Logar(Pedro, "abcefgjh")
        MsgBox("A tentativa de logar no sistema (Funcionario) resultou em " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(Alberto, "abcefgjhijklmnopq")
        MsgBox("A tentativa de logar no sistema (Representante) resultou em " + vLoga.ToString)


    End Sub
End Class
