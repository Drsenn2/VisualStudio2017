' Program Name: Open Mic Night
' Developer: Don "Rick" Senn
' Date: 9/12/2023
' Purpose: This should show the Campus Music Cafe mic night information when a user clicks the Info button.
Public Class OpenMicNight

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        ' When a user clicks the Info button, the additional information should appear.
        ' The Close button should become visible and enabled, and the Info button should unenable.

        lblMoreInfo.Visible = True
        btnExit.Enabled = True
        btnExit.Visible = True
        btnInfo.Enabled = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' When this button is clicked, it should close the window and end the program

        Close()
    End Sub
End Class
