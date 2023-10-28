<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSprBrkPractice
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
        Me.grpVacationSelect = New System.Windows.Forms.GroupBox()
        Me.radBeach = New System.Windows.Forms.RadioButton()
        Me.radMountain = New System.Windows.Forms.RadioButton()
        Me.radCity = New System.Windows.Forms.RadioButton()
        Me.lblBeachCost = New System.Windows.Forms.Label()
        Me.lblMountainCost = New System.Windows.Forms.Label()
        Me.lblCityCost = New System.Windows.Forms.Label()
        Me.lblNumberOfDays = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picCity = New System.Windows.Forms.PictureBox()
        Me.picBeach = New System.Windows.Forms.PictureBox()
        Me.picMountains = New System.Windows.Forms.PictureBox()
        Me.grpVacationSelect.SuspendLayout()
        CType(Me.picCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMountains, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.IndianRed
        Me.lblHeading.Location = New System.Drawing.Point(270, 20)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(319, 49)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Spring Break 2024"
        '
        'grpVacationSelect
        '
        Me.grpVacationSelect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.grpVacationSelect.Controls.Add(Me.radCity)
        Me.grpVacationSelect.Controls.Add(Me.radMountain)
        Me.grpVacationSelect.Controls.Add(Me.radBeach)
        Me.grpVacationSelect.Controls.Add(Me.lblCityCost)
        Me.grpVacationSelect.Controls.Add(Me.lblMountainCost)
        Me.grpVacationSelect.Controls.Add(Me.lblBeachCost)
        Me.grpVacationSelect.Location = New System.Drawing.Point(56, 88)
        Me.grpVacationSelect.Name = "grpVacationSelect"
        Me.grpVacationSelect.Size = New System.Drawing.Size(746, 81)
        Me.grpVacationSelect.TabIndex = 1
        Me.grpVacationSelect.TabStop = False
        '
        'radBeach
        '
        Me.radBeach.AutoSize = True
        Me.radBeach.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBeach.Location = New System.Drawing.Point(78, 21)
        Me.radBeach.Name = "radBeach"
        Me.radBeach.Size = New System.Drawing.Size(171, 38)
        Me.radBeach.TabIndex = 0
        Me.radBeach.TabStop = True
        Me.radBeach.Text = "The Beach"
        Me.radBeach.UseVisualStyleBackColor = True
        '
        'radMountain
        '
        Me.radMountain.AutoSize = True
        Me.radMountain.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMountain.Location = New System.Drawing.Point(277, 21)
        Me.radMountain.Name = "radMountain"
        Me.radMountain.Size = New System.Drawing.Size(220, 38)
        Me.radMountain.TabIndex = 1
        Me.radMountain.TabStop = True
        Me.radMountain.Text = "The Mountains"
        Me.radMountain.UseVisualStyleBackColor = True
        '
        'radCity
        '
        Me.radCity.AutoSize = True
        Me.radCity.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radCity.Location = New System.Drawing.Point(525, 21)
        Me.radCity.Name = "radCity"
        Me.radCity.Size = New System.Drawing.Size(144, 38)
        Me.radCity.TabIndex = 2
        Me.radCity.TabStop = True
        Me.radCity.Text = "The City"
        Me.radCity.UseVisualStyleBackColor = True
        '
        'lblBeachCost
        '
        Me.lblBeachCost.AutoSize = True
        Me.lblBeachCost.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeachCost.ForeColor = System.Drawing.Color.Firebrick
        Me.lblBeachCost.Location = New System.Drawing.Point(135, 56)
        Me.lblBeachCost.Name = "lblBeachCost"
        Me.lblBeachCost.Size = New System.Drawing.Size(81, 24)
        Me.lblBeachCost.TabIndex = 2
        Me.lblBeachCost.Text = "$99/Day"
        Me.lblBeachCost.Visible = False
        '
        'lblMountainCost
        '
        Me.lblMountainCost.AutoSize = True
        Me.lblMountainCost.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMountainCost.ForeColor = System.Drawing.Color.Firebrick
        Me.lblMountainCost.Location = New System.Drawing.Point(369, 56)
        Me.lblMountainCost.Name = "lblMountainCost"
        Me.lblMountainCost.Size = New System.Drawing.Size(81, 24)
        Me.lblMountainCost.TabIndex = 3
        Me.lblMountainCost.Text = "$89/Day"
        Me.lblMountainCost.Visible = False
        '
        'lblCityCost
        '
        Me.lblCityCost.AutoSize = True
        Me.lblCityCost.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCityCost.ForeColor = System.Drawing.Color.Firebrick
        Me.lblCityCost.Location = New System.Drawing.Point(563, 56)
        Me.lblCityCost.Name = "lblCityCost"
        Me.lblCityCost.Size = New System.Drawing.Size(91, 24)
        Me.lblCityCost.TabIndex = 4
        Me.lblCityCost.Text = "$119/Day"
        Me.lblCityCost.Visible = False
        '
        'lblNumberOfDays
        '
        Me.lblNumberOfDays.AutoSize = True
        Me.lblNumberOfDays.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfDays.Location = New System.Drawing.Point(257, 388)
        Me.lblNumberOfDays.Name = "lblNumberOfDays"
        Me.lblNumberOfDays.Size = New System.Drawing.Size(227, 34)
        Me.lblNumberOfDays.TabIndex = 8
        Me.lblNumberOfDays.Text = "Number Of Days:"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumberOfDays.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfDays.Location = New System.Drawing.Point(521, 381)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(80, 41)
        Me.txtNumberOfDays.TabIndex = 9
        Me.txtNumberOfDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(268, 539)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(146, 34)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total Due:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Ink Free", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(432, 539)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(158, 34)
        Me.lblTotalCost.TabIndex = 11
        Me.lblTotalCost.Text = "$8888.88"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCalculate.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.Firebrick
        Me.btnCalculate.Location = New System.Drawing.Point(148, 457)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(154, 52)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate $"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Firebrick
        Me.btnClear.Location = New System.Drawing.Point(352, 460)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 52)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Firebrick
        Me.btnExit.Location = New System.Drawing.Point(556, 457)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(154, 52)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picCity
        '
        Me.picCity.Image = Global.SprBrkPractice.My.Resources.Resources.City
        Me.picCity.Location = New System.Drawing.Point(59, 171)
        Me.picCity.Name = "picCity"
        Me.picCity.Size = New System.Drawing.Size(742, 197)
        Me.picCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCity.TabIndex = 7
        Me.picCity.TabStop = False
        Me.picCity.Visible = False
        '
        'picBeach
        '
        Me.picBeach.Image = Global.SprBrkPractice.My.Resources.Resources.beach
        Me.picBeach.Location = New System.Drawing.Point(59, 171)
        Me.picBeach.Name = "picBeach"
        Me.picBeach.Size = New System.Drawing.Size(742, 197)
        Me.picBeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBeach.TabIndex = 5
        Me.picBeach.TabStop = False
        Me.picBeach.Visible = False
        '
        'picMountains
        '
        Me.picMountains.Image = Global.SprBrkPractice.My.Resources.Resources.Everest_North_Face_toward_Base_Camp_Tibet_Luca_Galuzzi_2006
        Me.picMountains.Location = New System.Drawing.Point(59, 171)
        Me.picMountains.Name = "picMountains"
        Me.picMountains.Size = New System.Drawing.Size(742, 197)
        Me.picMountains.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMountains.TabIndex = 6
        Me.picMountains.TabStop = False
        Me.picMountains.Visible = False
        '
        'frmSprBrkPractice
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(859, 634)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumberOfDays)
        Me.Controls.Add(Me.grpVacationSelect)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.picMountains)
        Me.Controls.Add(Me.picCity)
        Me.Controls.Add(Me.picBeach)
        Me.Name = "frmSprBrkPractice"
        Me.Text = "Spring Break Practice"
        Me.grpVacationSelect.ResumeLayout(False)
        Me.grpVacationSelect.PerformLayout()
        CType(Me.picCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMountains, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents grpVacationSelect As GroupBox
    Friend WithEvents radCity As RadioButton
    Friend WithEvents radMountain As RadioButton
    Friend WithEvents radBeach As RadioButton
    Friend WithEvents lblBeachCost As Label
    Friend WithEvents lblMountainCost As Label
    Friend WithEvents lblCityCost As Label
    Friend WithEvents picBeach As PictureBox
    Friend WithEvents picMountains As PictureBox
    Friend WithEvents picCity As PictureBox
    Friend WithEvents lblNumberOfDays As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
