Namespace Classes.Funcionarios

    Public Class Gerente
        Inherits FuncionarioAutenticavel

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub

#End Region

#Region "MÉTODOS"
        Public Overrides Function GetBonificacao() As Double

            Return salario * 0.25

        End Function

        Public Overrides Sub AumentarSalario()

            salario = salario * 1.03

        End Sub

#End Region

    End Class

End Namespace


