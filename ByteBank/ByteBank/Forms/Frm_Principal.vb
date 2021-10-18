
Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Principal"
        Lbl_Principal.Text = "Principal"
        Btm_Click.Text = "Clique aqui"
        Btm_TesteHeranca.Text = "Clique aqui para testar herança"
        Btm_ClasseBase.Text = "Executa exemplo classe Base"
        Btm_Aumento.Text = "Aumento Salarial"


    End Sub

    Private Sub Btm_Click_Click(sender As Object, e As EventArgs) Handles Btm_Click.Click

        Dim gerenciadorBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Gerente("543.445.434-00", 10000)
        Carlos.nome = "Carlos Antônio"

        gerenciadorBonificacao.Registrar(Carlos)

        Dim Bia As New Diretor("522.476.980-12", 20000)
        Bia.nome = "Beatriz Regina"

        gerenciadorBonificacao.Registrar(Bia)


        MsgBox("O salário do " + Carlos.nome + " é " + Carlos.salario.ToString)
        MsgBox("A bonificação de " + Carlos.nome + " será de  " + Carlos.GetBonificacao().ToString)

        MsgBox("O salário da " + Bia.nome + " é " + Bia.salario.ToString)
        MsgBox("A bonificação da " + Bia.nome + " será de  " + Bia.GetBonificacao().ToString)

        Dim totalBonificacao As Double
        totalBonificacao += Carlos.GetBonificacao
        totalBonificacao += Bia.GetBonificacao
        MsgBox("O valor total de bonificação a ser pago será de " + totalBonificacao.ToString +
               " o valor calculado pela biblioteca foi de " + gerenciadorBonificacao.getBonificacao.ToString)


    End Sub

    Private Sub Btm_TesteHeranca_Click(sender As Object, e As EventArgs) Handles Btm_TesteHeranca.Click

        'Dim vFuncionario As New Funcionario("111.111.111-04", 10000)
        'Dim vDiretorFuncionario As New Funcionario("111.112.111-04", 10000)

        'MsgBox("O número de funcionarios atualmente instanciados são de " + Funcionario.TotalDeFuncionario().ToString)

        'Dim vDiretor As New Diretor("111.116.111-04", 10000)

        'MsgBox("O número de funcionarios e diretores atualmente instanciados são de " + Funcionario.TotalDeFuncionario().ToString)

        'Dim vGerente As New Gerente("111.116.118-04", 10000)

        'MsgBox("O número de funcionarios, diretores e gerentes atualmente instanciados são de " + Funcionario.TotalDeFuncionario().ToString)

        'Dim vTexto As String
        'vTexto = "O CPF dos funcionarios são " + vFuncionario.cpf + " e " + vDiretorFuncionario.cpf + vbCrLf
        'vTexto += "O CPF do diretor é " + vDiretor.cpf + vbCrLf
        'vTexto += "O CPF do gerente é " + vGerente.cpf + vbCrLf

        'MsgBox(vTexto)

        'vDiretorFuncionario = vDiretor

        'Dim vSaida As String = ""

        'vSaida = "A bonificacao de vDiretor é " + vDiretor.GetBonificacao().ToString + vbCrLf
        'vSaida += "A bonificacao de vFuncionario é " + vFuncionario.GetBonificacao().ToString + vbCrLf
        'vSaida += "A bonificacao de vDiretorFuncionario é " + vDiretorFuncionario.GetBonificacao().ToString + vbCrLf

        'MsgBox(vSaida)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btm_ClasseBase.Click

        Dim vDiretor As New Diretor("123.456.444-04", 10000)
        MsgBox("A bonificação do diretor é: " + vDiretor.GetBonificacao().ToString)

    End Sub

    Private Sub Btm_Aumento_Click(sender As Object, e As EventArgs) Handles Btm_Aumento.Click

        'Dim vFuncionario As New Funcionario("123.123.123-56", 1000)
        'Dim vDiretor As New Diretor("123.123.444-56", 3000)
        'Dim vGerente As New Gerente("123.444.123-56", 2000)

        'Dim vTexto As String = ""
        'vTexto = "O salário do funcionario é : " + vFuncionario.salario.ToString + vbCrLf
        'vTexto += "O salário do gerente é : " + vGerente.salario.ToString + vbCrLf
        'vTexto += "O salário do diretor é : " + vDiretor.salario.ToString + vbCrLf

        'MsgBox(vTexto)

        'vFuncionario.AumentarSalario()
        'vGerente.AumentarSalario()
        'vDiretor.AumentarSalario()

        'vTexto = "O salário do funcionario é : " + vFuncionario.salario.ToString + vbCrLf
        'vTexto += "O salário do gerente é : " + vGerente.salario.ToString + vbCrLf
        'vTexto += "O salário do diretor é : " + vDiretor.salario.ToString + vbCrLf
        'MsgBox(vTexto)


    End Sub
End Class



