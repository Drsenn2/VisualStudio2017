'Program Name:  Fitness Challenge
'Author:        Don "Rick" Senn
'Date:          November 7, 2023
'Purpose:       This program is to show lists and loops.  The client should be given the opportunity to enter in 8 different weight loss
'               amounts and have the average totalled at the bottom of the screen.

Option Strict On
Public Class frmFitness
    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        ' This button shows the average weight loss of 8 different weight loss values.  It will then display that average at the bottom of the page.

        'declare and initialize variables
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D
        Dim strInputMessage As String = "Enter the weight loss for team member #"
        Dim strInputHeading As String = "Weight Loss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error = Enter a number for the weight loss of team member #"
        Dim strNegativeError As String = "Error - Enter a positive number for the weight loss of team member #"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'This loop allows the user to enter the weight loss of 8 people.  It ends when 8 values have been entered or when Cancel or Close have been chosen
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)
                If decWeightLoss > 0 Then
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'Calculates and displays the average weight loss
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss is " &
                decAverageLoss.ToString("F1") & "lbs"
        Else
            MsgBox("No weight loss value entered")
        End If

        'disables the button
        btnWeightLoss.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        'This Menu item clears out the listbox object and reenables the weight loss button.  It also makes the Average loss text non visible.

        lstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'This should close out the program

        Close()
    End Sub
End Class
