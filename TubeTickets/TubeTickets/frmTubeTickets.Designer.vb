<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTubeTickets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblHeadingInstructions = New System.Windows.Forms.Label()
        Me.grpZonePrices = New System.Windows.Forms.GroupBox()
        Me.radZoneOneThree = New System.Windows.Forms.RadioButton()
        Me.radZoneOneFive = New System.Windows.Forms.RadioButton()
        Me.radZoneOneSix = New System.Windows.Forms.RadioButton()
        Me.picTube = New System.Windows.Forms.PictureBox()
        Me.btnCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtTicketNumber = New System.Windows.Forms.TextBox()
        Me.lblNumberOfTickets = New System.Windows.Forms.Label()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblPound = New System.Windows.Forms.Label()
        Me.lblPoundPrice = New System.Windows.Forms.Label()
        Me.lblDollar = New System.Windows.Forms.Label()
        Me.lblDollarPrice = New System.Windows.Forms.Label()
        Me.grpZonePrices.SuspendLayout()
        CType(Me.picTube, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblHeading.Location = New System.Drawing.Point(198, 33)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(485, 48)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "London Tube Tickets"
        '
        'lblHeadingInstructions
        '
        Me.lblHeadingInstructions.AutoSize = True
        Me.lblHeadingInstructions.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingInstructions.ForeColor = System.Drawing.Color.Red
        Me.lblHeadingInstructions.Location = New System.Drawing.Point(291, 92)
        Me.lblHeadingInstructions.Name = "lblHeadingInstructions"
        Me.lblHeadingInstructions.Size = New System.Drawing.Size(299, 48)
        Me.lblHeadingInstructions.TabIndex = 1
        Me.lblHeadingInstructions.Text = "Prices will be converted to USD$" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblHeadingInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpZonePrices
        '
        Me.grpZonePrices.BackColor = System.Drawing.Color.White
        Me.grpZonePrices.Controls.Add(Me.radZoneOneSix)
        Me.grpZonePrices.Controls.Add(Me.radZoneOneFive)
        Me.grpZonePrices.Controls.Add(Me.radZoneOneThree)
        Me.grpZonePrices.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpZonePrices.ForeColor = System.Drawing.Color.MediumBlue
        Me.grpZonePrices.Location = New System.Drawing.Point(92, 233)
        Me.grpZonePrices.Name = "grpZonePrices"
        Me.grpZonePrices.Size = New System.Drawing.Size(300, 201)
        Me.grpZonePrices.TabIndex = 2
        Me.grpZonePrices.TabStop = False
        '
        'radZoneOneThree
        '
        Me.radZoneOneThree.AutoSize = True
        Me.radZoneOneThree.Checked = True
        Me.radZoneOneThree.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radZoneOneThree.ForeColor = System.Drawing.Color.MediumBlue
        Me.radZoneOneThree.Location = New System.Drawing.Point(38, 30)
        Me.radZoneOneThree.Name = "radZoneOneThree"
        Me.radZoneOneThree.Size = New System.Drawing.Size(224, 33)
        Me.radZoneOneThree.TabIndex = 0
        Me.radZoneOneThree.TabStop = True
        Me.radZoneOneThree.Text = "Zone 1-3: £4.90"
        Me.radZoneOneThree.UseVisualStyleBackColor = True
        '
        'radZoneOneFive
        '
        Me.radZoneOneFive.AutoSize = True
        Me.radZoneOneFive.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radZoneOneFive.ForeColor = System.Drawing.Color.MediumBlue
        Me.radZoneOneFive.Location = New System.Drawing.Point(38, 84)
        Me.radZoneOneFive.Name = "radZoneOneFive"
        Me.radZoneOneFive.Size = New System.Drawing.Size(224, 33)
        Me.radZoneOneFive.TabIndex = 1
        Me.radZoneOneFive.Text = "Zone 1-5: £5.90"
        Me.radZoneOneFive.UseVisualStyleBackColor = True
        '
        'radZoneOneSix
        '
        Me.radZoneOneSix.AutoSize = True
        Me.radZoneOneSix.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radZoneOneSix.ForeColor = System.Drawing.Color.MediumBlue
        Me.radZoneOneSix.Location = New System.Drawing.Point(38, 137)
        Me.radZoneOneSix.Name = "radZoneOneSix"
        Me.radZoneOneSix.Size = New System.Drawing.Size(224, 33)
        Me.radZoneOneSix.TabIndex = 2
        Me.radZoneOneSix.Text = "Zone 1-6: £6.00"
        Me.radZoneOneSix.UseVisualStyleBackColor = True
        '
        'picTube
        '
        Me.picTube.Image = Global.TubeTickets.My.Resources.Resources.Londontube
        Me.picTube.Location = New System.Drawing.Point(0, 544)
        Me.picTube.Name = "picTube"
        Me.picTube.Size = New System.Drawing.Size(882, 307)
        Me.picTube.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTube.TabIndex = 4
        Me.picTube.TabStop = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.LightGray
        Me.btnCost.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnCost.Location = New System.Drawing.Point(228, 455)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(185, 61)
        Me.btnCost.TabIndex = 5
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightGray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.MediumBlue
        Me.btnClear.Location = New System.Drawing.Point(467, 455)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(185, 61)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtTicketNumber
        '
        Me.txtTicketNumber.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTicketNumber.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtTicketNumber.Location = New System.Drawing.Point(718, 262)
        Me.txtTicketNumber.Name = "txtTicketNumber"
        Me.txtTicketNumber.Size = New System.Drawing.Size(53, 35)
        Me.txtTicketNumber.TabIndex = 7
        Me.txtTicketNumber.Text = "88"
        Me.txtTicketNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNumberOfTickets
        '
        Me.lblNumberOfTickets.AutoSize = True
        Me.lblNumberOfTickets.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfTickets.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblNumberOfTickets.Location = New System.Drawing.Point(466, 265)
        Me.lblNumberOfTickets.Name = "lblNumberOfTickets"
        Me.lblNumberOfTickets.Size = New System.Drawing.Size(241, 29)
        Me.lblNumberOfTickets.TabIndex = 8
        Me.lblNumberOfTickets.Text = "Number of Tickets:"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(53, 181)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(774, 29)
        Me.lblInstructions.TabIndex = 9
        Me.lblInstructions.Text = "1. Select the number of zones       2. Enter the number of tickets" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblPound
        '
        Me.lblPound.AutoSize = True
        Me.lblPound.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPound.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPound.Location = New System.Drawing.Point(466, 319)
        Me.lblPound.Name = "lblPound"
        Me.lblPound.Size = New System.Drawing.Size(127, 29)
        Me.lblPound.TabIndex = 10
        Me.lblPound.Text = "Total (£):"
        '
        'lblPoundPrice
        '
        Me.lblPoundPrice.AutoSize = True
        Me.lblPoundPrice.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoundPrice.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblPoundPrice.Location = New System.Drawing.Point(675, 319)
        Me.lblPoundPrice.Name = "lblPoundPrice"
        Me.lblPoundPrice.Size = New System.Drawing.Size(96, 29)
        Me.lblPoundPrice.TabIndex = 11
        Me.lblPoundPrice.Text = "888.88"
        Me.lblPoundPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDollar
        '
        Me.lblDollar.AutoSize = True
        Me.lblDollar.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollar.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblDollar.Location = New System.Drawing.Point(466, 372)
        Me.lblDollar.Name = "lblDollar"
        Me.lblDollar.Size = New System.Drawing.Size(127, 29)
        Me.lblDollar.TabIndex = 12
        Me.lblDollar.Text = "Total ($):"
        '
        'lblDollarPrice
        '
        Me.lblDollarPrice.AutoSize = True
        Me.lblDollarPrice.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollarPrice.ForeColor = System.Drawing.Color.MediumBlue
        Me.lblDollarPrice.Location = New System.Drawing.Point(675, 372)
        Me.lblDollarPrice.Name = "lblDollarPrice"
        Me.lblDollarPrice.Size = New System.Drawing.Size(96, 29)
        Me.lblDollarPrice.TabIndex = 13
        Me.lblDollarPrice.Text = "888.88"
        '
        'frmTubeTickets
        '
        Me.AcceptButton = Me.btnCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(881, 851)
        Me.Controls.Add(Me.lblDollarPrice)
        Me.Controls.Add(Me.lblDollar)
        Me.Controls.Add(Me.lblPoundPrice)
        Me.Controls.Add(Me.lblPound)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblNumberOfTickets)
        Me.Controls.Add(Me.txtTicketNumber)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.picTube)
        Me.Controls.Add(Me.grpZonePrices)
        Me.Controls.Add(Me.lblHeadingInstructions)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmTubeTickets"
        Me.Text = "London Tube Tickets"
        Me.grpZonePrices.ResumeLayout(False)
        Me.grpZonePrices.PerformLayout()
        CType(Me.picTube, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblHeadingInstructions As Label
    Friend WithEvents grpZonePrices As GroupBox
    Friend WithEvents radZoneOneSix As RadioButton
    Friend WithEvents radZoneOneFive As RadioButton
    Friend WithEvents radZoneOneThree As RadioButton
    Friend WithEvents picTube As PictureBox
    Friend WithEvents btnCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTicketNumber As TextBox
    Friend WithEvents lblNumberOfTickets As Label
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblPound As Label
    Friend WithEvents lblPoundPrice As Label
    Friend WithEvents lblDollar As Label
    Friend WithEvents lblDollarPrice As Label
End Class
