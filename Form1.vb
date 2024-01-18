Public Class Form1


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim grade As String
        grade = ComboBox1.Text

        Select Case grade
            Case "A"
            Case "A-"
                TextBox2.Text = "High Distinction"
                TextBox2.Text = "Distinction"
            Case "B"
            Case "C"
                TextBox2.Text = "Credit"
                TextBox2.Text = "Pass"
            Case "D"
            Case Else
                TextBox2.Text = "fail"
                TextBox2.Text = "Fail"

        End Select
    End Sub
End Class
