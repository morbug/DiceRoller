Public Class MainForm

    Private Sub rollD6_Click(sender As Object, e As EventArgs) Handles rollD6.Click
        Dim d6 As Die = New Die("d6", 1, 6)

        MessageBox.Show(String.Format("You rolled '{0}' and got the result: {1}", d6.Name, d6.Roll))

    End Sub

    Private Sub roll3d6_Click(sender As Object, e As EventArgs) Handles roll3d6.Click
        Dim ThreeDSix As StandardRoll = New StandardRoll("3d6")
        Dim d1 As Die = New Die("d6", 1, 6)
        Dim d2 As Die = New Die("d6", 1, 6)
        Dim d3 As Die = New Die("d6", 1, 6)
        Dim dieList As List(Of Die) = New List(Of Die)

        dieList.Add(d1)
        dieList.Add(d2)
        dieList.Add(d3)

        ThreeDSix.Dice = dieList

        MessageBox.Show(String.Format("You rolled '{0}' and got the result: {1}", ThreeDSix.Name, ThreeDSix.Roll))

    End Sub
End Class
