Public Class StandardRolls
    Implements IEnumerable


    '
    ' Den här borde kanske implementera IEnumerable för att blien bra lista???
    '
    '
    ' Fält
    Private m_standardRolls As New List(Of StandardRoll)

    ' Egenskaper


    ' Konstruktor

    ' Metoder

    Public Function GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator

    End Function

    Private Class StandardRollEnumerator
        Implements IEnumerator

        Public ReadOnly Property Current As Object Implements IEnumerator.Current
            Get

            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext

        End Function

        Public Sub Reset() Implements IEnumerator.Reset

        End Sub
    End Class

End Class
