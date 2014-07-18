Public Class MainForm

    Private Sub rollD6_Click(sender As Object, e As EventArgs) Handles rollD6.Click
        Dim d6 As Die = New Die("d6", 1, 6)

        MessageBox.Show(String.Format("You rolled '{0}' and got the result: {1}", d6.Name, d6.Roll))

    End Sub
End Class
