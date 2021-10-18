
Namespace Classes.Funcionarios

    Public MustInherit Class FuncionarioAutenticavel
        Inherits Funcionario
        Implements IAutentica

#Region "PROPRIEDADES"
        Public Property senha As String

#End Region

#Region "CONSTRUTORES"

        Public Sub New(_cpf As String, _salario As Double)
            MyBase.New(_cpf, _salario)
        End Sub

#End Region

#Region "MÉTODOS"

        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutentica.Autenticar
            If senhaTentativa.Length < 5 Then
                Return False
            End If
            If senha = senhaTentativa Then
                Return True
            End If
            Return False

        End Function

#End Region

    End Class

End Namespace


