'Project Name:  Spring Break Practice
'Author:        Rick Senn
'Date:          10/21/2023
'Purpose:       To try and put together things that I've already learned without having a guidebook next to me. This project should allow a 
'               person to choose one of three different vacation packages.  These packages will then ask for a number of days and provide
'               an estimate based on the package chosen and the number of days.

Option Strict On
Public Class frmSprBrkPractice
    Private Sub radBeach_CheckedChanged(sender As Object, e As EventArgs) Handles radBeach.CheckedChanged
        'When a user clicks on this event, it should make the beach image visible.  It should make the beach cost label visible, and it should
        'clear out the Mountain and City labels and pictures.

        picBeach.Visible = True
        lblBeachCost.Visible = True
        picMountains.Visible = False
        lblMountainCost.Visible = False
        picCity.Visible = False
        lblCityCost.Visible = False
        lblTotalCost.Text = ""
        txtNumberOfDays.Clear()
        txtNumberOfDays.Focus()
    End Sub

    Private Sub radMountain_CheckedChanged(sender As Object, e As EventArgs) Handles radMountain.CheckedChanged
        'When a user clicks on this event, it should make the mountain image visible.  It should make the mountain label visible, and it should
        'make the beach and city pictures and labels not visible.  It also puts the focus on the number of days field.

        picMountains.Visible = True
        lblMountainCost.Visible = True
        picBeach.Visible = False
        lblBeachCost.Visible = False
        picCity.Visible = False
        lblCityCost.Visible = False
        lblTotalCost.Text = ""
        txtNumberOfDays.Clear()
        txtNumberOfDays.Focus()

    End Sub

    Private Sub radCity_CheckedChanged(sender As Object, e As EventArgs) Handles radCity.CheckedChanged
        'When a user clicks on this event, it should make the City image and city label visible.  It should make the beach and mountain
        'labels and pictures not visible, and should place the focus on the number of days field.

        picCity.Visible = True
        lblCityCost.Visible = True
        picBeach.Visible = False
        lblBeachCost.Visible = False
        picMountains.Visible = False
        lblMountainCost.Visible = False
        lblTotalCost.Text = ""
        txtNumberOfDays.Clear()
        txtNumberOfDays.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'When this event is executed, the following should happen: Estimate for vacation is calculated based on the rad button chosen.
        'This should also contain error messages if people choose negative numbers or nonnumeric values

        'Declarations
        Dim intNumberOfDays As Integer  'Number of Days
        Dim intCostPerDay As Integer    'Cost Per Day
        Dim intCostEstimate As Integer  'Cost Estimate Field
        Dim intBeachCost As Integer = 99
        Dim intMountainCost As Integer = 89
        Dim intCityCost As Integer = 119

        'Check for Numeric Value
        If IsNumeric(txtNumberOfDays.Text) Then
            intNumberOfDays = Convert.ToInt32(txtNumberOfDays.Text)
            'Now that we have a number, lets make sure it's a positive one
            If intNumberOfDays > 0 Then
                'Determine Cost
                If radBeach.Checked Then
                    intCostPerDay = intBeachCost
                ElseIf radMountain.Checked Then
                    intCostPerDay = intMountainCost
                ElseIf radCity.Checked Then
                    intCostPerDay = intCityCost
                End If
                intCostEstimate = intNumberOfDays * intCostPerDay
                lblTotalCost.Text = intCostEstimate.ToString("C")
            Else
                'Display Error Message if a negative number
                MsgBox("You have entered " & intNumberOfDays.ToString() & ". Please enter a positive number", , "Input Error")
                txtNumberOfDays.Text = ""
                txtNumberOfDays.Focus()
            End If
        Else
            'Display Error message if Nonnumeric Value.
            'Reset Number Of Days and Focus
            MsgBox("Please enter the number of days for your vacation", , "Input Error")
            txtNumberOfDays.Text = ""
            txtNumberOfDays.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'When this event is activated, it will clear out the previous number of days field and reset the focus

        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        radBeach.Checked = True
        radMountain.Checked = False
        radCity.Checked = False
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'When this event is executed, it should close the program

        Close()
    End Sub

    Private Sub frmSprBrkPractice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When this is loaded, the application should set the focus to th Number of Days text box and clear the Cost Estimate box

        txtNumberOfDays.Focus()
        lblTotalCost.Text = ""
    End Sub
End Class
