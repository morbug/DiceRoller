Public MustInherit Class DiceRoll
    ' Fält
    Private m_name As String
    Private m_dice As New List(Of Die)
    Private m_modifiers As New List(Of Modification)
    Private m_result As Integer

    ' Egenskaper
    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property


    Public Property Dice() As List(Of Die)
        Get
            Return m_dice
        End Get
        Set(value As List(Of Die))
            m_dice = value
        End Set
    End Property

    Public Property Modifiers() As List(Of Modification)
        Get
            Return m_modifiers
        End Get
        Set(value As List(Of Modification))
            m_modifiers = value
        End Set
    End Property

    ' Konstruktor
    Public Sub New()
        m_name = ""
        m_dice = Nothing
        m_modifiers = Nothing
        m_result = 0
    End Sub

    Public Sub New(name As String)
        m_name = name
        m_dice = Nothing
        m_modifiers = Nothing
        m_result = 0
    End Sub

    ' Metoder
    Public Function Roll() As Integer
        ' Slå tärningarna som finns i listan och summera dessa

        Dim totalResult As Integer = 0

        If m_dice.Count > 0 Then
            For Each rolledDie As Die In m_dice
                totalResult += rolledDie.Roll()
            Next
        End If

        m_result = totalResult
        Return totalResult

    End Function

End Class
