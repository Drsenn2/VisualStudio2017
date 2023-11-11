'Program:   Payroll Calculator
'Author:    Don "Rick" Senn
'Date:      10/12/2023
'Purpose:   This application calculates the tax rate from a gross dollar amount.  It will then display the tax rates as well as the net dollar amount.

Option Strict On
Public Class frmPayroll_Cal
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' This event is executed when a user enters in an Integer and clicks the Find $ button or presses Enter.
        ' It calculates and displays multiple tax rates as well as the net.

        Dim strGrossPay As String
        Dim dblGrossPay As Double
        Const _cdblFICATax As Double = 0.0765
        Const _cdblFedTax As Double = 0.22
        Const _cdblStateTax As Double = 0.04
        Dim dblFICA As Double
        Dim dblFed As Double
        Dim dblState As Double
        Dim dblNetTotal As Double

        strGrossPay = txtGrossPay.Text
        dblGrossPay = Convert.ToDouble(strGrossPay)
        dblFICA = dblGrossPay * _cdblFICATax
        dblFed = dblGrossPay * _cdblFedTax
        dblState = dblGrossPay * _cdblStateTax
        dblNetTotal = dblGrossPay - (dblFICA + dblFed + dblState)
        lblFICA.Text = dblFICA.ToString("C")
        lblFederalTax.Text = dblFed.ToString("C")
        lblStateTax.Text = dblState.ToString("C")
        lblNetResult.Text = dblNetTotal.ToString("C")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'When this button is clicked, it should clear out the Gross Pay and Net Pay text boxes
        'It should clear out the Federal, State, and FICA text boxes as well and sets the focus on txtGrossPay

        txtGrossPay.Clear()
        lblFICA.Text = ""
        lblFederalTax.Text = ""
        lblStateTax.Text = ""
        lblNetResult.Text = ""
        txtGrossPay.Focus()

    End Sub

    Private Sub frmPayroll_Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is what should happen when the form is loaded.  It should clear out the FICA, Federal, and State labels and set the focus on txtGrossPay.

        lblFICA.Text = ""
        lblFederalTax.Text = ""
        lblStateTax.Text = ""
        lblNetResult.Text = ""
        txtGrossPay.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the window and terminates the application

        Close()
    End Sub
End Class
