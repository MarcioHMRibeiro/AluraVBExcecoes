Namespace Classes

    Public Class ContaCorrente

#Region "PROPRIEDADES"
        'TITULAR - Propriedade
        Public Property titular As Cliente

        'NUMERO DA CONTA - Propriedade
        Public ReadOnly Property numero As Integer

        'TAXA DE OPERAÇÃO - Propriedade
        Private Shared m_TaxaOperacao As Integer
        Public Shared ReadOnly Property TaxaOperacao As Integer
            Get
                Return m_TaxaOperacao
            End Get
        End Property

        'TOTAL DE CONTAS CRIADAS - Propriedade
        Private Shared m_TotalDeContasCriadas As Integer
        Public Shared ReadOnly Property TotalDeContasCriadas As Integer
            Get
                Return m_TotalDeContasCriadas
            End Get
        End Property

        'AGENCIA DA CONTA (Se for menor que 0 fica 0, se for maior recebe o valor inserido)- Propriedade
        Public ReadOnly Property agencia As Integer

        'SALDO DA CONTA (Começa com 100, se for -0 fica como 0 e se for maior, recebe o valor inserido)- Propriedade
        Private m_saldo As Double = 100
        Public Property saldo As Double
            Get
                Return m_saldo
            End Get
            Set(value As Double)
                If value <= 0 Then
                    m_saldo = 0
                Else
                    m_saldo = value
                End If
            End Set
        End Property
#End Region

#Region "CONSTRUTORES"
        'CALCULO DA TAXA (Realiza o calculo da taxa e contabiliza quantas contas estão criadas no sistema)- Construtor
        Public Sub New(vAgencia As Integer, vNumero As Integer)

            If (vAgencia <= 0) And (vNumero <= 0) Then

                Dim vParametro As String
                vParametro = NameOf(vAgencia)

                Dim Erro As New ArgumentException("Agencia e Conta menor que 0!!", vParametro)
                Throw Erro

            ElseIf (vAgencia <= 0) Then
                Dim Erro As New Exception("Agencia menor que 0!!")
                Throw Erro

            ElseIf (vNumero <= 0) Then
                Dim Erro As New Exception("Conta menor que 0!!")
                Throw Erro
            End If

            vAgencia = vAgencia
            vNumero = vNumero
            m_TotalDeContasCriadas += 1
            m_TaxaOperacao = 30 / m_TotalDeContasCriadas

        End Sub
#End Region

#Region "MÉTODOS"
        'SACAR - Metodo
        Public Function Sacar(ValorSacado As Double) As Boolean
            Dim vRetorno As Boolean
            If m_saldo < ValorSacado Then
                vRetorno = False
            Else
                vRetorno = True
                m_saldo -= ValorSacado
            End If
            Return vRetorno
        End Function

        'DEPOSITAR - Metodo
        Public Sub Depositar(ValorDepositado As Double)
            m_saldo += ValorDepositado
        End Sub

        'TRANSFERIR (Valida se valortransferencia é maior que o saldo e se for ele desconta o valor da transferencia
        'do saldo e envia para o metodo DEPOSITAR- Metodo
        Public Function Transferir(ValorTransferencia As Double, ContaDestino As ContaCorrente) As Boolean
            Dim vRetorno As Boolean
            If m_saldo < ValorTransferencia Then
                vRetorno = False
            Else
                m_saldo -= ValorTransferencia
                ContaDestino.Depositar(ValorTransferencia)
                vRetorno = True
            End If
            Return vRetorno
        End Function
#End Region

    End Class
End Namespace



