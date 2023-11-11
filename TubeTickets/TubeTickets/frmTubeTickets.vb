' Program Name: London Tube Tickets
' Author:       Don "Rick" Senn
' Date:         10/31/2023
' Purpose:      This application allows the user to select a tube pass and enter in a number of tickets needed.  It will then calculate the 
'               total in £ and $ based on the number of tickets entered and type of ticket selected.

'Option Strict not on so that we can convert from Dbl to Dec with the exchange rate
Public Class frmTubeTickets
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        'This button calculates the cost of tickets based on the number of tickets needed and the ticket type selected.
        'ENTER will also trigger the event

        'Declarations
        Dim decTicketNum As Decimal 'number of Tickets
        Dim decTicketPricePound As Decimal 'price of tickets £
        Dim dblConversionRate As Double = 1.21499 'pounds to dollar rate as of 10/31/2023 according to xe.com
        Dim decTicketTotalPound As Decimal 'total price £
        Dim decTicketTotalDollar As Decimal 'total price $
        Dim decZoneOneThree As Decimal = 4.9D 'zone1-3 price = 4.90
        Dim decZoneOneFive As Decimal = 5.9D 'zone1-5 price = 5.90
        Dim decZoneOneSix As Decimal = 6D 'zone 16 price = 6.00

        'Did User enter a numeric value?
        If IsNumeric(txtTicketNumber.Text) Then
            decTicketNum = Convert.ToDecimal(txtTicketNumber.Text)
            'Is this a positive number?
            If decTicketNum > 0 Then
                'determine the cost of the ticket
                If radZoneOneThree.Checked Then
                    decTicketPricePound = decZoneOneThree
                ElseIf radZoneOneFive.Checked Then
                    decTicketPricePound = decZoneOneFive
                ElseIf radZoneOneSix.Checked Then
                    decTicketPricePound = decZoneOneSix
                End If
                ' Calculate and display the cost of the tickets
                decTicketTotalPound = decTicketNum * decTicketPricePound
                decTicketTotalDollar = decTicketNum * (decTicketPricePound * dblConversionRate)
                lblPoundPrice.Text = decTicketTotalPound.ToString("C") 'I cannot find the method to display the £ symbol in the application.
                'There is probably a method online, but I can't find one in the book. - apologies
                lblDollarPrice.Text = decTicketTotalDollar.ToString("C")
            Else
                'Display if negative
                MsgBox("You entered " & decTicketNum.ToString() & ". Please enter a Positive Number", , "Input Error")
                txtTicketNumber.Text = ""
                txtTicketNumber.Focus()
            End If
        Else
            'Display error message for nonnumeric value
            MsgBox("Please Enter the Number of Tickets Needed", , "Input Error")
            txtTicketNumber.Text = ""
            txtTicketNumber.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event will clear out the text in the number of tickets text box, clear the price of the tickets in £ and $, and 
        'set the focus on the zone 1-3 radio button as well as the number of tickets text box.
        'ESC will also clear out the form
        txtTicketNumber.Clear()
        lblDollarPrice.Text = ""
        lblPoundPrice.Text = ""
        radZoneOneThree.Checked = True
        radZoneOneFive.Checked = False
        radZoneOneSix.Checked = False
        txtTicketNumber.Focus()

    End Sub

    Private Sub frmTubeTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event happens when the application is loaded.  It clears the 8s in the £ and $ text boxes and sets the focus on the tickets
        'text box.

        txtTicketNumber.Clear()
        txtTicketNumber.Focus()
        txtTicketNumber.Select()
        lblPoundPrice.Text = ""
        lblDollarPrice.Text = ""


    End Sub
End Class
