<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenMicNight
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
        Me.picCafeMic = New System.Windows.Forms.PictureBox()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMoreInfo = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        CType(Me.picCafeMic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Copperplate Gothic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblHeading.Location = New System.Drawing.Point(202, 18)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(315, 62)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Campus Music Cafe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Open Mic Night"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picCafeMic
        '
        Me.picCafeMic.Image = Global.Open_Mic_Night.My.Resources.Resources.open_mic_6
        Me.picCafeMic.Location = New System.Drawing.Point(127, 87)
        Me.picCafeMic.Name = "picCafeMic"
        Me.picCafeMic.Size = New System.Drawing.Size(465, 208)
        Me.picCafeMic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCafeMic.TabIndex = 1
        Me.picCafeMic.TabStop = False
        '
        'btnInfo
        '
        Me.btnInfo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnInfo.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnInfo.Location = New System.Drawing.Point(306, 338)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(107, 37)
        Me.btnInfo.TabIndex = 2
        Me.btnInfo.Text = "More Info"
        Me.btnInfo.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnExit.Location = New System.Drawing.Point(306, 483)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 37)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        Me.btnExit.Visible = False
        '
        'lblMoreInfo
        '
        Me.lblMoreInfo.AutoSize = True
        Me.lblMoreInfo.Font = New System.Drawing.Font("Copperplate Gothic Bold", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoreInfo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblMoreInfo.Location = New System.Drawing.Point(83, 390)
        Me.lblMoreInfo.Name = "lblMoreInfo"
        Me.lblMoreInfo.Size = New System.Drawing.Size(556, 75)
        Me.lblMoreInfo.TabIndex = 4
        Me.lblMoreInfo.Text = "October 30, 2018" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Open ""Mic""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Start Time: 8:00 PM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more information, view t" &
    "he Campus Music Cafe's Facebook page." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblMoreInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblMoreInfo.Visible = False
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Copperplate Gothic Bold", 10.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblWelcome.Location = New System.Drawing.Point(202, 301)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(314, 19)
        Me.lblWelcome.TabIndex = 5
        Me.lblWelcome.Text = "All College Students Welcome" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'OpenMicNight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(719, 532)
        Me.Controls.Add(Me.lblWelcome)
        Me.Controls.Add(Me.lblMoreInfo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.picCafeMic)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "OpenMicNight"
        Me.Text = "Open Mic Night"
        CType(Me.picCafeMic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picCafeMic As PictureBox
    Friend WithEvents btnInfo As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMoreInfo As Label
    Friend WithEvents lblWelcome As Label
End Class
