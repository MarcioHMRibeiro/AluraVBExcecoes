Namespace Classes.Externos

    Public Class Representante
        Implements IAutentica

#Region "PROPRIEDADES"
        Public Property senha As String

#End Region

#Region "MÉTODOS"

        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutentica.Autenticar
            If senhaTentativa.Length < 10 Then
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



