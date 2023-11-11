<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayroll_Cal
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
        Me.picMoney = New System.Windows.Forms.PictureBox()
        Me.lblGrossLabel = New System.Windows.Forms.Label()
        Me.lblFICALabel = New System.Windows.Forms.Label()
        Me.lblFedTaxLabel = New System.Windows.Forms.Label()
        Me.lblStateTaxLabel = New System.Windows.Forms.Label()
        Me.lblNetPayLabel = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetResult = New System.Windows.Forms.Label()
        CType(Me.picMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Bookman Old Style", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(134, 54)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(321, 40)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Payroll Calculator"
        '
        'lblHeadingInstructions
        '
        Me.lblHeadingInstructions.AutoSize = True
        Me.lblHeadingInstructions.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadingInstructions.Location = New System.Drawing.Point(42, 107)
        Me.lblHeadingInstructions.Name = "lblHeadingInstructions"
        Me.lblHeadingInstructions.Size = New System.Drawing.Size(521, 48)
        Me.lblHeadingInstructions.TabIndex = 1
        Me.lblHeadingInstructions.Text = "Enter your bi-weekly gross pay to determine your net pay" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'picMoney
        '
        Me.picMoney.Image = Global.Payroll_Calculator.My.Resources.Resources.third_stimulus_check_calculator_1400_payment
        Me.picMoney.Location = New System.Drawing.Point(0, 547)
        Me.picMoney.Name = "picMoney"
        Me.picMoney.Size = New System.Drawing.Size(605, 234)
        Me.picMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMoney.TabIndex = 2
        Me.picMoney.TabStop = False
        '
        'lblGrossLabel
        '
        Me.lblGrossLabel.AutoSize = True
        Me.lblGrossLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossLabel.Location = New System.Drawing.Point(180, 184)
        Me.lblGrossLabel.Name = "lblGrossLabel"
        Me.lblGrossLabel.Size = New System.Drawing.Size(110, 23)
        Me.lblGrossLabel.TabIndex = 3
        Me.lblGrossLabel.Text = "Gross Pay:"
        '
        'lblFICALabel
        '
        Me.lblFICALabel.AutoSize = True
        Me.lblFICALabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICALabel.Location = New System.Drawing.Point(180, 234)
        Me.lblFICALabel.Name = "lblFICALabel"
        Me.lblFICALabel.Size = New System.Drawing.Size(96, 23)
        Me.lblFICALabel.TabIndex = 4
        Me.lblFICALabel.Text = "FICA Tax:"
        '
        'lblFedTaxLabel
        '
        Me.lblFedTaxLabel.AutoSize = True
        Me.lblFedTaxLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTaxLabel.Location = New System.Drawing.Point(180, 285)
        Me.lblFedTaxLabel.Name = "lblFedTaxLabel"
        Me.lblFedTaxLabel.Size = New System.Drawing.Size(119, 23)
        Me.lblFedTaxLabel.TabIndex = 5
        Me.lblFedTaxLabel.Text = "Federal Tax:"
        '
        'lblStateTaxLabel
        '
        Me.lblStateTaxLabel.AutoSize = True
        Me.lblStateTaxLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTaxLabel.Location = New System.Drawing.Point(180, 337)
        Me.lblStateTaxLabel.Name = "lblStateTaxLabel"
        Me.lblStateTaxLabel.Size = New System.Drawing.Size(99, 23)
        Me.lblStateTaxLabel.TabIndex = 6
        Me.lblStateTaxLabel.Text = "State Tax:"
        '
        'lblNetPayLabel
        '
        Me.lblNetPayLabel.AutoSize = True
        Me.lblNetPayLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPayLabel.Location = New System.Drawing.Point(180, 388)
        Me.lblNetPayLabel.Name = "lblNetPayLabel"
        Me.lblNetPayLabel.Size = New System.Drawing.Size(86, 23)
        Me.lblNetPayLabel.TabIndex = 7
        Me.lblNetPayLabel.Text = "Net Pay:"
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Goldenrod
        Me.btnEnter.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(55, 453)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(118, 49)
        Me.btnEnter.TabIndex = 8
        Me.btnEnter.Text = "Find $"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Goldenrod
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(243, 453)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(118, 49)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Goldenrod
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(431, 453)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 49)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossPay.Location = New System.Drawing.Point(314, 181)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(110, 30)
        Me.txtGrossPay.TabIndex = 11
        Me.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICA.Location = New System.Drawing.Point(310, 234)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(115, 23)
        Me.lblFICA.TabIndex = 12
        Me.lblFICA.Text = "$888888.88"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(310, 285)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(115, 23)
        Me.lblFederalTax.TabIndex = 13
        Me.lblFederalTax.Text = "$888888.88"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(310, 337)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(115, 23)
        Me.lblStateTax.TabIndex = 14
        Me.lblStateTax.Text = "$888888.88"
        '
        'lblNetResult
        '
        Me.lblNetResult.AutoSize = True
        Me.lblNetResult.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetResult.Location = New System.Drawing.Point(310, 388)
        Me.lblNetResult.Name = "lblNetResult"
        Me.lblNetResult.Size = New System.Drawing.Size(115, 23)
        Me.lblNetResult.TabIndex = 15
        Me.lblNetResult.Text = "$888888.88"
        '
        'frmPayroll_Calculator
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(604, 782)
        Me.Controls.Add(Me.lblNetResult)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblNetPayLabel)
        Me.Controls.Add(Me.lblStateTaxLabel)
        Me.Controls.Add(Me.lblFedTaxLabel)
        Me.Controls.Add(Me.lblFICALabel)
        Me.Controls.Add(Me.lblGrossLabel)
        Me.Controls.Add(Me.picMoney)
        Me.Controls.Add(Me.lblHeadingInstructions)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPayroll_Calculator"
        Me.Text = "Payroll Calculator"
        CType(Me.picMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblHeadingInstructions As Label
    Friend WithEvents picMoney As PictureBox
    Friend WithEvents lblGrossLabel As Label
    Friend WithEvents lblFICALabel As Label
    Friend WithEvents lblFedTaxLabel As Label
    Friend WithEvents lblStateTaxLabel As Label
    Friend WithEvents lblNetPayLabel As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetResult As Label
End Class
