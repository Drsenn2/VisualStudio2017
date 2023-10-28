' Program:  Beach Bike Rentals
' Author:   Don "Rick" Senn
' Date:     9/23/2023
' Purpose:  This is to show us additional programming skills.  In this program,
'           a customer is to enter in a number of days and have it calculated into 
'           a rental cost estimate.

Option Strict On

Public Class frmBike

    ' Cost for the bike rental. This is a constant and should be kept global.
    Const _cdecPricePerDay As Decimal = 9.95D

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' When a user clicks on the Find Cost button, it should take the number entered and 
        ' calculate and display the cost base on the number of days and the cost per day.
        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This button should clear out the data when a use clicks on the Clear button.
        ' It should also set the focus on the txtNumberOfDays textbox

        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub frmBike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This should create and display the price per day in the lblCostHeading Label object
        ' This should also clear the Text property of the lblTotalCost Label object
        ' Set the focus to the txtNumberOfDays TextBox object

        lblCostHeading.Text = _cdecPricePerDay.ToString("C") & " per Day"
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This should close and exit the window

        Close()
    End Sub
End Class
