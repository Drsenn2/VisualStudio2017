'Program Name:  Decking Cost Calculator
'Author:        Don "Rick" Senn
'Date:          10/20/2023
'Purpose:       This application will allow a user to choose between three
'               different types of wood for a deck, enter in their square footage,
'               and generate a quote for the cost of a wood deck.

Public Class frmDecking
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'When you click on this button, the event handler calculates the cost of a 
        'deck based on the square footage entered and the type of wood selected

        Dim decFootage As Decimal
        Dim decCostPerSquareFoot As Decimal
        Dim decCostEstimate As Decimal
        Dim decLumberCost As Decimal = 2.35D
        Dim decRedwoodCost As Decimal = 7.75D
        Dim decCompositeCost As Decimal = 8.5D

        'Testing for numeric value
        If IsNumeric(txtFootage.Text) Then
            decFootage = Convert.ToDecimal(txtFootage.Text)
            If decFootage > 0 Then
                'Determining cost per sq foot based on item checked
                If radLumber.Checked Then
                    decCostPerSquareFoot = decLumberCost
                ElseIf radRedwood.Checked Then
                    decCostPerSquareFoot = decRedwoodCost
                ElseIf radComposite.Checked Then
                    decCostPerSquareFoot = decCompositeCost
                End If
                'calculate/display estimate
                decCostEstimate = decFootage * decCostPerSquareFoot
                lblCostEstimate.Text = decCostEstimate.ToString("C")
            Else
                'Error Message for a negative number
                MsgBox("You entered " & decFootage.ToString() & ". Enter a Positive Number", , "Input Error")
                txtFootage.Text = ""
                txtFootage.Focus()
            End If
        Else
            'Error Message for a nonnumeric value
            MsgBox("Enter the Square Footage of Decking", , "Input Error")
            txtFootage.Text = ""
            txtFootage.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event happens when a user clicks the clear button.  It clears out the square footage and the cost estimate.
        'It should reset the radio buttons and set the focus on the sq foot text box

        txtFootage.Clear()
        lblCostEstimate.Text = ""
        radLumber.Checked = True
        radRedwood.Checked = False
        radComposite.Checked = False
        txtFootage.Focus()
    End Sub

    Private Sub frmDecking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This executes when the form is loaded.  It sets the focus to the square footage text box and clears out the estimate

        txtFootage.Focus()
        lblCostEstimate.Text = ""
    End Sub
End Class
