Public Class Die

    ' Fält
    Private m_name As String
    Private m_max As Integer
    Private m_min As Integer
    Private m_result As Integer
    Shared rand As New Random()

    ' Egenskaper
    Public Property Name() As String
        Get
            Return m_name
        End Get
        Set(value As String)
            m_name = value
        End Set
    End Property

    Public Property Max() As Integer
        Get
            Return m_max
        End Get
        Set(value As Integer)
            If value > 0 Then
                m_max = value
            End If
        End Set
    End Property

    Public Property Min() As Integer
        Get
            Return m_min
        End Get
        Set(value As Integer)
            If value > 0 Then
                m_min = value
            End If
        End Set
    End Property

    Public ReadOnly Property Result() As Integer
        Get
            Return m_result
        End Get
    End Property


    ' Konstruktor
    Public Sub New(ByVal name As String, min As Integer, max As Integer)
        m_name = name
        m_min = min
        m_max = max
    End Sub

    ' Metoder
    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

    Public Function Roll() As Integer
        m_result = rand.Next(m_min, m_max)
        Return m_result
    End Function

End Class
