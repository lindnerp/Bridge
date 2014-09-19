Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strNameGuess As String = Me.txtName.Text
        Dim strQuestGuess As String = Me.txtQuest.Text
        Dim strColorGuess As String = Me.txtColor.Text
        Dim strName As String = "Pitcher"
        Dim strQuest As String = "Seek the Grail"
        Dim strColor As String = "Green"

        If strNameGuess <> strName Then
            Me.lblResult.Text = "You die."
        ElseIf strQuestGuess <> strQuest Then
            Me.lblResult.Text = "You die."
        ElseIf strColorGuess <> strColor Then
            Me.lblResult.Text = "You die."
        ElseIf strNameGuess = strName Then
            Me.lblResult.Text = "You may pass."
        ElseIf strQuestGuess = strQuest Then
            Me.lblResult.Text = "You may pass."
        ElseIf strColorGuess = strColor Then
            Me.lblResult.Text = "You may pass."

        End If
    End Sub
End Class
