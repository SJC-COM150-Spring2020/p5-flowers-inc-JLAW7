'Main form, first button added to allow user to take quiz

Public Class frmInc
    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click

        frmQuiz.Show()

    End Sub

    'Second button added to allow user to build their bouquet

    Private Sub btnBouquet_Click(sender As Object, e As EventArgs) Handles btnBouquet.Click

        frmBouquet.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Beep()
        Application.Exit()
    End Sub
End Class
