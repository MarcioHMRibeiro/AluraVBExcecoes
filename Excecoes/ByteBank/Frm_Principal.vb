
Imports ByteBank.Classes

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Projeto ByteBank"
        Lbl_Principal.Text = "Projeto ByteBank"
        Lbl_Denominador.Text = "Digite o denominador:"


    End Sub

    Private Sub Video01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video01ToolStripMenuItem.Click

        Dim conta As New ContaCorrente(237, 117333)
        MsgBox("O número de contas correntes criadas são de " + ContaCorrente.TotalDeContasCriadas.ToString)
        MsgBox("O valor da taxa de operacões eatá em " + ContaCorrente.TaxaOperacao.ToString)

    End Sub

    Private Sub Video02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video02ToolStripMenuItem.Click
        Dim denominador As Integer = Val(Txt_Denominador.Text)
        Dim resposta As Integer = TestarDivisao(denominador)

        If resposta = -1 Then
            MsgBox("Não é possivel realizar a divisão")
        ElseIf Resposta = -2 Then
            MsgBox("Não é possivel dividir pois: denominador>numerador")
        Else
            MsgBox("O valor da divisão é: " + resposta.ToString)
        End If
    End Sub

    Function TestarDivisao(Valor As Integer)
        Dim Resultado As Integer = EfetuaDivisao(10, Valor)
        If Resultado = -1 Then
            Return -1
        ElseIf Resultado = -2 Then
            Return -2
        End If
        Return Resultado
    End Function
    Function EfetuaDivisao(numerador As Integer, denominador As Integer) As Integer

        If denominador <= 0 Then
            Return -1
        End If
        If denominador > numerador Then
            Return -2
        End If
        Return numerador / denominador
    End Function

    Private Sub Frm_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Video03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video03ToolStripMenuItem.Click
        Dim denominador As Integer = Val(Txt_Denominador.Text)
        Try
            TestarDivisao2(denominador)
        Catch ex As InvalidCastException
            MsgBox("Existe um erro no texto, falta o 'tostring'")
        Catch ex As OverflowException 'Se eu por EXCEPTION eu trato qualquer tipo de erro
            MsgBox("Não é possivel efetuar a divisão por 0")
        Catch ex As Exception
            MsgBox("Não é possivel efetuar a divisão")
        End Try
    End Sub
    Sub TestarDivisao2(Valor As Integer)
        '    Try
        Dim Resultado As Integer = EfetuaDivisao2(10, Valor)
        '        MsgBox("O valor da divisão é: " + Resultado.ToString)
        '    Catch ex As OverflowException 'Se eu por EXCEPTION eu trato qualquer tipo de erro
        '        MsgBox("Não é possivel efetuar a divisão")
        '    End Try
    End Sub

    Function EfetuaDivisao2(numerador As Integer, denominador As Integer) As Integer
        Try
            Return numerador / denominador
        Catch ex As OverflowException
            MsgBox("Tentamos dividir o numero " + numerador.ToString + " por " + denominador.ToString)
            Throw 'Comando para sair da função.
        End Try
    End Function
End Class
