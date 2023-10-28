' Program Name:     Latte Selection
' Developer:        Don "Rick" Senn
' Date:             08/27/2023
' Purpose:          Introductory Lesson to teach VS basics.  This will allow for selection of a 
'                   choice of Pumpkin Spice or Mocha Latte.
Public Class frmLatteSelection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When this button is clicked, it closes the form and ends the program

        Close()
    End Sub

    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        ' This will allow you to choose a Pumpkin Spice Latte.  It will show the PSL picture, hide the Mocha
        ' latte picture if necessary, and allow for the Selection button to show.

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' This allows you to choose your latte.  It will disable the PSL button, the Mocha button, and 
        ' display the confirmation label as well as the Exit button.

        btnPumpkin.Enabled = False
        btnMocha.Enabled = False
        btnSelect.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        ' This will allow you to choose a Mocha Latte.  It will show the Mocha picture, hide the PSL
        ' latte picture if necessary, and allow for the Selection button to show.

        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True

    End Sub
End Class
